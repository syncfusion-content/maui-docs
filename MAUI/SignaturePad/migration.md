---
layout: post
title: Migrate from Xamarin to .NET MAUI SfSignaturePad | Syncfusion®
description: Learn here all about Migrating from Syncfusion® Xamarin SignaturePad to Syncfusion® .NET MAUI SignaturePad control and more.
platform: maui
control: SfSignaturePad
documentation: ug
---

# Migrate from Xamarin.Forms SfSignaturePad to .NET MAUI SfSignaturePad

To make migration from the [Xamarin SignaturePad](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html) to the [.NET MAUI SignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html) easier, most of the APIs from the Xamarin SfSignaturePad have been kept in the .NET MAUI SfSignaturePad. However, to maintain the consistency of API naming in the .NET MAUI SfSignaturePad, some of the APIs have been renamed. The differences are described in the following sections.

> **Compatibility:** The .NET MAUI SignaturePad is supported on .NET 8 and later. Migrate to .NET MAUI and Syncfusion<sup>®</sup> .NET MAUI controls before referencing the renamed APIs.

## Migration workflow

Follow these steps to migrate a Xamarin.Forms project that uses `SfSignaturePad` to .NET MAUI:

1. Migrate the Xamarin.Forms project to .NET MAUI by following the [official .NET MAUI migration guide](https://learn.microsoft.com/dotnet/maui/migration/).
2. Remove the `Syncfusion.Xamarin.SfSignaturePad` NuGet package from the project.
3. Install the [Syncfusion.Maui.SignaturePad](https://www.nuget.org/packages/Syncfusion.Maui.SignaturePad) NuGet package, and the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) package if it is not already referenced.
4. Update the XAML `xmlns` and C# `using` directives from `Syncfusion.XForms.SignaturePad` to `Syncfusion.Maui.SignaturePad` (see the [Namespaces](#namespaces) section).
5. Rename any APIs listed in the tables below. Pay particular attention to `Save` → `ToImageSource` and `StrokeStarted` → `DrawStarted`, which also change behavior.
6. Register the Syncfusion core handler in the `CreateMauiApp` method of `MauiProgram.cs` (see [Getting Started with .NET MAUI SignaturePad](getting-started.md)).
7. Clean and rebuild the project.

For prerequisites and project setup, see [Getting Started with .NET MAUI SignaturePad](getting-started.md).

## Namespaces

The following table lists the namespace changes between Xamarin and .NET MAUI:

<table>
<tr>
<th>Xamarin SfSignaturePad</th>
<th>.NET MAUI SfSignaturePad</th></tr>
<tr>
<td>Syncfusion.XForms.SignaturePad</td>
<td>Syncfusion.Maui.SignaturePad</td></tr>
</table>

For XAML, replace the namespace declaration as shown:

```xml
<!-- Xamarin -->
xmlns:signaturePad="clr-namespace:Syncfusion.XForms.SignaturePad;assembly=Syncfusion.SfSignaturePad.XForms"

<!-- .NET MAUI -->
xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad"
```

## Properties

The following table lists the property renames. The value range, units, and defaults are unchanged between Xamarin and .NET MAUI.

<table>
<tr>
<th>Xamarin SfSignaturePad</th>
<th>.NET MAUI SfSignaturePad</th>
<th>Description</th></tr>
<tr>
<td>{{'[StrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_StrokeColor)'| markdownify }}</td>
<td>{{'[StrokeColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_StrokeColor)'| markdownify }}</td>
<td>Gets or sets the stroke color of the signature.</td></tr>
<tr>
<td>{{'[MinimumStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_MinimumStrokeWidth)'| markdownify }}</td>
<td>{{'[MinimumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MinimumStrokeThickness)'| markdownify }}</td>
<td>Gets or sets the minimum stroke thickness of the signature.</td></tr>
<tr>
<td>{{'[MaximumStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_MaximumStrokeWidth)'| markdownify }}</td>
<td>{{'[MaximumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MaximumStrokeThickness)'| markdownify }}</td>
<td>Gets or sets the maximum stroke thickness of the signature.</td></tr>
</table>

## Methods

The following table lists the method renames. Note that `Save` was replaced by `ToImageSource`, which has a different return type and may return `null` on an empty pad.

<table>
<tr>
<th>Xamarin SfSignaturePad</th>
<th>.NET MAUI SfSignaturePad</th>
<th>Description</th></tr>
<tr>
<td>{{'[Save](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_Save)'| markdownify }}</td>
<td>{{'[ToImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_ToImageSource)'| markdownify }}</td>
<td>Returns the drawn signature in the SfSignaturePad as an image.</td></tr>
<tr>
<td>{{'[Clear](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_Clear)'| markdownify }}</td>
<td>{{'[Clear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_Clear)'| markdownify }}</td>
<td>Clears the drawn signature in the SfSignaturePad.</td></tr>
</table>

## Events

The following table lists the event renames. The `DrawStarted` event now provides a `CancelEventArgs` argument, allowing a stroke to be cancelled before it is drawn — this is a behavioral change from the Xamarin `StrokeStarted` event.

<table>
<tr>
<th>Xamarin SfSignaturePad</th>
<th>.NET MAUI SfSignaturePad</th>
<th>Description</th></tr>
<tr>
<td>{{'[StrokeStarted](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_StrokeStarted)'| markdownify }}</td>
<td>{{'[DrawStarted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawStarted)'| markdownify }}</td>
<td>Occurs when the user starts a stroke on the SfSignaturePad. Provides a <code>CancelEventArgs</code> that can be used to cancel the stroke.</td></tr>
<tr>
<td>{{'[StrokeCompleted](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_StrokeCompleted)'| markdownify }}</td>
<td>{{'[DrawCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawCompleted)'| markdownify }}</td>
<td>Occurs when the user completes a stroke on the SfSignaturePad.</td></tr>
</table>

## Code migration example

The following snippets show a minimal migration from Xamarin to .NET MAUI.

### XAML

```xml
<!-- Xamarin -->
<ContentPage xmlns:signaturePad="clr-namespace:Syncfusion.XForms.SignaturePad;assembly=Syncfusion.SfSignaturePad.XForms">
    <signaturePad:SfSignaturePad x:Name="signaturePad"
                                 StrokeColor="Red"
                                 MinimumStrokeWidth="1"
                                 MaximumStrokeWidth="6" />
</ContentPage>
```

```xml
<!-- .NET MAUI -->
<ContentPage xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <signaturePad:SfSignaturePad x:Name="signaturePad"
                                 StrokeColor="Red"
                                 MinimumStrokeThickness="1"
                                 MaximumStrokeThickness="6" />
</ContentPage>
```

### C#

```csharp
// Xamarin
using Syncfusion.XForms.SignaturePad;

SfSignaturePad signaturePad = new SfSignaturePad
{
    StrokeColor = Color.Red,
    MinimumStrokeWidth = 1,
    MaximumStrokeWidth = 6,
};
signaturePad.StrokeCompleted += OnStrokeCompleted;

private void OnStrokeCompleted(object sender, EventArgs e)
{
    var image = signaturePad.GetSignatureImage();
    signaturePad.Clear();
}
```

```csharp
// .NET MAUI
using Syncfusion.Maui.SignaturePad;

SfSignaturePad signaturePad = new SfSignaturePad
{
    StrokeColor = Colors.Red,
    MinimumStrokeThickness = 1,
    MaximumStrokeThickness = 6,
};
signaturePad.DrawCompleted += OnDrawCompleted;
this.Content = signaturePad;

private void OnDrawCompleted(object? sender, EventArgs e)
{
    ImageSource? source = signaturePad.ToImageSource();
    if (source is not null)
    {
        // Use the image source, for example, assign it to an Image control.
    }

    signaturePad.Clear();
}
```

## See Also

* [Getting Started with .NET MAUI SignaturePad](getting-started.md)
* [Customization in .NET MAUI SignaturePad](customization.md)
* [Events and Methods in .NET MAUI SignaturePad](events-and-methods.md)
* [SfSignaturePad API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html)