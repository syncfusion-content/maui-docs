#nullable disable
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Documents;
using Microsoft.Win32;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__ : INotifyPropertyChanged
    {
		private bool useDocumentContainer;

        public bool UseDocumentContainer
        {
            get { return useDocumentContainer; }
            set { useDocumentContainer = value; }
        }

        private bool enableMaximizeButton;

        public bool EnableMaximizeButton
        {
            get { return enableMaximizeButton; }
            set { enableMaximizeButton = value; }
        }


        private bool enableMinimizeButton;

        public bool EnableMinimizeButton
        {
            get { return enableMinimizeButton; }
            set { enableMinimizeButton = value; }
        }


        public __VIEW_MODEL_NAME__()
        {
            UseDocumentContainer = true;
            EnableMaximizeButton = true;
            EnableMinimizeButton = true;
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
