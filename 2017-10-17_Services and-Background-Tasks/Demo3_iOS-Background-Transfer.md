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
* Add the code (ensure to replace ViewDidLoad method)
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