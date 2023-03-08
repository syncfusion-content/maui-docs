---
layout: post
title: Floating label layout in .NET MAUI DataForm control | Syncfusion
description: Learn about the Floating label layout support in Syncfusion .NET MAUI DataForm (SfDataForm) control in mobile and desktop applications from a single shared codebase.
platform: maui
control: SfDataForm
documentation: ug
---

# Floating label Layout in .NET MAUI DataForm (SfDataForm)

## Overview

The floating label layout is a powerful feature that enhances the user experience and makes it easier for users to interact with forms.The dataform supports floating label layout which includes assistive labels, leading and trailing icons, and a password toggle icon to show or hide a password. It also supports leading and trailing labels. It offers three different kinds of containers, including filled, outlined, and none. Setting "LayoutType" to "TextInputLayout" enables floating label layout.

## Layout type
By default, the dataform arranges the editors and their labels corresponding to the fields in layout. However, to enable the floating label layout set `LayoutType` property of `SfDataForm` or `DataFormItem` to `TextInputLayout`.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm"
        LayoutType="TextInputLayout">
    </dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

this.dataForm.LayoutType = DataFormLayoutType.TextInputLayout;

{% endhighlight %}
{% endtabs %}

### Changing layout type of the DataFormItem
You can change layout type by using the `LayoutType` property of [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html) and it will be handled in the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}"
                        GenerateDataFormItem="OnGenerateDataFormItem">
</dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null && e.DataFormItem.FieldName == "FirstName")
    {
        e.DataFormItem.LayoutType = DataFormLayoutType.TextInputLayout;
    }
}

{% endhighlight %}
{% endtabs %}

## Supported editors
Dataform supports the floating label layout for the following editors.
* Text editor
* Password editor
* MultilineText editor
* ComboBox editor
* AutoComplete editor
* Custom editor

## Container types
Containers enhance the perspective of dataform editor views. By default, the container type is `Outlined`. By using the `ContainerType` property in `DataForm` or in `DataFormItem`, you can modify the container type to `Filled` or `None`.

#### Outlined
The `Outlined` container type draws a thin border around the text input field and adds a hint text that floats above the input field when the user starts typing. To enable the outlined container type, you can set `ContainerType` property of `TextInputLayoutSettings` to `Outlined` in `DataForm` or in `DataFormItem` which covers the editor view with rounded-corner.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}">
    <dataForm:SfDataForm.TextInputLayoutSettings>
        <dataForm:TextInputLayoutSettings ContainerType="Outlined"/>
    </dataForm:SfDataForm.TextInputLayoutSettings>
</dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
    {
        e.DataFormItem.LayoutType = DataFormLayoutType.TextInputLayout;
        e.DataFormItem.TextInputLayoutSettings = new TextInputLayoutSettings
        {
            ContainerType = TextInputLayoutContainerType.Outlined
        };
    }
}

{% endhighlight %}
{% endtabs %}

#### Filled
The `Filled` container type fills the background of the text input field with a solid color and adds a hint text that floats above the input field when the user starts typing. It can be enabled by setting the `ContainerType` property to `Filled` in `DataForm` or in `DataFormItem`.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}">
    <dataForm:SfDataForm.TextInputLayoutSettings>
        <dataForm:TextInputLayoutSettings ContainerType="Filled"/>
    </dataForm:SfDataForm.TextInputLayoutSettings>
</dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
    {
        e.DataFormItem.LayoutType = DataFormLayoutType.TextInputLayout;
        e.DataFormItem.TextInputLayoutSettings = new TextInputLayoutSettings
        {
            ContainerType = TextInputLayoutContainerType.Filled
        };
    }
}

{% endhighlight %}
{% endtabs %}

#### None

The `None` container type does not add any border or background to the text input field and it can be enabled by setting the `ContainerType`property to `None` in `DataForm` or in `DataFormItem` container, it will have empty background and enough spacing.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}">
    <dataForm:SfDataForm.TextInputLayoutSettings>
        <dataForm:TextInputLayoutSettings ContainerType="None"/>
    </dataForm:SfDataForm.TextInputLayoutSettings>
</dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
    {
        e.DataFormItem.LayoutType = DataFormLayoutType.TextInputLayout;
        e.DataFormItem.TextInputLayoutSettings = new TextInputLayoutSettings
        {
            ContainerType = TextInputLayoutContainerType.None
        };
    }
}

{% endhighlight %}
{% endtabs %}

## Leading and Trailing view

#### Leading view
The leading view is a view that appears to the left of the text input field. It can be used to add additional functionality or visual elements to the text input, such as a label or an icon. It can be added to the floating label layout by setting the `LeadingView` property of [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). You can able show leading view only when `ShowLeadingView` property is `true.`

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}">
<dataForm:SfDataForm.Items>
    <dataForm:DataFormTextItem FieldName="Name" ShowLeadingView="True">
        <dataForm:DataFormTextItem.LeadingView>
            <Label Text="F" FontSize="18" TextColor="Gray" FontFamily="InputLayoutIcons" HeightRequest="24" VerticalTextAlignment="End" />
        </dataForm:DataFormTextItem.LeadingView>
    </dataForm:DataFormTextItem>
</dataForm:SfDataForm.Items>
</dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
    {
        e.DataFormItem.LayoutType = DataFormLayoutType.TextInputLayout;
        e.DataFormItem.ShowLeadingView = true;
        e.DataFormItem.LeadingView = new Label { Text = "F", FontSize = 18, TextColor = Colors.Gray, FontFamily = "InputLayoutIcons", HeightRequest = 24, VerticalTextAlignment = TextAlignment.End };
    }
}

{% endhighlight %}
{% endtabs %}

N> The `LeadingView` is applicable for both `Default` and `TextInputLayout` layout types

#### Trailing view
The trailing view is a view that appears to the right of the text input field. It can be used to add additional functionality or visual elements to the text input, such as a clear button or an icon. It can be added to the floating label layout by setting the `TrailingView` property of [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). You can able show trailing view only when `ShowTrailingView` property is `true.`

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}">
<dataForm:SfDataForm.Items>
    <dataForm:DataFormTextItem FieldName="Name" 
                                ShowTrailingView="True">
        <dataForm:DataFormTextItem.TrailingView>
            <Label Text="F" FontSize="18" TextColor="Gray" FontFamily="InputLayoutIcons" HeightRequest="24" VerticalTextAlignment="End" />
        </dataForm:DataFormTextItem.TrailingView>
    </dataForm:DataFormTextItem>
</dataForm:SfDataForm.Items>
</dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
    {
        e.DataFormItem.LayoutType = DataFormLayoutType.TextInputLayout;
        e.DataFormItem.ShowTrailingView = true;
        e.DataFormItem.TrailingView = new Label { Text = "F", FontSize = 18, TextColor = Colors.Gray, FontFamily = "InputLayoutIcons", HeightRequest = 24, VerticalTextAlignment = TextAlignment.End };
    }
}

{% endhighlight %}
{% endtabs %}

N> The `TrailingView` is applicable only when `LayoutType` is `TextInputLayout` layout types

#### Leading and Trailing View Position
The `LeadingViewPosition` and `TrailingViewPosition` properties of `DataFormItem` allow you to adjust the leading and trailing view's positions. The view is positioned `outside` of the container if the leading and trailing view positions are both set to `TextInputLayoutViewPosition.Outside`. The view is positioned `inside` the container if the leading and trailing view positions are both set to `TextInputLayoutViewPosition.Inside`.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}">
<dataForm:SfDataForm.Items>
    <dataForm:DataFormTextItem FieldName="Name" 
                                ShowLeadingView="True" 
                                LeadingViewPosition="Outside">
        <dataForm:DataFormTextItem.LeadingView>
            <Label Text="F" FontSize="18" TextColor="Gray" FontFamily="InputLayoutIcons" HeightRequest="24" VerticalTextAlignment="End" />
        </dataForm:DataFormTextItem.LeadingView>
    </dataForm:DataFormTextItem>
