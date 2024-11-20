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
    
   <chip:SfChip WidthRequest="100"
                x:Name="chip"
                CloseButtonClicked="SfChip_CloseButtonClicked"/>

{% endhighlight %}
{% highlight c# %}

   SfChip chip = new SfChip();
   chip.CloseButtonClicked+=chip_CloseButtonClicked;

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
    
    private async void SfChip_CloseButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Message", "Chip CloseButton Clicked", "close");
        }

{% endhighlight %}
{% endtabs %}