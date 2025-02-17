---
layout: post
title: Header and Footer in MAUI ComboBox control | Syncfusion
description: Learn here all about Header and Footer support in Syncfusion Maui ComboBox (SfComboBox) control and more.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu.
---

# Header and Footer support in .NET MAUI ComboBox (SfComboBox)

You can provide header and footer views in the dropdown in [SfComboBox](https://www.syncfusion.com/maui-controls/maui-combobox) by enabling the [ShowDropDownHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ShowDropdownHeaderView) and the [ShowDropDownFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ShowDropdownFooterView) properties. 

## Header content

You can provide content for header at the top of the ComboBox's dropdown. The [DropDownHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropdownHeaderView) property is used to set the content of the header. The height of the header in the [SfComboBox](https://www.syncfusion.com/maui-controls/maui-combobox) can be adjusted using the [DropDownHeaderViewHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropdownHeaderViewHeight) property.

{% tabs %}

{% highlight xaml %}

    <StackLayout VerticalOptions="Start" HorizontalOptions="Start" Padding="30">
        <editors:SfComboBox HeightRequest="50" WidthRequest="350" x:Name="comboBox" IsEditable="true" DisplayMemberPath="Name" ItemsSource="{Binding SocialMedias}" IsFilteringEnabled="true" TextMemberPath="Name" ShowDropdownHeaderView="True">
            <editors:SfComboBox.DropdownHeaderView>
                <StackLayout BackgroundColor="#f0f0f0" >
                    <Label  x:Name="label2" Text="Header View" FontSize="20" VerticalTextAlignment="Center" HorizontalOptions="Center" VerticalOptions="Center" TextColor="#006bcd" />
                </StackLayout>
            </editors:SfComboBox.DropdownHeaderView>        
        </editors:SfComboBox>
    </StackLayout>                  


{% endhighlight %}

{% highlight c# %}

    StackLayout layout = new StackLayout()
    {
        VerticalOptions = LayoutOptions.Start,
        HorizontalOptions = LayoutOptions.Start,
        Padding = new Thickness(30)
    };

     SfComboBox comboBox = new SfComboBox()
     {
        HeightRequest = 50,
        WidthRequest = 350,
        ShowDropdownHeaderView = true,
        ItemsSource = socialMediaViewModel.SocialMedias,
        IsEditable = true,
        DisplayMemberPath = "Name",
        TextMemberPath = "Name",
        IsFilteringEnabled = true,
        DropdownHeaderViewHeight = 50
    };

    StackLayout customHeaderView = new StackLayout();
    Label label2 = new Label()
    {
        FontSize = 20,
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center,
        HorizontalOptions = LayoutOptions.Center,
        Text = "Header View",
        VerticalOptions = LayoutOptions.Center,
        TextColor = Colors.FromHex("#006bcd")
    };

    customHeaderView.Children.Add(label2);
    comboBox.DropdownHeaderView = customHeaderView;
    layout.Children.Add(comboBox);
    this.Content = layout;

{% endhighlight %}

{% endtabs %}

![Header Image](Images/HeaderFooter/headertemplate.png)

## Footer content

You can provide content for footer at the bottom of the ComboBox's dropdown. The [DropDownFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropdownFooterView) property is used to set the content for footer. The height of the footer in the [SfComboBox](https://www.syncfusion.com/maui-controls/maui-combobox) can be adjusted using the [DropDownFooterViewHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropdownFooterViewHeight) property.

The following code example shows how to set footer content in [SfComboBox](https://www.syncfusion.com/maui-controls/maui-combobox).

{% tabs %}

{% highlight xaml %}

    <StackLayout VerticalOptions="Start" HorizontalOptions="Start" Padding="30">
        <editors:SfComboBox HeightRequest="50" ItemsSource="{Binding SocialMedias}" DisplayMemberPath="Name" x:Name="comboBox" IsEditableMode="true" AllowFiltering="true">
            <editors:SfComboBox.DropDownFooterView>
                <StackLayout BackgroundColor="#f0f0f0" >
                    <Label Text="Add New" BackgroundColor="#f0f0f0" TextColor="#006bcd" VerticalTextAlignment="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" FontSize="20"/>
                </StackLayout>
            </editors:SfComboBox.DropDownFooterView>
        </editors:SfComboBox>
    </StackLayout>                  

{% endhighlight %}

{% highlight c# %}

    StackLayout layout = new StackLayout()
    {
        VerticalOptions = LayoutOptions.Start,
        HorizontalOptions = LayoutOptions.Start,
        Padding = new Thickness(30)
    };

    SfComboBox comboBox = new SfComboBox()
     {
        HeightRequest = 50,
        ShowDropdownFooterView = true,
        WidthRequest = 350,
        ItemsSource = socialMediaViewModel.SocialMedias,
        IsEditable = true,
        DisplayMemberPath = "Name",
        TextMemberPath = "Name",
        IsFilteringEnabled = true,
        DropDownFooterViewHeight = 50
    };

    StackLayout customFooterView = new StackLayout();
    Label label = new Label() 
    { 
        Text = "Footer View", 
        BackgroundColor = Colors.FromHex("#f0f0f0"), 
        TextColor = Colors.FromHex("#006bcd"), 
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

![Footer Image](Images/HeaderFooter/footertemplate.png)

