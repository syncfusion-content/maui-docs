---
layout: post
title: Events in .NET MAUI Bottom Sheet | Syncfusion®
description: Learn about event support in the Syncfusion® .NET MAUI Bottom Sheet (SfBottomSheet) control and more.
platform: maui
control: SfBottomSheet
documentation: UG
---

# Events in .NET MAUI Bottom Sheet

## StateChanged event

The [StateChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.BottomSheet.SfBottomSheet.html#Syncfusion_Maui_BottomSheet_SfBottomSheet_StateChanged) event is triggered when the [State](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.BottomSheet.SfBottomSheet.html#Syncfusion_Maui_BottomSheet_SfBottomSheet_State) property of the Bottom Sheet changes. This can occur either through user interaction, such as swiping the Bottom Sheet, or programmatically by setting the State property using XAML or C# code. The event's arguments are of type [StateChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.BottomSheet.StateChangedEventArgs.html) and provide the following properties:

* [NewState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.BottomSheet.StateChangedEventArgs.html#Syncfusion_Maui_BottomSheet_StateChangedEventArgs_NewState) : Gets the current state of the Bottom Sheet.
* [OldState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.BottomSheet.StateChangedEventArgs.html#Syncfusion_Maui_BottomSheet_StateChangedEventArgs_OldState) : Gets the previous state of the Bottom Sheet.

{% tabs %}
{% highlight xaml %}

<bottomSheet:SfBottomSheet x:Name="bottomSheet" StateChanged="OnStateChanged">
    <bottomSheet:SfBottomSheet.BottomSheetContent>
        <Grid/>
    </bottomSheet:SfBottomSheet.BottomSheetContent>
</bottomSheet:SfBottomSheet>

{% endhighlight %}
{% highlight c# %}

SfBottomSheet bottomSheet = new SfBottomSheet();
Grid grid = new Grid();
bottomSheet.BottomSheetContent = grid;
this.Content = bottomSheet; 
bottomSheet.StateChanged += OnStateChanged;

{% endhighlight %}
{% endtabs %}

{% highlight c# %}

private void OnStateChanged(object sender, StateChangedEventArgs args)
{
    // Codes that need to be executed once the Sheet's state value is Changed.
}

{% endhighlight %}