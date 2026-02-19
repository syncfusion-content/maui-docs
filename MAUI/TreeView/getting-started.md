---
layout: post
title: Getting Started with .NET MAUI TreeView Control | Syncfusion
description: Learn here about getting started with the Syncfusion .NET MAUI TreeView (SfTreeView) control, its elements and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Getting Started with .NET MAUI TreeView

This section guides you through setting up and configuring a [TreeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html) in your .NET MAUI application. Follow the steps below to add a basic TreeView to your project.

## Prerequisites
Before proceeding, ensure the following are in place:

 1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
 2. Set up a .NET MAUI environment with Visual Studio 2026 (v18.0.0 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a .NET MAUI project

{% tabcontents %}
{% tabcontent Visual Studio %}

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create.**

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Ensure you have the latest version of JetBrains Rider.
2. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI TreeView NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.TreeView](https://www.nuget.org/packages/Syncfusion.Maui.TreeView/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) is a dependent package for all the Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight c# tabtitle="MauiProgram.cs" hl_lines="4 20" %}
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace GettingStarted
{
    public class MauiProgram 
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.ConfigureSyncfusionCore();
            return builder.Build();
        }
    }
}
{% endhighlight %} 
{% endtabs %}
 
## Step 4: Add a basic TreeView

 1. To initialize the control, import the `Syncfusion.Maui.TreeView` namespace into your code.
 2. Initialize [SfTreeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html).

{% tabs %}
{% highlight xaml hl_lines="5" %}

<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView">

    <syncfusion:SfTreeView />
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="9" %}

using Syncfusion.Maui.TreeView;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeView treeView = new SfTreeView();
        this.Content = treeView;
    }
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}
{% endtabcontents %}
 
## Step 2: Install the Syncfusion<sup>®</sup> MAUI TreeView NuGet package
 
 1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
 2. Search for [Syncfusion.Maui.TreeView](https://www.nuget.org/packages/Syncfusion.Maui.TreeView) and install the latest version.
 3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) is a dependent package for all the Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight c# tabtitle="MauiProgram.cs" hl_lines="4 20" %}
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace GettingStarted
{
    public class MauiProgram 
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.ConfigureSyncfusionCore();
            return builder.Build();
        }
    }
}
{% endhighlight %} 
{% endtabs %}
 
## Step 4: Add a basic TreeView

 1. To initialize the control, import the `Syncfusion.Maui.TreeView` namespace into your code.
 2. Initialize [SfTreeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html).

{% tabs %}
{% highlight xaml hl_lines="5" %}

<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView">

    <syncfusion:SfTreeView />
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="9" %}

using Syncfusion.Maui.TreeView;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeView treeView = new SfTreeView();
        this.Content = treeView;
    }
}

{% endhighlight %}
{% endtabs %}

## Step 5: Data population

TreeView can be populated either with the data source by using a [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemsSource) or by creating & adding the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) to [Nodes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Nodes) property.

### Populating nodes without data source - unbound mode

You can create and manage the `TreeViewNode` objects by yourself to display the data in a hierarchical view. To create a tree view, you can use a `TreeView` control and a hierarchy of `TreeViewNode` objects. You can create the node hierarchy by adding one or more root nodes to the TreeView control’s Nodes collection. Each `TreeViewNode` can then have more nodes added to its Children collection. You can nest the tree view nodes to any depth you need.

I> `ItemsSource` is an alternative mechanism to `Nodes` for adding content into the TreeView control. You cannot set both `ItemsSource` and `Nodes` at the same time. When you use `ItemsSource`, nodes are created internally, but you cannot access them from the `Nodes` property.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:treeviewengine="clr-namespace:Syncfusion.TreeView.Engine;assembly=Syncfusion.Maui.TreeView"
             x:Class="GettingStarted.MainPage">
    <ContentPage.Content>
       <syncfusion:SfTreeView x:Name="treeView">
            <syncfusion:SfTreeView.Nodes>
                <treeviewengine:TreeViewNode Content="Australia">
                    <treeviewengine:TreeViewNode.ChildNodes>
                        <treeviewengine:TreeViewNode Content="New South Wales">
                            <treeviewengine:TreeViewNode.ChildNodes>
                                <treeviewengine:TreeViewNode Content="Sydney"/>
                            </treeviewengine:TreeViewNode.ChildNodes>
                        </treeviewengine:TreeViewNode>
                    </treeviewengine:TreeViewNode.ChildNodes>
                </treeviewengine:TreeViewNode>
                <treeviewengine:TreeViewNode Content="United States of America">
                    <treeviewengine:TreeViewNode.ChildNodes>
                        <treeviewengine:TreeViewNode Content="New York"/>
                        <treeviewengine:TreeViewNode Content="California">
                            <treeviewengine:TreeViewNode.ChildNodes>
                                <treeviewengine:TreeViewNode Content="San Francisco"/>
                            </treeviewengine:TreeViewNode.ChildNodes>
                        </treeviewengine:TreeViewNode>
                    </treeviewengine:TreeViewNode.ChildNodes>
                </treeviewengine:TreeViewNode>
            </syncfusion:SfTreeView.Nodes>
        </syncfusion:SfTreeView>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.TreeView;
