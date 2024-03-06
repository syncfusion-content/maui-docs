---
layout: post
title: Events in MAUI TextInputLayout control | Syncfusion
description: Learn about Events support in Syncfusion Essential Studio MAUI TextInputLayout control, its elements, and more.
platform: maui
control: SfTextInputLayout
documentation: ug
---

# Events in MAUI TextInputLayout

## PasswordVisibilityToggled Event

The `PasswordVisibilityToggled` event will be triggered whenever toggle the EnablePasswordVisibilityToggle icon in the SfTextInputLayout. It can defines visibility of the password based on the icon clicked. If the icon shows, the value of `IsPasswordVisible` will be **true**. The event arguments are of type `PasswordVisibilityToggledEventArgs` and expose the following property:

* `IsPasswordVisible`: Its value is defined based on the password visibility.

{% tabs %} 
{% highlight xaml %} 

<inputLayout:SfTextInputLayout  Hint="Password" 
                                PasswordVisibilityToggled="SfTextInputLayout_PasswordVisibilityToggled">
    <Entry Text="1234"/>
</inputLayout:SfTextInputLayout>  
 
{% endhighlight %}

{% highlight C# %} 

var inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Password";
inputLayout.PasswordVisibilityToggled += InputLayout_PasswordVisibilityToggled;
inputLayout.Content = new Entry() { Text = "1234" }; 

{% endhighlight %}

{% tabs %}
{% highlight c# %}
    
    private void SfTextInputLayout_PasswordVisibilityToggled(object sender, PasswordVisibilityToggledEventArgs e)
	{
    	bool passwordVisbility = e.IsPasswordVisible;
	}

{% endhighlight %}
{% endtabs %}