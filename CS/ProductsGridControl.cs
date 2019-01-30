using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InheritedUserControl {
    public partial class ProductsGridControl : InheritedUserControl.BaseGridControl {
        public ProductsGridControl() {
            InitializeComponent();
        }

        private void ProductsGridControl_Load(object sender, EventArgs e) {
            if(!DesignMode)
                productsBindingSource.DataSource = DataHelper.GetData();
            gridView1.ExpandAllGroups();
        }
    }
}

