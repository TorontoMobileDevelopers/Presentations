# Demo 2 : iOS - DidEnterBackground Tasks
## Setup
Create Project
* Visual Studio for Mac
* File > New Solution
* iOS > App > Single View App > Next

Configure iOS App
* App Name: DidEnterBackgroundTask
* Org ID: com.tomobiledevs
* Team: Canadian Project Partners
* Devices: iPhone
* Target: iOS 10.3
 
Configure Single View App
* Keep defaults

## Task 1 - Implement Basic Background Task
* Open AppDelegate.cs

```cs

        public override void DidEnterBackground (UIApplication application)
        {
            nint taskID = 0;
            Console.WriteLine ("App entering background state.");

            taskID = UIApplication.SharedApplication.BeginBackgroundTask(() => {});
            Task.Run( () => {
                LongRunningTask(taskID);
                UIApplication.SharedApplication.EndBackgroundTask(taskID);
            });
        }

        void LongRunningTask (nint taskID)
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
  * System
  * System.Threading
  * System.Threading.Tasks
  * CoreGraphics
* Run
* Return to home
* Examine Application Output

## Task 2 - Handle Background Task Timeout
* Modify AppDelegate.DidEnterBackground

```cs

        public override void DidEnterBackground (UIApplication application)
        {
            nint taskID = 0;
            Console.WriteLine ("App entering background state.");
            
            taskID = UIApplication.SharedApplication.BeginBackgroundTask(() =>
            {
                Console.WriteLine("Background task timed out.");
                // Do teardown work
                UIApplication.SharedApplication.EndBackgroundTask(taskID);
            });
            Task.Run(() =>
            {
                LongRunningTask(taskID);
                UIApplication.SharedApplication.EndBackgroundTask(taskID);
            });
        }

```
* Increase Thread.Sleep to 300000ms (5 minutes)
* Run
* Return to home
* Examin Application Output after 3 minutes