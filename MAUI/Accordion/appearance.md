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
{% highlight xaml %}
<syncfusion:SfAccordion x:Name="accordion" 
                        HeaderIconPosition="Start" />
{% endhighlight %}
{% highlight c# %}
accordion.HeaderIconPosition = Syncfusion.Maui.Expander.IconPosition.Start;
{% endhighlight %}
{% endtabs %}

## Header background color customization

The `SfAccordion` allows you to customize the background color of the expander header by using the `HeaderBackground` property.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfAccordion x:Name="accordion">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem HeaderBackground="Pink"/>
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# %}
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
    item.HeaderBackground = Colors.Pink;
    return item;
}
{% endhighlight %}
{% endtabs %}

## Icon color customization

The `SfAccordion` allows you to customize the color of the expander icon by using the `HeaderIconColor` property. By default, the `HeaderIconColor` is `Black`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfAccordion x:Name="accordion">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem HeaderIconColor="Brown"/>
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# %}
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
    item.HeaderIconColor = Colors.Brown;
    return item;
}
{% endhighlight %}
{% endtabs %}

## Visual State Manager

The appearance of the `SfAccordion` can be customized using the following two `VisualStates`:

* Expanded
* Collapsed

{% tabs %}
{% highlight xaml %}
     <ContentPage.Resources>
        <Style TargetType="syncfusion:AccordionItem">
            <Setter Property="VisualStateManager.VisualStateGroups">
                <VisualStateGroupList>
                    <VisualStateGroup>
                        <VisualState Name="Expanded">
                            <VisualState.Setters>
                                <Setter Property="HeaderBackground" Value="#6750A4"/>
                                <Setter Property="HeaderIconColor" Value="White"/>
                            </VisualState.Setters>
                        </VisualState>
                        <VisualState Name="Collapsed">
                            <VisualState.Setters>
                                <Setter Property="HeaderBackground" Value="#1F1C1B1F"/>
                                <Setter Property="HeaderIconColor" Value="#49454F"/>
                            </VisualState.Setters>
                        </VisualState>
                    </VisualStateGroup>
                </VisualStateGroupList>
            </Setter>
        </Style>
    </ContentPage.Resources>
    <ContentPage.Content>
        <syncfusion:SfAccordion ExpandMode="MultipleOrNone" BackgroundColor="#FAFAFA">
            <syncfusion:SfAccordion.Items>
                <syncfusion:AccordionItem x:Name="item1" 
                                          IsExpanded="True">
                    <syncfusion:AccordionItem.Header>
                        <Grid Padding="5,5,5,5">
                            <Label TextColor="{Binding HeaderIconColor, Source={x:Reference item1}}" Text="Robin Rane" VerticalTextAlignment="Center"/>
                        </Grid>
                    </syncfusion:AccordionItem.Header>
                    <syncfusion:AccordionItem.Content>
                        <Grid ColumnSpacing="10" RowSpacing="2" >
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
                </syncfusion:AccordionItem>
                ......................
            </syncfusion:SfAccordion.Items>
        </syncfusion:SfAccordion>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
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
    }
}
{% endhighlight %}
{% endtabs %}

![.NET Maui Accordion with VisualStateManager](Images/appearance/maui-accordion-with-visual-state-manager.png)