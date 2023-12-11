---
layout: post
title: Customization in .NET MAUI Switch Control | Syncfusion
description: Learn here all about Customization support in Syncfusion .NET MAUI Switch (SfSwitch) control, and more.
platform: .NET MAUI
control: SfSwitch
documentation: ug
---

# Customization in .NET MAUI Switch (SfSwitch)

The switch control provides options to customize the color based on the states. The following code example demonstrates how to customize the switch control.

## Colors

The following properties are used to apply solid colors to the thumb, track, and border, respectively:

* [`TrackColor`]: Represents the color for the track.
* [`ThumbBackground`]: Represents the color for the thumb.
* [`TrackStroke`]: Represents the color for the border of the track.
* [`ThumbStroke`]: Represents the border color for the thumb.
* [`IconColor`]: Represents the border color for the thumb's Icon.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch IsOn="False" AllowIndeterminateState="false"> 
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroup  x:Name="CommonStates">
            <VisualState x:Name="On">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                 ThumbBackground="#FF029BFF"
                                 ThumbStroke="#FF029BFF"
                                 TrackBackground="#22029BFF"
                                 TrackStroke="#FF029BFF"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Off">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbBackground="#FFFF0199"
                                ThumbStroke="#FFFF0199"
                                TrackBackground="#22FF0199"
                                TrackStroke="#FFFF0199"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Indeterminate">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                 ThumbBackground="#9ACB0D"
                                 ThumbStroke="#9ACB0D"
                                 TrackBackground="#DEF991"
                                 TrackStroke="#9ACB0D"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
        </VisualStateGroup>
    </VisualStateManager.VisualStateGroups>
</syncfusion:SfSwitch>

{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
SwitchSettings onStyle = new SwitchSettings();
onStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#22029BFF"));
onStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#FF029BFF"));
onStyle.TrackStroke = Color.FromRgba("#FF029BFF");
onStyle.ThumbStroke = Color.FromRgba("#FF029BFF");

SwitchSettings offStyle = new SwitchSettings();
offStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#22FF0199"));
offStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#FFFF0199"));
offStyle.TrackStroke = Color.FromRgba("#FFFF0199");
offStyle.ThumbStroke = Color.FromRgba("#FFFF0199");

SwitchSettings indeterminateStyle = new SwitchSettings();
indeterminateStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#DEF991"));
indeterminateStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#9ACB0D"));
indeterminateStyle.TrackStroke = Color.FromRgba("#9ACB0D");
indeterminateStyle.ThumbStroke = Color.FromRgba("#9ACB0D");

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();

VisualState onState = new VisualState { Name = "On" };
onState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= onStyle});

VisualState offState = new VisualState { Name = "Off" };
offState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= offStyle});

VisualState indeterminateState = new VisualState { Name = "Indeterminate" };
indeterminateState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= indeterminateStyle});

commonStateGroup.States.Add(onState);
commonStateGroup.States.Add(offState);
commonStateGroup.States.Add(indeterminateState);

visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(sfSwitch, visualStateGroupList);
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![switch conrol with visual state customization](images/customization/Colors.png)

## Sizing

In the switch control, sizing of the thumb and the track can be controlled by using the following properties:

* [`TrackCornerRadius`]: Represents a CornerRadius value to create curved corner of the track.
* [`TrackStrokeThickness`]: Represents a double value for defining the track border width.
* [`TrackWidthRequest`]: Represents a double value for defining the track width.
* [`TrackHeightRequest`]: Represents double value for defining the track height.
* [`ThumbCornerRadius`]: Represents a CornerRadius value to create curved corner of the thumb.
* [`ThumbStrokeThickness`]: Represents a double value for defining the thumb border width.
* [`ThumbWidthRequest`]: Represents double value for defining the thumb width.
* [`ThumbHeightRequest`]: Represents double value for defining the thumb height.

The following code example demonstrates how to customize the size of the track and thumb.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch> 
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroup  x:Name="CommonStates">
            <VisualState x:Name="On">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbStrokeThickness="2"
                                TrackStrokeThickness="2"  
                                TrackHeightRequest="25" 
                                TrackWidthRequest="75" 
                                TrackCornerRadius="4"
                                ThumbCornerRadius="4" 
                                ThumbHeightRequest="10" 
                                ThumbWidthRequest="10"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Off">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbStrokeThickness="2"
                                TrackStrokeThickness="2"  
                                TrackHeightRequest="25" 
                                TrackWidthRequest="75" 
                                TrackCornerRadius="4"
                                ThumbCornerRadius="4" 
                                ThumbHeightRequest="10" 
                                ThumbWidthRequest="10"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
        </VisualStateGroup>
    </VisualStateManager.VisualStateGroups>
