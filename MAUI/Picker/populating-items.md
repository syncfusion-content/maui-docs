---
layout: post
title: Populating with .NET MAUI Picker Control | Syncfusion
description: Learn here all about populating items with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Populating Items in MAUI Picker (SfPicker)

In .NET MAUI, you can bind a Picker control to an external data source by setting its ItemsSource property to an ObservableCollection. This enables the Picker to display and update data from the collection.

To bind the item source in the picker, set the `SfPicker.Columns.ItemSource` property as shown in the following code.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    ObservableCollection<object> cityName = new ObservableCollection<object>();
    cityName.Add("Chennai");
    cityName.Add("Mumbai");
    cityName.Add("Delhi");
    cityName.Add("Kolkata");
    cityName.Add("Bangalore");
    cityName.Add("Hyderabad");
    cityName.Add("Pune");
    cityName.Add("Ahmedabad");
    cityName.Add("Jaipur");
    cityName.Add("Lucknow");
    cityName.Add("Chandigarh");
    PickerColumn pickerColumn = new PickerColumn()
    {
        HeaderText = "Select City",
        ItemsSource = cityName,
        SelectedIndex = 1,
    };
    this.Picker.Columns.Add(pickerColumn);

{% endhighlight %}
{% endtabs %}

## Multi-column items

The picker populates the items as Multi-column based on the columns value.

Collection of items can be created and assigned to a Collection based on index value, and each index is a column of picker.

The following code example encapsulate how to populate Country and Cityes in each column of picker.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    ObservableCollection<object> countryName = new ObservableCollection<object>();
    countryName.Add("Canada");
    countryName.Add("United States");
    countryName.Add("India");
    countryName.Add("United Kingdom");
    countryName.Add("Australia");
    countryName.Add("Germany");
    countryName.Add("France");
    countryName.Add("Japan");
    countryName.Add("China");
    countryName.Add("Brazil");
    PickerColumn countryColumn = new PickerColumn()
    {
        HeaderText = "Select Country",
        ItemsSource = countryName,
        SelectedIndex = 1,
    };
    ObservableCollection<object> cityName = new ObservableCollection<object>();
    cityName.Add("Chennai");
    cityName.Add("Mumbai");
    cityName.Add("Delhi");
    cityName.Add("Kolkata");
    cityName.Add("Bangalore");
    cityName.Add("Hyderabad");
    cityName.Add("Pune");
    cityName.Add("Ahmedabad");
    cityName.Add("Jaipur");
    cityName.Add("Lucknow");
    cityName.Add("Chandigarh");
    PickerColumn cityColumn = new PickerColumn()
    {
        HeaderText = "Select City",
        ItemsSource = cityName,
        SelectedIndex = 1,
    };
    this.Picker.Columns.Add(countryColumn);
    this.Picker.Columns.Add(cityColumn);

{% endhighlight %}
{% endtabs %}

## Set items text style customization

The .NET MAUI Picker control, selected and unselected items, [TextColor], [FontSize], [FontFamily], and [FontAttributes] can be customized as shown in the following code.

### Selected item customization

Selected item text style can be customized by setting `SfPicker.SelectedTextStyle` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
        <sfPicker:SfPicker.SelectedTextStyle>
            <sfPicker:PickerTextStyle FontSize="16" FontAttributes="Bold" TextColor="White">
            </sfPicker:PickerTextStyle>
        </sfPicker:SfPicker.SelectedTextStyle>
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.SelectedTextStyle.FontSize = 16;
    this.Picker.SelectedTextStyle.FontAttributes = FontAttributes.Bold;
    this.Picker.SelectedTextStyle.TextColor = Colors.White;

{% endhighlight %}
{% endtabs %}

### Unselected item customization

Unselected item text style can be customized by setting `SfPicker.TextStyle` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker">
        <sfPicker:SfPicker.TextStyle>
            <sfPicker:PickerTextStyle FontSize="16" FontAttributes="Italic" TextColor="Black">
            </sfPicker:PickerTextStyle>
        </sfPicker:SfPicker.TextStyle>
    </sfPicker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.TextStyle.FontSize = 16;
    this.Picker.TextStyle.FontAttributes = FontAttributes.Italic;
    this.Picker.TextStyle.TextColor = Colors.Black;

{% endhighlight %}
{% endtabs %}

## Adding custom view to items

In picker control, the items can be customized with a custom view of all items by ItemTemplate and assign a custom view to the `ItemTemplate`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <Grid>
        <Grid.Resources>
            <DataTemplate x:Key="customView">
                <Grid Background = "black" >
                    <Label HorizontalTextAlignment="Center" VerticalTextAlignment="Center" TextColor="Red" Text="{Binding Data}"/>
                    </Grid>
            </DataTemplate>
        </Grid.Resources>
    <sfPicker:SfPicker x:Name="Picker" ItemTemplate="{StaticResource customView}">
    </sfPicker:SfPicker>
    </Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    DataTemplate customView = new DataTemplate(() =>
    {
        Grid grid = new Grid
        {
            Padding = new Thickness(0, 1, 0, 1);
        };
        Label label = new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            HorizontalTextAlignment = TextAlignment.Center,
            VerticalTextAlignment = TextAlignment.Center,
            TextColor = Colors.Black,
        };
        label.SetBinding(Label.TextProperty, new Binding("Data"));
        grid.Children.Add(label);
        return grid;
    });
    this.Picker.ItemTemplate = customView;

{% endhighlight %}
{% endtabs %}
