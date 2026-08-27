---
layout: post
title: Visual States in .NET MAUI ComboBox | Syncfusion®
description: Learn about visual states support in the Syncfusion® .NET MAUI ComboBox control and how to customize each state.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu, .net maui combobox searching.
---

# Visual States in .NET MAUI ComboBox

Visual states let you change the appearance of [.NET MAUI ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) in response to user interaction. Use them to apply different colors, borders, or other properties for each state without writing code-behind handlers.

`SfComboBox` supports the following visual states through the [`VisualStateManager`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/visual-states?view=net-maui-10.0):

* `Normal` - The default resting state of the ComboBox.
* `Focused` - The ComboBox has keyboard or input focus.
* `Disabled` - The ComboBox is disabled (`IsEnabled` is `false`).
* `Hover` - The pointer is over the ComboBox (desktop platforms).

## Prerequisites

Before using the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/combobox/getting-started) documentation.

## Defining visual states

`SfComboBox` exposes its states through a single `VisualStateGroup` named `CommonStates`. Each `VisualState` contains a list of `Setter` objects that target bindable properties on the ComboBox. Common target properties are `Background`, `Stroke`, `TextColor`, `PlaceholderColor`, `ClearButtonIconColor`, and `DropDownIconColor`.

The dropdown appearance can be customized independently using properties such as `DropDownBackground`, `DropDownStroke`, `DropDownStrokeThickness`, `DropDownItemTextColor`, `DropDownItemFontSize`, `SelectedDropDownItemBackground`, and `SelectedDropDownItemTextStyle`.

{% tabs %}
{% highlight xaml %}

<inputs:SfComboBox x:Name="comboBox"
                   DisplayMemberPath="Name"
                   TextMemberPath="Name"
                   SelectionMode="Multiple"
                   ItemsSource="{Binding SocialMedias}"
				   WidthRequest="250"
				   HeightRequest="50"
				   Placeholder="Select an item"
				   DropDownBackground="White"
				   DropDownStroke="Gray"
				   DropDownStrokeThickness="4"
				   DropDownItemTextColor="Black"
				   SelectedDropDownItemBackground="#E6F4FF">
    <inputs:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </inputs:SfComboBox.BindingContext>
	<VisualStateManager.VisualStateGroups>
		<VisualStateGroup x:Name="CommonStates">
			<VisualState x:Name="Normal">
				<VisualState.Setters>
					<Setter Property="Background" Value="White" />
					<Setter Property="Stroke" Value="#8A8A8A" />
					<Setter Property="TextColor" Value="Black" />
					<Setter Property="PlaceholderColor" Value="#707070" />
					<Setter Property="ClearButtonIconColor" Value="#707070" />
					<Setter Property="DropDownIconColor" Value="#707070" />
				</VisualState.Setters>
			</VisualState>
			<VisualState x:Name="Focused">
				<VisualState.Setters>
					<Setter Property="Background" Value="#F5FAFF" />
					<Setter Property="Stroke" Value="#0066CC" />
					<Setter Property="TextColor" Value="#0066CC" />
					<Setter Property="PlaceholderColor" Value="#707070" />
					<Setter Property="ClearButtonIconColor" Value="#0066CC" />
					<Setter Property="DropDownIconColor" Value="#0066CC" />
				</VisualState.Setters>
			</VisualState>
			<VisualState x:Name="Disabled">
				<VisualState.Setters>
					<Setter Property="Background" Value="#F0F0F0" />
					<Setter Property="Stroke" Value="#BDBDBD" />
					<Setter Property="TextColor" Value="#9E9E9E" />
					<Setter Property="PlaceholderColor" Value="#9E9E9E" />
					<Setter Property="ClearButtonIconColor" Value="#9E9E9E" />
					<Setter Property="DropDownIconColor" Value="#9E9E9E" />
				</VisualState.Setters>
			</VisualState>
			<VisualState x:Name="Hover">
				<VisualState.Setters>
					<Setter Property="Background" Value="#FAFAFA" />
					<Setter Property="Stroke" Value="#4D4D4D" />
					<Setter Property="TextColor" Value="#202020" />
					<Setter Property="PlaceholderColor" Value="#707070" />
					<Setter Property="ClearButtonIconColor" Value="#202020" />
					<Setter Property="DropDownIconColor" Value="#202020" />
				</VisualState.Setters>
			</VisualState>
		</VisualStateGroup>
	</VisualStateManager.VisualStateGroups>
