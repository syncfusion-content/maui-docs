---
layout: post
title: Events in .NET MAUI DatePicker control | Syncfusion
description: Learn here all about the Command support in Syncfusion .NET MAUI Date Picker (SfDatePicker) control and more details.
platform: maui
control: SfDatePicker
documentation: ug
---

# Commands

## SelectionChangedCommand

The [SelectionChangedCommand]() is triggered whenever the selection index in the picker changes, with the `DatePickerSelectionChangedEventArgs` passed as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                    SelectionChangedCommand="{Binding SelectionChangedCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,5,7" %}

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

## AcceptCommand

The [AcceptCommand]() is triggered whenever confirm button tapped on date picker.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                    AcceptCommand="{Binding AcceptCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,5,7" %}

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

## DeclineCommand

The [DeclineCommand]() is triggered whenever the cancel button tapped on date picker.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                    DeclineCommand="{Binding DeclineCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,5,7" %}

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