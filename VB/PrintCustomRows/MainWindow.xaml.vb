Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Media
Imports System.Windows.Media.Imaging

Namespace PrintCustomRows

    Public Class TestData

        Public Property PlainText As String

        Public Property MemoText As String

        Public Property BooleanMember As Boolean

        Public Property Image As ImageSource

        Public Property Price As Double
    End Class

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = New ObservableCollection(Of TestData)(GetData())
        End Sub

        Private Shared Iterator Function GetData() As IEnumerable(Of TestData)
            Yield New TestData() With {.PlainText = "LMA AG", .MemoText = "Mercedes-Benz SLK " & Microsoft.VisualBasic.Constants.vbLf & "2004 " & Microsoft.VisualBasic.Constants.vbLf & "Silver", .BooleanMember = True, .Image = GetImage("1.jpg"), .Price = 25}
            Yield New TestData() With {.PlainText = "Western Motors", .MemoText = "Rolls-Royce Corniche " & Microsoft.VisualBasic.Constants.vbLf & "1975 " & Microsoft.VisualBasic.Constants.vbLf & "Snowy white", .BooleanMember = False, .Image = GetImage("2.jpg"), .Price = 15}
            Yield New TestData() With {.PlainText = "Sun car rent", .MemoText = "Ford Ranger FX-4 " & Microsoft.VisualBasic.Constants.vbLf & "1999 " & Microsoft.VisualBasic.Constants.vbLf & "Red rock", .BooleanMember = True, .Image = GetImage("3.jpg"), .Price = 20}
        End Function

        Private Shared Function GetImage(ByVal path As String) As ImageSource
            Return New BitmapImage(New Uri($"pack://application:,,,/Images/{path}"))
        End Function
    End Class
End Namespace
