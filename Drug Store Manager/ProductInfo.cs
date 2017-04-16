using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drug_Store_Manager {
    public class ProductInfo {
        public int Id, Quantity, Price;
        public string Name;
        public ProductInfo(int id, string name, int quantity, int price) {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
