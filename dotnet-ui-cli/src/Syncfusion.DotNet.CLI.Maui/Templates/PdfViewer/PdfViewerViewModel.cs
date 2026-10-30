using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed class __VIEW_MODEL_NAME__ : INotifyPropertyChanged
{
    private Stream? _documentStream;
    private bool _isLoading;
    private string? _errorMessage;

    public Stream? DocumentStream
    {
        get => _documentStream;
        private set
        {
            _documentStream = value;
            OnPropertyChanged(nameof(DocumentStream));
        }
    }

    public bool IsLoading
    {
        get => _isLoading;
        private set
        {
            _isLoading = value;
            OnPropertyChanged(nameof(IsLoading));
        }
    }

    public string? ErrorMessage
    {
        get => _errorMessage;
        private set
        {
            _errorMessage = value;
            OnPropertyChanged(nameof(ErrorMessage));
            OnPropertyChanged(nameof(HasError));
        }
    }

    public bool HasError => !string.IsNullOrEmpty(ErrorMessage);

    public event PropertyChangedEventHandler? PropertyChanged;

    public async Task LoadDocumentAsync()
    {
        if (DocumentStream is not null || IsLoading) return;
        IsLoading = true;
        ErrorMessage = null;
        try
        {
            string resourceName = "PdfViewer.Pdf.PDF_Succinctly.pdf";
            DocumentStream = GetType()
                .Assembly
                .GetManifestResourceStream(resourceName);
        }
        catch (Exception exception) when (exception is IOException or InvalidOperationException)
        {
            ErrorMessage = "The sample PDF could not be loaded. Reopen this sample to try again.";
        }
        finally
        {
            IsLoading = false;
        }
    }

    public void UnloadDocument()
    {
        DocumentStream?.Dispose();
        DocumentStream = null;
        ErrorMessage = null;
        OnPropertyChanged(nameof(DocumentStream));
    }

    private void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
