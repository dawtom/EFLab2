using ConsoleApp3.Forms;
using ConsoleApp3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp3
{
    public partial class OrderForm : Form
    {
        ProdContext prodContext = new ProdContext();
        public OrderForm()
        {
            InitializeComponent();
            this.Load += OrderForm_Load;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            var reader = new System.IO.StreamReader("MyFilename.txt");
            var fileContents = reader.ReadToEnd();
            reader.Close();
            var name = fileContents.Substring(0, fileContents.Count() - 2);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ordersDataSet.Orders' . Możesz go przenieść lub usunąć.
            this.ordersTableAdapter.Fill(this.ordersDataSet.Orders);

            var allOrders = from order in prodContext.Orders
                            where order.CompanyName == name
                            select order;

            List<Order> orders = new List<Order>(); 
            foreach(var order in allOrders)
            {
                orders.Add(order);
            }
            dataGridView1.DataSource = orders;

        }

        //private void loadCatForm()
        //{
        //    List<Category> allCategories = new List<Category>();


        //    var allCats = from c in prodContext.Categories
        //                  select c;

        //    foreach (var cat in allCats)
        //    {
        //        Category tmpCategory = new Category()
        //        {
        //            CategoryID = cat.CategoryID,
        //            Name = cat.Name,
        //            Description = cat.Description
        //        };
        //        allCategories.Add(tmpCategory);
        //    }



        //    //dataGridView1.DataSource = allCategories;
        //    this.dataGridView1.DataSource = allCategories;
        //    //this.dataGridView1.Columns["CategoryID"].ReadOnly = true;
        //    //this.categoryBindingSource.DataSource = catSet;
        //}

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void placeAnOrderButton_Click(object sender, EventArgs e)
        {
            PlaceAnOrderForm placeAnOrderForm = new PlaceAnOrderForm();
            Hide();
            placeAnOrderForm.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            Hide();
            mainForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
