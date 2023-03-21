---
layout: post
title: Styles in .NET MAUI Popup control | Syncfusion
description: Learn here all about Styles support in Syncfusion .NET MAUI Popup (SfPopup) control, its elements and more.
platform: MAUI
control: SfPopup
documentation: ug
--- 

# Styles in .NET MAUI Popup (SfPopup)

The SfPopup applies style to all of its elements by using the `SfPopup.PopupStyle` property.

## Styling popup header

The SfPopup allows customizing the header elements with various header customizations as follows:

<table>
<tr>
<th> Property </th>
<th> Description </th>
</tr>
<tr>
<td> SfPopup.PopupStyle.HeaderBackground </td>
<td> Gets or sets the background color for the header.</td>
</tr>
<tr>
<td> SfPopup.PopupStyle.HeaderFontAttribute </td>
<td> Gets or sets the font attribute for the header title.</td>
</tr>
<tr>
<td> SfPopup.PopupStyle.HeaderFontFamily </td>
<td> Gets or sets the font style for the header title.</td>
</tr>
<tr>
<td> SfPopup.PopupStyle.HeaderFontSize </td>
<td> Gets or sets the font size for the header title.</td>
</tr>
<tr>
<td> SfPopup.PopupStyle.HeaderTextAlignment </td>
<td> Gets or sets the text alignment for the header.</td>
</tr>
<tr>
<td> SfPopup.PopupStyle.HeaderTextColor </td>
<td> Gets or sets the text color to be applied for the header title.</td>
</tr>
</table>

Refer to the following code example for customizing the header elements.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4 5 6 7 8 9" %}

<sfPopup:SfPopup x:Name="popup" >
    <sfPopup:SfPopup.PopupStyle>
        <sfPopup:PopupStyle HeaderBackground="DimGray"
                            HeaderFontAttribute="Bold"
                            HeaderFontFamily="Roboto-Medium"
                            HeaderFontSize="25"
                            HeaderTextAlignment="Center"
                            HeaderTextColor="White"/>
    </sfPopup:SfPopup.PopupStyle>
</sfPopup:SfPopup>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="5 6 7 8 9 10"%}

public MainPage()
{
    InitializeComponent();
    popup.PopupStyle.HeaderBackground = Color.FromRgb(105,105,105);
    popup.PopupStyle.HeaderFontAttribute = FontAttributes.Bold;
    popup.PopupStyle.HeaderFontFamily = "Roboto-Medium";
    popup.PopupStyle.HeaderFontSize = 25;
    popup.PopupStyle.HeaderTextAlignment = TextAlignment.Center;
    popup.PopupStyle.HeaderTextColor = Color.White;
}

{% endhighlight %}

{% endtabs %}

![Displaying a .NET MAUI Popup with header customization](/Images/styles/maui-popup-with-header-customization.png)

## Styling popup footer

The SfPopup allows customizing the footer elements with various footer customizations as follows:

<table>
<tr>
<th> Property </th>
<th> Description </th>
</tr>
<tr>
<td> SfPopup.PopupStyle.FooterBackground </td>
<td> Gets or sets the background color for the footer.</td>
</tr>
<tr>
<td> SfPopup.PopupStyle.AcceptButtonBackground </td>
<td> Gets or sets the background color for the Accept button in the footer.</td>
</tr>
<tr>
<td> SfPopup.PopupStyle.AcceptButtonTextColor </td>
<td> Gets or sets the foreground color for the Accept button in the footer.</td>
</tr>
<tr>
<td> SfPopup.PopupStyle.DeclineButtonBackground </td>
<td> Gets or sets the background color for the Decline button in the footer.</td>
</tr>
<tr>
<td> SfPopup.PopupStyle.DeclineButtonTextColor </td>
<td> Gets or sets the foreground color for the Decline button in the footer.</td>
</tr>
</table>

Refer to the following code example for customizing the footer elements.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4 5 6 7 8"%}

<sfPopup:SfPopup x:Name="popup" AppearanceMode="TwoButton" ShowFooter="True" >
    <sfPopup:SfPopup.PopupStyle>
        <sfPopup:PopupStyle FooterBackground="LightGray"
                            AcceptButtonBackground ="DimGray"
                            AcceptButtonTextColor="White"
                            DeclineButtonBackground="DimGray"
                            DeclineButtonTextColor="White" />
    </sfPopup:SfPopup.PopupStyle>
</sfPopup:SfPopup>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="11 12 13 14 15" %}

