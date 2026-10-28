#nullable disable
using System.Collections.ObjectModel;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__
    {
        public ObservableCollection<ChartModel> CanadaData { get; }

        public ObservableCollection<ChartModel> FranceData { get; }

        public ObservableCollection<ChartModel> PlantDetails { get; set; }

        public __VIEW_MODEL_NAME__()
        {
            CanadaData = new ObservableCollection<ChartModel>();
            FranceData = new ObservableCollection<ChartModel>();
            PlantDetails = new ObservableCollection<ChartModel>
            {
                new ChartModel { Direction = "North", Tree = 80 },
                new ChartModel { Direction = "NorthWest", Tree = 87 },
                new ChartModel { Direction = "West", Tree = 78 },
                new ChartModel { Direction = "SouthWest", Tree = 85 },
                new ChartModel { Direction = "South", Tree = 81 },
                new ChartModel { Direction = "SouthEast", Tree = 88 },
                new ChartModel { Direction = "East", Tree = 80 },
                new ChartModel { Direction = "NorthEast", Tree = 85 },
            };

            CanadaData.Add(new ChartModel { Year = "2000", Value = 26.8 });
            CanadaData.Add(new ChartModel { Year = "2001", Value = 29 });
            CanadaData.Add(new ChartModel { Year = "2002", Value = 27.5 });
            CanadaData.Add(new ChartModel { Year = "2003", Value = 28.4 });
            CanadaData.Add(new ChartModel { Year = "2004", Value = 26.5 });
            CanadaData.Add(new ChartModel { Year = "2005", Value = 25.1 });

            FranceData.Add(new ChartModel { Year = "2000", Value = 9.3 });
            FranceData.Add(new ChartModel { Year = "2001", Value = 8.3 });
            FranceData.Add(new ChartModel { Year = "2002", Value = 9.2 });
            FranceData.Add(new ChartModel { Year = "2003", Value = 9.9 });
            FranceData.Add(new ChartModel { Year = "2004", Value = 9.6 });
            FranceData.Add(new ChartModel { Year = "2005", Value = 10.8 });
        }
    }
}
