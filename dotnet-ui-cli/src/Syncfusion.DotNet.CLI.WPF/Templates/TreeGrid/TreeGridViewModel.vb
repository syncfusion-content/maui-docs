
Imports System.Collections.ObjectModel

Namespace __ROOT_NAMESPACE__.TreeGrid
    Public Class TreeGridViewModel

        Public Sub New()
            Employees = GetEmployees()
        End Sub
        Private _employees As ObservableCollection(Of TreeGridModel)

        Public Property Employees As ObservableCollection(Of TreeGridModel)
            Get
                Return _employees
            End Get
            Set(value As ObservableCollection(Of TreeGridModel))
                _employees = value
            End Set
        End Property

        Private Function GetEmployees() As ObservableCollection(Of TreeGridModel)
            Dim employeeDetails As ObservableCollection(Of TreeGridModel) = New ObservableCollection(Of TreeGridModel)()
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Ferando",
                .LastName = "Joseph",
                .Title = "Management",
                .Salary = 2000000,
                .ReportsTo = -1,
                .ID = 2
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "John",
                .LastName = "Adams",
                .Title = "Accounts",
                .Salary = 2000000,
                .ReportsTo = -1,
                .ID = 3
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Thomas",
                .LastName = "Jefferson",
                .Title = "Sales",
                .Salary = 300000,
                .ReportsTo = -1,
                .ID = 4
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Andrew",
                .LastName = "Madison",
                .Title = "Marketing",
                .Salary = 4000000,
                .ReportsTo = -1,
                .ID = 5
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Ulysses",
                .LastName = "Pierce",
                .Title = "HumanResource",
                .Salary = 1500000,
                .ReportsTo = -1,
                .ID = 6
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Jimmy",
                .LastName = "Harrison",
                .Title = "Purchasing",
                .Salary = 200000,
                .ReportsTo = -1,
                .ID = 7
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Ronald",
                .LastName = "Fillmore",
                .Title = "Production",
                .Salary = 2800000,
                .ReportsTo = -1,
                .ID = 8
            })
            'Management

            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Andrew",
                .LastName = "Fuller",
                .ID = 9,
                .Salary = 1200000,
                .ReportsTo = 2,
                .Title = "Vice President"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Janet",
                .LastName = "Leverling",
                .ID = 10,
                .Salary = 1000000,
                .ReportsTo = 2,
                .Title = "GM"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Steven",
                .LastName = "Buchanan",
                .ID = 11,
                .Salary = 900000,
                .ReportsTo = 2,
                .Title = "Manager"
            })

            'Accounts
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Nancy",
                .LastName = "Davolio",
                .ID = 12,
                .Salary = 850000,
                .ReportsTo = 3,
                .Title = "Accounts Manager"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Margaret",
                .LastName = "Peacock",
                .ID = 13,
                .Salary = 700000,
                .ReportsTo = 3,
                .Title = "Accountant"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Michael",
                .LastName = "Suyama",
                .ID = 14,
                .Salary = 700000,
                .ReportsTo = 3,
                .Title = "Accountant"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Robert",
                .LastName = "King",
                .ID = 15,
                .Salary = 650000,
                .ReportsTo = 3,
                .Title = "Accountant"
            })

            'Sales
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Laura",
                .LastName = "Callahan",
                .ID = 16,
                .Salary = 900000,
                .ReportsTo = 4,
                .Title = "Sales Manager"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Anne",
                .LastName = "Dodsworth",
                .ID = 17,
                .Salary = 800000,
                .ReportsTo = 4,
                .Title = "Sales Representative"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Albert",
                .LastName = "Hellstern",
                .ID = 18,
                .Salary = 750000,
                .ReportsTo = 4,
                .Title = "Sales Representative"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Tim",
                .LastName = "Smith",
                .ID = 19,
                .Salary = 700000,
                .ReportsTo = 4,
                .Title = "Sales Representative"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Justin",
                .LastName = "Brid",
                .ID = 20,
                .Salary = 700000,
                .ReportsTo = 4,
                .Title = "Sales Representative"
            })

            'Back Office
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Caroline",
                .LastName = "Patterson",
                .ID = 21,
                .Salary = 800000,
                .ReportsTo = 5,
                .Title = "Receptionist"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Xavier",
                .LastName = "Martin",
                .ID = 22,
                .Salary = 700000,
                .ReportsTo = 5,
                .Title = "Mail Clerk"
            })

            'HR
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Laurent",
                .LastName = "Pereira",
                .ID = 23,
                .Salary = 900000,
                .ReportsTo = 6,
                .Title = "HR Manager"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Syed",
                .LastName = "Abbas",
                .ID = 24,
                .Salary = 650000,
                .ReportsTo = 6,
                .Title = "HR Assistant"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Amy",
                .LastName = "Alberts",
                .ID = 25,
                .Salary = 650000,
                .ReportsTo = 6,
                .Title = "HR Assistant"
            })

            'Purchasing

            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Pamela",
                .LastName = "Ansman-Wolfe",
                .ID = 26,
                .Salary = 600000,
                .ReportsTo = 7,
                .Title = "Purchase Manager"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Michael",
                .LastName = "Blythe",
                .ID = 27,
                .Salary = 550000,
                .ReportsTo = 7,
                .Title = "Store Keeper"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "David",
                .LastName = "Campbell",
                .ID = 28,
                .Salary = 450000,
                .ReportsTo = 7,
                .Title = "Store Keeper"
            })

            'Production
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Jillian",
                .LastName = "Carson",
                .ID = 29,
                .Salary = 600000,
                .ReportsTo = 8,
                .Title = "Production Manager"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Shu",
                .LastName = "Ito",
                .ID = 30,
                .Salary = 550000,
                .ReportsTo = 8,
                .Title = "Production Engineer"
            })
            employeeDetails.Add(New TreeGridModel() With {
                .FirstName = "Stephen",
                .LastName = "Jiang",
                .ID = 31,
                .Salary = 450000,
                .ReportsTo = 8,
                .Title = "Production Engineer"
            })

            Return employeeDetails
        End Function
    End Class
End Namespace
