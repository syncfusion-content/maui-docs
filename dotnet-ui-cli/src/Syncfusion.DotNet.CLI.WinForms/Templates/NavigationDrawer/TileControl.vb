
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace __ROOT_NAMESPACE__.NavigationDrawer
    Public Class TileControl
        Inherits Control
        Private ReadOnly fieldFont As Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular)
        Private ReadOnly textSize As Size

        Public Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)
            HeaderText = "HeaderText"
            PostionText = "PostionText"
            OrganizatonText = "OrganizatonText"
            DOBText = "DOBText"
            LocationText = "LocationText"
            HeaderColor = Color.Black
            HeaderTextColor = Color.Black
            TextColor = Color.Black
            TileImage = New Bitmap(10, 10)
            textSize = TextRenderer.MeasureText(" Date Of Birth", MyBase.Font)
        End Sub

        <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property HeaderColor As Color

        <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property HeaderText As String

        <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property TileImage As Image

        <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property PostionText As String

        <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property OrganizatonText As String

        <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property LocationText As String

        <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property DOBText As String

        <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property TextColor As Color

        <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property HeaderTextColor As Color

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                fieldFont.Dispose()
                TileImage?.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
            Dim headerBounds = New Rectangle(0, 0, Width, 45)
            Dim imageBounds = New Rectangle(15, headerBounds.Bottom + 15, TileImage.Width, TileImage.Height)
            Dim labelsX = imageBounds.Right + 10
            Dim valuesX = labelsX + 102
            Dim firstLabelY = headerBounds.Bottom + 15
            Dim lineHeight = textSize.Height + 15
            Dim headerTextSize = TextRenderer.MeasureText(HeaderText, MyBase.Font)
            Dim headerTextY = headerBounds.Y + (headerBounds.Height - headerTextSize.Height) / 2

            Using borderPen = New Pen(HeaderColor, 2)
                Using headerBrush = New SolidBrush(HeaderColor)
                    Using headerFont = New Font(fieldFont.FontFamily, 11, FontStyle.Bold)
                        Using headerTextBrush = New SolidBrush(HeaderTextColor)
                            Using textBrush = New SolidBrush(TextColor)
                                Using boldFieldFont = New Font(fieldFont, FontStyle.Bold)
                                    e.Graphics.DrawRectangle(borderPen, 0, 0, Math.Max(0, Width - 1), Math.Max(0, Height - 1))
                                    e.Graphics.FillRectangle(headerBrush, headerBounds)
                                    e.Graphics.DrawString(HeaderText, headerFont, headerTextBrush, 5.0F, CSng(headerTextY))
                                    If TileImage IsNot Nothing Then
                                        e.Graphics.DrawImage(TileImage, imageBounds)
                                    End If

                                    DrawField(e.Graphics, "Postion", PostionText, labelsX, valuesX, firstLabelY, boldFieldFont, fieldFont, textBrush)
                                    DrawField(e.Graphics, "Organizaton", OrganizatonText, labelsX, valuesX, firstLabelY + lineHeight, boldFieldFont, fieldFont, textBrush)
                                    DrawField(e.Graphics, "Date Of Birth", DOBText, labelsX, valuesX, firstLabelY + lineHeight * 2, boldFieldFont, fieldFont, textBrush)
                                    DrawField(e.Graphics, "Location", LocationText, labelsX, valuesX, firstLabelY + lineHeight * 3, boldFieldFont, fieldFont, textBrush)
                                End Using
                            End Using
                        End Using
                    End Using
                End Using
            End Using
        End Sub

        Private Shared Sub DrawField(graphics As Graphics, label As String, value As String, labelsX As Integer, valuesX As Integer, y As Integer, labelFont As Font, valueFont As Font, brush As Brush)
            graphics.DrawString(label, labelFont, brush, labelsX, y)
            graphics.DrawString(value, valueFont, brush, valuesX, y)
        End Sub
    End Class
End Namespace
