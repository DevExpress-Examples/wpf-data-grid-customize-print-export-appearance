Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace PrintCustomGroupRows

    Public Enum Category
        Deferred
        Normal
        Urgent
    End Enum

    Public Class Item

        Public Property ID As Integer

        Public Property Name As String

        Public Property Value As Double

        Public Property Category As Category
    End Class

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = New ObservableCollection(Of Item)(GetData())
        End Sub

        Private Shared Iterator Function GetData() As IEnumerable(Of Item)
            Dim r = New Random()
            For i As Integer = 0 To 50 - 1
                Yield New Item() With {.ID = i, .Name = "Item " & i, .Value = r.Next(0, 50), .Category = CType(r.Next(0, 3), Category)}
            Next
        End Function
    End Class
End Namespace
