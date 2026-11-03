#nullable disable
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Syncfusion.Windows.Shared;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__ : NotificationObject, INotifyPropertyChanged
    {
        public System.Collections.ObjectModel.ObservableCollection<NavigationDrawerModel> Contents { get; } =
            new System.Collections.ObjectModel.ObservableCollection<NavigationDrawerModel>
            {
                new NavigationDrawerModel { Name = "Inbox" },
                new NavigationDrawerModel { Name = "Sent Mail" },
                new NavigationDrawerModel { Name = "Starred" },
                new NavigationDrawerModel { Name = "Drafts" },
            };

        public __VIEW_MODEL_NAME__()
        {
        }


        protected void Set<T>(
            ref T storage,
            T value,
            [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            RaisePropertyChanged(propertyName);
        }
    }
}
