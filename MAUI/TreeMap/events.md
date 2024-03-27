---
layout: post
title: Events in .NET MAUI TreeMap (SfTreemap) Control | Syncfusion
description: Learn here all about the Events support in the Syncfusion .NET MAUI TreeMap (SfTreemap) control and more.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Events in the .NET MAUI TreeMap (SfTreeMap)

## Notifying TreeMap selection changes

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SelectionChanged) event occurs when there is a change in the selection within a tree map item.

We can get the below details from the [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SelectionChanged) event.

 * [OldItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapSelectionChangedEventArgs.html#Syncfusion_Maui_TreeMap_TreeMapSelectionChangedEventArgs_OldItems): Returns the previously selected items.
 * [NewItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapSelectionChangedEventArgs.html#Syncfusion_Maui_TreeMap_TreeMapSelectionChangedEventArgs_NewItems): Returns the newly selected items.
 * [Category](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapSelectionChangedEventArgs.html#Syncfusion_Maui_TreeMap_TreeMapSelectionChangedEventArgs_Category): Returns the hierarchical path of the selected item within its groups.
 * [IsSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapSelectionChangedEventArgs.html#Syncfusion_Maui_TreeMap_TreeMapSelectionChangedEventArgs_IsSelected): Returns the items are selected or deselected.
 * [GroupLevel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.TreeMapSelectionChangedEventArgs.html#Syncfusion_Maui_TreeMap_TreeMapSelectionChangedEventArgs_GroupLevel): Returns the level of grouping for the selected items.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   SelectionChanged="OnTreeMapSelectionChanged"
                   PrimaryValuePath="Population">
    <treemap:SfTreeMap.BindingContext>
        <local:PopulationViewModel />
    </treemap:SfTreeMap.BindingContext>
    <treemap:SfTreeMap.LeafItemSettings>
        <treemap:TreeMapLeafItemSettings LabelPath="Country">
        </treemap:TreeMapLeafItemSettings>
    </treemap:SfTreeMap.LeafItemSettings>
    <treemap:SfTreeMap.LeafItemBrushSettings>
        <treemap:TreeMapUniformBrushSettings Brush="Orange"/>
    </treemap:SfTreeMap.LeafItemBrushSettings>
</treemap:SfTreeMap>

{% endhighlight %}

{% highlight C# hl_lines="1" %}

this.treeMap.SelectionChanged += this.OnTreeMapSelectionChanged;

 private void OnTreeMapSelectionChanged(object sender, TreeMapSelectionChangedEventArgs e)
 {
     var oldItems = e.OldItems;
     var newItems = e.NewItems;
     string groupName = e.Category;
     int groupLevel = e.GroupLevel;
     bool isSelected = e.IsSelected;
 }

{% endhighlight %}
{% highlight C# tabtitle="PopulationDetails.cs" %}

public class PopulationDetails
{
    public string Country { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}
{% highlight c# tabtitle="PopulationViewModel.cs" %}

public class PopulationViewModel
{
    public PopulationViewModel()
    {
        this.PopulationDetails = new ObservableCollection<PopulationDetails>()
        {
            new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
            new PopulationDetails() { Continent ="South America", Country = "Brazil", Population = 216422446 },
            new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
            new PopulationDetails() { Continent ="South America", Country = "Colombia", Population = 52085168 },
            new PopulationDetails() { Continent ="South America", Country = "Argentina", Population = 45773884 },
            new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
            new PopulationDetails() { Continent ="South America", Country = "Peru", Population = 34352719 },
            new PopulationDetails() { Continent ="South America", Country = "Venezuela", Population = 28838499 },
            new PopulationDetails() { Continent ="South America", Country = "Chile", Population = 19629590 },
            new PopulationDetails() { Continent ="South America", Country = "Ecuador", Population = 18190484 },
            new PopulationDetails() { Continent ="North America", Country = "Guatemala", Population = 18092026 },
            new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
            new PopulationDetails() { Continent ="North America", Country = "Honduras", Population = 10593798 },
            new PopulationDetails() { Continent ="North America", Country = "Nicaragua", Population = 7046311 },
            new PopulationDetails() { Continent ="South America", Country = "Paraguay", Population = 6861524 },
            new PopulationDetails() { Continent ="North America", Country = "El Salvador", Population = 6364943 },
            new PopulationDetails() { Continent ="North America", Country = "Costa Rica", Population = 5212173 },
            new PopulationDetails() { Continent ="South America", Country = "Uruguay", Population = 3423109 },
        };
    }

    public ObservableCollection<PopulationDetails> PopulationDetails
    {
        get;
        set;
    }
}

{% endhighlight %}
{% endtabs %}