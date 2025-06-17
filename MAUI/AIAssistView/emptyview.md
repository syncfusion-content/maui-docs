---
layout: post
title: EmptyView in .NET MAUI AI AssistView control | Syncfusion
description: Learn here all about EmptyView support in Syncfusion .NET MAUI AI AssistView control and more.
control: AI AssistView
documentation: ug
---

# Empty view in .NET MAUI AI AssistView

The `AI AssistView` control provides the functionality to display custom empty view content when no data is available. This feature is implemented using the following properties:

* `EmptyView`: This property can be set to a simple string or a custom view and will be used when the `AI AssistView` has no items. The default value is `null`.
* `EmptyViewTemplate`: This allows for customization of the appearance of the `EmptyView`. The default value is `null`.

## Display views when AI AssistView has no items

The `EmptyView` property can also be set to a string or a view , which will be displayed when the `AssistItems` property is null or the collection specified by the `AssistItems` property is empty.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView">

   <syncfusion:SfAIAssistView x:Name="sfAIAssistView" 
                              ShowHeader="False" 
                              AssistItems="{Binding AssistItems}"
                              EmptyView="Ask AI Anything">
    </syncfusion:SfAIAssistView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;

    public MainPage()
    { 
        InitializeComponent();
        sfAIAssistView = new SfAIAssistView();
        GettingStartedViewModel viewModel = new GettingStartedViewModel();  
        sfAIAssistView.AssistItems = viewModel.AssistItems;
        sfAIAssistView.EmptyView = "Ask AI Anything";
        Content = sfAIAssistView;
   }
}

{% endhighlight %}
{% endtabs %}

## EmptyView Customization

The `EmptyView` can be customized by using the `EmptyViewTemplate` property. This property allows you to define a custom layout and style for the `EmptyView`.


{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView">

 <syncfusion:SfAIAssistView x:Name="sfAIAssistView" 
                         ShowHeader="False" 
                         AssistItems="{Binding AssistItems}"
                         EmptyView="No Items">
     <syncfusion:SfAIAssistView.EmptyViewTemplate>
         <DataTemplate>
             <Grid RowDefinitions="45,30" 
                   RowSpacing="10"
                   HorizontalOptions="Center"
                   VerticalOptions="Center">
                <Border Background="#6C4EC2" 
                         Stroke="#CAC4D0"  
                         HorizontalOptions="Center" >
                    <Border.StrokeShape>
                         <RoundRectangle CornerRadius="12"/>
                    </Border.StrokeShape>
                       <Label Text="&#xe7e1;"
                              FontSize="24"
                              HorizontalTextAlignment="Center" VerticalTextAlignment="Center" FontFamily="MauiSampleFontIcon" 
                              TextColor="White"
                              HeightRequest="45" WidthRequest="45" HorizontalOptions="Center" />
                 </Border>
                 <Label Text="Hi, How can I help you!" 
                        HorizontalOptions="Center" Grid.Row="1" FontFamily="Roboto-Regular" 
                        FontSize="20"/>
             </Grid>
         </DataTemplate>
     </syncfusion:SfAIAssistView.EmptyViewTemplate>
 </syncfusion:SfAIAssistView>

</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

  public partial class MainPage : ContentPage
  {
        SfAIAssistView sfAIAssistView;

        public MainPage()
        {
            InitializeComponent();

            sfAIAssistView = new SfAIAssistView
            {
                ShowHeader = false,
                EmptyView = "No Items"
            };

            GettingStartedViewMode viewModel = new GettingStartedViewMode();  
            sfAIAssistView.AssistItems = viewModel.AssistItems;

            sfAIAssistView.EmptyViewTemplate = new DataTemplate(() =>
            {
                var grid = new Grid
                {
                    RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(45) },
                        new RowDefinition { Height = new GridLength(30) }
                    },
                    RowSpacing = 10,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center
                };

                var border = new Border
                {
                    Background = Color.FromArgb("#6C4EC2"),
                    Stroke = Color.FromArgb("#CAC4D0"),
                    HorizontalOptions = LayoutOptions.Center,
                    StrokeShape = new RoundRectangle { CornerRadius = 12 }
                };

                var iconLabel = new Label
                {
                    Text = "\ue7e1", 
                    FontSize = 24,
                    FontFamily = "MauiSampleFontIcon",  
                    TextColor = Colors.White,
                    WidthRequest = 45,
                    HeightRequest = 45,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalOptions = LayoutOptions.Center
                };

                border.Content = iconLabel;

                var messageLabel = new Label
                {
                    Text = "Hi, How can I help you!",
                    FontSize = 20,
                    FontFamily = "Roboto-Regular", 
                    HorizontalOptions = LayoutOptions.Center
                };

                Grid.SetRow(messageLabel, 1);
                grid.Children.Add(border);
                grid.Children.Add(messageLabel);

                return grid;
            });

            Content = sfAIAssistView;
        }
    }

{% endhighlight %}
{% endtabs %}


![EmptyView customization in .NET MAUI AI AssistView](Images/maui-aiassistview-emptyview-customization.png)

N> EmptyView can be set to custom type and the appearance of the EmptyView can be customized by using the EmptyViewTemplate.