using Syncfusion.TreeView.Engine;
using System;

namespace GettingStarted
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfTreeView treeView = new SfTreeView();

            var australia = new TreeViewNode() { Content = "Australia" };
            var nsw = new TreeViewNode() { Content = "New South Wales" };
            var sydney = new TreeViewNode() { Content = "Sydney" };
            australia.ChildNodes.Add(nsw);
            nsw.ChildNodes.Add(sydney);
 
            var usa = new TreeViewNode() { Content = "United States of America" };
            var newYork = new TreeViewNode() { Content = "New York," };
            var california = new TreeViewNode() { Content = "California" };
            var sanFrancisco = new TreeViewNode() { Content = "San Francisco" };
            usa.ChildNodes.Add(newYork);
            usa.ChildNodes.Add(california);
            California.ChildNodes.Add(sanFrancisco);
            treeView.Nodes.Add(australia);
            treeView.Nodes.Add(usa);

            this.Content = treeView;
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Step 6: Running the application

Press **F5** to build and run the application. Once compiled, the TreeView will be displayed with the data provided.

Here is the result of the previous codes,

Download the entire source code from GitHub [here](https://github.com/SyncfusionExamples/populate-the-nodes-in-unbound-mode-in-.net-maui-treeview).

![.NET MAUI TreeView getting started UnBoundMode](Images/getting-started/maui-treeView-unboundMode.png)

## Populating nodes by data binding - bound mode

### Define the model

Create a simple data model as shown in the following code example, and save it as `FileManager.cs` file: 

{% tabs %}
{% highlight c# tabtitle="FileManager.cs" %}
public class FileManager : INotifyPropertyChanged
{
   private string itemName;
   private ImageSource imageIcon;
   private ObservableCollection<FileManager> subFiles;

   public ObservableCollection<FileManager> SubFiles
   {
      get { return subFiles; }
      set
      {
         subFiles = value;
         RaisedOnPropertyChanged("SubFiles");
      }
   }

   public string ItemName
   {
      get { return itemName; }
      set
      {
         itemName = value;
         RaisedOnPropertyChanged("ItemName");
      }
   }
 
   public ImageSource ImageIcon
   {
       get { return imageIcon; }
       set
       {
          imageIcon = value;
          RaisedOnPropertyChanged("ImageIcon");
       }
   }

   public event PropertyChangedEventHandler PropertyChanged;

   public void RaisedOnPropertyChanged(string propertyName)
   {
      if (PropertyChanged != null)
      {
         PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
   }
}

{% endhighlight %}
{% endtabs %}

N> If you want your data model to respond to property changes, then implement [INotifyPropertyChanged](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-7.0) interface in your model class.

### Define the view model

Create a model repository class with `ImageNodeInfo` collection property initialized with required number of data objects in a new class file as shown in the following code example, and save it as `FileManagerViewModel.cs` file:

{% tabs %}
{% highlight c# tabtitle="FileManagerViewModel.cs" %}
public class FileManagerViewModel
{
   private ObservableCollection<FileManager> imageNodeInfo;

   public FileManagerViewModel()
   {
      GenerateSource();
   }

   public ObservableCollection<FileManager> ImageNodeInfo
   {
      get { return imageNodeInfo; }
      set { this.imageNodeInfo = value; }
   }

   private void GenerateSource()
   {
      var nodeImageInfo = new ObservableCollection<FileManager>();
      var doc = new FileManager() { ItemName = "Documents", ImageIcon = "folder.png" };
      var download = new FileManager() { ItemName = "Downloads", ImageIcon = "folder.png" };
      var mp3 = new FileManager() { ItemName = "Music", ImageIcon ="folder.png" };
      var pictures = new FileManager() { ItemName = "Pictures", ImageIcon = "folder.png" };
      var video = new FileManager() { ItemName = "Videos", ImageIcon ="folder.png" };

      var pollution = new FileManager() { ItemName = "Environmental Pollution.docx", ImageIcon = "word.png" };
      var globalWarming = new FileManager() { ItemName = "Global Warming.ppt", ImageIcon = "ppt.png" };
      var sanitation = new FileManager() { ItemName = "Sanitation.docx", ImageIcon = "word.png"};
      var socialNetwork = new FileManager() { ItemName = "Social Network.pdf", ImageIcon ="pdfimage.png" };
      var youthEmpower = new FileManager() { ItemName = "Youth Empowerment.pdf", ImageIcon = "pdfimage.png" };
          
      var tutorials = new FileManager() { ItemName = "Tutorials.zip", ImageIcon = "zip.png" };
      var typeScript = new FileManager() { ItemName = "TypeScript.7z", ImageIcon ="zip.png" };
      var uiGuide = new FileManager() { ItemName = "UI-Guide.pdf", ImageIcon = "pdfimage.png"};

      var song = new FileManager() { ItemName = "Gouttes", ImageIcon = "audio.png" };

      var camera = new FileManager() { ItemName = "Camera Roll", ImageIcon = "folder.png" };
      var stone = new FileManager() { ItemName = "Stone.jpg", ImageIcon = "image.png" };
      var wind = new FileManager() { ItemName = "Wind.jpg", ImageIcon = "image.png"};

      var img0 = new FileManager() { ItemName = "WIN_20160726_094117.JPG", ImageIcon = "people_circle23.png" };
      var img1 = new FileManager() { ItemName = "WIN_20160726_094118.JPG", ImageIcon = "people_circle2.png" };

      var video1 = new FileManager() { ItemName = "Naturals.mp4", ImageIcon = "video.png" };
      var video2 = new FileManager() { ItemName = "Wild.mpeg", ImageIcon = "video.png" };

      doc.SubFiles = new ObservableCollection<FileManager>
      {
         pollution,
         globalWarming,
         sanitation,
         socialNetwork,
         youthEmpower
      };

      download.SubFiles = new ObservableCollection<FileManager>
      {
         tutorials,
         TypeScript,
         uiGuide
      };

      mp3.SubFiles = new ObservableCollection<FileManager>
      {
         song
      };

      pictures.SubFiles = new ObservableCollection<FileManager>
      {
         camera,
         stone,
         wind
      };
      
      camera.SubFiles = new ObservableCollection<FileManager>
      {
         img0,
         img1
      };

      video.SubFiles = new ObservableCollection<FileManager>
      {
         video1,
         video2
      };

      nodeImageInfo.Add(doc);
      nodeImageInfo.Add(download);
      nodeImageInfo.Add(mp3);
      nodeImageInfo.Add(pictures);
      nodeImageInfo.Add(video);
      imageNodeInfo = nodeImageInfo;
  }
}

{% endhighlight %}
{% endtabs %}

### Bind the data source

Create a `ViewModel` instance and set it as the ListView's `BindingContext`. This enables property binding from `ViewModel` class.

To populate the TreeView by binding the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemsSource) to a hierarchical data source. To create a tree view using data binding, set a hierarchical collection to the `ItemsSource` property. Then in the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTemplate) and [ExpanderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpanderTemplate), set the child items collection to the `ItemsSource` property.

I> ItemsSource is an alternative mechanism to [Nodes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Nodes) for adding content into the TreeView control. You cannot set both ItemsSource and Nodes at the same time. When you use ItemsSource, nodes are created internally, but you cannot access them from the Nodes property.

{% tabs %}
{% highlight xaml hl_lines="11" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:GettingStarted;assembly=GettingStarted"
             x:Class="GettingStarted.MainPage">

  <ContentPage.BindingContext>
    <local:FileManagerViewModel x:Name="viewModel" />
  </ContentPage.BindingContext>
   <syncfusion:SfTreeView x:Name="treeView" 
                   ItemsSource="{Binding ImageNodeInfo}" 
                   ChildPropertyName="SubFiles"/>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="12" %}
using Syncfusion.Maui.TreeView;

namespace GettingStarted;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfTreeView treeView = new SfTreeView();
        FileManagerViewModel viewModel = new FileManagerViewModel();
        treeView.ItemsSource = viewModel.ImageNodeInfo; 
        treeView.ChildPropertyName = "SubFiles";
        this.Content = treeView;
    }
}

