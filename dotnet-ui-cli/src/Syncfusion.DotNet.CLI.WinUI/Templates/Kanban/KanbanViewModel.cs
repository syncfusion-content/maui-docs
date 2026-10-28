using System.Collections.ObjectModel;
using Syncfusion.UI.Xaml.Kanban;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed class __VIEW_MODEL_NAME__
{
    public ObservableCollection<KanbanModel> TaskDetails { get; } = new();

    public __VIEW_MODEL_NAME__()
    {
        InitializeData();
    }

    private void InitializeData()
    {
        TaskDetails.Add(new KanbanModel()
        {
            Title = "Analyze the new requirements gathered from the customer.",
            Id = "1",
            Description = "Analyze business logic",
            Category = "Open",
            IndicatorColorKey = "High"
        });

        TaskDetails.Add(new KanbanModel()
        {
            Title = "Improve application performance",
            Id = "2",
            Description = "Improve app performance",
            Category = "InProgress",
            IndicatorColorKey = "Normal"
        });

        TaskDetails.Add(new KanbanModel()
        {
            Title = "Arrange web server priority list",
            Id = "3",
            Description = "Arrange server priority",
            Category = "InProgress",
            IndicatorColorKey = "Low"
        });

        TaskDetails.Add(new KanbanModel()
        {
            Title = "Fix the issues reported in the IE browser.",
            Id = "4",
            Description = "Fix IE browser issues",
            Category = "Review",
            IndicatorColorKey = "High"
        });

        TaskDetails.Add(new KanbanModel()
        {
            Title = "Fix the issues reported by the customer.",
            Id = "5",
            Description = "Fix customer issues",
            Category = "Closed",
            IndicatorColorKey = "Low"
        });

        TaskDetails.Add(new KanbanModel()
        {
            Title = "Test the application in the IE browser.",
            Id = "6",
            Description = "Test IE browser",
            Category = "Closed",
            IndicatorColorKey = "Normal"
        });

        TaskDetails.Add(new KanbanModel()
        {
            Title = "Publish new version in the server.",
            Id = "7",
            Description = "Publish new version",
            Category = "Open",
            IndicatorColorKey = "Normal"
        });

        TaskDetails.Add(new KanbanModel()
        {
            Title = "Send new requirements document to the server.",
            Id = "8",
            Description = "Send requirements",
            Category = "Open",
            IndicatorColorKey = "Low"
        });
    }
}
