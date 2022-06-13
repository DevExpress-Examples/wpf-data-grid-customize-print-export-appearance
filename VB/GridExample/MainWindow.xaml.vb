Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Media
Imports System.Windows.Media.Imaging

Namespace GridExample

    Public Class TestData

        Public Property PlainText As String

        Public Property MemoText As String

        Public Property BooleanMember As Boolean

        Public Property Image As ImageSource
    End Class

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = GetData().ToList()
        End Sub

        Private Shared Iterator Function GetData() As IEnumerable(Of TestData)
            Yield New TestData() With {.PlainText = "LMA AG", .MemoText = "Mercedes-Benz SLK " & Microsoft.VisualBasic.Constants.vbLf & "2004 " & Microsoft.VisualBasic.Constants.vbLf & "Silver", .BooleanMember = True, .Image = GetImage("/Images/1.png")}
            Yield New TestData() With {.PlainText = "Western Motors", .MemoText = "Rolls-Royce Corniche " & Microsoft.VisualBasic.Constants.vbLf & "1975 " & Microsoft.VisualBasic.Constants.vbLf & "Snowy white", .BooleanMember = False, .Image = GetImage("/Images/2.png")}
            Yield New TestData() With {.PlainText = "Sun car rent", .MemoText = "Ford Ranger FX-4 " & Microsoft.VisualBasic.Constants.vbLf & "1999 " & Microsoft.VisualBasic.Constants.vbLf & "Red rock", .BooleanMember = True, .Image = GetImage("/Images/3.png")}
        End Function

        Private Shared Function GetImage(ByVal path As String) As ImageSource
            Return New BitmapImage(New Uri(path, UriKind.Relative))
        End Function
    End Class
End Namespace
