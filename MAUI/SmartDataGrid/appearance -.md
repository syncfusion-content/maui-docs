---
layout: post
title: Appearance in MAUI SmartDataGrid control | Syncfusion®
description: Learn here all about how to customize the appearance of Syncfusion® .NET MAUI SmartDataGrid (SfSmartDataGrid) control and more.
platform: MAUI
control: SfSmartDataGrid
documentation: UG
keywords : maui datagrid, appearance, styling, assistview, toolbar, templates
---

# Appearance in MAUI SmartDataGrid (SfSmartDataGrid)

The `SfSmartDataGrid` provides options to customize the appearance of its toolbar, AssistView button, and AssistView popup. You can style elements such as background, stroke, and thickness, or replace default visuals with templates for complete control over the layout and design.

## Toolbar

### Styling

The toolbar’s visual style is driven by the following `SmartAssistStyle` properties:

- `ToolbarBackground`: Background color for the toolbar.
- `ToolbarStroke`: Border color of the toolbar.
- `ToolbarStrokeThickness`: Border thickness of the toolbar.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
  <smart:SfSmartDataGrid.AssistViewSettings>
    <smart:DataGridAssistViewSettings>
      <smart:DataGridAssistViewSettings.AssistStyle>
        <smart:SmartAssistStyle
          ToolbarBackground="#F7F2FB"
          ToolbarStroke="#CAC4D0"
          ToolbarStrokeThickness="1" />
      </smart:SmartAssistStyle>
    </smart:DataGridAssistViewSettings.AssistStyle>
    </smart:DataGridAssistViewSettings>
  </smart:SfSmartDataGrid.AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
var style = SmartGrid.AssistViewSettings.AssistStyle;
style.ToolbarBackground = Color.FromArgb("#F7F2FB");
style.ToolbarStroke = Colors.Red;
style.ToolbarStrokeThickness = 2f;
{% endhighlight %}
{% endtabs %}

<img alt="maui-smart-datagrid-toolbar-style" src="Images\Appearance\maui-smart-datagrid-toolbar-style.png" width="600"/>

### Toolbar Template

The `SfSmartDataGrid` control allows you to fully customize the toolbar appearance by using the `ToolbarTemplate` property. This property lets you define a custom layout and style for the toolbar.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <smart:SfSmartDataGrid.ToolbarTemplate>
      <DataTemplate>
          <Grid BackgroundColor="LightGray" Padding="8,8" ColumnDefinitions="*,Auto">
              <Label Text="My Custom Toolbar" 
                     VerticalTextAlignment="Center"
                     FontAttributes="Bold" >
              </Label>
              <Button Text="Ask AI" 
                      Grid.Column="1" 
                      Clicked="OnAskAIClicked" >
              </Button>
          </Grid>
      </DataTemplate>
    </smart:SfSmartDataGrid.ToolbarTemplate>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
SmartGrid.ToolbarTemplate = new DataTemplate(() =>
{
    var grid = new Grid
    {
        BackgroundColor = Colors.LightGray,
        Padding = new Thickness(8, 8),
        ColumnDefinitions =
        {
            new ColumnDefinition { Width = GridLength.Star },
            new ColumnDefinition { Width = GridLength.Auto }
        }
    };

    var label = new Label
    {
        Text = "My Custom Toolbar",
        VerticalTextAlignment = TextAlignment.Center,
        FontAttributes = FontAttributes.Bold
    };

    var button = new Button
    {
        Text = "Ask AI"
    };

    Grid.SetColumn(button, 1);

    button.Clicked += OnAskAIClicked;

    grid.Add(label, 0, 0);
    grid.Add(button, 1, 0);

    return grid;
});
{% endhighlight %}
{% endtabs %}


## AssistView Button

### Styling

The AssistView button’s visual style is driven by the following `SmartAssistStyle` properties:

- `AssistButtonBackground`: Background color for the AssistView button.
- `AssistButtonIconColor`: Color applied to the AssistView button icon.
- `AssistButtonCornerRadius`: Corner radius for the button shape.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
  <smart:SfSmartDataGrid.AssistViewSettings>
    <smart:DataGridAssistViewSettings>
      <smart:DataGridAssistViewSettings.AssistStyle>
        <smart:SmartAssistStyle
          AssistButtonBackground="#6750A4"
          AssistButtonIconColor="#FFFFFF"
          AssistButtonCornerRadius="10" />
      </smart:SmartAssistStyle>
    </smart:DataGridAssistViewSettings.AssistStyle>
    </smart:DataGridAssistViewSettings>
  </smart:SfSmartDataGrid.AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
