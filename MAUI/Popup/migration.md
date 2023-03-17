---
layout: post
title: Migrate from Xamarin SfPopupLayout to .NET MAUI SfPopup | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin Popup to Syncfusion .NET MAUI Popup control and more.
platform: MAUI
control: SfPopup
documentation: ug
---  

# Migrate from Xamarin.Forms SfPopupLayout to .NET MAUI SfPopup

To migrate easier from Xamarin.Forms SfPopupLayout to .NET MAUI Popup, we kept most of the APIs from Xamarin SfPopupLayout in MAUI SfPopup. However, to maintain the consistency of API naming in MAUI SfPopup, we renamed some of the APIs. The APIs that have been changed in MAUI SfPopup from Xamarin SfPopupLayout are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfPopupLayout </th>
<th>.NET MAUI SfPopup</th></tr>
<tr>
<td>Syncfusion.XForms.SfPopupLayout</td>
<td>Syncfusion.Maui.Popup</td></tr>
</table>

## Initialize Control

To initialize the control, import the popup namespace and initialize SfPopup as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfPopupLayout</th>
<th>.NET MAUI SfPopup</th></tr>
<tr>
<td>
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage xmlns:sfPopup="clr-namespace:Syncfusion.XForms.PopupLayout;assembly=Syncfusion.SfPopupLayout.XForms">
<sfPopup:SfPopupLayout x:Name="popupLayout">
    <sfPopup:SfPopupLayout.Content>
        <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" 
        VerticalOptions="Start" HorizontalOptions="FillAndExpand"
        Clicked="ClickToShowPopup_Clicked"/>
    </sfPopup:SfPopupLayout.Content>
</sfPopup:SfPopupLayout>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void ClickToShowPopup_Clicked(object sender, EventArgs e)
    {
        popupLayout.Show();      
    }
}

{% endhighlight %}
{% endtabs %}
</td>
<td>
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup">            
    <StackLayout>
            <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" 
        VerticalOptions="Start" HorizontalOptions="FillAndExpand"
        Clicked="ClickToShowPopup_Clicked"/>
            <syncfusion:SfPopup x:Name="popup"/>
        </StackLayout>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
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

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

## Classes

<table> 
<tr>
<th>Xamarin SfPopupLayout</th>
<th>.NET MAUI SfPopup</th>
<th>Description</th></tr>
<td>SfPopupLayout</td>
<td>Sfpopup</td>
<td>Displays an alert message with customizable buttons or loads a desired view within a pop-up window.</td></tr>
<tr>
<td>PopupView</td>
<td>Nil</td>
<td>Not supported</td></tr>
</table>

## Properties

N> All the properties from Xamarin.Forms PopupView class are moved to MAUI SfPopup class itself.

<table>
<tr>
<th>Xamarin SfPopupLayout</th>
<th>.NET MAUI SfPopup</th>
<th>Description</th></tr>
<tr>
<td>SfPopupLayout.Content</td>
<td>Nil</td>
<td>Not supported</td></tr>
<td>SfPopupLayout.PopupView</td>
<td>PopupStyle.HeaderBackground</td>
<td>Gets or sets the background color to be applied for the header.</td></tr>
<td>PopupStyle.FooterBackgroundColor</td>
<td>PopupStyle.FooterBackground</td>
<td>Gets or sets the background color of the footer.</td></tr>
<td>PopupStyle.AcceptButtonBackgroundColor</td>
<td>PopupStyle.AcceptButtonBackground</td>
<td>Gets or sets the background color of accept button in the footer.</td></tr>
<td>PopupStyle.DeclineButtonBackgroundColor</td>
<td>PopupStyle.DeclineButtonBackground</td>
<td>Gets or sets the background color of decline button in the footer.</td></tr>
<td>PopupStyle.ContentBackgroundColor</td>
<td>PopupStyle.MessageBackground</td>
<td>Gets or sets the background color of content.</td></tr>
<td>PopupStyle.BorderColor</td>
<td>PopupStyle.Stroke</td>
<td>Gets or sets the border color for the PopupView</td></tr>
<td>PopupStyle.BorderThickness</td>
<td>PopupStyle.StrokeThickness</td>
<td>Gets or sets the border thickness for the PopupView</td></tr>
<td>PopupStyle.OverlayOpacity</td>
<td>PopupStyle.OverlayColor</td>
<td>You can achieve by setting value using rgba value like below,

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfPopup.PopupStyle>
    <syncfusion:PopupStyle OverlayColor="#80000000"/>
</syncfusion:SfPopup.PopupStyle>
{% endtabs %}

</td></tr>
<td>SfPopuplayoutResources.Title</td>
<td>SfPopupResource.Title</td>
<td>Gets the TitleLabelText.</td></tr>
<td>SfPopuplayoutResources.Popup_message</td>
<td>SfPopupResource.Message</td>
<td>Gets the MessageView text.</td></tr>
<td>SfPopuplayoutResources.ACCEPT</td>
<td>SfPopupResource.AcceptButtonText</td>
<td>Gets the Accept button text.</td></tr>
<td>SfPopuplayoutResources.DECLINE</td>
<td>SfPopupResource.DeclineButtonText</td>
<td>Gets the Decline button text.</td></tr>
</table>

## Enums 

<table>
<tr>
<th>Xamarin SfPopupLayout</th>
<th>.NET MAUI SfPopup</th>
<th>Description</th></tr>
<td>AutoSizeMode</td>
<td>PopupAutoSizeMode</td>
<td>Defines constant that specify how the PopupView is Sized.</td></tr>
<td>AppearanceMode</td>
<td>PopupButtonAppearanceMode</td>
<td>Built-in layout styles of the PopupView.</td></tr>
<td>BlurIntensity</td>
<td>PopupBlurIntensity</td>
<td>Defines constants that specifies the intensity of the blur effect applied to the overlay.</td></tr>
<td>OverlayMode</td>
<td>PopupOverlayMode</td>
<td>Defines constants that specifies whether the overlay should be transparent or blurred.</td></tr>
<td>RelativePosition</td>
<td>PopupRelativePosition</td>
<td>Positions the popup view relative to the given view.</td></tr>
</table>

## Methods

<table>
<tr>
<th>Xamarin SfPopupLayout</th>
<th>.NET MAUI SfPopup</th>
<th>Description</th></tr>
<td>PopupView.Refresh()</td>
<td>Nil</td>
<td>Not supported</td></tr>
</table>

## Upcoming Features

* Popup position - ShowAtTouchPoint()
* Animation 
* Padding