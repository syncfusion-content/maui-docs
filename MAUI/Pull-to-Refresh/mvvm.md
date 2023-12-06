---
layout: post
title: Working with MVVM in .NET MAUI PullToRefresh control | Syncfusion
description: Learn about working with MVVM support in Syncfusion .NET MAUI PullToRefresh (SfPullToRefresh) control and more.
platform: MAUI
control: SfPullToRefresh 
documentation: ug
---

# How to refresh the .NET MAUI SfPullToRefresh from ViewModel

`SfPullToRefresh` is fully MVVM compatible and can be refreshed by binding a property in the view model to the `SfPullToRefresh.IsRefreshing` property.
`SfPullToRefresh` also provides support for `SfPullToRefresh.RefreshCommand` that will be executed when the pulling is completed and the pointer is released.  You can also pass a desired object as parameter to the SfPullToRefresh.RefreshCommand using the `SfPullToRefresh.RefreshCommandParameter`.
The `CanExecute()` method of `SfPullToRefresh.RefreshCommand` will be fired when the pulling action is performed. Returning `false` in the command's CanExecute() will cancel the pulling and the SfPullToRefresh.RefreshCommand will not be executed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="13 15" %}

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
                                        RefreshCommand="{Binding RefreshCommand}">
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

    public class ViewModel : INotifyPropertyChanged
    {
        private bool isRefreshing;
        public ICommand RefreshCommand { get; set; }

        public bool IsRefreshing
        {
            get
            {
                return isRefreshing;
            }
            set
            {
                isRefreshing = value;
                RaisePropertyChanged(nameof(IsRefreshing));
            }
        }

        public ViewModel()
        {
            RefreshCommand = new Command(Refresh);
        }

        async private void Refresh(object obj)
        {
            IsRefreshing = true;
            await Task.Delay(1000);
            IsRefreshing = false;
            int index = random.Next(0, 6);
            Temperature = temperatureArray[index];
        }
    }

{% endhighlight %}
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/refresh-command-binding-using-mvvm-in-.net-maui-pull-to-refresh).