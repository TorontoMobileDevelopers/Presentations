# Microsoft Build 2018
## Day 2

### Keynote

### M365
* Any place, any device
* Graph - cloud back organizational data store


Windows
Windows dev
Office dev
Graph

### Windows
Timeline
* based on graph
* edge history from all devices
* cortana + suggestions based on history

Mobile experience
Launcher
* fluent ui
* customer focused
* MS Launcher for enterprisd
* tailored to the customer
* powered by InTune
* timeline enabled

Edge
* timeline enabled (iOS)

OOTB windows app
Key workloads from phone to PC
Phone communicates to PC app via Graph

Sets
* Group Tasks
* Contextual app grouping
* Sets in timeline
* Sets available when it's ready :D

### Windows Dev
Fluent Design System
* UWP XAML Islands - add UWP controls available in WPF
* fluent data grid
* imporved screen density

Hyper-V + Android Emulator (HAXM)
Linux line breaks
Chocolatey + boxstarter - personas

Microsoft Store revenue split : 85% through store, 95% through referral link

### Office
Excel javascript support
Pull data from web services
Excel.Script.CustomFunctions["NAMESPACE"]["FNNAME"] = { // MY CODE };
Add through O365 Admin Center

Adaptive Cards
Open soure card exchange format
* Teams/Outlook/Cortana/Timeline/etc
* Actionable content within the card context
adaptivecards.io

Teams

# Digital Transformation at Starbucks
Journey into the cloud to drive digital transformation

CX drives everything

Delivery
Learning
Automation

Cohort based delivery - hackathon style

20+ apps
50+ azure services

Data platform
* Before - BI
* After - ???
* Data as a product
* Data unlocks ML

Micro service architecture
* Data was previously very siloed
* Realtime approach for re-engineering
* Realtime was essential for mobile ordering, etc

Training
1. intro
2. sandbox
3. formal training
4. POC project
5. execution

Devops enablers
* accelerate and enable teams
* reference architecture repository

Hands on assistance from MS

Security
* gap analysis

Cost-benefit analysis

Integration requirements

Relationship with MS
* embed into scrum teams
* MS coordinated hackathon
* guided hands-on learning
* proactive approach - not reactive after mistakes were made

Operational excellence
* stability
* operations
* monitoring

UX is very important internally and externally

POCs are extremely important, start simple

Scrum - agile practices

What helped with sentiment/adoption/success
* Realtime data
* Better tools
* Emphasis on training
* Executive sponsorship + uniform messaging
* Culture - open to experimentation
* True understanding of technology value prop
* Well funded

Don't underestimate your people

Collaborate and share


## Xamarin and Visual Studio: The Future of App Development
### Miguel
* 10 apps on average per user per day
* 3 billion active devices
* 11 billion in Apple app store revenue

### Customer Retention
* 55% of users retained after 1 week
* if launched at least once in week 2, 82% retained
* <IMG FROM TWITTER>

### Onboarding
* Login causes 50% drop off!!!
* Intro
* Walkthrough
* Interstitials for major new features
* how to draw people in

### Design
* Joel Spolsky - User Interface for Developers https://www.joelonsoftware.com/2001/10/24/user-interface-design-for-programmers/
* Microsoft Inclusive Design https://www.microsoft.com/en-us/design/inclusive
* Where are people using your app?
* How are they using your application (alone/coworkers/crowd/friends+family)
* Persona spectrum

#### Tools for Design
* Paper sketches
* Adobe XD
* Miguel: "Microsoft developers tend to design interfaces that are suitable to people from another galaxy"

### Native Access
* Native UI
* Native API Access
* Native Performance
* Same Day Support (latest OS platform and APIs on launch day)

### Tooling Improvements
* Developer experience improvements
* simlified templates
* streamlined Mac provisioning (mono, xcode, etc)
* Android AVD replacement
* Android SDK manager replacement
* Automatic Android SDK Management

### Editing
* VS Xaml Editor now supports Xamarin.Forms
* Much improved Xaml development experience
* iOS Designer - new size classes support
* Android Designer - split view (axml + preview), drag/drop, completion
* Improved dependency tracking - huge build performance improvements
* Android deployment - Eager deployment (runtime deployed in parallel) saves ~25 seconds of deployment time (~15% for largr apps)

Android Emulator on Hyper-V
* Windows team made kernel changes to support this change
* Windows April update
* Alpha preview of VS
* Almost instant launch from cold boot
* Launch speed is MUCH faster overall
* Minutes to seconds

Fastlane iOS device provisioning
* Provision a device automatcally in seconds (provisioning profiles, certificates, entitlements)

Testing
* Developers have new, fast phones, users do not
* Scenario - 12 second load time
* Use the profiler - ALWAYS
* Profiler improvements - light allocations mode
* snapshot comparisons

Relase Builds
* Always ship using LLVM Optimizing Compiler
* On Android, opt for AOT or Hybrid Compilation
* Test on old devices!!!

Networking
* json sucks, very slow
* binary json
* protocol buffers
    * https://github.com/mgravell/protobuf-net
    * https://developers.google.com/protocol-buffers/docs/csharptutorial

New on the platforms
* iOS - full static startup
* consume less memory, faster startup
* faster VS for Mac startup 11s to 7s - think about the impact on mobile
* 23-34% improvement on mem usage - same as swift
* iOS weak attribute (RESEARCH THIS) - replaces `WeakReference<T>`

Xamarin Forms 3.0 Released
* CSS
* Flex Layout
* Visual State Manager
* Right-to-left language support

Xamarin Essentials
* replaces individual plugins

Xamarin Forms Project F100
* Top 100 annoyances

Beyond Build 2018
* Elmish.XamarinForms - Elm + F# + Xamarin.Forms - similar to react
* Ooui - Xamarin forms ASP.NET Core WebAssembly
* GraphQL
* Xamarin.Forms Shell