---
layout: post
title: LoadMore in .NET MAUI Autocomplete control | Syncfusion<sup>®</sup>
description: Learn all about LoadMore support in Syncfusion<sup>®</sup> .NET MAUI Autocomplete (SfAutocomplete) control and more here.
platform: maui
control: SfAutocomplete
documentation: ug
---

# LoadMore in .NET MAUI Autocomplete (SfAutocomplete)

Restrict the number of suggestions displayed and have the remaining items loaded by selecting LoadMore. We can restrict maximum suggestion to be displayed with the [MaximumSuggestion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_MaximumSuggestion) property.

{% tabs %}
{% highlight xaml %}

 <editors:SfAutocomplete x:Name="autocomplete"
                         WidthRequest="250"
                         ItemsSource="{Binding SocialMedias}"
                         MaximumSuggestion="2"
                         DisplayMemberPath="Name"
                         TextMemberPath="Name" />

{% endhighlight %}

{% highlight C# %}

autocomplete.MaximumSuggestion = 2;

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete LoadMore support](Images/Maximum-display-item-with-Expander/LoadMore.gif)

## LoadMore text customization

The LoadMore support provides [LoadMoreText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_LoadMoreText). We can set the desire text for the displaying the Load more text with the property LoadMoreText.

{% tabs %}
{% highlight xaml %}

 <editors:SfAutocomplete x:Name="autocomplete"
                         WidthRequest="250"
                         ItemsSource="{Binding SocialMedias}"
                         MaximumSuggestion="2"
                         LoadMoreText="Load more items"
                         DisplayMemberPath="Name"
                         TextMemberPath="Name" />

{% endhighlight %}

{% highlight C# %}

autocomplete.MaximumSuggestion = 2;
autocomplete.LoadMoreText= "Load more items";

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete LoadMoreText](Images/Maximum-display-item-with-Expander/LoadMoreText.png)

## LoadMore view customization

SfAutocomplete allows customizing User Interface(UI) of Load More view. To customize the load more text, add the custom UI in the [LoadMoreTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_LoadMoreTemplate) API in SfAutocomplete, as shown in the following code snippet.

{% tabs %}
{% highlight xaml %}

 <editors:SfAutocomplete x:Name="autocomplete"
                         WidthRequest="250"
                         ItemsSource="{Binding SocialMedias}"
                         MaximumSuggestion="2"
                         DisplayMemberPath="Name"
                         TextMemberPath="Name" >
                <editors:SfAutocomplete.LoadMoreTemplate>
                    <DataTemplate>
                        <Grid BackgroundColor="LightGreen">
                            <Label Text="Load more items..." VerticalOptions="Center" FontAttributes="Bold" HorizontalOptions="Center" TextColor="Red"/>
                        </Grid>
                    </DataTemplate>
                </editors:SfAutocomplete.LoadMoreTemplate>
            </editors:SfAutocomplete>

{% endhighlight %}

{% highlight C# %}

autocomplete.MaximumSuggestion = 2;
autocomplete.LoadMoreTemplate = new DataTemplate(() =>
{
    var grid = new Grid();
    Label label = new Label();
    label.Text = "Load more items...";
    label.TextColor = Colors.Red;
    grid.Background = Colors.LightGreen;
    label.HorizontalOptions = LayoutOptions.Center;
    label.VerticalOptions = LayoutOptions.Center;
    label.FontAttributes = FontAttributes.Bold;
    grid.Children.Add(label);
    return grid;
});

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code:

![.NET MAUI Autocomplete LoadMoreTemplate](Images/Maximum-display-item-with-Expander/LoadMoreTemplate.png)

## LoadMore Button Tapped Event

The LoadMore support provides [LoadMoreButtonTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_LoadMoreButtonTapped) Event. The event can be triggered only when you tap on the load more button.

{% tabs %}
{% highlight xaml %}

 <editors:SfAutocomplete x:Name="autocomplete"
                         WidthRequest="250"
                         ItemsSource="{Binding SocialMedias}"
                         MaximumSuggestion="2"
                         LoadMoreButtonTapped="autocomplete_LoadMoreButtonTapped"
                         DisplayMemberPath="Name"
                         TextMemberPath="Name" >
             </editors:SfAutocomplete>

{% endhighlight %}

{% highlight C# %}

autocomplete.MaximumSuggestion = 2;
autocomplete.LoadMoreButtonTapped += Autocomplete_LoadMoreButtonTapped;

private void Autocomplete_LoadMoreButtonTapped(object? sender, EventArgs e)
{

}

{% endhighlight %}
{% endtabs %}


