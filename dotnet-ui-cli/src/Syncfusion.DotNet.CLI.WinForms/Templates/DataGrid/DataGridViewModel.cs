#nullable disable
using System;
using System.Collections.ObjectModel;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__
    {
        public ObservableCollection<DataGridModel> EmployeeDetails { get; set; }

        public __VIEW_MODEL_NAME__()
        {
            EmployeeDetails = GetEmployeeDetails(100);
        }

        public ObservableCollection<DataGridModel> GetEmployeeDetails(int count)
        {
            string[] employees = { "Michael", "Kathryn", "Tamer", "Martin", "Davolio", "Nancy", "Fuller", "Leverling", "Therasa",
                "Margaret", "Buchanan", "Janet", "Andrew", "Callahan", "Laura", "Dodsworth", "Anne",
                "Bergs", "Vinet", "Anto", "Fleet", "Zachery", "Van", "Edward", "Jack", "Rose" };
            string[] genders = { "1", "2", "1", "1", "2", "2", "1", "2", "2", "2", "1", "2", "1", "1", "2", "1", "2", "1", "1", "1", "1", "1", "1", "1", "1", "2" };
            string[] designations = { "Manager", "CFO", "Designer", "Developer", "Program Directory", "System Analyst", "Project Lead" };
            string[] mailDomains = { "arpy.com", "sample.com", "rpy.com", "jourrapide.com" };
            string[] trustworthiness = { "Sufficient", "Perfect", "Insufficient" };
            string[] statuses = { "Active", "Inactive" };
            string[] locations = { "UK", "USA", "Sweden", "France", "Canada", "Argentina", "Austria", "Germany", "Mexico" };
            string[] addresses = { "59 rue de lAbbaye", "Luisenstr. 48", " Rua do Paço 67", "2 rue du Commerce", "Boulevard Tirou 255",
                "Rua do mailPaço 67", "Hauptstr. 31", "Starenweg 5", "Rua do Mercado, 12", "Carrera 22 con Ave.",
                " Carlos Soublette #8-35", "Kirchgasse 6", "Sierras de Granada 9993", "Mehrheimerstr. 369",
                "Rua da Panificadora 12", "2817 Milton Dr.", "Kirchgasse 6", "Åkergatan 24", "24, place Kléber",
                "Torikatu 38", "Berliner Platz 43", "5ª Ave. Los Palos Grandes", "1029 - 12th Ave. S.",
                "Torikatu 38", "P.O. Box 555", "2817 Milton Dr.", "Taucherstraße 10", "59 rue de lAbbaye",
                "Via Ludovico il Moro 22", "Avda. Azteca 123", "Heerstr. 22", "Berguvsvägen  8", "Magazinweg 7",
                "Berguvsvägen  8", "Gran Vía, 1", "Gran Vía, 1", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                "Magazinweg 7", "Taucherstraße 10", "Taucherstraße 10" };

            var random = new Random();
            var employeesDetails = new ObservableCollection<DataGridModel>();
            for (var index = 10000; index < count + 10000; index++)
            {
                var name = employees[random.Next(25)];
                var gender = genders[Array.IndexOf(employees, name)];
                employeesDetails.Add(new DataGridModel(
                    index % 2 == -1,
                    name,
                    designations[random.Next(6)],
                    name.ToLower() + "@" + mailDomains[random.Next(4)],
                    locations[random.Next(8)],
                    trustworthiness[random.Next(3)],
                    statuses[random.Next(2)],
                    random.Next(1, 100),
                    random.Next(100000, 400000),
                    addresses[random.Next(1, 25)],
                    gender));
            }

            return employeesDetails;
        }
    }
}