</syncfusion:SfSwitch>

{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
SwitchSettings onStyle = new SwitchSettings();
onStyle.TrackWidthRequest = 75;
nStyle.TrackHeightRequest = 25;
onStyle.ThumbWidthRequest = 10;
onStyle.ThumbHeightRequest = 10;
onStyle.TrackStrokeThickness = 2;
onStyle.ThumbStrokeThickness = 2;
onStyle.TrackCornerRadius = 4;
onStyle.ThumbCornerRadius = 4;

SwitchSettings offStyle = new SwitchSettings();
offStyle.TrackWidthRequest = 75;
offStyle.TrackHeightRequest = 25;
offStyle.ThumbWidthRequest = 10;
offStyle.ThumbHeightRequest = 10;
offStyle.TrackStrokeThickness = 2;
offStyle.ThumbStrokeThickness = 2;
offStyle.TrackCornerRadius = 4;
 offStyle.ThumbCornerRadius = 4;

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();

VisualState onState = new VisualState { Name = "On" };
onState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= onStyle});

VisualState offState = new VisualState { Name = "Off" };
offState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= offStyle});

commonStateGroup.States.Add(onState);
commonStateGroup.States.Add(offState);

visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(sfSwitch, visualStateGroupList);
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![switch conrol with sizing](images/customization/Sizing.png)

## Custom Path

