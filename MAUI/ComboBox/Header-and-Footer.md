---
layout: post
title: Header and Footer in Maui ComboBox control | Syncfusion
description: Learn here all about Header and Footer support in Syncfusion Maui ComboBox (SfComboBox) control and more.
platform: maui
control: SfComboBox
documentation: ug
---
# Header and Footer in Maui ComboBox (SfComboBox)

You can provide header and footer views in the suggestion list in [`SfComboBox`] by enabling the [`ShowDropDownHeaderView`] and the [`ShowDropDownFooterView`] properties. 

## Header content

You can provide content for header at the top of the ComboBox's Suggestion box. The [`DropDownHeaderView`] property is used to set the content of the header. The height of the header in the [`SfComboBox`] can be adjusted using the [`DropDownHeaderViewHeight`] property.

{% tabs %}

{% highlight xaml %}

    <StackLayout VerticalOptions="Start" HorizontalOptions="Start" Padding="30">
        <combobox:SfComboBox HeightRequest="40" x:Name="comboBox" IsEditableMode="true" AllowFiltering="true">
            <combobox:SfComboBox.DataSource>
                <ListCollection:List x:TypeArguments="x:String">
                    <x:String> Uganda </x:String>
                    <x:String> Ukraine </x:String>
                    <x:String> United Arab Emirates </x:String>
                    <x:String> United Kingdom </x:String>
                    <x:String> United States </x:String>
                </ListCollection:List>
            </combobox:SfComboBox.DataSource> 
            <combobox:SfComboBox.DropDownHeaderView>
                <StackLayout BackgroundColor="#f0f0f0" >
                    <Label  x:Name="label2" FontSize="20" VerticalTextAlignment="Center" HorizontalOptions="Center" VerticalOptions="Center" TextColor="#006bcd" />
                </StackLayout>
            </combobox:SfComboBox.DropDownHeaderView>        
        </combobox:SfComboBox>
    </StackLayout>                  


{% endhighlight %}

{% highlight c# %}

    StackLayout layout = new StackLayout()
    {
        VerticalOptions = LayoutOptions.Start,
        HorizontalOptions = LayoutOptions.Start,
        Padding = new Thickness(30)
    };

    Label label2 = new Label()
    {
        FontSize = 20,
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        TextColor = Color.FromHex("#006bcd")
    };

    List<String> countryNames = new List<String>();
    countryNames.Add("Uganda");
    countryNames.Add("Ukraine");
    countryNames.Add("United Arab Emirates");
    countryNames.Add("United Kingdom");
    countryNames.Add("United States");

    SfComboBox comboBox = new SfComboBox();
    comboBox.HeightRequest = 40;
    comboBox.DataSource = countryNames;
    comboBox.IsEditableMode = true;
    comboBox.AllowFiltering = true;
    comboBox.ShowDropDownHeaderView = true;
    //Set the height of the Header View
    comboBox.DropDownHeaderViewHeight = 50;
    comboBox.ValueChanged += (object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e) =>
    {
        label2.Text = "Search for " + e.Value;
    };

    comboBox.DropDownHeaderView = label2;
    layout.Children.Add(comboBox);
    this.Content = layout;

{% endhighlight %}

{% endtabs %}

![Header Image]

## Footer content

You can provide content for footer at the bottom of the ComboBox's Suggestion box. The [`DropDownFooterView`] property is used to set the content for footer. The height of the footer in the [`SfComboBox`] can be adjusted using the [`DropDownFooterViewHeight`] property.

The following code example shows how to set footer content in [`SfComboBox`].

{% tabs %}

{% highlight xaml %}

    <StackLayout VerticalOptions="Start" HorizontalOptions="Start" Padding="30">
        <combobox:SfComboBox HeightRequest="40" x:Name="comboBox" IsEditableMode="true" AllowFiltering="true">
            <combobox:SfComboBox.DataSource>
                <ListCollection:List x:TypeArguments="x:String">
                    <x:String> Uganda </x:String>
                    <x:String> Ukraine </x:String>
                    <x:String> United Arab Emirates </x:String>
                    <x:String> United Kingdom </x:String>
                    <x:String> United States </x:String>
                </ListCollection:List>
            </combobox:SfComboBox.DataSource> 
            <combobox:SfComboBox.DropDownFooterView>
                <StackLayout BackgroundColor="#f0f0f0" >
                    <Label Text="Add New" BackgroundColor="#f0f0f0" TextColor="#006bcd" VerticalTextAlignment="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" FontSize="20"/>
                </StackLayout>
            </combobox:SfComboBox.DropDownFooterView>
        </combobox:SfComboBox>
    </StackLayout>                  

{% endhighlight %}

{% highlight c# %}

    StackLayout layout = new StackLayout()
    {
        VerticalOptions = LayoutOptions.Start,
        HorizontalOptions = LayoutOptions.Start,
        Padding = new Thickness(30)
    };
    List<String> countryNames = new List<String>();
    countryNames.Add("Uganda");
    countryNames.Add("Ukraine");
    countryNames.Add("United Arab Emirates");
    countryNames.Add("United Kingdom");
    countryNames.Add("United States");

    SfComboBox comboBox = new SfComboBox();
    comboBox.HeightRequest = 40;
    comboBox.DataSource = countryNames;
    comboBox.IsEditableMode = true;
    comboBox.AllowFiltering = true;
    comboBox.ShowDropDownFooterView = true;

    StackLayout customFooterView = new StackLayout();
    Label label = new Label() 
    { 
        Text = "Add New", 
        BackgroundColor = Color.FromHex("#f0f0f0"), 
        TextColor = Color.FromHex("#006bcd"), 
        VerticalOptions = LayoutOptions.Center, 
        VerticalTextAlignment = TextAlignment.Center, 
        HorizontalTextAlignment = TextAlignment.Center, 
        FontSize = 20 
    };
    customFooterView.Children.Add(label);
    comboBox.DropDownFooterView = customFooterView;
    layout.Children.Add(comboBox);
    Content = layout;

{% endhighlight %}

{% endtabs %}

