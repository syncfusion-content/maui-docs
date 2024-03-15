---
layout: post
title: Styles in .NET MAUI Chat control | Syncfusion
description: Learn here all about Styles support in Syncfusion .NET MAUI Chat (SfChat) control, its elements, and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Styles in .NET MAUI Chat (SfChat)

You can style the elements of the `SfChat` control by creating resource dictionaries and assigning values to the in-built keys assigned for each individual element.

## Chat background

You can set any solid color as background for `SfChat` by setting any color to the `SfChat.Background` property. However, if you want the solid color to be applied to the message input view area, also, set the background color of the message input view as transparent, as shown in the below code sample.

{% tabs %}
{% highlight xaml hl_lines="18 28" %}
    
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
                xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
                xmlns:local="clr-namespace:MauiChat"             
                x:Class="MauiChat.MainPage">

        <ContentPage.BindingContext>
            <local:ViewModel x:Name="viewModel"/>
        </ContentPage.BindingContext>
        
        <ContentPage.Resources>
            <syncTheme:SyncfusionThemeDictionary>
                <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                    <ResourceDictionary>
                        <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                        <Color x:Key="SfChatMessageInputViewBackground">Transparent</Color>
                    </ResourceDictionary>
                </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
            </syncTheme:SyncfusionThemeDictionary>
        </ContentPage.Resources>

        <ContentPage.Content>
            <sfChat:SfChat x:Name="sfChat"
                            Messages="{Binding Messages}"
                            CurrentUser="{Binding CurrentUser}"
                            Background="#94b6ec"/>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="12" %}

    public partial class MainPage : ContentPage
    {
        SfChat sfChat;
        ViewModel viewModel;      
        public MainPage()
        {
            InitializeComponent();
            this.sfChat = new SfChat();
            this.viewModel = new ViewModel();
            this.sfChat.Messages = viewModel.Messages;
            this.sfChat.CurrentUser = viewModel.CurrentUser;
            sfChat.Background = Color.FromHex("#94b6ec");
            this.Content = sfChat;
        }
    }

{% endhighlight %}
{% endtabs %}

![Background color in .NET MAUI Chat](images/styles/maui-chat-background-color-style.png)

### Set background image

You can set any image as the background for the `SfChat` by setting the `SfChat.Background` as `Colors.Transparent` and adding an image below the `SfChat` control. However, if you want the image to be applied to the message input view area as well, set the background color of the message input view as transparent, as shown in the code sample below.

{% tabs %}
{% highlight xaml hl_lines="26" %}
    
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
                xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
                xmlns:local="clr-namespace:MauiChat"             
                x:Class="MauiApp1.MainPage">

        <ContentPage.BindingContext>
            <local:ViewModel x:Name="viewModel"/>
        </ContentPage.BindingContext>

        <ContentPage.Resources>
            <syncTheme:SyncfusionThemeDictionary>
                <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                    <ResourceDictionary>
                        <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                        <Color x:Key="SfChatMessageInputViewBackground">Transparent</Color>
                    </ResourceDictionary>
                </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
            </syncTheme:SyncfusionThemeDictionary>
        </ContentPage.Resources>

        <ContentPage.Content>
            <Grid>
                <Image Source="backgroundimage.jpg" Aspect="AspectFill" />
                <sfChat:SfChat x:Name="sfChat"
                                Messages="{Binding Messages}"
                                CurrentUser="{Binding CurrentUser}"
                                Background="Transparent" /> 
            </Grid>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="10 11 12" %}

    public partial class MainPage : ContentPage
    {
        Grid grid = new Grid();
        SfChat sfChat;
        Image image = new Image();
        ViewModel viewModel;
        public MainPage()
        {
            this.InitializeComponent();
            image.Source = "backgroundimage.jpg";
            image.Aspect = Aspect.AspectFill;
            grid.Children.Add(image);
            this.sfChat = new SfChat();
            this.sfChat.Background = Colors.Transparent;
            this.viewModel = new ViewModel();
            this.sfChat.Messages = viewModel.Messages;
            this.sfChat.CurrentUser = viewModel.CurrentUser;
            grid.Children.Add(sfChat);
            this.Content = grid;
        }
    }

