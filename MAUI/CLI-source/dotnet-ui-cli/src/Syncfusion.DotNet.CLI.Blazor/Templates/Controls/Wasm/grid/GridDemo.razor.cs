using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System.Collections.ObjectModel;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Inputs;
using System.ComponentModel.DataAnnotations;

namespace __PAGE_NAMESPACE__;

public partial class GridDemo
{
    SfGrid<Employee>? Grid;

    // Toolbar items
    List<string> ToolbarItems = new()
    {
        "Add", "Edit", "Delete", "Update", "Cancel",
        "Search", "ColumnChooser",
        "ExcelExport", "PdfExport", "CsvExport"
    };

    // Context Menu
    List<object> ContextMenuItems = new()
    {
        "AutoFit",
        "AutoFitAll",
        "SortAscending",
        "SortDescending",
        "Copy",
        "Edit",
        "Delete",
        "Save",
        "Cancel"
    };

    // Per-column FilterSettings (reused)
    FilterSettings MenuFilter = new() { Type = Syncfusion.Blazor.Grids.FilterType.Menu };
    FilterSettings ExcelFilter = new() { Type = Syncfusion.Blazor.Grids.FilterType.Excel };
    FilterSettings CheckBoxFilter = new() { Type = Syncfusion.Blazor.Grids.FilterType.CheckBox };

    public async Task ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "Grid_pdfexport")  //Id is combination of Grid's ID and itemname.
        {
            await Grid!.ExportToPdfAsync();
        }
        else if (args.Item.Id == "Grid_excelexport") //Id is combination of Grid's ID and itemname.
        {
            await Grid!.ExportToExcelAsync();
        }
        else if (args.Item.Id == "Grid_csvexport")
        {
            await Grid!.ExportToCsvAsync();
        }
    }

    // Local Data
    List<Employee> Employees = new()
    {
        new() { Id = 1, Name="Arun Kumar", Department="IT", Designation="Developer", Salary=60000, IsActive=true, Email="arun.kumar@example.com" },
        new() { Id = 2, Name="Bala Subramani", Department="HR", Designation="Manager", Salary=75000, IsActive=true, Email="bala.subramani@example.com" },
        new() { Id = 3, Name="Charan Raj", Department="Finance", Designation="Analyst", Salary=65000, IsActive=false, Email="charan.raj@example.com" },
        new() { Id = 4, Name="Deepa Nair", Department="IT", Designation="Lead", Salary=90000, IsActive=true, Email="deepa.nair@example.com" },
        new() { Id = 5, Name="Ezhil Selvan", Department="Admin", Designation="Executive", Salary=55000, IsActive=true, Email="ezhil.selvan@example.com" },

        new() { Id = 6, Name="Farooq Ahmed", Department="Finance", Designation="Auditor", Salary=72000, IsActive=false, Email="farooq.ahmed@example.com" },
        new() { Id = 7, Name="Gayathri R", Department="HR", Designation="Recruiter", Salary=58000, IsActive=true, Email="gayathri.r@example.com" },
        new() { Id = 8, Name="Hari Prasad", Department="IT", Designation="Tester", Salary=62000, IsActive=true, Email="hari.prasad@example.com" },
        new() { Id = 9, Name="Indhu Mathi", Department="Marketing", Designation="Coordinator", Salary=54000, IsActive=true, Email="indhu.mathi@example.com" },
        new() { Id = 10, Name="Jagan Mohan", Department="Sales", Designation="Sales Executive", Salary=57000, IsActive=true, Email="jagan.mohan@example.com" },

        new() { Id = 11, Name="Karthick S", Department="IT", Designation="Senior Developer", Salary=95000, IsActive=true, Email="karthick.s@example.com" },
        new() { Id = 12, Name="Lakshmi Priya", Department="HR", Designation="HR Executive", Salary=52000, IsActive=true, Email="lakshmi.priya@example.com" },
        new() { Id = 13, Name="Manoj Kumar", Department="Finance", Designation="Accountant", Salary=68000, IsActive=false, Email="manoj.kumar@example.com" },
        new() { Id = 14, Name="Nandhini V", Department="IT", Designation="UI Designer", Salary=70000, IsActive=true, Email="nandhini.v@example.com" },
        new() { Id = 15, Name="Om Prakash", Department="Admin", Designation="Office Manager", Salary=64000, IsActive=true, Email="om.prakash@example.com" },

        new() { Id = 16, Name="Priya Dharshini", Department="Marketing", Designation="Content Specialist", Salary=60000, IsActive=true, Email="priya.dharshini@example.com" },
        new() { Id = 17, Name="Qadir Khan", Department="Sales", Designation="Regional Manager", Salary=88000, IsActive=true, Email="qadir.khan@example.com" },
        new() { Id = 18, Name="Ramesh Babu", Department="IT", Designation="DevOps Engineer", Salary=92000, IsActive=true, Email="ramesh.babu@example.com" },
        new() { Id = 19, Name="Sangeetha M", Department="Finance", Designation="Cost Analyst", Salary=67000, IsActive=false, Email="sangeetha.m@example.com" },
        new() { Id = 20, Name="Tharun Raj", Department="IT", Designation="Intern", Salary=30000, IsActive=true, Email="tharun.raj@example.com" },

        new() { Id = 21, Name="Usha Rani", Department="HR", Designation="Training Lead", Salary=78000, IsActive=true, Email="usha.rani@example.com" },
        new() { Id = 22, Name="Vigneshwaran K", Department="IT", Designation="Architect", Salary=120000, IsActive=true, Email="vigneshwaran.k@example.com" },
        new() { Id = 23, Name="Wasim Akram", Department="Sales", Designation="Sales Analyst", Salary=61000, IsActive=false, Email="wasim.akram@example.com" },
        new() { Id = 24, Name="Xavier Paul", Department="Admin", Designation="Facilities Lead", Salary=59000, IsActive=true, Email="xavier.paul@example.com" },
        new() { Id = 25, Name="Yamini Devi", Department="Marketing", Designation="SEO Analyst", Salary=63000, IsActive=true, Email="yamini.devi@example.com" },

        new() { Id = 26, Name="Zahir Hussain", Department="Finance", Designation="Compliance Officer", Salary=82000, IsActive=true, Email="zahir.hussain@example.com" },
        new() { Id = 27, Name="Anitha Joseph", Department="IT", Designation="Support Engineer", Salary=56000, IsActive=true, Email="anitha.joseph@example.com" },
        new() { Id = 28, Name="Bhaskar Rao", Department="Sales", Designation="Business Development Manager", Salary=87000, IsActive=true, Email="bhaskar.rao@example.com" },
        new() { Id = 29, Name="Chitra Iyer", Department="HR", Designation="Policy Specialist", Salary=71000, IsActive=false, Email="chitra.iyer@example.com" },
        new() { Id = 30, Name="Dinesh Kumar", Department="IT", Designation="Product Owner", Salary=110000, IsActive=true, Email="dinesh.kumar@example.com" },
    };

    // Model with validation
    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3)]
        public string? Name { get; set; }

        [Required]
        public string? Department { get; set; }

        [Required]
        public string? Designation { get; set; }

        [Range(10000, 200000, ErrorMessage = "Salary must be between 10,000 and 200,000")]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string? Email { get; set; }
    }
}
