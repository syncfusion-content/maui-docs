using System.Collections.ObjectModel;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

/// <summary>
/// Represents the class <see cref="TreeViewItemModel"/> that contains the data for <see cref="Syncfusion.UI.Xaml.TreeView.SfTreeView"/>.
/// </summary>
public class TreeViewItemModel : NotificationObject
{
    #region Fields

    /// <summary>
    /// Maintains the collections for subitems.
    /// </summary>
    private ObservableCollection<TreeViewItemModel> subItems;

    /// <summary>
    /// Maintains the string value for state.
    /// </summary>
    private string state;

    #endregion

    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="TreeViewItemModel"/> class.
    /// </summary>
    public TreeViewItemModel()
    {
        SubItems = new ObservableCollection<TreeViewItemModel>();
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the collection for SubItems.
    /// </summary>
    public ObservableCollection<TreeViewItemModel> SubItems
    {
        get
        {
            return subItems;
        }

        internal set
        {
            subItems = value;
            this.RaisePropertyChanged(nameof(SubItems));
        }
    }

    /// <summary>
    /// Gets or sets a value indicating the state of the TreeViewItem.
    /// </summary>
    public string State
    {
        get
        {
            return state;
        }

        set
        {
            state = value;
            this.RaisePropertyChanged(nameof(State));
        }
    }

    #endregion
}
