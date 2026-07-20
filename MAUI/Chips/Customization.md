---
layout: post
title: Customization in .NET MAUI Chips (SfChip and SfChipGroup) control | Syncfusion®
description: Learn how to customize the Syncfusion® .NET MAUI Chips controls, including SfChip and SfChipGroup, in code and XAML.
platform: maui
control: SfChip, SfChipGroup
documentation: ug
---

# Customization in .NET MAUI Chips (SfChip and SfChipGroup)

The [.NET MAUI Chips](https://www.syncfusion.com/maui-controls/maui-chips) controls support customizing the background color, border color, close button color, selection indicator, text, icons, and more. This page documents the customization properties for both [`SfChip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html) and [`SfChipGroup`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html).

## Prerequisites

Before using the [SfChip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/chips/getting-started) documentation.

- For `SfChipGroup` samples that bind `ItemsSource` to `Employees`, set the page's `BindingContext` to a ViewModel that exposes an `ObservableCollection<Employee>` (see the [Populating Items](https://help.syncfusion.com/maui/chips/populating-items) page for a complete model and ViewModel).
- For samples that reference an image (e.g., `ChipUserContact.png`, `lion.png`, `jhon.png`), add the image to the `Resources/Images` folder of your .NET MAUI project and register it as a `MauiImage` in the `.csproj` file.

## SfChip Customization

The following properties customize the appearance of an individual `SfChip`.

### ShowCloseButton

The [`ShowCloseButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_ShowCloseButton) property sets the visibility of the close button in `SfChip`. The default value is `false`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             ShowCloseButton="True" />

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    ShowCloseButton = true
};

{% endhighlight %}
{% endtabs %}

![SfChip with CloseButton](images/customization-images/chip_showclosebutton_image.png)

### ShowSelectionIndicator

The [`ShowSelectionIndicator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_ShowSelectionIndicator) property sets the visibility of the selection indicator in `SfChip`. The default value is `false`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             ShowSelectionIndicator="True" />

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    ShowSelectionIndicator = true
};

{% endhighlight %}
{% endtabs %}

![SfChip with ShowSelectionIndicator](images/customization-images/chip_showselectionindicator_image.png)

### CloseButtonColor

The [`CloseButtonColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_CloseButtonColor) property customizes the color of the close button in `SfChip`. The default value is `Color.FromArgb("#49454E")`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             ShowCloseButton="True"
             CloseButtonColor="Red" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    ShowCloseButton = true,
    CloseButtonColor = Colors.Red
};

{% endhighlight %}
{% endtabs %}

![SfChip with CloseButtonColor](images/customization-images/chip_closebuttoncolor_image.png)

### SelectionIndicatorColor

The [`SelectionIndicatorColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_SelectionIndicatorColor) property customizes the selection indicator color in `SfChip`. The default value is `Color.FromRgb(30, 25, 43)`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             ShowSelectionIndicator="True"
             SelectionIndicatorColor="Yellow" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    ShowSelectionIndicator = true,
    SelectionIndicatorColor = Colors.Yellow
};

{% endhighlight %}
{% endtabs %}

![SfChip with SelectionIndicatorColor](images/customization-images/chip_selectionindicatorcolor_image.png)

### Background

The [`Background`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_Background) property customizes the background color of `SfChip`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             Background="LightCoral" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    Background = Colors.LightCoral
};

{% endhighlight %}
{% endtabs %}

![SfChip with Background](images/customization-images/chip_chipbackgroundcolor_image.png)

### Stroke

The [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_Stroke) property customizes the border color of `SfChip`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             Stroke="Black" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    Stroke = Colors.Black
};

{% endhighlight %}
{% endtabs %}

![SfChip with Stroke](images/customization-images/chip_stroke_image.png)

### StrokeThickness

The [`StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_StrokeThickness) property customizes the border thickness of `SfChip` on all four sides.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             StrokeThickness="7"
             Stroke="Black" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    StrokeThickness = 7,
    Stroke = Colors.Black
};

{% endhighlight %}
{% endtabs %}

![SfChip with StrokeThickness](images/customization-images/chip_strokethickness_image.png)

### CornerRadius

The [`CornerRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_CornerRadius) property customizes the corner radius of `SfChip`. The default value is `new Thickness(8)`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             CornerRadius="25"
             Stroke="Black" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    CornerRadius = 25,
    Stroke = Colors.Black
};

{% endhighlight %}
{% endtabs %}

![SfChip with CornerRadius](images/customization-images/chip_cornerradius_image.png)

