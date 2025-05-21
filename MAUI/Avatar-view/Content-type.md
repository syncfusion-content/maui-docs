---
layout: post
title: Various Customizations in Syncfusion® Avatar View control.  
description: Learn about avatar types and how to set values for avatar types in .NET MAUI Avatar View.
platform: MAUI
control: SfAvatarView
documentation: UG
---

# Content Types in SfAvatarView

## Avatar types

The [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1) control allows you to display the view in five different ways:

* [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContentType.html#Syncfusion_Maui_Core_ContentType_Default) - Displays the default image when initializing without any other source such as image and group.

* [Initials](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContentType.html#Syncfusion_Maui_Core_ContentType_Initials) - Displays the initials in the view.

* [AvatarCharacter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContentType.html#Syncfusion_Maui_Core_ContentType_AvatarCharacter) - Displays a preset vector image in the view.

* [Custom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContentType.html#Syncfusion_Maui_Core_ContentType_Custom) - Displays a custom image in the view.

* [Group](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContentType.html#Syncfusion_Maui_Core_ContentType_Group) - Displays up to three images or initials in a single view.


## Default

The default type Avatar View is used to display the default vector image when initializing without specifying initials, custom, or group view types.

{% tabs %}

{% highlight xaml %}

<sfavatar:SfAvatarView ContentType="Default"
                       VerticalOptions="Center"
                       HorizontalOptions="Center"
                       Background="OrangeRed"
                       WidthRequest="50"
                       HeightRequest="50"
                       CornerRadius="25"
                       Stroke="Black"
                       StrokeThickness="1">
</sfavatar:SfAvatarView>
	
{% endhighlight %}

{% highlight C# %}

Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.WidthRequest = 50;
avatarview.HeightRequest = 50;
avatarview.CornerRadius = 25;
avatarview.ContentType = ContentType.Default;
avatarview.Background = Colors.OrangeRed;
avatarview.Stroke = Colors.Black;
avatarview.StrokeThickness = 1;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;	

{% endhighlight %}

{% endtabs %}

![Default](ContentType_Images/Default.jpg)

## Initials 

When using [ContentType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ContentType) as initials, set the initial character using the following properties:

* [InitialsType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsType) - Defines the type of characters to be displayed.
* [AvatarName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarName)- Gets or sets the value for the initials type, which displays the text in the avatar view.
* [InitialsColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsColor)- Gets or sets the color of the initials.

### InitialsType

The [InitialsType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsType) includes the following types:

* SingleCharacter
* DoubleCharacter

Set the [AvatarName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarName) property to display initials in the Avatar View. This property accepts a `string` value.

#### SingleCharacter

The `SingleCharacter` type displays the first character of the [AvatarName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarName) specified in the [InitialsType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsType) property.

{% tabs %}
{% highlight xaml %}

<sfavatar:SfAvatarView ContentType="Initials"
                       HorizontalOptions="Center"
                       VerticalOptions="Center"
                       InitialsType="SingleCharacter"
                       AvatarName="Alex"
                       InitialsColor="Black" 
                       WidthRequest="50"
                       FontAttributes="Bold"
                       HeightRequest="50"
                       CornerRadius="25"          
                       Background="Bisque"
                       Stroke="Black"
                       StrokeThickness="1">
</sfavatar:SfAvatarView>

{% endhighlight %}
{% highlight c# %}
             
Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.Background = Colors.Bisque;
avatarview.WidthRequest = 50;
avatarview.HeightRequest = 50;
avatarview.CornerRadius = 25;
avatarview.ContentType = ContentType.Initials;
avatarview.AvatarName = "Alex";
avatarview.InitialsType = InitialsType.SingleCharacter;
avatarview.InitialsColor = Colors.Black;
avatarview.Stroke = Colors.Black;
avatarview.StrokeThickness = 1;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;

{% endhighlight %}
{% endtabs %}

![SingleCharacter](ContentType_Images/Initial_Single_AvatarView.png)

### DoubleCharacter

The `DoubleCharacter` type is used to display two-character text based on the value set in the [InitialsType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsType) property. If the initials contain one word, it shows the first and last letters. If it contains multiple words, it displays the first letter of the first and last string.

{% tabs %}
{% highlight xaml %}

<sfavatar:SfAvatarView ContentType="Initials"
                       InitialsType="DoubleCharacter"
                       AvatarName="Alex"
                       InitialsColor="Black"                     
                       WidthRequest="50"
                       FontAttributes="Bold"                     
                       HeightRequest="50"
                       CornerRadius="25"                        
                       Background="Bisque"
                       Stroke="Black"
                       StrokeThickness="1">
</sfavatar:SfAvatarView>

{% endhighlight %}
{% highlight c# %}
          
Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.Background = Colors.Bisque;
avatarview.WidthRequest = 50;
avatarview.HeightRequest = 50;
avatarview.CornerRadius = 25;
avatarview.ContentType = ContentType.Initials;
avatarview.AvatarName = "Alex";
avatarview.InitialsType = InitialsType.DoubleCharacter;
avatarview.InitialsColor = Colors.Black;
avatarview.Stroke = Colors.Black;
avatarview.StrokeThickness = 1;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;

{% endhighlight %}
{% endtabs %}

![DoubleCharacter](ContentType_Images/Initial_Double_AvatarView.png)

## Custom image

You can add a custom user image by setting the [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSource) property. Refer to the Getting Started Documentation in [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html).

## Avatar characters

The preset vector images in Avatar View can be utilized by setting the [AvatarCharacter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarCharacter) property.

{% tabs %}
{% highlight xaml %}

<sfavatar:SfAvatarView VerticalOptions="Center"
                       HorizontalOptions="Center"
                       ContentType="AvatarCharacter"
                       AvatarCharacter="Avatar8"
                       Background="DeepSkyBlue"
                       WidthRequest="50"
                       HeightRequest="50"
                       CornerRadius="25"
                       Stroke="Black"
                       StrokeThickness="1">
</sfavatar:SfAvatarView>

{% endhighlight %}
{% highlight c# %}
            
Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.WidthRequest = 50;
avatarview.HeightRequest = 50;
avatarview.CornerRadius = 25;
avatarview.ContentType = ContentType.AvatarCharacter;
avatarview.AvatarCharacter = AvatarCharacter.Avatar8;
avatarview.Background = Colors.DeepSkyBlue;
avatarview.Stroke = Colors.Black;
avatarview.StrokeThickness = 1;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;
            
{% endhighlight %}
{% endtabs %}

![AvatarCharacter](ContentType_Images/AvatarCharacter.jpg)

## Group view 

Add up to three images or initials in the same view using the group view type.

Use [InitialsMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsMemberPath) for initials and [ImageSourceMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSourceMemberPath) for images. The following code sample demonstrates how to add images using the [GroupSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_GroupSource) property.

{% tabs %}
{% highlight c# %}
 public class Employee
    {

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string imagesource;

        public string ImageSource
        {
            get { return imagesource; }
            set { imagesource = value; }
        }

        private Color colors;

        public Color Colors
        {
            get { return colors; }
            set { colors = value; }
        }

    }

    public class EmployeeViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        private ObservableCollection<Employee> collectionimage;

        public ObservableCollection<Employee> CollectionImage
        {
            get { return collectionimage; }
            set
            {
                collectionimage = value;
                OnPropertyRaised("CollectionImage");
            }
        }

        public EmployeeViewModel()
        {
            CollectionImage = new ObservableCollection<Employee>();
            CollectionImage.Add(new Employee { Name="Mike" , ImageSource = "mike.png",Colors=Colors.Gray });
            CollectionImage.Add(new Employee { Name="Alex",ImageSource= "alex.png", Colors = Colors.Bisque });
            CollectionImage.Add(new Employee { Name="Ellanaa", ImageSource= "ellanaa.png",Colors=Colors.LightCoral });
        }

    }
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}

<ContentPage.BindingContext>
    <local:EmployeeViewModel/>
</ContentPage.BindingContext>

<sfavatar:SfAvatarView ContentType="Group"                         
                       VerticalOptions="Center"
                       HorizontalOptions="Center"
                       GroupSource="{Binding CollectionImage}"
                       BackgroundColorMemberPath="Colors"
                       ImageSourceMemberPath="ImageSource"
                       WidthRequest="50"
                       HeightRequest="50"
                       CornerRadius="25"
                       Stroke="Black"
                       StrokeThickness="1">
</sfavatar:SfAvatarView>

{% endhighlight %}
{% highlight c# %}

 public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        EmployeeViewModel emp;

           public MainPage()
           {
            InitializeComponent();
            Grid mainGrid = new Grid();
            emp = new EmployeeViewModel();
            SfAvatarView avatarview = new SfAvatarView();
            avatarview.VerticalOptions = LayoutOptions.Center;
            avatarview.HorizontalOptions = LayoutOptions.Center;
            avatarview.WidthRequest = 50;
            avatarview.HeightRequest = 50;
            avatarview.CornerRadius = 25;
            avatarview.ContentType = ContentType.Group;
            avatarview.GroupSource = emp.CollectionImage;
            avatarview.ImageSourceMemberPath = "ImageSource";
            avatarview.BackgroundColorMemberPath = "Colors";
            avatarview.Stroke = Colors.Black;
            avatarview.StrokeThickness = 1;
            this.BindingContext = emp;
            mainGrid.Children.Add(avatarview);
            this.Content = mainGrid;
            }
    }

{% endhighlight %}
{% endtabs %}

![Group view](ContentType_Images/GroupView_SfAvatarView.png)

## Add initials only in group view

Set the initials only in the group view by using the [InitialsMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsMemberPath) alone. The following example shows how this is done.

{% tabs %}

{% highlight xaml %}

<ContentPage.BindingContext>
    <local:EmployeeViewModel/>
</ContentPage.BindingContext>

<sfavatar:SfAvatarView ContentType="Group"                         
                       VerticalOptions="Center"
                       HorizontalOptions="Center"
                       GroupSource="{Binding CollectionImage}"
                       BackgroundColorMemberPath="Colors"
                       InitialsMemberPath="Name"
                       WidthRequest="50"
                       HeightRequest="50"
                       CornerRadius="25"
                       Stroke="Black"
                       StrokeThickness="1">
</sfavatar:SfAvatarView>

{% endhighlight %}

{% highlight c# %}

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    EmployeeViewModel emp;
    public MainPage()
    {

        Grid mainGrid = new Grid();
        emp = new EmployeeViewModel();
        SfAvatarView avatarview = new SfAvatarView();
        avatarview.VerticalOptions = LayoutOptions.Center;
        avatarview.HorizontalOptions = LayoutOptions.Center;
        avatarview.WidthRequest = 50;
        avatarview.HeightRequest = 50;
        avatarview.CornerRadius = 25;
        avatarview.ContentType = ContentType.Group;
        avatarview.GroupSource = emp.CollectionImage;
        avatarview.InitialsMemberPath = "Name";
        avatarview.BackgroundColorMemberPath = "Colors";
        avatarview.Stroke = Colors.Black;
        avatarview.StrokeThickness = 1;
        this.BindingContext = emp;
        mainGrid.Children.Add(avatarview);
        this.Content = mainGrid;
    }
}

{% endhighlight %}
{% endtabs %}

![Group view in initials only](ContentType_Images/GroupView_InitialsAlone.png)

## Add both image and initials in a group view

Set both the image and initials as necessary for the collection. If the image needs to be displayed, set [ImageSourceMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSourceMemberPath); if initials need to be displayed, set [InitialsMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsMemberPath). This is illustrated in the following code:

{% tabs %}
{% highlight c# %}

public class EmployeeViewModel : INotifyPropertyChanged
{
    public EmployeeViewModel()
    {
        CollectionImage = new ObservableCollection<Employee>();
        CollectionImage.Add(new Employee { ImageSource="mike.png" });
        CollectionImage.Add(new Employee { Name= "alex", Colors=Colors.White });
        CollectionImage.Add(new Employee { ImageSource= "ellanaa.png" });
    }  
}

{% endhighlight %}
{% endtabs %}


![Group view for both image and initials](ContentType_Images/GroupView_InitialAndImage.png)

## See also 

[How to load the online images in .NET MAUI Avatar View?](https://support.syncfusion.com/kb/article/17110/how-to-load-the-online-images-in-net-maui-avatarview)