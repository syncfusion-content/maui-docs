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

## SfPdfViewer

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
        <td rowspan="290">
            SfPdfViewerStyles  
            <br/>
            <br/>
        </td>
		<td>
           SfPdfViewerTheme 
            <br/>
            <br/>
        </td>
        <td>    
            By merging this key in application resources, you can customize the appearance of SfPdfViewer without merging common theme resource and control style resource dictionaries.
			
{% highlight xaml %}

<Application xmlns:SyncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <SyncTheme:SyncfusionThemeDictionary>
        <SyncTheme:SyncfusionThemeDictionary.MergedDictionaries>
            <ResourceDictionary>
                <x:String x:Key="SfPdfViewerTheme">Custom Theme</x:String>
                <Color x:Key="SfPdfViewerNormalDialogSaveButtonBackgroundColor">aqua</Color>
                <Color x:Key="SfPdfViewerNormalScrollHeadBackgroundColor">red</Color>
                <Color x:Key="SfPdfViewerNormalScrollHeadBorderColor">Blue</Color>
                <Color x:Key="SfPdfViewerNormalScrollHeadTextColor">green</Color>
                <Color x:Key="SfPdfViewerNormalContextMenuBackGroundColor">yellow</Color>
            </ResourceDictionary>
        </SyncTheme:SyncfusionThemeDictionary.MergedDictionaries>
    </SyncTheme:SyncfusionThemeDictionary>
</Application.Resources>

....

</Application>

