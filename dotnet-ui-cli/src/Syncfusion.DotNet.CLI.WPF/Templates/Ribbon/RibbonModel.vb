

Namespace __ROOT_NAMESPACE__.Ribbon
    Public Class RibbonModel
        Inherits NotificationObject
        ''' <summary>
        ''' Maintains the font family for RibbonComboBox Control.
        ''' </summary>
        Private fontFamilyField As String

        ''' <summary>
        ''' Maintains the font size for RibbonComboBox Control.
        ''' </summary>
        Private fontSizeField As Integer

        ''' <summary>
        ''' Maintains the slide number.
        ''' </summary>
        Private slideNumberField As Integer

        ''' <summary>
        ''' Maintains the text inside the slide item.
        ''' </summary>
        Private itemTextField As String

        ''' <summary>
        ''' Maintains the description of each slide item.
        ''' </summary>
        Private descriptionField As String

        ''' <summary>
        ''' Gets or sets the font family of the <seecref="GettingStartedModel"/> class.
        ''' </summary>
        Public Property FontFamily As String
            Get
                Return fontFamilyField
            End Get
            Set(value As String)
                fontFamilyField = value
                RaisePropertyChanged("FontFamily")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the font size of the <seecref="GettingStartedModel"/> class.
        ''' </summary>
        Public Property FontSize As Integer
            Get
                Return fontSizeField
            End Get
            Set(value As Integer)
                fontSizeField = value
                RaisePropertyChanged("FontSize")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the value for slide number <seecref="GettingStartedModel"/> class.
        ''' </summary>
        Public Property SlideNumber As Integer
            Get
                Return slideNumberField
            End Get
            Set(value As Integer)
                slideNumberField = value
                RaisePropertyChanged("SlideNumber")
            End Set
        End Property

        ''' <summary>
        ''' Gets and sets the value for item text <seecref="GettingStartedModel"/> class.
        ''' </summary>
        Public Property ItemText As String
            Get
                Return itemTextField
            End Get
            Set(value As String)
                itemTextField = value
                RaisePropertyChanged("ItemText")
            End Set
        End Property

        ''' <summary>
        ''' Gets and sets the value for description <seecref="GettingStartedModel"/> class.
        ''' </summary>
        Public Property Description As String
            Get
                Return descriptionField
            End Get
            Set(value As String)
                descriptionField = value
                RaisePropertyChanged("Description")
            End Set
        End Property
    End Class
End Namespace
