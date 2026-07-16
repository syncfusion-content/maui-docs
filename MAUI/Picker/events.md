---
layout: post
title: Events with .NET MAUI Picker Control | Syncfusion®
description: Learn here all about events with Syncfusion Essential .NET MAUI Picker (SfPicker) control, it's elements and more details.
platform: maui
control: SfPicker
documentation: ug
---

# Events in .NET MAUI Picker (SfPicker)

Six events are available for a [.NET MAUI Picker](https://www.syncfusion.com/maui-controls/maui-picker) when it is in Dialog mode:

 * Opened
 * Closing
 * Closed
 * SelectionChanged
 * OkButtonClicked
 * CancelButtonClicked

## Opened

The [Opened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened) event occurs when the picker pop-up is opened.

## Closing

The [Closing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing) event is raised when the picker pop-up is closing. Prevent the picker pop-up from closing by setting `e.Cancel` to true.

## Closed

The [Closed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed) event is raised after the picker pop-up is closed.

## SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html#Syncfusion_Maui_Picker_SfPicker_SelectionChanged) event is raised after the selected index changes on the `SfPicker`.

N>
* In `SfPicker`, the [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedIndex) and [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedItem) properties are updated only when the OK button in the footer view is tapped. This behavior applies when the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) is set to `Dialog` or `RelativeDialog`, the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Height) of the PickerFooterView is greater than zero, and [ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton) is enabled. This applies only when there is a single picker column.
* When [IsSelectionImmediate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsSelectionImmediate) is set to `true`, the [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedIndex) and [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedItem) are updated immediately upon selection.
* When [IsSelectionImmediate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsSelectionImmediate) is set to `false` by `default`, the selection is confirmed only when the OK button in the footer view is tapped.

## OkButtonClicked

The [OkButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked) event is raised after the `OK` button is clicked on the `SfPicker`. This event is not applicable while the footer view and `OK` button are not visible.

## CancelButtonClicked

The [CancelButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked) is raised after the Cancel button is clicked on the `SfPicker`. This event is not applicable while the footer view is not visible.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfPicker x:Name="picker"
                     Opened="picker_Opened"
                     Closed="picker_Closed"
                     Closing="picker_Closing"
                     SelectionChanged="picker_SelectionChanged"
                     OkButtonClicked="picker_OkButtonClicked"
                     CancelButtonClicked="picker_CancelButtonClicked">
    </picker:SfPicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Picker;
. . .
        SfPicker picker = new SfPicker();
        picker.Opened += Picker_Opened;
        picker.Closing += Picker_Closing;
        picker.Closed += Picker_Closed;
        picker.SelectionChanged += Picker_SelectionChanged;
        picker.OkButtonClicked += Picker_OkButtonClicked;
        picker.CancelButtonClicked += Picker_CancelButtonClicked;
        this.Content = picker;

    private void Picker_Opened(object sender, EventArgs e)
    {
        // Handle the open action.
    }

    private void Picker_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        // Stop the close action by setting `e.Cancel` to true.
    }

    private void Picker_Closed(object sender, EventArgs e)
    {
        // Hit after the picker is closed.
    }

    private void Picker_SelectionChanged(object sender, PickerSelectionChangedEventArgs e)
    {
        // Hit after the picker selected index is changed.
    }

    private void Picker_OkButtonClicked(object sender, EventArgs e)
    {
        // Handle the OK button click.
    }

    private void Picker_CancelButtonClicked(object sender, EventArgs e)
    {
        // Handle the Cancel button click.
    }

{% endhighlight %}
{% endtabs %}

## Commands

### SelectionChangedCommand

The SfPicker includes a built-in event called `SelectionChanged` that is triggered whenever the selection index in the picker changes. This event can be invoked through the [SelectionChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html#Syncfusion_Maui_Picker_SfPicker_SelectionChangedCommand), which passes the `PickerSelectionChangedEventArgs` as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <picker:SfPicker x:Name="picker"
                     SelectionChangedCommand="{Binding SelectionChangedCommand}"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

using Syncfusion.Maui.Picker;
. . .

public class ViewModel
{
    public ICommand SelectionChangedCommand { get; set; }
    public ViewModel()
    {
        SelectionChangedCommand = new Command(SelectionChanged);
    }
    private void SelectionChanged()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

### AcceptCommand

The SfPicker includes a built-in event called `OkButtonClicked`, which is triggered when the confirm button is tapped on the picker. This event can be invoked through the [AcceptCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_AcceptCommand).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <picker:SfPicker x:Name="picker"
                     AcceptCommand="{Binding AcceptCommand}"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

using Syncfusion.Maui.Picker;
. . .

public class ViewModel
{
    public ICommand AcceptCommand { get; set; }
    public ViewModel()
    {
        AcceptCommand = new Command(ActionButtonClicked);
    }
    private void ActionButtonClicked()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

### DeclineCommand

The SfPicker includes a built-in event called `CancelButtonClicked`, which is triggered when the cancel button is tapped on the picker. This event can be invoked through the [DeclineCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DeclineCommand).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <picker:SfPicker x:Name="picker"
                     DeclineCommand="{Binding DeclineCommand}"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

using Syncfusion.Maui.Picker;
. . .

public class ViewModel
{
    public ICommand DeclineCommand { get; set; }
    public ViewModel()
    {
        DeclineCommand = new Command(ActionButtonCanceled);
    }
    private void ActionButtonCanceled()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}