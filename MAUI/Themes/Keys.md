---
layout: post
title: About Keys for Syncfusion Controls | Syncfusion
description: This section contains the details about the keys which are mapped to the UI elements of all the controls
platform: maui
control: General
documentation: ug
---

# Keys of Syncfusion Controls

This page lists the keys for each control and the element to which it is mapped for all the controls.

## SfAvatarView

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>

    <tr>
        <td rowspan="14">
            SfAvatarViewStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfAvatarViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfAvatarView without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfAvatarViewTheme">CommonTheme</x:String>
                <Color x:Key="SfAvatarViewNormalStroke">Red</Color>
                <Color x:Key="SfAvatarViewNormalBackground">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfAvatarViewNormalStroke  
            <br/>
            <br/>
        </td>
        <td>
            Stroke color of SfAvatarView
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfAvatarViewNormalBackground 
            <br/>
            <br/>
        </td>
        <td>
            Background color of SfAvatarView
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfAvatarViewNormalInitialsColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color for the Initials String
            <br/>
            <br/>
        </td>
    </tr>
</table>

## SfAccordion

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>

    <tr>
        <td rowspan="12">
            SfAccordionStyles  
            <br/>
            <br/>
        </td>
        <td>
           SfAccordionTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfAccordion without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfAccordionTheme">CommonTheme</x:String>
                <Color x:Key="SfAccordionNormalHeaderBackground">Blue</Color>
                <Color x:Key="SfAccordionNormalHeaderIconColor">LightGreen</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td> SfAccordionNormalHeaderBackground <br/><br/></td>
        <td> Background color of header in SfAccordion.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionHoverHeaderBackground <br/><br/></td> 
        <td> Background color of header when it is in hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionFocusedHeaderBackground <br/><br/></td> 
        <td> Background color of header when it is in focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionHeaderRippleBackground <br/><br/></td> 
        <td> Background color of header when it is in pressed state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionNormalHeaderIconColor <br/><br/></td>
        <td> Color of the SfAccordion Header Icon.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionHoverHeaderIconColor <br/><br/></td> 
        <td> Color of header icon when it is in hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionPressedHeaderIconColor <br/><br/></td> 
        <td> Color of header icon when it is in pressed state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionFocusedHeaderIconColor <br/><br/></td> 
        <td> Color of header icon when it is in focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionExpandedItemStroke <br/><br/></td> 
        <td> Stroke color of expanded accordion item.<br/><br/></td>
    </tr>
    <tr>
        <td> SfAccordionExpandedItemStrokeThickness <br/><br/></td> 
        <td> Stroke thickness of expanded accordion item.<br/><br/>
        </td>
    </tr>
    <tr>
        <td> SfAccordionFocusedItemStroke <br/><br/></td> 
        <td> Stroke color of the header when it is in focused state during keyboard navigation.<br/><br/></td>
    </tr>
</table>

## SfExpander

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>

    <tr>
        <td rowspan="7">
            SfExpanderStyles  
            <br/>
            <br/>
        </td>
        <td>
           SfExpanderTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfExpander without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfExpanderTheme">CommonTheme</x:String>
                <Color x:Key="SfExpanderNormalHeaderBackground">Red</Color>
                <Color x:Key="SfExpanderNormalHeaderIconColor">LightBlue</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td> SfExpanderNormalHeaderBackground <br/><br/></td>
        <td> Background color of header in SfExpander.<br/><br/></td>
    </tr>
    <tr>
        <td> SfExpanderHoverHeaderBackground  <br/><br/></td> 
        <td> Background color of header when it is in hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfExpanderHeaderRippleBackground <br/><br/></td> 
        <td> Background color of header when it is in pressed state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfExpanderNormalHeaderIconColor <br/><br/></td>
        <td> Color of the SfExpander header icon.<br/><br/></td>
    </tr>
    <tr>
        <td> SfExpanderHoverHeaderIconColor  <br/><br/></td> 
        <td> Color of header icon when it is in hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfExpanderPressedHeaderIconColor <br/><br/></td> 
        <td> Color of header icon when it is in pressed state.<br/><br/></td>
    </tr>
</table>

## SfListView

<table>
    <tr>
        <th>Theme Dictionary<br/>
            <br/></th>        
        <th>
          Keys
            <br/>
            <br/>
        </th>
        <th>
            Description
            <br/>
            <br/>
        </th>
    </tr>

    <tr>
        <td rowspan="19">
            SfListViewStyles  
            <br/>
            <br/>
        </td>
        <td>
           SfListViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfListView without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfListViewTheme">CommonTheme</x:String>
                <Color x:Key="SfListViewNormalListViewItemBackground">LightBlue</Color>
                <Color x:Key="SfListViewHoverListViewItemBackground">Green</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
 </Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
    </tr>
    <tr>
        <td> SfListViewNormalListViewItemBackground <br/><br/></td>
        <td> Background color of ListViewItem. <br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewHoverListViewItemBackground <br/><br/></td>
        <td> Background color of ListViewItem when it is in hover state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewFocusedListViewItemBackground <br/><br/></td>
        <td> Background color of ListViewItem when it is in focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewFocusedListViewItemStroke <br/><br/></td> 
        <td> Stroke color of the ListViewItem when it is in focused state during key navigation.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewFocusedListViewItemStrokeThickness <br/><br/></td> 
        <td> Stroke thickness of the ListViewItem when it is in focused state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalListViewItemTextColor <br/><br/></td> 
        <td> Text color of the ListViewItem when it is in default state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalListViewItemFontSize  <br/><br/></td> 
        <td> Fontsize of the ListViewItem when it is in default state.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalGroupHeaderItemBackground <br/><br/></td> 
        <td> Backgroundcolor of the group header.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalGroupHeaderItemTextColor <br/><br/></td> 
        <td> Text color of the group header.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalGroupHeaderItemFontSize <br/><br/></td> 
        <td> FontSize of the group header.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalLoadMoreButtonBackground <br/><br/></td> 
        <td> Background color of the load more button when it is in the default state.<br/><br/></td>
    </tr>
    </tr>
    <tr>
        <td> SfListViewNormalLoadMoreItemTextColor <br/><br/></td> 
        <td> Text color of the load more button.<br/><br/></td>
    </tr>
    </tr>
    <tr>
        <td> SfListViewNormalLoadMoreItemFontSize <br/><br/></td> 
        <td> FontSize of the load more button.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalLoadMoreIndicatorIconColor <br/><br/></td> 
        <td> Color of the LoadMoreIndicator when the indicator is in the progressed state.<br/><br/></td>
    </tr>
    </tr>
    <tr>
        <td> SfListViewNormalEmptyViewItemBackground <br/><br/></td> 
        <td> Background color of the EmptyViewItem.<br/><br/></td>
    </tr>
    </tr>
    <tr>
        <td> SfListViewNormalEmptyViewItemTextColor <br/><br/></td> 
        <td> Text color of the EmptyViewItem.<br/><br/></td>
    </tr>
    <tr>
        <td> SfListViewNormalEmptyViewItemFontSize <br/><br/></td> 
        <td> Font size of the EmptyViewItem.<br/><br/></td>
    </tr>
</table>

