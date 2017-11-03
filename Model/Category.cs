using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Category
    {
        

        public int CategoryID { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public string Description { get; set; }
    }

}
