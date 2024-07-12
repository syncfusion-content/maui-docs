---
layout: post
title: Open a Password-Protected PDF in .NET MAUI PDF Viewer | Syncfusion
description: Learn here about opening a password-protected document in Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords : .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view
---

# Open a Password-Protected PDF in .NET MAUI PDF Viewer (SfPdfViewer)

To open a password-protected or encrypted PDF document, you can use the [LoadDocument](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_LoadDocument_System_IO_Stream_System_String_) method by providing the password along with the document source. The following code example explains the same.

{% tabs %}
{% highlight c# %}
string password = "PASSWORD";
pdfViewer.LoadDocument(pdfDocumentStream, password);
{% endhighlight %}
{% endtabs %}

In the above code snippet, `pdfDocumentStream` is the `Stream` instance read from the encrypted PDF, and `password` is the key with which the PDF is encrypted.

## Detecting a password-protected document

You can identify whether a PDF document to be opened is a password protected or not by using the [PasswordRequested](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_PasswordRequested) event. This event triggers when the document to be loaded in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) requires a password. In this event handler method, you can set the [password](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.PasswordRequestedEventArgs.html#Syncfusion_Maui_PdfViewer_PasswordRequestedEventArgs_Password) property from the [PasswordRequestedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.PasswordRequestedEventArgs.html) with the correct password to load the document. Refer to the following code example.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfPdfViewer x:Name="PdfViewer" 
	DocumentSource="{Binding PdfDocumentStream}" 
	PasswordRequested ="PdfViewer_PasswordRequested">
{% endhighlight %}

{% highlight c# %}
public MainPage()
{
    InitializeComponent();
    Stream pdfDocumentStream = this.GetType().Assembly.GetManifestResourceStream("PdfViewerExample.Assets.Password_Protected.pdf");
    PdfViewer.DocumentSource = pdfDocumentStream;
}

private void PdfViewer_PasswordRequested(object sender, PasswordRequestedEventArgs e)
{        
    e.Password = "PASSWORD";
    e.Handled = true;
}
{% endhighlight %}
{% endtabs %}

## Handling password request

When attempting to open a password protected document, the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) will display a default password prompt to obtain the user password to load the document. However, if you want to suppress the default password prompt and to implement your own UI to obtain the user password by using the [PasswordRequested](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_PasswordRequested) event. Set the [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs.html#Syncfusion_Maui_PdfViewer_DocumentLoadFailedEventArgs_Handled) property of the [PasswordRequestedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.PasswordRequestedEventArgs.html) to `true` to disable the control’s default password prompt and handle your own logic to supply the password to open the document.

{% tabs %}
{% highlight xaml %}

        <syncfusion:SfPdfViewer 
            x:Name="PdfViewer"
            PasswordRequested="PdfPasswordRequested"/>

{% endhighlight %}
{% highlight c# hl_lines="4" %}

	public MainPage()
	{
		InitializeComponent();
        PdfViewer.PasswordRequested += PdfPasswordRequested;
    }

    private void PdfPasswordRequested(object sender, PasswordRequestedEventArgs e)
    {
        e.Handled = true;
        // Handle your own logic here.
        e.Password = "{Document's password}";
    }

{% endhighlight %}
{% endtabs %}

### Creating a password request view

This is an example of how to create a custom password request dialog to ask for user password and use the same to view the password-protected PDF document in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html). The following code snippets illustrate the creation of a custom password request dialog and viewing the documents, with a few code additions to the **Getting Started** example.

**Step 1:** Create a custom password dialog view named `PasswordDialogBox` and add the functionalities to accept and validate the password, as shown below.

{% tabs %}
{% highlight xaml tabtitle="PasswordDialogBox.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentView xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="OpenPasswordProtectedFile.PasswordDialogBox"
             HeightRequest="280" WidthRequest="360">
    <Grid Padding="16" BackgroundColor="White">
        <Grid.RowDefinitions>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="2*"/>
            <RowDefinition Height="2*"/>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="1*"/>
        </Grid.RowDefinitions>
        <Grid Grid.Row="0" VerticalOptions="Start">
            <Label 
                Text="Enter a Password" 
                Grid.Column="0" 
                HorizontalOptions="Start"
                FontAttributes="Bold" 
                FontSize="20"/>
        </Grid>
        <Label 
            Grid.Row="1" 
            Text="The file is protected. Please enter a password to open the PDF file." 
            VerticalOptions="Center" 
            VerticalTextAlignment="End" 
            LineBreakMode="WordWrap"/>
        <VerticalStackLayout Grid.Row="2" Spacing="2">
            <Border Stroke="{OnPlatform Android=Gray}" Padding="{OnPlatform Android=4}">
                <Entry
                    HorizontalOptions="Fill"
                    Placeholder="Password: syncfusion"
                    x:Name="passwordBlock"
                    IsPassword="True"
                    TextChanged="passwordBlock_TextChanged"/>
            </Border>
            <Label 
                Text=""
                x:Name="helperText"
                VerticalOptions="Center" 
                VerticalTextAlignment="Center" 
                LineBreakMode="WordWrap"
                FontSize="12" 
                Padding="0,2,0,2"/>
        </VerticalStackLayout>
        <HorizontalStackLayout 
                x:Name="showPassword" 
                Spacing="8" 
                Grid.Row="3" 
                VerticalOptions="Start" >
            <CheckBox CheckedChanged="CheckBox_CheckedChanged"/>
            <Label 
                HorizontalTextAlignment="Center"
                Text="Show Password" 
                VerticalTextAlignment="Center"/>
        </HorizontalStackLayout>

        <Grid Grid.Row="4">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="auto"/>
                <ColumnDefinition Width="20"/>
                <ColumnDefinition Width="auto"/>
            </Grid.ColumnDefinitions>
            <Button 
                Grid.Column="1" 
                x:Name="cancelButton" 
                Text="CANCEL" 
                Clicked="CancelButton_Clicked"
                VerticalOptions="End"/>
            <Button 
                Grid.Column="3"
                x:Name="okButton" 
                Text="OK" 
                Clicked="OkButton_Clicked"
                VerticalOptions="End"/>
        </Grid>
    </Grid>
</ContentView>

{% endhighlight %} 

{% highlight c# tabtitle="PasswordDialogBox.xaml.cs" %}

public partial class PasswordDialogBox : ContentView
{
    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Occurs when the password is entered.
    /// </summary>
    public event EventHandler<EventArgs> PasswordEntered;

    /// <summary>
    /// Constructor for the password dialog box.
    /// </summary>
    public PasswordDialogBox()
    {
        InitializeComponent();
    }
    
    /// <summary>
    /// Handles when the cancel button is clicked.
    /// </summary>
    private void CancelButton_Clicked(object sender, EventArgs e)
    {
        //Reset the values and close the dialog.
        Password = null;
        passwordBlock.Text = "";
        this.IsVisible = false;
    }

    private void OkButton_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(passwordBlock.Text) == false)
        {
            //Store the password.
            Password = passwordBlock.Text;

            //Reset the UI and close the dialog.
            passwordBlock.Text = "";
            this.IsVisible = false;

            //Fire the password entered dialog.
            PasswordEntered?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            //Show warning when password is empty.
            helperText.TextColor = Color.FromRgb(255,0,0);
            helperText.Text = "* Password cannot be empty";
        }
    }
    
    /// <summary>
    /// Handles when show password check box is checked or unchecked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            // Show password when checked and hide when unchecked.
            if (checkBox.IsChecked)
                passwordBlock.IsPassword = false;
            else
                passwordBlock.IsPassword = true;
        }
    }
    
    /// <summary>
    /// Handles when password text is changed.
    /// </summary>
    private void passwordBlock_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(e.NewTextValue) == false)
        {
            //Reset the helper text if the current password is not null or empty.
            helperText.Text = "";
        }
    }
}

