' Developer Express Code Central Example:
' How to use the PrintCellStyle property to customize cell's printing appearance
' 
' This example shows how to create custom PrintCellStyle for grid columns to bring
' a custom printing appearance for PopupImageEdit, CheckBoxEdit and MemoEdit.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3227

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Media

Namespace GridExample
    Public Class TestData
        Public Property PlainText() As String
        Public Property MemoText() As String
        Public Property BooleanMember() As Boolean
        Public Property Image() As ImageSource
    End Class
End Namespace