{% endhighlight %}
            <br/>
            <br/>
        </td>
        <tr>
        <td>
            SfPdfViewerOutlineTabViewContainerBackgroundColor  
            <br/>
            <br/>
        </td>
        <td>
            Background colour of the tabview container in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	</tr>
    <tr>
        <td>
            SfPdfViewerOutlineNoBookMarkTextColor 
            <br/>
            <br/>
        </td>
        <td>
            Text colour of the No Bookmark label in the outlineview of the SfPdfViewer.
        <br/>
        <br/>
        </td>
    </tr>
    <tr>
        <td>
            SfPdfViewerNormalScrollHeadBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the scroll head in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalScrollHeadTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the scroll head in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalScrollHeadBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the scroll head in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalPasswordEntryStroke  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the password entry of the password dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalPasswordEntryErrorTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the password entry while entering the wrong password in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalPasswordEntryContainerBackground  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the password entry of the password dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalPasswordEntryTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Normal text color of the password entry of the password dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOkButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'OK' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOkButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'OK' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOkButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'OK' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOkButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'OK' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOkButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'OK' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOkButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the 'OK' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOkButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the 'OK' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOkButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the 'OK' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOkButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the 'OK' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOkButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the 'OK' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'OK' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'OK' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'OK' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'OK' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'OK' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogTitleTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the title in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogDescriptionTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the description in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'close' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'close' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'close' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'close' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'close' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'close' button while hovering over the in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'close' button while focusing the in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'close' button while pressing the in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'close' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'close' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'close' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'close' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the dialogs in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCancelButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'cancel' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCancelButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'cancel' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCancelButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'cancel' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCancelButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'cancel' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogCancelButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'cancel' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCancelButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'cancel' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCancelButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'cancel' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCancelButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'cancel' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCancelButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'cancel' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogCancelButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'cancel' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogCancelButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'cancel' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogCancelButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'cancel' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogCancelButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'cancel' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogCancelButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'cancel' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogCancelButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'cancel' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOpenButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'open' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOpenButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'open' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOpenButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'open' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOpenButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'open' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOpenBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'open' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOpenButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'open' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOpenButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'open' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOpenButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'open' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOpenButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'open' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOpenButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the 'open' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogOpenButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'open' button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogOpenButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'open' button while hovering over the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedDialogOpenButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'open' button while focusing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogOpenButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'open' button while pressing the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogOpenButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'open' button after disabled the button in the dialogs of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineTitleTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the title of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineExpanderTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the expander of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineExpanderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the expander of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineExpanderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the expander of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineExpanderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the expander of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineExpanderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused background color of the expander of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineExpanderButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
             Border color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineExpanderButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
             Hovering border color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineExpanderButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineExpanderButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused border color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineExpanderButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineExpanderButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineExpanderButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused text color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineExpanderButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the expander button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineSeparatorBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Separator color of outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineTitleLabelTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the title of outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineContainerBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the outlineview container in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the close button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the close button of the outlineview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused background color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineCloseButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering border color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed border color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused border color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineCloseButtonIconBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused border color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalOutlineCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverOutlineCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerFocusedOutlineCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Focused text color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedOutlineCloseButtonIconForegroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the close button in the outlineview of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the text selection context menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogListTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the dialog list in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogSaveButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogSaveButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogSaveButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogSaveButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the 'Save' button after disabled the button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogSaveButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerHoverDialogSaveButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerPressedDialogSaveButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the 'Save' button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDisabledDialogSaveButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the 'Save' button after disabled the button in the dialog of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogAnnotationTextEditTopPanelBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Header background color of the free text dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogAnnotationTextEditBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the free text dialog in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogAnnotationTextEditTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the free Text editor in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogAnnotationTextEditPlaceHolderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Place holder color of the free Text editor in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogNormalListCheckBoxColor  
            <br/>
            <br/>
        </td> 
        <td>
            Check box color of the list box form field in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalDialogSelectedListCheckBoxColor  
            <br/>
            <br/>
        </td> 
        <td>
            Selected check box color of the list box form field in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the text selection context menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalSeparatorBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Separator color of the text selection context menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuBorderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the text selection context menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalMoreOptionsBorderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the text more options menu in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuHoverColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the items in the text selection context menu of SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuPressedColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the items in the text selection context menu of SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuHoverTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the hovered item in the text selection context menu of SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerNormalContextMenuPressedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the pressed item in the text selection context menu of the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadHeaderTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Header text color of the signature pad in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's main container in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the draw signature pad in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonHoverTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonPressedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonHoverBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonPressedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the signature pad's 'Clear' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonHoverTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonPressedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonBackGroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonHoverBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering Background color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonPressedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed Background color of the signature pad's 'Close' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadClearButtonDisabledTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's 'Clear' button after disabled in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's 'Crete' button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewColorSelectorColor  
            <br/>
            <br/>
        </td> 
        <td>
            Color selector color of the signature pad in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewDrawTabBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's draw tab  in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewUploadTabButtonColor  
            <br/>
            <br/>
        </td> 
        <td>
            Upload button color of the signature pad in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewUploadTabButtonBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the signature pad's upload button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewUploadTabDragandDropTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Drag and drop text color of the signature pad's upload tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewUploadTabBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's upload tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewHeaderBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of integrated signature view's header in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewBackButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of signature pad's back button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewOkButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of signature pad's OK button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewHeaderTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of integrated signature view's header in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewSaveTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of integrated signature view's save button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewSaveCheckboxColor  
            <br/>
            <br/>
        </td> 
        <td>
            Checkbox color of signature pad in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewClearTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's clear button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewSaveLayoutBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature pad's save layout in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewColorBarBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of signature pad's color bar in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewItemBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of signature listview's items in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewItemBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of signature listview's items in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewLongPressedItemBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of signature listview's items while long press in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewLongPressedSItemBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of signature listview's items while long pressing on item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewTappedItemBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of signature listview's items while tapping on the item in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of signature listview in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureCreateButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature listview container's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureCreateButtonStrokeColor  
            <br/>
            <br/>
        </td> 
        <td>
            Stroke color of the signature listview container's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListDeleteButtonColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature listview container's delete button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewHeaderTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature listview container's header in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewDeleteButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature listview delete button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewCreateButtonTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature listview create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureTextNormalStrokeColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the text signature views in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureTextSelectedStrokeColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the selected text signature view in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerDesktopSignatureTextSelectedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the selected text signature view (Desktop) in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerMobileSignatureTextSelectedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the selected text signature view (Mobile) in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureListViewBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature swipe up view (Mobile) in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewTypeTabBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Background color of the signature type tab in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewTypeTabTextEntryBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the signature type tab's entry in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignatureViewTypeTabSignatureLabelBorderColor  
            <br/>
            <br/>
        </td> 
        <td>
            Border color of the signature type tab's label in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonHoverTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the signature pad's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonPressedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the signature pad's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonHoverBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the signature pad's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonPressedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the signature pad's create button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCreateButtonDisabledTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's create button after disabled in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCloseButtonDisabledTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's close button after disabled in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCancelButtonDisabledTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Text color of the signature pad's cancel button after disabled in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCancelButtonHoverTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering text color of the signature pad's cancel button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCancelButtonPressedTextColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed text color of the signature pad's cancel button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCancelHoverBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Hovering background color of the signature pad's cancel button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
	<tr>
        <td>
            SfPdfViewerSignaturePadCancelPressedBackgroundColor  
            <br/>
            <br/>
        </td> 
        <td>
            Pressed background color of the signature pad's cancel button in the SfPdfViewer.
            <br/>
            <br/>
        </td>
    </tr>
</table>