</dataForm:SfDataForm.Items>
</dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}">
<dataForm:SfDataForm.Items>
    <dataForm:DataFormTextItem FieldName="Name" 
                                ShowTrailingView="True" 
                                TrailingViewPosition="Inside">
        <dataForm:DataFormTextItem.TrailingView>
            <Label Text="F" FontSize="18" TextColor="Gray" FontFamily="InputLayoutIcons" HeightRequest="24" VerticalTextAlignment="End" />
        </dataForm:DataFormTextItem.TrailingView>
    </dataForm:DataFormTextItem>
</dataForm:SfDataForm.Items>
</dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
    {
        e.DataFormItem.LayoutType = DataFormLayoutType.TextInputLayout;
        e.DataFormItem.ShowLeadingView = true;
        e.DataFormItem.LeadingViewPosition = TextInputLayoutViewPosition.Outside;
        e.DataFormItem.LeadingView = new Label { Text = "F", FontSize = 18, TextColor = Colors.Gray, FontFamily = "InputLayoutIcons", HeightRequest = 24, VerticalTextAlignment = TextAlignment.End };
    }
}

{% endhighlight %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
    {
        e.DataFormItem.LayoutType = DataFormLayoutType.TextInputLayout;
        e.DataFormItem.ShowTrailingView = true;
        e.DataFormItem.TrailingViewPosition = TextInputLayoutViewPosition.Inside;
        e.DataFormItem.TrailingView = new Label { Text = "F", FontSize = 18, TextColor = Colors.Gray, FontFamily = "InputLayoutIcons", HeightRequest = 24, VerticalTextAlignment = TextAlignment.End };
    }
}

{% endhighlight %}
{% endtabs %}

## Enable password visibility toggle for password editor
Password toggle visibility in floating label layout is used to show or hide the visibility of characters in the dataform password editor. You can enable this toggle by setting the `EnablePasswordVisibilityToggle` property to true in `DataFormItem`. The default value of `EnablePasswordVisibilityToggle` is `true`.


{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}">
<dataForm:SfDataForm.Items>
    <dataForm:DataFormPasswordItem FieldName="Name" 
                                EnablePasswordVisibilityToggle="True">
    </dataForm:DataFormPasswordItem>
</dataForm:SfDataForm.Items>
</dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name" && e.DataFormItem is DataFormPasswordItem passwordItem)
    {
        passwordItem.LayoutType = DataFormLayoutType.TextInputLayout;
        passwordItem.EnablePasswordVisibilityToggle = true;
    }
}

{% endhighlight %}
{% endtabs %}

## Assistive label

#### Hint label
The data field name will be displayed as floating or hint label for the editor, and it will be enabled by using the `Name` or `LabelText` property.

#### Helper label
The helper label is used to display the water mark for the editor to provide hint for users and it can be set using `Prompt` or `PlaceHolderText`. 

The visibility of helper text in DataForm floating label layout for `DataForm` and `DataFormItem` can be collapsed by setting `ShowHelperText` property of `TextInputLayoutSettings` to `false`

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}">
    <dataForm:SfDataForm.TextInputLayoutSettings>
        <dataForm:TextInputLayoutSettings ShowHelperText="False"/>
    </dataForm:SfDataForm.TextInputLayoutSettings>
</dataForm:SfDataForm>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;

private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
{
    if (e.DataFormItem != null && e.DataFormItem.FieldName == "Name")
    {
        e.DataFormItem.TextInputLayoutSettings = new TextInputLayoutSettings
        {
            ShowHelperText = false,
        };
    }
}

{% endhighlight %}
{% endtabs %}

#### Validation label
The validation label used to display the dataform validation messages such as valid or invalid data. Refer [validation](https://help.syncfusion.com/maui/dataform/validation) to learn more about dataform validation.

## Appearance customization

