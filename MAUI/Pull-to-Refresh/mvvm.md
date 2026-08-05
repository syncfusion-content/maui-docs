---
layout: post
title: Working with MVVM in .NET MAUI PullToRefresh control | Syncfusion®
description: Learn about working with MVVM support in Syncfusion® .NET MAUI PullToRefresh (SfPullToRefresh) control and more.
platform: MAUI
control: SfPullToRefresh
documentation: ug
---

# How to Refresh the .NET MAUI SfPullToRefresh from a ViewModel

[SfPullToRefresh](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html) is fully MVVM-compatible and can be refreshed by binding a property in the view model to the [SfPullToRefresh.IsRefreshing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_IsRefreshing) property.

`SfPullToRefresh` also provides support for the [SfPullToRefresh.RefreshCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshCommand), which is executed when the pull gesture is released after reaching the refresh threshold. You can pass a parameter to the command through the [SfPullToRefresh.RefreshCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshCommandParameter) property.

To conditionally allow or prevent refresh operations, you can provide a `CanExecute` delegate when creating the command. If `CanExecute` returns `false`, the refresh operation is canceled and the command is not executed.

The following example demonstrates:

* Binding `IsRefreshing` to the view model.
* Updating the UI through `INotifyPropertyChanged`.
* Using `RefreshCommandParameter`.
* Using a `CanExecute` method with `RefreshCommand`.
* Updating a bound `Temperature` property after the refresh operation completes..

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14 15 16" %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="RefreshCommand.MainPage"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh"
             xmlns:local="clr-namespace:RefreshCommand">

    <ContentPage.BindingContext>
        <local:ViewModel />
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfPullToRefresh x:Name="pullToRefresh"
                                    IsRefreshing="{Binding IsRefreshing}"
                                    PullingThreshold="100"
                                    RefreshCommand="{Binding RefreshCommand}"
                                    RefreshCommandParameter="NewYork">

            <syncfusion:SfPullToRefresh.PullableContent>
                <StackLayout BackgroundColor="#00AFF9"
                             Orientation="Vertical">

                    <Label Text="New York Temperature"
                           FontSize="Large"
                           TextColor="White"
                           Margin="20" />

                    <Label Text="{Binding Temperature}"
                           FontSize="Large"
                           TextColor="White"
                           Margin="20"
                           HeightRequest="100" />

                </StackLayout>
            </syncfusion:SfPullToRefresh.PullableContent>

        </syncfusion:SfPullToRefresh>
    </ContentPage.Content>

</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="ViewModel.cs" %}

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace RefreshCommand
{
    public class ViewModel : INotifyPropertyChanged
    {
        private bool isRefreshing;
        private string temperature;

        private readonly Random random = new Random();

        private readonly string[] temperatureArray =
        {
            "18°C",
            "20°C",
            "22°C",
            "24°C",
            "26°C",
            "28°C"
        };

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand RefreshCommand { get; set; }

        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                if (isRefreshing == value)
                    return;

                isRefreshing = value;
                RaisePropertyChanged();
                ((Command)RefreshCommand).ChangeCanExecute();
            }
        }

        public string Temperature
        {
            get => temperature;
            set
            {
                if (temperature == value)
                    return;

                temperature = value;
                RaisePropertyChanged();
            }
        }

        public ViewModel()
        {
            Temperature = temperatureArray[0];

            RefreshCommand = new Command(
                execute: async (obj) => await Refresh(obj),
                canExecute: CanRefresh);
        }

        private bool CanRefresh(object obj)
        {
            return !IsRefreshing;
        }

        private async Task Refresh(object obj)
        {
            IsRefreshing = true;
            await Task.Delay(1000);
            int index = random.Next(0, temperatureArray.Length);
            Temperature = temperatureArray[index];
            IsRefreshing = false;
        }

        protected virtual void RaisePropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}

{% endhighlight %}

{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/refresh-command-binding-using-mvvm-in-.net-maui-pull-to-refresh).
### How it works

1. The `IsRefreshing` property is bound to `SfPullToRefresh.IsRefreshing`.
2. When the user performs a pull-to-refresh gesture and releases it after reaching the threshold, `RefreshCommand` is executed.
3. The value specified in `RefreshCommandParameter` is passed to the command through the `obj` parameter.
4. The `Temperature` property is updated after the asynchronous refresh operation completes.
5. The `PropertyChanged` event notifies the UI whenever `Temperature` or `IsRefreshing` changes.
6. `IsRefreshing` is set to `false` in the `finally` block after the refresh work completes, ensuring that the refresh indicator is stopped correctly.
7. `CanRefresh` prevents additional refresh requests while a refresh operation is already running.
