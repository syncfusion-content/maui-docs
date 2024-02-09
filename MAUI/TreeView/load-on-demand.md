---
layout: post
title: Load on Demand in .NET MAUI TreeView control | Syncfusion
description: Learn here all about Load on Demand support in Syncfusion .NET MAUI TreeView (SfTreeView) control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Load on Demand in .NET MAUI TreeView (SfTreeView)

TreeView enables loading child items only upon request through Lazy Loading. This feature allows loading child items from services when users expand the node. Initially, populate the root [Nodes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Nodes) by assigning [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemsSource), and subsequently, load child items when a node is expanded using [LoadOnDemandCommand](). Load on-demand is applicable for bound mode only.

{% tabs %}
{% highlight xaml %}

    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfTreeView="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"
             xmlns:treeviewengine="clr-namespace:Syncfusion.TreeView.Engine;assembly=Syncfusion.Maui.TreeView"
             xmlns:local="clr-namespace:LoadonDemand.ViewModels"
             x:Class="LoadOnDemand.MainPage">
       <ContentPage.BindingContext>
            <local:ViewModel x:Name="viewModel"/>
       </ContentPage.BindingContext>
       <ContentPage.Content>
            <sfTreeView:SfTreeView x:Name="treeView"
                               LoadOnDemandCommand="{Binding TreeViewOnDemandCommand}"
                               ItemsSource="{Binding Menu}" /> 
        </ContentPage.Content>
    </ContentPage>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight ViewModel.cs %}