{% endhighlight %}
{% endtabs %}

![Background image in .NET MAUI Chat](images/styles/maui-chat-image-background-style.png)

### Set gradient background

You can set the gradient view as a background for a chat by setting the `SfChat.Background` property to the gradient colors. However, if you want the gradient view to be applied to the message input view area, also, set the background color of the message input view as transparent as shown in the below code sample.

{% tabs %}
{% highlight xaml hl_lines="29 30" %}
    
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
                xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
                xmlns:local="clr-namespace:MauiApp1"             
                x:Class="MauiApp1.MainPage">

        <ContentPage.BindingContext>
            <local:ViewModel x:Name="viewModel"/>
        </ContentPage.BindingContext>
        
        <ContentPage.Resources>
            <syncTheme:SyncfusionThemeDictionary>
                <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                    <ResourceDictionary>
                        <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                        <Color x:Key="SfChatMessageInputViewBackground">Transparent</Color>
                    </ResourceDictionary>
                </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
            </syncTheme:SyncfusionThemeDictionary>
        </ContentPage.Resources>

        <ContentPage.Content>
            <sfChat:SfChat x:Name="sfChat"
                                Messages="{Binding Messages}"
                                CurrentUser="{Binding CurrentUser}" >
                                    
                <sfChat:SfChat.Background>
                    <LinearGradientBrush>
                        <GradientStop Color="SkyBlue" Offset="0.0" />
                        <GradientStop Color="LightCyan" Offset="0.25" />
                        <GradientStop Color="SteelBlue" Offset="0.5" />
                        <GradientStop Color="LightSkyBlue" Offset="0.75" />
                        <GradientStop Color="LightGray" Offset="1.0" />
                    </LinearGradientBrush>
                </sfChat:SfChat.Background>
            </sfChat:SfChat>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="12 18" %}

    public partial class MainPage : ContentPage
    {
        SfChat sfChat;
        ViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            this.sfChat = new SfChat();
            this.viewModel = new ViewModel();
            this.sfChat.Messages = viewModel.Messages;
            this.sfChat.CurrentUser = viewModel.CurrentUser;
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush();     
            linearGradientBrush.GradientStops.Add(new GradientStop(Colors.SkyBlue, 0.0f));
            linearGradientBrush.GradientStops.Add(new GradientStop(Colors.LightCyan, 0.25f));
            linearGradientBrush.GradientStops.Add(new GradientStop(Colors.SteelBlue, 0.5f));
            linearGradientBrush.GradientStops.Add(new GradientStop(Colors.LightSkyBlue, 0.75f));
            linearGradientBrush.GradientStops.Add(new GradientStop(Colors.LightGray, 1.0f));
            this.sfChat.Background = linearGradientBrush;
            this.Content = sfChat;
        }
    }

{% endhighlight %}
{% endtabs %}

![Gradient background in .NET MAUI Chat](images/styles/maui-chat-gradient-background-style.png)

## Incoming message styling

You can style the elements of an incoming message by setting values to the in-built keys of an incoming message in the resource dictionary.

