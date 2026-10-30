using System.Collections.ObjectModel;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed class __VIEW_MODEL_NAME__
{
    public ObservableCollection<Employee> Employees { get; } = new();

    public __VIEW_MODEL_NAME__()
    {
        string[] departments = ["Engineering", "Sales", "Customer support"];
        string[] locations = ["London", "Berlin", "New York"];
        string[] names = ["Alex", "Jordan", "Taylor", "Morgan", "Casey", "Riley", "Jamie"];
        for (var team = 0; team < departments.Length; team++)
        {
            var managerId = team * 10 + 1;
            Employees.Add(new Employee(managerId, -1, names[team], "Team lead", departments[team], locations[team]));
            for (var member = 0; member < 6; member++)
                Employees.Add(new Employee(managerId + member + 1, managerId,
                    names[(member + team + 1) % names.Length] + " " + (team + 1),
                    "Specialist", departments[team], locations[team]));
        }
    }
}

public sealed record Employee(int Id, int ReportsTo, string Name, string Title, string Department, string Location);
