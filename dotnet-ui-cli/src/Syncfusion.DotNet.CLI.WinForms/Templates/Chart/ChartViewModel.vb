
Imports System.Collections.ObjectModel

Namespace __ROOT_NAMESPACE__.Chart
    Public Class ChartViewModel
        Public ReadOnly Property CanadaData As ObservableCollection(Of ChartModel)

        Public ReadOnly Property FranceData As ObservableCollection(Of ChartModel)

        Public Property PlantDetails As ObservableCollection(Of ChartModel)

        Public Sub New()
            CanadaData = New ObservableCollection(Of ChartModel)()
            FranceData = New ObservableCollection(Of ChartModel)()
            PlantDetails = New ObservableCollection(Of ChartModel) From {
    New ChartModel With {
        .Direction = "North",
        .Tree = 80
    },
    New ChartModel With {
        .Direction = "NorthWest",
        .Tree = 87
    },
    New ChartModel With {
        .Direction = "West",
        .Tree = 78
    },
    New ChartModel With {
        .Direction = "SouthWest",
        .Tree = 85
    },
    New ChartModel With {
        .Direction = "South",
        .Tree = 81
    },
    New ChartModel With {
        .Direction = "SouthEast",
        .Tree = 88
    },
    New ChartModel With {
        .Direction = "East",
        .Tree = 80
    },
    New ChartModel With {
        .Direction = "NorthEast",
        .Tree = 85
    }
}

            CanadaData.Add(New ChartModel With {
                .Year = "2000",
                .Value = 26.8
            })
            CanadaData.Add(New ChartModel With {
                .Year = "2001",
                .Value = 29
            })
            CanadaData.Add(New ChartModel With {
                .Year = "2002",
                .Value = 27.5
            })
            CanadaData.Add(New ChartModel With {
                .Year = "2003",
                .Value = 28.4
            })
            CanadaData.Add(New ChartModel With {
                .Year = "2004",
                .Value = 26.5
            })
            CanadaData.Add(New ChartModel With {
                .Year = "2005",
                .Value = 25.1
            })

            FranceData.Add(New ChartModel With {
                .Year = "2000",
                .Value = 9.3
            })
            FranceData.Add(New ChartModel With {
                .Year = "2001",
                .Value = 8.3
            })
            FranceData.Add(New ChartModel With {
                .Year = "2002",
                .Value = 9.2
            })
            FranceData.Add(New ChartModel With {
                .Year = "2003",
                .Value = 9.9
            })
            FranceData.Add(New ChartModel With {
                .Year = "2004",
                .Value = 9.6
            })
            FranceData.Add(New ChartModel With {
                .Year = "2005",
                .Value = 10.8
            })
        End Sub
    End Class
End Namespace
