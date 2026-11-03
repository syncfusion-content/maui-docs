#nullable disable
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
