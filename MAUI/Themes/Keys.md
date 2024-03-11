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

## SfCalendar

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
            SfCalendarStyles
            <br/>
            <br/>
        </td>
		<td>
           SfCalendarTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, it is possible to customize the appearance of the SfCalendarTheme without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfCalendarViewTheme">CommonTheme</x:String>
                <Color x:Key="SfCalendarHeaderTextColor">Red</Color>
                <Color x:Key="SfCalendarHeaderBackgroundColor">Green</Color>
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
	<td>
	</td>
    <td>
            SfCalendarHeaderTextColor    
            <br/>
            <br/>
        </td>
        <td>
            Color of calendar header text.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
     <td>
	</td>
    <td>
            SfCalendarHeaderBackgroundColor     
            <br/>
            <br/>
        </td>
        <td>
            Color of calendar header background.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
    <td>
	</td>
    <td>
            SfCalendarViewHeaderTextColor      
            <br/>
            <br/>
        </td>
        <td>
            Color of calendar view header text.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
	<td>
	</td>
    <td>
            SfCalendarWeekNumberTextColor       
            <br/>
            <br/>
        </td>
        <td>
            Color of calendar week number text.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
	<td>
	</td>
    <td>
            SfCalendarWeekNumberBackgroundColor       
            <br/>
            <br/>
        </td>
        <td>
            Color of week number background.
            <br/>
            <br/>
        </td>
    </tr>
    
    <tr>
	<td>
	</td>
    <td>
            SfCalendarMonthDatesTextColor        
            <br/>
            <br/>
        </td>
        <td>
            Color of month date text.
            <br/>
            <br/>
        </td>
    </tr>

    <tr>
	<td>
	</td>
    <td>
            SfCalendarMonthDatesBackgroundColor         
            <br/>
            <br/>
        </td>
        <td>
            Color of month date text background. 
            <br/>
            <br/>
        </td>
    </tr>
    
    <tr>
	<td>
	</td>
    <td>
            SfCalendarMonthTodayTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of today text of month.
            <br/>
            <br/>
        </td>
    </tr>
    
    <tr>
	<td>
	</td>
    <td>
            SfCalendarMonthTodayBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of today background of month.
            <br/>
            <br/>
        </td>
    </tr>
    
    <tr>
	<td>
	</td>
    <td>
            SfCalendarMonthTrailingLeadingDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of trailing and leading text of month.
            <br/>
            <br/>
        </td>
    </tr>      

    <tr>
		<td>
	</td>
    <td>
            SfCalendarMonthTrailingLeadingDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of trailing and leading text of month background.
            <br/>
            <br/>
        </td>
    </tr>      

     <tr>
	 <td>
	</td>
    <td>
            SfCalendarMonthDisabledDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of disabled date in month.
            <br/>
            <br/>
        </td>
    </tr>    

     <tr>
	 	<td>
	</td>
    <td>
            SfCalendarMonthDisabledDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of disabled date in month background.
            <br/>
            <br/>
        </td>
    </tr>    	
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarWeekendDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of weekend date text.
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarWeekendDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of weekend date text background.
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarSpecialDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of special dates text.
            <br/>
            <br/>
        </td>
    </tr>    
	
    <tr>
		<td>
	</td>
    <td>
            SfCalendarSpecialDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of special date text background
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarMonthRangeTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of range text color.
            <br/>
            <br/>
        </td>
    </tr>    
	
    <tr>
		<td>
	</td>
    <td>
            SfCalendarMonthSelectionTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of selected text color.
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarYearDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of date text in the year.
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarYearDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of year dates in the background.
            <br/>
            <br/>
        </td>
    </tr>    
	
   <tr>
   	<td>
	</td>
    <td>
            SfCalendarYearDisabledDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of disabled text in the year.
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarYearDisabledDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of disabled dates background in the year.
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarYearLeadingDatesTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of leading dates text in the year
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarYearLeadingDatesBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of leading dates text background in the year.
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarYearTodayTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of today text in the year.
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarYearTodayBackgroundColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of today background in the year. 
            <br/>
            <br/>
        </td>
    </tr>    
	
    <tr>
		<td>
	</td>
    <td>
            SfCalendarYearRangeTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of year range text color.
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarYearSelectionTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of year selection text.
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarTodayHighlightColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of today highlight.
            <br/>
            <br/>
        </td>
    </tr>    
	
	<tr>
		<td>
	</td>
    <td>
            SfCalendarSelectionColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of selection.
            <br/>
            <br/>
        </td>
    </tr>  

	<tr>
		<td>
	</td>
    <td>
            SfCalendarStartRangeSelectionColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of start range selection.
            <br/>
            <br/>
        </td>
    </tr>  

	<tr>
		<td>
	</td>
    <td>
            SfCalendarEndRangeSelectionColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of end range selection.
            <br/>
            <br/>
        </td>
    </tr>  

	<tr>
		<td>
	</td>
    <td>
            SfCalendarRangeSelectionColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of range selection.
            <br/>
            <br/>
        </td>
    </tr>  

	<tr>
		<td>
	</td>
    <td>
            SfCalendarHeaderHoverTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of hovering text color of the header.
            <br/>
            <br/>
        </td>
    </tr>  

	<tr>
		<td>
	</td>
    <td>
            SfCalendarButtonTextColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of button text.
            <br/>
            <br/>
        </td>
    </tr>  

	<tr>
		<td>
	</td>
    <td>
            SfCalendarNavigationArrowColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of navigation arrow.
            <br/>
            <br/>
        </td>
    </tr>  

	<tr>
		<td>
	</td>
    <td>
            SfCalendarDisabledNavigationArrowColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of disabled navigation arrow.
            <br/>
            <br/>
        </td>
    </tr>  

	<tr>
		<td>
	</td>
    <td>
            SfCalendarHoverColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of hover.
            <br/>
            <br/>
        </td>
    </tr>  

    <tr>
		<td>
	</td>
    <td>
            SfCalendarSpecialDayIconColor          
            <br/>
            <br/>
        </td>
        <td>
            Color of special day icon.
            <br/>
            <br/>
        </td>
    </tr>  	
	
    <tr>
		<td>
	</td>
    <td>
            SfCalendarNormalBackground          
            <br/>
            <br/>
        </td>
        <td>
            Color of calendar background.
            <br/>
            <br/>
        </td>
    </tr>  	