<table>
<tr>
<th>Key</th>
<th>Description </th>
</tr>
<tr>
<td> SfChatIncomingMessageTextColor </td>
<td> Text color of the incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageAuthorTextColor </td>
<td> Text color of the author’s name in an incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageTimestampTextColor </td>
<td> Text color of the timestamp in an incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageBackground </td>
<td> Background color of the incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageFontFamily </td>
<td> Font family of the incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageFontAttributes </td>
<td> Font attributes of the incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageFontSize </td>
<td> Font size of the incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageAuthorFontFamily </td>
<td> Font family of the author’s name in an incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageAuthorFontAttributes </td>
<td> Font attributes of the author’s name in an incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageAuthorFontSize </td>
<td> Font size of the author’s name in an incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageTimestampFontFamily </td>
<td> Font family of the timestamp in an incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageTimestampFontAttributes </td>
<td> Font attributes of the timestamp in an incoming message. </td>
</tr>
<tr>
<td> SfChatIncomingMessageTimestampFontSize </td>
<td> Font size of the timestamp in an incoming message. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatIncomingMessageTextColor">Gray</Color>
                    <Color x:Key="SfChatIncomingMessageTimestampTextColor">Gray</Color>
                    <Color x:Key="SfChatIncomingMessageAuthorTextColor">Gray</Color>
                    <Color x:Key="SfChatIncomingMessageBackground">#eee479</Color>
                    <x:String x:Key="SfChatIncomingMessageFontFamily">Roboto-Medium</x:String>
                    <FontAttributes x:Key="SfChatIncomingMessageFontAttributes">Italic</FontAttributes>
                    <x:Double x:Key="SfChatIncomingMessageFontSize">16</x:Double>
                    <x:String x:Key="SfChatIncomingMessageAuthorFontFamily">Roboto-Medium</x:String>
                    <FontAttributes x:Key="SfChatIncomingMessageAuthorFontAttributes">Italic</FontAttributes>
                    <x:Double x:Key="SfChatIncomingMessageAuthorFontSize">16</x:Double>
                    <x:String x:Key="SfChatIncomingMessageTimestampFontFamily">Roboto-Medium</x:String>
                    <FontAttributes x:Key="SfChatIncomingMessageTimestampFontAttributes">Italic</FontAttributes>
                    <x:Double x:Key="SfChatIncomingMessageTimestampFontSize">16</x:Double>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatIncomingMessageTextColor", Colors.Gray);
        dictionary.Add("SfChatIncomingMessageTimestampTextColor", Colors.Gray);
        dictionary.Add("SfChatIncomingMessageAuthorTextColor", Colors.Gray);
        dictionary.Add("SfChatIncomingMessageBackground", Color.FromHex("#eee479"));
        dictionary.Add("SfChatIncomingMessageFontFamily", "Roboto-Medium");
        dictionary.Add("SfChatIncomingMessageFontAttributes", FontAttributes.Italic);
        dictionary.Add("SfChatIncomingMessageFontSize", 16);
        dictionary.Add("SfChatIncomingMessageAuthorFontFamily", "Roboto-Medium");
        dictionary.Add("SfChatIncomingMessageAuthorFontAttributes", FontAttributes.Italic);
        dictionary.Add("SfChatIncomingMessageAuthorFontSize", 16);
        dictionary.Add("SfChatIncomingMessageTimestampFontFamily", "Roboto-Medium");
        dictionary.Add("SfChatIncomingMessageTimestampFontAttributes", FontAttributes.Italic);
        dictionary.Add("SfChatIncomingMessageTimestampFontSize", 16);
        this.Resources.Add(dictionary);
    }

{% endhighlight %}
{% endtabs %}

![Incoming message style in .NET MAUI Chat](images/styles/maui-chat-incoming-message-style.png)
 
## Outgoing message styling

