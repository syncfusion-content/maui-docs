using System.Collections.ObjectModel;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__
    {
        public ObservableCollection<ListViewModel> Books { get; } = [];

        public __VIEW_MODEL_NAME__()
        {
            string[] topics =
            [
                "C#", ".NET MAUI", "XAML", "MVVM", "ASP.NET Core",
                "Blazor", "Entity Framework", "LINQ", "Async programming", "REST APIs",
                "Accessibility", "Application security", "Cloud development", "Data visualization", "Automated testing"
            ];
            (string Title, string Description)[] guides =
            [
                ("Foundations", "Explore the core concepts with practical examples."),
                ("Design patterns", "Build maintainable solutions using common patterns."),
                ("Testing", "Verify behavior and cover real-world edge cases."),
                ("Performance", "Measure bottlenecks and improve responsiveness."),
                ("Production", "Prepare reliable applications for deployment and support.")
            ];

            foreach (var topic in topics)
            {
                foreach (var guide in guides)
                {
                    Books.Add(new ListViewModel
                    {
                        BookName = $"{topic}: {guide.Title}",
                        BookDescription = $"{topic} — {guide.Description}"
                    });
                }
            }
        }
    }
}