var style = SmartGrid.AssistViewSettings.AssistStyle;
style.AssistButtonBackground   = Color.FromArgb("#6750A4");
style.AssistButtonIconColor    = Colors.Red
style.AssistButtonCornerRadius = 10;
{% endhighlight %}
{% endtabs %}

<img alt="maui-smart-datagrid-assist-button-style" src="Images\Appearance\maui-smart-datagrid-assist-button-style.png" width="600"/>

N> To customize the AssistView control's chat appearance and styles, refer to Syncfusion's official help documentation for **[.NET MAUI AIAssistView](https://help.syncfusion.com/maui/aiassistview/styles)**.

### AssistViewButton Icon Visibility

The `SfSmartDataGrid.ShowAssistButtonIcon` property determines whether the AssistView button icon is displayed. By default, ShowAssistButtonIcon is set to `true`. To hide the icon, set this property to false.

{% tabs %}
{% highlight xaml %}
    <smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}"
                        ShowAssistButtonIcon="False">
    </smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
// Hide the AssistView icon
SmartGrid.ShowAssistButtonIcon = false;
{% endhighlight %}
{% endtabs %}

### AssistView Button Template

The `SfSmartDataGrid` control allows you to fully customize the AssistView button’s appearance by using the `AssistButtonTemplate` property. This property lets you define a custom layout and style for the button.

{% tabs %}
{% highlight xaml %}  
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <smart:SfSmartDataGrid.AssistButtonTemplate>
        <DataTemplate>
            <Button Text="Ask" BackgroundColor="#6750A4" TextColor="White" CornerRadius="20" >
            </Button>
        </DataTemplate>
    </smart:SfSmartDataGrid.AssistButtonTemplate>
</smart:SfSmartDataGrid>

{% endhighlight %}

