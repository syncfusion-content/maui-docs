---
layout: post
title: Appearance | Accordion for Maui | Syncfusion
description: Learn about Appearance support in Syncfusion Maui Accordion (SfAccordion) control and more details.
platform: MAUI
control: SfAccordion
documentation: ug
---

# Appearance in Maui Accordion (SfAccordion)

The Accordion allows customization of the appearance of the Icon and provides various functionalities to the users.

## Header icon position 
 
The `SfAccordion` allows you to customize the position of the header icon in each accordion item using the `HeaderIconPosition` property. By default, the header icon position is set to `End`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
<syncfusion:SfAccordion x:Name="accordion" 
                        HeaderIconPosition="Start" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
accordion.HeaderIconPosition = Syncfusion.Maui.Expander.IconPosition.Start;
{% endhighlight %}
{% endtabs %}

## Header background color customization

The `SfAccordion` allows you to customize the background color of the expander header by using the `HeaderBackground` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
<syncfusion:SfAccordion x:Name="accordion">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem HeaderBackground="Pink"/>
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="18" %}
SfAccordion accordion;
public MainPage()
{
    InitializeComponent();
    InitializeAccordionItems();
    this.Content = accordion;
}

private void InitializeAccordionItems()
{
    accordion = new SfAccordion();
    accordion.Items.Add(GenerateAccordionItem());
}

public AccordionItem GenerateAccordionItem()
{
    var item = new AccordionItem();
    item.HeaderBackground = Color.Pink;
    return item;
}
{% endhighlight %}
{% endtabs %}

## Icon color customization

The `SfAccordion` allows you to customize the color of the expander icon by using the `HeaderIconColor` property. By default, the `HeaderIconColor` is `Black`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
<syncfusion:SfAccordion x:Name="accordion">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem HeaderIconColor="Accent"/>
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="18" %}
SfAccordion accordion;
public MainPage()
{
    InitializeComponent();
    InitializeAccordionItems();
    this.Content = accordion;
}

private void InitializeAccordionItems()
{
    accordion = new SfAccordion();
    accordion.Items.Add(GenerateAccordionItem());
}

public AccordionItem GenerateAccordionItem()
{
    var item = new AccordionItem();
    item.HeaderIconColor = Color.Accent;
    return item;
}
{% endhighlight %}
{% endtabs %}

## Visual State Manager

The appearance of the `SfAccordion` can be customized using the following two `VisualStates`:

