using System;
using System.Collections.Generic;
using Syncfusion.Blazor.Kanban;

namespace __PAGE_NAMESPACE__;

public partial class KanbanDemo
{
    private readonly List<Card> Cards = [new(1, "Backlog", "Accessibility audit", "Review keyboard paths"), new(2, "InProgress", "Dashboard", "Build revenue view"), new(3, "Done", "Project setup", "Create repository")];
    private sealed record Card(int Id, string Status, string Title, string Summary);
}
