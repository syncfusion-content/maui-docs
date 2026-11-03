using System.Collections.ObjectModel;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed class __VIEW_MODEL_NAME__
{
    public ObservableCollection<Order> Orders { get; } = new();

    public __VIEW_MODEL_NAME__()
    {
        string[] customers = ["Maria Anders", "Ana Trujillo", "Thomas Hardy", "Christina Berglund", "Laurence Lebihan"];
        string[] products = ["Laptop", "Monitor", "Keyboard", "Headset", "Docking station"];
        string[] cities = ["Berlin", "Mexico City", "London", "Stockholm", "Paris"];
        string[] countries = ["Germany", "Mexico", "United Kingdom", "Sweden", "France"];
        string[] statuses = ["Processing", "Shipped", "Delivered"];
        for (var index = 0; index < 50; index++)
        {
            var customer = index % customers.Length;
            Orders.Add(new Order
            {
                OrderId = 1001 + index,
                Customer = customers[customer],
                Product = products[index % products.Length],
                City = cities[customer],
                Country = countries[customer],
                Quantity = 1 + index % 12,
                UnitPrice = 49.95m + index % 8 * 25m,
                Status = statuses[index % statuses.Length],
            });
        }
    }
}

public sealed class Order
{
    public int OrderId { get; set; }
    public string Customer { get; set; } = "";
    public string Product { get; set; } = "";
    public string City { get; set; } = "";
    public string Country { get; set; } = "";
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public string Status { get; set; } = "";
}