### FontAttributes

The [`FontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_FontAttributes) property customizes the font style of the text in `SfChip`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             FontAttributes="Italic" />

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    FontAttributes = FontAttributes.Italic
};

{% endhighlight %}
{% endtabs %}

![SfChip with FontAttributes](images/customization-images/chip_fontattribute_image.png)

### FontFamily

The [`FontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_FontFamily) property customizes the font family of the text in `SfChip`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             FontFamily="Times New Roman" />

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    FontFamily = "Times New Roman"
};

{% endhighlight %}
{% endtabs %}

![SfChip with FontFamily](images/customization-images/chipfontfamily_image.png)

### FontSize

The [`FontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_FontSize) property customizes the size of the text in `SfChip`. The default value is `14d`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             FontSize="15" />

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    FontSize = 15
};

{% endhighlight %}
{% endtabs %}

![SfChip with FontSize](images/customization-images/chip_fontsize_image.png)

### TextColor

The [`TextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_TextColor) property customizes the color of the text in `SfChip`. The default value is `Color.FromArgb("#1C1B1F")`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             TextColor="Red" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    TextColor = Colors.Red
};

{% endhighlight %}
{% endtabs %}

![SfChip with TextColor](images/customization-images/chip_textcolor_image.png)

### TextAlignment

The [`HorizontalTextAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_HorizontalTextAlignment) and [`VerticalTextAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_VerticalTextAlignment) properties customize the alignment of the text in `SfChip`. The default values for both are `TextAlignment.Center`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             ShowCloseButton="True"
             HorizontalTextAlignment="Start"
             VerticalTextAlignment="Center" />

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    ShowCloseButton = true,
    HorizontalTextAlignment = TextAlignment.Start,
    VerticalTextAlignment = TextAlignment.Center
};

{% endhighlight %}
{% endtabs %}

![SfChip with TextAlignment](images/customization-images/chip_textalignment_image.png)

### ShowIcon

The [`ShowIcon`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ShowIcon) property specifies whether the image set in `ImageSource` is displayed in the `SfChip`. The default value is `false`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             ImageSource="ChipUserContact.png"
             ShowIcon="True" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    ImageSource = ImageSource.FromFile("ChipUserContact.png"),
    ShowIcon = true
};

{% endhighlight %}
{% endtabs %}

![SfChip with ShowIcon](images/customization-images/chip_showicon_image.png)

### ImageSource

The [`ImageSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageSource) property customizes the icon image of `SfChip` by adding a custom image. `ShowIcon` must be `true` for the image to render.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             ImageSource="ChipUserContact.png"
             ShowIcon="True" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    ImageSource = ImageSource.FromFile("ChipUserContact.png"),
    ShowIcon = true
};

{% endhighlight %}
{% endtabs %}

![SfChip with ImageSource](images/customization-images/chip_imagesource_image.png)

### ImageSize

The [`ImageSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageSize) property customizes the size of the icon image in `SfChip`. `ShowIcon` must be `true` for the size to apply. The default value is `18d`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             ImageSource="ChipUserContact.png"
             ImageSize="30"
             ShowIcon="True" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    ImageSource = ImageSource.FromFile("ChipUserContact.png"),
    ImageSize = 30,
    ShowIcon = true
};

{% endhighlight %}
{% endtabs %}

![SfChip with ImageSize](images/customization-images/chip_imagesize_image.png)

### ImageAlignment

The [`ImageAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageAlignment) property customizes the alignment of the icon image in `SfChip`. The default value is `Alignment.Start`.

{% tabs %}
{% highlight xaml %}

<chip:SfChip Text="James"
             ImageSource="ChipUserContact.png"
             ImageAlignment="End"
             ShowIcon="True" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    Text = "James",
    ImageSource = ImageSource.FromFile("ChipUserContact.png"),
    ImageAlignment = Alignment.End,
    ShowIcon = true
};

{% endhighlight %}
{% endtabs %}

![SfChip with ImageAlignment](images/customization-images/chip_imagealignment_image.png)

### BackgroundImageSource

The [`BackgroundImageSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_BackgroundImageSource) property customizes the background image of `SfChip`. The image is rendered in the chip's bounds using the default `Aspect` (`AspectFit`).

{% tabs %}
{% highlight xaml %}

<chip:SfChip BackgroundImageSource="lion.png" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

SfChip chip = new SfChip
{
    BackgroundImageSource = ImageSource.FromFile("lion.png")
};

