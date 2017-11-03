using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Customer
    {
        [Key]
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }

    }
}
