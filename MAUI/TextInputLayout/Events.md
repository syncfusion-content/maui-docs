---
layout: post
title: Events in MAUI TextInputLayout Control | Syncfusion®
description: Learn about Events support in Syncfusion® Essential Studio® MAUI TextInputLayout control, its elements, and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui
---

# Events in MAUI TextInputLayout

## PasswordVisibilityToggled Event

The [PasswordVisibilityToggled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_PasswordVisibilityToggled) event is triggered whenever the password toggle icon in the `SfTextInputLayout` is toggled. The event provides arguments of type [PasswordVisibilityToggledEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.PasswordVisibilityToggledEventArgs.html) which expose the following property:

- [IsPasswordVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.PasswordVisibilityToggledEventArgs.html#Syncfusion_Maui_Core_PasswordVisibilityToggledEventArgs_IsPasswordVisible): Indicates the current visibility state of the password.

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout  Hint="Password" 
                                PasswordVisibilityToggled="OnPasswordVisibilityToggled">
    <Entry Text="1234"/>
</inputLayout:SfTextInputLayout>  
 
{% endhighlight %}
{% highlight c# %}

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Password";
inputLayout.PasswordVisibilityToggled += OnPasswordVisibilityToggled;
inputLayout.Content = new Entry() { Text = "1234" }; 

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
    
    private void OnPasswordVisibilityToggled(object sender, PasswordVisibilityToggledEventArgs e)
	{
    	bool passwordVisbility = e.IsPasswordVisible;
	}

{% endhighlight %}
{% endtabs %}
