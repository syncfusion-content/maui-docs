
Imports System.Windows
Imports System.Windows.Media
Imports Syncfusion.UI.Xaml.Diagram
Imports Syncfusion.UI.Xaml.Diagram.Theming
Imports Syncfusion.UI.Xaml.Diagram.Controls
Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace __ROOT_NAMESPACE__.Diagram
    Public Class DiagramViewModel
        Implements INotifyPropertyChanged
        Private ReadOnly shapeResources As ResourceDictionary = New ResourceDictionary With {
    .Source = New Uri("/Syncfusion.SfDiagram.WPF;component/Resources/BasicShapes.xaml", UriKind.RelativeOrAbsolute)
}
        Private mNodes As Object
        Private mConnectors As Object
        Private mHorizontalRuler As Ruler
        Private mVerticalRuler As Ruler
        Private mSnapSettings As SnapSettings
        Private mTheme As DiagramTheme
        '
        ' Summary:
        '     Gets or sets the vertical ruler of the diagram.
        Public Property VerticalRuler As Ruler
            Get
                Return mVerticalRuler
            End Get
            Set(value As Ruler)
                If mVerticalRuler IsNot value Then
                    mVerticalRuler = value
                    OnPropertyChanged("VerticalRuler")
                End If
            End Set
        End Property
        '
        ' Summary:
        '     Gets or sets the horizontal ruler of the diagram.
        Public Property HorizontalRuler As Ruler
            Get
                Return mHorizontalRuler
            End Get
            Set(value As Ruler)
                If mHorizontalRuler IsNot value Then
                    mHorizontalRuler = value
                    OnPropertyChanged("HorizontalRuler")
                End If
            End Set
        End Property
        '
        ' Summary:
        '     Gets or sets the INode collection of the diagram.
        Public Property Nodes As Object
            Get
                Return mNodes
            End Get
            Set(value As Object)
                If mNodes IsNot value Then
                    mNodes = value
                    OnPropertyChanged("Nodes")
                End If
            End Set
        End Property

        '
        ' Summary:
        '     Gets or sets the IConnector collection of the diagram.
        Public Property Connectors As Object
            Get
                Return mConnectors
            End Get
            Set(value As Object)
                If mConnectors IsNot value Then
                    mConnectors = value
                    OnPropertyChanged("Connectors")
                End If
            End Set
        End Property
        '
        ' Summary:
        '     Gets or sets the SnapSettings of the Diagram.
        Public Property SnapSettings As SnapSettings
            Get
                Return mSnapSettings
            End Get
            Set(value As SnapSettings)
                If mSnapSettings IsNot value Then
                    mSnapSettings = value
                    OnPropertyChanged("SnapSettings")
                End If
            End Set
        End Property
        '
        ' Summary:
        '     Gets or sets the theme to a collection of property settings that allow you to
        '     define the look of diagram elements.
        Public Property Theme As DiagramTheme
            Get
                Return mTheme
            End Get
            Set(value As DiagramTheme)
                If mTheme IsNot value Then
                    mTheme = value
                    OnPropertyChanged("Theme")
                End If
            End Set
        End Property

        Public Sub New()
            Nodes = New NodeCollection()
            Connectors = New ConnectorCollection()
            HorizontalRuler = New Ruler() With {
                .Orientation = Controls.Orientation.Horizontal
            }
            VerticalRuler = New Ruler() With {
                .Orientation = Controls.Orientation.Vertical
            }
            SnapSettings = New SnapSettings() With {
                .SnapConstraints = SnapConstraints.ShowLines
            }
            Theme = New OfficeTheme()

            CreateNode()
            CreateConnector()
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub [Set](Of T)(ByRef storage As T, value As T,
<CallerMemberName> Optional propertyName As String = Nothing)
            If Equals(storage, value) Then
                Return
            End If

            storage = value
            OnPropertyChanged(propertyName)
        End Sub

        Protected Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

