---
layout: post
title: Migrate from Syncfusion Xamarin SfCards to .NET MAUI SfCards
description: Learn here about Migrating from Syncfusion Xamarin Card to Syncfusion .NET MAUI Card control.
platform: maui
control: SfCards
documentation: ug
---  

# Migrate from Xamarin.Forms SfCard to .NET MAUI SfCard 

To make the migration from the [Xamarin SfCards]() to [.NET MAUI SfCards]() easier, most of the APIs from the Xamarin SfCards were kept in the.NET MAUI SfCards. However, to maintain the consistency of API naming in the .NET MAUI SfCards, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfCards</th>
<th>.NET MAUI SfCards</th></tr>
<tr>
<td>Syncfusion.SfCards.XForms</td>
<td>Syncfusion.Maui.Cards</td></tr>
</table>

## Initialize control

To initialize the control, import the calendar namespace and initialize `SfCalendar` as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfCards</th>
<th>.NET MAUI SfCards</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:cards="clr-namespace:Syncfusion.XForms.Cards;assembly=Syncfusion.Cards.XForms">

<cards:SfCardView>
	<Label Text="SfCardView"/>
</cards:SfCardView>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Cards.XForms;
...

SfCardView cardView = new SfCardView();

//set Content for card view
cardView.Content = new Label(){ Text="SfCardView" };

this.Content = cardView;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage  xmlns:card="clr-namespace:Syncfusion.Maui.Cards;assembly=Syncfusion.Maui.Cards">

<card:SfCardView x:Name="sfCardView">
	<Label Text="SfCardView"/>	 
</card:SfCardView>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Cards;
...

SfCardView cardView = new SfCardView();

cardView.Content = new Label(){ Text="SfCardView" };

this.Content = cardView;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>


## Properties 

### SfCards

The following code example, explains how to initialize the properties of the `Xamarin SfCards` and `.NET MAUI SfCards` class.

