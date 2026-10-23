Imports System.Runtime.CompilerServices

Imports System.ComponentModel

Namespace __ROOT_NAMESPACE__.DataGrid
    Public Class DataGridModel
        Implements INotifyPropertyChanged
        Private selectedField As Boolean
        Private employeeNameField As String = String.Empty
        Private designationField As String = String.Empty
        Private mailField As String = String.Empty
        Private trustworthinessField As String = String.Empty
        Private statusField As String = String.Empty
        Private softwareProficiencyField As Integer
        Private salaryField As Integer
        Private addressField As String = String.Empty
        Private genderField As String = String.Empty

        Public Sub New(selected As Boolean, name As String, designation As String, mail As String, location As String, trustworthiness As String, status As String, proficiency As Integer, salary As Integer, address As String, gender As String)
            Me.Selected = selected
            EmployeeName = name
            Me.Designation = designation
            Me.Mail = mail
            Me.Location = location
            Me.Trustworthiness = trustworthiness
            Me.Status = status
            SoftwareProficiency = proficiency
            Me.Salary = salary
            Me.Address = address
            Me.Gender = gender
        End Sub

        Public Property Selected As Boolean
            Get
                Return selectedField
            End Get
            Set(value As Boolean)
                SetProperty(selectedField, value)
            End Set
        End Property

        Public Property EmployeeName As String
            Get
                Return employeeNameField
            End Get
            Set(value As String)
                SetProperty(employeeNameField, value)
            End Set
        End Property

        Public Property Designation As String
            Get
                Return designationField
            End Get
            Set(value As String)
                SetProperty(designationField, value)
            End Set
        End Property

        Public Property Mail As String
            Get
                Return mailField
            End Get
            Set(value As String)
                SetProperty(mailField, value)
            End Set
        End Property

        Public Property Location As String

        Public Property Trustworthiness As String
            Get
                Return trustworthinessField
            End Get
            Set(value As String)
                SetProperty(trustworthinessField, value)
            End Set
        End Property

        Public Property Status As String
            Get
                Return statusField
            End Get
            Set(value As String)
                SetProperty(statusField, value)
            End Set
        End Property

        Public Property SoftwareProficiency As Integer
            Get
                Return softwareProficiencyField
            End Get
            Set(value As Integer)
                SetProperty(softwareProficiencyField, value)
            End Set
        End Property

        Public Property Salary As Integer
            Get
                Return salaryField
            End Get
            Set(value As Integer)
                SetProperty(salaryField, value)
            End Set
        End Property

        Public Property Address As String
            Get
                Return addressField
            End Get
            Set(value As String)
                SetProperty(addressField, value)
            End Set
        End Property

        Public Property Gender As String
            Get
                Return genderField
            End Get
            Set(value As String)
                SetProperty(genderField, value)
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub SetProperty(Of T)(ByRef field As T, value As T,
<CallerMemberName> Optional propertyName As String = Nothing)
            field = value
            RaisePropertyChanged(propertyName)
        End Sub

        Public Sub RaisePropertyChanged(propertyName As String)
            Dim handler = PropertyChangedEvent
            If handler IsNot Nothing Then
                handler(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
End Namespace
