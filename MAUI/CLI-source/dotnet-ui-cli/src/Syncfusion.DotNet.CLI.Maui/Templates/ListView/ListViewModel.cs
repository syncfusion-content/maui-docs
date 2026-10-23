using System.ComponentModel;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class ListViewModel : INotifyPropertyChanged
    {
        private string? _bookName;
        private string? _bookDescription;

        public string? BookName
        {
            get { return _bookName; }
            set
            {
                _bookName = value;
                OnPropertyChanged(nameof(BookName));
            }
        }

        public string? BookDescription
        {
            get { return _bookDescription; }
            set
            {
                _bookDescription = value;
                OnPropertyChanged(nameof(BookDescription));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