{% endhighlight %}
{% endtabs %}

![SfChip with image property](images/customization-images/chip_chipbackground_image.png)

### Command

The [`Command`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_Command) property associates a command with an instance of `SfChip`. This property is most often set with the MVVM pattern to bind callbacks back into the ViewModel. You can also pass a `CommandParameter`. The default value is `null`.

{% tabs %}
{% highlight xaml %}

<ContentPage.BindingContext>
    <local:CommandDemoViewModel />
</ContentPage.BindingContext>

<chip:SfChip x:Name="Chip"
             Text="James"
             WidthRequest="120"
             Background="{Binding Background}"
             Command="{Binding ButtonCommand}" />

{% endhighlight %}
{% highlight c# %}

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Graphics;

namespace ChipsSample;

public class CommandDemoViewModel : INotifyPropertyChanged
{
    private Color _background = Colors.Violet;

    public Color Background
    {
        get => _background;
        set
        {
            _background = value;
            OnPropertyChanged();
        }
    }

    public ICommand ButtonCommand => new Command(ToggleBackground);

    public CommandDemoViewModel() => Background = Colors.Violet;

    private void ToggleBackground()
    {
        Background = Background == Colors.DeepSkyBlue ? Colors.Violet : Colors.DeepSkyBlue;
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChip with Command](images/customization-images/chip_command_image.png)

## SfChipGroup Customization

The chip group supports customizing the chip's background color, border color, text color, and more. The chip group can be customized using the following properties.

### InputView

The [`InputView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_InputView) property provides a view to the input chip. In this example, an `Entry` is added as the `InputView` so users can type a new chip's text. The `InputView` is only visible for the `Input` `ChipType`. The default value is `null`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup x:Name="chipGroup"
                  ItemsSource="{Binding Employees}"
                  ChipPadding="8,8,0,0"
                  ChipType="Input"
                  DisplayMemberPath="Name">
    <chip:SfChipGroup.InputView>
        <Entry x:Name="entry"
               Placeholder="Enter Name"
               Margin="10,10,0,0"
               WidthRequest="110" />
    </chip:SfChipGroup.InputView>
</chip:SfChipGroup>

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

namespace ChipsSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new ChipsViewModel();

        var entry = new Entry
        {
            Placeholder = "Enter Name",
            Margin = new Thickness(10, 10, 0, 0),
            WidthRequest = 110
        };

        var chipGroup = new SfChipGroup
        {
            InputView = entry,
            DisplayMemberPath = "Name",
            ChipPadding = new Thickness(8, 8, 0, 0),
            ChipType = SfChipsType.Input
        };
        BindingContext = new EmployeeViewModel();
        chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");

        Content = chipGroup;
    }
}

{% endhighlight %}

{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with InputView](images/customization-images/chipgroup_inputview_image.png)

### ChipBackground

The [`ChipBackground`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipBackground) property customizes the background color of the unselected chips in `SfChipGroup`. The default value is `Colors.Transparent`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  DisplayMemberPath="Name"
                  ChipTextColor="White"
                  CloseButtonColor="White"
                  ChipBackground="#512dcd" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ChipBackground = Color.FromArgb("#512dcd"),
    ChipTextColor = Colors.White,
    CloseButtonColor = Colors.White
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
this.Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with ChipBackground](images/customization-images/chipgroup_chipbackgroundcolor_image.png)

To customize the background color of the **selected** chip, set `ChipType="Choice"` or `ChipType="Filter"` and use the `VisualStateManager`:

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  DisplayMemberPath="Name"
                  ChipType="Choice">
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroup x:Name="CommonStates">
            <VisualState x:Name="Normal">
                <VisualState.Setters>
                    <Setter Property="ChipBackground" Value="White" />
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Selected">
                <VisualState.Setters>
                    <Setter Property="ChipBackground" Value="#502cd5" />
                </VisualState.Setters>
            </VisualState>
        </VisualStateGroup>
    </VisualStateManager.VisualStateGroups>
</chip:SfChipGroup>

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ChipType = SfChipsType.Choice
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");

var visualStateGroupList = new VisualStateGroupList();
var commonStateGroup = new VisualStateGroup();

var normalState = new VisualState { Name = "Normal" };
normalState.Setters.Add(new Setter { Property = SfChipGroup.ChipBackgroundProperty, Value = Colors.White });

var selectedState = new VisualState { Name = "Selected" };
selectedState.Setters.Add(new Setter { Property = SfChipGroup.ChipBackgroundProperty, Value = Color.FromArgb("#502cd5") });

commonStateGroup.States.Add(normalState);
commonStateGroup.States.Add(selectedState);
visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(chipGroup, visualStateGroupList);
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with SelectedChipBackground](images/customization-images/chipgroup_chipbackground_image.png)

### SelectedChipBackground

The [`SelectedChipBackground`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectedChipBackground) property customizes the background color of the selected chips in `Filter` and `Choice` `ChipType` values, without using a `VisualState`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  DisplayMemberPath="Name"
                  ChipTextColor="White"
                  ChipBackground="#512dcd"
                  ChipType="Filter"
                  SelectedChipBackground="#E8DEF8" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ChipBackground = Color.FromArgb("#512dcd"),
    ChipTextColor = Colors.White,
    ChipType = SfChipsType.Filter,
    SelectedChipBackground = Color.FromArgb("#E8DEF8")
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with SelectedChipBackground](images/customization-images/chipgroup_selectedchipbackgroundcolor_image.png)

### ChipTextColor

The [`ChipTextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipTextColor) property customizes the text color of the unselected chips in `SfChipGroup`. The default value is `Color.FromArgb("#1C1B1F")`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  DisplayMemberPath="Name"
                  ChipTextColor="Red" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ChipTextColor = Colors.Red
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with ChipTextColor](images/customization-images/chipgroup_chiptextcolor_image.png)

To customize the text color of the **selected** chip, set `ChipType="Choice"` or `ChipType="Filter"` and use the `VisualStateManager`:

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  DisplayMemberPath="Name"
                  ChipType="Choice">
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroup x:Name="CommonStates">
            <VisualState x:Name="Normal">
                <VisualState.Setters>
                    <Setter Property="ChipTextColor" Value="Black" />
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Selected">
                <VisualState.Setters>
                    <Setter Property="ChipTextColor" Value="Green" />
                </VisualState.Setters>
            </VisualState>
        </VisualStateGroup>
    </VisualStateManager.VisualStateGroups>
</chip:SfChipGroup>

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ChipType = SfChipsType.Choice
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");

var visualStateGroupList = new VisualStateGroupList();
var commonStateGroup = new VisualStateGroup();

var normalState = new VisualState { Name = "Normal" };
normalState.Setters.Add(new Setter { Property = SfChipGroup.ChipTextColorProperty, Value = Colors.Black });

var selectedState = new VisualState { Name = "Selected" };
selectedState.Setters.Add(new Setter { Property = SfChipGroup.ChipTextColorProperty, Value = Colors.Green });

commonStateGroup.States.Add(normalState);
commonStateGroup.States.Add(selectedState);
visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(chipGroup, visualStateGroupList);
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with SelectedChipTextColor](images/customization-images/chipgroup_selectedchiptextcolor_image.png)

