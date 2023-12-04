---
layout: post
title: Levels in .NET MAUI Sunburst Chart control | Syncfusion
description: This section explains about levels in Syncfusion .NET MAUI Sunburst Chart control.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Levels in .NET MAUI Sunburst Chart

The sunburst chart is used to display hierarchical data. More than one hierarchical data can be added to the [Levels]() collection of the sunburst chart. Each level of the hierarchy is represented by a circle.

The following code shows how to add hierarchical levels in the Levels collection.

{% tabs %} 

{% highlight xaml %}
 
    <sunburst:SfSunburstChart.Levels>
        <sunburst:SunburstHierarchicalLevel/>
    </sunburst:SfSunburstChart.Levels>

{% endhighlight %}

{% highlight C# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    . . . 
    SunburstHierarchicalLevel level = new SunburstHierarchicalLevel();
    sunburst.Levels.Add(level);
    . . .

{% endhighlight %}

{% endtabs %}

## Group member path

The [GroupMemberPath]() is a string property that is used to map the group category value in the sunburst [ItemsSource]

{% tabs %} 

{% highlight xaml %}

    . . .
        <sunburst:SfSunburstChart.Levels>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="Level1"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="Level2"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="Level2"/>
        </sunburst:SfSunburstChart.Levels>
    . . .
 
{% endhighlight %}

{% highlight C# %}

    . . .
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Level1" });
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Level2" });
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Level3" });
    . . .

{% endhighlight %}

{% endtabs %}

The following code specifies the levels for data model specified in the getting started section.

{% tabs %} 

{% highlight xaml %}

    <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}" 
                           ValueMemberPath="EmployeesCount">

            <sunburst:SfSunburstChart.Levels>
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
                <chasunburstrt:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
            </sunburst:SfSunburstChart.Levels>

    </sunburst:SfSunburstChart>
 
{% endhighlight %}

{% highlight C# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    SunburstViewModel viewModel = new SunburstViewModel();
    sunburst.BindingContext = viewModel;
    sunburst.ItemsSource = viewModel.DataSource;
    sunburst.ValueMemberPath = "EmployeesCount";
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobDescription" });
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobGroup" });
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobRole" });
    this.Content = sunburst;

{% endhighlight %}

{% endtabs %}
