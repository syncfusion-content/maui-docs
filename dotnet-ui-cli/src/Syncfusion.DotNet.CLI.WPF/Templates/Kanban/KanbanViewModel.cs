using Syncfusion.UI.Xaml.Kanban;
#nullable disable
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__ : INotifyPropertyChanged
    {
        public ObservableCollection<KanbanModel> Tasks { get; set; }

        public __VIEW_MODEL_NAME__()
        {
            Tasks = new ObservableCollection<KanbanModel>();
            Tasks.Add(new KanbanModel()
            {
                Title = "Universal App",
                ID = "27654",
                Description = "Incorporate feedback into functional specifications",
                Category = "Open",
                ColorKey = "Low",
                Tags = new string[] { "Deployment" },
                ImageURL = new Uri("/__ROOT_NAMESPACE__;component/Kanban/Resources/Employee.png", UriKind.RelativeOrAbsolute)
            });

            Tasks.Add(new KanbanModel()
            {
                Title = "Universal App",
                ID = "29477",
                Description = "Design functional specifications",
                Category = "In Progress",
                ColorKey = "Normal",
                Tags = new string[] { "Design" },
                ImageURL = new Uri("/__ROOT_NAMESPACE__;component/Kanban/Resources/Employee.png", UriKind.RelativeOrAbsolute)
            });

            Tasks.Add(new KanbanModel()
            {
                Title = "Universal App",
                ID = "25678",
                Description = "Review preliminary software specifications",
                Category = "Done",
                ColorKey = "Low",
                Tags = new string[] { "Analysis" },
                ImageURL = new Uri("/__ROOT_NAMESPACE__;component/Kanban/Resources/Employee.png", UriKind.RelativeOrAbsolute)
            });

            Tasks.Add(new KanbanModel()
            {
                Title = "Universal App",
                ID = "6593",
                Description = "Draft preliminary software specifications",
                Category = "Review",
                ColorKey = "High",
                Tags = new string[] { "Analysis" },
                ImageURL = new Uri("/__ROOT_NAMESPACE__;component/Kanban/Resources/Employee.png", UriKind.RelativeOrAbsolute)
            });
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
    }
}