In the switch control, you can customize the thumb's icon by providing a custom path, the custom path should be given to the `Path` property.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch IsOn="{x:Null}" AllowIndeterminateState="True">
        <VisualStateManager.VisualStateGroups>
            <VisualStateGroup  x:Name="CommonStates">
                <VisualState x:Name="On">
                    <VisualState.Setters>
                        <Setter Property="SwitchSettings">
                            <Setter.Value>
                            <syncfusion:SwitchSettings
                                    TrackHeightRequest="40"
                                    TrackWidthRequest="80"
                                    ThumbHeightRequest="30"
                                    ThumbWidthRequest="30"
                                    CustomPath="M17.2558 12.7442L15.8333 11.3217V8.33341C15.8333 5.65258 14.0125 3.39425 11.5458 2.71508C11.3017 2.10008 10.705 1.66675 10 1.66675C9.295 1.66675 8.69833 2.10008 8.45417 2.71508C5.9875 3.39508 4.16667 5.65258 4.16667 8.33341V11.3217L2.74417 12.7442C2.66663 12.8215 2.60514 12.9133 2.56324 13.0144C2.52133 13.1156 2.49984 13.224 2.5 13.3334V15.0001C2.5 15.2211 2.5878 15.4331 2.74408 15.5893C2.90036 15.7456 3.11232 15.8334 3.33333 15.8334H16.6667C16.8877 15.8334 17.0996 15.7456 17.2559 15.5893C17.4122 15.4331 17.5 15.2211 17.5 15.0001V13.3334C17.5002 13.224 17.4787 13.1156 17.4368 13.0144C17.3949 12.9133 17.3334 12.8215 17.2558 12.7442V12.7442ZM15.8333 14.1667H4.16667V13.6784L5.58917 12.2559C5.6667 12.1787 5.72819 12.0868 5.7701 11.9857C5.812 11.8846 5.83349 11.7762 5.83333 11.6667V8.33341C5.83333 6.03591 7.7025 4.16675 10 4.16675C12.2975 4.16675 14.1667 6.03591 14.1667 8.33341V11.6667C14.1667 11.8884 14.2542 12.1001 14.4108 12.2559L15.8333 13.6784V14.1667ZM10 18.3334C10.5161 18.3341 11.0195 18.1739 11.4404 17.8752C11.8613 17.5765 12.1786 17.1541 12.3483 16.6667H7.65167C7.82139 17.1541 8.13873 17.5765 8.55959 17.8752C8.98045 18.1739 9.48392 18.3341 10 18.3334V18.3334Z"/>
                        </Setter.Value>
                        </Setter>
                    </VisualState.Setters>
                </VisualState>
                <VisualState x:Name="Off">
                    <VisualState.Setters>
                        <Setter Property="SwitchSettings">
                            <Setter.Value>
                            <syncfusion:SwitchSettings
                                    TrackHeightRequest="40"
                                    TrackWidthRequest="80"
                                    ThumbHeightRequest="30"
                                    ThumbWidthRequest="30"
                                    CustomPath="M10.0003 18.3334C10.5164 18.3341 11.0198 18.1739 11.4407 17.8752C11.8616 17.5765 12.1789 17.1541 12.3486 16.6667H7.65197C7.82168 17.1541 8.13903 17.5765 8.55989 17.8752C8.98075 18.1739 9.48422 18.3341 10.0003 18.3334V18.3334ZM17.5003 15.0001V13.3334C17.5005 13.224 17.479 13.1156 17.4371 13.0144C17.3952 12.9133 17.3337 12.8215 17.2561 12.7442L15.8336 11.3217V8.33341C15.8336 5.65258 14.0128 3.39425 11.5461 2.71508C11.302 2.10008 10.7053 1.66675 10.0003 1.66675C9.2953 1.66675 8.69863 2.10008 8.45447 2.71508C7.35197 3.01841 6.40197 3.65508 5.66613 4.48758L3.08947 1.91091L1.91113 3.08925L16.9111 18.0892L18.0895 16.9109L16.9545 15.7759C17.114 15.7182 17.252 15.6128 17.3496 15.474C17.4472 15.3352 17.4998 15.1698 17.5003 15.0001V15.0001ZM10.0003 4.16675C12.2978 4.16675 14.167 6.03591 14.167 8.33341V11.6667C14.167 11.8884 14.2545 12.1001 14.4111 12.2559L15.8336 13.6784V14.1667H15.3453L6.83947 5.66091C7.6003 4.75425 8.72613 4.16675 10.0003 4.16675ZM5.58947 12.2559C5.667 12.1787 5.72849 12.0868 5.7704 11.9857C5.8123 11.8846 5.83379 11.7762 5.83363 11.6667V9.26758L4.22363 7.65758C4.1978 7.88091 4.16697 8.10341 4.16697 8.33341V11.3217L2.74447 12.7442C2.66693 12.8215 2.60544 12.9133 2.56354 13.0144C2.52163 13.1156 2.50014 13.224 2.5003 13.3334V15.0001C2.5003 15.2211 2.5881 15.4331 2.74438 15.5893C2.90066 15.7456 3.11262 15.8334 3.33363 15.8334H12.3995L10.7328 14.1667H4.16697V13.6784L5.58947 12.2559Z"/>
                        </Setter.Value>
                        </Setter>
                    </VisualState.Setters>
                </VisualState>
                <VisualState x:Name="Indeterminate">
                    <VisualState.Setters>
                        <Setter Property="SwitchSettings">
                            <Setter.Value>
                            <syncfusion:SwitchSettings
                                    TrackHeightRequest="40"
                                    TrackWidthRequest="80"
                                    ThumbHeightRequest="30"
                                    ThumbWidthRequest="30"
                                    CustomPath="M17.2558 12.7442L15.8333 11.3217V8.33341C15.8333 5.65258 14.0125 3.39425 11.5458 2.71508C11.3017 2.10008 10.705 1.66675 10 1.66675C9.295 1.66675 8.69833 2.10008 8.45417 2.71508C5.9875 3.39508 4.16667 5.65258 4.16667 8.33341V11.3217L2.74417 12.7442C2.66663 12.8215 2.60514 12.9133 2.56324 13.0144C2.52133 13.1156 2.49984 13.224 2.5 13.3334V15.0001C2.5 15.2211 2.5878 15.4331 2.74408 15.5893C2.90036 15.7456 3.11232 15.8334 3.33333 15.8334H16.6667C16.8877 15.8334 17.0996 15.7456 17.2559 15.5893C17.4122 15.4331 17.5 15.2211 17.5 15.0001V13.3334C17.5002 13.224 17.4787 13.1156 17.4368 13.0144C17.3949 12.9133 17.3334 12.8215 17.2558 12.7442V12.7442ZM15.8333 14.1667H4.16667V13.6784L5.58917 12.2559C5.6667 12.1787 5.72819 12.0868 5.7701 11.9857C5.812 11.8846 5.83349 11.7762 5.83333 11.6667V8.33341C5.83333 6.03591 7.7025 4.16675 10 4.16675C12.2975 4.16675 14.1667 6.03591 14.1667 8.33341V11.6667C14.1667 11.8884 14.2542 12.1001 14.4108 12.2559L15.8333 13.6784V14.1667ZM10 18.3334C10.5161 18.3341 11.0195 18.1739 11.4404 17.8752C11.8613 17.5765 12.1786 17.1541 12.3483 16.6667H7.65167C7.82139 17.1541 8.13873 17.5765 8.55959 17.8752C8.98045 18.1739 9.48392 18.3341 10 18.3334V18.3334Z M6.69727 8.33325H13.3023V9.99992H6.69727V8.33325Z"/>
                        </Setter.Value>
                        </Setter>
                    </VisualState.Setters>
                </VisualState>
            </VisualStateGroup>
        </VisualStateManager.VisualStateGroups>
    </syncfusion:SfSwitch>

