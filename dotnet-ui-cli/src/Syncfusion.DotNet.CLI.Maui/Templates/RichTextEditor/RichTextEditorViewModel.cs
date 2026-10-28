using System.ComponentModel;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__ : INotifyPropertyChanged
    {
        private string _htmlText = string.Empty;

        public string HtmlText
        {
            get { return _htmlText; }
            set
            {
                if (_htmlText == value) return;
                _htmlText = value;
                OnPropertyChanged(nameof(HtmlText));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public __VIEW_MODEL_NAME__()
        {
            HtmlText = "<h1>Project notes</h1>"
                + "<p>Use the toolbar to format text, insert links, and organize this document.</p>"
                + "<h2>Release checklist</h2>"
                + "<ul><li>Review the design and requirements.</li><li>Test keyboard navigation and accessibility.</li><li>Update the documentation.</li></ul>"
                + "<h2>Next steps</h2><p>Add your own notes here and try the available formatting options.</p>";
        }
    }
}
