
Imports System
Imports System.Collections.ObjectModel

Namespace __ROOT_NAMESPACE__.DataGrid
    Public Class DataGridViewModel
        Public Property EmployeeDetails As ObservableCollection(Of DataGridModel)

        Public Sub New()
            EmployeeDetails = GetEmployeeDetails(100)
        End Sub

        Public Function GetEmployeeDetails(count As Integer) As ObservableCollection(Of DataGridModel)
            Dim employees = {"Michael", "Kathryn", "Tamer", "Martin", "Davolio", "Nancy", "Fuller", "Leverling", "Therasa", "Margaret", "Buchanan", "Janet", "Andrew", "Callahan", "Laura", "Dodsworth", "Anne", "Bergs", "Vinet", "Anto", "Fleet", "Zachery", "Van", "Edward", "Jack", "Rose"}
            Dim genders = {"1", "2", "1", "1", "2", "2", "1", "2", "2", "2", "1", "2", "1", "1", "2", "1", "2", "1", "1", "1", "1", "1", "1", "1", "1", "2"}
            Dim designations = {"Manager", "CFO", "Designer", "Developer", "Program Directory", "System Analyst", "Project Lead"}
            Dim mailDomains = {"arpy.com", "sample.com", "rpy.com", "jourrapide.com"}
            Dim trustworthiness = {"Sufficient", "Perfect", "Insufficient"}
            Dim statuses = {"Active", "Inactive"}
            Dim locations = {"UK", "USA", "Sweden", "France", "Canada", "Argentina", "Austria", "Germany", "Mexico"}
            Dim addresses = {"59 rue de lAbbaye", "Luisenstr. 48", " Rua do Paço 67", "2 rue du Commerce", "Boulevard Tirou 255", "Rua do mailPaço 67", "Hauptstr. 31", "Starenweg 5", "Rua do Mercado, 12", "Carrera 22 con Ave.", " Carlos Soublette #8-35", "Kirchgasse 6", "Sierras de Granada 9993", "Mehrheimerstr. 369", "Rua da Panificadora 12", "2817 Milton Dr.", "Kirchgasse 6", "Åkergatan 24", "24, place Kléber", "Torikatu 38", "Berliner Platz 43", "5ª Ave. Los Palos Grandes", "1029 - 12th Ave. S.", "Torikatu 38", "P.O. Box 555", "2817 Milton Dr.", "Taucherstraße 10", "59 rue de lAbbaye", "Via Ludovico il Moro 22", "Avda. Azteca 123", "Heerstr. 22", "Berguvsvägen  8", "Magazinweg 7", "Berguvsvägen  8", "Gran Vía, 1", "Gran Vía, 1", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Magazinweg 7", "Taucherstraße 10", "Taucherstraße 10"}

            Dim random = New Random()
            Dim employeesDetails = New ObservableCollection(Of DataGridModel)()
            For index = 10000 To count + 10000 - 1
                Dim name = employees(random.Next(25))
                Dim gender = genders(Array.IndexOf(employees, name))
                employeesDetails.Add(New DataGridModel(index Mod 2 = -1, name, designations(random.Next(6)), name.ToLower() & "@" & mailDomains(random.Next(4)), locations(random.Next(8)), trustworthiness(random.Next(3)), statuses(random.Next(2)), random.Next(1, 100), random.Next(100000, 400000), addresses(random.Next(1, 25)), gender))
            Next

            Return employeesDetails
        End Function
    End Class
End Namespace
