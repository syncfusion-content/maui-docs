# Code Snippets — XAML and C# for MAUI

This page provides ready-to-use snippets to speed up MAUI development. Place snippets into Code Studio's snippets folder or use an extension that imports snippet files.

Recommended assets
- Add images to docs/assets/images: snippet-mainpage.png, snippet-run.png

Snippet: MainPage XAML
- Description: Simple page with header, button and counter.
- Save as MainPageSnippet.xaml or add to Code Studio snippets.

```xml
<!-- MainPage.xaml snippet -->
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MyMauiApp.MainPage"
             Title="Home">
  <StackLayout Padding="20" Spacing="12">
    <Label Text="Welcome to Code Studio + MAUI" FontSize="24" HorizontalOptions="Center" />
    <Button x:Name="CounterBtn" Text="Click me" Clicked="OnCounterClicked"/>
    <Label x:Name="CounterLabel" Text="Times clicked: 0" />
  </StackLayout>
</ContentPage>
```

Snippet: MainPage code-behind (C#)
```csharp
// MainPage.xaml.cs snippet
using Microsoft.Maui.Controls;

namespace MyMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Times clicked: {count}";
        }
    }
}
```

How to import snippets into Code Studio
1. File > Preferences > User Snippets > New Global Snippets file.
2. Paste snippet JSON or add XAML/C# files into a workspace folder and reference them via the extension.
3. Use editor Emmet-like completion or custom prefixes for fast insertion.

Useful links
- .NET MAUI samples: https://github.com/dotnet/maui-samples
- MAUI docs and API references: https://learn.microsoft.com/dotnet/maui

Add these snippets to your project template to speed onboarding for new developers using Code Studio.