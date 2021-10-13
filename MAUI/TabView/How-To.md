---
layout: post
title: Programmatically select tab in .NET MAUI Tab View | Syncfusion
description: Learn here all about select tab item programmatically in Syncfusion .NET MAUI Tab View(SfTabView) control and more.
platform: maui
control: Tab View
documentation: ug
---

# How to select a tab item programmatically? 

## Programmatically select the tab item

Using the [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_SelectedIndex) property of SfTabView, we can programmatically select the tab item as like in the below code snippet.

{% tabs %}

{% highlight xaml %}
   <tabView:SfTabView x:Name="tabView" SelectedIndex="2">
                <tabView:SfTabView.Items>
                    <tabView:SfTabItem x:Name="tab1" Header="ITEM 1">
                        ....
                    </tabView:SfTabItem>

                    <tabView:SfTabItem x:Name="tab2" Header="ITEM 2">
                        ....
                    </tabView:SfTabItem>

                    <tabView:SfTabItem x:Name="tab3" Header="ITEM 3">
                        ....
                    </tabView:SfTabItem>
                </tabView:SfTabView.Items>
            </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
public partial class TabView : ContentPage
	{
        SfTabView tabView;
		public TabView ()
		{
			InitializeComponent ();
            var tabView = new SfTabView();
            var tabItems = new TabItemCollection
            {
                new SfTabItem()
                {
                    Header = "ITEM 1",
                    Content = new ListView()
                    {
                        //// code,
                    }
                },
                new SfTabItem()
                {
                    Header = "ITEM 2",
                     Content = new ListView()
                    {
                        //// code,
                    }
                },
                new SfTabItem()
                {
                    Header = "ITEM 3",
                     Content = new ListView()
                    {
                        //// code,
                    }
                }
            };

            tabView.Items = tabItems;
            tabView.SelectedIndex = 2;
            this.Content = tabView;
		}
	}
{% endhighlight %}

{% endtabs %}

![SelectedIndex in SfTabView](images/SelectedIndexTabView.png)

## Get the selected tab item using IsSelected

Indicates whether the tab item is active or not. This property can be used to get selected item of tab view as like below code snippet.

{% tabs %}

{% highlight xaml %}
   <tabView:SfTabView x:Name="tabView" SelectedIndex="1" SelectionChanged="Index_Changed"
                <tabView:SfTabView.Items>
                    <tabView:SfTabItem x:Name="tab1" Header="ITEM 1" >
                        <tabView:SfTabItem x:Name="tab1" Header="ITEM 1">
                            ....
                        </tabView:SfTabItem>

                        <tabView:SfTabItem x:Name="tab2" Header="ITEM 2">
                            ....
                        </tabView:SfTabItem>

                        <tabView:SfTabItem x:Name="tab3" Header="ITEM 3">
                            ....
                        </tabView:SfTabItem>
                </tabView:SfTabView.Items>
            </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}

public partial class TabView : ContentPage
	{
        SfTabView tabView;
		public TabView ()
		{
			InitializeComponent ();
            var tabView = new SfTabView();
            var tabItems = new TabItemCollection
            {
                new SfTabItem()
                {
                    Header = "ITEM 1",
                    Content = new ListView()
                    {
                        //// code,
                    }
                },
                new SfTabItem()
                {
                    Header = "ITEM 2",
                     Content = new ListView()
                    {
                        //// code,
                    }
                },
                new SfTabItem()
                {
                    Header = "ITEM 3",
                     Content = new ListView()
                    {
                        //// code,
                    }
                }
            };

            tabView.Items = tabItems;
            tabView.SelectedIndex = 1;
            this.Content = tabView;
		}

        private void Index_Changed(object sender, TabSelectionChangedEventArgs e)
        {
            bool itemSelection = tab1.IsSelected;
            if (itemSelection)
            {
                tab1.FontSize = 26;
            }
        }
	}

{% endhighlight %}

{% endtabs %}

![IsSelected TabItem](images/SelectedIndex.png)