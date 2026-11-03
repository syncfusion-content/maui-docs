using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class DataGridModel : INotifyPropertyChanged
    {
        private string _orderID = string.Empty;
        private string _customerID = string.Empty;
        private string _customer = string.Empty;
        private string _shipCity = string.Empty;
        private string _shipCountry = string.Empty;
        private DateTime _orderDate;
        private string _product = string.Empty;
        private int _quantity;
        private decimal _unitPrice;

        public string OrderID { get => _orderID; set => SetProperty(ref _orderID, value); }
        public string CustomerID { get => _customerID; set => SetProperty(ref _customerID, value); }
        public string Customer { get => _customer; set => SetProperty(ref _customer, value); }
        public string ShipCity { get => _shipCity; set => SetProperty(ref _shipCity, value); }
        public string ShipCountry { get => _shipCountry; set => SetProperty(ref _shipCountry, value); }
        public DateTime OrderDate { get => _orderDate; set => SetProperty(ref _orderDate, value); }
        public string Product { get => _product; set => SetProperty(ref _product, value); }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (SetProperty(ref _quantity, value)) OnPropertyChanged(nameof(Total));
            }
        }

        public decimal UnitPrice
        {
            get => _unitPrice;
            set
            {
                if (SetProperty(ref _unitPrice, value)) OnPropertyChanged(nameof(Total));
            }
        }

        public decimal Total => Quantity * UnitPrice;

        public event PropertyChangedEventHandler? PropertyChanged;

        private bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        private void OnPropertyChanged(string? name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
