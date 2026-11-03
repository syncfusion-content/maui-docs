#nullable disable
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__ : INotifyPropertyChanged
    {
        public ObservableCollection<ChartModel> Data { get; } = new ObservableCollection<ChartModel>();

        public __VIEW_MODEL_NAME__()
        {
            Data.Add(new ChartModel { Name = "Product A", Imports = 2.2, Exports = 1.2 });
            Data.Add(new ChartModel { Name = "Product B", Imports = 2.4, Exports = 1.3 });
            Data.Add(new ChartModel { Name = "Product C", Imports = 3, Exports = 1.5 });
            Data.Add(new ChartModel { Name = "Product D", Imports = 3.1, Exports = 2.2 });
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
