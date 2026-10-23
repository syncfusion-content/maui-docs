#nullable disable
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__
    {

        public __VIEW_MODEL_NAME__()
        {
            this.Employees = this.GetEmployees();
        }
        private ObservableCollection<TreeGridModel> _employees;

        public ObservableCollection<TreeGridModel> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        private ObservableCollection<TreeGridModel> GetEmployees()
        {
            ObservableCollection<TreeGridModel> employeeDetails = new ObservableCollection<TreeGridModel>();
            employeeDetails.Add(new TreeGridModel() { FirstName = "Ferando", LastName = "Joseph", Title = "Management", Salary = 2000000, ReportsTo = -1, ID = 2 });
            employeeDetails.Add(new TreeGridModel() { FirstName = "John", LastName = "Adams", Title = "Accounts", Salary = 2000000, ReportsTo = -1, ID = 3 });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Thomas", LastName = "Jefferson", Title = "Sales", Salary = 300000, ReportsTo = -1, ID = 4 });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Andrew", LastName = "Madison", Title = "Marketing", Salary = 4000000, ReportsTo = -1, ID = 5 });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Ulysses", LastName = "Pierce", Title = "HumanResource", Salary = 1500000, ReportsTo = -1, ID = 6 });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Jimmy", LastName = "Harrison", Title = "Purchasing", Salary = 200000, ReportsTo = -1, ID = 7 });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Ronald", LastName = "Fillmore", Title = "Production", Salary = 2800000, ReportsTo = -1, ID = 8 });
            //Management

            employeeDetails.Add(new TreeGridModel() { FirstName = "Andrew", LastName = "Fuller", ID = 9, Salary = 1200000, ReportsTo = 2, Title = "Vice President" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Janet", LastName = "Leverling", ID = 10, Salary = 1000000, ReportsTo = 2, Title = "GM" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Steven", LastName = "Buchanan", ID = 11, Salary = 900000, ReportsTo = 2, Title = "Manager" });

            //Accounts
            employeeDetails.Add(new TreeGridModel() { FirstName = "Nancy", LastName = "Davolio", ID = 12, Salary = 850000, ReportsTo = 3, Title = "Accounts Manager" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Margaret", LastName = "Peacock", ID = 13, Salary = 700000, ReportsTo = 3, Title = "Accountant" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Michael", LastName = "Suyama", ID = 14, Salary = 700000, ReportsTo = 3, Title = "Accountant" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Robert", LastName = "King", ID = 15, Salary = 650000, ReportsTo = 3, Title = "Accountant" });

            //Sales
            employeeDetails.Add(new TreeGridModel() { FirstName = "Laura", LastName = "Callahan", ID = 16, Salary = 900000, ReportsTo = 4, Title = "Sales Manager" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Anne", LastName = "Dodsworth", ID = 17, Salary = 800000, ReportsTo = 4, Title = "Sales Representative" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Albert", LastName = "Hellstern", ID = 18, Salary = 750000, ReportsTo = 4, Title = "Sales Representative" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Tim", LastName = "Smith", ID = 19, Salary = 700000, ReportsTo = 4, Title = "Sales Representative" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Justin", LastName = "Brid", ID = 20, Salary = 700000, ReportsTo = 4, Title = "Sales Representative" });

            //Back Office
            employeeDetails.Add(new TreeGridModel() { FirstName = "Caroline", LastName = "Patterson", ID = 21, Salary = 800000, ReportsTo = 5, Title = "Receptionist" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Xavier", LastName = "Martin", ID = 22, Salary = 700000, ReportsTo = 5, Title = "Mail Clerk" });

            //HR
            employeeDetails.Add(new TreeGridModel() { FirstName = "Laurent", LastName = "Pereira", ID = 23, Salary = 900000, ReportsTo = 6, Title = "HR Manager" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Syed", LastName = "Abbas", ID = 24, Salary = 650000, ReportsTo = 6, Title = "HR Assistant" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Amy", LastName = "Alberts", ID = 25, Salary = 650000, ReportsTo = 6, Title = "HR Assistant" });

            //Purchasing

            employeeDetails.Add(new TreeGridModel() { FirstName = "Pamela", LastName = "Ansman-Wolfe", ID = 26, Salary = 600000, ReportsTo = 7, Title = "Purchase Manager" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Michael", LastName = "Blythe", ID = 27, Salary = 550000, ReportsTo = 7, Title = "Store Keeper" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "David", LastName = "Campbell", ID = 28, Salary = 450000, ReportsTo = 7, Title = "Store Keeper" });

            //Production
            employeeDetails.Add(new TreeGridModel() { FirstName = "Jillian", LastName = "Carson", ID = 29, Salary = 600000, ReportsTo = 8, Title = "Production Manager" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Shu", LastName = "Ito", ID = 30, Salary = 550000, ReportsTo = 8, Title = "Production Engineer" });
            employeeDetails.Add(new TreeGridModel() { FirstName = "Stephen", LastName = "Jiang", ID = 31, Salary = 450000, ReportsTo = 8, Title = "Production Engineer" });

            return employeeDetails;
        }
    }
}
