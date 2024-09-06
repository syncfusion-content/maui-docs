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
{% highlight xaml hl_lines="159" %}

     <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="headerTemplate">
                <VerticalStackLayout Padding="0,23,0,0">
                    <Grid RowDefinitions="30,30,Auto" RowSpacing="10">
                        <HorizontalStackLayout HorizontalOptions="Center">
                            <Border Stroke="#CAC4D0" VerticalOptions="Center" BackgroundColor="LightBlue"  HeightRequest="30" WidthRequest="30">
                                <Border.StrokeShape>
                                    <RoundRectangle CornerRadius="6"/>
                                </Border.StrokeShape>
                                <Image Source="ai.png" HorizontalOptions="Center" />
                            </Border>
                            <Label Text="AssistView" TextColor="Black" FontFamily="Bold" FontSize="20" VerticalOptions="Center" Padding="10,0,0,0"/>
                        </HorizontalStackLayout>
                        <Label Grid.Row="1" Text="Your everyday AI Companion" HorizontalOptions="Center" FontFamily="Roboto-Regular" FontSize="16"/>

                        <Grid Grid.Row="2" Margin="8,0,8,0">
                            <listview:SfListView x:Name="headerlayout" ItemSpacing="5" ItemSize="328" HeightRequest="250" Orientation="Horizontal" ScrollBarVisibility="Never" ItemsSource="{Binding Path=HeaderInfoCollection}">
                                <listview:SfListView.Behaviors>
                                    <local:ListViewBehavior/>
                                </listview:SfListView.Behaviors>
                                <listview:SfListView.ItemTemplate>
                                    <DataTemplate>
                                        <Grid RowDefinitions="*,Auto,10">
                                            <Grid.GestureRecognizers>
                                                <TapGestureRecognizer Command="{Binding Path=BindingContext.HeaderItemTappedCommand, Source={x:Reference headerlayout}}" CommandParameter="{x:Reference label}"/>
                                            </Grid.GestureRecognizers>
                                            <Border Grid.RowSpan="2" Stroke="#CAC4D0" WidthRequest="327" HeightRequest="220" HorizontalOptions="Center" VerticalOptions="Center">
                                                <Border.StrokeShape>
                                                    <RoundRectangle CornerRadius="15"/>
                                                </Border.StrokeShape>
                                                <Image Source="{Binding Image}" Aspect="AspectFill" HeightRequest="220" VerticalOptions="Center" WidthRequest="325" HorizontalOptions="Center"/>
                                            </Border>
                                            <Border Grid.Row="1" Grid.RowSpan="2" BackgroundColor="#FFFBFE" Stroke="#CAC4D0"  Opacity="0.8" HorizontalOptions="Center" VerticalOptions="End" WidthRequest="300">
                                                <Border.StrokeShape>
                                                    <RoundRectangle CornerRadius="12"/>
                                                </Border.StrokeShape>
                                                <Label x:Name="label" Text="{Binding HeaderMessage}" FontFamily="Roboto-Regular" TextColor="Black" LineBreakMode="WordWrap" FontSize="14" Padding="10" HorizontalOptions="Center" VerticalOptions="End" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
                                            </Border>
                                        </Grid>
                                    </DataTemplate>
                                </listview:SfListView.ItemTemplate>
                            </listview:SfListView>
                            <Grid Grid.Row="2" HorizontalOptions="Start" VerticalOptions="Center" >
                                <Grid.GestureRecognizers>
                                    <TapGestureRecognizer Command="{Binding Path=BindingContext.PreviousItemCommand, Source={x:Reference headerlayout}}" CommandParameter="{x:Reference headerlayout}"/>
                                </Grid.GestureRecognizers>
                                <Border Padding="0,0,2,0" Background="White" Stroke="#CAC4D0" >
                                    <Border.StrokeShape>
                                        <RoundRectangle CornerRadius="20"/>
                                    </Border.StrokeShape>
                                    <Image Source="previous_item.png" HorizontalOptions="Center" HeightRequest="25" VerticalOptions="Center" >
                                    </Image>
                                </Border>
                            </Grid>

                            <Grid Grid.Row="2"  HorizontalOptions="End" VerticalOptions="Center">
                                <Grid.GestureRecognizers>
                                    <TapGestureRecognizer Command="{Binding Path=BindingContext.NextItemCommand, Source={x:Reference headerlayout}}" CommandParameter="{x:Reference headerlayout}"/>
                                </Grid.GestureRecognizers>
                                <Border Padding="2,0,0,0" Background="White" Stroke="#CAC4D0">
                                    <Border.StrokeShape>
                                        <RoundRectangle CornerRadius="20"/>
                                    </Border.StrokeShape>
                                    <Image Source="next_item.png" HeightRequest="25" VerticalOptions="Center" HorizontalOptions="Center" >
                                    </Image>
                                </Border>
                            </Grid>
                        </Grid>
                    </Grid>
                </VerticalStackLayout>
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
                            <BindableLayout.ItemTemplate>
                                <DataTemplate>
                                    <Grid Margin="2"
                                          Padding="2">
                                        <Grid RowDefinitions="*"
                                              ColumnDefinitions="auto,auto,auto">
                                            <Border 
                                                    
                                                    Opacity="0.8"
                                                    HorizontalOptions="Center"
                                                    VerticalOptions="End"
                                                    Grid.Row="0">

                                                <Border.GestureRecognizers>
                                                    <TapGestureRecognizer Command="{Binding Source={RelativeSource AncestorType={x:Type ScrollView}}, Path=BindingContext.ToggleSelectionCommand}"
                                                                          CommandParameter="{Binding .}" />
                                                </Border.GestureRecognizers>
                                                <Border.StrokeShape>
                                                    <RoundRectangle CornerRadius="10" />
                                                </Border.StrokeShape>
                                                <Label x:Name="label"
                                                       Text="{Binding ToneContent}"
                                                       Background="{Binding IsSelected, Converter={StaticResource colorConverter}}"
                                                       FontFamily="Roboto-Regular"
                                                       FontSize="14"
                                                       Padding="7"
                                                       HorizontalOptions="Center"
                                                       HorizontalTextAlignment="Center"
                                                       VerticalTextAlignment="Center"
                                                       TextColor="{Binding IsSelected, Converter={StaticResource textColorConverter}}">
                                                </Label>
                                            </Border>
                                        </Grid>
                                    </Grid>
                                </DataTemplate>
                            </BindableLayout.ItemTemplate>
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
                            <BindableLayout.ItemTemplate>
                                <DataTemplate>
                                    <Grid Margin="2"
                                          Padding="2">
                                        <!-- Define the rows with appropriate heights -->
                                        <Grid.RowDefinitions>
                                            <RowDefinition Height="60" />
                                            <!-- Height for the image -->
                                            <RowDefinition Height="30" />
                                            <!-- Height for the label -->
                                        </Grid.RowDefinitions>
                                        <Grid.ColumnDefinitions>
                                            <ColumnDefinition Width="Auto" />
                                            <ColumnDefinition Width="Auto" />
                                            <ColumnDefinition Width="Auto" />
                                            <ColumnDefinition Width="Auto" />

                                        </Grid.ColumnDefinitions>
                                        <!-- Image Border -->
                                        <Border WidthRequest="60"
                                                HeightRequest="60"
                                                HorizontalOptions="Center"
                                                Background="#F6EDFF"
                                                Stroke="{Binding IsSelected, Converter={StaticResource colorConverter}}">
                                            <Border.GestureRecognizers>
                                                <TapGestureRecognizer Command="{Binding Source={RelativeSource AncestorType={x:Type ScrollView}}, Path=BindingContext.FormatModelSelectionChangedCommand}"
                                                                      CommandParameter="{Binding .}" />
                                            </Border.GestureRecognizers>
                                            <Border.StrokeShape>
                                                <RoundRectangle CornerRadius="12" />
                                            </Border.StrokeShape>
                                            <Image Source="{Binding Images}"
                                                   HeightRequest="30"
                                                   WidthRequest="30"
                                                   HorizontalOptions="Center"/>
                                        </Border>

                                        <Label Text="{Binding Content}"
                                               Grid.Row="1"
                                               x:Name="label"
                                               FontFamily="Roboto-Regular"
                                               FontSize="12"
                                               HorizontalOptions="Center"
                                               HorizontalTextAlignment="Center"
                                               VerticalTextAlignment="Center"/>

                                    </Grid>
                                </DataTemplate>
                            </BindableLayout.ItemTemplate>
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
                            <BindableLayout.ItemTemplate>
                                <DataTemplate>
                                    <Grid Margin="2"
                                          Padding="2">
                                        <Grid RowDefinitions="35"
                                              ColumnDefinitions="auto,auto,auto">

                                            <Border 
                                                    Opacity="0.8"
                                                    HorizontalOptions="Center"
                                                    VerticalOptions="End"
                                                    Grid.Row="0">
                                                <Border.GestureRecognizers>
                                                    <TapGestureRecognizer Command="{Binding Source={RelativeSource AncestorType={x:Type ScrollView}}, Path=BindingContext.LengthModelSelectionChangedCommand}"
                                                                          CommandParameter="{Binding .}" />
                                                </Border.GestureRecognizers>
                                                <Border.StrokeShape>
                                                    <RoundRectangle CornerRadius="10" />
                                                </Border.StrokeShape>
                                                <Label Text="{Binding LengthContent}"
                                                       x:Name="label"
                                                       Background="{Binding IsSelected, Converter={StaticResource colorConverter}}"
                                                       FontFamily="Roboto-Regular"
                                                       FontSize="14"
                                                       Padding="7"
                                                       HorizontalOptions="Center"
                                                       HorizontalTextAlignment="Center"
                                                       VerticalTextAlignment="Center"
                                                       TextColor="{Binding IsSelected, Converter={StaticResource textColorConverter}}"/>
                                            </Border>
                                        </Grid>
                                    </Grid>
                                </DataTemplate>
                            </BindableLayout.ItemTemplate>
                        </FlexLayout>
                    </StackLayout>
                </Border>
            </Grid>
        </Border>
    </StackLayout>

{% endhighlight %}
{% endtabs %}

![Control template in .NET MAUI AI Assist View](Images/maui-aiassistview-control-template.png)