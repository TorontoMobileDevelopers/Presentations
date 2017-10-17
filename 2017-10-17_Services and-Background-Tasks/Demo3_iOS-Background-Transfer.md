# Demo 3 : iOS - Background Transfer
## Setup
Create Project
* Visual Studio for Mac
* File > New Solution
* iOS > App > Single View App > Next

Configure iOS App
* App Name: Background Transfer
* Org ID: com.tomobiledevs
* Team: Canadian Project Partners
* Devices: iPhone
* Target: iOS 10.3
 
Configure Single View App
* Keep defaults

## Task 1 - Implement Background Transfer
* Open Main.storyboard

* Open AppDelegate.cs
* Add the code (ensure to replace methods)
```cs
    public Action BackgroundSessionCompletionHandler { get; set; }

    public override void HandleEventsForBackgroundUrl (UIApplication application, string sessionIdentifier, Action completionHandler)
    {
        Console.WriteLine ("HandleEventsForBackgroundUrl");
        BackgroundSessionCompletionHandler = completionHandler;
    }
```

* Open ViewController.cs
* Add the code (ensure to replace ViewDidLoad method and the remainder of the class body)
```cs
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            if (Session == null)
                Session = InitBackgroundSession();

            // Perform any additional setup after loading the view, typically from a nib.
            progressView.Progress = 0;
            imageView.Hidden = false;
            progressView.Hidden = true;
        }

        const string Identifier = "com.tomobiledevs.BackgroundTransfer";
        const string DownloadUrlString = "https://upload.wikimedia.org/wikipedia/commons/9/97/The_Earth_seen_from_Apollo_17.jpg";

        public NSUrlSessionDownloadTask DownloadTask;
        public NSUrlSession Session;

        public UIProgressView ProgressView => progressView;

        public UIImageView ImageView => imageView;

        partial void StartButton_TouchUpInside(UIButton sender)
        {
            if (DownloadTask != null)
            {
                Console.Write("Download already started.");
                return;     
            }

            using (var url = NSUrl.FromString(DownloadUrlString))
            using (var request = NSUrlRequest.FromUrl(url))
            {
                DownloadTask = Session.CreateDownloadTask(request);
                DownloadTask.Resume();
            }

            imageView.Hidden = true;
            progressView.Hidden = false;
        }

        public NSUrlSession InitBackgroundSession()
        {
            Console.WriteLine("InitBackgroundSession");

            INSUrlSessionDelegate sessionDelegate = new UrlSessionDelegate(this);
            using (var configuration = NSUrlSessionConfiguration.CreateBackgroundSessionConfiguration(Identifier))
            {
                return NSUrlSession.FromConfiguration(configuration, sessionDelegate, null);
            }
        }
```

* Open UrlSessionDelegate.cs
* Replace the code
```cs
using System;
using Foundation;

namespace BackgroundTransfer
{
    public class UrlSessionDelegate : NSUrlSessionDownloadDelegate, INSUrlSessionDelegate
    {
        public ViewController Controller;

        public UrlSessionDelegate(ViewController controller)
        {
            Controller = controller;
        }

        public override void DidWriteData(NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long bytesWritten, long totalBytesWritten, long totalBytesExpectedToWrite)
        {
            Console.WriteLine("Set Progress");

            if (downloadTask != Controller.DownloadTask) return;

            float progress = totalBytesWritten / (float)totalBytesExpectedToWrite;
            Console.WriteLine($"DownloadTask: {downloadTask}  progress: {progress}");
            InvokeOnMainThread(() =>
            {
                Controller.ProgressView.Progress = progress;
            });
        }

        public override void DidFinishDownloading(NSUrlSession session, NSUrlSessionDownloadTask downloadTask, NSUrl location)
        {
            Console.WriteLine("Finished");
            Console.WriteLine("File downloaded in : {0}", location);
            NSFileManager fileManager = NSFileManager.DefaultManager;

            NSUrl[] urls = fileManager.GetUrls(NSSearchPathDirectory.DocumentDirectory, NSSearchPathDomain.User);
            NSUrl documentsDictionry = urls.FirstOrDefault();

            NSUrl destinationUrl = documentsDictionry.Append("image1.png", false);

            fileManager.Remove(destinationUrl, out NSError removeCopy);
            bool success = fileManager.Copy(location, destinationUrl, out NSError errorCopy);

            if (!success)
            {
                Console.WriteLine("Error during the copy: {0}", errorCopy.LocalizedDescription);
                return;
            }

            // we do not need to be on the main/UI thread to load the UIImage
            UIImage image = UIImage.FromFile(destinationUrl.Path);
            InvokeOnMainThread(() =>
            {
                try
                {
                    Controller.ImageView.Image = image;
                    Controller.ImageView.Hidden = false;
                    Controller.ProgressView.Hidden = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            });
        }

        public override void DidCompleteWithError(NSUrlSession session, NSUrlSessionTask task, NSError error)
        {
            Console.WriteLine("DidComplete");
            if (error == null)
                Console.WriteLine("Task: {0} completed successfully", task);
            else
                Console.WriteLine("Task: {0} completed with error: {1}", task, error.LocalizedDescription);

            float progress = task.BytesReceived / (float)task.BytesExpectedToReceive;
            InvokeOnMainThread(() => {
                Controller.ProgressView.Progress = progress;
            });

            Controller.DownloadTask = null;
        }

        public override void DidResume(NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long resumeFileOffset, long expectedTotalBytes)
        {
            Console.WriteLine("DidResume");
        }

        public override void DidFinishEventsForBackgroundSession(NSUrlSession session)
        {
            using (AppDelegate appDelegate = UIApplication.SharedApplication.Delegate as AppDelegate)
            {
                var handler = appDelegate.BackgroundSessionCompletionHandler;
                if (handler != null)
                {
                    appDelegate.BackgroundSessionCompletionHandler = null;
                    handler();
                }
            }

            Console.WriteLine("All tasks are finished");
        }
    }
}

```