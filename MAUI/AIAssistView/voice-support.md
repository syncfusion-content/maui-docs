---
layout: post
title: Voice and Text-to-Speech Support in .NET MAUI AI AssistView | Syncfusion®
description: Learn how to enable and configure voice input and text-to-speech support in the Syncfusion® .NET MAUI AI AssistView (SfAIAssistView) control.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# How to Enable Voice and Text-to-Speech Support in .NET MAUI SfAIAssistView?

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control provides built-in voice input and text-to-speech capabilities. Voice input allows users to interact using speech through a microphone button, while text-to-speech enables users to listen to AI responses.

## Voice Input Support in SfAIAssistView

The `SfAIAssistView` control provides built-in voice input support through a microphone button in the editor. By default, the microphone view is visible. To hide it, set the `EnableVoiceInput` property to `false`.

### Permission Required for Voice Input

To use voice input support, you must grant audio recording permissions on each platform.

#### Android Platform

Provide audio permission in the `AndroidManifest.xml` file:

{% tabs %}
{% highlight xml %}

<uses-permission android:name="android.permission.RECORD_AUDIO" />

{% endhighlight %}
{% endtabs %}

#### iOS and macOS Platform

Add the following permissions to the `Info.plist` file:

{% tabs %}
{% highlight xml %}

<key>NSSpeechRecognitionUsageDescription</key>
<string>Recognize speech</string>
<key>NSMicrophoneUsageDescription</key>
<string>Use microphone to listen to your voice input</string>

{% endhighlight %}
{% endtabs %}

#### Windows Platform

Provide the `Microphone` capability in the `Package.appxmanifest` file:

{% tabs %}
{% highlight xml %}

<DeviceCapability Name="microphone"/>

{% endhighlight %}
{% endtabs %}

##### Configure Speech Recognition

Ensure that the following settings are enabled on the device:

- Online speech recognition: **Settings > Privacy > Privacy & Security**.
- Microphone access: **Settings > Privacy & Security > Microphone** with the required permissions granted to the application.

### Disable Voice Input

You can disable the microphone button by setting the `EnableVoiceInput` property to `false`.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           EnableVoiceInput="False" />

{% endhighlight %}
{% highlight c# hl_lines="2" %}

    SfAIAssistView sfAIAssistView = new SfAIAssistView();
    sfAIAssistView.EnableVoiceInput = false;

{% endhighlight %}
{% endtabs %}

## Text-to-Speech Support in SfAIAssistView

The `SfAIAssistView` control provides built-in text-to-speech support for each response. This allows users to listen to generated responses and control playback using playback actions such as play, pause, and stop.
