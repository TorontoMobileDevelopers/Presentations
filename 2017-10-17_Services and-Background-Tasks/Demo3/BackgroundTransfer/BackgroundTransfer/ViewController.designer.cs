//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BackgroundTransfer
{
    [Register("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIImageView imageView { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIProgressView progressView { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIButton startButton { get; set; }

        [Action("StartButton_TouchUpInside:")]
        [GeneratedCode("iOS Designer", "1.0")]
        partial void StartButton_TouchUpInside(UIKit.UIButton sender);

        void ReleaseDesignerOutlets()
        {
            if (imageView != null)
            {
                imageView.Dispose();
                imageView = null;
            }

            if (progressView != null)
            {
                progressView.Dispose();
                progressView = null;
            }

            if (startButton != null)
            {
                startButton.Dispose();
                startButton = null;
            }
        }
    }
}
