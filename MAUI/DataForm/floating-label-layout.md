---
Layout: Post
Title: Floating label layout in .NET MAUI DataForm control | Syncfusion
Description: Learn about the Floating label layout support in Syncfusion .NET MAUI DataForm (SfDataForm) control.
Platform: Maui
Control: SfDataForm
Documentation: UG
---

# Floating label Layout in .NET MAUI DataForm (SfDataForm)

## Overview

The floating label layout is a powerful feature that enhances the user experience and makes it easier for users to interact with forms. The data form supports a floating label layout which includes assistive labels, leading and trailing icons, and a password toggle icon to show or hide a password. It offers three different containers, including filled, outlined, and none. Setting `LayoutType` to `TextInputLayout` enables a floating label layout.

## Changing the layout type for the data form
By default, the dataform arranges the editors and their labels corresponding to the fields in the layout. However, to enable the floating label layout for data form, set the LayoutType property of the `SfDataForm` or `DataFormItem` to `TextInputLayout`.

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

![Changing the layout type in .NET MAUI DataForm.](images/floating-label-layout/outlined-container-type.png)

#### Changing the layout type for the editor
Change the layout type for the editor by using the `LayoutType` property of the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html), and it will be handled in the [GenerateDataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem) event.

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
Containers enhance the perspective of the dataform editor views. By default, the container type is `Outlined`. By using the `ContainerType` property of the `TextInputLayoutSettings` in `DataForm` or `DataFormItem`, modify the container type to `Filled` or `None`.

#### Outlined
The `Outlined` container type draws a thin border around the text input field and adds a hint text that floats above the input field when the user starts typing. To enable the outlined container type, set the `ContainerType` property of the `TextInputLayoutSettings` to `Outlined` in `DataForm` or `DataFormItem`, which covers the editor view with rounded-corner.

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

public class ContactInfo
{
    [Display(Name = "First Name", Prompt = "Enter your first name")]
    [DataFormDisplayOptions(ValidMessage = "Valid name")]
    [Required(ErrorMessage = "Please enter your first name")]
    [StringLength(10, ErrorMessage = "First name should not exceed 10 characters")]
    public string FirstName { get; set; }

    [Display(Name = "Middle Name")]
    [Required(ErrorMessage = "Please enter your middle name")]
    [StringLength(10, ErrorMessage = "First name should not exceed 10 characters")]
    public string MiddleName { get; set; }

    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "Please enter your last name")]
    [StringLength(10, ErrorMessage = "First name should not exceed 10 characters")]
    public string LastName { get; set; }

    [Display(Name = "Contact Number")]
    public string ContactNumber { get; set; }

    [Display(Name = "Email", Prompt = "Enter your email")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }

    public string Address { get; set; }
}

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

![Outlined container type in .NET MAUI DataForm.](images/floating-label-layout/outlined-container-type.png)

#### Filled
The `Filled` container type fills the background of the text input field with a solid color and adds a hint of text that floats above the input field when the user starts typing. It can be enabled by setting the `ContainerType` property to `Filled` in the `DataForm` or `DataFormItem`.

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

![Filled container type in .NET MAUI DataForm.](images/floating-label-layout/filled-container-type.png)

#### None
The `None` container type adds no border or background to the text input field. It can be enabled by setting the `ContainerType` property to `None` in the `DataForm` or `DataFormItem` container. It will have an empty background and enough spacing.

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

![None container type in .NET MAUI DataForm.](images/floating-label-layout/none-container-type.png)

## Leading and Trailing view

#### Leading view
The leading view is a view that appears to the left of the text input field. It can add functionality or visual elements to the text input such as a label or an icon. It can be added to the floating label layout by setting the `LeadingView` property of the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Show the leading view only when the `ShowLeadingView` property is `true`.

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

![Leading view in .NET MAUI DataForm.](images/floating-label-layout/leading-view.png)

#### Trailing view
The trailing view is a view that appears to the right of the text input field. It can be used to add additional functionality or visual elements to the text input such as a clear button or an icon. It can be added to the floating label layout by setting the `TrailingView` property of the [DataFormItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html). Show a trailing view only when the `ShowTrailingView` property is `true`.

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

N> The `TrailingView` is applicable only when the `LayoutType` is `TextInputLayout`.

![Trailing view in .NET MAUI DataForm.](images/floating-label-layout/trailing-view.png)

#### Leading and Trailing View Position
The `LeadingViewPosition` and `TrailingViewPosition` properties of the `DataFormItem` allow you to adjust the leading and trailing view's positions. The view is positioned `outside` the container if the leading and trailing view positions are set to `TextInputLayoutViewPosition.Outside`. The view is positioned `inside` the container if the leading and trailing view positions are set to `TextInputLayoutViewPosition.Inside`.

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