{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
SwitchSettings onStyle = new SwitchSettings();
onStyle.TrackWidthRequest = 80;
nStyle.TrackHeightRequest = 40;
onStyle.ThumbWidthRequest = 30;
onStyle.ThumbHeightRequest = 30;
onStyle.CustomPath = "M17.2558 12.7442L15.8333 11.3217V8.33341C15.8333 5.65258 14.0125 3.39425 11.5458 2.71508C11.3017 2.10008 10.705 1.66675 10 1.66675C9.295 1.66675 8.69833 2.10008 8.45417 2.71508C5.9875 3.39508 4.16667 5.65258 4.16667 8.33341V11.3217L2.74417 12.7442C2.66663 12.8215 2.60514 12.9133 2.56324 13.0144C2.52133 13.1156 2.49984 13.224 2.5 13.3334V15.0001C2.5 15.2211 2.5878 15.4331 2.74408 15.5893C2.90036 15.7456 3.11232 15.8334 3.33333 15.8334H16.6667C16.8877 15.8334 17.0996 15.7456 17.2559 15.5893C17.4122 15.4331 17.5 15.2211 17.5 15.0001V13.3334C17.5002 13.224 17.4787 13.1156 17.4368 13.0144C17.3949 12.9133 17.3334 12.8215 17.2558 12.7442V12.7442ZM15.8333 14.1667H4.16667V13.6784L5.58917 12.2559C5.6667 12.1787 5.72819 12.0868 5.7701 11.9857C5.812 11.8846 5.83349 11.7762 5.83333 11.6667V8.33341C5.83333 6.03591 7.7025 4.16675 10 4.16675C12.2975 4.16675 14.1667 6.03591 14.1667 8.33341V11.6667C14.1667 11.8884 14.2542 12.1001 14.4108 12.2559L15.8333 13.6784V14.1667ZM10 18.3334C10.5161 18.3341 11.0195 18.1739 11.4404 17.8752C11.8613 17.5765 12.1786 17.1541 12.3483 16.6667H7.65167C7.82139 17.1541 8.13873 17.5765 8.55959 17.8752C8.98045 18.1739 9.48392 18.3341 10 18.3334V18.3334Z";

SwitchSettings offStyle = new SwitchSettings();
offStyle.TrackWidthRequest = 80;
offStyle.TrackHeightRequest = 40;
offStyle.ThumbWidthRequest = 30;
offStyle.ThumbHeightRequest = 30;
offStyle.CustomPath = "M10.0003 18.3334C10.5164 18.3341 11.0198 18.1739 11.4407 17.8752C11.8616 17.5765 12.1789 17.1541 12.3486 16.6667H7.65197C7.82168 17.1541 8.13903 17.5765 8.55989 17.8752C8.98075 18.1739 9.48422 18.3341 10.0003 18.3334V18.3334ZM17.5003 15.0001V13.3334C17.5005 13.224 17.479 13.1156 17.4371 13.0144C17.3952 12.9133 17.3337 12.8215 17.2561 12.7442L15.8336 11.3217V8.33341C15.8336 5.65258 14.0128 3.39425 11.5461 2.71508C11.302 2.10008 10.7053 1.66675 10.0003 1.66675C9.2953 1.66675 8.69863 2.10008 8.45447 2.71508C7.35197 3.01841 6.40197 3.65508 5.66613 4.48758L3.08947 1.91091L1.91113 3.08925L16.9111 18.0892L18.0895 16.9109L16.9545 15.7759C17.114 15.7182 17.252 15.6128 17.3496 15.474C17.4472 15.3352 17.4998 15.1698 17.5003 15.0001V15.0001ZM10.0003 4.16675C12.2978 4.16675 14.167 6.03591 14.167 8.33341V11.6667C14.167 11.8884 14.2545 12.1001 14.4111 12.2559L15.8336 13.6784V14.1667H15.3453L6.83947 5.66091C7.6003 4.75425 8.72613 4.16675 10.0003 4.16675ZM5.58947 12.2559C5.667 12.1787 5.72849 12.0868 5.7704 11.9857C5.8123 11.8846 5.83379 11.7762 5.83363 11.6667V9.26758L4.22363 7.65758C4.1978 7.88091 4.16697 8.10341 4.16697 8.33341V11.3217L2.74447 12.7442C2.66693 12.8215 2.60544 12.9133 2.56354 13.0144C2.52163 13.1156 2.50014 13.224 2.5003 13.3334V15.0001C2.5003 15.2211 2.5881 15.4331 2.74438 15.5893C2.90066 15.7456 3.11262 15.8334 3.33363 15.8334H12.3995L10.7328 14.1667H4.16697V13.6784L5.58947 12.2559Z";

SwitchSettings indeterminateStyle = new SwitchSettings();
indeterminateStyle.TrackWidthRequest = 80;
indeterminateStyle.TrackHeightRequest = 40;
indeterminateStyle.ThumbWidthRequest = 30;
indeterminateStyle.ThumbHeightRequest = 30;
indeterminateStyle.CustomPath = "M17.2558 12.7442L15.8333 11.3217V8.33341C15.8333 5.65258 14.0125 3.39425 11.5458 2.71508C11.3017 2.10008 10.705 1.66675 10 1.66675C9.295 1.66675 8.69833 2.10008 8.45417 2.71508C5.9875 3.39508 4.16667 5.65258 4.16667 8.33341V11.3217L2.74417 12.7442C2.66663 12.8215 2.60514 12.9133 2.56324 13.0144C2.52133 13.1156 2.49984 13.224 2.5 13.3334V15.0001C2.5 15.2211 2.5878 15.4331 2.74408 15.5893C2.90036 15.7456 3.11232 15.8334 3.33333 15.8334H16.6667C16.8877 15.8334 17.0996 15.7456 17.2559 15.5893C17.4122 15.4331 17.5 15.2211 17.5 15.0001V13.3334C17.5002 13.224 17.4787 13.1156 17.4368 13.0144C17.3949 12.9133 17.3334 12.8215 17.2558 12.7442V12.7442ZM15.8333 14.1667H4.16667V13.6784L5.58917 12.2559C5.6667 12.1787 5.72819 12.0868 5.7701 11.9857C5.812 11.8846 5.83349 11.7762 5.83333 11.6667V8.33341C5.83333 6.03591 7.7025 4.16675 10 4.16675C12.2975 4.16675 14.1667 6.03591 14.1667 8.33341V11.6667C14.1667 11.8884 14.2542 12.1001 14.4108 12.2559L15.8333 13.6784V14.1667ZM10 18.3334C10.5161 18.3341 11.0195 18.1739 11.4404 17.8752C11.8613 17.5765 12.1786 17.1541 12.3483 16.6667H7.65167C7.82139 17.1541 8.13873 17.5765 8.55959 17.8752C8.98045 18.1739 9.48392 18.3341 10 18.3334V18.3334Z M6.69727 8.33325H13.3023V9.99992H6.69727V8.33325Z";

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();

VisualState onState = new VisualState { Name = "On" };
onState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= onStyle});

VisualState offState = new VisualState { Name = "Off" };
offState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= offStyle});

VisualState indeterminateState = new VisualState { Name = "Indeterminate" };
indeterminateState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= indeterminateStyle});

commonStateGroup.States.Add(onState);
commonStateGroup.States.Add(offState);
commonStateGroup.States.Add(indeterminateState);

visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(sfSwitch, visualStateGroupList);
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![switch conrol with custom path](images/Path/Path.gif)

N> Keep the size of the `Path` within the dimensions of the thumb.
