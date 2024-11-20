---
layout: post
title: Events in MAUI TextInputLayout control | Syncfusion
description: Learn about Events support in Syncfusion Essential Studio® MAUI TextInputLayout control, its elements, and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui.
---

# Events in MAUI TextInputLayout

## PasswordVisibilityToggled Event

The [PasswordVisibilityToggled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_PasswordVisibilityToggled) event will be triggered whenever you toggle the password toggle icon in the SfTextInputLayout. The event arguments are of type [PasswordVisibilityToggledEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.PasswordVisibilityToggledEventArgs.html) and expose the following property:

* [IsPasswordVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.PasswordVisibilityToggledEventArgs.html#Syncfusion_Maui_Core_PasswordVisibilityToggledEventArgs_IsPasswordVisible): Its value is defined based on the visibility of the password.

{% tabs %}
{% highlight xaml %}
    
   <inputLayout:SfTextInputLayout Hint="Password" PasswordVisibilityToggled="OnPasswordVisibilityToggled"> </inputLayout:SfTextInputLayout>

{% endhighlight %}
{% highlight c# %}

   var inputLayout = new SfTextInputLayout(); inputLayout.Hint = "Password"; inputLayout.PasswordVisibilityToggled += OnPasswordVisibilityToggled; inputLayout.Content = new Entry() { Text = "1234" };

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
