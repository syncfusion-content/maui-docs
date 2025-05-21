---
layout: post
title: "No Results Found in .NET MAUI Autocomplete Control | Syncfusion®"
description: "Learn about the 'No Results Found' feature in the .NET MAUI Autocomplete (SfAutocomplete) control and understand its functionalities."
platform: maui
control: SfAutocomplete
documentation: ug
---
# No Results Found in .NET MAUI Autocomplete (SfAutocomplete)

When the entered item is not found in the suggestion list, the [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control displays a message indicating that no search results were found. You can set the desired text to be displayed for this message using the [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText) and [NoResultsFoundTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundTemplate) properties.

## NoResultsFoundText

The [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText) property allows you to customize the message text that indicates no results were found.
{% tabs %}

{% highlight xaml %}
                  
<editors:SfAutocomplete x:Name="autocomplete"
                        NoResultsFoundText="Not Found"
                        ItemsSource="{Binding SocialMedias}"
                        TextMemberPath="Name"
                        DisplayMemberPath="Name"/> 

{% endhighlight %}

{% highlight c# %}

SfAutocomplete autocomplete = new SfAutocomplete()
{
    NoResultsFoundText = "Not Found",
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemsSource = socialMediaViewModel.SocialMedias
};

{% endhighlight %}

{% endtabs %}

![NoResultsFoundText](images/NoResultsFound/NoResultsFoundText.png)

## NoResultsFoundTemplate

The [NoResultsFoundTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundTemplate) property allows you to customize the appearance of the message text that indicates no results were found.
{% tabs %}
{% highlight xaml %}

  <editors:SfAutocomplete x:Name="autocomplete"
               ItemsSource="{Binding SocialMedias}"
              TextMemberPath="Name"
             DisplayMemberPath="Name" >
      <editors:SfAutocomplete.NoResultsFoundTemplate>
          <DataTemplate>
              <Label Text="Not Found"  FontSize="20" FontAttributes="Italic" TextColor="Red" Margin="70,10,0,0"/>
           </DataTemplate>
      </editors:SfAutocomplete.NoResultsFoundTemplate>
  </editors:SfAutocomplete>
{% endhighlight %}

{% highlight c# %}


SfAutocomplete autocomplete = new SfAutocomplete()
{
    ItemsSource = socialMediaViewModel.SocialMedias
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
    NoResultsFoundTemplate = new DataTemplate(() =>
    {
        return new Label
        {
            Text = "Not Found",
            FontSize = 20,
            FontAttributes = FontAttributes.Italic,
            TextColor = Colors.Red,
            Margin = new Thickness(70, 10, 0, 0)
        };
    })
};


{% endhighlight %}

{% endtabs %}

![NoResultsFoundTemplate](images/NoResultsFound/NoResultsFoundTemplate.png)

N> By Default [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText) is enabled we can restrict it by using [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText) as Empty.
