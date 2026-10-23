using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System.Collections.ObjectModel;
using Syncfusion.Blazor.RichTextEditor;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Buttons;

namespace __PAGE_NAMESPACE__;

public partial class RichTextEditorDemo
{
    private SfRichTextEditor? EditorRef;
    private string SaveURL = "https://blazor.syncfusion.com/services/production/api/RichTextEditor/SaveFile";
    private string Path = "https://blazor.syncfusion.com/services/production/RichTextEditor/";
    private string PlaceHolderText = "Type something or use @ to tag a user...";
    private bool Prompt = true;
    private bool Plaintext = false;
    private bool Keepformat = false;
    private string? DeniedTagsText { get; set; }
    private string? DeniedAttributesText { get; set; }
    private string? AllowedStylePropertiesText { get; set; }
    private string[]? Deniedtags { get; set; }
    private string[]? Deniedattr { get; set; }
    private string[] Allowedstyle { get; set; } = new string[]{
        "background", "background-color", "border", "border-bottom", "border-left", "border-radius",
        "border-right", "border-style", "border-top", "border-width", "clear", "color", "cursor",
        "direction", "display", "float", "font", "font-family", "font-size", "font-weight", "font-style",
        "height", "left", "line-height", "margin", "margin-top", "margin-left",
        "margin-right", "margin-bottom", "max-height", "max-width", "min-height", "min-width",
        "overflow", "overflow-x", "overflow-y", "padding", "padding-bottom", "padding-left", "padding-right",
        "padding-top", "position", "right", "table-layout", "text-align", "text-decoration", "text-indent",
        "top", "vertical-align", "visibility", "white-space", "width"
    };
    private List<ToolbarItemModel> Tools = new List<ToolbarItemModel>()
    {
        new ToolbarItemModel() { Command = ToolbarCommand.Undo },
        new ToolbarItemModel() { Command = ToolbarCommand.Redo },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.ImportWord },
        new ToolbarItemModel() { Command = ToolbarCommand.ExportWord },
        new ToolbarItemModel() { Command = ToolbarCommand.ExportPdf },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.Bold },
        new ToolbarItemModel() { Command = ToolbarCommand.Italic },
        new ToolbarItemModel() { Command = ToolbarCommand.Underline },
        new ToolbarItemModel() { Command = ToolbarCommand.StrikeThrough },
        new ToolbarItemModel() { Command = ToolbarCommand.InlineCode },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator},
        new ToolbarItemModel() { Command = ToolbarCommand.CreateLink },
        new ToolbarItemModel() { Command = ToolbarCommand.Image },
        new ToolbarItemModel() { Command = ToolbarCommand.CreateTable },
        new ToolbarItemModel() { Command = ToolbarCommand.CodeBlock },
        new ToolbarItemModel() { Command = ToolbarCommand.HorizontalLine },
        new ToolbarItemModel() { Command = ToolbarCommand.Blockquote },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.LineHeight },
        new ToolbarItemModel() { Command = ToolbarCommand.Formats },
        new ToolbarItemModel() { Command = ToolbarCommand.Alignments },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.BulletFormatList },
        new ToolbarItemModel() { Command = ToolbarCommand.NumberFormatList },
        new ToolbarItemModel() { Command = ToolbarCommand.Checklist },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.Outdent },
        new ToolbarItemModel() { Command = ToolbarCommand.Indent },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.FontColor },
        new ToolbarItemModel() { Command = ToolbarCommand.BackgroundColor },
        new ToolbarItemModel() { Command = ToolbarCommand.FontName },
        new ToolbarItemModel() { Command = ToolbarCommand.FontSize },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.LowerCase },
        new ToolbarItemModel() { Command = ToolbarCommand.UpperCase },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.SuperScript },
        new ToolbarItemModel() { Command = ToolbarCommand.SubScript },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator},
        new ToolbarItemModel() { Command = ToolbarCommand.Video },
        new ToolbarItemModel() { Command = ToolbarCommand.Audio },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.FormatPainter },
        new ToolbarItemModel() { Command = ToolbarCommand.ClearFormat },
        new ToolbarItemModel() {Command = ToolbarCommand.Separator},
        new ToolbarItemModel() { Command = ToolbarCommand.Print },
        new ToolbarItemModel() { Command = ToolbarCommand.SourceCode },
        new ToolbarItemModel() { Command = ToolbarCommand.FullScreen }
    };
    private List<ToolbarItemModel> TextQuickToolbarItems = new List<ToolbarItemModel>()
    {
        new ToolbarItemModel() { Command = ToolbarCommand.Formats },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.Bold },
        new ToolbarItemModel() { Command = ToolbarCommand.Italic },
        new ToolbarItemModel() { Command = ToolbarCommand.FontColor },
        new ToolbarItemModel() { Command = ToolbarCommand.BackgroundColor },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.CreateLink },
        new ToolbarItemModel() { Command = ToolbarCommand.Image },
        new ToolbarItemModel() { Command = ToolbarCommand.CreateTable },
        new ToolbarItemModel() { Command = ToolbarCommand.Blockquote },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.UnorderedList },
        new ToolbarItemModel() { Command = ToolbarCommand.OrderedList },
        new ToolbarItemModel() { Command = ToolbarCommand.Indent },
        new ToolbarItemModel() { Command = ToolbarCommand.Outdent },
    };
    private List<TableToolbarItemModel> TableQuickToolbarItems = new List<TableToolbarItemModel>()
    {
        new TableToolbarItemModel() { Command = TableToolbarCommand.TableHeader },
        new TableToolbarItemModel() { Command = TableToolbarCommand.TableRemove },
        new TableToolbarItemModel() { Command = TableToolbarCommand.Separator },
        new TableToolbarItemModel() { Command = TableToolbarCommand.TableRows },
        new TableToolbarItemModel() { Command = TableToolbarCommand.TableColumns },
        new TableToolbarItemModel() { Command = TableToolbarCommand.TableCell },
        new TableToolbarItemModel() { Command = TableToolbarCommand.Separator },
        new TableToolbarItemModel() { Command = TableToolbarCommand.TableEditProperties },
        new TableToolbarItemModel() { Command = TableToolbarCommand.Styles },
        new TableToolbarItemModel() { Command = TableToolbarCommand.BackgroundColor },
        new TableToolbarItemModel() { Command = TableToolbarCommand.Alignments },
        new TableToolbarItemModel() { Command = TableToolbarCommand.TableCellVerticalAlign }
    };
    public class PersonData
    {
        public string? Name { get; set; }
        public string? Initial { get; set; }
        public string? Email { get; set; }
        public string? Color { get; set; }
        public string? BgColor { get; set; }
    }
    private List<PersonData> EmailData = new List<PersonData>
    {
        new PersonData() { Name = "Selma Rose", Initial = "SR", Email = "selma@gmail.com", Color = "#FAFDFF", BgColor = "#01579B" },
        new PersonData() { Name = "Maria", Initial = "MA", Email = "maria@gmail.com", Color = "#004378", BgColor = "#ADDBFF" },
        new PersonData() { Name = "Russo Kay", Initial = "RK", Email = "russo@gmail.com", Color = "#F9DEDC", BgColor = "#8C1D18" },
        new PersonData() { Name = "Robert", Initial = "RO", Email = "robert@gmail.com", Color = "#FFD6F7", BgColor = "#37003A" },
        new PersonData() { Name = "Camden Kate", Initial = "CK", Email = "camden@gmail.com", Color = "#FFFFFF", BgColor = "#464ECF" },
        new PersonData() { Name = "Garth", Initial = "GA", Email = "garth@gmail.com", Color = "#FFFFFF", BgColor = "#008861" },
        new PersonData() { Name = "Andrew James", Initial = "AJ", Email = "james@gmail.com", Color = "#FFFFFF", BgColor = "#53CA17" },
        new PersonData() { Name = "Olivia", Initial = "OL", Email = "olivia@gmail.com", Color = "#FFFFFF", BgColor = "#8C1D18" },
        new PersonData() { Name = "Sophia", Initial = "SO", Email = "sophia@gmail.com", Color = "#000000", BgColor = "#D0BCFF" },
        new PersonData() { Name = "Margaret", Initial = "MA", Email = "margaret@gmail.com", Color = "#000000", BgColor = "#F2B8B5" },
        new PersonData() { Name = "Ursula Ann", Initial = "UA", Email = "ursula@gmail.com", Color = "#000000", BgColor = "#47ACFB" },
        new PersonData() { Name = "Laura Grace", Initial = "LG", Email = "laura@gmail.com", Color = "#000000", BgColor = "#FFE088" },
        new PersonData() { Name = "Albert", Initial = "AL", Email = "albert@gmail.com", Color = "#FFFFFF", BgColor = "#00335B" },
        new PersonData() { Name = "William", Initial = "WA", Email = "william@gmail.com", Color = "#FFFFFF", BgColor = "#163E02" }
    };
    private List<SlashMenuItemModel> slashmenuItems = new List<SlashMenuItemModel>()
    {
        new SlashMenuItemModel() {Command = SlashMenuCommand.Paragraph},
        new SlashMenuItemModel() {Command = SlashMenuCommand.Heading1},
        new SlashMenuItemModel() {Command = SlashMenuCommand.Heading2},
        new SlashMenuItemModel() {Command = SlashMenuCommand.Heading3},
        new SlashMenuItemModel() {Command = SlashMenuCommand.Heading4},
        new SlashMenuItemModel() {Command = SlashMenuCommand.OrderedList},
        new SlashMenuItemModel() {Command = SlashMenuCommand.UnorderedList},
        new SlashMenuItemModel() {Command = SlashMenuCommand.Blockquote},
        new SlashMenuItemModel() {Command = SlashMenuCommand.CodeBlock},
        new SlashMenuItemModel() {Command = SlashMenuCommand.Image},
        new SlashMenuItemModel() {Command = SlashMenuCommand.Audio},
        new SlashMenuItemModel() {Command = SlashMenuCommand.Video},
        new SlashMenuItemModel() {Command = SlashMenuCommand.Link},
        new SlashMenuItemModel() {Command = SlashMenuCommand.Table},
    };
}