You can style the elements of an outgoing message by setting values to the in-built keys of an outgoing message in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<td> SfChatOutgoingMessageTextColor </td>
<td> Text color of outgoing message. </td>
</tr><tr>
<td> sfChatOutgoingMessageAuthorTextColor </td>
<td> Text color of the author’s name in an outgoing message. </td>
</tr><tr>
<td> sfChatOutgoingMessageTimestampTextColor </td>
<td> Text color of the timestamp in an outgoing message. </td>
</tr><tr>
<td> SfChatOutgoingMessageBackground </td>
<td> Background color of the outgoing message. </td>
</tr><tr>
<td> sfChatOutgoingMessageFontFamily </td>
<td> Font family of the outgoing message. </td>
</tr><tr>
<td> sfChatOutgoingMessageFontAttributes </td>
<td> Font attributes of the outgoing message. </td>
</tr>
<tr>
<td> sfChatOutgoingMessageFontSize </td>
<td> Font size of the outgoing message. </td>
</tr><tr>
<td> sfChatOutgoingMessageAuthorFontFamily </td>
<td> Font family of the author’s name in an outgoing message. </td>
</tr><tr>
<td> sfChatOutgoingMessageAuthorFontAttributes </td>
<td> Font attributes of the author’s name in an outgoing message. </td>
</tr><tr>
<td> sfChatOutgoingMessageAuthorFontSize </td>
<td> Font size of the author’s name in an outgoing message. </td>
</tr><tr>
<td> sfChatOutgoingMessageTimestampFontFamily </td>
<td> Font family of the timestamp in an outgoing message. </td>
</tr><tr>
<td> sfChatOutgoingMessageTimestampFontAttributes </td>
<td> Font attributes of the timestamp in an outgoing message. </td>
</tr><tr>
<td> SfChatOutgoingMessageTimestampFontSize </td>
<td> Font size of the timestamp in an outgoing message. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}
   
    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatOutgoingMessageTextColor">Gray</Color>
                    <Color x:Key="SfChatOutgoingMessageBackground">#eee479</Color>
                    <Color x:Key="SfChatOutgoingMessageTimestampTextColor">Gray</Color>
                    <Color x:Key="SfChatOutgoingMessageAuthorTextColor">Gray</Color>
                    <x:String x:Key="SfChatOutgoingMessageFontFamily">Roboto-Medium</x:String>
                    <FontAttributes x:Key="SfChatOutgoingMessageFontAttributes">Italic</FontAttributes>
                    <x:Double x:Key="SfChatOutgoingMessageFontSize">16</x:Double>
                    <x:String x:Key="SfChatOutgoingingMessageAuthorFontFamily">Roboto-Medium</x:String>
                    <FontAttributes x:Key="SfChatOutgoingMessageAuthorFontAttributes">Italic</FontAttributes>
                    <x:Double x:Key="SfChatOutgoingMessageAuthorFontSize">16</x:Double>
                    <x:String x:Key="SfChatOutgoingMessageTimestampFontFamily">Roboto-Medium</x:String>
                    <FontAttributes x:Key="SfChatOutgoingMessageTimestampFontAttributes">Italic</FontAttributes>
                    <x:Double x:Key="SfChatOutgoingMessageTimestampFontSize">16</x:Double>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatOutgoingMessageTextColor", Colors.Gray);
        dictionary.Add("SfChatOutgoingMessageTimestampTextColor", Colors.Gray);
        dictionary.Add("SfChatOutgoingMessageAuthorTextColor", Colors.Gray);
        dictionary.Add("SfChatOutgoingMessageBackground", Color.FromHex("#eee479"));
        dictionary.Add("SfChatOutgoingMessageFontFamily", "Roboto-Medium");
        dictionary.Add("SfChatOutgoingMessageFontAttributes", FontAttributes.Italic);
        dictionary.Add("SfChatOutgoingMessageFontSize", 16);
        dictionary.Add("SfChatOutgoingMessageAuthorFontFamily", "Roboto-Medium");
        dictionary.Add("SfChatOutgoingMessageAuthorFontAttributes", FontAttributes.Italic);
        dictionary.Add("SfChatOutgoingMessageAuthorFontSize", 16);
        dictionary.Add("SfChatOutgoingMessageTimestampFontFamily", "Roboto-Medium");
        dictionary.Add("SfChatOutgoingMessageTimestampFontAttributes", FontAttributes.Italic);
        dictionary.Add("SfChatOutgoingMessageTimestampFontSize", 16);
        this.Resources.Add(dictionary);
    }

{% endhighlight %}
{% endtabs %}

![Outgoing message style in .NET MAUI Chat](images/styles/maui-chat-outgoing-message-style.png)

## Calendar message styling

You can style the elements of a calendar message by setting values to the in-built keys of a calendar message in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<tr>
<td> SfChatCalendarBackground </td>
<td> Background color of the calendar message. </td>
</tr>
<tr>
<td> SfChatCalendarStroke </td>
<td> Border color of the calendar message. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}
  
    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatCalendarBackground">White</Color>
                    <Color x:Key="SfChatCalendarStroke">Black</Color>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight C# %}

    public MainPage()
    {
        ....
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatCalendarBackground", Colors.White);
        dictionary.Add("SfChatCalendarStroke", Colors.Black);
        this.Resources.Add(dictionary);
        ....
    }