</table>

## SfBackdrop

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
            SfBackdropStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfBackdropPageTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfBackdrop without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfBackdropPageTheme">CommonTheme</x:String>
                <Color x:Key="SfBackdropPageFrontLayerBackgroundColor">Red</Color>
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
        </td>
        <td>
            SfBackdropPageFrontLayerBackgroundColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the front layer background in the backdrop page.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
</table>

## SfBarcodeGenerator

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
            SfBarcodeGeneratorStyles
            <br/>
            <br/>
        </td>
		<td>
           SfBarcodeGeneratorTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfBarcodeGenerator without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfBarcodeGeneratorTheme">CommonTheme</x:String>
                <Color x:Key="SfBarcodeGeneratorBackgroundColor">Red</Color>
				 <Color x:Key="SfBarcodeGeneratorForegroundColor">Green</Color>
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
        </td>
        <td>
            SfBarcodeGeneratorBackgroundColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the background in the barcode generator
            <br/>
            <br/>
        </td>
    </tr>
	
	  <tr>
        <td>
        </td>
        <td>
            SfBarcodeGeneratorForegroundColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the foreground in the barcode generator
            <br/>
            <br/>
        </td>
    </tr>
	
	       <tr>
        <td>
        </td>
        <td>
            SfBarcodeGeneratorTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the text in the barcode generator
            <br/>
            <br/>
        </td>
    </tr>
	
	</tr>
</table>

## SfCards

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
            SfCardViewStyles
            <br/>
            <br/>
        </td>
		<td>
           SfCardViewTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfCardView without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfCardViewTheme">CommonTheme</x:String>
                <Color x:Key="SfCardViewBorderColor">Red</Color>
				 <Color x:Key="SfCardViewIndicatorColor">Green</Color>
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
        </td>
        <td>
            SfCardViewBorderColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the border of card view.
            <br/>
            <br/>
        </td>
    </tr>
	
	  <tr>
        <td>
        </td>
        <td>
            SfCardViewIndicatorColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the indicator of the card view.
            <br/>
            <br/>
        </td>
    </tr>
	
	       <tr>
        <td>
        </td>
        <td>
            SfCardViewNormalBackround  
            <br/>
            <br/>
        </td>
        <td>
            Color of the card Background.
            <br/>
            <br/>
        </td>
    </tr>
	
	</tr>