/// <summary>
/// ViewModel class with <see cref="Command"/> for load on demand. 
/// </summary>
      
    public class ViewModel
    {
    
     public ObservableCollection<Model> Menu { get; set; }

     public ICommand? TreeViewOnDemandCommand
     {
         get; set;
     }

     public ViewModel()
     {
         this.Menu = this.GetMenuItems();
         TreeViewOnDemandCommand = new Command(ExecuteOnDemandLoading, CanExecuteOnDemandLoading);
     }

     private bool CanExecuteOnDemandLoading(object sender)
     {
         var hasChildNodes = ((sender as TreeViewNode)!.Content as Model)!.HasChildNodes;
         if (hasChildNodes)
             return true;
         else
             return false;
     }

     private void ExecuteOnDemandLoading(object obj)
     {
         var node = obj as TreeViewNode;
         // Skip the repeated population of child items when every time the node expands.
         if (node!.ChildNodes!.Count > 0)
         {
             node.IsExpanded = true;
             return;
         }

         node.ShowExpanderAnimation = true;
         //Animation starts for the expander to show the progressing of load on demand.
         Model? Info = node!.Content as Model;
         Microsoft.Maui.Controls.Application.Current!.Dispatcher.Dispatch(async () =>
         {
             await Task.Delay(1000);
             //Fetching child items to add.
             var items = GetSubMenu(Info!.ID);
             // Populating child items for the node in on-demand.
             node.PopulateChildNodes(items);
             if (items.Any())
                 //Expand the node after child items are added.
                 node.IsExpanded = true;
             node.ShowExpanderAnimation = false;
         });
     }

     private ObservableCollection<Model> GetMenuItems()
     {
         ObservableCollection<Model> menuItems = new ObservableCollection<Model>();
         menuItems.Add(new Model() { ItemName = "My Drive", HasChildNodes = true, ID = 0 });
         return menuItems;
     }

     public IEnumerable<Model> GetSubMenu(int iD)
     {
         ObservableCollection<Model> menuItems = new ObservableCollection<Model>();
         if (iD == 0)
         {
             menuItems.Add(new Model() { ItemName = "Documents", HasChildNodes = true, ID = 1 });
             menuItems.Add(new Model() { ItemName = "Work", HasChildNodes = true, ID = 2 });
             menuItems.Add(new Model() { ItemName = "Photos", HasChildNodes = true, ID = 3 });
             menuItems.Add(new Model() { ItemName = "Music", HasChildNodes = true, ID = 4 });
             menuItems.Add(new Model() { ItemName = "Videos", HasChildNodes = true, ID = 5 });
         }
         if (iD == 1)
         {
             menuItems.Add(new Model() { ItemName = "Personal", HasChildNodes = true, ID = 11 });
         }
         else if (iD == 2)
         {
             menuItems.Add(new Model() { ItemName = "ProjectA", HasChildNodes = true, ID = 21 });
             menuItems.Add(new Model() { ItemName = "ProjectB", HasChildNodes = true, ID = 22 });
         }
         else if (iD == 3)
         {
             menuItems.Add(new Model() { ItemName = "Family", HasChildNodes = true, ID = 31 });
             menuItems.Add(new Model() { ItemName = "Friends", HasChildNodes = true, ID = 32 });
         }
         else if (iD == 4)
         {
             menuItems.Add(new Model() { ItemName = "Playlist1", HasChildNodes = true, ID = 41 });
             menuItems.Add(new Model() { ItemName = "Playlist2", HasChildNodes = true, ID = 42 });
         }
         else if (iD == 5)
         {
             menuItems.Add(new Model() { ItemName = "Tutorial", HasChildNodes = true, ID = 51 });
         }
         else if (iD == 11)
         {
             menuItems.Add(new Model() { ItemName = "Resume.docx", HasChildNodes = false, ID = 61 });
             menuItems.Add(new Model() { ItemName = "TravelPlans.pdf", HasChildNodes = false, ID = 62 });
         }
         else if (iD == 21)
         {
             menuItems.Add(new Model() { ItemName = "Proposal.docx", HasChildNodes = false, ID = 71 });
             menuItems.Add(new Model() { ItemName = "Presentation.pptx", HasChildNodes = false, ID = 72 });
         }
         else if (iD == 22)
         {
             menuItems.Add(new Model() { ItemName = "Report.pdf", HasChildNodes = false, ID = 73 });
         }
         else if (iD == 31)
         {
             menuItems.Add(new Model() { ItemName = "Beach.jpg", HasChildNodes = false, ID = 81 });
             menuItems.Add(new Model() { ItemName = "Mountains.jpg", HasChildNodes = false, ID = 82 });
         }
         else if (iD == 32)
         {
             menuItems.Add(new Model() { ItemName = "GrouPhoto.jpg", HasChildNodes = false, ID = 91 });
         }
         else if (iD == 41)
         {
             menuItems.Add(new Model() { ItemName = "Song1.mp3", HasChildNodes = false, ID = 101 });
             menuItems.Add(new Model() { ItemName = "Song2.mp3", HasChildNodes = false, ID = 102 });
         }
         else if (iD == 42)
         {
             menuItems.Add(new Model() { ItemName = "Song3.mp3", HasChildNodes = false, ID = 111 });
             menuItems.Add(new Model() { ItemName = "Song4.mp3", HasChildNodes = false, ID = 112 });
         }
         else if (iD == 51)
         {
             menuItems.Add(new Model() { ItemName = "Codingbasics.mp4", HasChildNodes = false, ID = 121 });
             menuItems.Add(new Model() { ItemName = "Webdevelopment.mp4", HasChildNodes = false, ID = 122 });
         }
        
         return menuItems;
     }
 }
{% endhighlight %}
{% endtabs %}
{% tabs %}
{% highlight Model.cs %}
/// <summary>
/// Model
/// </summary>
      
    public class Model : INotifyPropertyChanged
    {

    public string? itemName;
    public int id;
    public bool hasChildNodes;

    public string? ItemName
    {
        get 
        { 
            return itemName;
        }

        set
        {
            itemName = value;
            OnPropertyChanged("ItemName");
        }
    }

    public int ID
    {
        get 
        { 
            return id;
        }

        set
        {
            id = value;
            OnPropertyChanged("ID");
        }
    }

    public bool HasChildNodes
    {
        get 
        { 
            return hasChildNodes;
        }

        set
        {
            hasChildNodes = value;
            OnPropertyChanged("HasChildNodes");
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

{% endhighlight %}
{% endtabs %}

N> `LoadOnDemandCommand` receives [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) as a command parameter by default. 

## Handling expander visibility

The TreeView displays the expander icon for a specific node based on the return value of the [CanExecute](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.command.canexecute?view=net-maui-8.0) method within the LoadOnDemandCommand. When `CanExecute` returns `true`, the expander icon appears for that node; if `false`, the expander icon is not displayed. `CanExecute` is invoked to determine the visibility of the expander icon before executing [LoadOnDemandCommand](). 

{% tabs %}
{% highlight c# %}

       
    /// <summary>
    /// CanExecute method is called before expanding and initialization of node. Returns whether the node has child nodes or not.
    /// Based on the return value of the expander, the visibility of the node is handled.  
    /// </summary>
    /// <param name="sender">TreeViewNode is passed as default parameter </param>
    /// <returns>Returns true if the specified node has child items to load and the expander icon is displayed for that node, else returns false and the icon is not displayed.</returns>
    private bool CanExecuteOnDemandLoading(object sender)
    {
      var hasChildNodes = ((sender as TreeViewNode).Content as Model).HasChildNodes;
      if (hasChildNodes)
        return true;
      else
        return false;
    }
{% endhighlight %}
{% endtabs %}

## On-demand loading of child items

For on-demand loading of child items, the [Execute](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.command.execute?view=net-maui-8.0) method of `LoadOnDemandCommand` is where you can load child items for the node. This method is triggered when the user expands the tree node. Within `LoadOnDemand.Execute`, you can perform the following operations.

* Manage the visibility of the expander by adjusting [TreeViewNode.ShowExpanderAnimation]() until the data is fetched.
* Once the data is retrieved, populate the child nodes by invoking [TreeViewNode.PopulateChildNodes](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_PopulateChildNodes_System_Collections_IEnumerable_) and passing the collection of child items. 
* As the expanding operation is not handled by the `TreeView` during the execution of the load-on-demand command, you need to set [TreeViewNode.IsExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_IsExpanded) to `true` to expand the tree node after populating the child nodes.
* To avoid repeatedly populating child items each time the node expands, you can skip this step based on the count of [TreeViewNode.ChildNodes](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_ChildNodes).
* Utilize the [TreeViewNode.VisibleNodesCount](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_VisibleNodesCount) property to determine the number of child nodes displayed in the view.
* The presence of child nodes for a TreeView node can be determined by the return value of the [HasChildNodes](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_HasChildNodes) property. It returns `true` if the node has child nodes, otherwise `false`.

{% tabs %}
{% highlight c# %}

  
  
  
    /// <summary>
    /// Execute method is called when any item is requested for load-on-demand items.
    /// </summary>
    /// <param name="obj">TreeViewNode is passed as default parameter </param>
    private void ExecuteOnDemandLoading(object obj)
    {
      var node = obj as TreeViewNode;
        
    // Skip the repeated population of child items when every time the node expands.
    if (node.ChildNodes.Count > 0)
    {
        node.IsExpanded = true;
        return;
    }

    /// <summary>
    /// CanExecute method is called before expanding and initialization of node. Returns whether the node has child nodes or not.
    /// Based on the return value, the expander visibility of the node is handled.  
    /// </summary>
    /// <param name="sender">TreeViewNode is passed as default parameter </param>
    /// <returns>Returns true if the specified node has child items to load on demand and the expander icon is displayed for that node, else returns false, and the icon is not displayed.</returns>
    private bool CanExecuteOnDemandLoading(object sender)
    {
        var hasChildNodes = ((sender as TreeViewNode).Content as Model).HasChildNodes;
        if (hasChildNodes)
            return true;
        else
            return false;
    }

    //Animation starts for the expander to show the progress of load on demand.
    node.ShowExpanderAnimation = true;
    Info Info = node.Content as Info;
    Device.BeginInvokeOnMainThread(async () =>
    {
        await Task.Delay(2000);
        
        //Fetching child items to add.
        var items = GetSubMenu(Info.ID);
        
        // Populating child items for the node in on-demand.
        node.PopulateChildNodes(items);
        if (items.Count() > 0)
            //Expand the node after child items are added.
            node.IsExpanded = true;
            
            //Get the VisibleNodesCount.
            var count = node.VisibleNodesCount;

        //Stop the animation after load on demand is executed, if the animation is not stopped, it remains still after execution of load on demand.
        node.ShowExpanderAnimation = false;
    });   
}
{% endhighlight %}
{% endtabs %}

Download the entire source code from GitHub [here](https://github.com/SyncfusionExamples/perform-load-on-demand-item-population-in-.net-maui-treeview/tree/master).

![.NET MAUI TreeView Load on Demand](Images/LoadonDemand/maui-treeView-Loadondemand.gif)
