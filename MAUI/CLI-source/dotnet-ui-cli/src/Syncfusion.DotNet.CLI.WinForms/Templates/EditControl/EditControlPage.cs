#nullable disable

using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Enums;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public partial class __VIEW_NAME__ : UserControl
    {
        public __VIEW_NAME__()
        {
            var editControl = new Syncfusion.Windows.Forms.Edit.EditControl
            {
                AccessibleName = "Syntax Editor",
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 11F),
                Name = "editControl",
                Text = @"using System;
using System.Collections.Generic;
using System.Linq;

namespace SyntaxEditorSample
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }

        public decimal Price { get; }
    }

    internal static class Program
    {
        private static void Main()
        {
            var products = new List<Product>
            {
                new Product(""Laptop"", 1200m),
                new Product(""Monitor"", 350m),
                new Product(""Keyboard"", 80m)
            };

            // Filter and display products that cost more than 100.
            var premiumProducts = products
                .Where(product => product.Price > 100m)
                .OrderBy(product => product.Name);

            foreach (var product in premiumProducts)
            {
                Console.WriteLine($""{product.Name}: {product.Price:C}"");
            }
        }
    }
}",
            };

            editControl.ApplyConfiguration(KnownLanguages.CSharp);

            Controls.Add(editControl);

            Dock = DockStyle.Fill;
            Name = "__VIEW_NAME__";
            Size = new Size(900, 600);
        }
    }
}
