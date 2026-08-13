---
layout: post
title: AI Task Prioritization Engine in .NET MAUI Kanban Board | Syncfusion®
description: Learn how to implement an AI-Driven Task Prioritization Engine using the Syncfusion® .NET MAUI Kanban Board (SfKanban) control.
platform: maui
control: SfKanban
documentation: ug
---

# AI-Driven Task Prioritization Engine in .NET MAUI Kanban Board

This document walks you through implementing an AI-powered task prioritization engine using the Syncfusion [.NET MAUI Kanban](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) control. The example leverages Azure OpenAI to analyze task deadlines, impact, and dependencies, then automatically reorder tasks to help teams focus on the most important work items first.

## Prerequisites

Before you begin, ensure you have the following:

- A working .NET MAUI application with the `Syncfusion.Maui.Kanban` and `Syncfusion.Maui.Buttons` packages installed.
- An active Azure subscription with access to [Azure OpenAI](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/overview) and a deployed model. If you don't have access, refer to the [create and deploy Azure OpenAI service](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/how-to/create-resource?pivots=web-portal) guide to set up a new account. Note down the deployment name, endpoint URL, and API key.
- Install the following AI-related NuGet packages:

    ```powershell
    Install-Package Azure.AI.OpenAI -Version 2.0.0
    Install-Package Azure.Identity -Version 1.13.1
    Install-Package Microsoft.Extensions.AI.OpenAI -Version 9.0.1-preview.1.24570.5
    ```
    Or using the .NET CLI:
    ```bash
    dotnet add package Azure.AI.OpenAI --version 2.0.0
    dotnet add package Azure.Identity --version 1.13.1
    dotnet add package Microsoft.Extensions.AI.OpenAI --version 9.0.1-preview.1.24570.5
    ```

## Integrating Azure OpenAI with your .NET MAUI App

First, create a service class to communicate with [Azure OpenAI](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/overview). Replace the `endpoint`, `deploymentName`, and `key` with values from your Azure OpenAI resource.

The `AzureOpenAIBaseService` class initializes the Azure OpenAI chat client, validates the credentials, and retrieves AI-generated responses for task prioritization.

