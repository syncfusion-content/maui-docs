---
layout: post
title: Checkbox in .NET MAUI TreeView Control | Syncfusion®
description: Learn here about Checkbox support in Syncfusion® .NET MAUI TreeView (SfTreeView) control, its elements and more.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Checkbox in .NET MAUI TreeView (SfTreeView)

The `SfTreeView` provides built-in checkbox support for each node, enabling users to check or uncheck the corresponding node.

The built-in checkbox tracks its state through the [TreeViewNode.IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_IsChecked) property. When populating TreeView nodes from [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemsSource), the checked items can be accessed or modified using the [CheckedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckedItems) property.

## CheckBox State

The `SfTreeView` handles the [IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_IsChecked) property (checkbox state) of `TreeViewNode` based on the [CheckBoxMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxMode) property. The `CheckBoxMode` property determines the behavior of the parent and child nodes' checkbox states when users check or uncheck a node. Its default value is `None`. The checkbox mode contains the following three states:

* `None`: Checking and unchecking are only reflected in the view and do not impact the `CheckedItems` collection.
* `Individual`: The state of the checkbox only affects the individual node and does not alter the checkbox state or `IsChecked` property value of parent or child nodes.
* `Recursive`: When a node's checkbox is checked or unchecked, it influences the checkbox states of both parent and child nodes. For instance, if a parent node's checkbox is checked or unchecked, all of its child nodes' checkboxes will follow suit. Similarly, if all child nodes within a parent node are either checked or unchecked, the parent node's checkbox will reflect this state accordingly. Additionally, if any of the child nodes are checked, the parent node's checkbox will enter an intermediate (indeterminate) state.

N> Set the [NodePopulationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodePopulationMode) as `Instant` and the [CheckBoxMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxMode) as `Recursive` to support recursive checking programmatically through `CheckedItems`.



