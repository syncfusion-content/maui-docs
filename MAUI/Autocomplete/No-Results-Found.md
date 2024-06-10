---
layout: post
title: No Results Found in .NET MAUI  Autocomplete control | Syncfusion
description: Learn about No Results Found support in .NET MAUI Autocomplete (SfAutocomplete) control and more details.
platform: maui
control: SfAutocomplete
documentation: ug
---
# No Results Found in .NET MAUI Autocomplete (SfAutocomplete)

When the entered item is not in the suggestion list, `SfAutocomplete` displays a text indicating there is no search results found. We can set the desire text to be displayed for indicating no results found with the `NoResultsFoundText` and `NoResultsFoundTemplate` properties.

## NoResultsFoundText
We can customize the desire text to be displayed for indicating no results found by using the ` NoResultsFoundText` property.

{% tabs %}

{% highlight xaml %}
                  
<editors:SfAutocomplete x:Name="autocomplete"
                        NoResultsFoundText="Not Found"
                        ItemsSource="{Binding SocialMedias}"
                        TextMemberPath="Name"
                        DisplayMemberPath="Name"
                        WidthRequest="240" /> 

{% endhighlight %}

{% highlight c# %}

autocomplete.NoResultsFoundText = "Not Found";

{% endhighlight %}

{% endtabs %}

![NoResultsFoundText](images/NoResultsFound/NoResultsFoundText.png)

## NoResultsFoundTemplate

We can customize the appearance of the desire text to be displayed for indicating no results found by using the `NoResultsFoundTemplate` property.

{% tabs %}
{% highlight xaml %}

  <editors:SfAutocomplete x:Name="autocomplete"
               ItemsSource="{Binding SocialMedias}"
              TextMemberPath="Name"
             DisplayMemberPath="Name"
             WidthRequest="240">

      <editors:SfAutocomplete.NoResultsFoundTemplate>
          <DataTemplate>
              <Label Text="Not Found"  FontSize="20" FontAttributes="Italic" TextColor="Red" Margin="70,10,0,0"/>
           </DataTemplate>
      </editors:SfAutocomplete.NoResultsFoundTemplate>
  </editors:SfAutocomplete>
{% endhighlight %}

{% highlight c# %}
var noResultsTemplate = new DataTemplate(() =>
        {
            var label = new Label
            {
                Text = "Not Found",
                FontSize = 20,
                FontAttributes = FontAttributes.Italic,
                TextColor = Color.Red,
                Margin = new Thickness(70, 10, 0, 0)
            };

            return new ViewCell { View = label };
        });

autocomplete.NoResultsFoundTemplate = noResultsTemplate;

{% endhighlight %}

{% endtabs %}

![NoResultsFoundTemplate](images/NoResultsFound/NoResultsFoundTemplate.png)

N> By Default `NoResultsFoundText` is enabled we can restrict it by using `NoResultsFoundText` as Empty. `autocomplete.NoResultsFoundText = "";`