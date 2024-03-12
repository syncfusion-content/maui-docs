---
layout: post
title: Loading Online Images in .NET MAUI Rotator control | Syncfusion
description: Learn about Loading Online Images support in Syncfusion .NET MAUI Rotator (SfRotator) control and more.
platform: maui 
control: Rotator 
documentation: ug
---

# Loading Online Images in .NET MAUI Rotator (SfRotator)

This section describes loading the online images in the `SfRotator` Control.

{% tabs %}
{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"
                xmlns:local="clr-namespace:Rotator"
                x:Class="Rotator.Rotator">
        <ContentPage.BindingContext>
            <local:RotatorViewModel/>
        </ContentPage.BindingContext>
        <ContentPage.Content>
            <StackLayout>
                <rotator:SfRotator x:Name="rotator" 
                            ItemsSource="{Binding ImageCollection}" 
                            NavigationDirection="Horizontal">
                    <rotator:SfRotator.ItemTemplate>
                        <DataTemplate>
                                <Image Source="{Binding Image}"/>
                        </DataTemplate>
                    </rotator:SfRotator.ItemTemplate>
                </rotator:SfRotator>
            </StackLayout>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight c# %}

    using Syncfusion.Maui.Core.Rotator;
    using Syncfusion.Maui.Rotator;
    namespace Rotator
    {
        public partial class Rotator : ContentPage
        {
            public Rotator()
            {
                InitializeComponent();
                SfRotator sfRotator = new SfRotator();
                sfRotator.ItemsSource = GetDataSource();

                var imageTemplate = new DataTemplate(() =>
                {
                    Image image = new Image();
                    image.SetBinding(Image.SourceProperty, "Image");
                    return image;
                });

                sfRotator.ItemTemplate = imageTemplate;
                this.Content = sfRotator;
            }
            List<CustomData> GetDataSource()
            {
                List<CustomData> list = new List<CustomData>();
                list.Add(new CustomData("https://cdn.syncfusion.com/content/images/Images/Camtasia_Succinctly.png?v=22022017060923"));
                list.Add(new CustomData("https://cdn.syncfusion.com/content/images/Images/SQL_Queries_Succinctly.png?v=04022017014551"));
                list.Add(new CustomData("https://upload.wikimedia.org/wikipedia/commons/0/0c/Cow_female_black_white.jpg"));
                list.Add(new CustomData("https://cdn.syncfusion.com/content/images/Images/Keystonejs_Succinctly.png?v=22022017060923"));
                list.Add(new CustomData("https://cdn.syncfusion.com/content/images/Images/sql_server_for_c_sharp_developers_succinctly_cover_img.png?v=22022017060923"));
                list.Add(new CustomData("https://cdn.syncfusion.com/content/images/Images/sql_server_for_c_sharp_developers_succinctly_cover_img.png?v=22022017060923"));
                return list;
            }
        }
    }


    // ViewModel Class:

        public class RotatorViewModel
            {
                public RotatorViewModel()
                {
                    ImageCollection= = new ObservableCollection<RotatorModel>();
                    ImageCollection.Add(new RotatorModel("https://cdn.syncfusion.com/content/images/Images/Camtasia_Succinctly.png?v=22022017060923"));
                    ImageCollection.Add(new RotatorModel("https://cdn.syncfusion.com/content/images/Images/SQL_Queries_Succinctly.png?v=04022017014551"));
                    ImageCollection.Add(new RotatorModel("https://upload.wikimedia.org/wikipedia/commons/0/0c/Cow_female_black_white.jpg"));
                    ImageCollection.Add(new RotatorModel("https://cdn.syncfusion.com/content/images/Images/Keystonejs_Succinctly.png?v=22022017060923"));
                    ImageCollection.Add(new RotatorModel("https://cdn.syncfusion.com/content/images/Images/sql_server_for_c_sharp_developers_succinctly_cover_img.png?v=22022017060923"));
                    ImageCollection.Add(new RotatorModel("https://cdn.syncfusion.com/content/images/Images/sql_server_for_c_sharp_developers_succinctly_cover_img.png?v=22022017060923"));
                }

                private ObservableCollection<RotatorModel> imageCollection;
                public ObservableCollection<RotatorModel> ImageCollection
                {
                    get { return imageCollection; }
                    set { imageCollection = value; }
                }
            }

        // Model Class:

        public class RotatorModel
            {
                public RotatorModel(string imageString)
                {
                    Image = imageString;
                }
                private String _image;
                public String Image
                {
                    get { return _image; }
                    set { _image = value; }
                }
            }

        // Custom Data 

        namespace Rotator
        {
            public class CustomData : ContentPage
            {
                public CustomData(string image)
                {
                    Image = image;
                }
                public string Image
                {
                    get;
                    set;
                }
            }
        }

{% endhighlight %}

{% endtabs %}

![Loading URL Image](images/URLImage.png)