{% endhighlight %}
{% endtabs %}

N> In addition to this, you can write the target style to the `SfCalendar` control to style the inner elements of the calendar, like the selection of background color, foreground color, etc.

## Hyperlink message styling

You can style the elements of a hyperlink message by setting values to the in-built keys of a hyperlink message in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<tr>
<td> SfChatIncomingHyperlinkColor </td>
<td> Text color of the URL in a hyperlink message. </td>
</tr><tr>
<td> SfChatOutgoingHyperlinkColor </td>
<td> Text color of the URL in an outgoing hyperlink message. </td>
</tr><tr>
<td> SfChatHyperlinkDescriptionTextColor </td>
<td> Text color of the URL's meta description in a hyperlink message. </td>
</tr><tr>
<td> sfChatHyperlinkDescriptionBackground </td>
<td> Background color of the URL description area in a hyperlink message. </td>
</tr><tr>
<td> SfChatHyperlinkMetaTitleTextColor </td>
<td> Text color of the URL's meta title in a hyperlink message. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatIncomingHyperlinkColor">#94b6ec</Color>
                    <Color x:Key="SfChatHyperlinkMetaTitleTextColor">#f29d0a</Color>
                    <Color x:Key="SfChatHyperlinkDescriptionTextColor">Black</Color>
                    <Color x:Key="SfChatHyperlinkDescriptionBackground">#dde9cc</Color>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
        ....
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatIncomingHyperlinkColor", Color.FromHex("#94b6ec"));
        dictionary.Add("SfChatHyperlinkMetaTitleTextColor", Color.FromHex("#f29d0a"));
        dictionary.Add("SfChatHyperlinkDescriptionTextColor", Colors.Black);
        dictionary.Add("SfChatHyperlinkDescriptionBackground", Color.FromHex("#dde9cc"));
        this.Resources.Add(dictionary);
        ....
    }

{% endhighlight %}
{% endtabs %}

![Hyperlink message style in .NET MAUI Chat](images/styles/maui-chat-hyperlink-message-style.png)

## Date picker message styling

You can style the elements of a date picker message by setting values to the in-built keys of a date picker message in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<tr>
<td> SfChatDatePickerIconColor </td>
<td> Color of date picker icon. </td>
</tr>
<tr>
<td> SfChatDatePickerTextColor </td>
<td> Color of the text in date picker.  </td>
</tr>
<tr>
<td> SfChatDatePickerBackground </td>
<td> Background color of the date picker. </td>
</tr>
<tr>
<td> SfChatDatePickerStroke </td>
<td> Border color of the date picker. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatDatePickerIconColor">Blue</Color>
                    <Color x:Key="SfChatDatePickerTextColor">White</Color>
                    <Color x:Key="SfChatDatePickerBackground">SkyBlue</Color>
                    <Color x:Key="SfChatDatePickerStroke">Black</Color>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
        ....
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatDatePickerBackground", Colors.SkyBlue);
        dictionary.Add("SfChatDatePickerTextColor", Colors.White);
        dictionary.Add("SfChatDatePickerIconColor", Colors.Blue);
        dictionary.Add("SfChatDatePickerStroke", Colors.Blue);
        this.Resources.Add(dictionary);
        ....
    }

{% endhighlight %}
{% endtabs %}

![Date picker message style in .NET MAUI Chat](images/styles/maui-chat-datepicker-message-style.png)

## Time picker message styling

You can style the elements of a time picker message by setting values to the in-built keys of a time picker message in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<tr>
<td> SfChatTimePickerIconColor </td>
<td> Color of time picker icon. </td>
</tr><tr>
<td> SfChatTimePickerTextColor </td>
<td> Color of the text in time picker.  </td>
</tr><tr>
<td> SfChatTimePickerBackground </td>
<td> Background color of time picker. </td>
</tr><tr>
<td> SfChatTimePickerStroke </td>
<td> Border color of time picker. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatTimePickerIconColor">Blue</Color>
                    <Color x:Key="SfChatTimePickerTextColor">White</Color>
                    <Color x:Key="SfChatTimePickerBackground">SkyBlue</Color>
                    <Color x:Key="SfChatTimePickerStroke">Black</Color>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
        ....
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatTimePickerBackground", Colors.SkyBlue);
        dictionary.Add("SfChatTimePickerTextColor", Colors.White);
        dictionary.Add("SfChatTimePickerIconColor", Colors.Blue);
        dictionary.Add("SfChatTimePickerStroke", Colors.Black);
        this.Resources.Add(dictionary);
        ....
    }

