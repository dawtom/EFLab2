using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp3
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryID { get; set; }
        [Column(TypeName = "Money")]
        public Decimal UnitPrice { get; set; }

    }
}
