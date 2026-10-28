


Namespace __ROOT_NAMESPACE__.TreeGrid
    Public Class TreeGridModel
        Private _id As Integer
        Private _firstName As String
        Private _lastName As String
        Private _title As String
        Private _salary As Double?
        Private _reportsTo As Integer

        Public Property FirstName As String
            Get
                Return _firstName
            End Get
            Set(value As String)
                _firstName = value
            End Set
        End Property

        Public Property LastName As String
            Get
                Return _lastName
            End Get
            Set(value As String)
                _lastName = value
            End Set
        End Property

        Public Property ID As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property Title As String
            Get
                Return _title
            End Get
            Set(value As String)
                _title = value
            End Set
        End Property

        Public Property Salary As Double?
            Get
                Return _salary
            End Get
            Set(value As Double?)
                _salary = value
            End Set
        End Property

        Public Property ReportsTo As Integer
            Get
                Return _reportsTo
            End Get
            Set(value As Integer)
                _reportsTo = value
            End Set
        End Property
    End Class
End Namespace
