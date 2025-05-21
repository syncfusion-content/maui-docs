---
layout: post
title: States and Colors in .NET MAUI Text Input Layout | Syncfusion®
description: Learn about States and Colors support in the Syncfusion® .NET MAUI Text Input Layout (SfTextInputLayout) control and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui
---

# States and Colors in .NET MAUI Text Input Layout (SfTextInputLayout)

Utilize the Visual State Manager to change the [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_Stroke) properties based on visual states set in code. Applicable visual states include normal, focused, and error.

Depending on the state, colors are applied to the floating hint label and borders. For instance, when the input view is focused, the focused state [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_Stroke) will be applied; the other states follow suit. You can obtain the current stroke color via the [CurrentActiveColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_CurrentActiveColor) property.

N> The error color will not be set to `CurrentActiveColor` when the `HasError` property is set to `true`.

## Stroke
The [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_Stroke) property value applies to the hint label and border of the `SfTextInputLayout`.

I> The cursor color of the input view will match the `Accent` color of the application on each platform.

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name" 
                               Stroke="#00AFA0"
                               HelperText="Enter the name">
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroupList>
            <VisualStateGroup x:Name="CommonStates">
                    <VisualState Name="Normal">
                        <VisualState.Setters>
                            <Setter Property="Stroke" Value="#79747E"/>
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState Name="Focused">
                        <VisualState.Setters>
                            <Setter Property="Stroke" Value="#6750A4"/>
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState Name="Error">
                        <VisualState.Setters>
                            <Setter Property="Stroke" Value="#B3261E"/>
                        </VisualState.Setters>
                    </VisualState>
            </VisualStateGroup>
        </VisualStateGroupList>
    </VisualStateManager.VisualStateGroups>
    <Entry />
</inputLayout:SfTextInputLayout>  
 
{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "User name";
inputLayout.ErrorText = "User name available";
inputLayout.Content = new Entry(); 

VisualStateGroupList visualStateGroupList = new VisualStateGroupList() { };

VisualStateGroup visualStateGroup = new VisualStateGroup();

visualStateGroup.Name = "CommonStates";

VisualState normalState = new VisualState() { Name = "Normal" };
Setter normalStrokeSetter = new Setter() { Property = StrokeProperty, Value = Color.FromArgb("#79747E") };
normalState.Setters.Add(normalStrokeSetter);

VisualState focusedState = new VisualState() { Name = "Focused" };
Setter focusedStrokeSetter = new Setter() { Property = StrokeProperty, Value = Color.FromArgb("#6750A4") };
focusedState.Setters.Add(focusedStrokeSetter);

VisualState errorState = new VisualState() { Name = "Error" };
Setter errorStrokeSetter = new Setter() { Property = StrokeProperty, Value = Color.FromArgb("#B3261E") };
errorState.Setters.Add(errorStrokeSetter);

visualStateGroup.States.Add(normalState);
visualStateGroup.States.Add(focusedState);
visualStateGroup.States.Add(errorState);

visualStateGroupList.Add(visualStateGroup);

Setter mainSetter = new Setter() { Property = VisualStateManager.VisualStateGroupsProperty, Value = visualStateGroupList };

var style = new Style(typeof(SfTextInputLayout));

style.Setters.Add(mainSetter);

Resources = new ResourceDictionary() { style };

inputLayout.Style = style;

{% endhighlight %}

{% endtabs %}

![States](images/StatesAndColors/States.png)

## Disabled State

The text input layout can be disabled by setting the [IsEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_IsEnabled) property to `false`. The color of the container and other UI elements will change to the disabled state, though this color cannot be customized.

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name" 
                               IsEnabled="false">
    <Entry />
</inputLayout:SfTextInputLayout>  
 
{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.IsEnabled = false;
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![Disabled state](images/StatesAndColors/Disabled.jpg)

## Container Color
Customize the color of the container using the [ContainerBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ContainerBackground) property. This applies when the [ContainerType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ContainerType) property is set to [Filled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Filled) or [Outlined](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Outlined).

### Filled

Customize the container color when the [ContainerType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ContainerType) is [Filled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Filled).

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name" 
                               Stroke="#0450C2"
                               ContainerType="Filled"
                               ContainerBackground="#E6EEF9">
    <Entry />
</inputLayout:SfTextInputLayout>  
 
{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.Stroke = Color.FromHex("#0450C2");
inputLayout.ContainerBackground = Color.FromHex("#E6EEF9");
inputLayout.ContainerType = ContainerType.Filled;
inputLayout.Content = new Entry() { Text = "John" }; 

{% endhighlight %}

{% endtabs %}

![Filled](images/StatesAndColors/FilledContainerBackground.png)

### Outlined

Customize the container color when the [ContainerType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ContainerType) is [Outlined](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Outlined).

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name" 
                               Stroke="#0450C2"
                               ContainerType="Outlined"
                               ContainerBackground="#E6EEF9">
    <Entry  />
</inputLayout:SfTextInputLayout>  
 
{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.Stroke = Color.FromHex("#0450C2");
inputLayout.ContainerBackgroundColor = Color.FromHex("#E6EEF9");
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![outlined](images/StatesAndColors/OutlinedContainerBackground.png)

## Customizing the Text Color of Label

Customize the text color of the `hint`, `helper`, and `error` labels using the [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.LabelStyle.html#Syncfusion_Maui_Core_LabelStyle_TextColor) property of [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.LabelStyle.html).

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name" 
                               ContainerType="Outlined"
                               Stroke="Red"
                               HelperText="Enter your name"
                               ErrorText="Invalid text">
        
    <inputLayout:SfTextInputLayout.HintLabelStyle>
        <inputLayout:LabelStyle TextColor="Green"/>
    </inputLayout:SfTextInputLayout.HintLabelStyle>
    <inputLayout:SfTextInputLayout.HelperLabelStyle>
        <inputLayout:LabelStyle TextColor="Blue"/>
    </inputLayout:SfTextInputLayout.HelperLabelStyle>
    <inputLayout:SfTextInputLayout.ErrorLabelStyle>
        <inputLayout:LabelStyle TextColor="Maroon"/>
    </inputLayout:SfTextInputLayout.ErrorLabelStyle>
        
    <Entry Text="John" />
        
</inputLayout:SfTextInputLayout>  
 
{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.Stroke = Colors.Red;
inputLayout.HelperText = "Enter your name";
inputLayout.ErrorText = "Invalid text";
inputLayout.Content = new Entry();

inputLayout.HintLabelStyle = new LabelStyle() { TextColor = Color.Green };
inputLayout.HelperLabelStyle = new LabelStyle() { TextColor = Color.Blue };
inputLayout.ErrorLabelStyle = new LabelStyle() { TextColor = Color.Maroon };

{% endhighlight %}

{% endtabs %}

![Label text color](images/StatesAndColors/AssistiveColors.png)
