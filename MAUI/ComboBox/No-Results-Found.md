---
layout: post
title: No Results Found in  ComboBox control | Syncfusion®
description: Learn all about No Results Found support in .NET MAUI ComboBox (SfComboBox) control and more details.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu.
---
# No Results Found in .NET MAUI ComboBox (SfComboBox)

When the entered item is not in the suggestion list, [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) displays a text indicating there is no search results found. We can set the desire text to be displayed for indicating no results found with the [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText) and [NoResultsFoundTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundTemplate) properties.

## NoResultsFoundText
We can customize the desire text to be displayed for indicating no results found by using the [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText) property. 

{% tabs %}

{% highlight xaml %}

                    
<editors:SfComboBox x:Name="comboBox"
                        IsEditable="True"
                        IsFilteringEnabled="True"
                        NoResultsFoundText="Not Found"
                        ItemsSource="{Binding SocialMedias}"
                        TextMemberPath="Name"
                        DisplayMemberPath="Name" /> 

{% endhighlight %}

{% highlight c# %}

SfComboBox comboBox = new SfComboBox() 
{
    IsFilteringEnabled = true,
    IsEditable = true,
    NoResultsFoundText = "Not Found",
    ItemsSource = socialMediaViewModel.SocialMedias,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
};

{% endhighlight %}

{% endtabs %}

![NoResultsFoundText](images/NoResultsFound/NoResultsFoundText.png)

## NoResultsFoundTemplate

We can customize the appearance of the desire text to be displayed for indicating no results found by using the [NoResultsFoundTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundTemplate) property.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    IsEditable="True"
                    IsFilteringEnabled="True"
                    TextMemberPath="Name"
                    DisplayMemberPath="Name">
    <editors:SfComboBox.NoResultsFoundTemplate>
        <DataTemplate>
            <Label Text="Not Found"  FontSize="20" FontAttributes="Italic" TextColor="Red" Margin="70,10,0,0"/>
        </DataTemplate>
    </editors:SfComboBox.NoResultsFoundTemplate>
</editors:SfComboBox>


{% endhighlight %}

{% highlight c# %}

    SfComboBox comboBox = new SfComboBox() 
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

N> By Default [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText) is enabled we can restrict it by using [NoResultsFoundText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText)as Empty.