* Expanded
* Collapsed

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="59 127" %}
    <ContentPage.Resources>
        <Color x:Key="ExpandedColor">#6750A4</Color>
        <Color x:Key="CollapsedColor">Gray</Color>
    </ContentPage.Resources>
    <ContentPage.Content>
        <syncfusion:SfAccordion ExpandMode="MultipleOrNone" BackgroundColor="#FAFAFA">
            <syncfusion:SfAccordion.Items>
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Grid Padding="5,5,5,5">
                            <Label TextColor="#495F6E" Text="Robin Rane" VerticalTextAlignment="Center"/>
                        </Grid>
                    </syncfusion:AccordionItem.Header>
                    <syncfusion:AccordionItem.Content>
                        <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4"  >
                            <Grid Margin="16,6,0,0">
                                <Grid.Resources>
                                    <Style TargetType="Label">
                                        <Setter Property="FontFamily" Value="Roboto-Regular"/>
                                    </Style>
                                </Grid.Resources>
                                <Grid.RowDefinitions >
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="{OnPlatform Default=90,Android=90,WinUI=70, iOS=100,MacCatalyst=70 }"/>
                                    <RowDefinition Height="Auto"/>
                                </Grid.RowDefinitions>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="100"/>
                                    <ColumnDefinition Width="100"/>
                                    <ColumnDefinition Width="*"/>
                                </Grid.ColumnDefinitions>
                                <Frame  Grid.RowSpan="4" BorderColor="Transparent" Grid.Row="0" Grid.Column="0"  Padding="0" Margin="0,0,0,7">
                                    <Image  Source="emp_01.png"/>
                                </Frame>
                                <Label Text="Position" Grid.Column="1" Grid.Row="0" Margin="6,0,0,0"/>
                                <Label Text="Chairman" Grid.Row="0" Grid.Column="2"/>
                                <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="ABC Inc." Grid.Row="1" Grid.Column="2"/>
                                <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="09/17/1973" Grid.Row="2" Grid.Column="2"/>
                                <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="Boston" Grid.Row="3" Grid.Column="2"/>
                                <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3"  LineBreakMode="WordWrap"  
                                            FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                                                Text="Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry.">
                                </Label>
                                <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                                    <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2"
                                                   FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                    <Label Text="(617) 555-1234" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14"/>
                                </StackLayout>
                            </Grid>
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                    <VisualStateManager.VisualStateGroups>
                        <VisualStateGroupList>
                            <VisualStateGroup>
                                <VisualState Name="Expanded">
                                    <VisualState.Setters>
                                        <Setter Property="HeaderBackground" Value="{x:StaticResource ExpandedColor}"/>
                                    </VisualState.Setters>
                                </VisualState>
                                <VisualState Name="Collapsed">
                                    <VisualState.Setters>
                                        <Setter Property="HeaderBackground" Value="{x:StaticResource CollapsedColor}"/>
                                    </VisualState.Setters>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateGroupList>
                    </VisualStateManager.VisualStateGroups>
                </syncfusion:AccordionItem>
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Grid Padding="5,5,5,5">
                            <Label Margin="10,10,10,10" TextColor="#495F6E" Text="Paul Vent" VerticalTextAlignment="Center"/>
                        </Grid>
                    </syncfusion:AccordionItem.Header>
                    <syncfusion:AccordionItem.Content>
                        <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4"  >
                            <Grid Margin="16,6,0,0">
                                <Grid.Resources>
                                    <Style TargetType="Label">
                                        <Setter Property="FontFamily" Value="Roboto-Regular"/>
                                    </Style>
                                </Grid.Resources>
                                <Grid.RowDefinitions >
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="{OnPlatform Default=90,Android=90,WinUI=70, iOS=100,MacCatalyst=70 }"/>
                                    <RowDefinition Height="Auto"/>
                                </Grid.RowDefinitions>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="100"/>
                                    <ColumnDefinition Width="100"/>
                                    <ColumnDefinition Width="*"/>
                                </Grid.ColumnDefinitions>
                                <Frame  Grid.RowSpan="4" BorderColor="Transparent" Grid.Row="0" Grid.Column="0"  Padding="0" Margin="0,0,0,7">
                                    <Image  Source="emp_02.png"/>
                                </Frame>
                                <Label Text="Position" Grid.Column="1" Grid.Row="0" Margin="6,0,0,0"/>
                                <Label Text="General Manager" Grid.Row="0" Grid.Column="2"/>
                                <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="XYZ Corp." Grid.Row="1" Grid.Column="2"/>
                                <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="05/27/1985" Grid.Row="2" Grid.Column="2"/>
                                <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="New York" Grid.Row="3" Grid.Column="2"/>
                                <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3"  LineBreakMode="WordWrap"  
                                            FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                                                Text="Paul Vent, General Manager of XYZ Corp., oversees daily operations, ensuring the company's success and growth through strategic planning and effective management practices.">
                                </Label>
                                <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                                    <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2"
                                                   FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                    <Label Text="(212) 555-1234" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14"/>
                                </StackLayout>
                            </Grid>
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                    <VisualStateManager.VisualStateGroups>
                        <VisualStateGroupList>
                            <VisualStateGroup>
                                <VisualState Name="Expanded">
                                    <VisualState.Setters>
                                        <Setter Property="Header">
                                            <Setter.Value>
                                                <Grid Padding="5,5,5,5">
                                                    <Label Text="Expanded Header" TextColor="#495F6E"/>
                                                </Grid>
                                            </Setter.Value>
                                        </Setter>
                                    </VisualState.Setters>
                                </VisualState>
                                <VisualState Name="Collapsed">
                                    <VisualState.Setters>
                                        <Setter Property="Header">
                                            <Setter.Value>
                                                <Grid Padding="5,5,5,5">
                                                    <Label Text="Collpased Header" TextColor="#495F6E"/>
                                                </Grid>
                                            </Setter.Value>
                                        </Setter>
                                    </VisualState.Setters>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateGroupList>
                    </VisualStateManager.VisualStateGroups>
                </syncfusion:AccordionItem>
            </syncfusion:SfAccordion.Items>
        </syncfusion:SfAccordion>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="116 218" %}