</inputs:SfComboBox>

{% endhighlight %}
{% highlight c# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();
SfComboBox comboBox = new SfComboBox
{
	WidthRequest = 250,
	HeightRequest = 50,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemsSource = socialMediaViewModel.SocialMedias,
    SelectionMode = ComboBoxSelectionMode.Multiple,
	Placeholder = "Select an item",
	DropDownBackground = Colors.White,
	DropDownStroke = Colors.Gray,
	DropDownStrokeThickness = 4,
	DropDownItemTextColor = Colors.Black,
	SelectedDropDownItemBackground = Color.FromArgb("#E6F4FF")
};

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup { Name = "CommonStates" };

VisualState normalState = new VisualState { Name = "Normal" };
normalState.Setters.Add(new Setter { Property = SfComboBox.BackgroundProperty, Value = Colors.White });
normalState.Setters.Add(new Setter { Property = SfComboBox.StrokeProperty, Value = Color.FromArgb("#8A8A8A") });
normalState.Setters.Add(new Setter { Property = SfComboBox.TextColorProperty, Value = Colors.Black });

VisualState focusedState = new VisualState { Name = "Focused" };
focusedState.Setters.Add(new Setter { Property = SfComboBox.BackgroundProperty, Value = Color.FromArgb("#F5FAFF") });
focusedState.Setters.Add(new Setter { Property = SfComboBox.StrokeProperty, Value = Color.FromArgb("#0066CC") });
focusedState.Setters.Add(new Setter { Property = SfComboBox.TextColorProperty, Value = Color.FromArgb("#0066CC") });

VisualState disabledState = new VisualState { Name = "Disabled" };
disabledState.Setters.Add(new Setter { Property = SfComboBox.BackgroundProperty, Value = Color.FromArgb("#F0F0F0") });
disabledState.Setters.Add(new Setter { Property = SfComboBox.StrokeProperty, Value = Color.FromArgb("#BDBDBD") });
disabledState.Setters.Add(new Setter { Property = SfComboBox.TextColorProperty, Value = Color.FromArgb("#9E9E9E") });

VisualState hoverState = new VisualState { Name = "Hover" };
hoverState.Setters.Add(new Setter { Property = SfComboBox.BackgroundProperty, Value = Color.FromArgb("#FAFAFA") });
hoverState.Setters.Add(new Setter { Property = SfComboBox.StrokeProperty, Value = Color.FromArgb("#4D4D4D") });
hoverState.Setters.Add(new Setter { Property = SfComboBox.TextColorProperty, Value = Color.FromArgb("#202020") });

commonStateGroup.States.Add(normalState);
commonStateGroup.States.Add(focusedState);
commonStateGroup.States.Add(disabledState);
commonStateGroup.States.Add(hoverState);
visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(comboBox, visualStateGroupList);
Content = comboBox;

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// ViewModel
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }

    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia { Name = "Facebook", ID = 0 },
            new SocialMedia { Name = "Google Plus", ID = 1 },
            new SocialMedia { Name = "Instagram", ID = 2 },
            new SocialMedia { Name = "LinkedIn", ID = 3 },
            new SocialMedia { Name = "Skype", ID = 4 },
            new SocialMedia { Name = "Telegram", ID = 5 },
            new SocialMedia { Name = "Twitter", ID = 6 },
            new SocialMedia { Name = "WhatsApp", ID = 7 },
            new SocialMedia { Name = "YouTube", ID = 8 }
        };
    }
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

{% endhighlight %}
{% endtabs %}

## See Also

- [Customization](https://help.syncfusion.com/maui/combobox/ui-customization)
- [Selection](https://help.syncfusion.com/maui/combobox/selection)
- [Getting Started](https://help.syncfusion.com/maui/combobox/getting-started)