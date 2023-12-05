---
layout: post
title: Getting started with MAUI Card control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Card (SfCalendar) control and its basic features.
platform: maui
control: SfCard
documentation: ug
---

# Getting started with .NET MAUI Card (SfCard)
This section explains how to add the Card control. This section covers only the basic features needed to get started with Syncfusion Card.

To get start quickly with our .NET MAUI Card, you can check the below video.

{% youtube
"youtube:https://www.youtube.com/watch?v=kfQjKiD9Xas"%}

## Creating an application using the .NET MAUI Card

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add `SfCalendar` to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Card](), and then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.Card` in XAML or C# code.

4. Initialize `SfCard.`

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:card="clr-namespace:Syncfusion.Maui.Cards;assembly=Syncfusion.Maui.Cards">

    <card:SfCardView />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 9 10" %}

using Syncfusion.Maui.Cards;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfCardView cardView = new SfCardView();
        this.Content = cardView;
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The `Syncfusion.Maui.Core` NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

using Syncfusion.Maui.Core.Hosting;
namespace GettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("Segoe-mdl2.ttf", "SegoeMDL2");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## SwipeToDismiss

The `SwipeToDismiss` property is used to enable or disable swiping in SfCardView.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 5" %}

<card:SfCardView SwipeToDismiss="True">
	<Label Text="SfCardView"/>
</card:SfCardView>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 9 10" %}

using Syncfusion.Maui.Cards;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfCardView cardView = new SfCardView();
        cardView.SwipeToDismiss = true;
        cardView.Content = new Label(){ Text="SfCardView" };
        this.Content = cardView;
    }
}

{% endhighlight %}
{% endtabs %}	

## Dismiss the card programmatically

We can get a view state of the card using the `IsDismissed` property, which also allows the user to programmatically alter the view state of the card.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 5" %}

<card:SfCardView IsDismissed="true">
     <Label Text="SfCardView"/>
</card:SfCardView>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 9 10" %}

using Syncfusion.Maui.Cards;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfCardView cardView = new SfCardView();
        cardView.SwipeToDismiss = true;
        cardView.Content = new Label(){ Text="SfCardView" };
        this.Content = cardView;
    }
}

{% endhighlight %}
{% endtabs %}	

### SfCardLayout

Initialize a card layout with card view as shown in the following code.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 5" %}

<cards:SfCardLayout SwipeDirection="Left" HeightRequest="500" BackgroundColor="#F0F0F0">

	<cards:SfCardView>
		<Label  Text="Cyan" BackgroundColor="Cyan"/>
	</cards:SfCardView>

	<cards:SfCardView>
		<Label  Text="Yellow" BackgroundColor="Yellow"/>
	</cards:SfCardView>

	<cards:SfCardView>
		<Label  Text="Orange" BackgroundColor="Orange"/>
	</cards:SfCardView>  

</cards:SfCardLayout>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 9 10" %}

using Syncfusion.Maui.Cards;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfCardLayout cardLayout = new SfCardLayout();

        //Add children for card layout 
        cardLayout.Children.Add(new SfCardView(){Content = new Label(){ Text="Cyan", BackgroundColor=Colors.Cyan }});

        cardLayout.Children.Add(new SfCardView(){Content = new Label(){ Text="Yellow", BackgroundColor=Colors.Yellow }});
     
        cardLayout.Children.Add(new SfCardView(){Content = new Label(){ Text="Orange", BackgroundColor=Colors.Orange }});

        this.Content = cardLayout;
    }
}

{% endhighlight %}
{% endtabs %}	