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

The `PasswordVisibilityToggled` event will be triggered whenever you toggle the password toggle icon in the SfTextInputLayout. The event arguments are of type `PasswordVisibilityToggledEventArgs` and expose the following property:

* `IsPasswordVisible`: Its value is defined based on the visibility of the password.

{% tabs %} 
{% highlight xaml %} 

<inputLayout:SfTextInputLayout  Hint="Password" 
                                PasswordVisibilityToggled="OnPasswordVisibilityToggled">
    <Entry Text="1234"/>
</inputLayout:SfTextInputLayout>  
 
{% endhighlight %}

{% highlight C# %} 

var inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Password";
inputLayout.PasswordVisibilityToggled += OnPasswordVisibilityToggled;
inputLayout.Content = new Entry() { Text = "1234" }; 

{% endhighlight %}

{% tabs %}
{% highlight c# %}
    
    private void OnPasswordVisibilityToggled(object sender, PasswordVisibilityToggledEventArgs e)
	{
    	bool passwordVisbility = e.IsPasswordVisible;
	}

{% endhighlight %}
{% endtabs %}