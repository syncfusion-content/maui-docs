using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

internal static class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        if (args.Length != 3)
            throw new ArgumentException("Provide generated DLL path, WelcomeView full type name, and screenshot output directory.");
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        var assembly = Assembly.LoadFrom(Path.GetFullPath(args[0]));
        using var tabs = new TabControl { Dock = DockStyle.Fill };
        tabs.TabPages.Add(new TabPage("Welcome"));
        foreach (var id in new[] { "chart", "datagrid", "diagram", "docking-manager", "navigation-drawer" })
            tabs.TabPages.Add(new TabPage(id) { Tag = id });
        using var view = (UserControl)Activator.CreateInstance(assembly.GetType(args[1], true)!, tabs)!;
        view.Dock = DockStyle.Fill;
        tabs.TabPages[0].Controls.Add(view);
        using var form = new Form { AutoScaleMode = AutoScaleMode.Dpi, Text = "Welcome validation" };
        form.Controls.Add(tabs);
        form.Show();
        var output = Path.GetFullPath(args[2]);
        Directory.CreateDirectory(output);
        foreach (var width in new[] { 1440, 1024, 760, 360 })
        {
            form.ClientSize = new Size(width, 720);
            Application.DoEvents();
            var controls = Descendants(view).ToArray();
            var cards = controls.Where(control => control.GetType().Name == "WelcomePanel"
                && control.Controls.OfType<LinkLabel>().Any()).ToArray();
            Require(cards.Length == 4, "Expected four resource cards.");
            Require(cards.Select(card => card.Height).Distinct().Count() == 1, "Cards have unequal heights.");
            foreach (var card in cards)
            foreach (Control item in card.Controls)
                Require(item.Bottom + item.Margin.Bottom <= card.Height - card.Padding.Bottom,
                    "A resource card clips its contents.");
            var links = controls.OfType<LinkLabel>().Where(link => link.Text is "Privacy Policy" or "Terms of Service" or "Contact Us").ToArray();
            Require(links.Length == 3, "A footer link is missing.");
            foreach (var link in links)
            {
                Require(link.Parent!.ClientRectangle.Contains(link.Bounds), "Footer link is clipped.");
                Require(link.TabStop && link.Tag is string url && url.StartsWith("https://www.syncfusion.com/", StringComparison.Ordinal),
                    "Footer link must be keyboard-accessible and point to Syncfusion.");
            }
            Require(!view.HorizontalScroll.Visible, "Welcome page requires horizontal scrolling.");
            using var bitmap = new Bitmap(form.Width, form.Height);
            form.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            bitmap.Save(Path.Combine(output, $"welcome-{width}.png"));
            view.ScrollControlIntoView(links[0]);
            Application.DoEvents();
            using var footer = new Bitmap(form.Width, form.Height);
            form.DrawToBitmap(footer, new Rectangle(Point.Empty, footer.Size));
            footer.Save(Path.Combine(output, $"footer-{width}.png"));
            view.AutoScrollPosition = Point.Empty;
            Console.WriteLine($"PASS width={width}; four equal-height cards; three footer links; no horizontal scrolling");
        }
        foreach (var button in Descendants(view).OfType<Button>().ToArray())
        {
            tabs.SelectedIndex = 0;
            button.PerformClick();
            Require(tabs.SelectedIndex > 0, "Sample button failed to navigate.");
        }
        form.Close();
    }

    private static IEnumerable<Control> Descendants(Control root)
    {
        foreach (Control child in root.Controls)
        {
            yield return child;
            foreach (var descendant in Descendants(child)) yield return descendant;
        }
    }

    private static void Require(bool condition, string message)
    {
        if (!condition) throw new InvalidOperationException(message);
    }
}
