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
Imports System.Drawing

Namespace GridExample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            AddHandler Loaded, New RoutedEventHandler(AddressOf Me.MainWindow_Loaded)
        End Sub

        Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.grid.ItemsSource = New List(Of TestData)() From {New TestData() With {.PlainText = "LMA AG", .MemoText = "Mercedes-Benz SLK " & Microsoft.VisualBasic.Constants.vbLf & " 2004 " & Microsoft.VisualBasic.Constants.vbLf & " Silver", .BooleanMember = True, .Image = GetImage("/Images/1.png")}, New TestData() With {.PlainText = "Western Motors", .MemoText = "Rolls-Royce Corniche " & Microsoft.VisualBasic.Constants.vbLf & " 1975 " & Microsoft.VisualBasic.Constants.vbLf & " Snowy whight", .BooleanMember = False, .Image = GetImage("/Images/2.png")}, New TestData() With {.PlainText = "Sun car rent", .MemoText = "Ford Ranger FX-4" & Microsoft.VisualBasic.Constants.vbLf & " 1999 " & Microsoft.VisualBasic.Constants.vbLf & " Red rock", .BooleanMember = True, .Image = GetImage("/Images/3.png")}}
        End Sub

        Private Function GetImage(ByVal path As String) As ImageSource
            Return New BitmapImage(New Uri(path, UriKind.Relative))
        End Function

        Private Sub PrintButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.view.ShowPrintPreview(Me)
        End Sub
    End Class
End Namespace
