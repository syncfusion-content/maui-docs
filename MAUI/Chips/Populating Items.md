---
layout: post
title: Populating Items in .NET MAUI Chips control | Syncfusion
description: Learn about Populating Items support in Syncfusion Essential Studio .NET MAUI Chips control, its elements and more.
platform: .NET MAUI
control: Chips
documentation: ug
---

# Populating Items in .NET MAUI Chips

Chips can be populated with either business objects and SfChip. This section explain how to populate the chips control with business objects and SfChip.

## Populating business objects as items

Business objects can be populated in Chips using the `ItemsSource` property.
Refer to this [documentation] to know more details about populating the chips control with list of employee details.

## Populating SfChip as items

Chips control also provides support to create and set [`SfChip`] as item. It can be achieved using the [`Items`] property.

{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:core ="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:local="clr-namespace:Chips"
    x:Class="Chips.GettingStarted">
	<ContentPage.Content>
		<core:SfChipGroup ChipType="Action">
			<core:SfChipGroup.Items>
				<core:SfChip Text="Extra Small"/>
				<core:SfChip Text="Small"/>
				<core:SfChip Text="Medium"/>
				<core:SfChip Text="Large"/>
				<core:SfChip Text="Extra Large"/>
			</core:SfChipGroup.Items>
		</core:SfChipGroup>
	</ContentPage.Content>
</ContentPage>

	
{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Core;

namespace Chips
{
	public partial class GettingStarted: ContentPage
	{
		public GettingStarted()
		{
			InitializeComponent();
			Grid grid = new Grid();
			var chipGroup = new SfChipGroup(){Type = SfChipsType.Action};
			grid.Children.Add(chipGroup);
			chipGroup.Items.Add(new SfChip(){Text="Extra Small"});
			chipGroup.Items.Add(new SfChip(){Text="Small"});
			chipGroup.Items.Add(new SfChip(){Text="Medium"});
			chipGroup.Items.Add(new SfChip(){Text="Large"});
			chipGroup.Items.Add(new SfChip(){Text="Extra Large"});
			chipGroup.HeightRequest = 30;
        	chipGroup.BackgroundColor = Colors.Violet;
			this.Content = grid;
		}
	}
}

{% endhighlight %}

{% endtabs %}

![Collection of items to chip group](images/items/chips_items.png)