</table>

## SfRadialGauge

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
            SfRadialGaugeStyles
            <br/>
            <br/>
        </td>
		<td>
            SfRadialGaugeTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfRadialGauge without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfRadialGaugeTheme">CommonTheme</x:String>
                <Color x:Key="SfRadialGaugeAxisLabelTextColor">Red</Color>
				 <Color x:Key="SfRadialGaugeAxisLineFillColor">Green</Color>
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
        </td>
        <td>
            SfRadialGaugeAxisLabelTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of axis label text in radial gauge.
            <br/>
            <br/>
        </td>
    </tr>
	
	  <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeAxisLineFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of axis line fill in radial gauge.
            <br/>
            <br/>
        </td>
    </tr>
	
	       <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeAxisLineGradientColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the gradient of the axis line.
            <br/>
            <br/>
        </td>
    </tr>
	
		    <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeMajorTickStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the major tick stroke. 
            <br/>
            <br/>
        </td>
    </tr>
	
		 <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeMinorTickStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the minor tick stroke.
            <br/>
            <br/>
        </td>
    </tr>
	
	 <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeShapePointerFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the shape pointer fill.
            <br/>
            <br/>
        </td>
    </tr>
	
	<tr>
        <td>
        </td>
        <td>
            SfRadialGaugeShapePointerOverlayFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the shape pointer overlayfill.
            <br/>
            <br/>
        </td>
    </tr>
	
	 <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeShapePointerStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the pointer stroke of the shape. 
            <br/>
            <br/>
        </td>
    </tr>
	
		       <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeNeedlePointerKnobFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the knobfill of the needle pointer.
            <br/>
            <br/>
        </td>
    </tr>
	
    <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeNeedlePointerKnobStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the stroke of needle pointer knob.
            <br/>
            <br/>
        </td>
    </tr>
	
    <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeNeedlePointerNeedleFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the needle pointer fill.
            <br/>
            <br/>
        </td>
    </tr>
	
	    <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeNeedlePointerTailFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the tail pointer fill.
            <br/>
            <br/>
        </td>
    </tr>
	
	    <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeRangePointerFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the need pointer fill.
            <br/>
            <br/>
        </td>
    </tr>
	
	    <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeRangePointerGradientColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the gradient of the radial gauge.
            <br/>
            <br/>
        </td>
    </tr>
	
	    <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeRadialRangeFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of radial range fill.
            <br/>
            <br/>
        </td>
    </tr>
	
	    <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeRadialRangeGradientColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the gradient of gauge.
            <br/>
            <br/>
        </td>
    </tr>
	
	    <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeRadialRangeLabelTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the radial range text color.
            <br/>
            <br/>
        </td>
    </tr>
	
	    <tr>
        <td>
        </td>
        <td>
            SfRadialGaugeShapeShadowColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the shape shadow.
            <br/>
            <br/>
        </td>
    </tr>
	
	</tr>
</table>

## SfLinearGauge

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
            SfLinearGaugeThemeStyles
            <br/>
            <br/>
        </td>
		<td>
           SfLinearGaugeTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfLinearGauge without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfBarcodeGeneratorTheme">CommonTheme</x:String>
                <Color x:Key="SfLinearGaugeBarPointerFillColor">Red</Color>
				 <Color x:Key="SfLinearGaugeLabelTextColor">Green</Color>
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
        </td>
        <td>
            SfLinearGaugeBarPointerFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the pointer fill of the linear gauge.
            <br/>
            <br/>
        </td>
    </tr>
	
	  <tr>
        <td>
        </td>
        <td>
            SfLinearGaugeLabelTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the label text.
            <br/>
            <br/>
        </td>
    </tr>
	
	       <tr>
        <td>
        </td>
        <td>
            SfLinearGaugeMajorTickStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the major tick Stroke.
            <br/>
            <br/>
        </td>
    </tr>
	
		       <tr>
        <td>
        </td>
        <td>
            SfLinearGaugeMinorTickStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the minor tick Stroke.
            <br/>
            <br/>
        </td>
    </tr>
	
		       <tr>
        <td>
        </td>
        <td>
            SfLinearGaugeAxisLineFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the axis line fill.
            <br/>
            <br/>
        </td>
    </tr>
	
		       <tr>
        <td>
        </td>
        <td>
            SfLinearGaugeRangeFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the range fill.
            <br/>
            <br/>
        </td>
    </tr>
	
		       <tr>
        <td>
        </td>
        <td>
            SfLinearGaugeShapePointerFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Color of the shape pointer of the gauge.
            <br/>
            <br/>
        </td>
    </tr>
	
    <tr>
        <td>
        </td>
        <td>
            SfLinearGaugeShapePointerStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the pointer stroke
            <br/>
            <br/>
        </td>
    </tr>
	
	 <tr>
        <td>
        </td>
        <td>
            SfLinearGaugeNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the gauge background.
            <br/>
            <br/>
        </td>
    </tr>
	
	</tr>