{% endhighlight %}
{% endtabs %}

![Time picker message style in .NET MAUI Chat](images/styles/maui-chat-timepicker-message-style.png)

## Message input view styling

You can style the elements of the message input view by setting values to the in-built keys of the message input view in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<tr>
<td> SfChatMessageInputViewBackground </td>
<td> Message input view background color. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatMessageInputViewBackground">#94b6ec</Color>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight C# %}

    public MainPage()
    {
        ....
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatMessageInputViewBackground", Colors.SkyBlue);
        this.Resources.Add(dictionary);
        ....
    }

{% endhighlight %}
{% endtabs %}

![Message input view style in .NET MAUI Chat](images/styles/maui-chat-message-inputview-style.png)

## Editor styling

You can style the elements of the editor view by setting values to the in-built keys of the editor view in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<tr>
<td> SfChatEditorTextColor </td>
<td> Color of the text in the editor. </td>
</tr>
<tr>
<td> SfChatEditorPlaceholderTextColor </td>
<td> Color of the placeholder text in the editor. </td>
</tr>
<tr>
<td> SfChatEditorStroke </td>
<td> Color of the border in the editor. </td>
</tr>
<tr>
<td> SfChatEditorBackground </td>
<td> Background color of the editor. </td>
</tr>
<tr>
<td> SfChatEditorFontFamily </td>
<td> Font family of the text in the editor. </td>
</tr>
<tr>
<td> SfChatEditorFontAttributes </td>
<td> Font attributes of the text in the editor. </td>
</tr>
<tr>
<td> SfChatEditorFontSize </td>
<td> Font size of the text in the editor. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatEditorPlaceholderTextColor">Blue</Color>
                    <Color x:Key="SfChatEditorTextColor">Black</Color>
                    <Color x:Key="SfChatEditorBackground">LightGreen</Color>
                    <Color x:Key="SfChatEditorStroke">Black</Color>
                    <x:String x:Key="SfChatEditorFontFamily">Roboto-Medium</x:String>
                    <FontAttributes x:Key="SfChatEditorFontAttributes">Bold</FontAttributes>
                    <x:Double x:Key="SfChatEditorFontSize">16</x:Double>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
        ....
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatEditorPlaceholderTextColor", Colors.Blue);
        dictionary.Add("SfChatEditorBackground", Colors.LightGreen);
        dictionary.Add("SfChatEditorTextColor", Colors.Black);
        dictionary.Add("SfChatEditorStroke", Colors.Black);
        dictionary.Add("SfChatEditorFontFamily", "Roboto-Medium");
        dictionary.Add("SfChatEditorFontAttributes", FontAttributes.Italic);
        dictionary.Add("SfChatEditorFontSize", 16);
        this.Resources.Add(dictionary);
        ....
    }

{% endhighlight %}
{% endtabs %}

![Editor style in .NET MAUI Chat](images/styles/maui-chat-editor-style.png)

## Typing indicator styling

