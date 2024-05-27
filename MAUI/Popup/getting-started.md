---
layout: post
title: Getting Started with .NET MAUI Popup control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Popup (SfPopup) control, its elements and more.
platform: MAUI
control: SfPopup
documentation: ug
---

# Getting Started with .NET MAUI Popup (SfPopup)

This section provides a quick overview of how to get start with the .NET MAUI Popup (SfPopup) for MAUI. Walk through the entire process of creating the real-world SfPopup.

To get start quickly with .NET MAUI Popup, you can check on this video:
<style>#MAUIPopupVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIPopupVideoTutorial' src='https://www.youtube.com/embed/HTk6JAGP-qE'></iframe>

## Creating an application using the .NET MAUI Popup

 1. Create a new .NET MAUI application in Visual Studio.
 2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfPopup to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Popup and install it.
 3. Import the control namespace `Syncfusion.Maui.Popup` in XAML or C# code.
 4. Initialize the [SfPopup](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html) control.
 
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup">

    <syncfusion:SfPopup />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Popup;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfPopup popup = new SfPopup();
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The `Syncfusion.Maui.Core` NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight c# tabtitle="MauiProgram.cs" hl_lines="4 20" %}
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace GettingStarted
{
    public class MauiProgram 
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.ConfigureSyncfusionCore();
            return builder.Build();
        }
    }
}
{% endhighlight %} 
{% endtabs %}

## Displaying popup

Display a popup over your view by calling the [Show](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_Boolean_) method.

Refer to the following code example for displaying popup.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage" 
             Padding="0,40,0,0">
     <StackLayout x:Name="mainLayout">
       <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" 
               VerticalOptions="Start" HorizontalOptions="Center"
               Clicked="ClickToShowPopup_Clicked" />
               <popup:SfPopup x:Name="popup" />
     </StackLayout>
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="12" %}
namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClickToShowPopup_Clicked(object sender, EventArgs e)
        {
            popup.Show();
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Popup with default appearance](Images/getting-started//maui-popup-with-default-appearance.png)

Download the source code of this sample [here](https://github.com/SyncfusionExamples/getting-started-.net-maui-popup).

## Dismissing popup

To close the popup programmatically, you can call either the [Dismiss](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Dismiss) method or set the IsOpen property to false.

Refer to the following code example for dismissing popup.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4 7" %}
    
    private void ClickToDismissPopup_Clicked(object sender, EventArgs e)
    {
        // Dismiss SfPopup from the view.
        sfPopup.Dismiss();

        // Or
        sfPopup.IsOpen = false;
    }
{% endhighlight %} 
{% endtabs %}

## Customize positioning

The .NET MAUI Popup (SfPopup) allows showing the popup content at various positions.

The following list of options is available to position the SfPopup in the desired position:

* `Center Positioning`: Use the [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_IsOpen) property or [Show](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_Boolean_) method to display the SfPopup at the center.
* `Absolute Positioning`: Use the [Show(x-position, y-position)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_Double_System_Double_) to display the SfPopup at the specified X and y position.
* `Relative Positioning`: Use the [ShowRelativeToView(View, RelativePosition)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowRelativeToView_Microsoft_Maui_Controls_View_Syncfusion_Maui_Popup_PopupRelativePosition_System_Double_System_Double_) to display the SfPopup at any of the 8 positions relative to the specified view.
* `Absolute relative positioning`: Use the [ShowRelativeToView(View, RelativePosition,x position,y position)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowRelativeToView_Microsoft_Maui_Controls_View_Syncfusion_Maui_Popup_PopupRelativePosition_System_Double_System_Double_) to display the SfPopup at an absolute x,y coordinate from the relative position of the specified view.

## Customizing layouts

By default, choose a layout from the following available layouts in the SfPopup by using the [AppearanceMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AppearanceMode) property.

* [OneButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupButtonAppearanceMode.html#Syncfusion_Maui_Popup_PopupButtonAppearanceMode_OneButton): Shows the SfPopup with one button in the footer view. This is the default value.
* [TwoButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupButtonAppearanceMode.html#Syncfusion_Maui_Popup_PopupButtonAppearanceMode_TwoButton): Shows the SfPopup with two buttons in the footer view.

Also, customize the entire popupview by loading the templates or custom views for the header, body, and footer.

Refer to the following code example for displaying popup with appearance mode.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="11" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage" 
             Padding="0,40,0,0">
     <StackLayout x:Name="mainLayout">
       <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" 
               VerticalOptions="Start" HorizontalOptions="FillAndExpand"
               Clicked="ClickToShowPopup_Clicked" />
        <popup:SfPopup x:Name="popup"  ShowFooter="True" AppearanceMode="TwoButton"/>
     </StackLayout>
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="13 14" %}
using Syncfusion.Maui.Popup;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        SfPopup popup;

        public MainPage()
        {
            InitializeComponent();
            popup = new SfPopup();
            popup.ShowFooter = true;
            popup.AppearanceMode = Syncfusion.Maui.Popup.PopupButtonAppearanceMode.TwoButton;
        }

        private void ClickToShowPopup_Clicked(object sender, EventArgs e)
        {
            popup.Show();
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Popup with Appearance Mode](Images/getting-started//maui-popup-with-appearance-mode.png)

###  Load your template view in the popup body

Any view can be added as popup content by using the [ContentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ContentTemplate) property to refresh it. Refer to the following code example in which a label is added as popup content. 

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="15" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage" 
             Padding="0,40,0,0"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup">
    <StackLayout>
        <Button x:Name="clickToShowPopup"
                Text="ClickToShowPopup"
                VerticalOptions="Start"
                HorizontalOptions="FillAndExpand"
                Clicked="ClickToShowPopup_Clicked" />
        <sfPopup:SfPopup x:Name="popup">
            <sfPopup:SfPopup.ContentTemplate>
                <DataTemplate>
                    <Label Text="This is the Customized view for SfPopup"
                           BackgroundColor="SkyBlue"
                           VerticalTextAlignment="Center"
                           HorizontalTextAlignment="Center" />
                </DataTemplate>
            </sfPopup:SfPopup.ContentTemplate>
        </sfPopup:SfPopup>
    </StackLayout>
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="23"%}
using Syncfusion.Maui.Popup;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        DataTemplate templateView;
        Label popupContent;

        public MainPage()
        {
            InitializeComponent();            
            templateView = new DataTemplate(() =>
            {
                popupContent = new Label();
                popupContent.Text = "This is the Customized view for SfPopup";
                popupContent.BackgroundColor = Color.LightSkyBlue;
                popupContent.HorizontalTextAlignment = TextAlignment.Center;
                return popupContent;
            });

            // Adding ContentTemplate of the SfPopup
            popup.ContentTemplate = templateView;
        }

        private void ClickToShowPopup_Clicked(object sender, EventArgs e)
        {
            popup.Show();
        }
    } 
}

{% endhighlight %}

{% endtabs %}

![Popup with custom content](Images/getting-started//maui-popup-with-custom-content.png)
