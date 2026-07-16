---
layout: post
title: Events and Commands in .NET MAUI Popup (SfPopup) | Syncfusion®
description: Learn about the events and commands available in the Syncfusion® .NET MAUI Popup (SfPopup) control and more.
platform: MAUI
control: SfPopup
documentation: ug
--- 

# Events and Commands in .NET MAUI Popup (SfPopup)

The SfPopup control provides the following five built-in events:

* PositionChanging
* Opening
* Opened
* Closing
* Closed

## PositionChanging event

The `PositionChanging` event allows you to customize the position of the Popup before it opens. This event is triggered before the Popup is displayed, giving you the flexibility to modify its location dynamically. When the PositionChanging event occurs, it provides an instance of `PopupPositionChangingEventArgs`, which contains the following members:

* `Bounds` : Represents the current bounds of the Popup.
* `MoveTo` : Specifies the new position where the Popup should be moved. You can assign a custom position to this property.
* `Handled` : Must be set to `true` for the `MoveTo` value to take effect. If `Handled` is not set, the Popup will retain its original position.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6" %}
<ContentPage xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="PopupEventsSample.MainPage">
    <StackLayout>
        <Button Text="Open Popup" Clicked="OnOpenPopupClicked" />
        <sfPopup:SfPopup x:Name="popup"
                         PositionChanging="OnPopupPositionChanging"/>
    </StackLayout>
</ContentPage>
{%endhighlight%}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9" %}
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Popup;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        popup.PositionChanging += OnPopupPositionChanging;
    }

    private void OnOpenPopupClicked(object sender, EventArgs e)
    {
        popup.IsOpen = true;
    }

    private void OnPopupPositionChanging(object sender, PopupPositionChangingEventArgs e)
    {
        e.MoveTo = new Point(50, 100);
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Opening event

The [Opening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Opening) event is raised before the Popup is displayed. It can cancel the Popup from opening with `CancelEventArgs` that contains the following property:

* `Cancel`: Set to `true` to cancel the Popup from opening.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="PopupEventsSample.MainPage">
    <StackLayout>
        <Button Text="Open Popup" Clicked="OnOpenPopupClicked" />
        <sfPopup:SfPopup x:Name="popup" Opening="Popup_Opening"/>
    </StackLayout>
</ContentPage>
{%endhighlight%}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9" %}
using System.ComponentModel;
using Syncfusion.Maui.Popup;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        popup.Opening += Popup_Opening;
    }

    private void OnOpenPopupClicked(object sender, EventArgs e)
    {
        popup.IsOpen = true;
    }

    private void Popup_Opening(object sender, CancelEventArgs e)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

> **Note**: The `xmlns:sfPopup` namespace declaration is required for the `SfPopup` tag to resolve. See [Getting Started](getting-started.md) for the full namespace and NuGet package setup.

## Opened event

The [Opened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Opened) event is raised after the Popup is displayed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="PopupEventsSample.MainPage">
    <StackLayout>
        <Button Text="Open Popup" Clicked="OnOpenPopupClicked" />
        <sfPopup:SfPopup x:Name="popup" Opened="Popup_Opened"/>
    </StackLayout>
</ContentPage>
{%endhighlight%}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9" %}
using System;
using Syncfusion.Maui.Popup;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        popup.Opened += Popup_Opened;
    }

    private void OnOpenPopupClicked(object sender, EventArgs e)
    {
        popup.IsOpen = true;
    }

    private void Popup_Opened(object sender, EventArgs e)
    {
        // Code that needs to be executed once the popup is visible on the screen.
    }
}
{% endhighlight %}
{% endtabs %}

> **Note**: The `xmlns:sfPopup` namespace declaration is required for the `SfPopup` tag to resolve. See [Getting Started](getting-started.md) for the full namespace and NuGet package setup.

## Closing event

The [Closing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Closing) event is raised when the Popup is about to close. It can cancel the Popup from closing with `CancelEventArgs` that contains the following property:

* `Cancel`: Set to `true` to cancel the Popup from closing.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="PopupEventsSample.MainPage">
    <StackLayout>
        <Button Text="Open Popup" Clicked="OnOpenPopupClicked" />
        <sfPopup:SfPopup x:Name="popup" Closing="Popup_Closing"/>
    </StackLayout>
</ContentPage>
{%endhighlight%}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9" %}
using System.ComponentModel;
using Syncfusion.Maui.Popup;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        popup.Closing += Popup_Closing;
    }

    private void OnOpenPopupClicked(object sender, EventArgs e)
    {
        popup.IsOpen = true;
    }

    private void Popup_Closing(object sender, CancelEventArgs e)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

N> The `xmlns:sfPopup` namespace declaration is required for the `SfPopup` tag to resolve. See [Getting Started](getting-started.md) for the full namespace and NuGet package setup.

## Closed event

The [Closed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Closed) event is raised after the Popup has been dismissed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="PopupEventsSample.MainPage">
    <StackLayout>
        <Button Text="Open Popup" Clicked="OnOpenPopupClicked" />
        <sfPopup:SfPopup x:Name="popup" Closed="Popup_Closed"/>
    </StackLayout>
