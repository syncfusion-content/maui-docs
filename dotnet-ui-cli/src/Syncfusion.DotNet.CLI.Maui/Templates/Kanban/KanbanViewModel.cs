using System.Collections.ObjectModel;
using Syncfusion.Maui.Kanban;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__
    {
        public ObservableCollection<KanbanModel> Cards { get; } =
        [
            new() { ID = 1, Title = "Review project requirements", Category = "Open", Description = "Review project requirements for the next application release." },
            new() { ID = 2, Title = "Define acceptance criteria", Category = "Open", Description = "Define acceptance criteria for the next application release." },
            new() { ID = 3, Title = "Plan keyboard navigation", Category = "Open", Description = "Plan keyboard navigation for the next application release." },
            new() { ID = 4, Title = "Prepare sample datasets", Category = "Open", Description = "Prepare sample datasets for the next application release." },
            new() { ID = 5, Title = "Review mobile layouts", Category = "Open", Description = "Review mobile layouts for the next application release." },
            new() { ID = 6, Title = "Build the dashboard", Category = "In Progress", Description = "Build the dashboard for the next application release." },
            new() { ID = 7, Title = "Implement search", Category = "In Progress", Description = "Implement search for the next application release." },
            new() { ID = 8, Title = "Add validation messages", Category = "In Progress", Description = "Add validation messages for the next application release." },
            new() { ID = 9, Title = "Improve loading states", Category = "In Progress", Description = "Improve loading states for the next application release." },
            new() { ID = 10, Title = "Write integration tests", Category = "In Progress", Description = "Write integration tests for the next application release." },
            new() { ID = 11, Title = "Review API changes", Category = "Code Review", Description = "Review API changes for the next application release." },
            new() { ID = 12, Title = "Check data bindings", Category = "Code Review", Description = "Check data bindings for the next application release." },
            new() { ID = 13, Title = "Review accessibility", Category = "Code Review", Description = "Review accessibility for the next application release." },
            new() { ID = 14, Title = "Verify error handling", Category = "Code Review", Description = "Verify error handling for the next application release." },
            new() { ID = 15, Title = "Review documentation", Category = "Code Review", Description = "Review documentation for the next application release." },
            new() { ID = 16, Title = "Create the project", Category = "Closed", Description = "Create the project for the next application release." },
            new() { ID = 17, Title = "Configure dependencies", Category = "Closed", Description = "Configure dependencies for the next application release." },
            new() { ID = 18, Title = "Set up the build pipeline", Category = "Closed", Description = "Set up the build pipeline for the next application release." },
            new() { ID = 19, Title = "Add navigation", Category = "Closed", Description = "Add navigation for the next application release." },
            new() { ID = 20, Title = "Publish the design notes", Category = "Closed", Description = "Publish the design notes for the next application release." }
        ];
    }
}
