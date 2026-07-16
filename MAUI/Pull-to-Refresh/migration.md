---
layout: post
title: Migrate from Xamarin SfPullToRefresh to .NET MAUI SfPullToRefresh | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin PullToRefresh to Syncfusion .NET MAUI SfPullToRefresh control and more.
platform: MAUI
control: SfPullToRefresh
documentation: ug
---  

# Migrate from Xamarin.Forms SfPullToRefresh to .NET MAUI SfPullToRefresh

To make migration easier from Xamarin.Forms SfPullToRefresh to .NET MAUI SfPullToRefresh, we kept most of the APIs from Xamarin SfPullToRefresh in .NET MAUI SfPullToRefresh. However, to maintain the consistency of API naming in .NET MAUI SfPullToRefresh, we renamed some of the APIs. The APIs that have been changed in .NET MAUI SfPullToRefresh from Xamarin SfPullToRefresh are detailed as follows.

## Migration Overview

Follow these steps to migrate from Xamarin.Forms SfPullToRefresh to .NET MAUI SfPullToRefresh:

1. **Replace the NuGet package** — Remove `Syncfusion.Xamarin.SfPullToRefresh` (or `Syncfusion.SfPullToRefresh.XForms`) and install `Syncfusion.Maui.PullToRefresh`. For information on installing NuGet packages, see [NuGet Package Manager documentation](https://learn.microsoft.com/nuget/consume-packages/install-use-packages-powershell).
2. **Migrate the project** — Migrate your Xamarin.Forms project to a .NET MAUI project. For details, see [Migrating from Xamarin.Forms to .NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/migration/forms-to-maui).
3. **Update namespaces** — Change the XAML and code-behind namespaces as described in the [Namespaces](#namespaces) section below.
4. **Rename APIs** — Update the renamed properties, events, and enums in your XAML and code-behind as described in this document.
5. **Build and verify** — Rebuild the solution and resolve any remaining compile errors. Common errors and fixes are listed in [Troubleshooting](#troubleshooting).

## Namespaces

<table>
<tr>
<th>Xamarin SfPullToRefresh</th>
<th>.NET MAUI SfPullToRefresh</th>
<th>Description</th>
</tr>
<tr>
<td>Syncfusion.SfPullToRefresh.XForms</td>
<td>Syncfusion.Maui.PullToRefresh</td>
<td>Namespace that contains the SfPullToRefresh class and its supporting types.</td>
</tr>
</table>

### Updating XAML namespace declarations

**Xamarin**

````xaml
xmlns:sfPullToRefresh="clr-namespace:Syncfusion.SfPullToRefresh.XForms;assembly=Syncfusion.SfPullToRefresh.XForms"
````

**.NET MAUI**

````xaml
xmlns:sfPullToRefresh="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh"
````

### Updating C# using directives

**Xamarin**

````csharp
using Syncfusion.SfPullToRefresh.XForms;
````

**.NET MAUI**

````csharp
using Syncfusion.Maui.PullToRefresh;
````

## Properties

<table>
<tr>
<th>Xamarin SfPullToRefresh</th>
<th>.NET MAUI SfPullToRefresh</th>
<th>Type</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[ProgressStrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_ProgressStrokeColor)'| markdownify }}</td>
<td>{{'[ProgressColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressColor)'| markdownify }}</td>
<td><code>Color</code> / <code>Brush</code></td>
<td>Gets or sets the progress color of SfPullToRefresh. In .NET MAUI, this property accepts a <code>Brush</code> in addition to a <code>Color</code>.</td>
</tr>

<tr>
<td>{{'[ProgressBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_ProgressBackgroundColor)'| markdownify }}</td>
<td>{{'[ProgressBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressBackground)'| markdownify }}</td>
<td><code>Color</code> / <code>Brush</code></td>
<td>Gets or sets the progress background of SfPullToRefresh. In .NET MAUI, this property accepts a <code>Brush</code> in addition to a <code>Color</code>.</td>
</tr>

<tr>
<td>{{'[ProgressStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_ProgressStrokeWidth)'| markdownify }}</td>
<td>{{'[ProgressThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressThickness)'| markdownify }}</td>
<td><code>double</code></td>
<td>Gets or sets the progress indicator thickness.</td>
</tr>

<tr>
<td>{{'[RefreshContentHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_RefreshContentHeight)'| markdownify }}</td>
<td>{{'[RefreshViewHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewHeight)'| markdownify }}</td>
<td><code>double</code></td>
<td>Gets or sets the height of the refresh view.</td>
</tr>

<tr>
<td>{{'[RefreshContentWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_RefreshContentWidth)'| markdownify }}</td>
<td>{{'[RefreshViewWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewWidth)'| markdownify }}</td>
<td><code>double</code></td>
<td>Gets or sets the width of the refresh view.</td>
</tr>

<tr>
<td>{{'[RefreshContentThreshold](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_RefreshContentThreshold)'| markdownify }}</td>
<td>{{'[RefreshViewThreshold](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewThreshold)'| markdownify }}</td>
<td><code>double</code></td>
<td>Gets or sets the threshold value that indicates the position at which the progress indicator starts to appear in the view.</td>
</tr>
</table>

## Enums

<table>
<tr>
<th>Xamarin SfPullToRefresh</th>
<th>.NET MAUI SfPullToRefresh</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[TransitionType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.TransitionType.html)'| markdownify }}</td>
<td>{{'[PullToRefreshTransitionType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.html)'| markdownify }}</td>
<td>Defines the type of pulling animation to be performed.</td>
</tr>
</table>

### Enum Members

The `TransitionType` (Xamarin) and `PullToRefreshTransitionType` (.NET MAUI) enums expose the following members, which have been preserved with the same values:

<table>
<tr>
<th>Xamarin member</th>
<th>.NET MAUI member</th>
<th>Description</th>
</tr>
<tr>
<td><code>SlideOnTop</code></td>
<td><code>SlideOnTop</code></td>
<td>Slides the content on top of the pull-to-refresh indicator.</td>
</tr>
<tr>
<td><code>PushOnTop</code></td>
<td><code>PushOnTop</code></td>
<td>Pushes the content down to make room for the pull-to-refresh indicator.</td>
</tr>
</table>

## Code Example: Before and After

The following example shows a typical Xamarin.Forms `SfPullToRefresh` declaration and its .NET MAUI equivalent after migration.

**Xamarin (XAML)**

````xaml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPullToRefresh="clr-namespace:Syncfusion.SfPullToRefresh.XForms;assembly=Syncfusion.SfPullToRefresh.XForms"
             x:Class="Sample.PullToRefreshPage">
    <sfPullToRefresh:SfPullToRefresh x:Name="pullToRefresh"
                                     ProgressStrokeColor="Blue"
                                     ProgressBackgroundColor="LightGray"
                                     ProgressStrokeWidth="3"
                                     RefreshContentHeight="50"
                                     RefreshContentWidth="50"
                                     RefreshContentThreshold="40"
                                     TransitionType="SlideOnTop">
        <sfPullToRefresh:SfPullToRefresh.PullableContent>
            <ListView ItemsSource="{Binding Items}" />
        </sfPullToRefresh:SfPullToRefresh.PullableContent>
    </sfPullToRefresh:SfPullToRefresh>
</ContentPage>
````

**.NET MAUI (XAML)**

````xaml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPullToRefresh="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh"
             x:Class="Sample.PullToRefreshPage">
    <sfPullToRefresh:SfPullToRefresh x:Name="pullToRefresh"
                                     ProgressColor="Blue"
                                     ProgressBackground="LightGray"
                                     ProgressThickness="3"
                                     RefreshViewHeight="50"
                                     RefreshViewWidth="50"
                                     RefreshViewThreshold="40"
                                     TransitionType="SlideOnTop">
        <sfPullToRefresh:SfPullToRefresh.PullableContent>
            <CollectionView ItemsSource="{Binding Items}" />
        </sfPullToRefresh:SfPullToRefresh.PullableContent>
    </sfPullToRefresh:SfPullToRefresh>
</ContentPage>
````


## Removed APIs

The following Xamarin APIs have no direct equivalent in the .NET MAUI SfPullToRefresh and are no longer available. If your code depends on them, refactor accordingly.

- `ProgressStrokeColor` — replaced by `ProgressColor`.
- `ProgressBackgroundColor` — replaced by `ProgressBackground`.
- `ProgressStrokeWidth` — replaced by `ProgressThickness`.
- `RefreshContentHeight` — replaced by `RefreshViewHeight`.
- `RefreshContentWidth` — replaced by `RefreshViewWidth`.
- `RefreshContentThreshold` — replaced by `RefreshViewThreshold`.
- `TransitionType` (enum) — replaced by `PullToRefreshTransitionType`.