<table>
<tr>
<th>Xamarin SfCards</th>
<th>.NET MAUI SfCards</th>
<th>Description</th>
</tr>
<tr>
<td>Nil</td>
<td>{{'[BorderWidth]()'| markdownify }}</td>
<td>Gets or sets the stroke size in SfCardView</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[BorderColor]()'| markdownify }}</td>
<td>Gets or sets the stroke in SfCardView.</td>
</tr>
<tr>
<td>{{'[IsDismissed](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardView.html#Syncfusion_XForms_Cards_SfCardView_IsDismissed)'| markdownify }}</td>
<td>{{'[IsDismissed]()'| markdownify }}</td>
<td>Gets or sets a card is dismissed or not.</td>
</tr>
<tr>
<td>{{'[CornerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardView.html#Syncfusion_XForms_Cards_SfCardView_CornerRadius)'| markdownify }}</td>
<td>{{'[CornerRadius]()'| markdownify }}</td>
<td>Gets or sets the corner radius value in SfCardView.</td>
</tr>
<tr>
<td>{{'[IndicatorColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardView.html#Syncfusion_XForms_Cards_SfCardView_IndicatorColor)'| markdownify }}</td>
<td>{{'[IndicatorColor]()'| markdownify }}</td>
<td>Gets or sets the indicator color in SfCardView.</td>
</tr>
<tr>
<td>{{'[IndicatorThickenss](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardView.html#Syncfusion_XForms_Cards_SfCardView_IndicatorThickness)'| markdownify }}</td>
<td>{{'[IndicatorThickenss]()'| markdownify }}</td>
<td>Gets or sets the indicator thickness in SfCardView.</td>
</tr>
<tr>
<td>{{'[IndicatorPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardView.html#Syncfusion_XForms_Cards_SfCardView_IndicatorPosition)'| markdownify }}</td>
<td>{{'[IndicatorPosition]()'| markdownify }}</td>
<td>Gets or sets the indicator position in SfCardView.</td>
</tr>
<tr>
<td>{{'[SwipeToDismiss](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardView.html#Syncfusion_XForms_Cards_SfCardView_SwipeToDismiss)'| markdownify }}</td>
<td>{{'[SwipeToDismiss]()'| markdownify }}</td>
<td>Gets or sets the swipe to dismiss value in SfCardView.</td>
</tr>
<tr>
<td>{{'[FadeOutOnSwiping](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardView.html#Syncfusion_XForms_Cards_SfCardView_FadeOutOnSwiping)'| markdownify }}</td>
<td>{{'[FadeOutOnSwiping]()'| markdownify }}</td>
<td>Gets or sets the Fade out value in SfCardView.</td>
</tr>
<tr>
<td>{{'[SwipeDirection](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardLayout.html#Syncfusion_XForms_Cards_SfCardLayout_SwipeDirection)'| markdownify }}</td>
<td>{{'[SwipeDirection]()'| markdownify }}</td>
<td>Gets or sets the swipe direction value in SfCardLayout.</td>
</tr>
<tr>
<td>{{'[ShowSwipedCard](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardLayout.html#Syncfusion_XForms_Cards_SfCardLayout_ShowSwipedCard)'| markdownify }}</td>
<td>{{'[ShowSwipedCard]()'| markdownify }}</td>
<td>Gets or sets the swiped card value in SfCardLayout.</td>
</tr>
<tr>
<td>{{'[VisibleCardIndex](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardLayout.html#Syncfusion_XForms_Cards_SfCardLayout_VisibleCardIndex)'| markdownify }}</td>
<td>{{'[VisibleIndex]()'| markdownify }}</td>
<td>Gets or sets the visible index value in SfCardLayout.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[VerticalCardSpacing]()'| markdownify }}</td>
<td>Gets or sets the vertical space value in SfCardLayout.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[HorizontalCardSpacing]()'| markdownify }}</td>
<td>Gets or sets the horizontal space value in SfCardLayout.</td>
</tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfCards</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[CardTapped](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardLayout.html#Syncfusion_XForms_Cards_SfCardLayout_CardTapped)'| markdownify }}</td>
<td>{{'[Tapped]()'| markdownify }}</td>
<td>Occurs whenever the card tapped on SfCardLayout. </td>
</tr>
<tr>
<td>{{'[VisibleCardIndexChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardLayout.html#Syncfusion_XForms_Cards_SfCardLayout_VisibleCardIndexChanged)'| markdownify }}</td>
<td>{{'[VisibleIndexChanged]()'| markdownify }}</td>
<td>Occurs whenever the card visible index changed on SfCardLayout. </td>
</tr>
<tr>
<td>{{'[VisibleCardIndexChanging](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardLayout.html#Syncfusion_XForms_Cards_SfCardLayout_VisibleCardIndexChanging)'| markdownify }}</td>
<td>{{'[VisibleIndexChanging]()'| markdownify }}</td>
<td>Occurs whenever the card visible index changing on SfCardLayout. </td>
</tr>
<tr>
<td>{{'[Dismissed](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardView.html#Syncfusion_XForms_Cards_SfCardView_Dismissed)'| markdownify }}</td>
<td>{{'[Dismissed]()'| markdownify }}</td>
<td>Occurs whenever the card dismissed on SfCardView. </td>
</tr>
<tr>
<td>{{'[Dismissing](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Cards.SfCardView.html#Syncfusion_XForms_Cards_SfCardView_Dismissing)'| markdownify }}</td>
<td>{{'[Dismissing]()'| markdownify }}</td>
<td>Occurs whenever the card dismissing on SfCardView. </td>
</tr>
</table>

## Methods

<table>
<tr>
<th>Xamarin SfCards</th>
<th>.NET MAUI SfCards</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[Forward]()'| markdownify }}</td>
<td>{{'[Forward]()'| markdownify }}</td>
<td>Move to next card.</td>
</tr>
<tr>
<td>{{'[Backward]()'| markdownify }}</td>
<td>{{'[Backward]()'| markdownify }}</td>
<td>Move to previous card.</td>
</tr>
</table>

## Upcoming Features

* Shadow effect support.
* Content support.