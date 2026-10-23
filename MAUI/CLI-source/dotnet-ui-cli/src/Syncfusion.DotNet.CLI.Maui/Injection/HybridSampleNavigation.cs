using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui.Manifest;

namespace Syncfusion.DotNet.CLI.Maui.Injection;

/// <summary>Adds a registry-bound native sample strip without replacing the Blazor application.</summary>
public static class HybridSampleNavigation
{
    public const string ViewModelPath = "Welcome/WelcomeViewModel.cs";

    public static bool CanIntegrate(string root, string rootNamespace, SyncfusionManifest? manifest)
    {
        if (!ProjectControlState.IsManaged(manifest) || manifest!.ProjectType != "blazor-hybrid") return false;
        if (manifest.GeneratedBlocks.Any(block => block.Marker == "hybrid-layout-start")) return true;
        foreach (var file in new[] { "MainPage.xaml", "MainPage.xaml.cs" })
        {
            var path = TemplatePathResolver.ResolveDestination(root, file);
            if (!File.Exists(path)) return false;
            var reference = EmbeddedResourceLoader.ReadText(TemplatePathResolver.ResourcePrefix + "Templates.Welcome.HybridReference." + file)
                .Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal);
            if (Normalize(File.ReadAllText(path)) != Normalize(reference)) return false;
        }
        return true;
    }

    public static void Ensure(string root, string rootNamespace, FileRollback rollback, SyncfusionManifest manifest,
        ProjectDetector.ProjectInfo? project = null)
    {
        if (!CanIntegrate(root, rootNamespace, manifest)) return;
        project ??= MauiProjectResolver.Resolve(root);
        var projectXml = System.Xml.Linq.XDocument.Load(project.CsprojPath);
        if (projectXml.Descendants().Any(element => element.Name.LocalName == "MauiXamlInflator" && element.Value == "SourceGen")
            && !projectXml.Descendants().Any(element => element.Name.LocalName == "MauiXaml" && (string?)element.Attribute("Update") == "MainPage.xaml"))
        {
            // The XAML generator cannot see Routes produced by the Razor source
            // generator in the same compilation. Limit the SDK-supported override
            // to this mixed native/Blazor page and track it as an inserted block.
            var before = File.ReadAllText(project.CsprojPath);
            var block = GeneratedCodeBlocks.Wrap("hybrid-xaml-inflator",
                "  <ItemGroup>\n    <MauiXaml Update=\"MainPage.xaml\" Inflator=\"Runtime\" Condition=\"'$(Configuration)' == 'Debug'\" />\n    <MauiXaml Update=\"MainPage.xaml\" Inflator=\"XamlC\" Condition=\"'$(Configuration)' != 'Debug'\" />\n  </ItemGroup>", xaml: true, indent: "  ");
            var after = before.Replace("</Project>", "\n" + block + "</Project>", StringComparison.Ordinal);
            _ = System.Xml.Linq.XDocument.Parse(after);
            rollback.TrackModified(project.CsprojPath);
            File.WriteAllText(project.CsprojPath, after);
            var relative = Path.GetFileName(project.CsprojPath);
            manifest.GeneratedBlocks.AddRange(GeneratedCodeBlocks.CaptureNew(relative, before, after));
            if (!manifest.ModifiedFiles.Contains(relative)) manifest.ModifiedFiles.Add(relative);
        }
        var modelPath = "Welcome/WelcomeModel.cs";
        var modelAbsolute = TemplatePathResolver.ResolveDestination(root, modelPath);
        if (!File.Exists(modelAbsolute))
        {
            rollback.TrackModified(modelAbsolute);
            rollback.TrackCreatedDirectories(Path.GetDirectoryName(modelAbsolute)!, root);
            Directory.CreateDirectory(Path.GetDirectoryName(modelAbsolute)!);
            File.WriteAllText(modelAbsolute, EmbeddedResourceLoader.ReadText(TemplatePathResolver.ResourcePrefix + "Templates.Welcome.WelcomeModel.cs")
                .Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal));
            manifest.GeneratedFiles.Add(modelPath);
            manifest.WelcomeFiles.Add(modelPath);
            manifest.OriginalHashes[modelPath] = FileRollback.ComputeHash(modelAbsolute)!;
        }
        var vmPath = TemplatePathResolver.ResolveDestination(root, ViewModelPath);
        var vm = EmbeddedResourceLoader.ReadText(TemplatePathResolver.ResourcePrefix + "Templates.Welcome.WelcomeViewModel.cs")
            .Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal);
        if (File.Exists(vmPath) && (manifest.OriginalHashes.GetValueOrDefault(ViewModelPath) != FileRollback.ComputeHash(vmPath)))
            throw new InvalidOperationException($"Conflict: '{ViewModelPath}' is untracked or edited. No changes made.");
        if (!File.Exists(vmPath))
        {
            rollback.TrackModified(vmPath);
            rollback.TrackCreatedDirectories(Path.GetDirectoryName(vmPath)!, root);
            Directory.CreateDirectory(Path.GetDirectoryName(vmPath)!);
            File.WriteAllText(vmPath, vm);
            if (!manifest.GeneratedFiles.Contains(ViewModelPath)) manifest.GeneratedFiles.Add(ViewModelPath);
            manifest.OriginalHashes[ViewModelPath] = FileRollback.ComputeHash(vmPath)!;
            manifest.WelcomeFiles.Add(ViewModelPath);
        }
        foreach (var file in new[] { "MainPage.xaml", "MainPage.xaml.cs" })
        {
            var path = TemplatePathResolver.ResolveDestination(root, file);
            var before = File.ReadAllText(path);
            if (before.Contains(file.EndsWith(".cs") ? "sf-cli:hybrid-binding" : "sf-cli:hybrid-layout-start")) continue;
            rollback.TrackModified(path);
            string after;
            if (file.EndsWith(".cs"))
            {
                var binding = GeneratedCodeBlocks.Wrap("hybrid-binding", $$$"""
                        BindingContext = new global::{{{rootNamespace}}}.Welcome.WelcomeViewModel(async page =>
                        {
                            var close = new ToolbarItem { Text = "Close sample" };
                            close.Clicked += async (_, _) => await Navigation.PopModalAsync();
                            page.ToolbarItems.Add(close);
                            await Navigation.PushModalAsync(new NavigationPage(page));
                        });
                """, indent: "        ");
                var index = before.IndexOf("InitializeComponent();", StringComparison.Ordinal) + "InitializeComponent();".Length;
                after = before.Insert(index, "\n" + binding);
            }
            else
            {
                var start = GeneratedCodeBlocks.Wrap("hybrid-layout-start", $$$"""
                    <Grid RowDefinitions="Auto,*" MinimumWidthRequest="0" MinimumHeightRequest="0">
                        <ScrollView Grid.Row="0" MaximumHeightRequest="220" MinimumWidthRequest="0" MinimumHeightRequest="0">
                            <VerticalStackLayout Padding="16" Spacing="12" MinimumWidthRequest="0" MinimumHeightRequest="0">
                                <Label Text="Your control samples" FontAttributes="Bold" MinimumWidthRequest="0" MinimumHeightRequest="0" />
                                <Label Text="No control samples yet. Add a control with sf add." IsVisible="{Binding IsEmpty}" LineBreakMode="WordWrap" MinimumWidthRequest="0" MinimumHeightRequest="0" />
                                <FlexLayout Direction="Row" Wrap="Wrap" AlignItems="Start" BindableLayout.ItemsSource="{Binding Samples}" MinimumWidthRequest="0" MinimumHeightRequest="0">
                                    <BindableLayout.ItemTemplate>
                                        <DataTemplate>
                                            <Button Text="{Binding Name}" CornerRadius="20" Margin="0,0,8,8" Padding="16,12"
                                                    MinimumHeightRequest="44" MinimumWidthRequest="0" FlexLayout.Shrink="1" LineBreakMode="WordWrap"
                                                    BackgroundColor="{AppThemeBinding Light=#EFF4FF, Dark=#194185}"
                                                    TextColor="{AppThemeBinding Light=#175CD3, Dark=#D1E9FF}"
                                                    Command="{Binding Source={RelativeSource AncestorType={x:Type ContentPage}}, Path=BindingContext.OpenSampleCommand}"
                                                    CommandParameter="{Binding .}" />
                                        </DataTemplate>
                                    </BindableLayout.ItemTemplate>
                                </FlexLayout>
                            </VerticalStackLayout>
                        </ScrollView>
                        <ContentView Grid.Row="1" MinimumWidthRequest="0" MinimumHeightRequest="0">
                """, xaml: true, indent: "    ");
                var end = GeneratedCodeBlocks.Wrap("hybrid-layout-end", "        </ContentView>\n    </Grid>", xaml: true, indent: "    ");
                var index = before.IndexOf("    <BlazorWebView", StringComparison.Ordinal);
                after = before.Insert(index, start).Replace("</ContentPage>", end + "</ContentPage>", StringComparison.Ordinal);
                _ = System.Xml.Linq.XDocument.Parse(after);
            }
            File.WriteAllText(path, after);
            manifest.GeneratedBlocks.AddRange(GeneratedCodeBlocks.CaptureNew(file, before, after));
            if (!manifest.ModifiedFiles.Contains(file)) manifest.ModifiedFiles.Add(file);
        }
    }

    private static string Normalize(string value) => value.TrimStart('\uFEFF').Replace("\r\n", "\n").Trim();
}
