---
layout: post
title: Header and Footer in MAUI AutoComplete control | Syncfusion
description: Learn about Header and Footer support in Syncfusion Maui AutoComplete (SfAutoComplete) control and more details.
platform: maui
control: SfAutoComplete
documentation: ug
---

# Header and Footer in Maui AutoComplete (SfAutoComplete)

## Header and Footer in Maui SfAutoComplete

We can provide Header and Footer view in the suggestion list in [`SfAutoComplete`] by enabling [`ShowDropDownHeaderView`] and [`ShowDropDownFooterView`]. 

## Header Content

We can provide Header Content at the top of the AutoComplete's Suggestion box.[`DropDownHeaderView`] property is used to set the content of the header. The height of the Header in the [`SfAutoComplete`] can be adjusted by the property [`DropDownHeaderViewHeight`].

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:autocomplete="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
             xmlns:local="clr-namespace:AutocompleteSample"             
             x:Class="AutocompleteSample.MainPage">

    <StackLayout VerticalOptions="Start" 
                 HorizontalOptions="Start" 
                 Padding="30">
        <autocomplete:SfAutoComplete HeightRequest="40"
                                     ShowDropDownHeaderView ="True"
                                     DropDownHeaderViewHeight="50"
                                     ValueChanged="SfAutoComplete_ValueChanged">
            <autocomplete:SfAutoComplete.AutoCompleteSource>
               <ListCollection:List x:TypeArguments="x:String">
                    <x:String>India</x:String>
                    <x:String>Uganda</x:String>
                    <x:String>Ukraine</x:String>
                    <x:String>Canada</x:String>
                    <x:String>United Arab Emirates</x:String>
                    <x:String>France</x:String>
                    <x:String>United Kingdom</x:String>
                    <x:String>China</x:String>
                    <x:String>United States</x:String>
                    <x:String>Japan</x:String>
                    <x:String>Angola</x:String>
                </ListCollection:List>
            </autocomplete:SfAutoComplete.AutoCompleteSource>
            <autocomplete:SfAutoComplete.DropDownHeaderView>
                <StackLayout BackgroundColor="#f0f0f0" >
                    <Label  x:Name="SearchLabel" 
                            FontSize="20" 
                            VerticalTextAlignment="Center" 
                            HorizontalOptions="Center" 
                            VerticalOptions="Center" 
                            TextColor="#006bcd"   />
                </StackLayout>
            </autocomplete:SfAutoComplete.DropDownHeaderView>
        </autocomplete:SfAutoComplete>
    </StackLayout>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Inputs;
using System.Collections.Generic;

namespace AutocompleteSample
{
    public partial class MainPage : ContentPage
    {
        Label SearchLabel;
        public MainPage()
        {
            InitializeComponent();
            StackLayout stackLayout = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Start,
                Padding = new Thickness(30)
            };

            SfAutoComplete autoComplete = new SfAutoComplete()
            {
                HeightRequest = 40,
                ShowDropDownHeaderView = true,
                DropDownHeaderViewHeight = 50,
                AutoCompleteSource = new List<string>()
                {
                    "India",
                    "Uganda",
                    "Ukraine",
                    "Canada",
                    "United Arab Emirates",
                    "France",
                    "United Kingdom",
                    "China",
                    "United States",
                    "Japan",
                    "Angola"
                }
            };

            StackLayout layout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#f0f0f0")
            };

            SearchLabel = new Label()
            {
                FontSize = 20,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.FromHex("#006bcd")
            };

            layout.Children.Add(SearchLabel);
            autoComplete.DropDownHeaderView = layout;
            autoComplete.ValueChanged += SfAutoComplete_ValueChanged;
            stackLayout.Children.Add(autoComplete);
            this.Content = stackLayout;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Events 

The following event will be hooked.

{% tabs %}

{% highlight C# %}

        private void SfAutoComplete_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SearchLabel.Text = "Search for " + e.Value;
        }
        
{% endhighlight %}

{% endtabs %}

![Header Image]()

## Footer Content

We can provide Footer Content at the bottom of the AutoComplete's Suggestion box. [`DropDownFooterView`] property is used to set the content of the footer.The height of the Header in the [`SfAutoComplete`] can be adjusted by the property [`DropDownFooterViewHeight`].

The following code example illustrate how to set Footer content in [`SfAutoComplete`].

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:autocomplete="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
             xmlns:local="clr-namespace:AutocompleteSample"             
             x:Class="AutocompleteSample.MainPage">

    <StackLayout VerticalOptions="Start" 
                 HorizontalOptions="Start" 
                 Padding="30">
        <autocomplete:SfAutoComplete HeightRequest="40"
                                     ShowDropDownFooterView ="True"
                                     DropDownFooterViewHeight="50">
            <autocomplete:SfAutoComplete.AutoCompleteSource>
                <ListCollection:List x:TypeArguments="x:String">
                    <x:String>India</x:String>
                    <x:String>Uganda</x:String>
                    <x:String>Ukraine</x:String>
                    <x:String>Canada</x:String>
                    <x:String>United Arab Emirates</x:String>
                    <x:String>France</x:String>
                    <x:String>United Kingdom</x:String>
                    <x:String>China</x:String>
                    <x:String>United States</x:String>
                    <x:String>Japan</x:String>
                    <x:String>Angola</x:String>
                </ListCollection:List>
            </autocomplete:SfAutoComplete.AutoCompleteSource>
            <autocomplete:SfAutoComplete.DropDownFooterView>
                <StackLayout BackgroundColor="#f0f0f0" >
                    <Label  Text="Add New"
                            FontSize="20" 
                            VerticalTextAlignment="Center" 
                            HorizontalOptions="Center" 
                            VerticalOptions="Center" 
                            TextColor="#006bcd" />
                </StackLayout>
            </autocomplete:SfAutoComplete.DropDownFooterView>
        </autocomplete:SfAutoComplete>
    </StackLayout>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Inputs;
using System.Collections.Generic;

namespace AutocompleteSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            StackLayout stackLayout = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Start,
                Padding = new Thickness(30)
            };

            SfAutoComplete autoComplete = new SfAutoComplete()
            {
                HeightRequest = 40,
                ShowDropDownFooterView = true,
                DropDownFooterViewHeight = 50,
                AutoCompleteSource = new List<string>()
                {
                    "India",
                    "Uganda",
                    "Ukraine",
                    "Canada",
                    "United Arab Emirates",
                    "France",
                    "United Kingdom",
                    "China",
                    "United States",
                    "Japan",
                    "Angola"
                }
            };

            StackLayout layout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#f0f0f0")
            };

            Label SearchLabel = new Label()
            {
                FontSize = 20,
                Text = "Add New",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.FromHex("#006bcd")
            };

            layout.Children.Add(SearchLabel);
            autoComplete.DropDownFooterView = layout;
            stackLayout.Children.Add(autoComplete);
            this.Content = stackLayout;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Footer Image]()