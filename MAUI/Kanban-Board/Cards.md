---
layout: post
title: Cards in .NET MAUI Kanban Board control | Syncfusion
description: Learn here all about Cards support in Syncfusion .NET MAUI Kanban Board (SfKanban) control, its elements and more.
platform: maui
control: Kanban
documentation: ug
---

# Cards in .NET MAUI Kanban Board (SfKanban)

The default elements of a card can be customized using the below properties of [`KanbanModel`]().

* [`Title`]() - Used to set the title of a card.
* [`ImageURL`]() - Used to set the image URL of a card. The image will be displayed at right side in default card template.
* [`Category`]() - Used to set the category of a card. Based on the category the cards will be added to the respective columns. 
* [`Description`]() - Used to set the description text of a card.
* [`IndicatorFill`]() - Used to specify the indicator color.
* [`Tags`]() - Used to specify the tags of a card. The tags will be displayed at bottom in default card template.
* [`ID`]() - Used to set the ID of a card.

{% highlight C# %}

    new KanbanModel()
    {
        ID = 1,
        Title = "iOS - 1002",
        ImageURL = "Image1.png",
        Category = "Open",
        Description = "Analyze customer requirements",
        IndicatorFill = Colors.Red;
        Tags = new string[] { "Incident", "Customer" }
    });

{% endhighlight %}

## Template

You can replace the entire card template with your own design using [`CardTemplate`]() property of [`SfKanban`](). The following code snippet and screenshot illustrates this.

{% tabs %}

{% highlight xaml %}

    <kanban:SfKanban.CardTemplate >

    <DataTemplate>
        <StackLayout WidthRequest="250" Orientation="Vertical" BackgroundColor="Gray" Padding="10,10,10,10"> 
            
            <StackLayout  Orientation="Horizontal"> 

                <Label Text="{Binding Path=Title}" TextColor="Silver" HorizontalOptions="StartAndExpand" >
                </Label>

            </StackLayout>      

            <StackLayout  Orientation="Horizontal"> 

                <Label Text="{Binding Description}" WidthRequest="150" FontSize="14" TextColor="Silver" LineBreakMode="WordWrap" ></Label>                    
                <Image Source="{Binding ImageURL}" HeightRequest="50" WidthRequest="50"  ></Image>

            </StackLayout>
            
        </StackLayout>
    </DataTemplate>

    </kanban:SfKanban.CardTemplate>

{% endhighlight %}

{% highlight C# %}

    var cardTemplate = new DataTemplate(() =>
    {

        StackLayout root = new StackLayout()
        {
            WidthRequest = 250,
            Orientation = StackOrientation.Vertical,
            Padding = new Thickness(10),
            BackgroundColor = Color.Gray
        };

        StackLayout titleLayout = new StackLayout();
        Label title = new Label()
        {
            TextColor = Color.Silver,
            HorizontalOptions = LayoutOptions.StartAndExpand
        };
        title.SetBinding(Label.TextProperty, new Binding("Title"));
        titleLayout.Children.Add(title);

        StackLayout contentLayout = new StackLayout()
        {
            Orientation = StackOrientation.Horizontal
        };
        Label desc = new Label()
        {
            WidthRequest = 150,
            FontSize = 14,
            TextColor = Color.Silver,
            LineBreakMode = LineBreakMode.WordWrap
        };
        desc.SetBinding(Label.TextProperty, new Binding("Description"));
        Image image = new Image()
        {
            HeightRequest = 50,
            WidthRequest = 50
        };
        image.SetBinding(Image.SourceProperty, new Binding("ImageURL"));
        contentLayout.Children.Add(desc);
        contentLayout.Children.Add(image);

        root.Children.Add(titleLayout);
        root.Children.Add(contentLayout);

        return root;

    });

    kanban.CardTemplate = cardTemplate;

{% endhighlight %}

{% endtabs %}

## Data template selector

You can customize the appearance of each card with different templates based on specific constraints using [`DataTemplateSelector`]().

### Create a data template selector

Create a custom class by inheriting [`DataTemplateSelector`](), and override the [`OnSelectTemplate`]() method to return the [`DataTemplate`]() for that item. At runtime, the SfKanban invokes the [`OnSelectTemplate`]() method for each item and passes the data object as parameter.

{% tabs %}

{% highlight c# %}

    public class KanbanTemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate menuTemplate;
        private readonly DataTemplate orderTemplate;
        private readonly DataTemplate readyToServeTemplate;
        private readonly DataTemplate deliveryTemplate;

        public KanbanTemplateSelector()
        {
            menuTemplate = new DataTemplate(typeof(MenuTemplate));
            orderTemplate = new DataTemplate(typeof(OrderTemplate));
            readyToServeTemplate = new DataTemplate(typeof(ReadyToServeTemplate));
            deliveryTemplate = new DataTemplate(typeof(DeliveryTemplate));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var data = item as CustomKanbanModel;
            if (data == null)
                return null;

            string category = data.Category?.ToString();

            return category.Equals("Menu") ? menuTemplate : 
            category.Equals("Dining") || category.Equals("Delivery") ? orderTemplate : 
            category.Equals("Ready to Serve") ? readyToServeTemplate : deliveryTemplate;
        }
    }

{% endhighlight %}

{% endtabs %}

### Applying the data template selector

Assign custom [`DataTemplateSelector`]() to the [`CardTemplate`]() of the SfKanban in either XAML or C#.

{% tabs %}

{% highlight xaml %}

    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                x:Class="SimpleSample.MainPage"
                xmlns:kanban="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban"
                xmlns:local="clr-namespace:SimpleSample;assembly=SimpleSample">
                
        <ContentPage.Resources>
            <ResourceDictionary>
            <local:KanbanTemplateSelector x:Key="kanbanTemplateSelector" />
            </ResourceDictionary>
        </ContentPage.Resources>
    
        <ContentPage.BindingContext>
            <local:KanbanCustomViewModel />
        </ContentPage.BindingContext>
                
        <kanban:SfKanban x:Name="kanban" HorizontalOptions="FillAndExpand"
                        VerticalOptions="FillAndExpand" ItemsSource="{Binding Cards}"
                        CardTemplate="{StaticResource kanbanTemplateSelector}" >
                    
        ...
                    
        </kanban:SfKanban>

    </ContentPage>

{% endhighlight %}

{% highlight c# %}

    SfKanban kanban = new SfKanban();
    kanban.ItemsSource = viewModel.Cards;
    kanban.CardTemplate = new KanbanTemplateSelector();
      
{% endhighlight %}

{% endtabs %}