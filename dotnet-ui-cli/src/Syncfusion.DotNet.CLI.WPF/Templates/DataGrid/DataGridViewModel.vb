
Imports System
Imports System.Collections.Generic
Imports System.Windows.Data
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Globalization
Imports System.Runtime.CompilerServices

Namespace __ROOT_NAMESPACE__.DataGrid
    Public Class DataGridViewModel
        Implements INotifyPropertyChanged
#Region "Constructor"
        ''' <summary>
        ''' Initializes a new instance of the <seecref="DataGridViewModel"/> class.
        ''' </summary>
        Public Sub New()
            Gender = New List(Of String)()
            Gender.Add("Male")
            Gender.Add("Female")

            Trustworthiness = New List(Of String)()
            Trustworthiness.Add("Sufficient")
            Trustworthiness.Add("Insufficient")
            Trustworthiness.Add("Perfect")
            EmployeeDetails = GetEmployeeDetails(50)
        End Sub

#End Region

#Region "Properties"

        Public Property Trustworthiness As List(Of String)

        Private _employeeDetails As ObservableCollection(Of DataGridModel) = New ObservableCollection(Of DataGridModel)()

        Public Property EmployeeDetails As ObservableCollection(Of DataGridModel)
            Get
                Return _employeeDetails
            End Get
            Set(value As ObservableCollection(Of DataGridModel))
                _employeeDetails = value
            End Set
        End Property
        Public Property Gender As List(Of String)

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub [Set](Of T)(ByRef storage As T, value As T,
<CallerMemberName> Optional propertyName As String = Nothing)
            If Equals(storage, value) Then
                Return
            End If

            storage = value
            OnPropertyChanged(propertyName)
        End Sub

        Protected Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

#End Region

#Region "Method"

        Public Function GetEmployeeDetails(count As Integer) As ObservableCollection(Of DataGridModel)
            Dim random As Random = New Random()
            Dim ordersDetails As ObservableCollection(Of DataGridModel) = New ObservableCollection(Of DataGridModel)()

            For i = 10000 To count + 10000 - 1
                Dim name = employees(random.Next(25))
                Dim index = Array.IndexOf(employees, name)
                Dim genders = Gender(genderField(index))
                ordersDetails.Add(New DataGridModel(name, designation(random.Next(6)), name.ToLower() & "@" & mail(random.Next(4)), location(random.Next(8)), trust(random.Next(3)), random.Next(1, 5), random.Next(100000, 400000), address(random.Next(1, 25)), genders))
            Next

            Return ordersDetails
        End Function
#End Region

#Region "Collections"

        Private employees As String() = {"Michael", "Kathryn", "Tamer", "Martin", "Davolio", "Nancy", "Fuller", "Leverling", "Therasa", "Margaret", "Buchanan", "Janet", "Andrew", "Callahan", "Laura", "Dodsworth", "Anne", "Bergs", "Vinet", "Anto", "Fleet", "Zachery", "Van", "Edward", "Jack", "Rose"}
        Private genderField As Integer() = {0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1}
        Private designation As String() = {"Manager", "CFO", "Designer", "Developer", "Program Directory", "System Analyst", "Project Lead"}
        Private mail As String() = {"arpy.com", "sample.com", "rpy.com", "jourrapide.com"}
        Private trust As String() = {"Sufficient", "Perfect", "Insufficient"}
        Private location As String() = {"UK", "USA", "Sweden", "France", "Canada", "Argentina", "Austria", "Germany", "Mexico"}
        Private address As String() = {"59 rue de lAbbaye", "Luisenstr. 48", " Rua do Paço 67", "2 rue du Commerce", "Boulevard Tirou 255", "Rua do mailPaço 67", "Hauptstr. 31", "Starenweg 5", "Rua do Mercado, 12", "Carrera 22 con Ave.", " Carlos Soublette #8-35", "Kirchgasse 6", "Sierras de Granada 9993", "Mehrheimerstr. 369", "Rua da Panificadora 12", "2817 Milton Dr.", "Kirchgasse 6", "Åkergatan 24", "24, place Kléber", "Torikatu 38", "Berliner Platz 43", "5ª Ave. Los Palos Grandes", "1029 - 12th Ave. S.", "Torikatu 38", "P.O. Box 555", "2817 Milton Dr.", "Taucherstraße 10", "59 rue de lAbbaye", "Via Ludovico il Moro 22", "Avda. Azteca 123", "Heerstr. 22", "Berguvsvägen  8", "Magazinweg 7", "Berguvsvägen  8", "Gran Vía, 1", "Gran Vía, 1", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Magazinweg 7", "Taucherstraße 10", "Taucherstraße 10"}

#End Region
    End Class

    Public Class SelectedImageConverter
        Implements IValueConverter
        ''' <summary>
        ''' Converts a value.
        ''' </summary>
        ''' <paramname="value">The value produced by the binding source.</param>
        ''' <paramname="targetType">The type of the binding target property.</param>
        ''' <paramname="parameter">The converter parameter to use.</param>
        ''' <paramname="info">The culture to use in the converter.</param>
        ''' <returns>
        ''' A converted value. If the method returns null, the valid null value is used.
        ''' </returns>
        Private Function Convert(value As Object, targetType As Type, parameter As Object, info As CultureInfo) As Object Implements IValueConverter.Convert

            If value Is Nothing Then Return Nothing
            Return "/__ROOT_NAMESPACE__;component/DataGrid/Resources/Employee.png"
        End Function

        ''' <summary>
        ''' Converts a value.
        ''' </summary>
        ''' <paramname="value">The value that is produced by the binding target.</param>
        ''' <paramname="targetType">The type to convert to.</param>
        ''' <paramname="parameter">The converter parameter to use.</param>
        ''' <paramname="info">The culture to use in the converter.</param>
        ''' <returns>
        ''' A converted value. If the method returns null, the valid null value is used.
        ''' </returns>
        Private Function ConvertBack(value As Object, targetType As Type, parameter As Object, info As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class StringToImageConverter
        Implements IValueConverter
        Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
            If value IsNot Nothing Then
                Dim str As String = value.ToString()

                If Equals(str, "Sufficient") Then
                    Return "/__ROOT_NAMESPACE__;component/DataGrid/Resources/Sufficient.png"
                ElseIf Equals(str, "Insufficient") Then
                    Return "/__ROOT_NAMESPACE__;component/DataGrid/Resources/Insufficient.png"
                ElseIf Equals(str, "Perfect") Then
                    Return "/__ROOT_NAMESPACE__;component/DataGrid/Resources/Perfect.png"
                End If
            End If
            Return Nothing
        End Function

        Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
