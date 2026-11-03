using System.Collections.ObjectModel;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed class __VIEW_MODEL_NAME__
{
    public ObservableCollection<SalesPoint> Sales { get; } = new()
    {
        new("Jan", 12000), new("Feb", 14500), new("Mar", 13200),
        new("Apr", 17800), new("May", 16400), new("Jun", 19200),
        new("Jul", 18500), new("Aug", 21300), new("Sep", 20100),
        new("Oct", 23400), new("Nov", 25800), new("Dec", 28100),
    };
}

public sealed record SalesPoint(string Month, double Revenue);
