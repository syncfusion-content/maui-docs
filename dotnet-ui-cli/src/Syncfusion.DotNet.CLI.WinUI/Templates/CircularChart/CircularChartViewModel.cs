using System.Collections.ObjectModel;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed class __VIEW_MODEL_NAME__
{
    public ObservableCollection<Sales> Data { get; } = new()
    {
        new("iPad", 25),
        new("iPhone", 35),
        new("MacBook", 15),
        new("Mac", 5),
        new("Others", 10),
    };
}

public sealed record Sales(string Product, double SalesRate);
