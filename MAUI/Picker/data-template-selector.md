---
layout: post
title: DataTemplateSelector with .NET MAUI Picker control | Syncfusion
description: Learn here all about data template selector with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# DataTemplateSelector in .NET MAUI Picker (SfPicker)

The DataTemplateSelector feature of SfPicker allows you to select a DataTemplate based on the data object.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             xmlns:local ="clr-namespace:Picker_29"
             x:Class="Picker_29.MainPage">
              
    <Grid>
        <Grid.Resources>
            <DataTemplate x:Key="indianLanguage">
                <Grid>
                    <Label Grid.Column="1" HorizontalTextAlignment="Center" BackgroundColor="LightGray" VerticalTextAlignment="Center" Text="{Binding Data}"/>
                </Grid>
            </DataTemplate>
            <DataTemplate x:Key="otherLanguage">
                <Grid>
                    <Label HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Text="{Binding Data}"/>
                </Grid>
            </DataTemplate>
            <local:PickerTemplate x:Key="pickerTemplate"
                                    IndianLanguages="{StaticResource indianLanguage}" 
                                    OtherLanguages="{StaticResource otherLanguage}"/>
        </Grid.Resources>
        <sfPicker:SfPicker x:Name="picker" ItemTemplate="{StaticResource pickerTemplate}">
        </sfPicker:SfPicker>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="c#" %}

    using Syncfusion.Maui.Picker;
    using System.Collections.ObjectModel;
    namespace Picker_29;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ObservableCollection<string> languages = new ObservableCollection<string> { "Spanish", "French", "Tamil", "English", "German", "Chinese", "Telegu", "Japanese", "Arabic", "Russian", "Portuguese", "Italian" };
            PickerColumn pickerColumn = new PickerColumn()
            {
                HeaderText = "Select Languages",
                ItemsSource = languages,
                SelectedIndex = 1,
            };
            this.picker.Columns.Add(pickerColumn);
        }
    }

    public class PickerTemplate : DataTemplateSelector
    {
        public DataTemplate IndianLanguages { get; set; }
        public DataTemplate OtherLanguages { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            PickerItemDetails pickerItemDetails = item as PickerItemDetails;
            string language = pickerItemDetails.Data.ToString();
            if (language == "Tamil" || language == "Telegu")
            {
                return this.IndianLanguages;
            }
            else
            {
                return this.OtherLanguages;
            }
        }
    }
    
{% endhighlight %}
{% endtabs %}