You can style the elements of the typing indicator view by setting values to the in-built keys of the typing indicator view in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<tr>
<td> SfChatTypingIndicatorTextColor </td>
<td> Text color in the typing indicator. </td>
</tr>
<tr>
<td> SfChatTypingIndicatorBackground </td>
<td> Background color of the typing indicator. </td>
</tr>
<tr>
<td> SfChatTypingIndicatorFontFamily </td>
<td> Font family of the text in the typing indicator. </td>
</tr>
<tr>
<td> SfChatTypingIndicatorFontAttributes </td>
<td> Font attributes of the text in the typing indicator. </td>
</tr>
<tr>
<td> SfChatTypingIndicatorFontSize </td>
<td> Font size of the text in the typing indicator. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatTypingIndicatorTextColor">Blue</Color>
                    <Color x:Key="SfChatTypingIndicatorBackground">#eee479</Color>
                    <x:String x:Key="SfChatTypingIndicatorFontFamily">Roboto-Medium</x:String>
                    <FontAttributes x:Key="SfChatTypingIndicatorFontAttributes">Italic</FontAttributes>
                    <x:Double x:Key="SfChatTypingIndicatorFontSize">16</x:Double>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
        ....
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatTypingIndicatorBackground", Color.FromHex("#eee479"));
        dictionary.Add("SfChatTypingIndicatorTextColor", Colors.Blue);
        dictionary.Add("SfChatTypingIndicatorFontFamily", "Roboto-Medium");
        dictionary.Add("SfChatTypingIndicatorFontAttributes", FontAttributes.Italic);
        dictionary.Add("SfChatTypingIndicatorFontSize", 16);
        this.Resources.Add(dictionary);
        ....
    }

{% endhighlight %}
{% endtabs %}

![Typing indicator style in .NET MAUI Chat](images/styles/maui-chat-typingindicator-style.png)

## Time break view styling

You can style the elements of the time break view by setting values to the in-built keys of the time break view in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<tr>
<td> SfChatTimeBreakViewTextColor </td>
<td> Text color of the text in the time break view. </td>
</tr>
<tr>
<td> SfChatTimeBreakViewBackground </td>
<td> Background color of the time break view. </td>
</tr>
<tr>
<td> SfChatTimeBreakViewFontFamily </td>
<td> Font family of the text in the time break view. </td>
</tr>
<tr>
<td> SfChatTimeBreakViewFontAttributes </td>
<td> Font attributes of the text in the time break view. </td>
</tr>
<tr>
<td> SfChatTimeBreakViewFontSize  </td>
<td> Font size of the text in the time break view. </td>
</tr>
<tr>
<td> SfChatTimeBreakViewStroke </td>
<td> Border color of the time break view. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatTimeBreakViewTextColor">Blue</Color>
                    <Color x:Key="SfChatTimeBreakViewBackground">#e2f9cd</Color>
                    <Color x:Key="SfChatTimeBreakViewStroke">LimeGreen</Color>
                    <x:String x:Key="SfChatTimeBreakViewFontFamily">Roboto-Medium</x:String>
                    <FontAttributes x:Key="SfChatTimeBreakViewFontAttributes">Italic</FontAttributes>
                    <x:Double x:Key="SfChatTimeBreakViewFontSize">16</x:Double>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
        ....
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatTimeBreakViewTextColor", Colors.Blue);
        dictionary.Add("SfChatTimeBreakViewStroke", Colors.LimeGreen);
        dictionary.Add("SfChatTimeBreakViewBackground", Color.FromHex("#e2f9cd"));
        dictionary.Add("SfChatTimeBreakViewFontFamily", "Roboto-Medium");
        dictionary.Add("SfChatTimeBreakViewFontAttributes", FontAttributes.Italic);
        dictionary.Add("SfChatTimeBreakViewFontSize", 16);
        this.Resources.Add(dictionary);
        ....
    }

{% endhighlight %}
{% endtabs %}

![Time break view style in .NET MAUI Chat](images/styles/maui-chat-time-break-style.png)

## Suggestions styling

