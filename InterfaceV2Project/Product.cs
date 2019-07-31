using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceV2Project {
    public class Product : ICalcSales {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Units { get; set; }

        public Product(int id, string name, decimal price, int units) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Units = units;
        }

        public decimal CalcSales() {
            throw new NotImplementedException();
        }
    }
}
