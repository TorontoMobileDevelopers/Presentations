# Microsoft Build 2018

# HttpTracer
https://github.com/TorontoMobileDevelopers/HttpTracer

# Xamarin Forms 3.0

## Feature Roadmap as of 2018-02-09
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

## Highlights
* CSS
* FlexLayout
* Visual State Manager

https://blog.xamarin.com/update-to-xamarin-forms-3-0-pre-release-available-today/
https://developer.xamarin.com/releases/xamarin-forms/xamarin-forms-3.0/3.0.0-pre3/


## Loading Sample Apps


## Visual State Manager
* Allows for predefined states to be attached to a control (`Visual Element`)
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
* State can be changed by calling `VisualStateManager.GotoState(myLabel, "Success");`


## FlexLayout
* New Layout inspired by css FlexBox
* Has the potential to replace Grid (and StackLayout) in most cases
* Less markup than Grid to acheive the same result

## CSS
* Finally a DSL for style
* Reuse styling between web and mobile
* Apply multiple `StyleClass` to elements