### SelectedChipTextColor

The [`SelectedChipTextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectedChipTextColor) property customizes the text color of the selected chips in `Filter` and `Choice` `ChipType` values, without using a `VisualState`. The default value is `Color.White`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  DisplayMemberPath="Name"
                  ChipBackground="LightGray"
                  ChipType="Filter"
                  SelectionIndicatorColor="White"
                  SelectedChipBackground="#512dcd"
                  SelectedChipTextColor="White" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ChipBackground = Colors.LightGray,
    ChipType = SfChipsType.Filter,
    SelectionIndicatorColor = Colors.White,
    SelectedChipBackground = Color.FromArgb("#512dcd"),
    SelectedChipTextColor = Colors.White
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with SelectedChipTextColor](images/customization-images/chipgroup_selectedchiptextcolorproperty_image.png)

### ChipStroke

The [`ChipStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipStroke) property customizes the border color of the chips in `SfChipGroup`. The default value is `Color.FromArgb("#79747E")`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  DisplayMemberPath="Name"
                  ChipStroke="Red"
                  ChipBackground="LightYellow" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ChipStroke = Colors.Red,
    ChipBackground = Colors.LightYellow
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with ChipStroke](images/customization-images/chipgroup_chipstroke_image.png)

### ChipTextSize