{% tabs %}
{% highlight c# %}

// AzureOpenAIBaseService.cs

    internal class AzureOpenAIBaseService
    {
        private const string endpoint = "<MENTION-YOUR-URL>";
        private const string deploymentName = "<MENTION-YOUR-DEPLOYMENT-NAME>";
        private const string key = "<MENTION-YOUR-KEY>";

        private IChatClient? client;

        public bool IsCredentialValid { get; private set; } = false;

        public AzureOpenAIBaseService()
        {
            Initialize();
            _ = ValidateCredential();
        }

        private void Initialize()
        {
            try
            {
                client = new AzureOpenAIClient(new Uri(endpoint),new AzureKeyCredential(key)).AsChatClient(modelId: deploymentName);
            }
            catch
            {
                client = null;
            }
        }

        private async Task ValidateCredential()
        {
            try
            {
                if (client != null)
                {
                    await client.CompleteAsync("Test message");
                    IsCredentialValid = true;
                }
            }
            catch
            {
                IsCredentialValid = false;
            }
        }

        public async Task<string> GetAIResponse(string prompt)
        {
            try
            {
                if (!IsCredentialValid || client == null)
                    return string.Empty;

                var response = await client.CompleteAsync(prompt);

                return response?.ToString() ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }

{% endhighlight %}

{% endtabs %}

## Creating the task model

The `CardDetails` model stores task information such as title, description, due date, workflow category, assignee details, and visual properties used to highlight AI-prioritized tasks.

{% tabs %}
{% highlight c# %}

// CardDetails.cs

    public class CardDetails : INotifyPropertyChanged
    {
        private string? _name;
        private string? _title;
        private string? _description;
        private string? _category;
        private int _index;
        private double _progress;
        private string? _image;
        private DateTime _dueDate;
        private Color _urgencyStrokeColor = Colors.Transparent;
        private double _strokeThickness = 0;
        private double glowOpacity = 1;

        public string? Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string? Title
        {
            get => _title;
            set { _title = value; OnPropertyChanged(nameof(Title)); }
        }

        public string? Description
        {
            get => _description;
            set { _description = value; OnPropertyChanged(nameof(Description)); }
        }

        public string? Category
        {
            get => _category;
            set { _category = value; OnPropertyChanged(nameof(Category)); }
        }

        public int Index
        {
            get => _index;
            set { _index = value; OnPropertyChanged(nameof(Index)); }
        }

        public double Progress
        {
            get => _progress;
            set { _progress = value; OnPropertyChanged(nameof(Progress)); }
        }

        public string? Image
        {
            get => _image;
            set { _image = value; OnPropertyChanged(nameof(Image)); }
        }

        public DateTime DueDate
        {
            get => _dueDate;
            set { _dueDate = value; OnPropertyChanged(nameof(DueDate)); }
        }

        public Color UrgencyStrokeColor
        {
            get => _urgencyStrokeColor;
            set { _urgencyStrokeColor = value; OnPropertyChanged(nameof(UrgencyStrokeColor)); }
        }

        public double StrokeThickness
        {
            get => _strokeThickness;
            set { _strokeThickness = value; OnPropertyChanged(nameof(StrokeThickness)); }
        }

        public double GlowOpacity
        {
            get => glowOpacity;
            set
            {
                glowOpacity = value;
                OnPropertyChanged(nameof(GlowOpacity));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

{% endhighlight %}

{% endtabs %}

## Creating the ViewModel

The `ViewModel` maintains the collection of Kanban cards displayed in the board. Tasks are organized into workflow stages such as `To Do`, `In Progress`, `Review`, and `Done`. The `Index` property is used by the Kanban control to determine card ordering.

{% tabs %}
{% highlight c# %}

// ViewModel.cs

    public class ViewModel
    {
        public ObservableCollection<CardDetails> Cards { get; set; }

        public ViewModel()
        {
            Cards = GetCardDetails();
        }

        private ObservableCollection<CardDetails> GetCardDetails()
        {
            var today = DateTime.Today;

            return new ObservableCollection<CardDetails>
            {
                // OPEN
                new CardDetails { Name = "Bella", Index=1, Title="Refactor Auth Service", Category="Open", Progress=0, Description="Refactor authentication service to support token refresh and improve modularity.", Image="bella.png", DueDate=today.AddDays(30) },
                new CardDetails { Name = "Olivia", Index=2, Title="Redesign Login UI", Category="Open", Progress=0, Description="Implement responsive login screen with validation and error handling.", Image="olivia.png", DueDate=today.AddDays(10) },
                . . .

                // IN PROGRESS
                new CardDetails { Name = "Zara", Index=6, Title="Integrate Payments", Category="In Progress", Progress=0.5, Description="Integrate Razorpay SDK and handle success/failure callbacks securely.", Image="zara.png", DueDate=today.AddDays(7) },
                new CardDetails { Name = "David", Index=7, Title="Setup Push Service", Category="In Progress", Progress=0.5, Description="Configure Firebase Cloud Messaging for push notifications.", Image="david.png", DueDate=today.AddDays(5) },
                . . .

                // CODE REVIEW 
                new CardDetails { Name = "Edward", Index=11, Title="Test Kanban DragDrop", Category="Code Review", Progress=0.8, Description="Validate drag-and-drop functionality and state synchronization.", Image="edward.png", DueDate=today.AddDays(3) },
                new CardDetails { Name = "Janet", Index=12, Title="Optimize DB Queries", Category="Code Review", Progress=0.8, Description="Review and optimize SQL queries and indexing for performance.", Image="janet.png", DueDate=today.AddDays(4) },
                . . .

                // DONE 
                new CardDetails { Name = "Esther", Index=16, Title="Complete Auth Module", Category="Done", Progress=1, Description="Implemented JWT authentication and role-based access control.", Image="esther.png", DueDate=today.AddDays(-2) },
                new CardDetails { Name = "Olivia", Index=17, Title="Finish Profile UI", Category="Done", Progress=1, Description="Built responsive profile page with editable fields and validation.", Image="olivia.png", DueDate=today.AddDays(-1) },
                . . .
            };
        }
    }

{% endhighlight %}

{% endtabs %}

## Implementing AI-based task prioritization

Create a custom behavior that connects the Kanban Board with Azure OpenAI. This behavior is responsible for collecting active tasks, sending task information to Azure OpenAI for analysis, reordering tasks based on the AI response, and highlighting high-priority tasks within the Kanban Board.

The `BuildPrompt` method converts the active Kanban tasks into a structured prompt. In addition to due dates, the prompt instructs Azure OpenAI to consider business impact, task dependencies, and critical operations such as security, API integrations, and payment processing when determining task priority.

The `KanbanAIReorderBehavior` is attached to the page and automatically connects with the Kanban control, AI action button, and ViewModel. When the AI button is clicked, all active tasks are collected and sent to Azure OpenAI. The AI analyzes task attributes such as due dates, descriptions, and business impact, then returns a prioritized task list.

The behavior processes the AI response and updates the underlying collection. Since the Kanban control uses the [SortingMappingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_SortingMappingPath) property, cards are automatically reordered according to the AI-generated priority. Tasks in the Done column are excluded from AI analysis, ensuring that prioritization is applied only to active work items. Additionally, the highest-priority task in each active column is highlighted using border styling and glow animations.

{% tabs %}
{% highlight c# %}

// KanbanAIReorderBehavior.cs

    public class KanbanAIReorderBehavior : Behavior<ContentPage>
    {
        private SfButton? button;
        private Label? infoLabel;
        private Border? infoContainer;
        private SfKanban? kanban;
        private ViewModel? viewModel;
        private ContentPage? attachedPage;
        private readonly AzureOpenAIBaseService aiService = new();
        private const string DoneCategory = "Done";
        private const int AiTimeoutMs = 3000;

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            attachedPage = bindable;

            bindable.BindingContextChanged += OnBindingContextChanged;
            viewModel = bindable.BindingContext as ViewModel;

            button = bindable.FindByName<SfButton>("aiSortButton");
            infoLabel = bindable.FindByName<Label>("infoLabel");
            infoContainer = bindable.FindByName<Border>("infoContainer");
            kanban = bindable.FindByName<SfKanban>("kanbanBoard");

            if (button != null)
            {
                button.Clicked += OnAISortClicked;
            }
        }

        private void OnBindingContextChanged(object? sender, EventArgs e)
        {
            viewModel = (sender as ContentPage)?.BindingContext as ViewModel;
        }

        private async void OnAISortClicked(object? sender, EventArgs e)
        {
            if (viewModel == null || button == null || infoLabel == null) return;

            button.IsEnabled = false;
            if (infoContainer != null) infoContainer.IsVisible = false;

            await ShowInfo("AI analyzing tasks...");

            if (!aiService.IsCredentialValid)
            {
                await StopUI("Invalid AI credentials");
                return;
            }

            if (kanban != null) await kanban.FadeToAsync(0.3, 150);

            var activeTasks = viewModel.Cards.Where(c => c.Category != DoneCategory).ToList();
            var doneTasks = viewModel.Cards.Where(c => c.Category == DoneCategory)
                                            .OrderBy(c => c.Index).ToList();

            string prompt = BuildPrompt(activeTasks);
            string result = await GetAIResponseWithTimeout(prompt);

            var finalList = ApplyAIResult(activeTasks, result);
            finalList.AddRange(doneTasks);

            viewModel.Cards.Clear();
            int index = 1;
            foreach (var card in finalList)
            {
                card.Index = index++;
                viewModel.Cards.Add(card);
            }

            var topTasks = viewModel.Cards
                .Where(c => c.Category != DoneCategory)
                .GroupBy(c => c.Category)
                .Select(g => g.First())
                .ToList();

            foreach (var task in topTasks)
            {
                _ = ApplyGlowEffect(task);
            }

            if (kanban != null)
            {
                kanban.TranslationY = 30;
                await Task.WhenAll(
                    kanban.FadeToAsync(1, 300),
                    kanban.TranslateToAsync(0, 0, 300, Easing.CubicIn));
            }

            await StopUI("✅ AI prioritization completed");
        }

        private async Task<string> GetAIResponseWithTimeout(string prompt)
        {
            try
            {
                var aiTask = aiService.GetAIResponse(prompt);
                var winner = await Task.WhenAny(aiTask, Task.Delay(AiTimeoutMs));
                return winner == aiTask ? await aiTask : string.Empty;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"AI request failed: {ex.Message}");
                return string.Empty;
            }
        }

        private async Task ShowInfo(string message)
        {
            if (infoLabel == null) return;

            infoLabel.Text = message;
            if (infoContainer != null) infoContainer.IsVisible = true;

            infoLabel.Opacity = 0;
            await infoLabel.FadeToAsync(1, 150);
        }

        private string BuildPrompt(List<CardDetails> tasks)
        {
            string taskText = string.Join("\n", tasks.Select(t =>
                $"Title: {t.Title}, Description: {t.Description}, DueDate: {t.DueDate:yyyy-MM-dd}"));

            return $@"You are an AI task prioritization engine.
                Analyze the following tasks and determine priority.
                RULES:
                1. Tasks with nearer DueDate = higher priority
                2. If tasks have SAME DueDate:
                    - prioritize based on IMPACT (critical, backend, integrations)
                    - prioritize tasks affecting other tasks (DEPENDENCIES)
                3. Payment, API, security, core system = HIGH priority
                4. UI, cosmetic changes = LOW priority
                Return ONLY JSON array of Titles in correct order.
                Tasks:{taskText}";
        }

        private static List<CardDetails> ApplyAIResult(List<CardDetails> tasks, string aiResult)
        {
            if (string.IsNullOrWhiteSpace(aiResult))
                return tasks.OrderBy(t => t.DueDate).ToList();

            try
            {
                int start = aiResult.IndexOf('[');
                int end = aiResult.LastIndexOf(']');
                if (start < 0 || end < 0 || end <= start)
                    return tasks.OrderBy(t => t.DueDate).ToList();

                string json = aiResult.Substring(start, end - start + 1);
                var titles = JsonSerializer.Deserialize<List<string>>(json);
                return tasks.OrderBy(t => titles?.IndexOf(t.Title!) ?? int.MaxValue).ToList();
            }
            catch (JsonException ex)
            {
                System.Diagnostics.Debug.WriteLine($"AI JSON parse failed: {ex.Message}");
                return tasks.OrderBy(t => t.DueDate).ToList();
            }
        }

        private async Task StopUI(string message)
        {
            if (infoLabel != null)
            {
                infoLabel.Text = message;
                if (infoContainer != null) infoContainer.IsVisible = true;

                infoLabel.Opacity = 1;
                await Task.Delay(2000);
                await infoLabel.FadeToAsync(0, 300);
                if (infoContainer != null) infoContainer.IsVisible = false;
            }

            if (button != null) button.IsEnabled = true;
        }

        private async Task ApplyGlowEffect(CardDetails card)
        {
            try
            {
                card.UrgencyStrokeColor = Colors.PapayaWhip;
                card.StrokeThickness = 3;

                for (int i = 0; i < 3; i++)
                {
                    card.GlowOpacity = 0.6;
                    await Task.Delay(400);
                    card.GlowOpacity = 1;
                    await Task.Delay(200);
                }

                await Task.Delay(1200);
                card.StrokeThickness = 0;
                card.UrgencyStrokeColor = Colors.Gold;
                card.GlowOpacity = 1;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Glow effect failed: {ex.Message}");
            }
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            if (attachedPage != null)
            {
                attachedPage.BindingContextChanged -= OnBindingContextChanged;
                attachedPage = null;
            }

            if (button != null)
            {
                button.Clicked -= OnAISortClicked;
                button = null;
            }

            base.OnDetachingFrom(bindable);
        }
    }

{% endhighlight %}

{% endtabs %}

## Creating the Kanban Board user interface

The [SfKanban](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) control binds to the ViewModel task collection and displays tasks across four workflow stages: To Do, In Progress, Review, and Done. The AI action button initiates task prioritization and refreshes the board with the AI-generated ordering.

{% tabs %}
{% highlight c# %}

// MainPage.xaml

    <ContentPage . . .
                 xmlns:kanban="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban"
                 xmlns:button="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"
                 xmlns:local="clr-namespace:AITaskPrioritization"
                 x:Class="AITaskPrioritization.MainPage">

        <!-- Behavior -->
        <ContentPage.Behaviors>
            <local:KanbanAIReorderBehavior />
        </ContentPage.Behaviors>

        <!-- ViewModel -->
        <ContentPage.BindingContext>
            <local:ViewModel/>
        </ContentPage.BindingContext>

        <!-- Resources -->
        <ContentPage.Resources>
            <ResourceDictionary>
                <DataTemplate x:Key="CardTemplate">

                    <Border Padding="12" Margin="8" BackgroundColor="White" Opacity="{Binding GlowOpacity}"
                        Stroke="{Binding UrgencyStrokeColor}" StrokeThickness="{Binding StrokeThickness}">

                        <Border.StrokeShape>
                            <RoundRectangle CornerRadius="14"/>
                        </Border.StrokeShape>

                        <Grid RowDefinitions="Auto,Auto,Auto" RowSpacing="6">

                            <Grid Grid.Row="0" ColumnDefinitions="*,Auto">

                                <HorizontalStackLayout Grid.Column="1" Spacing="4" VerticalOptions="Center">

                                    <!-- DUE DATE -->
                                    <Label Text="&#xe758;" FontFamily="MauiSampleFontIcon" 
                                    TextColor="#777" FontSize="13"/>

                                    <Label Text="{Binding DueDate, StringFormat='{0:dd MMM}'}"
                                    FontSize="11" TextColor="#777"/>
                                </HorizontalStackLayout>

                            </Grid>

                            <!-- TITLE -->
                            <Label Grid.Row="0" Grid.Column="0" Text="{Binding Title}"
                            FontSize="14" FontAttributes="Bold" TextColor="#222"/>

                            <!-- DESCRIPTION -->
                            <Label Grid.Row="1" Text="{Binding Description}" FontSize="12"
                            TextColor="#666" MaxLines="2" LineBreakMode="TailTruncation"/>

                            <!-- CLEAN BOTTOM ROW -->
                            <Grid Grid.Row="2" Margin="0,8,0,0" ColumnDefinitions="Auto,*,Auto"
                            VerticalOptions="Center">

                                <!-- Avatar -->
                                <Image Source="{Binding Image}" HeightRequest="26" WidthRequest="26"
                                    Aspect="AspectFill">
                                    <Image.Clip>
                                        <EllipseGeometry Center="13,13" RadiusX="13" RadiusY="13"/>
                                    </Image.Clip>
                                </Image>

                                <!-- NAME -->
                                <Label Grid.Column="1" Text="{Binding Name}" FontSize="11"
                                TextColor="#444" VerticalOptions="Center" Margin="6,0,0,0"/>

                                <Label Grid.Column="2" Text="&#xe75a;" FontFamily="MauiSampleFontIcon"
                                TextColor="#555" FontSize="13" VerticalOptions="Center"/>

                            </Grid>

                        </Grid>
                    </Border>
                </DataTemplate>

            </ResourceDictionary>
        </ContentPage.Resources>

        <Grid RowDefinitions="Auto,*">

            <!-- HEADER -->
            <Grid Grid.Row="0" Padding="10" ColumnDefinitions="*,Auto">

                <Label Text="AI-Driven Task Prioritization Engine" FontSize="18" FontAttributes="Bold"
                VerticalOptions="Center" HorizontalOptions="Center"/>

                <button:SfButton x:Name="aiSortButton" Grid.Column="1" Text="&#xe7e1;" TextColor="White"
                            Background="#6C4EFF" FontFamily="MauiSampleFontIcon" CornerRadius="12"
                            WidthRequest="44" HeightRequest="44" FontSize="24"/>

            </Grid>

            <!-- KANBAN -->
            <kanban:SfKanban x:Name="kanbanBoard" Grid.Row="1" ItemsSource="{Binding Cards}"
                        ColumnMappingPath="Category" SortingMappingPath="Index"
                        AutoGenerateColumns="False" CardTemplate="{StaticResource CardTemplate}">

                <!-- Placeholder Style -->
                <kanban:SfKanban.Resources>
                    <kanban:KanbanPlaceholderStyle x:Key="PlaceholderStyle" Background="#FAC7AD"
                                            SelectionIndicatorBackground="#FAC7AD"
                                            SelectionIndicatorStroke="#914C00">

                        <kanban:KanbanPlaceholderStyle.SelectionIndicatorTextStyle>
                            <kanban:KanbanTextStyle TextColor="#914C00" />
                        </kanban:KanbanPlaceholderStyle.SelectionIndicatorTextStyle>

                    </kanban:KanbanPlaceholderStyle>
                </kanban:SfKanban.Resources>

                <!-- Columns -->
                <kanban:KanbanColumn Title="To Do" Categories="Open" Background="#DAE0E3"
                                PlaceholderStyle="{StaticResource PlaceholderStyle}" />

                <kanban:KanbanColumn Title="In Progress" Categories="In Progress" Background="#D6EAF5"
                                PlaceholderStyle="{StaticResource PlaceholderStyle}" />

                <kanban:KanbanColumn Title="Review" Categories="Code Review" Background="#FFF8DC"
                                PlaceholderStyle="{StaticResource PlaceholderStyle}" />

                <kanban:KanbanColumn Title="Done" Categories="Done" Background="#DCEDDC" AllowDrag="False"
                                PlaceholderStyle="{StaticResource PlaceholderStyle}" />

            </kanban:SfKanban>

            <!-- Info label -->

            <Border x:Name="infoContainer" Grid.RowSpan="2" HorizontalOptions="Center" VerticalOptions="Center"
                    Stroke="Black" StrokeThickness="1.5" BackgroundColor="GhostWhite" Padding="12"
                    StrokeShape="RoundRectangle 10" IsVisible="False">

                <Label x:Name="infoLabel" TextColor="Black" FontSize="20" FontAttributes="Bold"
                    HorizontalOptions="Center" VerticalOptions="Center" />
            </Border>

        </Grid>

    </ContentPage>

{% endhighlight %}

{% endtabs %}

## Running the application

When the application launches, tasks are displayed in their respective Kanban columns.

When the user clicks the AI action button:

- Active tasks are collected from the Kanban Board.
- Task information is sent to Azure OpenAI.
- Azure OpenAI analyzes and prioritizes the tasks.
- The task collection is reordered based on the AI response.
- The highest-priority task in each active column is visually highlighted.

This provides an intelligent task management experience that helps users focus on urgent and high-impact work items.

![.NET MAUI Kanban Board.](Images/smart-ai-solution/kanbanboard.gif)

You can find the complete sample from this [link.](https://github.com/SyncfusionExamples/AI-Task-Prioritization-Engine-with-MAUI-Kanban-Board)

## See also

* [Getting Started](https://help.syncfusion.com/maui/kanban-board/getting-started)
* [Sorting](https://help.syncfusion.com/maui/kanban-board/sorting)
* [Workflow](https://help.syncfusion.com/maui/kanban-board/workflows)
