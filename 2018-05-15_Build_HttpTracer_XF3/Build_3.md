# Microsoft Build 2018

## Day 3

### VS Code Can Do That?!

* History
* Erich Gamma - eclipse
  * Project Monaco
  * VS Online
  * IE 11 Dev Tools
  * OneDrive
* editor - IDE spectrum

* Customization
  * cobalt theme
  * material icons
  * ligatures
  * https://github.com/tonsky/FiraCode
  * json settings

* Commands
  * command-shift-p
  * interactive playground
  * command-1/2/3
  * command-w
  * command-p-p

* command pallette navigation
  * command-p-@
* command-p-?
* toggle sidebar
  * command-b
* toggle terminal
  * control-`
* toggle bottom pane
  * command-j

* Other Features
  * hotsave
  * minimap
  * code folding
  * zen mode
  
* emmet for html/markup
  * emmet will insert image dimensions dynamically
  * cheatsheet

https://code.visualstudio.com/docs/languages/markdown
https://code.visualstudio.com/shortcuts/keyboard-shortcuts-macos.pdf

### Xamarin Forms 3.0

* predictable cadence
* xamarin forms UI embed in native/classic apps
* .NET embedding in obj-c/swift/java

* Performance
  * netstandard 2.0
  * compiled bindings
  * fast renderers
  * layout compression
  * startup optimizations
  * xamlc

* Community Contributions
  * Need contributions
  * 133 contributors

* Prism extension for app center
* Better VS for Mac extensibility
* Ooui

* Xaml Standard Update
  * align win 10 xaml with xamarin.forms xaml
  * XAML Standard tags in Xamarin.Forms 3.1

https://movai.azurewebsites.net/
https://github.com/Microsoft/ConferenceVision

* Xamarin Forms 3.0
  * Visual State Manager
  * Right-To-Left
  * FlexLayout
  * CSS
  * F100 - improvements
  * ResourceDictionary Improvements (David's blog post)
  
* FlexLayout
  * Flexbox inspired layout
  * Less ui nesting
  * prioritizes distribution and alignment

* CSS
  * Parsed at runtime
  * supports many properties, but not all


* Mac is supported in 3.0

* Telerik is supported

* The Future
  * f100s
  * look at the slides, and the

### VS for Mac

* Jordan Matteisen

* v 7.5
  * Razor TypeScript, JS language services
  * Azure Functions
    * 10+ templates
  * Xamarin netstandard 2.0 templates
  * iOS debugging over wifi
  * .editorconfig
  * TFVC (preview)

* Tips and Tricks
  * prefs
    * light/dark
    * keybindings
      * full windows, including ctrl-x/c/v
      * customizable
      * BONUS: makes a good command reference
    * text editor
      * code folding (on by default next release)
      * markers and rulers
    * behaviors
      * vs styles
  * navigating
    * find ref improvements - roslyn hooks
    * open multiple solutions (automator shortcut)
    * can drag tabs out to new windows
    * split windows
    * navigate toolbar
    * cmd+. to search
    * cmd-shift-D
    * cmd-shift-p (commands, like vs code)
    * layouts - preconfigured + customizable
  * editor
    * block selection
      * alt-shift-click+drag
      * option-shift-up
    * cmd + R - backed by roslyn
    * recommendations on the scroll bar on the right
    * fn-option-up/down navigate through callouts
    * snippets (need to research)

* https://docs.microsoft.com/en-us/visualstudio/mac/keyboard-shortcuts

### Xamarin and Azure Functions

#### Laurent Bugnion

* azure functions - serverless, pay per use, auto scale
* microservice - small units of computation, stateless, independent
* Messaging between fns - event grid, connectors, etc
* various triggers - http/timer/event
  * blob trigger
  * webhooks
* dev/debug in vs / vs code
* one fn per endpoint w/seperate url
* proxy to tie multiple endpoints together
* fns can be secured ssl/auth
* names must be unique
* can be run in windows/linux/docker
* billed on consumption/app service plan

### Azure IoT

* Core Ingredients
  * Things - generate data
  * Data - generate insights which can be used to determine actions
  * Actions - executed on things or external system

* Needs
  * Security
  * Deployment
  * HA/DR

* Solution Accelerators
  * https://docs.microsoft.com/en-us/azure/iot-suite/

* Device simulator!




https://aws.amazon.com/iot-1-click/

