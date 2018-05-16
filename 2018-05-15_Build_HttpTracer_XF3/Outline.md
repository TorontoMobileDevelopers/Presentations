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

### Personal Experience

* Seattle is a great city
* Expo floor booths operated by team members
* Networking opportunities
* Exposure to new technology
* Hands on sessions
* Celebration at Seattle Center/MoPOP
* Swag!

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
* C# Interactive improvements
* TFVC in preview for VS for Mac
* .editorconfig support for VS for Mac
* Azure functions support in VS for Mac
* https://blogs.msdn.microsoft.com/visualstudio/2018/05/07/visual-studio-for-mac-version-7-5-and-beyond/

https://channel9.msdn.com/Events/Build/2018/BRK2100

### .NET

* .Net is a platform for anything
* Large growth
* Net core improvements
  * Aspnet core
  * Ef core
  * Build times 10x faster for 2.1
* Net core 2 is fast! Runtime performance

### C#

* Last 12 Months: 7.1, 7.2, 7.3
* `default` keyword no longer requires a type where it can be implied (`default<T>`)
* Overload resolution
* Enum and delegate constraints on generics
* Unmanaged pointers as generics
* Unsafe keyword
* Tuple autonames
* Equality operators for tuples
* In parameters for immutable reference
* return ref
* readonly method returns
* static ref readonly int
* `Span<T>`
  * Framework only (no core/standard yet)
  * Requires pre-release System.Memory Nuget package
  * [Merge Comflict Episode](http://www.mergeconflict.fm/92)
* `stackalloc` gives managed access to the stack

#### Future (C# 8.0)

* Design/compile time null reference checking
* Reference types non-nullable by default
	  * https://blogs.msdn.microsoft.com/dotnet/2017/11/15/nullable-reference-types-in-csharp/
* Switch supports lambda syntax
* Range operator `^`
* Async iterators
* `IAsyncDisposable`
* Default Interface Members
* Records
  * `class Person (string firstName, string LastName);`
* [Build Session](https://channel9.msdn.com/Events/Build/2018/BRK2155)

### Xamarin

#### Miguel's Advice

* Miguel: "Microsoft developers tend to design interfaces that are suitable to people from another galaxy"
* UX
* Speed
* Metrics

* 10 apps on average per user per day
* 3 billion active devices
* 11 billion in Apple app store revenue

* Customer Retention
  * Apps must be good from day one!
  * 55% of users retained after 1 week
  * if launched at least once in week 2, 82% retained
  * https://www.braze.com/blog/be-your-customers-ritual-consistent-engagement-results-in-90-audience-retention-after-one-month/

* Onboarding
  * Login causes 50% drop off!!!
  * Intro/Walkthrough
  * Interstitials for major new features
  * how to draw people in

* Design
  * Joel Spolsky - User Interface for Developers https://www.joelonsoftware.com/2001/10/24/user-interface-design-for-programmers/
  * Microsoft Inclusive Design https://www.microsoft.com/en-us/design/inclusive
  * Where/how/with whom are people using your app?
  * Persona spectrum

* Tools for Design
  * Paper sketches
  * Adobe XD
  * Sketch
  * InDesign

* Testing
  * Developers have new, fast phones, users do not
  * Scenario - 12 second load time
  * Test on old devices!
  * Use the profiler - ALWAYS

* Release Builds
  * Always ship using LLVM Optimizing Compiler (in project options)
  * On Android, opt for AOT or Hybrid Compilation

* Networking
  * json sucks, very slow
  * binary json
  * protocol buffers
    * https://github.com/mgravell/protobuf-net
    * https://developers.google.com/protocol-buffers/docs/csharptutorial

#### Developer Experience Improvements

* Simplified project templates
* Streamlined Mac provisioning (mono, xcode, etc for VS agent)
* New Android Device Manager + Android SDK Manager
  * Automatically suggests installs
* Much improved Xaml development experience
* iOS Designer - new size classes support
* Android Designer - split view (axml + preview), drag/drop, completion
* Improved dependency tracking - huge build performance improvements
* Android deployment - Eager deployment (runtime deployed in parallel) saves ~25 seconds of deployment time (~15% for largr apps)
* Android Emulator on Hyper-V
* Provision a device automatcally in seconds (provisioning profiles, certificates, entitlements)
* Profiler improvements - light allocations mode
* Profiler snapshot comparisons

* New on the platforms
  * iOS - full static startup
  * consume less memory, faster startup
  * faster VS for Mac startup 11s to 7s - think about the impact on mobile
  * 23-34% improvement on mem usage - same as swift
  * iOS weak attribute (RESEARCH THIS) - replaces `WeakReference<T>`

* Xamarin Essentials
  * replaces individual plugins

* Xamarin Forms Project F100
  * Top 100 annoyances

* Beyond Build 2018
  * Elmish.XamarinForms - Elm + F# + Xamarin.Forms - similar to react
  * Ooui - Xamarin forms ASP.NET Core WebAssembly
  * GraphQL
  * Xamarin.Forms Shell

https://channel9.msdn.com/Events/Build/2018/BRK2422

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
* Community contributions encouraged

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

#### CSS

* Finally a DSL for style
* Reuse styling between web and mobile
* Apply multiple `StyleClass` to elements
* TODO: Tooling supports SCSS (Sass - pre-processed styles)