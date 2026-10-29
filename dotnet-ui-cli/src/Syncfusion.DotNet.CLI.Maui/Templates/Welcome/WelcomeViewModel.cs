using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace __ROOT_NAMESPACE__.Welcome;

public sealed class WelcomeViewModel : INotifyPropertyChanged
{
    private string _statusMessage = string.Empty;
    private bool _navigating;
    public IReadOnlyList<ControlSample> Samples => ControlRegistry.All;
    public bool HasSamples => Samples.Count > 0;
    public bool IsEmpty => !HasSamples;
    public IReadOnlyList<WelcomeModel> Resources { get; } =
    [
        new("Explore Demos", "See what you can build with interactive .NET MAUI demos.", "Explore Demos →",
            "https://www.syncfusion.com/demos/maui", "sf_welcome_demos.png"),
        new("Explore Docs", "Find guides and examples for your next feature.", "Explore Docs →",
            "https://help.syncfusion.com/maui/introduction/overview", "sf_welcome_docs.png"),
        new("AI Coding Guidance", "Get practical guidance for building with AI coding assistants.", "AI Coding Guidance →",
            "https://help.syncfusion.com/maui/ai-coding-assistant/overview", "sf_welcome_ai.png"),
        new(".NET MAUI Controls", "Discover the full collection of Syncfusion MAUI controls.", ".NET MAUI Controls →",
            "https://www.syncfusion.com/maui-controls", "sf_welcome_controls.png"),
    ];
    public ICommand OpenSampleCommand { get; }
    public ICommand OpenLinkCommand { get; }
    public string StatusMessage
    {
        get => _statusMessage;
        private set { _statusMessage = value; OnPropertyChanged(); }
    }
    public event PropertyChangedEventHandler? PropertyChanged;

    public WelcomeViewModel(Func<ContentPage, Task> navigate)
    {
        OpenSampleCommand = new Command<ControlSample>(async sample =>
        {
            if (_navigating || sample is null) return;
            _navigating = true;
            try
            {
                StatusMessage = string.Empty;
                var page = sample.CreatePage();
                page.Title = sample.Name;
                await navigate(page);
            }
            catch (Exception) { StatusMessage = "This sample could not be opened. Please try again."; }
            finally { _navigating = false; }
        });
        OpenLinkCommand = new Command<string>(async url =>
        {
            try
            {
                if (!await Browser.Default.OpenAsync(new Uri(url), BrowserLaunchMode.SystemPreferred))
                    StatusMessage = "A browser could not be opened on this device.";
            }
            catch (Exception) { StatusMessage = "This link could not be opened. Please try again."; }
        });
    }

    private void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