The [`ChipTextSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipTextSize) property customizes the text size of the chips in `SfChipGroup`. The default value is `14d`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  DisplayMemberPath="Name"
                  ChipTextSize="10" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ChipTextSize = 10
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with ChipTextSize](images/customization-images/chipgroup_chiptextsize_image.png)

### ChipFontAttributes

The `ChipFontAttributes` property customizes the font style of the chip text in `SfChipGroup`. The default value is `FontAttributes.None`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  DisplayMemberPath="Name"
                  ChipFontAttributes="Bold"
                  ChipType="Choice" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ChipType = SfChipsType.Choice,
    ChipFontAttributes = FontAttributes.Bold
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with ChipFontAttributes](images/customization-images/chipgroup_chipfontattribute_image.png)

### ChipFontFamily

The [`ChipFontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipFontFamily) property customizes the font family of the chip text in `SfChipGroup`. The default value is `string.Empty`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  DisplayMemberPath="Name"
                  ChipFontFamily="OpenSans-Semibold" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ChipFontFamily = "OpenSans-Semibold"
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with ChipFontFamily](images/customization-images/chipgroup_chipfontfamily-image.png)

### ChipPadding

The [`ChipPadding`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipPadding) property sets the spacing between each chip in `SfChipGroup`. The default value is `new Thickness(5d, 0, 0, 0)`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  DisplayMemberPath="Name"
                  ChipPadding="8,0,0,0" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    ChipPadding = new Thickness(8, 0, 0, 0),
    DisplayMemberPath = "Name"
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with ChipPadding](images/customization-images/chipgroup_chippadding_image.png)

### ChipStrokeThickness

The [`ChipStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipStrokeThickness) property customizes the border width of the chips in `SfChipGroup`. The default value is `2d`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  ChipStrokeThickness="7"
                  DisplayMemberPath="Name"
                  ChipStroke="Red" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    ChipStrokeThickness = 7,
    DisplayMemberPath = "Name",
    ChipStroke = Colors.Red
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with ChipStrokeThickness](images/customization-images/chipgroup_chipstrokethickness_image.png)

### ChipLayout

The `SfChipGroup` creates a chip for each item and arranges the chips in a `StackLayout` with horizontal orientation by default. Use the `ChipLayout` property to provide a custom layout (such as a `FlexLayout`) for the chips.

{% tabs %}
{% highlight xaml %}

<ContentPage.Content>
    <Grid>
        <chip:SfChipGroup DisplayMemberPath="Name" ItemsSource="{Binding Employees}">
            <chip:SfChipGroup.ChipLayout>
                <FlexLayout HorizontalOptions="Start"
                            VerticalOptions="Center" />
            </chip:SfChipGroup.ChipLayout>
        </chip:SfChipGroup>
    </Grid>
</ContentPage.Content>

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

namespace ChipsSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var layout = new FlexLayout
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Center
        };

        var chipGroup = new SfChipGroup
        {
            DisplayMemberPath = "Name",
            ChipLayout = layout
        };
        BindingContext = new EmployeeViewModel();
        chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");

        Content = new Grid
        {
            Children = { chipGroup }
        };
    }
}

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

### ItemHeight

The [`ItemHeight`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemHeight) property customizes the height of the items in `SfChipGroup`. The default value is `double.NaN` (the chip uses its measured height).

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  ItemHeight="60"
                  DisplayMemberPath="Name" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

BindingContext = new EmployeeViewModel();
SfChipGroup chipGroup = new SfChipGroup
{
    ItemHeight = 60,
    DisplayMemberPath = "Name"
};
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with ItemHeight](images/customization-images/chipgroup_itemheight_image.png)

### ShowIcon

The [`ShowIcon`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ShowIcon) property specifies whether the image set in `ImageMemberPath` is displayed on the chips in `SfChipGroup`. The default value is `false`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  ChipPadding="8,8,0,0"
                  ImageMemberPath="Image"
                  ChipImageSize="30"
                  ShowIcon="True"
                  DisplayMemberPath="Name" />

{% endhighlight %}
{% endtabs %}

### Model and ViewModel for the ShowIcon sample

{% tabs %}
{% highlight c# %}

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ChipsSample;

public class Person
{
    public string Name { get; set; }
    public string Image { get; set; }
}

public class ChipsViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Person> employees;

    public ObservableCollection<Person> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public ChipsViewModel()
    {
        Employees = new ObservableCollection<Person>
        {
            new Person { Image = "jhon.png", Name = "John" },
            new Person { Image = "james.png", Name = "James" },
            new Person { Image = "alexandar.png", Name = "Alexandar" },
            new Person { Image = "liam.png", Name = "Liam" }
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ImageMemberPath = "Image",
    ChipImageSize = 30,
    ShowIcon = true,
    ChipPadding = new Thickness(8, 8, 0, 0)
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");

{% endhighlight %}
{% endtabs %}

![SfChipGroup with ShowIcon](images/customization-images/chipgroup_showicon_image.png)

### CloseButtonColor

The [`CloseButtonColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_CloseButtonColor) property customizes the color of the close button in `SfChipGroup`. The default value is `Color.FromArgb("#49454E")`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  CloseButtonColor="Red"
                  ChipBackground="LightYellow"
                  DisplayMemberPath="Name" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    CloseButtonColor = Colors.Red
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with CloseButtonColor](images/customization-images/chipgroup_closebuttoncolor_image.png)