public MainPage()
{
    InitializeComponent();

    // Setting the AppearanceMode as TwoButton
    popup.ShowFooter = true;
    popup.AppearanceMode = Syncfusion.Maui.Popup.PopupButtonAppearanceMode.TwoButton;

    // Footer customization
    popup.PopupStyle.FooterBackground = Color.LightGray;
    popup.PopupStyle.AcceptButtonBackground = Color.FromRgb(105, 105, 105);
    popup.PopupStyle.AcceptButtonTextColor = Color.White;
    popup.PopupStyle.DeclineButtonBackground = Color.FromRgb(105, 105, 105);
    popup.PopupStyle.DeclineButtonTextColor = Color.White;
}

{% endhighlight %}

{% endtabs %}

![Displaying a .NET MAUI Popup with footer customization](/Images/styles/naui-popup-with-footer-customization.png)

## Stroke customization

The SfPopup allows customizing the stroke appearance with various stroke customizations as follows:

<table>
<tr>
<th> Property </th>
<th> Description </th>
</tr>
<tr>
<td> SfPopup.PopupStyle.Stroke </td>
<td> Gets or sets the stroke color for the PopupView.</td>
</tr>
<tr>
<td> SfPopup.PopupStyle.StrokeThickness </td>
<td> Gets or sets the stroke thickness for the PopupView.</td>
</tr>
<tr>
<td> SfPopup.PopupStyle.CornerRadius </td>
<td> Gets or sets the corner radius for the PopupView.</td>
</tr>
</table>

Refer to the following code example for customizing the stroke elements.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4 5 6"%}

<sfPopup:SfPopup x:Name="popup">
    <sfPopup:SfPopup.PopupStyle>
        <sfPopup:PopupStyle Stroke="LightBlue"
                            StrokeThickness="3"
                            CornerRadius="5" />
    </sfPopup:SfPopup.PopupStyle>
<sfPopup:SfPopup>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="5 6 7" %}

public MainPage()
{
    InitializeComponent();
    popup.PopupStyle.Stroke = Colors.LightBlue;
    popup.PopupStyle.StrokeThickness = 3;
    popup.PopupStyle.CornerRadius = 5;
}

{% endhighlight %}

{% endtabs %}

![Displaying a .NET MAUI Popup with stroke customization](/Images/styles/maui-popup-with-stroke-customization.png)

## Styling overlay background

The SfPopup allows to customize the background color of overlay using the `SfPopup.PopupStyle.OverlayColor` property.

Refer to the following code example for customizing the overlay background color.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
        <sfPopup:SfPopup x:Name="popup">
            <sfPopup:SfPopup.PopupStyle>
                    <sfPopup:PopupStyle OverlayColor="LightPink" />
            </sfPopup:Sfpopup.PopupStyle>
        </sfPopup:SfPopup>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

    popup.PopupStyle.OverlayColor = Colors.LightPink;

{% endhighlight %}

{% endtabs %}

![Displaying a .NET MAUI Popup with overlay customization](/Images/styles/maui-popup-with-overlay-customization.png)

### Blurred background

The SfPopup allows to blur the background using `SfPopup.OverlayMode` and `SfPopup.PopupStyle.BlurIntensity` properties, respectively.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14 17" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="GettingStarted.MainPage"
             xmlns:sfPopup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup">
    <StackLayout x:Name="layout">
        <Image Source="Blurred_Background.png" Aspect="Fill" >
             <Image.GestureRecognizers>
                 <TapGestureRecognizer Tapped="TapGestureRecognizer_Tapped"/>
             </Image.GestureRecognizers>
        </Image>
        <sfPopup:SfPopup x:Name="popup" 
                        OverlayMode="Blur" 
                        ShowCloseButton="True">
            <sfPopup:SfPopup.PopupStyle>
                <sfPopup:PopupStyle BlurIntensity="ExtraDark" />
            </sfPopup:SfPopup.PopupStyle>
        </sfPopup:SfPopup>
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
            popup.ShowCloseButton = true;
            popup.OverlayMode = OverlayMode.Blur;
            popup.PopupStyle.BlurIntensity = BlurIntensity.ExtraDark;
            var layout = new StackLayout();
            var image = new Image() { Source = "Blurred_Background.png", Aspect = Aspect.Fill };
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            image.GestureRecognizers.Add(tapGestureRecognizer);
            layout.Children.Add(image);
            Content = layout;
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            popup.Show();
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Displaying a .NET MAUI Popup with Blurred background](/Images/styles/maui-popup-with-blurred-background.png)
