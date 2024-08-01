---
layout: post
title: Various customization in Syncfusion AvatarView control.  
description: Learn what are the types in AvatarType and how to set value for the Avatartype in .NET MAUI AvatarView.
platform: maui
control: SfAvatarView
documentation: ug
---

# Content Types in SfAvatarView

## Avatar Types

The [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1) control allows you to display the view in five different ways:

* [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContentType.html#Syncfusion_Maui_Core_ContentType_Default) - Displays the default image when initializing without any other source such as image and group.

* [Initials](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContentType.html#Syncfusion_Maui_Core_ContentType_Initials) - Displays the initial in the view.

* [AvatarCharacter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContentType.html#Syncfusion_Maui_Core_ContentType_AvatarCharacter) - Displays the default image in the view.

* [Custom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContentType.html#Syncfusion_Maui_Core_ContentType_Custom) - Displays a custom image in the view.

* [Group](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContentType.html#Syncfusion_Maui_Core_ContentType_Group) - Displays a maximum of three images or initials in a single view.


## Default

Default type avatar view is used for displaying the default vector image when initializing without the initials, custom, or group view types.

{% tabs %}

{% highlight xaml %}

<sfavatar:SfAvatarView  ContentType="Default"
                        VerticalOptions="Center"
                        HorizontalOptions="Center"
                        BackgroundColor="OrangeRed"
                        WidthRequest="50"
                        HeightRequest="50"
                        CornerRadius="25">
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
avatarview.BackgroundColor = Colors.OrangeRed;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;	

{% endhighlight %}

{% endtabs %}

![Default](ContentType_Images/Default.jpg)

## Initials 

When using the [ContentType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ContentType) as initials, you need to set the initial character using the following properties:

* [InitialsType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsType) - Defines the type of characters to be displayed.
* [AvatarName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarName)- Gets or sets the value for the initials type, which displays the text in the avatar view.
* [InitialsColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsColor)- Gets or sets the color of the initial color value that defines color for the initial string.

### InitialsType

The [InitialsType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsType) contains the following two types:

* SingleCharacter
* DoubleCharacter

You must set the [AvatarName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarName) string property for displaying the initial value in the AvatarView.

#### SingleCharacter

The `SingleCharacter` is used for displaying the first character in the string you have set in the [InitialsType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsType) property.

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
                       BackgroundColor="Bisque">
</sfavatar:SfAvatarView>

{% endhighlight %}
{% highlight c# %}
             
Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.BackgroundColor = Colors.Bisque;
avatarview.WidthRequest = 50;
avatarview.HeightRequest = 50;
avatarview.CornerRadius = 25;
avatarview.ContentType = ContentType.Initials;
avatarview.AvatarName = "Alex";
avatarview.InitialsType = InitialsType.SingleCharacter;
avatarview.InitialsColor = Colors.Black;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;

{% endhighlight %}
{% endtabs %}

![SingleCharacter](ContentType_Images/Initial_Single_AvatarView.png)

### DoubleCharacter

The `DoubleCharacter` is used for displaying a two-characters text you have set in the [InitialsType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsType) property. If the initials contain one word, it shows the first and last letters of the single string. If it contains two or more words, it displays the first letter of the first string and first letter of the last string.

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
                       BackgroundColor="Bisque">
</sfavatar:SfAvatarView>

{% endhighlight %}
{% highlight c# %}
          
Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.BackgroundColor = Colors.Bisque;
avatarview.WidthRequest = 50;
avatarview.HeightRequest = 50;
avatarview.CornerRadius = 25;
avatarview.ContentType = ContentType.Initials;
avatarview.AvatarName = "Alex";
avatarview.InitialsType = InitialsType.DoubleCharacter;
avatarview.InitialsColor = Colors.Black;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;

{% endhighlight %}
{% endtabs %}

![Double Character](ContentType_Images/Initial_Double_AvatarView.png)

## Custom image

You can add a custom user image by setting the [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSource) property. Refer to the Getting Started Documentation in [SfAvatarView.](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html)

## Avatar characters

You can set the default vector images that already present in avatar view by setting the [AvatarCharacter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarCharacter) property.

{% tabs %}
{% highlight xaml %}

<sfavatar:SfAvatarView VerticalOptions="Center"
                       HorizontalOptions="Center"
                       ContentType="AvatarCharacter"
                       AvatarCharacter="Avatar8"
                       BackgroundColor="DeepSkyBlue"
                       WidthRequest="50"
                       HeightRequest="50"
                       CornerRadius="25">
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
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;
            
{% endhighlight %}
{% endtabs %}

![AvatarCharacter](ContentType_Images/AvatarCharacter.jpg)

## GroupView 

You can add maximum three images or initials in the same view using a GroupView type.

Set the [InitialsMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsMemberPath) for displaying the initials in the group view. For image, set the [ImageSourceMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSourceMemberPath). The following code sample demonstrates how to add images using the [GroupSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_GroupSource) property.

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
                       CornerRadius="25">
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
            this.BindingContext = emp;
            mainGrid.Children.Add(avatarview);
            this.Content = mainGrid;
            }
    }

{% endhighlight %}
{% endtabs %}

![GroupViewImage](ContentType_Images/GroupView_SfAvatarView.png)

## Add initials only in GroupView

You can set the initials only in the group view by setting the [InitialsMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsMemberPath) alone. It is demonstrated in the following code sample.

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
                       InitialsMemberPath="Name"
                       WidthRequest="50"
                       HeightRequest="50"
                       CornerRadius="25">
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
			avatarview.ImageSourceMemberPath = "ImageSource";
            avatarview.BackgroundColorMemberPath = "Colors";
            this.BindingContext = emp;
            mainGrid.Children.Add(avatarview);
            this.Content = mainGrid;
         }
      }

{% endhighlight %}
{% endtabs %}

![GroupView in Initials Only](ContentType_Images/GroupView_InitialsAlone.png)

## Add both image and initials in a GroupView

You have to set both the image and initials based on what should be added in the collection. If the image needs to be added, set [ImageSourceMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSourceMemberPath), or if initials need to be added, set [InitialsMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsMemberPath). This is demonstrated in the following code snippet.

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
}

{% endhighlight %}
{% endtabs %}


![GroupView for both image and initials](ContentType_Images/GroupView_InitialAndImage.png)