{% highlight c# %}
SmartGrid.AssistButtonTemplate = new DataTemplate(() =>
{
    return new Button
    {
        Text = "Ask",
        BackgroundColor = Color.FromArgb("#6750A4"),
        TextColor = Colors.White,
        CornerRadius = 20
    };
});
{% endhighlight %}
{% endtabs %}

### AssistView Icon Template

The `SfSmartDataGrid` control allows you to fully customize the AssistView button’s icon by using the `AssistButtonIconTemplate` property. This property lets you define a custom layout for the icon.

{% tabs %}
{% highlight xaml %}  
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <smart:SfSmartDataGrid.AssistButtonIconTemplate>
        <DataTemplate>
            <Image Source="assistant_icon.png"
                   HeightRequest="20"
                   WidthRequest="20"/>
        </DataTemplate>
    </smart:SfSmartDataGrid.AssistButtonIconTemplate>
</smart:SfSmartDataGrid>

{% endhighlight %}

{% highlight c# %}
SmartGrid.AssistButtonIconTemplate = new DataTemplate(() =>
{
    return new Image
    {
        Source = "assistant_icon.png",
        HeightRequest = 20,
        WidthRequest = 20
    };
});
{% endhighlight %}
{% endtabs %}

## AssistView

### Styling

Use `SmartAssistStyle` to style the AssistView popup, header, and default highlight color.

- `AssistPopupStroke`: Border color of the AssistView popup.
- `AssistPopupStrokeThickness`: Border thickness of the AssistView popup.
- `AssistViewHeaderTextColor`:Text color of the header.
- `AssistViewHeaderFontFamily`: Font family used for the header text.
- `AssistViewHeaderFontAttributes`: Font attributes (e.g., Bold, Italic).
- `AssistViewHeaderFontSize`: Font size for header text.
- `AssistViewHeaderBackground`: Background color of the header.
- `HighlightColor`: Fallback color used by row/cell highlight actions when the prompt doesn’t specify a color.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
  <smart:SfSmartDataGrid.AssistViewSettings>
    <smart:DataGridAssistViewSettings>
      <sf:DataGridAssistViewSettings.AssistStyle>
        <sf:SmartAssistStyle 
            AssistPopupStroke="#CAC4D0"
            AssistPopupStrokeThickness="1"
            AssistViewHeaderTextColor="#6750A4"
            AssistViewHeaderFontFamily="TimesNewRoman"
            AssistViewHeaderFontAttributes="Bold"
            AssistViewHeaderFontSize="16"
            AssistViewHeaderBackground="#FFFBFE" 
            HighlightColor="Red" />
      </sf:DataGridAssistViewSettings.AssistStyle>
    </smart:DataGridAssistViewSettings>
  </smart:SfSmartDataGrid.AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
var style = SmartGrid.AssistViewSettings.AssistStyle;
style.AssistPopupStroke          = Color.FromArgb("#CAC4D0");
style.AssistPopupStrokeThickness = 2;
style.AssistViewHeaderTextColor  = Color.FromArgb("#6750A4");
style.AssistViewHeaderFontFamily = "TimesNewRoman";
style.AssistViewHeaderFontAttributes = FontAttributes.Bold;
style.AssistViewHeaderFontSize   = 16d;
style.AssistViewHeaderBackground = Color.FromArgb("#FFFBFE");
style.HighlightColor = Colors.Red;
{% endhighlight %}
{% endtabs %}

<img alt="maui-smart-datagrid-assist-view-style" src="Images\Appearance\maui-smart-datagrid-assist-view-style.png" width="600"/>

### AssistView Header Text

The `AssistViewHeaderText` property in `DataGridAssistViewSettings` is used to change the default text displayed in the AssistView header. By default, the header text is "AI Assistant".

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <smart:SfSmartDataGrid.AssistViewSettings>
        <smart:DataGridAssistViewSettings AssistViewHeaderText="Smart Assistant" />
    </smart:SfSmartDataGrid.AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
SmartGrid.AssistViewSettings.AssistViewHeaderText = "Smart Assistant";
{% endhighlight %}
{% endtabs %}

### Show AssistView Close Button

The `ShowAssistViewCloseButton` property in `DataGridAssistViewSettings` determines whether the close button in the AssistView header is displayed. By default, this property is set to `true`. To hide the close button, set this property to false.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <smart:SfSmartDataGrid.AssistViewSettings>
        <smart:DataGridAssistViewSettings ShowAssistViewCloseButton="False" />
    </smart:SfSmartDataGrid.AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
SmartGrid.AssistViewSettings.ShowAssistViewCloseButton = false;
{% endhighlight %}
{% endtabs %}

### Show AssistView Banner

The `ShowAssistViewBanner` property in `DataGridAssistViewSettings` determines whether the banner area of the AssistView is displayed. By default, this property is set to `true`. To hide the banner, set this property to false.

N> To display the content defined in `AssistViewBannerTemplate` and the `suggestions` in the AssistView, you must set `ShowAssistViewBanner` to true.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <smart:SfSmartDataGrid.AssistViewSettings>
        <smart:DataGridAssistViewSettings ShowAssistViewBanner="True" />
    </smart:SfSmartDataGrid.AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}
{% highlight c# %}
SmartGrid.AssistViewSettings.ShowAssistViewBanner = true;
{% endhighlight %}
{% endtabs %}

### AssistView Header Template

The `SfSmartDataGrid` control allows you to fully customize the AssistView header’s appearance by using the `AssistViewHeaderTemplate` property in `DataGridAssistViewSettings`. This property lets you define a custom layout and style for the header.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
        <smart:AssistViewSettings>
            <smart:DataGridAssistViewSettings.AssistViewHeaderTemplate>
                <DataTemplate>
                    <Grid Padding="10" BackgroundColor="#F5F5F5">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="*" />
                            <ColumnDefinition Width="Auto" />
                        </Grid.ColumnDefinitions>
                        <Label Text="My AI Assistant"
                               FontAttributes="Bold"
                               FontSize="18"
                               VerticalOptions="Center"
                               HorizontalOptions="Start" >
                        </Label>
                        <Button Grid.Column="1"
                                Text="✕"
                                TranslationY="-4"
                                TextColor="Red"
                                FontSize="16"
                                HeightRequest="18"
                                WidthRequest="18"
                                BackgroundColor="Transparent"
                                Clicked="OnAssistViewCloseClicked" >
                        </Button>
                    </Grid>
                </DataTemplate>
            </smart:DataGridAssistViewSettings.AssistViewHeaderTemplate>
        </smart:AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}
{% highlight c# %}
SmartGrid.AssistViewSettings.AssistViewHeaderTemplate = new DataTemplate(() =>
{
    var grid = new Grid
    {
        Padding = new Thickness(10),
        BackgroundColor = Color.FromArgb("#F5F5F5"),
        ColumnDefinitions =
        {
            new ColumnDefinition { Width = GridLength.Star },
            new ColumnDefinition { Width = GridLength.Auto }
        }
    };

    var titleLabel = new Label
    {
        Text = "My AI Assistant",
        FontAttributes = FontAttributes.Bold,
        FontSize = 18,
        VerticalOptions = LayoutOptions.Center,
        HorizontalOptions = LayoutOptions.Start
    };

    var closeButton = new Button
    {
        Text = "✕",
        TranslationY = -4,
        TextColor = Colors.Red,
        FontSize = 16,
        HeightRequest = 18,
        WidthRequest = 18,
        BackgroundColor = Colors.Transparent
    };

    closeButton.Clicked += (s, args) =>
    {
        SmartGrid.CloseAssistView();
    };
    grid.Add(titleLabel, 0, 0);
    grid.Add(closeButton, 1, 0);

    return grid;
});
{% endhighlight %}
{% endtabs %}

### AssistView Banner Template

The `SfSmartDataGrid` control allows you to fully customize the AssistView banner area by using the `AssistViewBannerTemplate` property in `DataGridAssistViewSettings`. This property lets you define a custom layout and style for the banner.

N> To display the content defined in `AssistViewBannerTemplate`, you must set `ShowAssistViewBanner` to true.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
        <smart:AssistViewSettings>
            <smart:DataGridAssistViewSettings.AssistViewBannerTemplate>
                <DataTemplate>
                    <Label Text="I'm Sync AI for you"
                        FontAttributes="Bold"
                        HorizontalOptions="Center"
                        VerticalOptions="Center"
                        HorizontalTextAlignment="Center"
                        VerticalTextAlignment="Center" >
                    </Label>
                </DataTemplate>
            </smart:DataGridAssistViewSettings.AssistViewBannerTemplate>
        </smart:AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
SmartGrid.AssistViewSettings.AssistViewBannerTemplate = new DataTemplate(() =>
{
    return new Label
    {
        Text = "I'm Sync AI for you",
        FontAttributes = FontAttributes.Bold,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    };
});
{% endhighlight %}
{% endtabs %}

### AssistView Editor Template

The `SfSmartDataGrid` control allows you to fully customize the AssistView Editor area by using the `AssistViewEditorTemplate` property in `DataGridAssistViewSettings`. This property lets you define a custom layout and style for the editor.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
        <smart:AssistViewSettings>
            <smart:DataGridAssistViewSettings.AssistViewEditorTemplate>
                <DataTemplate>
                    <Grid Padding="8" ColumnDefinitions="*,Auto">
                        <Entry x:Name="entry"
                                Placeholder="Ask the grid..."
                                Completed="Entry_Completed" >
                        </Entry>
                        <Button Text="Send"
                                Grid.Column="1"
                                Clicked="Button_Clicked" >
                        </Button>
                    </Grid>
                </DataTemplate>
            </smart:DataGridAssistViewSettings.AssistViewEditorTemplate>
        </smart:AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
SmartGrid.AssistViewSettings.AssistViewEditorTemplate = new DataTemplate(() =>
{
    var grid = new Grid
    {
        Padding = new Thickness(8),
        ColumnDefinitions =
        {
            new ColumnDefinition { Width = GridLength.Star },
            new ColumnDefinition { Width = GridLength.Auto }
        }
    };

    var entry = new Entry
    {
        Placeholder = "Ask the grid..."
    };

    entry.Completed += Entry_Completed;

    var sendButton = new Button
    {
        Text = "Send"
    };

    Grid.SetColumn(sendButton, 1);

    sendButton.Clicked += Button_Clicked;

    grid.Add(entry, 0, 0);
    grid.Add(sendButton, 1, 0);

    return grid;
});
{% endhighlight %}
{% endtabs %}