{% endhighlight %}
{% endtabs %}

**Step 2:** Add the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) and `PasswordDialogBox` elements to the `MainPage` and handle the functionalities to open a custom password request dialog and display the PDF document after providing a correct password, as shown below.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="OpenPasswordProtectedFile.MainPage"
             xmlns:local="clr-namespace:OpenPasswordProtectedFile"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.PdfViewer;assembly=Syncfusion.Maui.PdfViewer">
    <ContentPage.BindingContext>
        <local:PdfViewerViewModel/>
    </ContentPage.BindingContext>
    <Grid>
        <syncfusion:SfPdfViewer 
            x:Name="PdfViewer"
            DocumentSource="{Binding PdfDocumentStream}"
            PasswordRequested="SfPdfViewer_PasswordRequested"
            DocumentLoadFailed="PdfViewer_DocumentLoadFailed"/>
        <local:PasswordDialogBox
            x:Name="PasswordDialog"
            IsVisible="false" 
            PasswordEntered="PasswordDialogBox_PasswordEntered"/>
    </Grid>
</ContentPage>

{% endhighlight %} 

{% highlight c# tabtitle="MainPage.xaml.cs" %}

public partial class MainPage : ContentPage
{
    //It is used to delay the current thread's execution, until the user enters the password.
    ManualResetEvent manualResetEvent = new ManualResetEvent(false);

    /// <summary>
    /// Constructor of the main page.
    /// </summary>
    public MainPage()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Handles password requested event.
    /// </summary>
    private void SfPdfViewer_PasswordRequested(object sender, Syncfusion.Maui.PdfViewer.PasswordRequestedEventArgs e)
    {
        //Show the password dialog.
        PasswordDialog.Dispatcher.Dispatch(() => PasswordDialog.IsVisible = true);
        
        //Block the current thread until user enters the password.
        manualResetEvent.WaitOne();
        manualResetEvent.Reset();

        //Pass the user password to PDF Viewer to validate and load the PDF.
        e.Password = PasswordDialog.Password;
        e.Handled = true;
    }

    /// <summary>
    /// Handles when document is failed to load.
    /// </summary>
    private void PdfViewer_DocumentLoadFailed(object sender, Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs e)
    {
        //Show the incorrect password message to the user, when document failed to load if the password is invalid.
        if (e.Message == "Can't open an encrypted document. The password is invalid.")
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                DisplayAlert("Incorrect Password", "The password you entered is incorrect. Please try again.", "OK");
            });
        }
    }

    /// <summary>
    /// Handles when the password is entered.
    /// </summary>
    private void PasswordDialogBox_PasswordEntered(object sender, EventArgs e)
    {
        //Hide the password dialog.
        PasswordDialog.IsVisible = false;

        //Release the current waiting thread to execute.
        manualResetEvent.Set();
    }
}