{% endhighlight %}
{% endtabs %}

## Creating hierarchical data model for tree view

Create an hierarchical data model to bind it to the control.

Create a simple hierarchical data source as shown in the following code example in a new class file, and save it as `FileManager.cs` file. 

{% tabs %}
{% highlight c# tabtitle="FileManager.cs" %}
public class Folder : INotifyPropertyChanged
{
    private string itemName;
    private ImageSource imageIcon;
    private ObservableCollection<File> files;

    public Folder()
    {
    }

    public ObservableCollection<File> Files
    {
        get { return files; }
        set
        {
            files = value;
            RaisedOnPropertyChanged("Files");
        }
    }

    public string ItemName
    {
        get { return itemName; }
        set
        {
            itemName = value;
            RaisedOnPropertyChanged("ItemName");
        }
    }

    public ImageSource ImageIcon
    {
        get { return imageIcon; }
        set
        {
            imageIcon = value;
            RaisedOnPropertyChanged("ImageIcon");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void RaisedOnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

public class File : INotifyPropertyChanged
{
    private string itemName;
    private ImageSource imageIcon;
    private ObservableCollection<SubFile> subFiles;

    public File()
    {
    }

    public ObservableCollection<SubFile> SubFiles
    {
        get { return subFiles; }
        set
        {
            subFiles = value;
            RaisedOnPropertyChanged("SubFiles");
        }
    }

    public string ItemName
    {
        get { return itemName; }
        set
        {
            itemName = value;
            RaisedOnPropertyChanged("ItemName");
        }
    }

    public ImageSource ImageIcon
    {
        get { return imageIcon; }
        set
        {
            imageIcon = value;
            RaisedOnPropertyChanged("ImageIcon");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void RaisedOnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

public class SubFile : INotifyPropertyChanged
{
    private string itemName;
    private ImageSource imageIcon;

    public SubFile()
    {
    }

    public string ItemName
    {
        get { return itemName; }
        set
        {
            itemName = value;
            RaisedOnPropertyChanged("ItemName");
        }
    }

    public ImageSource ImageIcon
    {
        get { return imageIcon; }
        set
        {
            imageIcon = value;
            RaisedOnPropertyChanged("ImageIcon");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void RaisedOnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

{% endhighlight %}
{% endtabs %}

N> If you need your hierarchical data model to respond to the property changes, then implement the `INotifyPropertyChanged` interface in your model class.

Create a model repository class with the `Folders` collection property initialized with the required number of data objects in a new class file as shown in the following code example, and save it as `FileManagerViewModel.cs` file:

{% tabs %}
{% highlight c# tabtitle="FileManagerViewModel.cs" %}
public class FileManagerViewModel
{
    public ObservableCollection<Folder> Folders { get; set; }

    public FileManagerViewModel()
    {
        this.Folders = GetFiles();
    }

    private ObservableCollection<Folder> GetFiles()
    {
        var nodeImageInfo = new ObservableCollection<Folder>();

        var doc = new Folder() { ItemName = "Documents", ImageIcon = "folder.png" };
        var download = new Folder() { ItemName = "Downloads", ImageIcon = "folder.png" };
        var mp3 = new Folder() { ItemName = "Music", ImageIcon ="folder.png" };
        var pictures = new Folder() { ItemName = "Pictures", ImageIcon = "folder.png" };
        var video = new Folder() { ItemName = "Videos", ImageIcon ="folder.png" };

        var pollution = new File() { ItemName = "Environmental Pollution.docx", ImageIcon = "word.png" };
        var globalWarming = new File() { ItemName = "Global Warming.ppt", ImageIcon = "ppt.png" };
        var sanitation = new File() { ItemName = "Sanitation.docx", ImageIcon = "word.png"};
        var socialNetwork = new File() { ItemName = "Social Network.pdf", ImageIcon ="pdfimage.png" };
        var youthEmpower = new File() { ItemName = "Youth Empowerment.pdf", ImageIcon = "pdfimage.png" };

        var tutorials = new File() { ItemName = "Tutorials.zip", ImageIcon = "zip.png" };
        var typeScript = new File() { ItemName = "TypeScript.7z", ImageIcon ="zip.png" };
        var uiGuide = new File() { ItemName = "UI-Guide.pdf", ImageIcon = "pdfimage.png"};

        var song = new File() { ItemName = "Gouttes", ImageIcon = "audio.png" };

        var camera = new File() { ItemName = "Camera Roll", ImageIcon = "folder.png" };
        var stone = new File() { ItemName = "Stone.jpg", ImageIcon = "image.png" };
        var wind = new File() { ItemName = "Wind.jpg", ImageIcon = "image.png"};

        var img0 = new SubFile() { ItemName = "WIN_20160726_094117.JPG", ImageIcon = "people_circle23.png" };
        var img1 = new SubFile() { ItemName = "WIN_20160726_094118.JPG", ImageIcon = "people_circle2.png" };

        var video1 = new File() { ItemName = "Naturals.mp4", ImageIcon = "video.png" };
        var video2 = new File() { ItemName = "Wild.mpeg", ImageIcon = "video.png" };

        doc.Files = new ObservableCollection<File>
        {
            pollution,
            globalWarming,
            sanitation,
            socialNetwork,
            youthEmpower
        };

        download.Files = new ObservableCollection<File>
        {
            games,
            tutorials,
            typeScript,
            uiGuide
        };

        mp3.Files = new ObservableCollection<File>
        {
            song
        };

        pictures.Files = new ObservableCollection<File>
        {
            camera,
            stone,
            wind
        };

        camera.SubFiles = new ObservableCollection<SubFile>
        {
            img0,
            img1
        };

        video.Files = new ObservableCollection<File>
        {
            video1,
            video2
        };

        nodeImageInfo.Add(doc);
        nodeImageInfo.Add(download);
        nodeImageInfo.Add(mp3);
        nodeImageInfo.Add(pictures);
        nodeImageInfo.Add(video);
        return nodeImageInfo;
    }
}

{% endhighlight %}
{% endtabs %}

### Bind to hierarchy property descriptor

You can create a tree view by binding the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemsSource) to the hierarchy property descriptors data source. To create a tree view using hierarchical data binding, set a hierarchical collection to the `ItemsSource` property, and then set the `TargetType` and [ChildPropertyName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ChildPropertyName) property values in [HierarchyPropertyDescriptors](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_HierarchyPropertyDescriptors) .

I> `ItemsSource` is an alternative mechanism to [Nodes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Nodes) for adding content into the TreeView control. You cannot set both `ItemsSource` and `Nodes` at the same time. When you use `ItemsSource`, nodes are created internally, but you cannot access them from the `Nodes` property.

{% tabs %}
{% highlight xaml hl_lines="13 14 15 16" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:treeviewengine="clr-namespace:Syncfusion.TreeView.Engine;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:GettingStarted;assembly=GettingStarted"
             x:Class="GettingStarted.MainPage">

  <ContentPage.BindingContext>
    <local:FileManagerViewModel x:Name="viewModel" />
  </ContentPage.BindingContext>
   <syncfusion:SfTreeView x:Name="treeView" 
                          ItemsSource="{Binding Folders}" >
       <syncfusion:SfTreeView.HierarchyPropertyDescriptors>
            <treeviewengine:HierarchyPropertyDescriptor TargetType="{x:Type local:Folder}" ChildPropertyName="Files"/>
            <treeviewengine:HierarchyPropertyDescriptor TargetType="{x:Type local:File}" ChildPropertyName="SubFiles"/>
        </syncfusion:SfTreeView.HierarchyPropertyDescriptors>
    </syncfusion:SfTreeView>

</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="14 15 16 17" %}

using Syncfusion.Maui.TreeView;
using Syncfusion.TreeView.Engine;
using System;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        InitializeComponent();

       SfTreeView treeView = new SfTreeView();
       FileManagerViewModel viewModel = new FileManagerViewModel();
       treeView.ItemsSource = viewModel.Folders; 
       var propertyDescriptor = new HierarchyPropertyDescriptors();
       propertyDescriptor.Add(new Syncfusion.TreeView.Engine.HierarchyPropertyDescriptor() { TargetType = typeof(Folder), ChildPropertyName = "Files" });
       propertyDescriptor.Add(new Syncfusion.TreeView.Engine.HierarchyPropertyDescriptor() { TargetType = typeof(Files), ChildPropertyName = "SubFiles" });
       treeView.HierarchyPropertyDescriptors = propertyDescriptor;
       this.Content = treeView;
    }
}

{% endhighlight %}
{% endtabs %}

## Defining a template to expander and content view

By defining the [ExpanderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpanderTemplate) and [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTemplate) properties, a custom user interface (UI) can be created to display the data items for both expander and content view. It is applicable for both the Unbound and Bound mode data items.

N> By default, the binding context for each tree view item will be the data model object for Bound Mode and [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) for Unbound Mode. However, you can change the binding context for tree view items in Bound Mode as  `TreeViewNode` by defining the [ItemTemplateContextType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTemplateContextType.html) enumeration to `Node`, which is applicable for both `ExpanderTemplate` and `ItemTemplate` properties.

The following code example demonstrates how to customize your content view using the `ItemTemplate` and `ExpanderTemplate` property in both XAML and C#.

{% tabs %}
{% highlight xaml hl_lines="13 35" %}
<ContentPage  xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:GettingStarted.ViewModel"
             x:Class="GettingStarted.MainPage">
    <ContentPage.BindingContext>
       <local:FileManagerViewModel x:Name="viewModel"></local:FileManagerViewModel>
    </ContentPage.BindingContext>
    <ContentPage.Content>
       <syncfusion:SfTreeView x:Name="treeView" 
                              ItemsSource="{Binding ImageNodeInfo}"
                              ItemTemplateContextType="Node">
            <syncfusion:SfTreeView.ItemTemplate>
                <DataTemplate>
                           <Grid x:Name="grid" RowSpacing="0" 
                                 BackgroundColor="Transparent">
                              <Grid Padding="5,5,5,5">
                                  <Image Source="{Binding Content.ImageIcon}" 
                                         VerticalOptions="Center"
                                         HorizontalOptions="Center" 
                                         HeightRequest="35" 
                                         WidthRequest="35"/>
                              </Grid>
                              <Grid Grid.Column="1" 
                                    RowSpacing="1"
                                    Padding="1,0,0,0"
                                    VerticalOptions="Center">
                              <Label LineBreakMode="NoWrap" 
                                     Text="{Binding Content.ItemName}" 
                                     VerticalTextAlignment="Center"/>
                              </Grid>
                           </Grid>
                </DataTemplate>
            </syncfusion:SfTreeView.ItemTemplate>
            <syncfusion:SfTreeView.ExpanderTemplate>
                <DataTemplate>
                            <Image IsVisible="{Binding HasChildNodes,Converter={StaticResource IconVisibleConverter}}" 
                                   Source="{ Binding IsExpanded,Converter={StaticResource ExpanderIconConverter}}"
                                   VerticalOptions="Center" 
                                   HorizontalOptions="Center"/>
                </DataTemplate>
            </syncfusion:SfTreeView.ExpanderTemplate>
       </syncfusion:SfTreeView>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="14 28" %}
using Syncfusion.Maui.TreeView;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        InitializeComponent();

        SfTreeView treeView = new SfTreeView();
        FileManagerViewModel viewModel = new FileManagerViewModel();
        treeView.ItemsSource = viewModel.ImageNodeInfo; 
        treeView.ChildPropertyName = "SubFiles";
        treeView.ItemTemplateContextType = ItemTemplateContextType.Node;
        treeView.ItemTemplate = new DataTemplate(() => 
        {
            HorizontalStackLayout stack = new HorizontalStackLayout();
            var imageIcon = new Image { WidthRequest = 24, HeightRequest = 24 };
            imageIcon.SetBinding(Image.SourceProperty, new Binding("Content.ImageIcon"));
            var itemName = new Label { FontSize = 15, VerticalTextAlignment=TextAlignment.Center, Padding=5 };
            itemName.SetBinding(Label.TextProperty, new Binding("Content.ItemName"));

            stack.Children.Add(imageIcon);
            stack.Children.Add(itemName);

            return stack;
        });

        treeView.ExpanderTemplate = new DataTemplate(()=>
        {
            var grid = new Grid();
            var expanderIcon = new Image();
            expanderIcon.SetBinding(Image.SourceProperty, new Binding("IsExpanded"));
            expanderIcon.SetBinding(Image.IsVisibleProperty, new Binding("HasChildNodes"));
            grid.Children.Add(expanderIcon);
            return grid;
        });

        this.Content = treeView;
    }
}

{% endhighlight %}
{% endtabs %}

Download the entire source code from GitHub [here](https://github.com/SyncfusionExamples/data-binding-in-.net-maui-treeview).

![.NET MAUI TreeView getting started BoundMode](Images/getting-started/maui-treeView-boundMode.png)

## Interacting with a tree view

The TreeView allows you to expand and collapse the nodes either by user interaction on the nodes or by programmatically. The expanding and collapsing interactions can be handled with the help of [NodeCollapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCollapsing) and [NodeExpanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeExpanding) events.

You can define how the nodes to be expanded while loading the TreeView by using the [AutoExpandMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AutoExpandMode) property. Also, the TreeView allows you to set the restrictions whether expanding and collapsing of nodes can be performed only by tapping in expander view or in both expander view and content view by using the [ExpandActionTarget](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandActionTarget) property.

N> the `AutoExpandMode` property is only applicable for bound mode. For Unbound mode you need to set `IsExpanded` property to `true` while creating the nodes, to be in expanded state while loading the TreeView.

{% tabs %}
{% highlight xaml hl_lines="8 9" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:GettingStarted;assembly=GettingStarted"
             x:Class="GettingStarted.MainPage">
  <syncfusion:SfTreeView x:Name="treeView"
                         AutoExpandMode="AllNodesExpanded"
                         ExpandActionTarget="Node"/>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="12 13" %}
using Syncfusion.Maui.TreeView;
using Syncfusion.TreeView.Engine;

namespace GettingStarted
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfTreeView treeView = new SfTreeView();
            treeView.AutoExpandMode = TreeViewAutoExpandMode.AllNodesExpanded;
            treeView.ExpandActionTarget = TreeViewExpandActionTarget.Node;
            this.Content = treeView;
        }
    }
}
{% endhighlight %}
{% endtabs %}

## Selection

The `TreeView` allows selecting the item by setting the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionMode) property. Set the `SelectionMode` property to single, single-deselect, multiple, extended and none based on the requirements. Informations about the selected item can be tracked using the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectedItem), [CurrentItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CurrentItem) and [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectedItems) properties. Also, `TreeView` provides key board navigation support in WinUI and MacCatalyst platform.

It also allows changing the selection highlight color by using the `SelectionBackground` property. Additionally, for unbound mode, you can change the selection foreground color of the text by using the `SelectionForeground` property.

The selection operations can be handled with the help of [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionChanging) and [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionChanged) events.
 
{% tabs %}
{% highlight xaml hl_lines="8 9 10" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:GettingStarted.ViewModel"
             x:Class="GettingStarted.MainPage">

 <syncfusion:SfTreeView x:Name="treeView" 
                        SelectionMode="Single"
                        SelectionBackground="#EADDFF"
                        SelectionForeground="#1C1B1F"/>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="11 12 13" %}
using Syncfusion.Maui.TreeView;

namespace GettingStarted
{
    public class MainPage : ContentPage
    {
        SfTreeView treeView;
        public MainPage()
        {
            treeView = new SfTreeView();
            treeView.SelectionMode = TreeViewSelectionMode.Single;
            treeView.SelectionBackground = Color.FromHex("#EADDFF");
            treeView.SelectionForeground = Color.FromHex("#1C1B1F");
            this.Content=treeView;
        }
    }
}
{% endhighlight %}
{% endtabs %}

## Reset tree view items

You can reset the visible treeview items by using the [ResetTreeViewItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ResetTreeViewItems_System_Object_) method. If the parameter is null, all the visible treeview items will reset. If you are passing the data object as a parameter, a particular treeview item will reset.
 
{% tabs %}
{% highlight c# %}
treeView.ResetTreeViewItems();
{% endhighlight %}
{% endtabs %}

## Refresh view

You can refresh the view by using the [RefreshView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_RefreshView_System_Boolean_) method. It will be used to refresh the items in the treeview at runtime while updating the view.

{% tabs %}
{% highlight c# %}
treeView.RefreshView();
{% endhighlight %}
{% endtabs %}