</ContentPage>
{%endhighlight%}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9" %}
using System;
using Syncfusion.Maui.Popup;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        popup.Closed += Popup_Closed;
    }

    private void OnOpenPopupClicked(object sender, EventArgs e)
    {
        popup.IsOpen = true;
    }

    private void Popup_Closed(object sender, EventArgs e)
    {
        // Code that needs to be executed once popup is completely closed.
    }
}
{% endhighlight %}
{% endtabs %}

## Accept command

The [AcceptCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AcceptCommand) is invoked when the Accept button in the Popup footer is clicked.

To bind the Accept button to a custom command,

* Create a class that implements `ICommand`.
* Return `false` from `CanExecute()` to prevent the Popup from closing; `Execute()` will not be invoked.
* Return `true` from `CanExecute()` to allow the Popup to close and perform the required operations inside `Execute()`.
* Expose a property of your custom command type in the view model and initialize it.
* Bind that property to `AcceptCommand` in XAML.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="18" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:Popup"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="Popup.MainPage">
    <ContentPage.BindingContext>
        <local:PopupViewModel />
    </ContentPage.BindingContext>
    <StackLayout>
        <Button  Text="ClickToShowPopup"
                 VerticalOptions="Center"
                 HorizontalOptions="Center"
                 Command="{Binding PopupCommand}" />
        <sfPopup:SfPopup IsOpen="{Binding PopupOpen}"
                         ShowFooter="True"
                         AppearanceMode="TwoButton"
                         AcceptButtonText="OK"
                         AcceptCommand="{Binding PopupAcceptCommand}">
        </sfPopup:SfPopup>
    </StackLayout>
</ContentPage>
{% endhighlight %}

{% highlight c# tabtitle="PopupViewModel.cs" %}
using System.ComponentModel;
using System.Windows.Input;

public class PopupViewModel : INotifyPropertyChanged
{
    bool isOpen;
    public event PropertyChangedEventHandler PropertyChanged;
    void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public ICommand PopupAcceptCommand { get; set; }
    public ICommand PopupCommand { get; set; }
    public bool PopupOpen
    {
        get
        {
            return isOpen;
        }
        set
        {
            isOpen = value;
            OnPropertyChanged(nameof(PopupOpen));
        }
    }
    public PopupViewModel()
    {
        PopupAcceptCommand = new Command(PopupAccept); // CanExecute() will call the PopupAccept method
        PopupCommand = new Command(Popup);
    }

    private void Popup()
    {
        PopupOpen = true;
    }

    private void PopupAccept()
    {
        // You can write your set of code that needs to be executed.
    }
}
{% endhighlight %}

{% endtabs %}

## Decline command

The [DeclineCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_DeclineCommand) is invoked when the Decline button in the Popup footer is clicked.

To bind the Decline button to a custom command,

* Create a class that implements `ICommand`.
* Return `false` from `CanExecute()` to prevent the Popup from closing; `Execute()` will not be invoked.
* Return `true` from `CanExecute()` to allow the Popup to close and perform the required operations inside `Execute()`.
* Expose a property of your custom command type in the view model and initialize it.
* Bind that property to `DeclineCommand` in XAML.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="18" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:Popup"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             x:Class="Popup.MainPage">
    <ContentPage.BindingContext>
        <local:PopupViewModel />
    </ContentPage.BindingContext>
    <StackLayout>
        <Button  Text="ClickToShowPopup"
                 VerticalOptions="Center"
                 HorizontalOptions="Center"
                 Command="{Binding PopupCommand}" />
        <sfPopup:SfPopup IsOpen="{Binding PopupOpen}"
                         ShowFooter="True"
                         AppearanceMode="TwoButton"
                         DeclineButtonText="Cancel"
                         DeclineCommand="{Binding PopupDeclineCommand}">
        </sfPopup:SfPopup>
    </StackLayout>
</ContentPage>


{% endhighlight %}

{% highlight c# tabtitle="PopupViewModel.cs" %}
using System.ComponentModel;
using System.Windows.Input;

public class PopupViewModel : INotifyPropertyChanged
{
    bool isOpen;
    public event PropertyChangedEventHandler PropertyChanged;
    void OnPropertyChanged(string propertyName)
    {
       PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public ICommand PopupDeclineCommand { get; set; }
    public ICommand PopupCommand { get; set; }
    public bool PopupOpen 
    {
        get 
        { 
            return isOpen; 
        }
        set
        {
            isOpen = value;
            OnPropertyChanged(nameof(PopupOpen));
        } 
    }
    public PopupViewModel()
    {
        PopupDeclineCommand = new Command(PopupDecline); // CanExecute() will execute the PopupDecline method
        PopupCommand = new Command(Popup);
    }

    private void Popup()
    {
       PopupOpen = true;
    }

    private void PopupDecline()
    {
        // You can write your set of code that needs to be executed.
    }
}
{% endhighlight %}

{% endtabs %}