{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfTreeView x:Name="TreeView"
                        CheckBoxMode="Recursive"
                        ItemsSource="{Binding Folders}"
                        AutoExpandMode="AllNodesExpanded"
                        NodePopulationMode="Instant"/>
{% endhighlight %}
{% highlight c# %}
treeView.CheckBoxMode = CheckBoxMode.Recursive;
{% endhighlight %}
{% endtabs %}

The following example shows `Individual` mode, where checking a node affects only that node:

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfTreeView x:Name="TreeView"
                        CheckBoxMode="Individual"
                        ItemsSource="{Binding Folders}"/>
{% endhighlight %}
{% highlight c# %}
treeView.CheckBoxMode = CheckBoxMode.Individual;
{% endhighlight %}
{% endtabs %}


N> When the `CheckBoxMode` is enabled, the `ItemTapped` and `ItemDoubleTapped` events will not be triggered in `SfTreeView` since the checkbox will handle the touch interaction, only the `NodeChecked` event is triggered.

## CheckBox Width

The [CheckBoxWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxWidth) property reserves the width for the built-in checkbox in the tree view items. Its default value is `42`.

{% tabs %}
{% highlight xaml hl_lines="3" %}
<syncfusion:SfTreeView x:Name="treeView"
                       CheckBoxMode="Recursive"
                       CheckBoxWidth="50"/>
{% endhighlight %}
{% highlight c# %}
treeView.CheckBoxWidth = 50;
{% endhighlight %}
{% endtabs %}

N> The checkbox column is reserved only when the [CheckBoxMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxMode) is set to a value other than `None`.

## CheckBox Position

The [CheckBoxPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxPosition) property determines the position of the built-in checkbox in the tree view item. The checkbox can be placed on the start or end side of the content. Its default value is `Start`. The [TreeViewCheckBoxPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewCheckBoxPosition.html) enumeration defines the available options:

* `Start`: Specifies the checkbox position on the start side of the content.
* `End`: Specifies the checkbox position on the end side of the content.

{% tabs %}
{% highlight xaml hl_lines="3" %}
<syncfusion:SfTreeView x:Name="treeView"
                       CheckBoxMode="Recursive"
                       CheckBoxPosition="End"/>
{% endhighlight %}
{% highlight c# %}
treeView.CheckBoxPosition = TreeViewCheckBoxPosition.End;
{% endhighlight %}
{% endtabs %}

## CheckAction Target

The [CheckActionTarget](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckActionTarget) property determines whether a node can be checked or unchecked by tapping only the checkbox or by tapping the entire node. Its default value is `CheckBox`. The [TreeViewCheckActionTarget](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewCheckActionTarget.html) enumeration defines the available options:

* `CheckBox`: Specifies that nodes can only be checked and unchecked by tapping the checkbox.
* `Node`: Specifies that nodes can be checked and unchecked by tapping either the checkbox or the content view.

{% tabs %}
{% highlight xaml hl_lines="3" %}
<syncfusion:SfTreeView x:Name="treeView"
                       CheckBoxMode="Recursive"
                       CheckActionTarget="Node"/>
{% endhighlight %}
{% highlight c# %}
treeView.CheckActionTarget = TreeViewCheckActionTarget.Node;
{% endhighlight %}
{% endtabs %}

## Checked Items

The checkbox state of a node can be bound and manipulated either through the underlying data in bound mode or directly through the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) in unbound mode. To enable the checkbox in the TreeView, set the [CheckBoxMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxMode) property to a value other than `None`. The checkbox will be displayed automatically in the position determined by the `CheckBoxPosition` property.

### Bound mode

In bound mode, the checkbox states are tracked against the underlying data through the [CheckedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckedItems) property. You can get or set a list of items to be checked or unchecked using the `CheckedItems` property.

The SfTreeView facilitates the checking of multiple items by binding the `CheckedItems` property in the view model with `ObservableCollection<object>` type.

N> TreeView processes and sets `TreeViewNode.IsChecked` based on `CheckedItems` only during the binding of `ItemsSource`.

N> To update checked items after `ItemsSource` is already set, add or remove items directly from the `CheckedItems` collection. Ensure `CheckBoxMode` is set to `Recursive` and `NodePopulationMode` is set to `Instant` for the changes to reflect on the UI.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6 7" %}
<ContentPage.BindingContext>
    <local:FileManagerViewModel x:Name="fileManagerViewModel"/>
</ContentPage.BindingContext>
<syncfusion:SfTreeView x:Name="treeView"
                ItemsSource="{Binding Folders}"
                CheckBoxMode="Recursive"
                CheckedItems="{Binding CheckedItems}"
                NodePopulationMode="Instant">
</syncfusion:SfTreeView>
{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}
public class FileManagerViewModel
{
    private ObservableCollection<object>? checkedItems;
    
    public ObservableCollection<object>? CheckedItems
    {
        get { return checkedItems; }
        set { this.checkedItems = value; }
    }

    public ObservableCollection<Folder> Folders { get; set; }

    public FileManagerViewModel()
    {
        this.Folders = GenerateItem();
    }

    private ObservableCollection<Folder> GenerateItem()
    {

        var doc = new Folder() { FolderName = "Documents", ImageIcon = "folder.png" };
        var download = new Folder() { FolderName = "Downloads", ImageIcon = "folder.png" };
        var music = new Folder() { FolderName = "Music", ImageIcon = "folder.png" };
        var picture = new Folder() { FolderName = "Pictures", ImageIcon = "folder.png" };
        var videos = new Folder() { FolderName = "Videos", ImageIcon = "folder.png" };

        var pollution = new File() { FolderName = "Environmental Pollution.docx", ImageIcon = "Word.png" };
        var global = new File { FolderName = "Global Warming.ppt", ImageIcon = "ppt.png" };
        var sanitation = new File() { FolderName = "Sanitation.docx", ImageIcon = "Word.png" };
        var socialNetwork = new File { FolderName = "Social Networks.ppt", ImageIcon = "ppt.png" };
        var youthEmpowerment = new File { FolderName = "Youth Empowerment.pdf", ImageIcon = "pdfimage.png" };

        var tutorials = new File() { FolderName = "Tutorials.zip", ImageIcon = "zip.png" };
        var typeScript = new File() { FolderName = "TypeScript.7z", ImageIcon = "zip.png" };
        var uiGuide = new File() { FolderName = "UI-Guide.pdf", ImageIcon = "pdfimage.png" };

        var song = new File() { FolderName = "Gouttes", ImageIcon = "Audio.png" };

        var camera = new File() { FolderName = "Camera Roll", ImageIcon = "folder.png" };
        var stone = new File() { FolderName = "Stone.jpg", ImageIcon = "image.png" };
        var wind = new File() { FolderName = "Wind.jpg", ImageIcon = "image.png" };

        var pic1 = new SubFiles() { FolderName = "WIN_20160726_09.JPG", ImageIcon = "people_circle23.png" };
        var pic2 = new SubFiles() { FolderName = "WIN_20160726.Png", ImageIcon = "people_circle2.png" };

        var video1 = new File() { FolderName = "Naturals.mp4", ImageIcon = "video.png" };
        var video2 = new File() { FolderName = "Wild.mpeg", ImageIcon = "video.png" };

        doc.FilesInfo = new ObservableCollection<File>();
        doc.FilesInfo.Add(pollution);
        doc.FilesInfo.Add(global);
        doc.FilesInfo.Add(sanitation);
        doc.FilesInfo.Add(socialNetwork);
        doc.FilesInfo.Add(youthEmpowerment);

        download.FilesInfo = new ObservableCollection<File>();
        download.FilesInfo.Add(tutorials);
        download.FilesInfo.Add(typeScript);
        download.FilesInfo.Add(uiGuide);

        music.FilesInfo = new ObservableCollection<File>();
        music.FilesInfo.Add(song);

        picture.FilesInfo = new ObservableCollection<File>();
        picture.FilesInfo.Add(camera);
        picture.FilesInfo.Add(stone);
        picture.FilesInfo.Add(wind);

        videos.FilesInfo = new ObservableCollection<File>();
        videos.FilesInfo.Add(video1);
        videos.FilesInfo.Add(video2);

        camera.SubFiles = new ObservableCollection<SubFiles>();
        camera.SubFiles.Add(pic1);
        camera.SubFiles.Add(pic2);

        var deviceList = new ObservableCollection<Folder>();
        deviceList.Add(doc);
        deviceList.Add(download);
        deviceList.Add(music);
        deviceList.Add(picture);
        deviceList.Add(videos);

        checkedItems = new ObservableCollection<object>();
        checkedItems.Add(video1);
        checkedItems.Add(global);
        checkedItems.Add(camera);
        checkedItems.Add(socialNetwork);

        return deviceList;
    }
}
{% endhighlight %}
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/load-checkbox-in-each-nodes-in-.net-maui-treeview)

![Syncfusion .NET MAUI TreeView CheckBox nodes in bound mode](Images/checkbox/maui-treeView-checkboxBoundMode.png)

The individual `TreeViewNode` or collection of `TreeViewNode` can be programmatically checked by manipulating the `CheckedItems` property or adding items to the `CheckedItems` property based on the `CheckBoxMode`.

N> When `NodePopulationMode` is set to `Instant` and `CheckBoxMode` is set to `Recursive`, programmatically adding items to `CheckedItems` will propagate the checkbox states to the corresponding parent and child nodes. Otherwise, programmatically adding or removing a node value does not impact the checkbox states of its parent and child nodes.

{% tabs %}
{% highlight c# %}

treeView.CheckedItems.Add(viewModel.Folders[2]);
treeView.CheckedItems.Add(viewModel.Folders[3]);

{% endhighlight %}
{% endtabs %}

### Unbound mode

You can directly set the checkbox state of a node by setting the [TreeViewNode.IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_IsChecked) property value while creating nodes. Set the [CheckBoxMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxMode) property to enable the checkbox in unbound mode and the built-in checkbox will be displayed automatically.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="10 15" %}
<syncfusion:SfTreeView x:Name="treeView" 
                    CheckBoxMode="Recursive"
                    SelectionMode="None">

    <syncfusion:SfTreeView.Nodes>
        <treeviewengine:TreeViewNode Content="North America" IsExpanded="True">
            <treeviewengine:TreeViewNode.ChildNodes>
                <treeviewengine:TreeViewNode Content="United States of America"/>
                <treeviewengine:TreeViewNode Content="Cuba"/>
                <treeviewengine:TreeViewNode Content="Mexico" IsChecked="True"/>
            </treeviewengine:TreeViewNode.ChildNodes>
        </treeviewengine:TreeViewNode>
        <treeviewengine:TreeViewNode Content="Africa" IsExpanded="True">
            <treeviewengine:TreeViewNode.ChildNodes>
                <treeviewengine:TreeViewNode Content="Nigeria" IsChecked="True"/>
                <treeviewengine:TreeViewNode Content="Egypt"/>
                <treeviewengine:TreeViewNode Content="South Africa"/>
            </treeviewengine:TreeViewNode.ChildNodes>
    </syncfusion:SfTreeView.Nodes>
</syncfusion:SfTreeView>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeView.CheckBoxMode = CheckBoxMode.Recursive;
treeView.SelectionMode = Syncfusion.Maui.TreeView.SelectionMode.None;

var northAmerica = new TreeViewNode { Content = "North America", IsExpanded = true };
northAmerica.ChildNodes.Add(new TreeViewNode { Content = "United States of America" });
northAmerica.ChildNodes.Add(new TreeViewNode { Content = "Cuba" });
northAmerica.ChildNodes.Add(new TreeViewNode { Content = "Mexico", IsChecked = true });

var africa = new TreeViewNode { Content = "Africa", IsExpanded = true };
africa.ChildNodes.Add(new TreeViewNode { Content = "Nigeria", IsChecked = true });
africa.ChildNodes.Add(new TreeViewNode { Content = "Egypt" });
africa.ChildNodes.Add(new TreeViewNode { Content = "South Africa" });

treeView.Nodes.Add(northAmerica);
treeView.Nodes.Add(africa);
{% endhighlight %}
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/load-checkbox-in-each-nodes-with-unbound-mode-in-.net-maui-treeview)

![Syncfusion .NET MAUI TreeView Checkbox nodes in unbound mode](Images/checkbox/maui-treeView-checkboxUnboundMode.png)

You can get the list of checked nodes using the [GetCheckedNodes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_GetCheckedNodes) method and set the checkbox state by setting [TreeViewNode.IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_IsChecked) property.

N> The `TreeViewNode` class is available in the `Syncfusion.TreeView.Engine` namespace. Add `using Syncfusion.TreeView.Engine;` to access it in C#.

{% tabs %}
{% highlight c# %}

// Get all checked nodes
var checkedNodes = treeView.GetCheckedNodes();

// Set checkbox state of a node programmatically
var node = treeView.Nodes[0].ChildNodes[2]; // "Mexico"
node.IsChecked = true;
{% endhighlight %}
{% endtabs %}

## Checkbox Template Customization

By default, the `SfTreeView` renders a built-in checkbox when the [CheckBoxMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxMode) is enabled, and the checkbox column is reserved based on the `CheckBoxWidth` property. To use a custom checkbox, hide the built-in checkbox column by setting the `CheckBoxWidth` property to `0` and add the `SfCheckBox` to the `ItemTemplate`. Ensure the `CheckBoxMode` is still set to a value other than `None` so that `CheckedItems` and `IsChecked` tracking continue to function.

N> The `SfCheckBox` control requires the `Syncfusion.Maui.Buttons` namespace. Add the namespace declaration `xmlns:checkbox="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"` to the page to use the `checkbox:` prefix shown in the following examples. For more information on getting started with `SfCheckBox`, refer to the [SfCheckBox getting started](https://help.syncfusion.com/maui/button/overview) documentation.

### Checkbox Template in Bound Mode

In bound mode, bind the `SfCheckBox` in the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTemplate) to the [TreeViewNode.IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_IsChecked) property.

N> Set the [ItemTemplateContextType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTemplateContextType) as `Node` in order to bind the [TreeViewNode.IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_IsChecked) property to `SfCheckBox` within the `ItemTemplate`. When the context is `Node`, the underlying data is accessible through the `Content` property (e.g., `Content.FolderName`, `Content.ImageIcon`) and node properties like `IsChecked` are accessible directly. To know more about `ItemTemplateContextType` click [here](https://help.syncfusion.com/maui/treeview/appearance#bindingcontext-for-itemtemplate).

N> The `CheckedItems` collection in the view model must be of type `ObservableCollection<object>` and bound to the [CheckedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckedItems) property. Refer to the [Bound mode](#bound-mode) section above for the complete ViewModel example.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4 5 7 19 20 21" %}
<syncfusion:SfTreeView x:Name="treeView"
                    ItemsSource="{Binding Folders}"
                    AutoExpandMode="AllNodesExpanded"
                    CheckBoxMode="Recursive"
                    CheckBoxWidth="0"
                    ItemTemplateContextType="Node"
                    CheckedItems="{Binding CheckedItems}"
                    NodePopulationMode="Instant"
                    SelectionMode="None">

    <syncfusion:SfTreeView.ItemTemplate>
        <DataTemplate>
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="40" />
                    <ColumnDefinition Width="40" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>
                <Grid Grid.Column="0">
                    <checkbox:SfCheckBox VerticalOptions="Center"
                                        HorizontalOptions="Center"
                                        IsChecked="{Binding IsChecked, Mode=TwoWay}"/>
                </Grid>
                <Grid Grid.Column="1">
                    <Image Source="{Binding Content.ImageIcon}"
                        VerticalOptions="Center"
                        HorizontalOptions="Center"
                        HeightRequest="24"
                        WidthRequest="24"/>
                </Grid>
                <Grid Grid.Column="2" RowSpacing="1" Padding="1,0,0,0" VerticalOptions="Center">
                    <Label LineBreakMode="NoWrap"
                        Margin="5,0,0,0"
                        Text="{Binding Content.FolderName}"
                        CharacterSpacing="0.25"
                        FontFamily="Roboto-Regular"
                        FontSize="14"
                        VerticalTextAlignment="Center" />
                </Grid>
            </Grid>
        </DataTemplate>
    </syncfusion:SfTreeView.ItemTemplate>
</syncfusion:SfTreeView>
{% endhighlight %}
{% endtabs %}

### Checkbox Template in Unbound Mode

The checkbox state of each node can be set directly by setting the [TreeViewNode.IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_IsChecked) property while creating nodes, and the `SfCheckBox.IsChecked` in the `ItemTemplate` is bound to the same property.

N> In unbound mode, the binding context of the `ItemTemplate` is the [TreeViewNode](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html) by default, so setting the [ItemTemplateContextType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTemplateContextType) property is unnecessary.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2 3 28 29" %}
<syncfusion:SfTreeView x:Name="treeView"
                    CheckBoxMode="Recursive"
                    CheckBoxWidth="0"
                    SelectionMode="None">

    <syncfusion:SfTreeView.Nodes>
        <treeviewengine:TreeViewNode Content="North America" IsExpanded="True">
            <treeviewengine:TreeViewNode.ChildNodes>
                <treeviewengine:TreeViewNode Content="United States of America"/>
                <treeviewengine:TreeViewNode Content="Cuba"/>
                <treeviewengine:TreeViewNode Content="Mexico" IsChecked="True"/>
            </treeviewengine:TreeViewNode.ChildNodes>
        </treeviewengine:TreeViewNode>
        <treeviewengine:TreeViewNode Content="Africa" IsExpanded="True">
            <treeviewengine:TreeViewNode.ChildNodes>
                <treeviewengine:TreeViewNode Content="Nigeria" IsChecked="True"/>
                <treeviewengine:TreeViewNode Content="Egypt"/>
                <treeviewengine:TreeViewNode Content="South Africa"/>
            </treeviewengine:TreeViewNode.ChildNodes>
    </syncfusion:SfTreeView.Nodes>

    <syncfusion:SfTreeView.ItemTemplate>
        <DataTemplate>
            <Grid Padding="5">
                <checkbox:SfCheckBox Text="{Binding Content}"
                                    IsChecked="{Binding IsChecked, Mode=TwoWay}"/>
            </Grid>
        </DataTemplate>
    </syncfusion:SfTreeView.ItemTemplate>
</syncfusion:SfTreeView>
{% endhighlight %}
{% endtabs %}

## Events and Commands

### NodeChecked event

The [NodeChecked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeChecked) event is raised when checking and unchecking the CheckBox at run time. The [NodeCheckedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeCheckedEventArgs.html) has the following members, which provide information for the `NodeChecked` event.

* [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeCheckedEventArgs.html#Syncfusion_Maui_TreeView_NodeCheckedEventArgs_Node): Gets the `TreeViewNode` and data associated with the checked item as its arguments.

N> `NodeChecked` event occurs only on UI interactions. To programmatically change checkbox states, set the [TreeViewNode.IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html#Syncfusion_TreeView_Engine_TreeViewNode_IsChecked) property or modify the `CheckedItems` collection.

{% tabs %}
{% highlight c# %}
     
treeView.NodeChecked += OnTreeViewNodeChecked;

private void OnTreeViewNodeChecked(object sender, Syncfusion.Maui.TreeView.NodeCheckedEventArgs e)
{
    
}
{% endhighlight %}
{% endtabs %}

### NodeCheckedCommand

The [NodeCheckedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCheckedCommand) will be executed when checking and unchecking the CheckBox at run time. The command parameter will be of type [NodeCheckedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeCheckedEventArgs.html), which provides information about the checked node.

* [Node](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeCheckedEventArgs.html#Syncfusion_Maui_TreeView_NodeCheckedEventArgs_Node): Gets the `TreeViewNode` and data associated with the checked item as its arguments.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
public class CommandViewModel
{
    private Command<NodeCheckedEventArgs>? nodeCheckedCommand;

    public Command<NodeCheckedEventArgs>? NodeCheckedCommand
    {
        get { return nodeCheckedCommand; }
        set { nodeCheckedCommand = value; }
    }

    public CommandViewModel()
    {
        NodeCheckedCommand = new Command<NodeCheckedEventArgs>(NodeCheckedCommandMethod);
    }

    private void NodeCheckedCommandMethod(NodeCheckedEventArgs args)
    {
        // Handle node checked command
    }
}
{% endhighlight %}
{% endtabs %}

N> `NodeChecked` event and `NodeCheckedCommand` occur only on UI interactions.