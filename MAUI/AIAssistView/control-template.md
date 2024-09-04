---
layout: post
title: Control Template in .NET MAUI AI Assist View control | Syncfusion
description: Learn here all about Control Template support in Syncfusion .NET MAUI AI Assist View (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Control Template in .NET MAUI AI Assist View (SfAIAssistView)

Using control template with AI Assist View, it allows you to create a highly customized and interactive interface a follows.

{% tabs %}
{% highlight xaml hl_lines="3" %}
 <ContentPage.Content>
    <local:CustomAssistView x:Name="assistView" Grid.Row="1" ShowHeader="{Binding ShowHeader}" ItemCopyCommand="{Binding CopyCommand}" RequestCommand="{Binding         AssistViewRequestCommand}" ItemRetryCommand="{Binding RetryCommand}" HeaderTemplate="{StaticResource headerTemplate}" AssistItems="{Binding AssistMessages}">
        <local:CustomAssistView.ControlTemplate>
            <ControlTemplate>
                <ContentView>
                    <ContentView.Content>
                        <Grid>
                            <ContentView IsVisible="{Binding IsActiveChatView}" Content="{TemplateBinding AssistChatView}" BindingContext="{TemplateBinding    BindingContext}" />
                            <local:ComposeView  IsVisible="{Binding IsActiveComposeView}" BindingContext="{TemplateBinding BindingContext}"/>
                        </Grid>
                    </ContentView.Content>
                </ContentView>
            </ControlTemplate>
        </local:CustomAssistView.ControlTemplate>
    </local:CustomAssistView>
 </ContentPage.Content>

{% endhighlight %}
{% endtabs %}

![Control template in .NET MAUI AI Assist View](Images/maui-aiassistview-control-template.png)