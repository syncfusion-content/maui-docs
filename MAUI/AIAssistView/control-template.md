---
layout: post
title: Control Template in .NET MAUI AI Assist View control | Syncfusion
description: Learn here all about Control Template support in Syncfusion .NET MAUI AI Assist View (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Control Template in .NET MAUI AI Assist View (SfAIAssistView)

Using control template with AI Assist View, it allows you to create a highly customized and interactive interface as follows.

{% tabs %}
{% highlight xaml hl_lines="94" %}

     <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="headerTemplate">
                
                ...

            </DataTemplate>
            <local:FontAttributeConverter x:Key="fontAttributeConverter"/>
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.Content>
        <Border x:Name="rootBorder"
         StrokeThickness="{OnPlatform Default=0, WinUI=1, MacCatalyst=1}"
         VerticalOptions="{OnPlatform Default=Fill, WinUI=Center, MacCatalyst=Center}"
         WidthRequest="{OnPlatform WinUI=380, MacCatalyst=400}"
         HeightRequest="{OnPlatform WinUI=500, MacCatalyst=700}"
         HorizontalOptions="{OnPlatform WinUI=Center, MacCatalyst=Center, Default=Fill}">
            <Border.StrokeShape>
                <RoundRectangle CornerRadius="{OnPlatform WinUI=10, MacCatalyst=10}" />
            </Border.StrokeShape>
            <Grid RowDefinitions="50,*">
                <Grid ColumnDefinitions="Auto,Auto,*,Auto,Auto" RowDefinitions="*,1" RowSpacing="5" ColumnSpacing="10" HeightRequest="50">
                    <Grid Grid.Column="0" Padding="10,0,0,0" RowSpacing="1"
                          Grid.Row="0"
                          HeightRequest="30"
                          x:Name="ChatTab" ColumnDefinitions="30,*" RowDefinitions="*,2">
                        <Grid.GestureRecognizers>
                            <TapGestureRecognizer Command="{Binding Path=ChatTappedCommand, Source={x:Reference viewModel}}" CommandParameter="{Binding .}"/>
                        </Grid.GestureRecognizers>
                        <Image  Grid.Column="0" Grid.Row="0"  HeightRequest="20"
                                 Source="chat.png"  />
                        <Label x:Name="chat" 
                               Grid.Column="1"
                               Grid.Row="0"
                               VerticalOptions="Center"
                               FontAttributes="{Binding IsActiveChatView, Converter={StaticResource fontAttributeConverter}}"
                               Text="Chat" />
                        <BoxView Grid.Column="1"
                                 Grid.Row="1"
                                 IsVisible="{Binding IsActiveChatView}"
                                 WidthRequest="20"
                                 HorizontalOptions="Center"/>
                    </Grid>

                    <Grid x:Name="ComposeTab"
                          Grid.Column="1"
                          Grid.Row="0" RowSpacing="1"
                          HeightRequest="30"
                          ColumnDefinitions="30,*"
                          RowDefinitions="*,2">
                        <Grid.GestureRecognizers>
                            <TapGestureRecognizer Command="{Binding Path=ComposeTappedCommand, Source={x:Reference viewModel}}" CommandParameter="{Binding .}"/>
                        </Grid.GestureRecognizers>
                        <Image  Source="compose.png"
                                HeightRequest="20"
                                Grid.Column="0"
                                Grid.Row="0" />
                        <Label x:Name="compose" 
                               Grid.Column="1"
                               Grid.Row="0"
                               VerticalOptions="Center"
                               Text="Compose"
                              FontAttributes="{Binding IsActiveComposeView, Converter={StaticResource fontAttributeConverter}}"/>
                        <BoxView Grid.Column="1"
                       Grid.Row="1"
                       WidthRequest="20"
                       IsVisible="{Binding IsActiveComposeView}"/>
                    </Grid>
                    <Grid Grid.Row="0" Grid.Column="3" Grid.RowSpan="2" HeightRequest="30">
                        <Grid.GestureRecognizers>
                            <TapGestureRecognizer Command="{Binding Path=RefreshCommand}" CommandParameter="{Binding .}"/>
                        </Grid.GestureRecognizers>
                        <Image Source="refresh.png"
                               HorizontalOptions="Center"
                               BackgroundColor="Transparent"
                               HeightRequest="20"
                               VerticalOptions="Center"  />
                    </Grid>

                    <Grid x:Name="close" Grid.Row="0" Grid.Column="4"  HeightRequest="30" Grid.RowSpan="2" Padding="0,0,10,0">
                        <Image Source="close.png"
                               HorizontalOptions="Center"
                               BackgroundColor="Transparent"
                               HeightRequest="20"
                               VerticalOptions="Center"
                               ToolTipProperties.Text="Close Assist Pane" />
                    </Grid>
                    <BoxView Grid.Column="0" Grid.ColumnSpan="5"
                             Grid.Row="1"/>
                </Grid>

                <local:CustomAssistView x:Name="assistView" Grid.Row="1" ShowHeader="{Binding ShowHeader}" ItemCopyCommand="{Binding CopyCommand}" RequestCommand="{Binding AssistViewRequestCommand}" ItemRetryCommand="{Binding RetryCommand}" HeaderTemplate="{StaticResource headerTemplate}" AssistItems="{Binding AssistMessages}">
                    <local:CustomAssistView.ControlTemplate>
                        <ControlTemplate>
                            <ContentView>
                                <ContentView.Content>
                                    <Grid>
                                        <ContentView IsVisible="{Binding IsActiveChatView}" Content="{TemplateBinding AssistChatView}" BindingContext="{TemplateBinding BindingContext}" />
                                        <local:ComposeView  IsVisible="{Binding IsActiveComposeView}" BindingContext="{TemplateBinding BindingContext}"/>
                                        <ActivityIndicator x:Name="Indicator" IsRunning="{Binding ShowIndicator}" BindingContext="{TemplateBinding BindingContext}" VerticalOptions="Center" HorizontalOptions="Center" />
                                    </Grid>
                                </ContentView.Content>
                            </ContentView>
                        </ControlTemplate>
                    </local:CustomAssistView.ControlTemplate>
                </local:CustomAssistView>
            </Grid>
        </Border>
    </ContentPage.Content>
</ContentPage>

//Composeview

    <StackLayout>
        <StackLayout.Resources>
            <ResourceDictionary>
                <local:BoolToColorConverter x:Key="colorConverter" />
                <local:BoolToTextColorConverter x:Key="textColorConverter" />
            </ResourceDictionary>
        </StackLayout.Resources>
        <Border Padding="5"   
                StrokeThickness="0"
                MaximumWidthRequest="{OnPlatform WinUI=380, MacCatalyst=400}">
            <Border.StrokeShape>
                <RoundRectangle CornerRadius="10" />
            </Border.StrokeShape>
            <Border.Margin>
                <OnPlatform x:TypeArguments="thickness:Thickness">
                    <On Platform="MacCatalyst"
                        Value="5" />
                    <On Platform="WinUI"
                        Value="5" />
                </OnPlatform>
            </Border.Margin>
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="auto" />
                    <RowDefinition Height="auto" />
                    <RowDefinition Height="auto" />
                </Grid.RowDefinitions>
                <Border Padding="5"
                        Grid.Row="0"
                        Margin="5"
                        StrokeThickness="1"
                        MaximumWidthRequest="{OnPlatform WinUI=380, MacCatalyst=400}">
                    <Border.StrokeShape>
                        <RoundRectangle CornerRadius="10" />
                    </Border.StrokeShape>
                    <StackLayout Padding="0,5,0,5">
                        <HorizontalStackLayout>
                            <Image Margin="8,4,0,4"
                                   Source="tone.png"
                                   WidthRequest="22"
                                   HeightRequest="20" />
                            <Label Text="Tone" VerticalOptions="End"
                                   Padding="4,4,0,4" />
                        </HorizontalStackLayout>

                        <FlexLayout BindableLayout.ItemsSource="{Binding Path=TonesCollection}"
                                    Wrap="Wrap">
                           
                           ...
                           ...

                        </FlexLayout>
                    </StackLayout>
                </Border>

                <Border Padding="5"
                        Grid.Row="1"
                        Margin="5"
                        StrokeThickness="1"
                        MaximumWidthRequest="{OnPlatform WinUI=380, MacCatalyst=400}">
                    <Border.StrokeShape>
                        <RoundRectangle CornerRadius="10" />
                    </Border.StrokeShape>
                    <StackLayout>
                        <HorizontalStackLayout>
                            <Image Margin="8,4,0,4"
                                   Source="format.png"
                                   WidthRequest="20"
                                   HeightRequest="20" />
                            <Label Text="Format" VerticalOptions="End"
                                   Padding="4,4,0,4" />
                        </HorizontalStackLayout>

                        <FlexLayout BindableLayout.ItemsSource="{Binding Path=FormatModelsCollection}"
                                    Wrap="Wrap">
                           ...
                           ...
                                       
                        </FlexLayout>
                    </StackLayout>
                </Border>

                <Border Padding="5"
                        Grid.Row="2"
                        Margin="5"
                        StrokeThickness="1"
                        MaximumWidthRequest="{OnPlatform WinUI=380, MacCatalyst=400}">
                    <Border.StrokeShape>
                        <RoundRectangle CornerRadius="10" />
                    </Border.StrokeShape>
                    <StackLayout Padding="0,5,0,5">
                        <HorizontalStackLayout>
                            <Image Margin="8,4,0,4"
                                   Source="length.png"
                                   WidthRequest="20"
                                   HeightRequest="20" />
                            <Label Text="Length" VerticalOptions="End"
                                   Padding="4,4,0,4" />
                        </HorizontalStackLayout>

                        <FlexLayout BindableLayout.ItemsSource="{Binding Path=LengthModelsCollection}"
                                    Wrap="Wrap">
                            ...
                            ...

                        </FlexLayout>
                    </StackLayout>
                </Border>
            </Grid>
        </Border>
    </StackLayout>

{% endhighlight %}
{% endtabs %}