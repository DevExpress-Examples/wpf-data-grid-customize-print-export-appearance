' Developer Express Code Central Example:
' How to use the PrintCellStyle property to customize cell's printing appearance
' 
' This example shows how to create custom PrintCellStyle for grid columns to bring
' a custom printing appearance for PopupImageEdit, CheckBoxEdit and MemoEdit.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3227

Imports System
Imports System.Windows
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Collections.Generic
Imports System.Windows.Resources
Imports System.IO
Imports System.Drawing
Imports System.Windows.Data


Namespace GridExample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            AddHandler Loaded, AddressOf MainWindow_Loaded
        End Sub

        Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            grid.ItemsSource = New List(Of TestData)() From { _
                New TestData() With {.PlainText = "LMA AG", .MemoText = "Mercedes-Benz SLK " & ControlChars.Lf & " 2004 " & ControlChars.Lf & " Silver", .BooleanMember = True, .Image = GetImage("/Images/1.png")}, _
                New TestData() With {.PlainText = "Western Motors", .MemoText ="Rolls-Royce Corniche " & ControlChars.Lf & " 1975 " & ControlChars.Lf & " Snowy whight", .BooleanMember = False, .Image = GetImage("/Images/2.png")}, _
                New TestData() With {.PlainText = "Sun car rent", .MemoText = "Ford Ranger FX-4" & ControlChars.Lf & " 1999 " & ControlChars.Lf & " Red rock", .BooleanMember = True, .Image = GetImage("/Images/3.png")} _
            }
        End Sub

        Private Function GetImage(ByVal path As String) As ImageSource
            Return New BitmapImage(New Uri(path, UriKind.Relative))
        End Function

        Private Sub PrintButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            view.ShowPrintPreview(Me)
        End Sub
    End Class
End Namespace
