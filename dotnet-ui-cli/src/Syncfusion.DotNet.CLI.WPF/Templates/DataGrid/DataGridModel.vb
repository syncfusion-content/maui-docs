

Namespace __ROOT_NAMESPACE__.DataGrid
    Public Class DataGridModel
        Inherits NotificationObject
#Region "Private members"

        Private _name As String
        Private _designation As String
        Private _mail As String
        Private _trust As String
        Private _rating As Integer
        Private _salary As Integer
        Private _address As String
        Private _gender As String
#End Region

        Public Sub New()

        End Sub

        Public Sub New(name As String, designation As String, mail As String, location As String, trust As String, rating As Integer, salary As Integer, address As String, gender As String)
            EmployeeName = name
            Me.Designation = designation
            Me.Mail = mail
            Me.Location = location
            Trustworthiness = trust
            Me.Rating = rating
            Me.Salary = salary
            Me.Address = address
            Me.Gender = gender
        End Sub

        ''' <summary>
        ''' Gets or sets the employee name.
        ''' </summary>
        Public Property EmployeeName As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
                RaisePropertyChanged("EmployeeName")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the designation.
        ''' </summary>
        Public Property Designation As String
            Get
                Return _designation
            End Get
            Set(value As String)
                _designation = value
                RaisePropertyChanged("Designation")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the mail ID.
        ''' </summary>
        Public Property Mail As String
            Get
                Return _mail
            End Get
            Set(value As String)
                _mail = value
                RaisePropertyChanged("Mail")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the location.
        ''' </summary>
        Public Property Location As String

        ''' <summary>
        ''' Gets or sets the Trustworthiness.
        ''' </summary>
        Public Property Trustworthiness As String
            Get
                Return _trust
            End Get
            Set(value As String)
                _trust = value
                RaisePropertyChanged("Trustworthiness")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the rating.
        ''' </summary>
        Public Property Rating As Integer
            Get
                Return _rating
            End Get
            Set(value As Integer)
                _rating = value
                RaisePropertyChanged("Rating")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the salary.
        ''' </summary>
        Public Property Salary As Integer
            Get
                Return _salary
            End Get
            Set(value As Integer)
                _salary = value
                RaisePropertyChanged("Salary")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the address.
        ''' </summary>
        Public Property Address As String
            Get
                Return _address
            End Get
            Set(value As String)
                _address = value
                RaisePropertyChanged("Address")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the gender
        ''' </summary>
        Public Property Gender As String
            Get
                Return _gender
            End Get
            Set(value As String)
                _gender = value
            End Set
        End Property
    End Class
End Namespace
