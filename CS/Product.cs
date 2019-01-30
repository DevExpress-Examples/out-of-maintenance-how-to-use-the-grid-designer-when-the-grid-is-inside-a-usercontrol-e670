using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace InheritedUserControl {
    class Product {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public int QuantityPerUnit { get; set; }
        public bool Discontinued { get; set; }
        public decimal UnitPrice { get; set; }
    }

    static class DataHelper {
        public static BindingList<Product> GetData(int count = 10) {
            BindingList<Product> list = new BindingList<Product>();
            for(int i = 0; i < count; i++) {
                list.Add(new Product() {ProductID = i, CategoryID =  i % 3, Discontinued = i % 2 == 0, ProductName = string.Format("Product {0}", i), UnitPrice = i * 20  + i});
            }
            return list;
        }
    }
}
