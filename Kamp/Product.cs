using System;
using System.Collections.Generic;
using System.Text;

namespace KampOOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //fiyat
        public int UnitsInStocks { get; set; } //stoktaki sayısı

    }
}
