using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Threading;
using ConsoleApp3.Forms;
using System.Security.Cryptography;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static ProdContext prodContext = new ProdContext();
        
        static void Main(string[] args)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            
        }
        public static void displayWithLazyOrEagerLoading()
        {
            prodContext.Configuration.LazyLoadingEnabled = true;

            // here code
        }
        public static void displayWithNavigationProperties()
        {
            var categories =
                from c in prodContext.Categories
                select c;
            foreach (var c in categories)
            {
                Console.WriteLine("Category name is: " + c.Name);
                foreach (var p in c.Products)
                {
                    Console.WriteLine("Product name is: " + p.Name);
                }
            }
        }

        public static void displayWithJoins()
        {
            

            var productsWithCompleteCategories =
                from c in prodContext.Categories
                join p in prodContext.Products
                on c.CategoryID equals p.CategoryID
                select new { c.Description, c.Name, naame = p.Name };

            foreach (var p in productsWithCompleteCategories)
            {
                Console.WriteLine(p.Description + "::" + p.Name + "::" + p.naame);
            }
        }

        

    }
}


//string newCatName = Console.ReadLine();

//Category category = new Category() { Name = newCatName };

//CategoryForm categoryForm = new CategoryForm();

//ProdContext prodContext = new ProdContext();

//prodContext.Categories.Add(category);

//prodContext.SaveChanges();

//var categories = from db in prodContext.Categories
//                 orderby db.Name
//                 select db.Name;
//foreach(var c in categories)
//{
//    Console.WriteLine(c);
//}

//categoryForm.Activate();
//categoryForm.ShowDialog();

//Thread.Sleep(3000);
//categoryForm.Load();

//Thread.Sleep(2000);
//categoryForm.Hide();
//Console.ReadKey();