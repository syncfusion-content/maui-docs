using System.Collections.ObjectModel;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

/// <summary>
/// Represents the <see cref="TreeViewViewModel"/> class that contains the collection of items used to populate the <see cref="Syncfusion.UI.Xaml.TreeView.SfTreeView"/>.
/// </summary>
public sealed class TreeViewViewModel : NotificationObject
{
    #region Properties

    /// <summary>
    /// Gets or Sets the collection for CheckedItems.
    /// </summary>
    public ObservableCollection<object> CheckedItems { get; internal set; }

    /// <summary>
    /// Gets or Sets the collection for Items.
    /// </summary>
    public ObservableCollection<TreeViewItemModel> Items { get; internal set; }

    /// <summary>
    /// Gets or Sets the collection for SelectedItems (for Multiple selection mode).
    /// </summary>
    public ObservableCollection<object> SelectedItems { get; internal set; }

    #endregion

    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="TreeViewViewModel"/> class.
    /// </summary>
    public TreeViewViewModel()
    {
        Items = new ObservableCollection<TreeViewItemModel>();
        CheckedItems = new ObservableCollection<object>();
        SelectedItems = new ObservableCollection<object>();

        // Create country items with child states
        var country1 = new TreeViewItemModel { State = "Australia" };
        var country2 = new TreeViewItemModel { State = "Brazil" };
        var country3 = new TreeViewItemModel { State = "Canada" };
        var country4 = new TreeViewItemModel { State = "China" };
        var country5 = new TreeViewItemModel { State = "France" };
        var country6 = new TreeViewItemModel { State = "Germany" };
        var country7 = new TreeViewItemModel { State = "India" };
        var country8 = new TreeViewItemModel { State = "Russia" };
        var country9 = new TreeViewItemModel { State = "UK" };
        var country10 = new TreeViewItemModel { State = "USA" };

        // Australia states
        var aus_state1 = new TreeViewItemModel { State = "New South Wales" };
        var aus_state2 = new TreeViewItemModel { State = "Victoria" };
        var aus_state3 = new TreeViewItemModel { State = "South Australia" };
        var aus_state4 = new TreeViewItemModel { State = "Western Australia" };

        // Brazil states
        var brazil_state1 = new TreeViewItemModel { State = "Bahia" };
        var brazil_state2 = new TreeViewItemModel { State = "Minas Gerais" };
        var brazil_state3 = new TreeViewItemModel { State = "São Paulo" };
        var brazil_state4 = new TreeViewItemModel { State = "Rio de Janeiro" };

        // Canada provinces
        var canada_state1 = new TreeViewItemModel { State = "Alberta" };
        var canada_state2 = new TreeViewItemModel { State = "British Columbia" };
        var canada_state3 = new TreeViewItemModel { State = "Ontario" };
        var canada_state4 = new TreeViewItemModel { State = "Quebec" };

        // China provinces
        var china_state1 = new TreeViewItemModel { State = "Beijing" };
        var china_state2 = new TreeViewItemModel { State = "Shanghai" };
        var china_state3 = new TreeViewItemModel { State = "Guangdong" };
        var china_state4 = new TreeViewItemModel { State = "Sichuan" };

        // France regions
        var france_state1 = new TreeViewItemModel { State = "Alsace" };
        var france_state2 = new TreeViewItemModel { State = "Aquitaine" };
        var france_state3 = new TreeViewItemModel { State = "Auvergne" };
        var france_state4 = new TreeViewItemModel { State = "Brittany" };

        // Germany states
        var germany_state1 = new TreeViewItemModel { State = "Bavaria" };
        var germany_state2 = new TreeViewItemModel { State = "Berlin" };
        var germany_state3 = new TreeViewItemModel { State = "Hamburg" };
        var germany_state4 = new TreeViewItemModel { State = "North Rhine-Westphalia" };

        // India states
        var india_state1 = new TreeViewItemModel { State = "Andhra Pradesh" };
        var india_state2 = new TreeViewItemModel { State = "Goa" };
        var india_state3 = new TreeViewItemModel { State = "Gujarat" };
        var india_state4 = new TreeViewItemModel { State = "Karnataka" };

        // Russia regions
        var russia_state1 = new TreeViewItemModel { State = "Far Eastern" };
        var russia_state2 = new TreeViewItemModel { State = "Moscow" };
        var russia_state3 = new TreeViewItemModel { State = "Siberian" };
        var russia_state4 = new TreeViewItemModel { State = "Ural" };

        // UK countries
        var uk_state1 = new TreeViewItemModel { State = "England" };
        var uk_state2 = new TreeViewItemModel { State = "Scotland" };
        var uk_state3 = new TreeViewItemModel { State = "Wales" };
        var uk_state4 = new TreeViewItemModel { State = "Northern Ireland" };

        // USA states
        var usa_state1 = new TreeViewItemModel { State = "California" };
        var usa_state2 = new TreeViewItemModel { State = "Florida" };
        var usa_state3 = new TreeViewItemModel { State = "New York" };
        var usa_state4 = new TreeViewItemModel { State = "Texas" };

        // Add children to Australia
        country1.SubItems.Add(aus_state1);
        country1.SubItems.Add(aus_state2);
        country1.SubItems.Add(aus_state3);
        country1.SubItems.Add(aus_state4);

        // Add children to Brazil
        country2.SubItems.Add(brazil_state1);
        country2.SubItems.Add(brazil_state2);
        country2.SubItems.Add(brazil_state3);
        country2.SubItems.Add(brazil_state4);

        // Add children to Canada
        country3.SubItems.Add(canada_state1);
        country3.SubItems.Add(canada_state2);
        country3.SubItems.Add(canada_state3);
        country3.SubItems.Add(canada_state4);

        // Add children to China
        country4.SubItems.Add(china_state1);
        country4.SubItems.Add(china_state2);
        country4.SubItems.Add(china_state3);
        country4.SubItems.Add(china_state4);

        // Add children to France
        country5.SubItems.Add(france_state1);
        country5.SubItems.Add(france_state2);
        country5.SubItems.Add(france_state3);
        country5.SubItems.Add(france_state4);

        // Add children to Germany
        country6.SubItems.Add(germany_state1);
        country6.SubItems.Add(germany_state2);
        country6.SubItems.Add(germany_state3);
        country6.SubItems.Add(germany_state4);

        // Add children to India
        country7.SubItems.Add(india_state1);
        country7.SubItems.Add(india_state2);
        country7.SubItems.Add(india_state3);
        country7.SubItems.Add(india_state4);

        // Add children to Russia
        country8.SubItems.Add(russia_state1);
        country8.SubItems.Add(russia_state2);
        country8.SubItems.Add(russia_state3);
        country8.SubItems.Add(russia_state4);

        // Add children to UK
        country9.SubItems.Add(uk_state1);
        country9.SubItems.Add(uk_state2);
        country9.SubItems.Add(uk_state3);
        country9.SubItems.Add(uk_state4);

        // Add children to USA
        country10.SubItems.Add(usa_state1);
        country10.SubItems.Add(usa_state2);
        country10.SubItems.Add(usa_state3);
        country10.SubItems.Add(usa_state4);

        // Add countries to Items collection
        Items.Add(country1);
        Items.Add(country2);
        Items.Add(country3);
        Items.Add(country4);
        Items.Add(country5);
        Items.Add(country6);
        Items.Add(country7);
        Items.Add(country8);
        Items.Add(country9);
        Items.Add(country10);

        CheckedItems = new ObservableCollection<object>();
        CheckedItems.Add(aus_state3);
        CheckedItems.Add(aus_state4);
        CheckedItems.Add(brazil_state2);
        CheckedItems.Add(brazil_state3);
        CheckedItems.Add(china_state3);
    }

    #endregion
}
