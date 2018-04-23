Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace InheritedUserControl
	Partial Public Class ProductsGridControl
		Inherits InheritedUserControl.BaseGridControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ProductsGridControl_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			If (Not DesignMode) Then
				productsTableAdapter.Fill(northwindDataSet.Products)
			End If
			gridView1.ExpandAllGroups()
		End Sub
	End Class
End Namespace