![Leading and Trailing view position in .NET MAUI DataForm.](images/floating-label-layout/view-position.png)

## Enable password visibility toggle for password editor
Password toggle visibility in a floating label layout is used to show or hide the visibility of characters in the dataform password editor. Enable this toggle by setting the `EnablePasswordVisibilityToggle` property to true in the `DataFormItem`. The default value of the `EnablePasswordVisibilityToggle` is `true`.

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

![Enable password visibility in .NET MAUI DataForm.](images/floating-label-layout/password-toggle.png)

## Assistive label

#### Hint label
The data field name will be displayed as a floating or hint label for the editor and enabled by using the `Name` or `LabelText` property.

#### Helper label
The helper label displays the watermark for the editor to provide hints for users, and it can be set using `Prompt` or `PlaceHolderText`.

The visibility of the helper text in the DataForm floating label layout for the `DataForm` and `DataFormItem` can be collapsed by setting the `ShowHelperText` property of the `TextInputLayoutSettings` to `false`.

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
        e.DataFormItem.LayoutType = DataFormLayoutType.TextInputLayout;
        e.DataFormItem.TextInputLayoutSettings = new TextInputLayoutSettings
        {
            ShowHelperText = false,
        };
    }
}

{% endhighlight %}
{% endtabs %}

![Show helper text in .NET MAUI DataForm.](images/floating-label-layout/show-helper-false.png)

#### Validation label
The validation label displays the dataform validation messages such as valid or invalid data. Refer to the [validation](https://help.syncfusion.com/maui/dataform/validation) to learn more about the dataform validation.

## Customize Assistive label using text style
Customize the font of assistive labels by setting the `TextColor`, `FontFamily`, `FontSize`, and `FontAttributes` properties of the `DataFormTextStyle` property.

#### Hint label style
Customize the text of the hint label by setting the `TextColor`, `FontFamily`, `FontSize`, and `FontAttributes` properties of the `LabelTextStyle` in the DataFormItem.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}"
                        GenerateDataFormItem="OnGenerateDataFormItem">
    <dataForm:SfDataForm.TextInputLayoutSettings>
        <dataForm:TextInputLayoutSettings ShowHelperText="True">
            <dataForm:DataFormTextItem.LabelTextStyle>
                <dataForm:DataFormTextStyle TextColor="CadetBlue" FontAttributes="None"/>
            </dataForm:DataFormTextItem.LabelTextStyle>
        </dataForm:TextInputLayoutSettings>
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
        e.DataFormItem.LabelTextStyle = new DataFormTextStyle { FontAttributes = FontAttributes.Bold, TextColor = Colors.BlueViolet };
    }
}

{% endhighlight %}
{% endtabs %}

![Hint label style in .NET MAUI DataForm.](images/floating-label-layout/hint-label-style.png)

#### Helper label style
Customize the text of the helper label by setting the `TextColor`, `FontFamily`, `FontSize`, and `FontAttributes` properties of the `HelperTextStyle` in the DataFormItem.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}"
                        GenerateDataFormItem="OnGenerateDataFormItem">
    <dataForm:SfDataForm.TextInputLayoutSettings>
        <dataForm:TextInputLayoutSettings ShowHelperText="True">
            <dataForm:TextInputLayoutSettings.HelperTextStyle>
                <dataForm:DataFormTextStyle FontAttributes="Italic" TextColor="Violet" />
            </dataForm:TextInputLayoutSettings.HelperTextStyle>
        </dataForm:TextInputLayoutSettings>
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
            HelperTextStyle = new DataFormTextStyle { TextColor = Colors.Blue, FontAttributes = FontAttributes.Bold },
        };
    }
}

{% endhighlight %}
{% endtabs %}

![Helper label style in .NET MAUI DataForm.](images/floating-label-layout/helper-text-style.png)

#### Error message label style
Customize the text of the error message label by setting the `TextColor`, `FontFamily`, `FontSize`, and `FontAttributes` properties of the `ErrorLabelTextStyle` in the DataFormItem.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}"
                        AutoGenerateItems="False"
                        GenerateDataFormItem="OnGenerateDataFormItem">
    <dataForm:SfDataForm.Items>
        <dataForm:DataFormTextItem FieldName="Name">
            <dataForm:DataFormTextItem.ErrorLabelTextStyle>
                <dataForm:DataFormTextStyle TextColor="RosyBrown" FontAttributes="Italic"/>
            </dataForm:DataFormTextItem.ErrorLabelTextStyle>
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
        e.DataFormItem.ErrorLabelTextStyle = new DataFormTextStyle { FontAttributes = FontAttributes.Bold, TextColor = Colors.IndianRed };
    }
}

