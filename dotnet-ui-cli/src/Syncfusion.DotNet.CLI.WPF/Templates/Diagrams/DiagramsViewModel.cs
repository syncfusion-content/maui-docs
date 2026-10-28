#nullable disable
using System.Windows;
using System.Windows.Media;
using Syncfusion.UI.Xaml.Diagram;
using Syncfusion.UI.Xaml.Diagram.Theming;
using Syncfusion.UI.Xaml.Diagram.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__ : INotifyPropertyChanged
    {
        private readonly ResourceDictionary shapeResources = new ResourceDictionary
        {
            Source = new Uri("/Syncfusion.SfDiagram.WPF;component/Resources/BasicShapes.xaml", UriKind.RelativeOrAbsolute)
        };
		private object mNodes;
        private object mConnectors;
        private Ruler mHorizontalRuler;
        private Ruler mVerticalRuler;
        private SnapSettings mSnapSettings;
        private DiagramTheme mTheme;
        //
        // Summary:
        //     Gets or sets the vertical ruler of the diagram.
        public Ruler VerticalRuler
        {
            get
            {
                return mVerticalRuler;
            }
            set
            {
                if (mVerticalRuler != value)
                {
                    mVerticalRuler = value;
                    OnPropertyChanged("VerticalRuler");
                }
            }
        }
        //
        // Summary:
        //     Gets or sets the horizontal ruler of the diagram.
        public Ruler HorizontalRuler
        {
            get
            {
                return mHorizontalRuler;
            }
            set
            {
                if (mHorizontalRuler != value)
                {
                    mHorizontalRuler = value;
                    OnPropertyChanged("HorizontalRuler");
                }
            }
        }
        //
        // Summary:
        //     Gets or sets the INode collection of the diagram.
        public object Nodes
        {
            get
            {
                return mNodes;
            }
            set
            {
                if (mNodes != value)
                {
                    mNodes = value;
                    OnPropertyChanged("Nodes");
                }
            }
        }

        //
        // Summary:
        //     Gets or sets the IConnector collection of the diagram.
        public object Connectors
        {
            get
            {
                return mConnectors;
            }
            set
            {
                if (mConnectors != value)
                {
                    mConnectors = value;
                    OnPropertyChanged("Connectors");
                }
            }
        }
        //
        // Summary:
        //     Gets or sets the SnapSettings of the Diagram.
        public SnapSettings SnapSettings
        {
            get
            {
                return mSnapSettings;
            }
            set
            {
                if (mSnapSettings != value)
                {
                    mSnapSettings = value;
                    OnPropertyChanged("SnapSettings");
                }
            }
        }
        //
        // Summary:
        //     Gets or sets the theme to a collection of property settings that allow you to
        //     define the look of diagram elements.
        public DiagramTheme Theme
        {
            get
            {
                return mTheme;
            }
            set
            {
                if (mTheme != value)
                {
                    mTheme = value;
                    OnPropertyChanged("Theme");
                }
            }
        }

        public __VIEW_MODEL_NAME__()
        {
            Nodes = new NodeCollection();
            Connectors = new ConnectorCollection();
            HorizontalRuler = new Ruler() { Orientation = System.Windows.Controls.Orientation.Horizontal };
            VerticalRuler = new Ruler() { Orientation = System.Windows.Controls.Orientation.Vertical };
            SnapSettings = new SnapSettings() { SnapConstraints = Syncfusion.UI.Xaml.Diagram.SnapConstraints.ShowLines };
            Theme = new OfficeTheme();

            CreateNode();
            CreateConnector();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void Set<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #region Helper Methods
        private void CreateNode()
        {
            NodeViewModel node1 = new NodeViewModel()
            {
                ID = "NewIdea",
                UnitWidth = 150,
                UnitHeight = 60,
                OffsetX = 300,
                OffsetY = 60,
                Shape = shapeResources["Ellipse"],
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        Content = "New idea identified",
                        TextHorizontalAlignment = System.Windows.TextAlignment.Center,
                        TextVerticalAlignment = System.Windows.VerticalAlignment.Center,
                    }
                }
            };

            NodeViewModel node2 = new NodeViewModel()
            {
                ID = "Meeting",
                UnitWidth = 150,
                UnitHeight = 60,
                OffsetX = 300,
                OffsetY = 160,
                Shape = shapeResources["Process"],
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        Content = "Meeting with board",
                        TextHorizontalAlignment = System.Windows.TextAlignment.Center,
                        TextVerticalAlignment = System.Windows.VerticalAlignment.Center,
                    }
                }
            };

            NodeViewModel node3 = new NodeViewModel()
            {
                ID = "BoardDecision",
                UnitWidth = 180,
                UnitHeight = 100,
                OffsetX = 300,
                OffsetY = 270,
                Shape = shapeResources["Decision"],
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        Content = "Board decides whether to proceed",
                        WrapText = System.Windows.TextWrapping.Wrap,
                        UnitWidth = 75,
                        TextHorizontalAlignment = System.Windows.TextAlignment.Center,
                        TextVerticalAlignment = System.Windows.VerticalAlignment.Center,
                    }
                }
            };

            NodeViewModel node4 = new NodeViewModel()
            {
                ID = "Project",
                UnitWidth = 180,
                UnitHeight = 100,
                OffsetX = 300,
                OffsetY = 410,
                Shape = shapeResources["Decision"],
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        Content = "Find Project Manager, write specification",
                        WrapText = System.Windows.TextWrapping.Wrap,
                        UnitWidth = 75,
                        TextHorizontalAlignment = System.Windows.TextAlignment.Center,
                        TextVerticalAlignment = System.Windows.VerticalAlignment.Center,
                    }
                }
            };

            NodeViewModel node5 = new NodeViewModel()
            {
                ID = "End",
                UnitWidth = 120,
                UnitHeight = 60,
                OffsetX = 300,
                OffsetY = 530,
                Shape = shapeResources["Process"],
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        Content = "Implement and deliver",
                        WrapText = System.Windows.TextWrapping.Wrap,
                        TextHorizontalAlignment = System.Windows.TextAlignment.Center,
                        TextVerticalAlignment = System.Windows.VerticalAlignment.Center,
                    }
                }
            };

            NodeViewModel node6 = new NodeViewModel()
            {
                ID = "Decision",
                UnitWidth = 200,
                UnitHeight = 60,
                OffsetX = 540,
                OffsetY = 78,
                Shape = shapeResources["Card"],
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        Content = "Decision process for new software ideas",
                        WrapText = System.Windows.TextWrapping.Wrap,
                        TextHorizontalAlignment = System.Windows.TextAlignment.Center,
                        TextVerticalAlignment = System.Windows.VerticalAlignment.Center,
                    }
                }
            };

            NodeViewModel node7 = new NodeViewModel()
            {
                ID = "Reject",
                UnitWidth = 200,
                UnitHeight = 60,
                OffsetX = 540,
                OffsetY = 270,
                Shape = shapeResources["Process"],
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        UnitWidth = 100,
                        Content = "Reject and report the reasons",
                        WrapText = System.Windows.TextWrapping.Wrap,
                        TextHorizontalAlignment = System.Windows.TextAlignment.Center,
                        TextVerticalAlignment = System.Windows.VerticalAlignment.Center,
                    }
                }
            };

            NodeViewModel node8 = new NodeViewModel()
            {
                ID = "New_Resources",
                UnitWidth = 200,
                UnitHeight = 60,
                OffsetX = 540,
                OffsetY = 410,
                Shape = shapeResources["Process"],
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        UnitWidth = 75,
                        Content = "Hire new resources",
                        WrapText = System.Windows.TextWrapping.Wrap,
                        TextHorizontalAlignment = System.Windows.TextAlignment.Center,
                        TextVerticalAlignment = System.Windows.VerticalAlignment.Center,
                    }
                }
            };

            (Nodes as NodeCollection).Add(node1);
            (Nodes as NodeCollection).Add(node2);
            (Nodes as NodeCollection).Add(node3);
            (Nodes as NodeCollection).Add(node4);
            (Nodes as NodeCollection).Add(node5);
            (Nodes as NodeCollection).Add(node6);
            (Nodes as NodeCollection).Add(node7);
            (Nodes as NodeCollection).Add(node8);
        }

        private void CreateConnector()
        {
            ConnectorViewModel connector1 = new ConnectorViewModel()
            {
                SourceNodeID = "NewIdea",
                TargetNodeID = "Meeting"
            };

            ConnectorViewModel connector2 = new ConnectorViewModel()
            {
                SourceNodeID = "Meeting",
                TargetNodeID = "BoardDecision"
            };

            ConnectorViewModel connector3 = new ConnectorViewModel()
            {
                SourceNodeID = "BoardDecision",
                TargetNodeID = "Reject",
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        RotationReference = RotationReference.Page,
                        TextHorizontalAlignment= System.Windows.TextAlignment.Center,
                        TextVerticalAlignment= System.Windows.VerticalAlignment.Center,
                        Margin = new System.Windows.Thickness(0,10,0,0),
                        Content = "No",
                    },
                },
            };

            ConnectorViewModel connector4 = new ConnectorViewModel()
            {
                SourceNodeID = "BoardDecision",
                TargetNodeID = "Project",
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        RotationReference = RotationReference.Page,
                        TextHorizontalAlignment= System.Windows.TextAlignment.Center,
                        TextVerticalAlignment= System.Windows.VerticalAlignment.Center,
                        Margin = new System.Windows.Thickness(10,0,0,0),
                        Content = "Yes",
                    },
                },
            };

            ConnectorViewModel connector5 = new ConnectorViewModel()
            {
                SourceNodeID = "Project",
                TargetNodeID = "New_Resources",
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        RotationReference = RotationReference.Page,
                        TextHorizontalAlignment= System.Windows.TextAlignment.Center,
                        TextVerticalAlignment= System.Windows.VerticalAlignment.Center,
                        Margin = new System.Windows.Thickness(0,10,0,0),
                        Content = "No",
                    },
                },
            };

            ConnectorViewModel connector6 = new ConnectorViewModel()
            {
                SourceNodeID = "Project",
                TargetNodeID = "End",
                Annotations = new AnnotationCollection()
                {
                    new AnnotationEditorViewModel()
                    {
                        FontFamily = new FontFamily("Calibri"),
                        RotationReference = RotationReference.Page,
                        TextHorizontalAlignment= System.Windows.TextAlignment.Center,
                        TextVerticalAlignment= System.Windows.VerticalAlignment.Center,
                        Margin = new System.Windows.Thickness(10,0,0,0),
                        Content = "Yes",
                    },
                },
            };

            (Connectors as ConnectorCollection).Add(connector1);
            (Connectors as ConnectorCollection).Add(connector2);
            (Connectors as ConnectorCollection).Add(connector3);
            (Connectors as ConnectorCollection).Add(connector4);
            (Connectors as ConnectorCollection).Add(connector5);
            (Connectors as ConnectorCollection).Add(connector6);
        }
        #endregion
    }
}
