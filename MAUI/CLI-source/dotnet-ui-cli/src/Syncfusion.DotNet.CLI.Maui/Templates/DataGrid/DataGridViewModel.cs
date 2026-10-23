using System;
using System.Collections.ObjectModel;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__
    {
        public ObservableCollection<DataGridModel> Orders { get; } = [];

        public __VIEW_MODEL_NAME__()
        {
            (string Id, string Name, string City, string Country)[] customers =
            [
                ("ALFKI", "Maria Anders", "Berlin", "Germany"),
                ("ANATR", "Ana Trujillo", "Mexico City", "Mexico"),
                ("ANTON", "Antonio Moreno", "Mexico City", "Mexico"),
                ("AROUT", "Thomas Hardy", "London", "UK"),
                ("BERGS", "Christina Berglund", "Luleå", "Sweden"),
                ("BLAUS", "Hanna Moos", "Mannheim", "Germany"),
                ("BONAP", "Laurence Lebihan", "Marseille", "France"),
                ("CACTU", "Patricio Simpson", "Buenos Aires", "Argentina"),
                ("EASTC", "Ann Devon", "London", "UK"),
                ("FOLKO", "Maria Larsson", "Bräcke", "Sweden")
            ];

            string[] products = ["Notebook", "Keyboard", "Monitor", "Desk lamp", "Headset", "Webcam", "Docking station", "Mouse", "Laptop stand", "USB hub"];
            var firstOrderDate = DateTime.Today.AddDays(-49);
            for (var index = 0; index < 50; index++)
            {
                var customer = customers[index % customers.Length];
                Orders.Add(new DataGridModel
                {
                    OrderID = (1001 + index).ToString(),
                    CustomerID = customer.Id,
                    Customer = customer.Name,
                    ShipCity = customer.City,
                    ShipCountry = customer.Country,
                    OrderDate = firstOrderDate.AddDays(index),
                    Product = products[index % products.Length],
                    Quantity = 1 + index % 8,
                    UnitPrice = 19.95m + index % 10 * 15m
                });
            }
        }
    }
}
