using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InheritedUserControl {
    public partial class BaseGridControl : UserControl {
        public BaseGridControl() {
            InitializeComponent();
        }

        // base UserControl functionality
        protected virtual void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            if(gridView1.VisibleColumns.Count > 0)
                label1.Text = gridView1.GetRowCellDisplayText(e.FocusedRowHandle, gridView1.VisibleColumns[0]);
        }
    }
}