Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace InheritedUserControl
    Friend Class Product
        Public Property ProductID() As Integer
        Public Property CategoryID() As Integer
        Public Property ProductName() As String
        Public Property QuantityPerUnit() As Integer
        Public Property Discontinued() As Boolean
        Public Property UnitPrice() As Decimal
    End Class

    Friend NotInheritable Class DataHelper

        Private Sub New()
        End Sub

        Public Shared Function GetData(Optional ByVal count As Integer = 10) As BindingList(Of Product)
            Dim list As New BindingList(Of Product)()
            For i As Integer = 0 To count - 1
                list.Add(New Product() With { _
                    .ProductID = i, _
                    .CategoryID = i Mod 3, _
                    .Discontinued = i Mod 2 = 0, _
                    .ProductName = String.Format("Product {0}", i), _
                    .UnitPrice = i * 20 + i _
                })
            Next i
            Return list
        End Function
    End Class
End Namespace
