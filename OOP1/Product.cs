using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //birim fiyati
        public double UnitPrice { get; set; }   

        //stoktaki birim-stok  adedi
        public int UnitInStock { get; set; }
    }
}
