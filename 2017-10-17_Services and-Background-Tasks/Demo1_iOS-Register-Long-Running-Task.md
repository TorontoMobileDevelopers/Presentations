# Demo 1 : iOS - Register Long Running Task

Create Project
* Visual Studio for Mac
* File > New Solution
* iOS > App > Single View App > Next

Configure iOS App
* App Name: LongRunningTask
* Org ID: com.tomobiledevs
* Team: Canadian Project Partners
* Devices: iPhone
* Target: iOS 10.3
 
Configure Single View App
* Keep defaults

Modify Code
* Open ViewController.cs

```cs

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            var btn = UIButton.FromType (UIButtonType.System);
            btn.Frame = new CGRect (20, 200, 280, 44);
            btn.SetTitle ("Run Custom Task", UIControlState.Normal);
            btn.TouchUpInside += (sender, e) => {
                RunCustomTask();
            };
            View.AddSubview (btn);
        }

        void RunCustomTask()
        {
            Console.WriteLine ("Running custom task");
            nint taskID = UIApplication.SharedApplication.BeginBackgroundTask( () => {}); 
            
            //runs on main or background thread
            FinishLongRunningTask(taskID);

            UIApplication.SharedApplication.EndBackgroundTask(taskID);
        }

        void FinishLongRunningTask (nint taskID)
        {
            Console.WriteLine("Starting task {0}", taskID);
            Console.WriteLine("Background time remaining: {0}",
                UIApplication.SharedApplication.BackgroundTimeRemaining.Equals(double.MaxValue)
                    ? "Infinity"
                    : UIApplication.SharedApplication.BackgroundTimeRemaining.ToString());
            
            // sleep for 10 seconds to simulate a long running task
            Thread.Sleep(10000);

            Console.WriteLine("Task {0} finished", taskID);
            Console.WriteLine("Background time remaining: {0}",
                UIApplication.SharedApplication.BackgroundTimeRemaining.Equals(double.MaxValue)
                    ? "Infinity"
                    : UIApplication.SharedApplication.BackgroundTimeRemaining.ToString());
        }

```
* Add usings
  * System.Threading
  * CoreGraphics
* Run
* Click button
* Examine Application Output
* Click button
* Return to home
* Examine Application Output
