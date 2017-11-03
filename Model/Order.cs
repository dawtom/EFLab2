using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Model
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [ForeignKey("CompanyName")]
        public Customer Customer { get; set; }
        public string CompanyName { get; set; }

        public DateTime OrderDate { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
        public string ShipAddress { get; set; }
    }
}