{% endhighlight %}
{% endtabs %}

### Handling invalid password

The [DocumentLoadFailed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoadFailed) event triggers when any password-protected document is loaded with a wrong or invalid password. You can handle the functionality based on your needs within this event handler method.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfPdfViewer x:Name="PdfViewer " DocumentSource="{Binding PdfDocumentStream}" PasswordRequested ="PdfViewer_PasswordRequested" DocumentLoadFailed="PdfViewer_DocumentLoadFailed">
{% endhighlight %}

{% highlight c# %}
public MainPage()
{
    InitializeComponent();
    Stream pdfDocumentStream = this.GetType().Assembly.GetManifestResourceStream("PdfViewerExample.Assets.Password_Protected.pdf");
    PdfViewer.DocumentSource = pdfDocumentStream;
}

private void PdfViewer_PasswordRequested(object sender, PasswordRequestedEventArgs e)
{        
    e.Password = "WRONG PASSWORD";
    e.Handled = true;
}

private void PdfViewer_DocumentLoadFailed(object sender, Syncfusion.Maui.PdfViewer.DocumentLoadFailedEventArgs e)
{        
    if (e.Message == "Can't open an encrypted document. The password is invalid.")
    {
        DisplayAlert("Incorrect Password", "The password you entered is incorrect. Please try again.", "OK");
    }
}

{% endhighlight %}
{% endtabs %}

### Handling Correct Password
If the entered password is correct, the document will be loaded into the PDF Viewer. At this moment, the [DocumentLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentLoaded) event will be triggered. You can handle this event to show a message indicating that the password is correct or to close the custom dialog. Refer to this [link](https://help.syncfusion.com/maui/pdf-viewer/documentloadnotifications#document-loaded-event) for more details.

## Github example
The example project to open a password-protected document with a customized password request view can be downloaded [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples).