You can style the elements of the suggestion view by setting values to the in-built keys of the suggestion view in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<tr>
<td> SfChatSuggestionListItemTextColor </td>
<td> Text color of an item in the list of suggestions. </td>
</tr>
<tr>
<td> SfChatSuggestionListItemBackground </td>
<td> Background color of an item in the list of suggestions. </td>
</tr>
<tr>
<td> SfChatSuggestionListBackground </td>
<td> Background color of the suggestions list view. </td>
</tr>
<tr>
<td> SfChatSuggestionListItemFontFamily </td>
<td> Font family of an item in the list of suggestions. </td>
</tr>
<tr>
<td> SfChatSuggestionListItemFontAttributes </td>
<td> Font attributes of an item in the list of suggestions. </td>
</tr>
<tr>
<td> SfChatSuggestionListItemFontSize </td>
<td> Font size of an item in the list of suggestions. </td>
</tr>
<tr>
<td> SfChatSuggestionListItemStroke </td>
<td> Border color of an item in the list of suggestions. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatSuggestionListItemTextColor">Blue</Color>
                    <Color x:Key="SfChatSuggestionListItemBackground">#d9d9d9</Color>
                    <Color x:Key="SfChatSuggestionListBackground">Violet</Color>
                    <x:String x:Key="SfChatSuggestionListItemFontFamily">Roboto-Medium</x:String>
                    <FontAttributes x:Key="SfChatSuggestionListItemFontAttributes">Bold</FontAttributes>
                    <x:Double x:Key="SfChatSuggestionListItemFontSize">16</x:Double>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
        ....
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatSuggestionListItemTextColor", Colors.Blue);
        dictionary.Add("SfChatSuggestionListBackground", Colors.Violet);
        dictionary.Add("SfChatSuggestionListItemBackground", Color.FromHex("#d9d9d9"));
        dictionary.Add("SfChatSuggestionListItemFontFamily", "Roboto-Medium");
        dictionary.Add("SfChatSuggestionListItemFontAttributes", FontAttributes.Italic);
        dictionary.Add("SfChatSuggestionListItemFontSize", 16);
        this.Resources.Add(dictionary);
        ....
    }

{% endhighlight %}
{% endtabs %}

![Suggestions style in .NET MAUI Chat](images/styles/maui-chat-suggestion-style.png)

## Send button styling

You can style the send message button based on its state by setting values to the in-built keys of the send message button in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<tr>
<td> SfChatSendButtonColor </td>
<td> Color of the send button. </td>
</tr>
<tr>
<td> SfChatSendButtonDisabledColor </td>
<td> Color of the send button when it is in 'Disabled' state. </td>
<tr>
<td> SfChatSendButtonBackground </td>
<td> Background color of the send button. </td>
</tr>
<tr>
<td> SfChatDisabledSendButtonBackground </td>
<td> Disabled background color of the send button. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatSendButtonDisabledColor">Purple</Color>
                    <Color x:Key="SfChatSendButtonColor">DeepPink</Color>
                    <Color x:Key="SfChatSendButtonBackground">SkyBlue</Color>
                    <Color x:Key="SfChatDisabledSendButtonBackground">LightGreen</Color>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
        ....
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatSendButtonDisabledColor", Colors.Purple);
        dictionary.Add("SfChatSendButtonColor", Colors.DeepPink);
        dictionary.Add("SfChatSendButtonBackground", Colors.SkyBlue);
        dictionary.Add("SfChatDisabledSendButtonBackground", Colors.LightGreen);
        this.Resources.Add(dictionary);
        ....
    }

{% endhighlight %}
{% endtabs %}

![Send button disable and enable style in .NET MAUI Chat](images/styles/maui-chat-send-button-style.png)

## Attachment button styling

You can style the attachment button by setting values to the in-built keys of the attachment button in the resource dictionary.

<table>
<tr>
<th> Key </th>
<th> Description </th>
</tr>
<tr>
<td> SfChatAttachmentButtonColor </td>
<td> Color of the attachment button. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}

    <ContentPage.Resources>
        <syncTheme:SyncfusionThemeDictionary>
            <syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <x:String x:Key="SfChatTheme">CustomTheme</x:String>
                    <Color x:Key="SfChatAttachmentButtonColor">Orange</Color>
                </ResourceDictionary>
            </syncTheme:SyncfusionThemeDictionary.MergedDictionaries>
        </syncTheme:SyncfusionThemeDictionary>
    </ContentPage.Resources>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
        ....
        InitializeComponent();
        ResourceDictionary dictionary = new ResourceDictionary();
        dictionary.Add("SfChatTheme", "CustomTheme");
        dictionary.Add("SfChatAttachmentButtonColor", Colors.Orange);
        this.Resources.Add(dictionary);
        ....
    }

{% endhighlight %}
{% endtabs %}

![Attachment button style in .NET MAUI Chat](images/styles/maui-chat-attachmentbutton-style.png)