</table>


## SfStepProgressBar

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
           SfStepProgressBarThemeStyles
            <br/>
            <br/>
        </td>
		<td>
           SfStepProgressBarTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfStepProgressBar without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary />
            <ResourceDictionary>
                <x:String x:Key="SfStepProgressBarTheme">CommonTheme</x:String>
                <Color x:Key="SfStepProgressBarNormalBackground">Red</Color>
				 <Color x:Key="SfStepProgressBarNormalProgressBarBackground">Green</Color>
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
        </td>
        <td>
            SfStepProgressBarNormalBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the step progressbar background.
            <br/>
            <br/>
        </td>
    </tr>
	
	  <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalProgressBarBackground  
            <br/>
            <br/>
        </td>
        <td>
            Color of the normal step progressbar background.
            <br/>
            <br/>
        </td>
    </tr>
	
	       <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalCompletedStepContentFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Completed step content fill color in the progressbar.
            <br/>
            <br/>
        </td>
    </tr>
	
   <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalCompletedStepBackground  
            <br/>
            <br/>
        </td>
        <td>
            Completed step background color in the progressbar.
            <br/>
            <br/>
        </td>
    </tr>
	
   <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalCompletedStepStroke  
            <br/>
            <br/>
        </td>
        <td>
            Color of the step stroke in progressbar.
            <br/>
            <br/>
        </td>
    </tr>
	
     <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalCompletedStepProgressColor  
            <br/>
            <br/>
        </td>
        <td>
            Progress color in the completed step.
            <br/>
            <br/>
        </td>
    </tr>
	
    <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalCompletedStepTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Text color of the completed step.
            <br/>
            <br/>
        </td>
    </tr>
	
    <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalInProgressStepContentFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Fill color of the in Progress step. 
            <br/>
            <br/>
        </td>
    </tr>
	
	 <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalInProgressStepBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background of the in Progress step.
            <br/>
            <br/>
        </td>
    </tr>
	
		 <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalInProgressStepProgressColor  
            <br/>
            <br/>
        </td>
        <td>
            Step progress color of the in progress step.
            <br/>
            <br/>
        </td>
    </tr>
	
		 <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalInProgressStepTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Text color of the in progress step.
            <br/>
            <br/>
        </td>
    </tr>
	
		 <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalNotStartedStepContentFillColor  
            <br/>
            <br/>
        </td>
        <td>
            Fill color of the not started step.
            <br/>
            <br/>
        </td>
    </tr>
	
		 <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalNotStartedStepBackground  
            <br/>
            <br/>
        </td>
        <td>
            Background of the not started step.
            <br/>
            <br/>
        </td>
    </tr>
	
		 <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalNotStartedStepStroke  
            <br/>
            <br/>
        </td>
        <td>
            Step stroke of th not started step.
            <br/>
            <br/>
        </td>
    </tr>
	
		 <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalNotStartedStepProgressColor  
            <br/>
            <br/>
        </td>
        <td>
            Progress color of the not started step.
            <br/>
            <br/>
        </td>
    </tr>
	
		 <tr>
        <td>
        </td>
        <td>
            SfStepProgressBarNormalNotStartedStepTextColor  
            <br/>
            <br/>
        </td>
        <td>
            Text color of the not started text.
            <br/>
            <br/>
        </td>
    </tr>
	
	</tr>
</table>