public partial class MainPage : ContentPage
{
    SfAccordion accordion;
	public MainPage()
	{
		InitializeComponent();
        accordion = new SfAccordion();
        accordion.ExpandMode = ExpandMode.MultipleOrNone;
        GenerateAccordionItem();
        this.Content = accordion;
    }

    public void GenerateAccordionItem()
    {
        var item = new AccordionItem();
        var headerGrid = new Grid()
        {
            new Label(){ Text = "Robin Rane", Margin = new Thickness(16,14,0,14), CharacterSpacing = 0.25, FontFamily = "Roboto-Regular", FontSize = 14 }
        };
        headerGrid.HeightRequest = 48;
        item.Header = headerGrid;

        var content = new Grid();
        content.ColumnSpacing = 10;
        content.RowSpacing = 2;
        content.BackgroundColor = Color.FromArgb("#f4f4f4");
        var contentGrid = new Grid();
        contentGrid.Margin = new Thickness(16, 6, 0, 0);
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = DeviceInfo.Platform == DevicePlatform.WinUI || DeviceInfo.Platform == DevicePlatform.MacCatalyst ? 70 : DeviceInfo.Platform == DevicePlatform.Android ? 90 : DeviceInfo.Platform == DevicePlatform.iOS ? 100 : 90 });
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
        contentGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
        var image = new Image() { Source = "emp_01.png" };
        var frame = new Frame() { BorderColor = Colors.Transparent, Padding = 0, Margin = new Thickness(0, 0, 0, 7) };
        frame.Content = image;
        contentGrid.SetRowSpan(frame, 4);
        contentGrid.SetRow(frame, 0);
        contentGrid.SetColumn(frame, 0);
        contentGrid.Children.Add(frame);
        var position = new Label() { Text = "Position", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid.SetColumn(position, 1);
        contentGrid.SetRow(position, 0);
        contentGrid.Children.Add(position);
        var positionVal = new Label() { Text = "Chairman" };
        contentGrid.SetColumn(positionVal, 2);
        contentGrid.SetRow(positionVal, 0);
        contentGrid.Children.Add(positionVal);
        var organization = new Label() { Text = "Organization", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid.SetColumn(organization, 1);
        contentGrid.SetRow(organization, 1);
        contentGrid.Children.Add(organization);
        var organizationVal = new Label() { Text = "ABC Inc." };
        contentGrid.SetColumn(organizationVal, 2);
        contentGrid.SetRow(organizationVal, 1);
        contentGrid.Children.Add(organizationVal);
        var dob = new Label() { Text = "Date Of Birth", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid.SetColumn(dob, 1);
        contentGrid.SetRow(dob, 2);
        contentGrid.Children.Add(dob);
        var dobVal = new Label() { Text = "09/17/1973" };
        contentGrid.SetColumn(dobVal, 2);
        contentGrid.SetRow(dobVal, 2);
        contentGrid.Children.Add(dobVal);
        var location = new Label() { Text = "Location", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid.SetColumn(location, 1);
        contentGrid.SetRow(location, 3);
        contentGrid.Children.Add(location);
        var locationVal = new Label() { Text = "Boston" };
        contentGrid.SetColumn(locationVal, 2);
        contentGrid.SetRow(locationVal, 3);
        contentGrid.Children.Add(locationVal);
        var description = new Label() { Text = "Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry.", Padding = new Thickness(0, 10, 0, 10), LineBreakMode = LineBreakMode.WordWrap, FontSize = 14, CharacterSpacing = 0.25, VerticalTextAlignment = TextAlignment.Center };
        contentGrid.SetRow(description, 4);
        contentGrid.SetColumnSpan(description, 3);
        contentGrid.Children.Add(description);
        var stack = new StackLayout()
        {

            new Label() { Text="\ue700", FontSize=16, Margin = new Thickness(0,2,2,2), VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center,
                                                   FontFamily = DeviceInfo.Platform == DevicePlatform.WinUI ? "AccordionFontIcons.ttf#AccordionFontIcons" : DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : DeviceInfo.Platform == DevicePlatform.iOS ? "AccordionFontIcons" : "AccordionFontIcons"},
            new Label(){ Text = "(617) 555-1234", CharacterSpacing = 0.25, FontSize = 14, VerticalOptions = LayoutOptions.Center}
        };
        stack.Orientation = StackOrientation.Horizontal;
        stack.Margin = new Thickness(0, 0, 0, 12);
        contentGrid.SetRow(stack, 5);
        contentGrid.Children.Add(stack);
        content.Children.Add(contentGrid);
        item.Content = contentGrid;

        VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
        VisualStateGroup commonStateGroup = new VisualStateGroup();

        VisualState expanded = new VisualState
        {
            Name = "Expanded"
        };
        expanded.Setters.Add(new Setter { Property = AccordionItem.HeaderBackgroundProperty, Value = Colors.Red });
        expanded.Setters.Add(new Setter { Property = AccordionItem.HeaderBackgroundProperty, Value = Colors.Red });

        VisualState collapsed = new VisualState
        {
            Name = "Collapsed"
        };
        collapsed.Setters.Add(new Setter { Property = AccordionItem.HeaderBackgroundProperty, Value = Colors.Yellow });
        collapsed.Setters.Add(new Setter { Property = AccordionItem.HeaderBackgroundProperty, Value = Colors.Yellow });

        commonStateGroup.States.Add(expanded);
        commonStateGroup.States.Add(collapsed);

        visualStateGroupList.Add(commonStateGroup);
        VisualStateManager.SetVisualStateGroups(item, visualStateGroupList);
        accordion.Items.Add(item);

        var accordionItem1 = new AccordionItem();
        var headerGrid1 = new Grid()
        {
            new Label(){ Text = "Paul Vent", Margin = new Thickness(16,14,0,14), CharacterSpacing = 0.25, FontFamily = "Roboto-Regular", FontSize = 14 }
        };
        headerGrid1.HeightRequest = 48;
        accordionItem1.Header = headerGrid1;

        var content1 = new Grid();
        content1.ColumnSpacing = 10;
        content1.RowSpacing = 2;
        content1.BackgroundColor = Color.FromArgb("#f4f4f4");
        var contentGrid1 = new Grid();
        contentGrid1.Margin = new Thickness(16, 6, 0, 0);
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = DeviceInfo.Platform == DevicePlatform.WinUI || DeviceInfo.Platform == DevicePlatform.MacCatalyst ? 70 : DeviceInfo.Platform == DevicePlatform.Android ? 90 : DeviceInfo.Platform == DevicePlatform.iOS ? 100 : 90 });
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
        contentGrid1.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid1.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid1.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
        var image1 = new Image() { Source = "emp_02.png" };
        var frame1 = new Frame() { BorderColor = Colors.Transparent, Padding = 0, Margin = new Thickness(0, 0, 0, 7) };
        frame1.Content = image1;
        contentGrid1.SetRowSpan(frame1, 4);
        contentGrid1.SetRow(frame1, 0);
        contentGrid1.SetColumn(frame1, 0);
        contentGrid1.Children.Add(frame1);
        var position1 = new Label() { Text = "Position", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid1.SetColumn(position1, 1);
        contentGrid1.SetRow(position1, 0);
        contentGrid1.Children.Add(position1);
        var positionVal1 = new Label() { Text = "General Manager" };
        contentGrid1.SetColumn(positionVal1, 2);
        contentGrid1.SetRow(positionVal1, 0);
        contentGrid1.Children.Add(positionVal1);
        var organization1 = new Label() { Text = "Organization", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid1.SetColumn(organization1, 1);
        contentGrid1.SetRow(organization1, 1);
        contentGrid1.Children.Add(organization1);
        var organizationVal1 = new Label() { Text = "XYZ Corp." };
        contentGrid1.SetColumn(organizationVal1, 2);
        contentGrid1.SetRow(organizationVal1, 1);
        contentGrid1.Children.Add(organizationVal1);
        var dob1 = new Label() { Text = "Date Of Birth", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid1.SetColumn(dob1, 1);
        contentGrid1.SetRow(dob1, 2);
        contentGrid1.Children.Add(dob1);
        var dobVal1 = new Label() { Text = "05/27/1985" };
        contentGrid1.SetColumn(dobVal1, 2);
        contentGrid1.SetRow(dobVal1, 2);
        contentGrid1.Children.Add(dobVal1);
        var location1 = new Label() { Text = "Location", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid1.SetColumn(location1, 1);
        contentGrid1.SetRow(location1, 3);
        contentGrid1.Children.Add(location1);
        var locationVal1 = new Label() { Text = "New York" };
        contentGrid1.SetColumn(locationVal1, 2);
        contentGrid1.SetRow(locationVal1, 3);
        contentGrid1.Children.Add(locationVal1);
        var description1 = new Label() { Text = "Paul Vent, General Manager of XYZ Corp., oversees daily operations, ensuring the company's success and growth through strategic planning and effective management practices.", Padding = new Thickness(0, 10, 0, 10), LineBreakMode = LineBreakMode.WordWrap, FontSize = 14, CharacterSpacing = 0.25, VerticalTextAlignment = TextAlignment.Center };
        contentGrid1.SetRow(description1, 4);
        contentGrid1.SetColumnSpan(description1, 3);
        contentGrid1.Children.Add(description1);
        var stack1 = new StackLayout()
        {

            new Label() { Text="\ue700", FontSize=16, Margin = new Thickness(0,2,2,2), VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center,
                                                   FontFamily = DeviceInfo.Platform == DevicePlatform.WinUI ? "AccordionFontIcons.ttf#AccordionFontIcons" : DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : DeviceInfo.Platform == DevicePlatform.iOS ? "AccordionFontIcons" : "AccordionFontIcons"},
            new Label(){ Text = "(212) 555-1234", CharacterSpacing = 0.25, FontSize = 14, VerticalOptions = LayoutOptions.Center}
        };
        stack1.Orientation = StackOrientation.Horizontal;
        stack1.Margin = new Thickness(0, 0, 0, 12);
        contentGrid1.SetRow(stack1, 5);
        contentGrid1.Children.Add(stack1);
        content1.Children.Add(contentGrid1);
        accordionItem1.Content = contentGrid1;

        VisualStateGroupList visualStateGroupList1 = new VisualStateGroupList();
        VisualStateGroup commonStateGroup1 = new VisualStateGroup();

        VisualState expanded1 = new VisualState
        {
            Name = "Expanded"
        };
        expanded1.Setters.Add(new Setter { Property = AccordionItem.HeaderProperty, Value = new Grid() { new Label() { Text = "Expanded Header", TextColor = Color.FromArgb("#495F6E") } } });
        expanded1.Setters.Add(new Setter { Property = AccordionItem.HeaderProperty, Value = new Grid() { new Label() { Text = "Expanded Header", TextColor = Color.FromArgb("#495F6E") } } });

        VisualState collapsed1 = new VisualState
        {
            Name = "Collapsed"
        };
        collapsed1.Setters.Add(new Setter { Property = AccordionItem.HeaderProperty, Value = new Grid() { new Label() { Text = "Collapsed Header", TextColor = Color.FromArgb("#495F6E") } } });
        collapsed1.Setters.Add(new Setter { Property = AccordionItem.HeaderProperty, Value = new Grid() { new Label() { Text = "Collapsed Header", TextColor = Color.FromArgb("#495F6E") } } });

        commonStateGroup1.States.Add(expanded1);
        commonStateGroup1.States.Add(collapsed1);

        visualStateGroupList1.Add(commonStateGroup1);
        VisualStateManager.SetVisualStateGroups(accordionItem1, visualStateGroupList1);
        accordion.Items.Add(accordionItem1);
    }
}
{% endhighlight %}
{% endtabs %}

![Maui Accordion with VisualStateManager](Images/appearance/maui-accordion-with-collapsed.png)![Maui Accordion with VisualStateManager](Images/appearance/maui-accordion-with-Expanded.png)