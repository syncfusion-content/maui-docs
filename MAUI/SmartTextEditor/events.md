---
layout: post
title: Events in .NET MAUI Smart Text Editor control | Syncfusion®
description: Learn here all about the Events support in Syncfusion<sup>&reg;</sup> .NET MAUI Smart Text Editor (SfSmartTextEditor) control and more details.
platform: maui
control: SfSmartTextEditor
documentation: ug
---

# Events in .NET MAUI Smart Text Editor (SfSmartTextEditor)

The Smart Text Editor provides the `TextChanged` event, which is triggered whenever the text in the smart text editor changes.

## TextChanged

The [TextChanged] event is triggered whenever the text in the smart text editor changes.

* `Sender`: This contains the `SfSmartTextEditor` object.

* `EventArgs`: The event uses [TextChangedEventArgs], which provides details about the text change.

    * [NewTextValue] : Returns the new text. 
    * [OldTextValue] : Returns the previous text.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<smarttexteditor:SfSmartTextEditor x:Name="smarttexteditor" 
                      TextChanged="OnTextChanged">
</smarttexteditor:SfSmartTextEditor>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.smarttexteditor.TextChanged += OnTextChanged;
private void OnTextChanged(object sender, Syncfusion.Maui.SmartComponents.TextChangedEventArgs e)
{
    var oldValue = e.OldTextValue;
    var newValue = e.NewTextValue;
}

{% endhighlight %}
{% endtabs %}

### TextChangedCommand

The SfSmartTextEditor includes a built-in property called `TextChangedCommand`, which is triggered whenever the text in the smart text editor changes. This event can be invoked through the [TextChangedCommand].

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<smarttexteditor:SfSmartTextEditor x:Name="smarttexteditor"
                    TextChangedCommand="TextChangedCommand">
<ContentPage.BindingContext>
    <local:SmartTextEditorViewModel/>
</ContentPage.BindingContext>
</smarttexteditor:SfSmartTextEditor>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

public class SmartTextEditorViewModel
{
    public ICommand TextChangedCommand { get; set; }
    public SmartTextEditorViewModel()
    {
        TextChangedCommand = new Command(TextChangedCommand);
    }
    private void TextChangedCommand()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}