#Region "Helper Methods"
        Private Sub CreateNode()
            Dim node1 As NodeViewModel = New NodeViewModel() With {
    .ID = "NewIdea",
    .UnitWidth = 150,
    .UnitHeight = 60,
    .OffsetX = 300,
    .OffsetY = 60,
    .Shape = shapeResources("Ellipse"),
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .Content = "New idea identified",
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center
        }
    }
}

            Dim node2 As NodeViewModel = New NodeViewModel() With {
    .ID = "Meeting",
    .UnitWidth = 150,
    .UnitHeight = 60,
    .OffsetX = 300,
    .OffsetY = 160,
    .Shape = shapeResources("Process"),
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .Content = "Meeting with board",
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center
        }
    }
}

            Dim node3 As NodeViewModel = New NodeViewModel() With {
    .ID = "BoardDecision",
    .UnitWidth = 180,
    .UnitHeight = 100,
    .OffsetX = 300,
    .OffsetY = 270,
    .Shape = shapeResources("Decision"),
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .Content = "Board decides whether to proceed",
            .WrapText = TextWrapping.Wrap,
            .UnitWidth = 75,
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center
        }
    }
}

            Dim node4 As NodeViewModel = New NodeViewModel() With {
    .ID = "Project",
    .UnitWidth = 180,
    .UnitHeight = 100,
    .OffsetX = 300,
    .OffsetY = 410,
    .Shape = shapeResources("Decision"),
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .Content = "Find Project Manager, write specification",
            .WrapText = TextWrapping.Wrap,
            .UnitWidth = 75,
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center
        }
    }
}

            Dim node5 As NodeViewModel = New NodeViewModel() With {
    .ID = "End",
    .UnitWidth = 120,
    .UnitHeight = 60,
    .OffsetX = 300,
    .OffsetY = 530,
    .Shape = shapeResources("Process"),
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .Content = "Implement and deliver",
            .WrapText = TextWrapping.Wrap,
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center
        }
    }
}

            Dim node6 As NodeViewModel = New NodeViewModel() With {
    .ID = "Decision",
    .UnitWidth = 200,
    .UnitHeight = 60,
    .OffsetX = 540,
    .OffsetY = 78,
    .Shape = shapeResources("Card"),
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .Content = "Decision process for new software ideas",
            .WrapText = TextWrapping.Wrap,
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center
        }
    }
}

            Dim node7 As NodeViewModel = New NodeViewModel() With {
    .ID = "Reject",
    .UnitWidth = 200,
    .UnitHeight = 60,
    .OffsetX = 540,
    .OffsetY = 270,
    .Shape = shapeResources("Process"),
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .UnitWidth = 100,
            .Content = "Reject and report the reasons",
            .WrapText = TextWrapping.Wrap,
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center
        }
    }
}

            Dim node8 As NodeViewModel = New NodeViewModel() With {
    .ID = "New_Resources",
    .UnitWidth = 200,
    .UnitHeight = 60,
    .OffsetX = 540,
    .OffsetY = 410,
    .Shape = shapeResources("Process"),
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .UnitWidth = 75,
            .Content = "Hire new resources",
            .WrapText = TextWrapping.Wrap,
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center
        }
    }
}

            TryCast(Nodes, NodeCollection).Add(node1)
            TryCast(Nodes, NodeCollection).Add(node2)
            TryCast(Nodes, NodeCollection).Add(node3)
            TryCast(Nodes, NodeCollection).Add(node4)
            TryCast(Nodes, NodeCollection).Add(node5)
            TryCast(Nodes, NodeCollection).Add(node6)
            TryCast(Nodes, NodeCollection).Add(node7)
            TryCast(Nodes, NodeCollection).Add(node8)
        End Sub

        Private Sub CreateConnector()
            Dim connector1 As ConnectorViewModel = New ConnectorViewModel() With {
    .SourceNodeID = "NewIdea",
    .TargetNodeID = "Meeting"
}

            Dim connector2 As ConnectorViewModel = New ConnectorViewModel() With {
    .SourceNodeID = "Meeting",
    .TargetNodeID = "BoardDecision"
}

            Dim connector3 As ConnectorViewModel = New ConnectorViewModel() With {
    .SourceNodeID = "BoardDecision",
    .TargetNodeID = "Reject",
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .RotationReference = RotationReference.Page,
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center,
            .Margin = New Thickness(0, 10, 0, 0),
            .Content = "No"
        }
    }
}

            Dim connector4 As ConnectorViewModel = New ConnectorViewModel() With {
    .SourceNodeID = "BoardDecision",
    .TargetNodeID = "Project",
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .RotationReference = RotationReference.Page,
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center,
            .Margin = New Thickness(10, 0, 0, 0),
            .Content = "Yes"
        }
    }
}

            Dim connector5 As ConnectorViewModel = New ConnectorViewModel() With {
    .SourceNodeID = "Project",
    .TargetNodeID = "New_Resources",
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .RotationReference = RotationReference.Page,
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center,
            .Margin = New Thickness(0, 10, 0, 0),
            .Content = "No"
        }
    }
}

            Dim connector6 As ConnectorViewModel = New ConnectorViewModel() With {
    .SourceNodeID = "Project",
    .TargetNodeID = "End",
                    .Annotations = New AnnotationCollection() From {
                            New AnnotationEditorViewModel() With {
            .FontFamily = New FontFamily("Calibri"),
            .RotationReference = RotationReference.Page,
            .TextHorizontalAlignment = TextAlignment.Center,
            .TextVerticalAlignment = VerticalAlignment.Center,
            .Margin = New Thickness(10, 0, 0, 0),
            .Content = "Yes"
        }
    }
}

            TryCast(Connectors, ConnectorCollection).Add(connector1)
            TryCast(Connectors, ConnectorCollection).Add(connector2)
            TryCast(Connectors, ConnectorCollection).Add(connector3)
            TryCast(Connectors, ConnectorCollection).Add(connector4)
            TryCast(Connectors, ConnectorCollection).Add(connector5)
            TryCast(Connectors, ConnectorCollection).Add(connector6)
        End Sub
#End Region
    End Class
End Namespace
