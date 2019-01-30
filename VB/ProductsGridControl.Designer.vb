Namespace InheritedUserControl
    Partial Public Class ProductsGridControl
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReorderLevel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.productsBindingSource
            ' 
            ' 
            ' 
            Me.gridControl1.EmbeddedNavigator.Name = ""
            Me.gridControl1.Size = New System.Drawing.Size(560, 319)
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID, Me.colProductName, Me.colSupplierID, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel, Me.colDiscontinued})
            Me.gridView1.GroupCount = 1
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { _
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCategoryID, DevExpress.Data.ColumnSortOrder.Ascending), _
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colProductName, DevExpress.Data.ColumnSortOrder.Ascending) _
            })
            ' 
            ' colProductID
            ' 
            Me.colProductID.Caption = "ProductID"
            Me.colProductID.FieldName = "ProductID"
            Me.colProductID.Name = "colProductID"
            Me.colProductID.OptionsColumn.ReadOnly = True
            Me.colProductID.Width = 115
            ' 
            ' colProductName
            ' 
            Me.colProductName.Caption = "ProductName"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            Me.colProductName.Width = 149
            ' 
            ' colSupplierID
            ' 
            Me.colSupplierID.Caption = "SupplierID"
            Me.colSupplierID.FieldName = "SupplierID"
            Me.colSupplierID.Name = "colSupplierID"
            ' 
            ' colCategoryID
            ' 
            Me.colCategoryID.Caption = "CategoryID"
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.Visible = True
            Me.colCategoryID.VisibleIndex = 2
            ' 
            ' colQuantityPerUnit
            ' 
            Me.colQuantityPerUnit.Caption = "QuantityPerUnit"
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            Me.colQuantityPerUnit.Visible = True
            Me.colQuantityPerUnit.VisibleIndex = 1
            Me.colQuantityPerUnit.Width = 202
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.Caption = "UnitPrice"
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 2
            Me.colUnitPrice.Width = 202
            ' 
            ' colUnitsInStock
            ' 
            Me.colUnitsInStock.Caption = "UnitsInStock"
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            ' 
            ' colUnitsOnOrder
            ' 
            Me.colUnitsOnOrder.Caption = "UnitsOnOrder"
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            ' 
            ' colReorderLevel
            ' 
            Me.colReorderLevel.Caption = "ReorderLevel"
            Me.colReorderLevel.FieldName = "ReorderLevel"
            Me.colReorderLevel.Name = "colReorderLevel"
            ' 
            ' colDiscontinued
            ' 
            Me.colDiscontinued.Caption = "Discontinued"
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            Me.colDiscontinued.Visible = True
            Me.colDiscontinued.VisibleIndex = 3
            Me.colDiscontinued.Width = 208
            ' 
            ' ProductsGridControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.Name = "ProductsGridControl"
            Me.Size = New System.Drawing.Size(560, 359)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private productsBindingSource As System.Windows.Forms.BindingSource
        Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colSupplierID As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn
        Private colReorderLevel As DevExpress.XtraGrid.Columns.GridColumn
        Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
