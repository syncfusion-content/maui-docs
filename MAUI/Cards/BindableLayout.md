---
layout: post
title: BindableLayout in MAUI Cards control | Syncfusion<sup>&reg;</sup>
description: Learn about BindableLayout support in Syncfusion<sup>&reg;</sup> Essential Studio<sup>&reg;</sup> MAUI Cards control, its elements and more.
platform: MAUI
control: Cards
documentation: ug
---

# BindableLayout in MAUI Cards

Layout&lt;T&gt; introduces a feature called `BindableLayout`, which works with all layouts derived from Layout&lt;T&gt;. By simply setting the ItemTemplate and ItemsSource, BindableLayout automatically generates a group of UI elements (based on the provided ItemTemplate) for each data item in the ItemsSource and adds them as children.

Since [`SfCardLayout`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html) is an extended class of Layout&lt;T&gt;, this approach is also possible for `SfCardLayout`.

## Initialize view model

Define a simple data model that represents data to be populated for [`SfCardLayout`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html).

{% highlight c# %}

public class Model
{
   public IEnumerable<string> Colors { get; set; }
}

{% endhighlight %} 

Next, create a view model class and initialize a model object as demonstrated in the following code sample.

{% highlight c# %}

public class ViewModel 
{
        public Model Model { get; set; }

        public ViewModel()
        {
            Model = new Model
            {
                Colors = new string[]
                {
                    "Cyan", "Yellow", "Orange"
                }
            };
        }
 }

{% endhighlight %} 

Set the ViewModel instance as BindingContext of your page to bind properties of ViewModel to [`SfCardLayout`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html). 

N> Add the namespace of the ViewModel class in your XAML page if you prefer to set the BindingContext in XAML. 

{% tabs %} 

{% highlight xaml %}

<ContentPage.BindingContext>

<local:ViewModel/>

</ContentPage.BindingContext>

{% endhighlight %}

{% highlight c# %}

this.BindingContext = new ViewModel();      

{% endhighlight %}

{% endtabs %}

## Populate CardLayout with data

[`SfCardLayout`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html) can be populated with data by setting the ItemsSource property of BindableLayout to a collection of items that can be used in [`SfCardView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardView.html).

{% tabs %} 

{% highlight xaml %}

<cards:SfCardLayout BindableLayout.ItemsSource="{Binding Model.Colors}">
…
</cards:SfCardLayout>

{% endhighlight %}

{% highlight c# %}

SfCardLayout cardLayout = new SfCardLayout();
BindableLayout.SetItemsSource(cardLayout, viewModel.Model.Colors);

{% endhighlight %}

{% endtabs %}

## Define the appearance of SfCardView

[`SfCardLayout`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html) accepts only [`SfCardView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardView.html) as its child. The appearance of each [`SfCardView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardView.html) can be defined by setting the `BindableLayout.ItemTemplate` property.

{% tabs %} 

{% highlight xaml %}

<cards:SfCardLayout BindableLayout.ItemsSource="{Binding Model.Colors}"  SwipeDirection="Left" VerticalOptions="Center"  HeightRequest="300" WidthRequest="300" BackgroundColor="#F0F0F0">
        <BindableLayout.ItemTemplate>
            <DataTemplate>
                <cards:SfCardView BackgroundColor="{Binding}">
                    <Label Text="{Binding}" HorizontalOptions="CenterAndExpand" VerticalTextAlignment="Center"/>
                </cards:SfCardView>
            </DataTemplate>
        </BindableLayout.ItemTemplate>
</cards:SfCardLayout>

{% endhighlight %}

{% highlight c# %}

SfCardLayout cardLayout = new SfCardLayout()
{
    SwipeDirection = CardSwipeDirection.Left,
    BackgroundColor = Color.FromHex("#F0F0F0"),
    VerticalOptions = LayoutOptions.Center,
    HeightRequest = 300,
    WidthRequest = 300,
};

this.BindingContext = viewModel;

DataTemplate dataTemplate = new DataTemplate(() =>
{
    SfCardView cardView = new SfCardView();
    cardView.SetBinding(SfCardView.BackgroundColorProperty, new Binding() { Path = "."});

    Label label = new Label()
    {
        HorizontalOptions = LayoutOptions.CenterAndExpand,
        VerticalTextAlignment = TextAlignment.Center
    };

    label.SetBinding(Label.TextProperty, new Binding() { Path= "."});
    cardView.Content = label;
    return cardView;
});

BindableLayout.SetItemTemplate(cardLayout, dataTemplate);
BindableLayout.SetItemsSource(cardLayout, viewModel.Model.Colors);

this.Content = cardLayout;

{% endhighlight %}

{% endtabs %}