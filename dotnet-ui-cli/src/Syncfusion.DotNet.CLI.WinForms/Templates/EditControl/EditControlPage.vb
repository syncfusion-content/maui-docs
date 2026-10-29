Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Enums

Namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
    Public Class __VIEW_NAME__
        Inherits UserControl

        Public Sub New()
            Dim sampleCode =
                "Imports System" & Environment.NewLine &
                "Imports System.Collections.Generic" & Environment.NewLine &
                "Imports System.Linq" & Environment.NewLine &
                Environment.NewLine &
                "Namespace SyntaxEditorSample" & Environment.NewLine &
                "    Public Class Product" & Environment.NewLine &
                "        Public Sub New(name As String, price As Decimal)" & Environment.NewLine &
                "            Me.Name = name" & Environment.NewLine &
                "            Me.Price = price" & Environment.NewLine &
                "        End Sub" & Environment.NewLine &
                Environment.NewLine &
                "        Public ReadOnly Property Name As String" & Environment.NewLine &
                Environment.NewLine &
                "        Public ReadOnly Property Price As Decimal" & Environment.NewLine &
                "    End Class" & Environment.NewLine &
                Environment.NewLine &
                "    Friend Module Program" & Environment.NewLine &
                "        Private Sub Main()" & Environment.NewLine &
                "            Dim products = New List(Of Product) From {" & Environment.NewLine &
                "                New Product(""Laptop"", 1200D)," & Environment.NewLine &
                "                New Product(""Monitor"", 350D)," & Environment.NewLine &
                "                New Product(""Keyboard"", 80D)" & Environment.NewLine &
                "            }" & Environment.NewLine &
                Environment.NewLine &
                "            ' Filter and display products that cost more than 100." & Environment.NewLine &
                "            Dim premiumProducts = products." & Environment.NewLine &
                "                Where(Function(product) product.Price > 100D)." & Environment.NewLine &
                "                OrderBy(Function(product) product.Name)" & Environment.NewLine &
                Environment.NewLine &
                "            For Each product In premiumProducts" & Environment.NewLine &
                "                Console.WriteLine($""{product.Name}: {product.Price:C}"")" & Environment.NewLine &
                "            Next" & Environment.NewLine &
                "        End Sub" & Environment.NewLine &
                "    End Module" & Environment.NewLine &
                "End Namespace"

            Dim editControl As New Syncfusion.Windows.Forms.Edit.EditControl With
            {
                .AccessibleName = "Syntax Editor",
                .BorderStyle = BorderStyle.FixedSingle,
                .Dock = DockStyle.Fill,
                .Font = New Font("Consolas", 11.0F),
                .Name = "editControl",
                .Text = sampleCode
            }

            editControl.ApplyConfiguration(KnownLanguages.VBNET)

            Controls.Add(editControl)

            MyBase.Dock = DockStyle.Fill
            Name = "__VIEW_NAME__"
            Size = New Size(900, 600)
        End Sub
    End Class
End Namespace
