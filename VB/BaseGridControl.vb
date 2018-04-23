Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace InheritedUserControl
	Partial Public Class BaseGridControl
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		' base UserControl functionality
		Protected Overridable Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
			If gridView1.VisibleColumns.Count > 0 Then
				label1.Text = gridView1.GetRowCellDisplayText(e.FocusedRowHandle, gridView1.VisibleColumns(0))
			End If
		End Sub
	End Class
End Namespace