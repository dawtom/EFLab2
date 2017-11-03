using ConsoleApp3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class OrderDetails
    {
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        [Key]
        [Column(Order = 1)]
        public int ProductID { get; set; }

        [ForeignKey("OrderID")]
        public Order Order { get; set; }
        [Key]
        [Column(Order = 2)]
        public int OrderID { get; set; }

        public int Quantity { get; set; }
    }
}
