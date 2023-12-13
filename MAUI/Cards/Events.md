---
layout: post
title: Events in MAUI Cards control | Syncfusion
description: Learn about Events support in Syncfusion Essential Studio MAUI Cards control, its elements, and more.
platform: MAUI
control: Cards
documentation: ug
---

# Events in MAUI Cards

## Tapped

The [`Tapped`]() event is triggered when any card view is tapped. The associated argument contains the following information.

* [`CardView`]() - Gets the details of a particular card view.

## VisibleIndexChanging

The [`VisibleIndexChanging`]()  event is triggered when the visible card index is changing. The associated argument contains the following information.

* [`OldIndex]() - Gets the details of the previous index card.

* [`NewIndex`]() - Gets the details of the next possible index card.

* [`Cancel`]() - Gets or sets a value indicating whether the event should be canceled.

{% tabs %}
{% highlight xaml %}

<cards:SfCardLayout VisibleIndexChanging="VisibleIndexChanging" >
		<cards:SfCardView>
			<Label Text="Cyan" BackgroundColor="Cyan" />
		</cards:SfCardView>

		<cards:SfCardView>
			<Label Text="Yellow" BackgroundColor="Yellow" />
		</cards:SfCardView>

		<cards:SfCardView>
			<Label Text="Orange" BackgroundColor="Orange" />
		</cards:SfCardView>
</cards:SfCardLayout>
{% endhighlight %}

{% highlight c# %}

...
InitializeComponent();
SfCardLayout cardLayout = new SfCardLayout();
cardLayout.VisibleIndexChanging += VisibleIndexChanging;

//Add children for card layout. 
cardLayout.Children.Add(new SfCardView() { Content = new Label() { Text = "Cyan", BackgroundColor = Color.Cyan }});
cardLayout.Children.Add(new SfCardView() { Content = new Label() { Text = "Yellow", BackgroundColor = Color.Yellow }});
cardLayout.Children.Add(new SfCardView() { Content = new Label() { Text="Orange", BackgroundColor = Color.Orange }});
...

private void VisibleIndexChanging(System.Object sender, Syncfusion.Maui.Cards.CardVisibleIndexChangingEventArgs e)
{
// handle event action.
}
...


{% endhighlight %}
{% endtabs %}

## VisibleIndexChanged

The [`VisibleIndexChanged`]() event is triggered when the visible card index is changed. The associated argument contains the following information.

* [`OldIndex`]() - Gets the details of the previous card.

* [`NewIndex`]() - Gets the details of the current card.

{% tabs %}
{% highlight xaml %}

<cards:SfCardLayout VisibleIndexChanged="VisibleIndexChanged" >
		<cards:SfCardView>
			<Label Text="Cyan" BackgroundColor="Cyan" />
		</cards:SfCardView>

		<cards:SfCardView>
			<Label Text="Yellow" BackgroundColor="Yellow" />
		</cards:SfCardView>

		<cards:SfCardView>
			<Label Text="Orange" BackgroundColor="Orange" />
		</cards:SfCardView>
</cards:SfCardLayout>
{% endhighlight %}

{% highlight c# %}

...
InitializeComponent();
SfCardLayout cardLayout = new SfCardLayout();
cardLayout.VisibleIndexChanged += VisibleIndexChanged;
...

private void VisibleIndexChanged(System.Object sender, Syncfusion.Maui.Cards.CardVisibleIndexChangedEventArgs e)
{
// handle event action.
}
...


{% endhighlight %}
{% endtabs %}

## Dismissing event

The [`Dismissing`]() event fires when dismissing the card by swiping, with the `SwipeToDismiss` property enabled. The associated argument contains the following information.

* [`DismissDirection`]() - Gets a dismissing direction of the card view.

* [`Cancel`]() - Gets or sets a value indicating whether the event should be canceled.

{% tabs %}
{% highlight xaml %}

<cards:SfCardView Dismissing="SfCardView_Dismissing" SwipeToDismiss="True">
    <Label Text="SfCardView" />
</cards:SfCardView>

{% endhighlight %}

{% highlight c# %}

...
InitializeComponent();
SfCardView cardView = new SfCardView() { SwipeToDismiss = true };
cardView.Dismissing += SfCardView_Dismissing;
cardView.Content = new Label() { Text = "SfCardView" };
...

private void SfCardView_Dismissing(object sender, CardDismissingEventArgs e)
{
    e.Cancel = true;
}
...

{% endhighlight %}
{% endtabs %}

N> This event will not work when adding the `SfCardView` as a child of `SfCardLayout`.

## Dismissed event

The [`Dismissed`]() event fires when dismisses the card by swiping, with enables `SwipeToDismiss` property. The argument contains the following information.

* [`DismissDirection`]() - Gets a dismissed direction of the card view.

{% tabs %}
{% highlight xaml %}

 <cards:SfCardView Dismissed="SfCardView_Dismissed" SwipeToDismiss="True">
    <Label Text="SfCardView" />
</cards:SfCardView>

{% endhighlight %}

{% highlight c# %}

...
InitializeComponent();
SfCardView cardView = new SfCardView() { SwipeToDismiss = true };
cardView.Dismissed += SfCardView_Dismissed;

...
private void SfCardView_Dismissed(object sender, CardDismissedEventArgs e)
{
   // handle event action.
}
...

{% endhighlight %}
{% endtabs %}

N> This event will not work when adding the `SfCardView` as a child of `SfCardLayout`.