{% endhighlight %}
{% endtabs %}

![Error message label style in .NET MAUI DataForm.](images/floating-label-layout/error-message-style.png)

#### Valid message label style
Customize the text of a valid message label by setting the `TextColor`, `FontFamily`, `FontSize`, and `FontAttributes` properties of the `ValidMessageLabelTextStyle` in the DataFormItem.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}"
                        AutoGenerateItems="False"
                        GenerateDataFormItem="OnGenerateDataFormItem">
    <dataForm:SfDataForm.Items>
        <dataForm:DataFormTextItem FieldName="Name">
            <dataForm:DataFormTextItem.ValidMessageLabelTextStyle>
                <dataForm:DataFormTextStyle TextColor="ForestGreen" FontAttributes="Italic"/>
            </dataForm:DataFormTextItem.ValidMessageLabelTextStyle>
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
        e.DataFormItem.ValidMessageLabelTextStyle = new DataFormTextStyle { FontAttributes = FontAttributes.Bold, TextColor = Colors.GreenYellow };
    }
}

{% endhighlight %}
{% endtabs %}

![Valid message label style in .NET MAUI DataForm.](images/floating-label-layout/valid-message-style.png)

## Appearance customization

#### Changing outline corner radius
The corner radius of the container will be changed by setting the `OutlineCornerRadius` property of the `TextInputLayoutSettings` to double value.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}"
                        GenerateDataFormItem="OnGenerateDataFormItem">
    <dataForm:SfDataForm.TextInputLayoutSettings>
        <dataForm:TextInputLayoutSettings OutlineCornerRadius="10"/>
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
            OutlineCornerRadius = 10,
        };
    }
}

{% endhighlight %}
{% endtabs %}

![Outline corner radius in .NET MAUI DataForm.](images/floating-label-layout/outline-corner-radius.png)

#### Stroke color
The `Stroke` property of the `TextInputLayoutSettings` changes the label text and border color of the editors.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}"
                        GenerateDataFormItem="OnGenerateDataFormItem">
    <dataForm:SfDataForm.TextInputLayoutSettings>
        <dataForm:TextInputLayoutSettings Stroke="Blue"/>
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
            Stroke = Colors.Blue,
        };
    }
}

{% endhighlight %}
{% endtabs %}

![Stroke color in .NET MAUI DataForm.](images/floating-label-layout/stroke.png)

#### Focused stroke color
When the given editor view is focused, the `FocusedStroke` property value will be applied to the label text and border.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}"
                        GenerateDataFormItem="OnGenerateDataFormItem">
    <dataForm:SfDataForm.TextInputLayoutSettings>
        <dataForm:TextInputLayoutSettings FocusedStroke="Green"/>
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
            FocusedStroke = Colors.Green,
        };
    }
}

{% endhighlight %}
{% endtabs %}

![Focused stroke color in .NET MAUI DataForm.](images/floating-label-layout/focused-stroke.png)

#### Focused and unfocused stroke thickness
When the editor's view is focused and unfocused, the border's thickness can be changed using the `FocusedStrokeThickness` and `UnfocusedStrokeThickness` properties of the `TextInputLayoutSettings`.

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
<dataForm:SfDataForm x:Name="dataForm" 
                        LayoutType="TextInputLayout"
                        DataObject="{Binding ContactInfo}"
                        GenerateDataFormItem="OnGenerateDataFormItem">
    <dataForm:SfDataForm.TextInputLayoutSettings>
        <dataForm:TextInputLayoutSettings FocusedStrokeThickness="3.0"
                                    UnfocusedStrokeThickness="2.0"/>
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
            FocusedStrokeThickness = 3.0,
            UnfocusedStrokeThickness = 2.0,
        };
    }
}

{% endhighlight %}
{% endtabs %}

![Focused and unfocused stroke thickness in .NET MAUI DataForm.](images/floating-label-layout/stroke-thickness.png)

## Unsupported editors
The Floating label layout does not support non-editable editors such as `RadioGroup editor`, `CheckBox editor`, and `Switch editor`. Picker editors such as `Picker editor`, `Date picker`, and `Time picker` will be updated to support a floating label layout.

N> By default, the layout type of unsupported editors is `Default`. You can also set the layout type for the unsupported editor using this `Changing layout type of the DataFormItem`.