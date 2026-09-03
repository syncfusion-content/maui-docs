---
layout: post
title: Migrate Syncfusion® Xamarin Controls and NuGet Packages to .NET MAUI | Syncfusion®
description: Learn how to map Syncfusion Xamarin.Forms controls and NuGet packages to their .NET MAUI equivalents.
platform: MAUI
control: Common
documentation: UG
---

# Migrate Syncfusion® Xamarin Controls and NuGet Packages to .NET MAUI

Syncfusion® Essential Studio® ships a dedicated .NET MAUI suite that replaces the legacy Xamarin.Forms controls. Every Xamarin control has a direct .NET MAUI equivalent under the **Syncfusion.Maui.*** namespace, delivered through standalone NuGet packages. The following table consolidates the control-to-NuGet mapping for every supported Xamarin control and its .NET MAUI counterpart. Use the **NuGet** column to add the package via the [Package Manager UI](https://help.syncfusion.com/maui/installation/install-nuget-packages), the dotnet CLI, or the Package Manager Console.

## Control and NuGet package mapping

| Xamarin control | Xamarin NuGet package | MAUI equivalent control | MAUI NuGet package |
|---|---|---|---|
| SfAccordion | Syncfusion.Xamarin.Expander | [SfAccordion](/maui/Accordion/overview) | [Syncfusion.Maui.Expander](https://www.nuget.org/packages/Syncfusion.Maui.Expander) |
| SfAutoComplete | Syncfusion.Xamarin.SfAutoComplete | [SfAutoComplete](/maui/Autocomplete/Overview) | [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) |
| SfAvatarView | Syncfusion.Xamarin.Core | [SfAvatarView](/maui/Avatar-view/Overview) | [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) |
| SfBackdropPage | Syncfusion.Xamarin.SfBackdrop | [SfBackdropPage](/maui/Backdrop/overview) | [Syncfusion.Maui.Backdrop](https://www.nuget.org/packages/Syncfusion.Maui.Backdrop) |
| SfBadgeView | Syncfusion.Xamarin.SfBadgeView | [SfBadgeView](/maui/Badge-View/Overview) | [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) |
| SfBarcode | Syncfusion.Xamarin.SfBarcode | [SfBarcodeGenerator](/maui/Barcode-Generator/overview) | [Syncfusion.Maui.Barcode](https://www.nuget.org/packages/Syncfusion.Maui.Barcode) |
| SfBorder | Syncfusion.Xamarin.Core | Obsolete. Use Border | – |
| SfButton | Syncfusion.Xamarin.Buttons | [SfButton](/maui/Button/Overview) | [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons) |
| SfBusyIndicator | Syncfusion.Xamarin.SfBusyIndicator | [SfBusyIndicator](/maui/busy-indicator/overview) | [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) |
| SfCalendar | Syncfusion.Xamarin.SfCalendar | [SfCalendar](/maui/calendar/overview) | [Syncfusion.Maui.Calendar](https://www.nuget.org/packages/Syncfusion.Maui.Calendar) |
| SfCardView | Syncfusion.Xamarin.Cards | [SfCards](/maui/Cards/Overview) | [Syncfusion.Maui.Cards](https://www.nuget.org/packages/Syncfusion.Maui.Cards) |
| SfCarousel | Syncfusion.Xamarin.SfCarousel | [SfCarousel](/maui/carousel-view/overview) | [Syncfusion.Maui.Carousel](https://www.nuget.org/packages/Syncfusion.Maui.Carousel) |
| SfChart | Syncfusion.Xamarin.SfChart | [SfCartesianChart](/maui/cartesian-charts/overview)<br>[SfCircularChart](/maui/circular-charts/overview)<br>[SfFunnelChart](/maui/funnel-charts/overview)<br>[SfPolarChart](/maui/polar-charts/Overview)<br>[SfPyramidChart](/maui/pyramid-charts/overview) | [Syncfusion.Maui.Charts](https://www.nuget.org/packages/Syncfusion.Maui.Charts) |
| SfChat | Syncfusion.Xamarin.SfChat | [SfChat](/maui/Chat/overview) | [Syncfusion.Maui.Chat](https://www.nuget.org/packages/Syncfusion.Maui.Chat) |
| SfCheckBox | Syncfusion.Xamarin.Buttons | [SfCheckBox](/maui/CheckBox/Overview) | [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons) |
| SfChips | Syncfusion.Xamarin.Buttons | [SfChip, SfChipGroup](/maui/Chips/Overview) | [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) |
| SfCircularGauge | Syncfusion.Xamarin.SfGauge | [SfRadialGauge](/maui/Radial-Gauge/overview) | [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges) |
| SfCircularProgressBar | Syncfusion.Xamarin.SfProgressBar | [SfCircularProgressBar](/maui/CircularProgressBar/overview) | [Syncfusion.Maui.ProgressBar](https://www.nuget.org/packages/Syncfusion.Maui.ProgressBar) |
| SfComboBox | Syncfusion.Xamarin.SfComboBox | [SfComboBox](/maui/ComboBox/Overview) | [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) |
| SfDataForm | Syncfusion.Xamarin.SfDataForm | [SfDataForm](/maui/DataForm/Overview) | [Syncfusion.Maui.DataForm](https://www.nuget.org/packages/Syncfusion.Maui.DataForm) |
| SfDataGrid | Syncfusion.Xamarin.SfDataGrid | [SfDataGrid](/maui/DataGrid/overview) | [Syncfusion.Maui.DataGrid](https://www.nuget.org/packages/Syncfusion.Maui.DataGrid) |
| SfDatePicker | Syncfusion.Xamarin.SfPicker | [SfDatePicker](/maui/DatePicker/overview) | [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker) |
| SfDateTimePicker | Syncfusion.Xamarin.SfPicker | [SfDateTimePicker](/maui/DateTimePicker/overview) | [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker) |
| SfDateTimeRangeNavigator | Syncfusion.Xamarin.SfChart | [SfDateTimeRangeSlider](/maui/DateTime-Range-Slider/overview) | [Syncfusion.Maui.Sliders](https://www.nuget.org/packages/Syncfusion.Maui.Sliders) |
| SfDiagram | Syncfusion.Xamarin.SfDiagram | Obsolete. Use Syncfusion® Blazor Diagram. | – |
| SfDigitalGauge | Syncfusion.Xamarin.SfGauge | [SfDigitalGauge](/maui/digitalgauge/overview) | [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges) |
| SfEffectsView | Syncfusion.Xamarin.Core | [SfEffectsView](/maui/Effects-View/Overview) | [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) |
| SfExpander | Syncfusion.Xamarin.Expander | [SfExpander](/maui/Expander/overview) | [Syncfusion.Maui.Expander](https://www.nuget.org/packages/Syncfusion.Maui.Expander) |
| SfGradientView | Syncfusion.Xamarin.Core | Obsolete. Use Gradients | – |
| SfImageEditor | Syncfusion.Xamarin.SfImageEditor | [SfImageEditor](/maui/ImageEditor/overview) | [Syncfusion.Maui.ImageEditor](https://www.nuget.org/packages/Syncfusion.Maui.ImageEditor) |
| SfKanban | Syncfusion.Xamarin.SfKanban | [SfKanban](/maui/kanban-board/overview) | [Syncfusion.Maui.Kanban](https://www.nuget.org/packages/Syncfusion.Maui.Kanban) |
| SfLinearGauge | Syncfusion.Xamarin.SfGauge | [SfLinearGauge](/maui/Linear-Gauge/overview) | [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges) |
| SfLinearProgressBar | Syncfusion.Xamarin.SfProgressBar | [SfLinearProgressBar](/maui/LinearProgressBar/overview) | [Syncfusion.Maui.ProgressBar](https://www.nuget.org/packages/Syncfusion.Maui.ProgressBar) |
| SfListView | Syncfusion.Xamarin.SfListView | [SfListView](/maui/ListView/overview) | [Syncfusion.Maui.ListView](https://www.nuget.org/packages/Syncfusion.Maui.ListView) |
| SfMaps | Syncfusion.Xamarin.SfMaps | [SfMaps](/maui/Maps/overview) | [Syncfusion.Maui.Maps](https://www.nuget.org/packages/Syncfusion.Maui.Maps) |
| SfMaskedEdit | Syncfusion.Xamarin.SfMaskedEdit | [SfMaskedEntry](/maui/Masked-Entry/Overview) | [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) |
| SfNavigationDrawer | Syncfusion.Xamarin.SfNavigationDrawer | [SfNavigationDrawer](/maui/NavigationDrawer/Overview) | [Syncfusion.Maui.NavigationDrawer](https://www.nuget.org/packages/Syncfusion.Maui.NavigationDrawer) |
| SfNumericTextBox | Syncfusion.Xamarin.SfNumericTextBox | [SfNumericEntry](/maui/NumericEntry/Overview) | [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) |
| SfNumericUpDown | Syncfusion.Xamarin.SfNumericUpDown | [SfNumericEntry](/maui/NumericEntry/Overview) | [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) |
| SfParallaxView | Syncfusion.Xamarin.SfParallaxView | [SfParallaxView](/maui/parallax-view/overview) | [Syncfusion.Maui.ParallaxView](https://www.nuget.org/packages/Syncfusion.Maui.ParallaxView) |
| SfPdfViewer | Syncfusion.Xamarin.SfPdfViewer | [SfPdfViewer](https://help.syncfusion.com/maui/pdf-viewer/getting-started) | [Syncfusion.Maui.PdfViewer](https://www.nuget.org/packages/Syncfusion.Maui.PdfViewer) |
| SfPicker | Syncfusion.Xamarin.SfPicker | [SfPicker](/maui/Picker/overview) | [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker) |
| SfPopUpLayout | Syncfusion.Xamarin.SfPopupLayout | [SfPopup](/maui/Popup/overview) | [Syncfusion.Maui.Popup](https://www.nuget.org/packages/Syncfusion.Maui.Popup) |
| SfPullToRefresh | Syncfusion.Xamarin.SfPullToRefresh | [SfPullToRefresh](/maui/Pull-to-Refresh/overview) | [Syncfusion.Maui.PullToRefresh](https://www.nuget.org/packages/Syncfusion.Maui.PullToRefresh) |
| SfRadioButton | Syncfusion.Xamarin.Buttons | [SfRadioButton](/maui/Radio-Button/Overview) | [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons) |
| SfRadialMenu | Syncfusion.Xamarin.SfRadialMenu | [SfRadialMenu](/maui/Radial-Menu/Overview) | [Syncfusion.Maui.RadialMenu](https://www.nuget.org/packages/Syncfusion.Maui.RadialMenu) |
| SfRangeSlider | Syncfusion.Xamarin.SfRangeSlider | [SfRangeSlider](/maui/Range-Slider/overview) | [Syncfusion.Maui.Sliders](https://www.nuget.org/packages/Syncfusion.Maui.Sliders) |
| SfRating | Syncfusion.Xamarin.SfRating | [SfRating](/maui/Rating/Overview) | [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) |
| SfRotator | Syncfusion.Xamarin.SfRotator | [SfRotator](/maui/Rotator/Overview) | [Syncfusion.Maui.Rotator](https://www.nuget.org/packages/Syncfusion.Maui.Rotator) |
| SfSchedule | Syncfusion.Xamarin.SfSchedule | [SfScheduler](https://help.syncfusion.com/maui/scheduler/getting-started) | [Syncfusion.Maui.Scheduler](https://www.nuget.org/packages/Syncfusion.Maui.Scheduler) |
| SfSegmentedControl | Syncfusion.Xamarin.Buttons | [SfSegmentedControl](/maui/Segmented-Control/overview) | [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons) |
| SfShimmer | Syncfusion.Xamarin.Core | [SfShimmer](/maui/shimmer/overview) | [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) |
| SfSignaturePad | Syncfusion.Xamarin.SfSignaturePad | [SfSignaturePad](/maui/SignaturePad/overview) | [Syncfusion.Maui.SignaturePad](https://www.nuget.org/packages/Syncfusion.Maui.SignaturePad) |
| SfSparkline | Syncfusion.Xamarin.SfSparkline | SfSparkChart - available in Toolkit | [Syncfusion.Maui.Toolkit](https://www.nuget.org/packages/Syncfusion.Maui.Toolkit) |
| SfStepProgressBar | Syncfusion.Xamarin.SfProgressBar | [SfStepProgressBar](/maui/StepProgressBar/overview) | [Syncfusion.Maui.ProgressBar](https://www.nuget.org/packages/Syncfusion.Maui.ProgressBar) |
| SfSunburstChart | Syncfusion.Xamarin.SfSunburstChart | [SfSunburstChart](/maui/SunburstChart/Overview) | [Syncfusion.Maui.SunburstChart](https://www.nuget.org/packages/Syncfusion.Maui.SunburstChart) |
| SfSwitch | Syncfusion.Xamarin.Buttons | [SfSwitch](/maui/Switch/Overview) | [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons) |
| SfTabView | Syncfusion.Xamarin.SfTabView | [SfTabView](/maui/TabView/Overview) | [Syncfusion.Maui.TabView](https://www.nuget.org/packages/Syncfusion.Maui.TabView) |
| SfTextInputLayout | Syncfusion.Xamarin.Core | [SfTextInputLayout](/maui/TextInputLayout/Overview) | [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) |
| SfTimePicker | Syncfusion.Xamarin.SfPicker | [SfTimePicker](/maui/TimePicker/overview) | [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker) |
| SfTreemap | Syncfusion.Xamarin.SfTreeMap | [SfTreeMap](/maui/TreeMap/overview) | [Syncfusion.Maui.TreeMap](https://www.nuget.org/packages/Syncfusion.Maui.TreeMap) |
| SfTreeView | Syncfusion.Xamarin.SfTreeView | [SfTreeView](/maui/TreeView/overview) | [Syncfusion.Maui.TreeView](https://www.nuget.org/packages/Syncfusion.Maui.TreeView) |

## Obsolete controls

The following Xamarin.Forms controls have no direct Syncfusion® .NET MAUI counterpart and are marked as obsolete:

* **SfBorder** - Use the .NET MAUI **Border** element.
* **SfGradientView** - Use .NET MAUI gradients (**LinearGradientBrush**, **RadialGradientBrush**).
* **SfDiagram** - Use Syncfusion® Blazor Diagram hosted in the .NET MAUI application.

## Notes on specific migrations

* **SfChart - multiple chart controls**: The single Xamarin **SfChart** is split into chart-type-specific controls in .NET MAUI - [SfCartesianChart](/maui/cartesian-charts/overview), [SfCircularChart](/maui/circular-charts/overview), [SfFunnelChart](/maui/funnel-charts/overview), [SfPolarChart](/maui/polar-charts/overview), and [SfPyramidChart](/maui/pyramid-charts/overview). All five ship in the same [Syncfusion.Maui.Charts](https://www.nuget.org/packages/Syncfusion.Maui.Charts) package.
* **Several input controls share one package**: [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) hosts [SfAutoComplete](/maui/AutoComplete/Overview), [SfComboBox](/maui/ComboBox/Overview), [SfMaskedEntry](/maui/Masked-Entry/Overview), [SfNumericEntry](/maui/NumericEntry/Overview) (replaces both **SfNumericTextBox** and **SfNumericUpDown**), and [SfRating](/maui/Rating/Overview). Installing this one package covers all of them.
* **Pickers share one package**: [SfDatePicker](/maui/DatePicker/overview), [SfDateTimePicker](/maui/DateTimePicker/overview), [SfTimePicker](/maui/TimePicker/overview), and [SfPicker](/maui/Picker/overview) all ship in [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker).
* **Gauges share one package**: [SfRadialGauge](/maui/Radial-Gauge/overview) (replaces **SfCircularGauge**), [SfLinearGauge](/maui/Linear-Gauge/overview), and [SfDigitalGauge](/maui/DigitalGauge/overview) all ship in [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges).
* **Progress bars share one package**: [SfCircularProgressBar](/maui/CircularProgressBar/overview), [SfLinearProgressBar](/maui/LinearProgressBar/overview), and [SfStepProgressBar](/maui/StepProgressBar/overview) all ship in [Syncfusion.Maui.ProgressBar](https://www.nuget.org/packages/Syncfusion.Maui.ProgressBar).
* **SfSparkline is now Toolkit-only**: The .NET MAUI equivalent, **SfSparkChart**, ships in the [Syncfusion.Maui.Toolkit](https://www.nuget.org/packages/Syncfusion.Maui.Toolkit) package rather than a chart-specific package.
* **Shared package note**: [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) is a shared package used by several lightweight controls ([SfAvatarView](/maui/Avatar-view/Overview), [SfBadgeView](/maui/Badge-View/Overview), [SfBusyIndicator](/maui/busy-indicator/overview), [SfChips](/maui/Chips/Overview), [SfEffectsView](/maui/Effects-View/Overview), [SfShimmer](/maui/shimmer/overview), [SfTextInputLayout](/maui/TextInputLayout/Overview)) - a single install covers them all.

## See also

* [Install Syncfusion MAUI NuGet packages](https://help.syncfusion.com/maui/installation/install-nuget-packages)

* [Syncfusion® .NET MAUI Overview](https://help.syncfusion.com/maui/introduction/overview)


* [Syncfusion® .NET MAUI system requirements](https://help.syncfusion.com/maui/system-requirements)
