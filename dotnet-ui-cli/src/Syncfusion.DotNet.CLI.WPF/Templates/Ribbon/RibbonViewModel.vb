Imports System.IO
Imports System.Diagnostics
Imports Syncfusion.Windows.Tools
Imports Syncfusion.Windows.Tools.Controls

Imports System
Imports System.Windows
Imports System.Windows.Media
Imports System.Windows.Documents
Imports Microsoft.Win32
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Controls
Imports System.Windows.Input

Namespace __ROOT_NAMESPACE__.Ribbon
    Public Class RibbonViewModel
        Inherits NotificationObject
        Implements INotifyPropertyChanged
        ''' <summary>
        ''' Maintains the command for remove style
        ''' </summary>
        Private removeStyleCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for minimize ribbon
        ''' </summary>
        Private minimizeRibbonCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for rich textBox selection change
        ''' </summary>
        Private richTextBoxSelectionChangedCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for mouse left button up.
        ''' </summary>
        Private richTextBoxPreviewMouseLeftButtonUpCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for buttons
        ''' </summary>
        Private buttonCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for dropdown
        ''' </summary>
        Private dropdownCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for save as backstage item.
        ''' </summary>
        Private saveAsCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for open backstage item.
        ''' </summary>
        Private openCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for close backstage item.
        ''' </summary>
        Private closeCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for backStage exit click.
        ''' </summary>
        Private backStageExitCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for return to editor button in info backStage.
        ''' </summary>
        Private returnToEditorCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for onilne help button in help backStage.
        ''' </summary>
        Private onlineHelpCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for getting started button in help backStage.
        ''' </summary>
        Private gettingStartedHelpCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 1st gallery item.
        ''' </summary>
        Private galleryItemOneCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 2nd gallery item.
        ''' </summary>
        Private galleryItemTwoCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 3rd gallery item.
        ''' </summary>
        Private galleryItemThreeCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 4th gallery item.
        ''' </summary>
        Private galleryItemFourCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 5th gallery item.
        ''' </summary>
        Private galleryItemFiveCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 6th gallery item.
        ''' </summary>
        Private galleryItemSixCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 7th gallery item.
        ''' </summary>
        Private galleryItemSevenCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 8th gallery item.
        ''' </summary>
        Private galleryItemEightCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 9th gallery item.
        ''' </summary>
        Private galleryItemNineCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 10th gallery item.
        ''' </summary>
        Private galleryItemTenCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for closing application menu.
        ''' </summary>
        Private applicationMenuCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 11th gallery item.
        ''' </summary>
        Private galleryItemElevenCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 12th gallery item.
        ''' </summary>
        Private galleryItemTwelveCommandField As ICommand

        ''' <summary>
        ''' Maintains the command for 13th gallery item.
        ''' </summary>
        Private galleryItemThirteenCommandField As ICommand

        ''' <summary>
        ''' Maintains the bold is selected or not
        ''' </summary>
        Private isFormatBoldSelectedField As Boolean

        ''' <summary>
        ''' Maintains the italic is selected or not
        ''' </summary>
        Private isFormatItalicSelectedField As Boolean

        ''' <summary>
        ''' Maintains the underline is selected or not
        ''' </summary>
        Private isFormatUnderLineSelectedField As Boolean

        ''' <summary>
        ''' Maintains the Header Row selection.
        ''' </summary>
        Private isHeaderRowCheckedField As Boolean = True

        ''' <summary>
        ''' Maintains the Total Row selection.
        ''' </summary>
        Private isTotalRowCheckedField As Boolean = False

        ''' <summary>
        ''' Maintains the Banded Row selection.
        ''' </summary>
        Private isBandedRowCheckedField As Boolean = False

        ''' <summary>
        ''' Maintains the First Column selection.
        ''' </summary>
        Private isFirstColumnCheckedField As Boolean = True

        ''' <summary>
        ''' Maintains the Last Column selection.
        ''' </summary>
        Private isLastColumnCheckedField As Boolean = False

        ''' <summary>
        ''' Maintains the Banded Column selection.
        ''' </summary>
        Private isBandedColumnCheckedField As Boolean = False

        ''' <summary>
        ''' Maintains the collection of font family.
        ''' </summary>
        Private fontFamilyListField As ObservableCollection(Of RibbonModel) = New ObservableCollection(Of RibbonModel)()

        ''' <summary>
        ''' Maintains the collection of font size.
        ''' </summary>
        Private fontSizeListField As ObservableCollection(Of RibbonModel) = New ObservableCollection(Of RibbonModel)()

        ''' <summary>
        ''' Maintains the ribbon properties.
        ''' </summary>
        Private Shared ribbon As Syncfusion.Windows.Tools.Controls.Ribbon = Nothing

        ''' <summary>
        ''' Maintains the richTextBox properties.
        ''' </summary>
        Private Shared richTextBox As RichTextBox = Nothing

        ''' <summary>
        ''' Maintains the mini tool bar.
        ''' </summary>
        Private toolBar As MiniToolbar

        ''' <summary>
        ''' Initializes a new instance of the <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public Sub New()
            CommonResourceDictionary = New ResourceDictionary() With {
                .Source = New Uri("/__ROOT_NAMESPACE__;component/Ribbon/Resources/PathIcon.xaml", UriKind.RelativeOrAbsolute)
            }
            CreateMiniToolBar()
            IsHeaderRowChecked = True
            removeStyleCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteRemoveStyleCommand)
            minimizeRibbonCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteMinimizeRibbonCommand)
            galleryItemOneCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemOneCommand)
            galleryItemTwoCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemTwoCommand)
            galleryItemThreeCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemThreeCommand)
            galleryItemFourCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemFourCommand)
            galleryItemFiveCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemFiveCommand)
            galleryItemSixCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemSixCommand)
            galleryItemSevenCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemSevenCommand)
            galleryItemEightCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemEightCommand)
            galleryItemNineCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemNineCommand)
            galleryItemTenCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemTenCommand)
            galleryItemElevenCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemElevenCommand)
            galleryItemTwelveCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemTwelveCommand)
            galleryItemThirteenCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGalleryItemThirteenCommand)
            saveAsCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteSaveAsCommand)
            openCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteOpenCommand)
            closeCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteCloseCommand)
            applicationMenuCommandField = New DelegateCommand(Of Object)(AddressOf ExecuuteApplicationMenuCommand)
            buttonCommandField = New DelegateCommand(Of Object)(AddressOf ButtonCommandExecute)
            dropdownCommandField = New DelegateCommand(Of Object)(AddressOf DropDownCommandExecute)
            backStageExitCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteBackStageExitCommand)
            onlineHelpCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteOnlineHelpCommand)
            gettingStartedHelpCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteGettingStartedCommand)
            returnToEditorCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteReturnToEditorCommand)
            toolBar.PlacementTarget = richTextBox
            richTextBoxPreviewMouseLeftButtonUpCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteRichTextBoxPreviewMouseLeftButtonUpCommand)
            richTextBoxSelectionChangedCommandField = New DelegateCommand(Of Object)(AddressOf ExecuteRichTextBoxSelectionChangedCommand)
            TitleText = "WPF Ribbon"
            FirstParagraphText = "Ribbon illustrates the implementation of Office UI with Ribbon items and Backstage. Our product exposes most features of the new UI while conforming to the WPF architecture. Configuring and designing the layout is very easy when using XAML code. RibbonWindow has been implemented for giving a themed Office 2016 UI look and feel to the traditional window. Users can experience full-keyboard navigation. Key Tips are provided for faster access of items within the Ribbon. Enhanced tooltips help users use and understand the application very easily."
            SecondTitleText = "Interactive  Features"
            PointOne = "Ribbon Window that overrides the default window and displays Office style windows."
            PointTwo = "RibbonTab is available to add different tabs like in Microsoft Outlook."
            PointThree = "Ribbon Bar structures the layouts."
            PointFour = "Ribbon Bar Modes - LargeButton mode and SmallButton mode."
            PointFive = "Ribbon has a custom implementation of button control as RibbonButton."
            PointSix = "Can minimize/maximize the ribbon."
            PointSeven = "Keyboard navigation simplified through Key Tip (super accelerator support)."
            PointEight = "Quick Access Toolbar (QAT) provides access to commonly used items."
            PointNine = "RibbonStatusBar provides placing of StatusBar items."
        End Sub

        ''' <summary>
        ''' Indicates whether the format is bold or not <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public Property IsFormatBoldSelected As Boolean
            Get
                Return isFormatBoldSelectedField
            End Get
            Set(value As Boolean)
                isFormatBoldSelectedField = value
                RaisePropertyChanged("IsFormatBoldSelected")
            End Set
        End Property

        ''' <summary>
        ''' Indicates whether the format is italic or not <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public Property IsFormatItalicSelected As Boolean
            Get
                Return isFormatItalicSelectedField
            End Get
            Set(value As Boolean)
                isFormatItalicSelectedField = value
                RaisePropertyChanged("IsFormatItalicSelected")
            End Set
        End Property

        ''' <summary>
        ''' Indicates whether the format is underline or not <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public Property IsFormatUnderLineSelected As Boolean
            Get
                Return isFormatUnderLineSelectedField
            End Get
            Set(value As Boolean)
                isFormatUnderLineSelectedField = value
                RaisePropertyChanged("IsFormatUnderLineSelected")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets whether the Header Row is checked.
        ''' </summary>
        Public Property IsHeaderRowChecked As Boolean
            Get
                Return isHeaderRowCheckedField
            End Get
            Set(value As Boolean)
                isHeaderRowCheckedField = value
                RaisePropertyChanged("IsHeaderRowChecked")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets whether the Total Row is checked.
        ''' </summary>
        Public Property IsTotalRowChecked As Boolean
            Get
                Return isTotalRowCheckedField
            End Get
            Set(value As Boolean)
                isTotalRowCheckedField = value
                RaisePropertyChanged("IsTotalRowChecked")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets whether the Banded Row is checked.
        ''' </summary>
        Public Property IsBandedRowChecked As Boolean
            Get
                Return isBandedRowCheckedField
            End Get
            Set(value As Boolean)
                isBandedRowCheckedField = value
                RaisePropertyChanged("IsBandedRowChecked")
            End Set
        End Property
        ''' <summary>
        ''' Gets or sets whether the First Column is checked.
        ''' </summary>
        Public Property IsFirstColumnChecked As Boolean
            Get
                Return isFirstColumnCheckedField
            End Get
            Set(value As Boolean)
                isFirstColumnCheckedField = value
                RaisePropertyChanged("IsFirstColumnChecked")
            End Set
        End Property
        ''' <summary>
        ''' Gets or sets whether the Last Column is checked.
        ''' </summary>
        Public Property IsLastColumnChecked As Boolean
            Get
                Return isLastColumnCheckedField
            End Get
            Set(value As Boolean)
                isLastColumnCheckedField = value
                RaisePropertyChanged("IsLastColumnChecked")
            End Set
        End Property
        ''' <summary>
        ''' Gets or sets whether the Banded Column is checked.
        ''' </summary>
        Public Property IsBandedColumnChecked As Boolean
            Get
                Return isBandedColumnCheckedField
            End Get
            Set(value As Boolean)
                isBandedColumnCheckedField = value
                RaisePropertyChanged("IsBandedColumnChecked")
            End Set
        End Property

        ''' <summary>
        ''' Maintains the ribbon gallery selected item.
        ''' </summary>
        Public Property RibbonGallerySelectedItem As String

        ''' <summary>
        ''' Maintains the title text
        ''' </summary>
        Public Property TitleText As String

        ''' <summary>
        ''' Maintains the first paragraph
        ''' </summary>
        Public Property FirstParagraphText As String

        ''' <summary>
        ''' Maintains the second title.
        ''' </summary>
        Public Property SecondTitleText As String

        ''' <summary>
        ''' Maintains the point one.
        ''' </summary>
        Public Property PointOne As String

        ''' <summary>
        ''' Maintains the point two.
        ''' </summary>
        Public Property PointTwo As String

        ''' <summary>
        ''' Maintains the point three.
        ''' </summary>
        Public Property PointThree As String

        ''' <summary>
        ''' Maintains the point four.
        ''' </summary>
        Public Property PointFour As String

        ''' <summary>
        ''' Maintains the point five.
        ''' </summary>
        Public Property PointFive As String

        ''' <summary>
        ''' Maintains the point six.
        ''' </summary>
        Public Property PointSix As String

        ''' <summary>
        ''' Maintains the point seven.
        ''' </summary>
        Public Property PointSeven As String

        ''' <summary>
        ''' Maintains the point eight.
        ''' </summary>
        Public Property PointEight As String

        ''' <summary>
        ''' Maintains the point nine.
        ''' </summary>
        Public Property PointNine As String

        ''' <summary>
        ''' Holds the required resouces for IconTemplate.
        ''' </summary>
        Private Property CommonResourceDictionary As ResourceDictionary

        ''' <summary>
        ''' Gets the ribbon property
        ''' </summary>
        ''' <paramname="obj">Specifies the dependency object.</param>
        ''' <returns></returns>
        Public Shared Function GetRibbon(obj As DependencyObject) As Syncfusion.Windows.Tools.Controls.Ribbon
            Return CType(obj.GetValue(RibbonProperty), Syncfusion.Windows.Tools.Controls.Ribbon)
        End Function

        ''' <summary>
        ''' Sets the ribbon property
        ''' </summary>
        ''' <paramname="obj">>Specifies the dependency object.</param>
        ''' <paramname="value">Specifies the ribbon value.</param>
        Public Shared Sub SetRibbon(obj As DependencyObject, value As Syncfusion.Windows.Tools.Controls.Ribbon)
            obj.SetValue(RibbonProperty, value)
        End Sub

        ''' <summary>
        ''' Dependency property.
        ''' </summary>
        Public Shared ReadOnly RibbonProperty As DependencyProperty = DependencyProperty.RegisterAttached("Ribbon", GetType(Syncfusion.Windows.Tools.Controls.Ribbon), GetType(RibbonViewModel), New FrameworkPropertyMetadata(AddressOf OnRibbonChanged))

        ''' <summary>
        ''' Method used to access the ribbon control.
        ''' </summary>
        ''' <paramname="obj">Specifies the dependency object.</param>
        ''' <paramname="args">Specifies the dependency property changes event args.</param>
        Public Shared Sub OnRibbonChanged(obj As DependencyObject, args As DependencyPropertyChangedEventArgs)
            ribbon = TryCast(obj, Syncfusion.Windows.Tools.Controls.Ribbon)
        End Sub

        ''' <summary>
        ''' Gets the rich textBox property
        ''' </summary>
        ''' <paramname="obj">Specifies the dependency object.</param>
        ''' <returns></returns>
        Public Shared Function GetRichTextBox(obj As DependencyObject) As String
            Return CStr(obj.GetValue(RichTextBoxProperty))
        End Function

        ''' <summary>
        ''' Sets the rich textBox property
        ''' </summary>
        ''' <paramname="obj">>Specifies the dependency object.</param>
        ''' <paramname="value">Specifies the ribbon value.</param>
        Public Shared Sub SetRichTextBox(obj As DependencyObject, value As String)
            obj.SetValue(RichTextBoxProperty, value)
        End Sub

        ''' <summary>
        ''' Dependency property.
        ''' </summary>
        Public Shared ReadOnly RichTextBoxProperty As DependencyProperty = DependencyProperty.RegisterAttached("RichTextBox", GetType(String), GetType(RibbonViewModel), New FrameworkPropertyMetadata(AddressOf OnRichTextBoxChanged))

        ''' <summary>
        ''' Method used to access the rich textBox control.
        ''' </summary>
        ''' <paramname="obj">Specifies the dependency object.</param>
        ''' <paramname="args">Specifies the dependency property changes event args.</param>
        Public Shared Sub OnRichTextBoxChanged(obj As DependencyObject, args As DependencyPropertyChangedEventArgs)
            richTextBox = TryCast(obj, RichTextBox)
        End Sub

        ''' <summary>
        ''' Gets or sets the command for 1st gallery item  <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemOneCommand As ICommand
            Get
                Return galleryItemOneCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 2nd gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemTwoCommand As ICommand
            Get
                Return galleryItemTwoCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 3rd gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemThreeCommand As ICommand
            Get
                Return galleryItemThreeCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 4th gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemFourCommand As ICommand
            Get
                Return galleryItemFourCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 5th gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemFiveCommand As ICommand
            Get
                Return galleryItemFiveCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 6th gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemSixCommand As ICommand
            Get
                Return galleryItemSixCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 7th gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemSevenCommand As ICommand
            Get
                Return galleryItemSevenCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 8th gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemEightCommand As ICommand
            Get
                Return galleryItemEightCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 9th gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemNineCommand As ICommand
            Get
                Return galleryItemNineCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 10th gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemTenCommand As ICommand
            Get
                Return galleryItemTenCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 11th gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemElevenCommand As ICommand
            Get
                Return galleryItemElevenCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 12th gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemTwelveCommand As ICommand
            Get
                Return galleryItemTwelveCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for 13th gallery item <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GalleryItemThirteenCommand As ICommand
            Get
                Return galleryItemThirteenCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for richTextBox PreviewMouseLeftButtonUp <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property RichTextBoxPreviewMouseLeftButtonUpCommand As ICommand
            Get
                Return richTextBoxPreviewMouseLeftButtonUpCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for richText box selection changed <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property RichTextBoxSelectionChangedCommand As ICommand
            Get
                Return richTextBoxSelectionChangedCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for remove button <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property RemoveStyleCommand As ICommand
            Get
                Return removeStyleCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for minimize ribbon button <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property MinimizeRibbonCommand As ICommand
            Get
                Return minimizeRibbonCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for closing the application menu <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property ApplicationMenuCommand As ICommand
            Get
                Return applicationMenuCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for button <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property ButtonCommand As ICommand
            Get
                Return buttonCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for dropdown <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property DropDownCommand As ICommand
            Get
                Return dropdownCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for saveas backstage command button <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property SaveAsCommand As ICommand
            Get
                Return saveAsCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for open backstage command button <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property OpenCommand As ICommand
            Get
                Return openCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for close backstage command button <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property CloseCommand As ICommand
            Get
                Return closeCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for backStage exit button <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property BackStageExitCommand As ICommand
            Get
                Return backStageExitCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for return to editor button in info backstage <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property ReturnToEditorCommand As ICommand
            Get
                Return returnToEditorCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for online help button in help backstage <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property OnlineHelpCommand As ICommand
            Get
                Return onlineHelpCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the command for online getting started button in help backstage <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public ReadOnly Property GettingStartedHelpCommand As ICommand
            Get
                Return gettingStartedHelpCommandField
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the font.family for the ItemSource of RibbonComboBox Control <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public Property FontFamilyList As ObservableCollection(Of RibbonModel)
            Get
                Return fontFamilyListField
            End Get
            Set(value As ObservableCollection(Of RibbonModel))
                fontFamilyListField = value
                RaisePropertyChanged("FontFamilyList")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the font.size for the ItemSource of the RibbonComboBox Control <seecref="GettingStartedViewModel"/> class.
        ''' </summary>
        Public Property FontSizeList As ObservableCollection(Of RibbonModel)
            Get
                Return fontSizeListField
            End Get
            Set(value As ObservableCollection(Of RibbonModel))
                fontSizeListField = value
                RaisePropertyChanged("FontSizeList")
            End Set
        End Property

        ''' <summary>
        ''' Coerces the boolean value.
        ''' </summary>
        ''' <paramname="value">Specifies the value.</param>
        ''' <paramname="trueValue">Specifies the true value.</param>
        ''' <returns></returns>
        Private Function CoerceBooleanValue(value As Object, trueValue As Object) As Boolean?
            If value Is Nothing Then
                Return Nothing
            ElseIf value.Equals(trueValue) Then
                Return True
            ElseIf value Is DependencyProperty.UnsetValue Then
                Return Nothing
            Else
                Return False
            End If
        End Function

        ''' <summary>
        ''' Gets or sets the selection bold.
        ''' </summary>
        ''' <value>The selection bold.</value>
        Public Property SelectionBold As Boolean?
            Get
                Return CoerceBooleanValue(richTextBox.Selection.GetPropertyValue(TextElement.FontWeightProperty), FontWeights.Bold)
            End Get
            Set(value As Boolean?)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, If(value <> False, FontWeights.Bold, FontWeights.Normal))
                RaisePropertyChanged("SelectionBold")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the selection italic.
        ''' </summary>
        ''' <value>The selection italic.</value>
        Public Property SelectionItalic As Boolean?
            Get
                Return CoerceBooleanValue(richTextBox.Selection.GetPropertyValue(TextElement.FontStyleProperty), FontStyles.Italic)
            End Get
            Set(value As Boolean?)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, If(value <> False, FontStyles.Italic, FontStyles.Normal))
                RaisePropertyChanged("SelectionItalic")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the selection subscript.
        ''' </summary>
        ''' <value>The selection subscript.</value>
        Public Property SelectionSubscript As Boolean?
            Get
                Return CoerceBooleanValue(richTextBox.Selection.GetPropertyValue(Typography.VariantsProperty), FontVariants.Subscript)
            End Get
            Set(value As Boolean?)
                richTextBox.Selection.ApplyPropertyValue(Typography.VariantsProperty, If(value <> False, FontVariants.Subscript, FontVariants.Normal))
                RaisePropertyChanged("SelectionSubscript")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the selection superscript.
        ''' </summary>
        ''' <value>The selection superscript.</value>
        Public Property SelectionSuperscript As Boolean?
            Get
                Return CoerceBooleanValue(richTextBox.Selection.GetPropertyValue(Typography.VariantsProperty), FontVariants.Superscript)
            End Get
            Set(value As Boolean?)
                richTextBox.Selection.ApplyPropertyValue(Typography.VariantsProperty, If(value <> False, FontVariants.Superscript, FontVariants.Normal))
                RaisePropertyChanged("SelectionSuperscript")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the selection underline.
        ''' </summary>
        ''' <value>The selection underline.</value>
        Public Property SelectionUnderline As Boolean?
            Get
                Return CoerceBooleanValue(richTextBox.Selection.GetPropertyValue(TextBlock.TextDecorationsProperty), TextDecorations.Underline)
            End Get
            Set(value As Boolean?)
                richTextBox.Selection.ApplyPropertyValue(TextBlock.TextDecorationsProperty, If(value <> False, TextDecorations.Underline, Nothing))
                RaisePropertyChanged("SelectionUnderline")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the selection strikethrough.
        ''' </summary>
        ''' <value>The selection strikethrough.</value>
        Public Property SelectionStrikethrough As Boolean?
            Get
                Return CoerceBooleanValue(richTextBox.Selection.GetPropertyValue(TextBlock.TextDecorationsProperty), TextDecorations.Strikethrough)
            End Get
            Set(value As Boolean?)
                richTextBox.Selection.ApplyPropertyValue(TextBlock.TextDecorationsProperty, If(value <> False, TextDecorations.Strikethrough, Nothing))
                RaisePropertyChanged("SelectionStrikethrough")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the selection font family.
        ''' </summary>
        ''' <value>The selection font family.</value>
        Public Property SelectionFontFamily As FontFamily
            Get
                Dim value = richTextBox.Selection.GetPropertyValue(TextElement.FontFamilyProperty)
                If value Is DependencyProperty.UnsetValue Then
                    Return Nothing
                Else
                    Return CType(value, FontFamily)
                End If
            End Get
            Set(value As FontFamily)
                If value IsNot Nothing Then
                    richTextBox.Selection.ApplyPropertyValue(TextElement.FontFamilyProperty, value)
                    RaisePropertyChanged("SelectionFontFamily")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the size of the selection font.
        ''' </summary>
        ''' <value>The size of the selection font.</value>
        Public Property SelectionFontSize As Double
            Get
                Dim value = richTextBox.Selection.GetPropertyValue(TextElement.FontSizeProperty)
                If value Is DependencyProperty.UnsetValue Then
                    Return Double.NaN
                Else
                    Return value
                End If
            End Get
            Set(value As Double)
                If Not value.Equals(Double.NaN) Then
                    richTextBox.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, value)
                    RaisePropertyChanged("SelectionFontSize")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the selection foreground.
        ''' </summary>
        ''' <value>The selection foreground.</value>
        Public Property SelectionForeground As Brush
            Get
                Dim value = richTextBox.Selection.GetPropertyValue(TextElement.ForegroundProperty)
                If value Is DependencyProperty.UnsetValue Then
                    Return Nothing
                Else
                    Return CType(value, Brush)
                End If
            End Get
            Set(value As Brush)
                richTextBox.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, If(value IsNot Nothing, value, Brushes.Black))
                RaisePropertyChanged("SelectionForeground")
            End Set
        End Property

        ''' <summary>
        ''' Method used to execute the clear formatting command.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteClearFormattingCommand(parameter As Object)
            SelectionForeground = New SolidColorBrush(Color.FromRgb(0, 0, 0))
            SelectionFontSize = 14
        End Sub


        Protected Sub [Set](Of T)(ByRef storage As T, value As T, <CallerMemberName> Optional propertyName As String = Nothing)
            If Equals(storage, value) Then
                Return
            End If

            storage = value
            OnPropertyChanged(propertyName)
        End Sub

        Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
            RaisePropertyChanged(propertyName)
        End Sub

        ''' <summary>
        ''' Removes the item from the Style Gallery
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteRemoveStyleCommand(parameter As Object)
            Dim gallery As RibbonGallery = TryCast(ribbon.FindName("gallery"), RibbonGallery)
            Dim galleryItemOne As RibbonGalleryItem = TryCast(ribbon.FindName("firstItem"), RibbonGalleryItem)
            Dim galleryItemTwo As RibbonGalleryItem = TryCast(ribbon.FindName("secondItem"), RibbonGalleryItem)
            Dim galleryItemThree As RibbonGalleryItem = TryCast(ribbon.FindName("thirdItem"), RibbonGalleryItem)
            Dim galleryItemFour As RibbonGalleryItem = TryCast(ribbon.FindName("fourthItem"), RibbonGalleryItem)
            Dim galleryItemFive As RibbonGalleryItem = TryCast(ribbon.FindName("fifthItem"), RibbonGalleryItem)
            Dim galleryItemSix As RibbonGalleryItem = TryCast(ribbon.FindName("sixthItem"), RibbonGalleryItem)
            Dim galleryItemSeven As RibbonGalleryItem = TryCast(ribbon.FindName("seventhItem"), RibbonGalleryItem)
            Dim galleryItemEight As RibbonGalleryItem = TryCast(ribbon.FindName("eighthItem"), RibbonGalleryItem)
            Dim galleryItemNine As RibbonGalleryItem = TryCast(ribbon.FindName("ninthItem"), RibbonGalleryItem)
            Dim galleryItemTen As RibbonGalleryItem = TryCast(ribbon.FindName("tenthItem"), RibbonGalleryItem)
            Dim galleryItemEleven As RibbonGalleryItem = TryCast(ribbon.FindName("eleventhItem"), RibbonGalleryItem)
            Dim galleryItemItalic As RibbonGalleryItem = TryCast(ribbon.FindName("italicItem"), RibbonGalleryItem)
            Dim galleryItemString As RibbonGalleryItem = TryCast(ribbon.FindName("superString"), RibbonGalleryItem)

            If galleryItemOne.IsChecked Then
                gallery.Items.Remove(galleryItemOne)
            End If
            If galleryItemTwo.IsChecked Then
                gallery.Items.Remove(galleryItemTwo)
            End If
            If galleryItemThree.IsChecked Then
                gallery.Items.Remove(galleryItemThree)
            End If
            If galleryItemFour.IsChecked Then
                gallery.Items.Remove(galleryItemFour)
            End If
            If galleryItemFive.IsChecked Then
                gallery.Items.Remove(galleryItemFive)
            End If
            If galleryItemSix.IsChecked Then
                gallery.Items.Remove(galleryItemSix)
            End If
            If galleryItemSeven.IsChecked Then
                gallery.Items.Remove(galleryItemSeven)
            End If
            If galleryItemEight.IsChecked Then
                gallery.Items.Remove(galleryItemEight)
            End If
            If galleryItemNine.IsChecked Then
                gallery.Items.Remove(galleryItemNine)
            End If
            If galleryItemTen.IsChecked Then
                gallery.Items.Remove(galleryItemTen)
            End If
            If galleryItemEleven.IsChecked Then
                gallery.Items.Remove(galleryItemEleven)
            End If
            If galleryItemItalic.IsChecked Then
                gallery.Items.Remove(galleryItemItalic)
            End If
            If galleryItemString.IsChecked Then
                gallery.Items.Remove(galleryItemString)
            End If
        End Sub

        ''' <summary>
        ''' Minimizes the ribbon when MinimizeRibbon is selected
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteMinimizeRibbonCommand(parameter As Object)
            ribbon.RibbonState = RibbonState.Hide
        End Sub

        ''' <summary>
        ''' Creates the mini tool bar.
        ''' </summary>
        Private Sub CreateMiniToolBar()
            toolBar = New MiniToolbar()
            Dim fontFamilyComboBox As RibbonComboBox = New RibbonComboBox()
            Dim fontSizeComboBox As RibbonComboBox = New RibbonComboBox()
            Dim sizes = New Integer(14) {8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 28, 36, 48, 72}
            For Each fontFamily In Fonts.SystemFontFamilies
                FontFamilyList.Add(New RibbonModel() With {
                    .FontFamily = fontFamily.ToString()
                })
                Dim fontFamilyComboBoxItem As RibbonComboBoxItem = New RibbonComboBoxItem()
                fontFamilyComboBoxItem.Content = fontFamily
                fontFamilyComboBox.Items.Add(fontFamilyComboBoxItem)
                AddHandler fontFamilyComboBoxItem.PreviewMouseMove, AddressOf RibbonComboBoxItem1_PreviewMouseMove
            Next
            For i = 0 To sizes.Length - 1
                FontSizeList.Add(New RibbonModel() With {
                    .FontSize = sizes(i)
                })
                Dim fontSizeComboBoxItem As RibbonComboBoxItem = New RibbonComboBoxItem()
                fontSizeComboBoxItem.Content = sizes(i)
                fontSizeComboBox.Items.Add(fontSizeComboBoxItem)
                AddHandler fontSizeComboBoxItem.PreviewMouseMove, AddressOf RibbonComboBoxItem2_PreviewMouseMove
            Next
            fontFamilyComboBox.Width = 100
            fontFamilyComboBox.IsEditable = True
            fontSizeComboBox.Width = 40
            fontSizeComboBox.IsEditable = True

            Dim increaseFontButton As RibbonButton = New RibbonButton()
            Dim decreaseFontButton As RibbonButton = New RibbonButton()
            Dim toggleBoldButton As RibbonButton = New RibbonButton()
            Dim toggleItalicButton As RibbonButton = New RibbonButton()
            Dim toggleUnderlineButton As RibbonButton = New RibbonButton()
            Dim strikeButton As RibbonButton = New RibbonButton()
            Dim toggleSubScriptButton As RibbonButton = New RibbonButton()
            Dim toggleSuperScriptButton As RibbonButton = New RibbonButton()
            Dim fontColorButton As RibbonButton = New RibbonButton()
            Dim textHighlightButton As RibbonButton = New RibbonButton()

            increaseFontButton.CommandBindings.Add(New CommandBinding(EditingCommands.IncreaseFontSize))
            decreaseFontButton.CommandBindings.Add(New CommandBinding(EditingCommands.DecreaseFontSize))
            toggleBoldButton.CommandBindings.Add(New CommandBinding(EditingCommands.ToggleBold))
            toggleItalicButton.CommandBindings.Add(New CommandBinding(EditingCommands.ToggleItalic))
            toggleUnderlineButton.CommandBindings.Add(New CommandBinding(EditingCommands.ToggleUnderline))
            toggleSubScriptButton.CommandBindings.Add(New CommandBinding(EditingCommands.ToggleSubscript))
            toggleSuperScriptButton.CommandBindings.Add(New CommandBinding(EditingCommands.ToggleSuperscript))

            AddHandler increaseFontButton.Click, New RoutedEventHandler(AddressOf OnIncreaseFontThrough)
            AddHandler decreaseFontButton.Click, New RoutedEventHandler(AddressOf OnDecreaseFontThrough)
            AddHandler strikeButton.Click, New RoutedEventHandler(AddressOf OnStrikeThrough)
            AddHandler toggleBoldButton.Click, New RoutedEventHandler(AddressOf OnBoldThrough)
            AddHandler toggleItalicButton.Click, New RoutedEventHandler(AddressOf OnItalicThrough)
            AddHandler toggleUnderlineButton.Click, New RoutedEventHandler(AddressOf OnUnderlineThrough)
            AddHandler toggleSubScriptButton.Click, New RoutedEventHandler(AddressOf OnSubScriptThrough)
            AddHandler toggleSuperScriptButton.Click, New RoutedEventHandler(AddressOf OnSuperScriptThrough)

            increaseFontButton.IconTemplate = TryCast(CommonResourceDictionary("IncreaseFontSize"), DataTemplate)
            decreaseFontButton.IconTemplate = TryCast(CommonResourceDictionary("DecreaseFontSize"), DataTemplate)
            toggleBoldButton.IconTemplate = TryCast(CommonResourceDictionary("Bold"), DataTemplate)
            toggleItalicButton.IconTemplate = TryCast(CommonResourceDictionary("Italics"), DataTemplate)
            toggleUnderlineButton.IconTemplate = TryCast(CommonResourceDictionary("Underline"), DataTemplate)
            toggleSubScriptButton.IconTemplate = TryCast(CommonResourceDictionary("Bullets"), DataTemplate)
            toggleSuperScriptButton.IconTemplate = TryCast(CommonResourceDictionary("Numbering"), DataTemplate)
            strikeButton.IconTemplate = TryCast(CommonResourceDictionary("ClearFormatting"), DataTemplate)
            fontColorButton.IconTemplate = TryCast(CommonResourceDictionary("FontColor"), DataTemplate)
            textHighlightButton.IconTemplate = TryCast(CommonResourceDictionary("TextHighlight"), DataTemplate)

            increaseFontButton.SizeForm = SizeForm.ExtraSmall
            decreaseFontButton.SizeForm = SizeForm.ExtraSmall
            toggleBoldButton.SizeForm = SizeForm.ExtraSmall
            toggleItalicButton.SizeForm = SizeForm.ExtraSmall
            toggleUnderlineButton.SizeForm = SizeForm.ExtraSmall
            strikeButton.SizeForm = SizeForm.ExtraSmall
            toggleSubScriptButton.SizeForm = SizeForm.ExtraSmall
            toggleSuperScriptButton.SizeForm = SizeForm.ExtraSmall
            fontColorButton.SizeForm = SizeForm.ExtraSmall
            textHighlightButton.SizeForm = SizeForm.ExtraSmall

            toolBar.Items.Add(fontFamilyComboBox)
            toolBar.Items.Add(fontSizeComboBox)
            toolBar.Items.Add(increaseFontButton)
            toolBar.Items.Add(decreaseFontButton)
            toolBar.Items.Add(toggleBoldButton)
            toolBar.Items.Add(toggleItalicButton)
            toolBar.Items.Add(toggleUnderlineButton)
            toolBar.Items.Add(strikeButton)
            toolBar.Items.Add(toggleSubScriptButton)
            toolBar.Items.Add(toggleSuperScriptButton)
            toolBar.Items.Add(fontColorButton)
            toolBar.Items.Add(textHighlightButton)
        End Sub

        ''' <summary>
        ''' Method used to change the font family.
        ''' </summary>
        ''' <paramname="sender">Specifies the object type.</param>
        ''' <paramname="e">Specifies the mouse event argument.</param>
        Private Sub RibbonComboBoxItem1_PreviewMouseMove(sender As Object, e As MouseEventArgs)
            Dim item As RibbonComboBoxItem = TryCast(sender, RibbonComboBoxItem)
            If item IsNot Nothing Then
                SelectionFontFamily = TryCast(item.Content, FontFamily)
            End If
        End Sub

        ''' <summary>
        ''' Method used to change the font size
        ''' </summary>
        ''' <paramname="sender">Specifies the object type.</param>
        ''' <paramname="e">Specifies the mouse event argument.</param>
        Private Sub RibbonComboBoxItem2_PreviewMouseMove(sender As Object, e As MouseEventArgs)
            Dim item As RibbonComboBoxItem = TryCast(sender, RibbonComboBoxItem)
            If item IsNot Nothing Then
                SelectionFontSize = CInt(item.Content)
            End If
        End Sub

        ''' <summary>
        ''' Called when [strike through].
        ''' </summary>
        ''' <paramname="sender">The sender.</param>
        ''' <paramname="e">The <seecref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub OnStrikeThrough(sender As Object, e As EventArgs)
            SelectionStrikethrough = Not SelectionStrikethrough
        End Sub

        ''' <summary>
        ''' Called when [bold through].
        ''' </summary>
        ''' <paramname="sender">The sender.</param>
        ''' <paramname="e">The <seecref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub OnBoldThrough(sender As Object, e As EventArgs)
            SelectionBold = Not SelectionBold
            ResetCurrentEditorStyles()
        End Sub

        ''' <summary>
        ''' Called when [italic through].
        ''' </summary>
        ''' <paramname="sender">The sender.</param>
        ''' <paramname="e">The <seecref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub OnItalicThrough(sender As Object, e As EventArgs)
            SelectionItalic = Not SelectionItalic
            ResetCurrentEditorStyles()
        End Sub

        ''' <summary>
        ''' Called when [underline through].
        ''' </summary>
        ''' <paramname="sender">The sender.</param>
        ''' <paramname="e">The <seecref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub OnUnderlineThrough(sender As Object, e As EventArgs)
            SelectionUnderline = Not SelectionUnderline
            ResetCurrentEditorStyles()
        End Sub

        ''' <summary>
        ''' Called when [increase font through].
        ''' </summary>
        ''' <paramname="sender">The sender.</param>
        ''' <paramname="e">The <seecref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub OnIncreaseFontThrough(sender As Object, e As EventArgs)
            SelectionFontSize = SelectionFontSize + 1
        End Sub

        ''' <summary>
        ''' Called when [decrease font through].
        ''' </summary>
        ''' <paramname="sender">The sender.</param>
        ''' <paramname="e">The <seecref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub OnDecreaseFontThrough(sender As Object, e As EventArgs)
            If SelectionFontSize > 1 Then SelectionFontSize = SelectionFontSize - 1
        End Sub

        ''' <summary>
        ''' Called when [sub script through].
        ''' </summary>
        ''' <paramname="sender">The sender.</param>
        ''' <paramname="e">The <seecref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub OnSubScriptThrough(sender As Object, e As EventArgs)
            SelectionSubscript = Not SelectionSubscript
        End Sub

        ''' <summary>
        ''' Called when [super script through].
        ''' </summary>
        ''' <paramname="sender">The sender.</param>
        ''' <paramname="e">The <seecref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub OnSuperScriptThrough(sender As Object, e As EventArgs)
            SelectionSuperscript = Not SelectionSuperscript
        End Sub

        ''' <summary>
        ''' Resets the current editor styles.
        ''' </summary>
        Private Sub ResetCurrentEditorStyles()
            If SelectionBold.HasValue Then
                IsFormatBoldSelected = SelectionBold.Value
            End If
            If SelectionItalic.HasValue Then
                IsFormatItalicSelected = SelectionItalic.Value
            End If
            If SelectionUnderline.HasValue Then
                IsFormatUnderLineSelected = SelectionUnderline.Value
            End If
            Dim toolbarfont = CType(toolBar.Items(0), RibbonComboBox)
            Dim toolbarfontsize = CType(toolBar.Items(1), RibbonComboBox)
            Dim boldBtn = CType(toolBar.Items(4), RibbonButton)
            Dim italicBtn = CType(toolBar.Items(5), RibbonButton)
            Dim underlineBtn = CType(toolBar.Items(6), RibbonButton)
            Dim strikeBtn = CType(toolBar.Items(7), RibbonButton)
            If SelectionFontFamily IsNot Nothing Then toolbarfont.Text = SelectionFontFamily.Source
            If Not Double.IsNaN(SelectionFontSize) Then toolbarfontsize.Text = SelectionFontSize.ToString()
            If SelectionStrikethrough.HasValue Then strikeBtn.IsSelected = SelectionStrikethrough.Value
            If SelectionBold.HasValue Then boldBtn.IsSelected = SelectionBold.Value
            If SelectionItalic.HasValue Then italicBtn.IsSelected = SelectionItalic.Value
            If SelectionUnderline.HasValue Then underlineBtn.IsSelected = SelectionUnderline.Value
        End Sub

        ''' <summary>
        ''' Handles the MouseUp event of the editor control.
        ''' </summary>
        ''' <paramname="sender">The source of the event.</param>
        ''' <paramname="e">The <seecref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        Private Sub ExecuteRichTextBoxPreviewMouseLeftButtonUpCommand(sender As Object)
            If Not richTextBox.Selection.IsEmpty Then
                Dim toolbarfont = CType(toolBar.Items(0), RibbonComboBox)
                Dim toolbarfontsize = CType(toolBar.Items(1), RibbonComboBox)
                Dim boldBtn = CType(toolBar.Items(4), RibbonButton)
                Dim italicBtn = CType(toolBar.Items(5), RibbonButton)
                Dim underlineBtn = CType(toolBar.Items(6), RibbonButton)
                Dim strikeBtn = CType(toolBar.Items(7), RibbonButton)
                If SelectionFontFamily IsNot Nothing Then toolbarfont.Text = SelectionFontFamily.Source
                If Not Double.IsNaN(SelectionFontSize) Then toolbarfontsize.Text = SelectionFontSize.ToString()
                If SelectionStrikethrough.HasValue Then strikeBtn.IsSelected = SelectionStrikethrough.Value
                If SelectionBold.HasValue Then boldBtn.IsSelected = SelectionBold.Value
                If SelectionItalic.HasValue Then italicBtn.IsSelected = SelectionItalic.Value
                If SelectionUnderline.HasValue Then underlineBtn.IsSelected = SelectionUnderline.Value
                toolBar.Show()
            Else
                toolBar.Hide()
            End If
        End Sub

        ''' <summary>
        ''' Handles the SelectionChanged event of the editor control.
        ''' </summary>
        ''' <paramname="sender">The source of the event.</param>
        Private Sub ExecuteRichTextBoxSelectionChangedCommand(sender As Object)
            Dim selection = richTextBox.Selection
            Dim EmptySelection = selection.IsEmpty
            If EmptySelection Then toolBar.Hide()
            ResetCurrentEditorStyles()
        End Sub

        ''' <summary>
        ''' Method used to execute 1st gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemOneCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionForeground = New SolidColorBrush(Color.FromRgb(0, 0, 0))
                SelectionFontSize = 14
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 2nd gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemTwoCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionForeground = New SolidColorBrush(Color.FromRgb(0, 0, 0))
                SelectionFontSize = 12
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 3rd gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemThreeCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionFontSize = 18
                SelectionForeground = New SolidColorBrush(Color.FromRgb(0, 0, 139))
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 4th gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemFourCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionFontSize = 16
                SelectionForeground = New SolidColorBrush(Color.FromRgb(0, 0, 139))
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 5th gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemFiveCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionFontSize = 14
                SelectionForeground = New SolidColorBrush(Color.FromRgb(0, 0, 139))
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 6th gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemSixCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionFontSize = 12
                SelectionForeground = New SolidColorBrush(Color.FromRgb(0, 0, 139))
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 7th gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemSevenCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionFontSize = 24
                SelectionForeground = New SolidColorBrush(Color.FromRgb(0, 0, 0))
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 8th gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemEightCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionItalic = True
                SelectionFontSize = 14
                SelectionForeground = New SolidColorBrush(Color.FromRgb(0, 0, 0))
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 9th gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemNineCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionForeground = New SolidColorBrush(Color.FromRgb(255, 0, 0))
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 10th gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemTenCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionForeground = New SolidColorBrush(Color.FromRgb(255, 0, 0))
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 11th gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemElevenCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionForeground = New SolidColorBrush(Color.FromRgb(255, 0, 0))
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 12th gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemTwelveCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionFontSize = 16
                SelectionItalic = True
            End If
        End Sub

        ''' <summary>
        ''' Method used to execute 13th gallery item.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGalleryItemThirteenCommand(parameter As Object)
            If Not Equals(richTextBox.Selection.Text, String.Empty) Then
                SelectionFontSize = 20
                SelectionBold = True
            End If
        End Sub

        ''' <summary>
        ''' Method to execute returnToEditorCommand.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object parameter.</param>
        Public Sub ExecuteReturnToEditorCommand(parameter As Object)
            Call ribbon.HideBackStage()
        End Sub

        ''' <summary>
        ''' Method which is used to execute the saveas command.
        ''' </summary>
        ''' <paramname="parameter">Specifies the parameter of saveas command.</param>
        Private Sub ExecuteSaveAsCommand(parameter As Object)
            Dim dialog = New SaveFileDialog With {
                .Filter = "Rich text files (*.rtf)|*.rtf",
                .AddExtension = True,
                .DefaultExt = ".rtf"
            }
            If dialog.ShowDialog() <> True Then Return
            Try
                Using stream = dialog.OpenFile()
                    Call New TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Save(stream, DataFormats.Rtf)
                End Using
            Catch __unusedIOException1__ As IOException
                MessageBox.Show("The document could not be saved. Please try again.")
            End Try
        End Sub

        ''' <summary>
        ''' Method which is used to execute the open command.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteOpenCommand(parameter As Object)
            Dim dialog = New OpenFileDialog With {
                .Filter = "Rich text files (*.rtf)|*.rtf"
            }
            If dialog.ShowDialog() <> True Then Return
            Try
                Using stream = File.OpenRead(dialog.FileName)
                    Call New TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Load(stream, DataFormats.Rtf)
                End Using
                Call ribbon.HideBackStage()
            Catch __unusedIOException1__ As IOException
                MessageBox.Show("The document could not be opened. Please try again.")
            Catch __unusedArgumentException2__ As ArgumentException
                MessageBox.Show("Select a valid rich text document.")
            End Try
        End Sub

        ''' <summary>
        ''' Method to hide the backstage for close backstage button.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteCloseCommand(parameter As Object)
            Call ribbon.HideBackStage()
        End Sub

        ''' <summary>
        ''' Method to close the application menu.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuuteApplicationMenuCommand(parameter As Object)
            ribbon.ApplicationMenu.IsPopupOpen = False
        End Sub

        ''' <summary>
        ''' Method to execute backStageExitCommand.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object parameter.</param>
        Public Sub ExecuteBackStageExitCommand(parameter As Object)
            MessageBox.Show("Click operation has been performed.")
        End Sub

        ''' <summary>
        ''' Method to execute the command for button in help backstage tab.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteOnlineHelpCommand(parameter As Object)
            Process.Start("https://help.syncfusion.com/wpf/welcome-to-syncfusion-essential-wpf")
        End Sub

        ''' <summary>
        ''' Method to execute the command for button in help backstage tab.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type parameter.</param>
        Private Sub ExecuteGettingStartedCommand(parameter As Object)
            Process.Start("https://help.syncfusion.com/wpf/ribbon/gettingstarted")
        End Sub

        ''' <summary>
        ''' Method used to execute the button command.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type.</param>
        Private Sub ButtonCommandExecute(parameter As Object)
            MessageBox.Show("Click operation has been performed.")
        End Sub

        ''' <summary>
        ''' Method used to execute the dropdown command.
        ''' </summary>
        ''' <paramname="parameter">Specifies the object type.</param>
        Private Sub DropDownCommandExecute(parameter As Object)
            MessageBox.Show("The dropdown item has been selected.")
        End Sub

        ''' <summary>
        ''' Method used to dispose the ribbon and richtext box control.
        ''' </summary>
        Public Shared Sub Dispose()
            If ribbon IsNot Nothing Then
                Call ribbon.Dispose()
                ribbon = Nothing
            End If
            richTextBox = Nothing
        End Sub
    End Class


End Namespace
