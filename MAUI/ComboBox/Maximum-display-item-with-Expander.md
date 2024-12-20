---
layout: post
title: LoadMore in .NET MAUI ComboBox control | Syncfusion
description: Learn all about LoadMore support in Syncfusion .NET MAUI ComboBox (SfComboBox) control and more here.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu.
---

# LoadMore in .NET MAUI ComboBox (SfComboBox)

Restrict the number of suggestions displayed and have the remaining items loaded by selecting LoadMore. We can restrict maximum suggestion to be displayed with the [MaximumSuggestion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_MaximumSuggestion) property.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox" 
                    WidthRequest="300"
                    HeightRequest="40"
                    IsFilteringEnabled="True"
                    IsEditable="True" 
                    ItemsSource="{Binding SocialMedias}"          
                    MaximumSuggestion="2"
                    DisplayMemberPath="Name"                                    
                    TextMemberPath="Name"/>

{% endhighlight %}

{% highlight C# %}

SfComboBox comboBox = new SfComboBox() 
{
    WidthRequest= 250,
    HeightRequest = 40,
    MaximumSuggestion = 2,
    IsEditable = true,
    IsFilteringEnabled = true,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
    ItemsSource = socialMediaViewModel.SocialMedias
};
Content = comboBox;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox LoadMore support](Images/Maximum-display-item-with-Expander/LoadMore.gif)

## LoadMore text customization

The LoadMore support provides [LoadMoreText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_LoadMoreText). We can set the desire text for the displaying the Load more text with the property LoadMoreText.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox" 
                    WidthRequest="300"
                    HeightRequest="40"
                    IsFilteringEnabled="True"
                    IsEditable="True" 
                    ItemsSource="{Binding SocialMedias}"          
                    MaximumSuggestion="2"
                    LoadMoreText="Load more items"
                    DisplayMemberPath="Name"                                    
                    TextMemberPath="Name"/>


{% endhighlight %}

{% highlight C# %}

SfComboBox comboBox = new SfComboBox() 
{
    WidthRequest= 250,
    HeightRequest = 40,
    MaximumSuggestion = 2,
    LoadMoreText= "Load more items",
    IsEditable = true,
    IsFilteringEnabled = true,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
    ItemsSource = socialMediaViewModel.SocialMedias
};
Content = comboBox;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox LoadMoreText](Images/Maximum-display-item-with-Expander/LoadMoreText.png)

## LoadMore view customization

SfComboBox allows customizing User Interface(UI) of Load More view. To customize the load more text, add the custom UI in the [LoadMoreTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_LoadMoreTemplate) API in SfComboBox, as shown in the following code snippet.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox" 
                    WidthRequest="300"
                    HeightRequest="40"
                    IsFilteringEnabled="True"
                    IsEditable="True" 
                    ItemsSource="{Binding SocialMedias}"
                    MaximumSuggestion="2"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name">
    <editors:SfComboBox.LoadMoreTemplate>
        <DataTemplate>
            <Grid BackgroundColor="LightGreen">
                <Label Text="Load more items..." VerticalOptions="Center" FontAttributes="Bold" HorizontalOptions="Center" TextColor="Red"/>
            </Grid>
        </DataTemplate>
    </editors:SfComboBox.LoadMoreTemplate>
</editors:SfComboBox>

{% endhighlight %}

{% highlight C# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();
    SfComboBox comboBox = new SfComboBox
    {
        WidthRequest = 300,
        HeightRequest = 40,
        IsFilteringEnabled = true,
        IsEditable = false, 
        ItemsSource = socialMediaViewModel.SocialMedias,
        MaximumSuggestion = 2,
        DisplayMemberPath = "Name",
        TextMemberPath = "Name"
    };

    comboBox.LoadMoreTemplate = new DataTemplate(() =>
    {
        var grid = new Grid
        {
            BackgroundColor = Colors.LightGreen
        };

        var label = new Label
        {
            Text = "Load more items...",
            TextColor = Colors.Red,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            FontAttributes = FontAttributes.Bold
        };

        grid.Children.Add(label);
        return grid;
    });

    Content = comboBox;
{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI ComboBox LoadMoreTemplate](Images/Maximum-display-item-with-Expander/LoadMoreTemplate.png)

## LoadMore Button Tapped Event

The LoadMore support provides [LoadMoreButtonTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_LoadMoreButtonTapped) Event. The event can be triggered only when you tap on the load more button.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox" 
                    WidthRequest="300"
                    IsFilteringEnabled="True"
                    IsEditable="True" 
                    MaximumSuggestion="2"
                    ItemsSource="{Binding SocialMedias}"
                    LoadMoreButtonTapped="ComboBox_LoadMoreButtonTapped"
                    DisplayMemberPath="Name"                                    
                    TextMemberPath="Name">
</editors:SfComboBox>

{% endhighlight %}

{% highlight C# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();
SfComboBox comboBox = new SfComboBox
{
    WidthRequest = 300,
    HeightRequest=50,
    IsFilteringEnabled = true,
    IsEditable = true,
    MaximumSuggestion = 2,
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name"
};
comboBox.LoadMoreButtonTapped += ComboBox_LoadMoreButtonTapped;
Content = comboBox;

private void ComboBox_LoadMoreButtonTapped(object? sender, EventArgs e)
{

}
{% endhighlight %}
{% endtabs %}