### SelectionIndicatorColor

The [`SelectionIndicatorColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionIndicatorColor) property customizes the selection indicator color in `SfChipGroup`. The default value is `Color.FromRgb(30, 25, 43)`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup x:Name="sfChipGroup"
                  ItemsSource="{Binding Employees}"
                  SelectionIndicatorColor="White"
                  DisplayMemberPath="Name" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    SelectionIndicatorColor = Colors.White
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}
{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with SelectionIndicatorColor](images/customization-images/chipgroup_selectionindicatorcolor_image.png)

### ChipImageSize

The [`ChipImageSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipImageSize) property customizes the size of the icon image in `SfChipGroup`. The default value is `18d`.

{% tabs %}
{% highlight xaml %}

<chip:SfChipGroup ItemsSource="{Binding Employees}"
                  ImageMemberPath="Image"
                  ChipImageSize="50"
                  ShowIcon="True"
                  DisplayMemberPath="Name" />

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

SfChipGroup chipGroup = new SfChipGroup
{
    DisplayMemberPath = "Name",
    ImageMemberPath = "Image",
    ChipImageSize = 50,
    ShowIcon = true
};
BindingContext = new EmployeeViewModel();
chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
Content = chipGroup;

{% endhighlight %}

{% highlight Model & ViewModel %}

public class Employee
{
    public string Name { get; set; }
}

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Employee> Employees
    {
        get => employees;
        set
        {
            employees = value;
            OnPropertyChanged();
        }
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee { Name = "Joseph" },
            new Employee { Name = "Anne Joseph" },
            new Employee { Name = "Andrew Fuller" },
            new Employee { Name = "Emilio Alvaro" },
            new Employee { Name = "Janet Leverling" }
        };
    }

    public void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

{% endhighlight %}
{% endtabs %}

![SfChipGroup with ChipImageSize](images/customization-images/chipgroup_chipimagesize_image.png)


### IsSelected

The [`IsSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_IsSelected) property of `SfChip` indicates whether a chip is selected in the `Choice` and `Filter` `ChipType` values. Set `IsSelected="True"` to mark a chip as selected by default.

## Compatibility

| Platform | Notes |
|----------|-------|
| .NET MAUI | Requires .NET MAUI 7.0 or later. |
| iOS, macOS, Android, Windows | `SfChip` and `SfChipGroup` are supported on all .NET MAUI target platforms. |

## Troubleshooting

| Issue | Possible cause | Fix |
|------|---------------|-----|
| The chip group is empty on the page. | The `BindingContext` is not set, or `Employees` is empty. | Set `BindingContext` to the ViewModel and populate the collection. |
| The image does not appear on the chip. | `ShowIcon` is `false`, or the image is not registered as a `MauiImage`. | Set `ShowIcon="True"` and add the image to `Resources/Images` with a `MauiImage` entry in the `.csproj`. |
| The custom `ChipLayout` is not applied. | The `ChipLayout` property was assigned after the chips were generated. | Assign `ChipLayout` before adding the chip group to the visual tree, or call the appropriate reset method. |
| The `Command` does not fire. | The binding path is wrong, or the `Command` is `null` on the ViewModel. | Verify the binding path and that the ViewModel exposes a public `ICommand` property. |
| The selected-chip color does not change. | `ChipType` is not `Choice` or `Filter`, or the `VisualStateManager` is not attached. | Set `ChipType="Choice"` or `ChipType="Filter"`, and use either a `VisualState` or the `SelectedChipBackground`/`SelectedChipTextColor` properties. |
| `Colors.X` errors out in C# with a string color. | `Colors.X` only accepts the named-color constants; use `Color.FromArgb("#...")` for custom colors. | Use `Color.FromArgb("#512dcd")` for the literal hex value, or `Colors.Red` for the named color. |

## See Also

- [Getting Started](Getting-Started.md)
- [Chips Types](Chips-Types.md)
- [Events](Events.md)



