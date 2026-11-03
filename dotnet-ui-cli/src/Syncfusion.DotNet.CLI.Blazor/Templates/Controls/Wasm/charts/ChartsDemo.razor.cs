using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System.Collections.ObjectModel;
using Syncfusion.Blazor.Charts;

namespace __PAGE_NAMESPACE__;

public partial class ChartsDemo
{
    public List<Revenue> RevenueData = DashboardData.GetRevenue();
    public List<Order> OrdersData = DashboardData.GetOrders();
    public List<MarketShare> MarketShareData = DashboardData.GetMarketShare();
    public List<CustomerGrowth> CustomerGrowthData = DashboardData.GetCustomerGrowth();
    public static class DashboardData
    {
        public static List<Revenue> GetRevenue() => new()
        {
            new("Jan", 220),
            new("Feb", 260),
            new("Mar", 310),
            new("Apr", 390)
        };
        public static List<Order> GetOrders() => new()
        {
            new("Jan", 620),
            new("Feb", 780),
            new("Mar", 1020),
            new("Apr", 1350)
        };
        public static List<MarketShare> GetMarketShare() => new()
        {
            new("Product A", 40),
            new("Product B", 30),
            new("Product C", 20),
            new("Others", 10)
        };
        public static List<CustomerGrowth> GetCustomerGrowth() => new()
        {
            new("2021", 1200),
            new("2022", 1800),
            new("2023", 2600),
            new("2024", 3120)
        };
    }
    public record Revenue(string Month, double Amount);
    public record Order(string Month, double Count);
    public record MarketShare(string Company, double Share);
    public record CustomerGrowth(string Year, double Customers);
    private RenderFragment KpiCard(string title, string value, string icon) => builder =>
    {
        builder.OpenElement(0, "div");
        builder.AddAttribute(1, "class", "col-md-3");
        builder.OpenElement(2, "div");
        builder.AddAttribute(3, "class", "card text-center shadow-sm p-3");
        builder.OpenElement(4, "div");
        builder.AddAttribute(5, "style", "font-size:32px");
        builder.AddContent(6, icon);
        builder.CloseElement();
        builder.OpenElement(7, "h5");
        builder.AddContent(8, title);
        builder.CloseElement();
        builder.OpenElement(9, "h3");
        builder.AddContent(10, value);
        builder.CloseElement();
        builder.CloseElement(); // card
        builder.CloseElement(); // col
    };
}
