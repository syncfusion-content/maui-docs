---
layout: post
title: MVVM in .NET MAUI Popup control | Syncfusion®
description: Learn here all about MVVM support in the Syncfusion® .NET MAUI Popup (SfPopup) control, its elements, and more.
platform: MAUI
control: SfPopup
documentation: ug
---

# Working with MVVM in MAUI Popup (SfPopup)

`SfPopup` can be easily used in MVVM-based applications. In the following example, the [SfPopup.IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_IsOpen) property is bound to a property in the `ViewModel` based on which the popup is opened or closed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="13 15" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             xmlns:local="clr-namespace:PopupMVVM"
             x:Class="PopupMVVM.MainPage">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <VerticalStackLayout Padding="20">
            <Button x:Name="clickToShowPopup" Text="ClickToShowPopup"
                    VerticalOptions="Start" HorizontalOptions="Center"
                    Command="{Binding OpenPopupCommand}" />
            <sfPopup:SfPopup x:Name="sfPopup"
                             IsOpen="{Binding IsOpen}">
            </sfPopup:SfPopup>
        </VerticalStackLayout>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class ViewModel : INotifyPropertyChanged
{
    private bool isOpen;
    public ICommand OpenPopupCommand { get; set; }

    public bool IsOpen
    {
        get
        {
            return isOpen;
        }
        set
        {
            isOpen = value;
            OnPropertyChanged(nameof(IsOpen));
        }
    }

    public ViewModel()
    {
        OpenPopupCommand = new Command(OnOpenPopup);
    }

    private void OnOpenPopup()
    {
        IsOpen = true;
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (this.PropertyChanged != null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion
}
{% endhighlight %}
{% endtabs %}

## How to use commands with popup buttons?

`SfPopup` provides command support for the popup buttons,

 * [SfPopup.AcceptCommand](https://help.syncfusion.com/maui/popup/popup-events#accept-command)

 * [SfPopup.DeclineCommand](https://help.syncfusion.com/maui/popup/popup-events#decline-command)

## How to define a reusable popup view?

To use the `SfPopup` as a page, create a new XAML file with an `SfPopup` instance. You can use this XAML file instance (SfPopup view) across any file in your project wherever you may want to display a popup, thus allowing you to re-use the same instance of the popup where you can modify or change the required properties alone based on the current context to be displayed.

The following code sample shows how to create a popup in a XAML file. We have created a simple popup to display an error message to users on an unsuccessful login.

{% tabs %}
{% highlight xaml tabtitle="PopupPage.xaml" %}
<sfPopup:SfPopup xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                 xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                 x:Class="PopupMVVM.PopupPage"
                 xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
                 x:Name="sfPopup">
    <sfPopup:SfPopup.HeaderTemplate>
        <DataTemplate>
            <StackLayout>
                <Label Text="Login failed" HorizontalTextAlignment="Center"/>
            </StackLayout>
        </DataTemplate>
    </sfPopup:SfPopup.HeaderTemplate>
    <sfPopup:SfPopup.ContentTemplate>
        <DataTemplate>
            <StackLayout>
                <Label Text="Incorrect credentials" VerticalOptions="Center"/>
            </StackLayout>
        </DataTemplate>
    </sfPopup:SfPopup.ContentTemplate>
</sfPopup:SfPopup>
{% endhighlight %}
{% highlight c# tabtitle="PopupPage.xaml.cs" %}
using Syncfusion.Maui.Popup;

public partial class PopupPage : SfPopup
{
    public PopupPage()
    {
        InitializeComponent();
    }
}
{% endhighlight %}
{% endtabs %}

The following sample shows how to consume the previously created SfPopup view from inside a different content page.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="29" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="PopupMVVM.MainPage"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             xmlns:local="clr-namespace:PopupMVVM">                
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <StackLayout Orientation="Vertical">
            <Grid Padding="20" ColumnSpacing="10" RowSpacing="20">
                <Grid.RowDefinitions>
                    <RowDefinition Height="50"/>
                    <RowDefinition Height="50"/>
                    <RowDefinition Height="Auto"/>
                </Grid.RowDefinitions>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="Auto"/>
                    <ColumnDefinition Width="*"/>
                </Grid.ColumnDefinitions>
                <Label Text="User Name:" Grid.Row="0" Grid.Column="0" VerticalTextAlignment="Center"/>
                <Entry Text="{Binding UserName}" Grid.Row="0" Grid.Column="1"/>
                <Label Text="Password:" Grid.Row="1" Grid.Column="0" VerticalTextAlignment="Center" />
                <Entry Text="{Binding Password}" Grid.Row="1" Grid.Column="1" IsPassword="True"/>
                <Button Grid.Row="2" Grid.ColumnSpan="2" x:Name="LoginButton" Text="Login" 
                        Command="{Binding LoginCommand}" HorizontalOptions="Center" />
            </Grid>      
            <local:PopupPage x:Name="popup" 
                             IsOpen="{Binding IsOpen}">                         
            </local:PopupPage>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Microsoft.Maui.Controls;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class ViewModel : INotifyPropertyChanged
{
    #region Fields

    private bool isOpen;
    private string labelString, userName, password;

    #endregion

    #region Properties

    public ICommand LoginCommand { get; set; }

    public string LabelString
    {
        get { return labelString; }
        set
        {
            labelString = value;
            OnPropertyChanged(nameof(LabelString));
        }
    }
    public string UserName
    {
        get { return userName; }
        set
        {
            userName = value;
            OnPropertyChanged(nameof(UserName));
        }
    }
    public string Password
    {
        get { return password; }
        set
        {
            password = value;
            OnPropertyChanged(nameof(Password));
        }
    }
    public bool IsOpen
    {
        get { return isOpen; }
        set
        {
            isOpen = value;
            OnPropertyChanged(nameof(IsOpen));
        }
    }

    #endregion

    public ViewModel()
    {
        LoginCommand = new Command(OnLogin);
    }

    // Executed when the login button is clicked.
    private void OnLogin()
    {
        // You can write your set of codes that needs to be executed.
        if ((UserName != "Syncfusion") || (Password != "12345"))
        {
            // If credentials are incorrect show the error message as popup.
            LabelString = "Login failed";
            IsOpen = true;
        }
        else
        {
            LabelString = "Login successful";
        }
    }

    #region PropertyChanged

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;
    
    #endregion
}
{% endhighlight %}
{% endtabs %}

## How to retrieve a text value from an Entry control in the popup's ContentTemplate?

This can be done by binding the `Text` property of the `Entry` to a property in the `ViewModel`.

Refer to the following code example to retrieve a text value from an Entry control in the popup's `ContentTemplate`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="PopupMVVM.MainPage"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             xmlns:local="clr-namespace:PopupMVVM">         
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <StackLayout Padding="20" Spacing="20">
            <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" 
                    VerticalOptions="Start" HorizontalOptions="Center" 
                    Command="{Binding ShowPopupCommand}" />           
            <Label Text="{Binding ShowDetail}"
                   VerticalOptions="Center"
                   HorizontalOptions="Center"
                   LineBreakMode="NoWrap"
                   BackgroundColor="Blue"
                   TextColor="Red"
                   IsVisible="{Binding Visible}"/>               
            <sfPopup:SfPopup x:Name="sfPopup"     
                             IsOpen="{Binding PopupOpen}"
                             ShowFooter="True"
                             AppearanceMode="TwoButton"
                             AcceptButtonText="Login" 
                             DeclineButtonText="Exit"         
                             AcceptCommand="{Binding PopupAcceptCommand}"
                             AutoSizeMode="Both">
                <sfPopup:SfPopup.HeaderTemplate>
                    <DataTemplate>
                        <Label Text="{Binding LabelString}" HorizontalOptions="Center"/>
                    </DataTemplate>
                </sfPopup:SfPopup.HeaderTemplate>
                <sfPopup:SfPopup.ContentTemplate>
                    <DataTemplate>
                        <Grid Padding="20" ColumnSpacing="10" RowSpacing="20">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="50"/>
                                <RowDefinition Height="50"/>                                
                            </Grid.RowDefinitions>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="Auto"/>
                                <ColumnDefinition Width="*"/>
                            </Grid.ColumnDefinitions>
                            <Label Text="User Name:" Grid.Row="0" Grid.Column="0" VerticalTextAlignment="Center"/>
                            <Entry Text="{Binding UserName}" Grid.Row="0" Grid.Column="1"/>
                            <Label Text="Password:" Grid.Row="1" Grid.Column="0" VerticalTextAlignment="Center" />
                            <Entry Text="{Binding Password}" Grid.Row="1" Grid.Column="1" IsPassword="True"/>                            
                        </Grid>
                    </DataTemplate>
                </sfPopup:SfPopup.ContentTemplate>               
            </sfPopup:SfPopup>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Microsoft.Maui.Controls;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class ViewModel : INotifyPropertyChanged
{
    #region Fields

    private bool isOpen;
    private bool visible;
    private string labelString;
    private string userName;
    private string password;
    private string showdetail;

    #endregion

    #region Properties

    public ICommand PopupAcceptCommand { get; set; }
    public ICommand ShowPopupCommand { get; set; }

    public string LabelString
    {
        get { return labelString; }
        set
        {
            labelString = value;
            OnPropertyChanged(nameof(LabelString));
        }
    }
    public string UserName
    {
        get { return userName; }
        set
        {
            userName = value;
            OnPropertyChanged(nameof(UserName));
        }
    }
    public string ShowDetail
    {
        get { return showdetail; }
        set
        {
            showdetail = value;
            OnPropertyChanged(nameof(ShowDetail));
        }
    }
    public string Password
    {
        get { return password; }
        set
        {
            password = value;
            OnPropertyChanged(nameof(Password));
        }
    }
    public bool PopupOpen
    {
        get { return isOpen; }
        set
        {
            isOpen = value;
            OnPropertyChanged(nameof(PopupOpen));
        }
    }
    public bool Visible
    {
        get { return visible; }
        set
        {
            visible = value;
            OnPropertyChanged(nameof(Visible));
        }
    }

    #endregion

    #region Constructor

    public ViewModel()
    {
        PopupAcceptCommand = new Command(PopupAccept); // Invokes the PopupAccept method.
        ShowPopupCommand = new Command(OnShowPopupClicked);  // Invokes the OnShowPopupClicked method.
    }

    #endregion

    #region Methods

    private void OnShowPopupClicked()
    {
        PopupOpen = true;
        LabelString = "User Login";
        Visible = true;
    }

    private void PopupAccept()
    {
        // You can write your set of codes that needs to be executed.
        if ((UserName == "Syncfusion") && (Password == "12345"))
        {
            ShowDetail = "Login Successful";
            UserName = "";
            Password = "";
        }
        else
        {
            ShowDetail = "Login Failed";
            UserName = "";
            Password = "";
        }
    }

    #endregion

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
{% endhighlight %}
{% endtabs %}
