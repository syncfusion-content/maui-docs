---
layout: post
title: Popup Events and Commands in .NET MAUI Popup control | Syncfusion
description: Learn all about Popup Events And Commands support in the Syncfusion .NET MAUI Popup (SfPopup) control and more.
platform: MAUI
control: SfPopup
documentation: ug
--- 

# Popup Events And Commands in .NET MAUI Popup (SfPopup)

There are five built-in events in the SfPopup control namely:

* PositionChanging
* Opening
* Opened
* Closing
* Closed

## PositionChanging Event

The `PositionChanging` event allows you to customize the position of the popup before it opens. This event is triggered before the popup is displayed, giving you the flexibility to modify its location dynamically. When the PositionChanging event occurs, it provides an instance of `PopupPositionChangingEventArgs`, which contains the following members:

* `Bounds` : Represents the current bounds of the popup.
* `MoveTo` : Specifies the new position where the popup should be moved. You can assign a custom position to this property.
* `Handled` : Must be set to `true` for the `MoveTo` value to take effect. If `Handled` is not set, the popup will retain its original position.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
<sfPopup:SfPopup x:Name="popup"
                 PositionChanging="Popup_PositionChanging"/>
{%endhighlight%}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4 9 10" %}
public MainPage()
{
    InitializeComponent();
    popup.PositionChanging += myPopup_PositionChanging;
}

private void Popup_PositionChanging(object sender, PopupPositionChangingEventArgs e)
{
    e.MoveTo = new Point(50, 100); 
    e.Handled = true;
}

{% endhighlight %}
{% endtabs %}

## Opening event

The [Opening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Opening) event will be fired whenever opening the Popup in the application. It can cancel popup opening with `CancelEventArgs` that contains the following property:

* `Cancel`: Popup opening is based on this value.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<sfPopup:SfPopup x:Name="popup" Opening="popup_Opening"/>
{%endhighlight%}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4 9" %}
public MainPage()
{
    InitializeComponent();
    popup.Opening += Popup_Opening;
}

private void Popup_Opening(object sender, System.ComponentModel.CancelEventArgs e)
{
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Opened event

The [Opened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Opened) event will be fired whenever displaying the Popup in the application.

You can execute your own set of codes once the popup is opened, and visible in the application in its respective event handler.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<sfPopup:SfPopup x:Name="popup" Opened="popup_Opened"/>
{%endhighlight%}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}
public MainPage()
{
    InitializeComponent();
    popup.Opened += Popup_Opened;
}

private void Popup_Opened(object sender, EventArgs e)
{
   // Codes that need to be executed once the popup is visible on the screen.
}
{% endhighlight %}
{% endtabs %}

## Closing event

The [Closing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Closing) event will be fired whenever closing the Popup in the application. It can cancel the popup closing with `CancelEventArgs` that contains the following property:

* `Cancel`: Popup closing is based on this value.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<sfPopup:SfPopup x:Name="popup"  Closing="Popup_Closing"/>
{%endhighlight%}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4 9" %}
public MainPage()
{
    InitializeComponent();
    popup.Closing += Popup_Closing;
}

private void Popup_Closing(object sender, System.ComponentModel.CancelEventArgs e)
{
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Closed event

The [Closed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Closed) event will be fired whenever dismissing the Popup from the view.

You can execute your own set of codes once the popup is completely closed in its respective event handler.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<sfPopup:SfPopup x:Name="popup" Closed="Popup_Closed"/>
{%endhighlight%}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4" %}
public MainPage()
{
    InitializeComponent();
    popup.Closed += Popup_Closed;
}

private void Popup_Closed(object sender, EventArgs e)
{
    // Codes that needs to be executed once popup is completely closed.
}
{% endhighlight %}
{% endtabs %}

## Accept command

The [AcceptCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AcceptCommand) will be fired when clicking the Accept button in the popup footer.

To handle the Accept button,

* Derive a class from the `ICommand`, and implement its interface.
* To prevent the popup from closing, return false in the `CanExecute()` override method and the `Execute()` override method will not be fired.
* Else return true in the `CanExecute()` override method and do the required operations in the `Execute()` method.
* Now, create a property of your custom command type in the view model class and initialize it.
* Bind the property in the view model to the `AcceptCommand` in XAML.

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
                         AcceptCommand="{Binding PopupAcceptCommand}">
        </sfPopup:SfPopup>
    </StackLayout>
</ContentPage>
{% endhighlight %}

{% highlight c# tabtitle="PopupViewModel.cs" hl_lines="25" %}
class PopupViewModel : INotifyPropertyChanged
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
        PopupAcceptCommand = new Command(PopupAccept); //CanExecute() will be call the PopupAccept method
        PopupCommand = new Command(Popup);
    }

    private void Popup()
    {
        PopupOpen = true;
    }

    private void PopupAccept()
    {
        // You can write your set of codes that needs to be executed.
    }
}
{% endhighlight %}

{% endtabs %}

## Decline command

The [DeclineCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_DeclineCommand) will be fired when clicking the Decline button in the popup footer. 

To handle the Decline button,

* Derive a class from the ICommand, and implement its interface.
* To prevent the popup from closing, return false in the `CanExecute()` override method and the `Execute()` override method will not be fired.
* Else return true in the `CanExecute()` override method and do the required operations in the `Execute()` method.
* Now, create a property of your custom command type in the view model class and initialize it.
* Bind the property in the view model to the `DeclineCommand` in XAML.

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
                         DeclineCommand="{Binding PopupDeclineCommand}">
        </sfPopup:SfPopup>
    </StackLayout>
</ContentPage>


{% endhighlight %}

{% highlight c# tabtitle="PopupViewModel.cs" hl_lines="25" %}
class PopupViewModel : INotifyPropertyChanged
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
        PopupDeclineCommand = new Command(PopupDecline); //CanExecute() will be execute the PopupDecline method
        PopupCommand = new Command(Popup);
    }

    private void Popup()
    {
       PopupOpen = true;
    }

    private void PopupDecline()
    {
        // You can write your set of codes that needs to be executed.
    }
}
{% endhighlight %}

{% endtabs %}
