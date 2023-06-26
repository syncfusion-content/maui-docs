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
{% highlight xaml %}

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
{% highlight c# %}

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
{% highlight xaml %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup">            
    <StackLayout>
            <Button x:Name="clickToShowPopup" Text="ClickToShowPopup" 
        VerticalOptions="Start" HorizontalOptions="FillAndExpand"
        Clicked="ClickToShowPopup_Clicked"/>
            <syncfusion:SfPopup x:Name="popup"/>
        </StackLayout>
</ContentPage>

{% endhighlight %}
{% highlight c# %}
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
<tr>
<td>SfPopupLayout</td>
<td>SfPopup</td>
<td>Displays an alert message with customizable buttons or loads a desired view within a pop-up window.</td></tr>
<tr>
<td>PopupView</td>
<td>Nil</td>
<td>Not supported</td></tr>
</table>

## Properties

N> All the properties from the Xamarin.Forms PopupView class is moved to the MAUI SfPopup class itself.

<table>
<tr>
<th>Xamarin SfPopupLayout</th>
<th>.NET MAUI SfPopup</th>
<th>Description</th></tr>
<tr>
<td>SfPopupLayout.Content</td>
<td>Nil</td>
<td>Not supported</td></tr>
<tr>
<td>SfPopupLayout.PopupView</td>
<td>Nil</td>
<td>Not supported</td></tr>
<tr>
<td>{{'[PopupStyle.HeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.PopupStyle.html#Syncfusion_XForms_PopupLayout_PopupStyle_HeaderBackgroundColor)'| markdownify }}</td>
<td>{{'[PopupStyle.HeaderBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupStyle.html#Syncfusion_Maui_Popup_PopupStyle_HeaderBackground)'| markdownify }}</td>
<td>Gets or sets the background color to be applied for the header.</td></tr>
<tr>
<td>{{'[PopupStyle.FooterBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.PopupStyle.html#Syncfusion_XForms_PopupLayout_PopupStyle_FooterBackgroundColor)'| markdownify }}</td>
<td>{{'[PopupStyle.FooterBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupStyle.html#Syncfusion_Maui_Popup_PopupStyle_FooterBackground)'| markdownify }}</td>
<td>Gets or sets the background color of the footer.</td></tr>
<tr>
<td>{{'[PopupStyle.AcceptButtonBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.PopupStyle.html#Syncfusion_XForms_PopupLayout_PopupStyle_AcceptButtonBackgroundColor)'| markdownify }}</td>
<td>{{'[PopupStyle.AcceptButtonBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupStyle.html#Syncfusion_Maui_Popup_PopupStyle_AcceptButtonBackground)'| markdownify }}</td>
<td>Gets or sets the background color of accept button in the footer.</td></tr>
<tr>
<td>{{'[PopupStyle.DeclineButtonBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.PopupStyle.html#Syncfusion_XForms_PopupLayout_PopupStyle_DeclineButtonBackgroundColor)'| markdownify }}</td>
<td>{{'[PopupStyle.DeclineButtonBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupStyle.html#Syncfusion_Maui_Popup_PopupStyle_DeclineButtonBackground)'| markdownify }}</td>
<td>Gets or sets the background color of decline button in the footer.</td></tr>
<tr>
<td>{{'[PopupStyle.BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.PopupStyle.html#Syncfusion_XForms_PopupLayout_PopupStyle_BorderColor)'| markdownify }}</td>
<td>{{'[PopupStyle.Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupStyle.html#Syncfusion_Maui_Popup_PopupStyle_Stroke)'| markdownify }}</td>
<td>Gets or sets the border color for the PopupView</td></tr>
<tr>
<td>{{'[PopupStyle.BorderThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.PopupStyle.html#Syncfusion_XForms_PopupLayout_PopupStyle_BorderThickness)'| markdownify }}</td>
<td>{{'[PopupStyle.StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupStyle.html#Syncfusion_Maui_Popup_PopupStyle_StrokeThickness)'| markdownify }}</td>
<td>Gets or sets the border thickness for the PopupView</td></tr>
<tr>
<td>{{'[PopupStyle.OverlayOpacity](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.PopupStyle.html#Syncfusion_XForms_PopupLayout_PopupStyle_OverlayOpacity)'| markdownify }}</td>
<td>{{'[PopupStyle.OverlayColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupStyle.html#Syncfusion_Maui_Popup_PopupStyle_OverlayColor)'| markdownify }}</td>
<td>You can achieve by setting value using rgba value like below,

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfPopup.PopupStyle>
    <syncfusion:PopupStyle OverlayColor="#80000000"/>
</syncfusion:SfPopup.PopupStyle>

{% endhighlight %}
{% endtabs %}

</td></tr>
<tr>
<td>SfPopuplayoutResources.Title</td>
<td>SfPopupResource.Title</td>
<td>Gets the TitleLabelText.</td></tr>
<tr>
<td>SfPopuplayoutResources.Popup_message</td>
<td>SfPopupResource.Message</td>
<td>Gets the MessageView text.</td></tr>
<tr>
<td>SfPopuplayoutResources.ACCEPT</td>
<td>SfPopupResource.AcceptButtonText</td>
<td>Gets the Accept button text.</td></tr>
<tr>
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
<tr>
<td>{{'[AutoSizeMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.AutoSizeMode.html)'| markdownify }}</td>
<td>{{'[PopupAutoSizeMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAutoSizeMode.html)'| markdownify }}</td>
<td>Defines constant that specify how the PopupView is Sized.</td></tr>
<tr>
<td>{{'[AppearanceMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.AppearanceMode.html)'| markdownify }}</td>
<td>{{'[PopupButtonAppearanceMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupButtonAppearanceMode.html)'| markdownify }}</td>
<td>Built-in layout styles of the PopupView.</td></tr>
<tr>
<td>{{'[BlurIntensity](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.BlurIntensity.html)'| markdownify }}</td>
<td>{{'[PopupBlurIntensity](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupBlurIntensity.html)'| markdownify }}</td>
<td>Defines constants that specifies the intensity of the blur effect applied to the overlay.</td></tr>
<tr>
<td>{{'[OverlayMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.OverlayMode.html)'| markdownify }}</td>
<td>{{'[PopupOverlayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupOverlayMode.html)'| markdownify }}</td>
<td>Defines constants that specifies whether the overlay should be transparent or blurred.</td></tr>
<tr>
<td>{{'[RelativePosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.PopupLayout.RelativePosition.html)'| markdownify }}</td>
<td>{{'[PopupRelativePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html)'| markdownify }}</td>
<td>Positions the popup view relative to the given view.</td></tr>
</table>

## Upcoming Features

* Popup position - ShowAtTouchPoint()
* Animation 