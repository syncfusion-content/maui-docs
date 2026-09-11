---

layout: post
title: Visual States in .NET MAUI Rating | Syncfusion®
description: Learn about visual state support in the Syncfusion® .NET MAUI Rating control and customize its appearance.
platform: maui
control: Rating
documentation: ug

---

# Visual States in .NET MAUI Rating

Visual states let you change the appearance of [.NET MAUI Rating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) in response to user interaction. Use them to apply different fills and strokes for each state without writing code-behind handlers.

`Rating` supports the following visual states through the [`VisualStateManager`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/visual-states?view=net-maui-10.0):

* `Normal` - The default resting state of the Rating.
* `Disabled` - The Rating is disabled (`IsEnabled` is `false`).
* `Hovered` - The pointer is over the Rating (desktop platforms). When the [Precision](https://help.syncfusion.com/maui/rating/precision-mode) is set to `Standard`, the unrated items take the hover fill and stroke as the pointer moves over them, providing a live preview of the rating value before selection.

## Prerequisites

Before using the [SfRating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/rating/getting-started) documentation.

## Defining visual states

`SfRating` exposes its states through a single `VisualStateGroup` named `CommonStates`. Each `VisualState` contains a list of `Setter` objects that target bindable properties on the Rating. The common target property is [`RatingSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_RatingSettings), which exposes the rated and unrated appearance through `RatedFill`, `RatedStroke`, `UnratedFill`, and `UnratedStroke`.

The state-based appearance can be customized independently using the [`RatingSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html) properties such as `RatedFill`, `RatedStroke`, `UnratedFill`, and `UnratedStroke`. For more details, refer to the [Appearance Customization](https://help.syncfusion.com/maui/rating/appearance-customization) documentation.

{% tabs %}
{% highlight xaml %}

 <rating:SfRating Value="3">
     <VisualStateManager.VisualStateGroups>
         <VisualStateGroup x:Name="CommonStates">
             <VisualState x:Name="Normal">
                 <VisualState.Setters>
                     <Setter Property="RatingSettings">
                         <Setter.Value>
                             <rating:RatingSettings  RatedFill="#db9602"
                                                 RatedStroke="#F57C00"
                                                 UnratedFill="#E0E0E0"
                                                 UnratedStroke="#9E9E9E"/>
                         </Setter.Value>
                     </Setter>
                 </VisualState.Setters>
             </VisualState>
             <VisualState x:Name="PointerOver">
                 <VisualState.Setters>
                     <Setter Property="RatingSettings">
                         <Setter.Value>
                             <rating:RatingSettings  RatedFill="#e8c764"
                                                 RatedStroke="#FF8F00"
                                                 UnratedFill="#D6D6D6"
                                                 UnratedStroke="#D6D6D6"/>
                         </Setter.Value>
                     </Setter>
                 </VisualState.Setters>
             </VisualState>
             <VisualState x:Name="Disabled">
                 <VisualState.Setters>
                     <Setter Property="RatingSettings">
                         <Setter.Value>
                             <rating:RatingSettings RatedFill="#CFCFCF"
                                             RatedStroke="#A8A8A8"
                                             UnratedFill="#F0F0F0"
                                             UnratedStroke="#D0D0D0"/>
                         </Setter.Value>
                     </Setter>
                 </VisualState.Setters>
             </VisualState>
         </VisualStateGroup>
     </VisualStateManager.VisualStateGroups>
 </rating:SfRating>
 
{% endhighlight %}
{% highlight c# %}

SfRating rating = new SfRating
{
    Value = 3,
};

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup { Name = "CommonStates" };

VisualState normalState = new VisualState { Name = "Normal" };
normalState.Setters.Add(new Setter
{
    Property = SfRating.RatingSettingsProperty,
    Value = new RatingSettings
    {
        RatedFill = Color.FromArgb("#db9602"),
        RatedStroke = Color.FromArgb("#F57C00"),
        UnratedFill = Color.FromArgb("#E0E0E0"),
        UnratedStroke = Color.FromArgb("#9E9E9E")
    }
});

VisualState pointerOverState = new VisualState { Name = "PointerOver" };
pointerOverState.Setters.Add(new Setter
{
    Property = SfRating.RatingSettingsProperty,
    Value = new RatingSettings
    {
        RatedFill = Color.FromArgb("#e8c764"),
        RatedStroke = Color.FromArgb("#FF8F00"),
        UnratedFill = Color.FromArgb("#D6D6D6"),
        UnratedStroke = Color.FromArgb("#BDBDBD")
    }
});

VisualState disabledState = new VisualState { Name = "Disabled" };
disabledState.Setters.Add(new Setter
{
    Property = SfRating.RatingSettingsProperty,
    Value = new RatingSettings
    {
        RatedFill = Color.FromArgb("#CFCFCF"),
        RatedStroke = Color.FromArgb("#A8A8A8"),
        UnratedFill = Color.FromArgb("#F0F0F0"),
        UnratedStroke = Color.FromArgb("#D0D0D0")
    }
});

commonStateGroup.States.Add(normalState);
commonStateGroup.States.Add(pointerOverState);
commonStateGroup.States.Add(disabledState);

visualStateGroupList.Add(commonStateGroup);

VisualStateManager.SetVisualStateGroups(rating, visualStateGroupList);

Content = rating;

{% endhighlight %}
{% endtabs %}

### Normal visual state

![.NET MAUI Rating in the Normal visual state](images/visual_state_normal.png)

### Hovered visual state

![.NET MAUI Rating in the Hovered visual state](images/visual_state_hover.png)

### Disabled visual state

![.NET MAUI Rating in the Disabled visual state](images/visual_state_disable.png)

## See Also

- [Appearance Customization](https://help.syncfusion.com/maui/rating/appearance-customization)
- [Appearance and Styling](https://help.syncfusion.com/maui/rating/appearance-and-styling)
- [Getting Started](https://help.syncfusion.com/maui/rating/getting-started)
