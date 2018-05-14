# 2018-05-15 HttpTracer/Build/Xamarin.Forms 3.0

## HttpTracer

* What is the HttpTracer library
* Motivation
  * Easy to setup
  * Share usefull tools with the community
* Demo of log dumping console / File.
* Improvements
  * Cover types of requests like media
  * Customise log text (simple, complex)
  * Make Visual studio extensions (Fiddler alike)
* Call for more contributors and tools
  * Come create repos under Toronto meetup github :)

### Links

* https://github.com/TorontoMobileDevelopers/HttpTracer
* https://www.nuget.org/packages/HttpTracer/

## Microsoft Build 2018

### Vision

* Privacy & Trust
* Connectivity
* Empathy & Accessibility
* Empowering Developers

### Microsoft Ecosystem

* Azure
  * Azure Sphere
  * Azure Stack
  * IoT
    * IoT Edge
  * Open source
    * Microsoft is the largest open source contributor on Github
  * AI
    * Cognitive services
    * AI for Accessibility
  * Bot Framework
    * QnA Maker
  * Cosmos DB global performance improvements

* Microsoft 365
  * Windows + Office + EMS (Enterprise Mobility + Security)
  * Windows
    * Sets Contextual app grouping
    * Fluent design
    * UWP XAML islands - UWP controls in WPF
    * Improved screen density
    * Fluent controls, including data grid
  * Graph API
    * Timeline
      * iOS - Edge
      * Android - Launcher/Edge

### Visual Studio/VSTS

* Visual Studio 15.7 Performance
* Ctrl+click to navigate to decompiled code
  * Vs options > c# > advanced > enable decompiled sources
* Source link to open source projects to step through open source projects
* Intellicode - cognitive services parsed GitHub to give you better suggestions
  * https://www.visualstudio.com/services/intellicode/
* VSTS Credential Scan build task
* Azure Key Vault package
* Debugging
  * Step back into
  * Reverse Continue
* New Android Device Manager + Android SDK Manager
  * Automatically suggests installs
* TFVC in preview for VS for Mac
* .editorconfig support for VS for Mac
* Azure functions support in VS for Mac
* https://blogs.msdn.microsoft.com/visualstudio/2018/05/07/visual-studio-for-mac-version-7-5-and-beyond/
* C# Interactive improvements

### .NET

* .Net is a platform for anything
* Large growth
* Net core improvements
  * Aspnet core
  * Ef core
  * Build times 10x faster for 2.1
* Net core 2 is fast! Runtime performance

### C#

### Xamarin

### Personal Experience

## Xamarin Forms 3.0

### Feature Roadmap as of 2018-02-09

[Xamarin Forms Feature Roadmap](https://github.com/xamarin/Xamarin.Forms/wiki/Feature-Roadmap)

| **Feature**                       | **Description**                                                                                                                                              | **Status** |
| --------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------ | ---------- |
| Accessibility Improvements        | Adding direct support for focus order and tab index.                                                                                                         | Planned    |
| CSS                               | An alternative styling implementation to complement XAML styles and support `FlexLayout`. [Pull Request](https://github.com/xamarin/Xamarin.Forms/pull/1207) | Complete   |
| FlexLayout                        | A flexible box layout container using [Xamarin Flex](https://github.com/xamarin/flex). [1261](https://github.com/xamarin/Xamarin.Forms/pull/1261), [1759](https://github.com/xamarin/Xamarin.Forms/pull/1759)    | Complete  |
| Globalization                     | Right to Left (RTL) flow direction for text, layouts, and images. [Pull Request](https://github.com/xamarin/Xamarin.Forms/pull/1222)                         | Complete   |
| GTK# Backend Preview              | Runs Xamarin.Forms on Linux using GTK# 2.                                                                                                                    | Complete   |
| macOS Backend Preview             | Improvements.                                                                                                                                                | Complete   |
| .NET Standard 2.0                 | All code moved to .NET Standard 2.0. [Pull Request](https://github.com/xamarin/Xamarin.Forms/pull/1306)                                                      | Complete   |
| Renderer Registration Improvement | Reduce reflection burden by allowing developer to specify which assemblies to search for renderers at initialization. After spiking this work we measured no meaningful improvement.                                        | Cut    |
| Visual State Manager              | Specify states for a control to customize appearance and behavior. [Pull Request](https://github.com/xamarin/Xamarin.Forms/pull/1405)                        | Complete   |
| WP8/8.1 Removed                   | Removed in this version. To allow .NET Standard 2.0 and to improve performance.                                                                              | Complete   |
| x:Bind                            | Compiled bindings using the same syntax you get in UWP.                                                                                                      | Planned    |

### Highlights

* Performance??? (were fast renderers pushed into XF 2.5)
* More supported platforms (macOS, Linux, WPF, Tizen)
* Embedding improvements with Fragments??? (was this pushed in XF 2.5)
* CSS
* FlexLayout
* Visual State Manager
* Live Reload
* 500+ bug fixes/improvements

### Links

* https://blog.xamarin.com/update-to-xamarin-forms-3-0-pre-release-available-today/
* https://developer.xamarin.com/releases/xamarin-forms/xamarin-forms-3.0/3.0.0-pre3/


### Loading Sample Apps

* https://github.com/Microsoft/ConferenceVision

### Visual State Manager

* Allows for predefined states to be attached to a control (`Visual Element`)
* State can be changed by calling `VisualStateManager.GotoState(myLabel, "Success");`

```cs
var stateGroup = new VisualStateGroup{ Name = "ResultState", TargetType = typeof(Label) };
stateGroup.States.Add(CreateState("Success", "Great Success!", Color.Green));
stateGroup.States.Add(CreateState("Success", "Oh no! Everything is broken!", Color.Red));

static VisualState CreateState(string name, string text, Color color)
{
    var textSetter = new Setter { Value = text, Property = Label.TextProperty };
    var colorSetter = new Setter { Value = color, Property = Label.TextColorProperty };

    return new VisualState { Name = name, TargetType = typeof(Label), Setters = { textSetter, colorSetter } };
}
```

### FlexLayout

* New Layout inspired by css FlexBox
* Has the potential to replace Grid (and StackLayout) in most cases
* Less markup than Grid to acheive the same result
* A solid understanding of FlexBox will accelerate FlexLayout learning curve

## CSS

* Finally a DSL for style
* Reuse styling between web and mobile
* Apply multiple `StyleClass` to elements
* TODO: Tooling supports SCSS (Sass - pre-processed styles)