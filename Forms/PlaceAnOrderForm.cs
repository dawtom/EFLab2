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
    public partial class PlaceAnOrderForm : Form
    {
        ProdContext prodContext = new ProdContext();
        List<Product> allProds = new List<Product>();
        public PlaceAnOrderForm()
        {
            InitializeComponent();
            this.Load += PlaceAnOrderForm_Load;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = comboBox1.SelectedIndex;
            if (index >= 0)
            {
                var product = allProds[index];
                if (numericUpDown1.Value >= product.UnitsInStock)
                {
                    MessageBox.Show(
                        "Nie ma tylu sztuk w magazynie",
                        "Zamknij",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    label4.Text = allProds[index].UnitsInStock.ToString();
                    label6.Text = allProds[index].UnitPrice.ToString();
                    totalValueNumber.Text = (product.UnitPrice * numericUpDown1.Value).ToString();
                }
            }

        }

        private void PlaceAnOrderForm_Load(object sender, EventArgs e)
        {
            

            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ordersDataSet.Products' . Możesz go przenieść lub usunąć.
            this.productsTableAdapter.Fill(this.ordersDataSet.Products);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ordersDataSet.Customers' . Możesz go przenieść lub usunąć.
            this.customersTableAdapter.Fill(this.ordersDataSet.Customers);

            comboBox1.Text = "";

            List<string> allProdsString = new List<string>();

            ProdContext pc = new ProdContext();

            var allProducts = from c in pc.Products
                              select c;

            foreach (var prod in allProducts)
            {
                allProds.Add(prod);
                //allProdsString.Add(prod.Name);
            }


            //comboBox1.DataSource = allProdsString;
            //this.Controls.Add(comboBox1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reader = new System.IO.StreamReader("MyFilename.txt");
            var name = reader.ReadToEnd();
            reader.Close();

            int index = comboBox1.SelectedIndex;
            int productID = allProds[index].ProductID;
            string productName = allProds[index].Name;
            decimal quantity = numericUpDown1.Value;
            string country = countryTextBox.Text;
            string city = cityTextBox.Text;
            string address = addressTextBox.Text;
            string companyName = name;
            var product = allProds[index];

            bool isValid = true;

            if (String.IsNullOrEmpty(productName) || String.IsNullOrEmpty(country) || 
                String.IsNullOrEmpty(city) || String.IsNullOrEmpty(address) || quantity <= 0
                || String.IsNullOrEmpty(companyName) || numericUpDown1.Value >= product.UnitsInStock)
            {
                isValid = false;
            }


            if (isValid)
            {
                Order order = new Order()
                {
                    CompanyName = companyName.Substring(0,companyName.Count() - 2),
                    ShipCountry = country,
                    ShipCity = city,
                    ShipAddress = address,
                    OrderDate = DateTime.Now
                };

                prodContext.Orders.Add(order);
                prodContext.SaveChanges();

                int orderID = order.OrderID;

                OrderDetails orderDetails = new OrderDetails()
                {
                    OrderID = orderID,
                    ProductID = allProds[comboBox1.SelectedIndex].ProductID,
                    Quantity=(int)quantity
                };

                prodContext.OrderDetails.Add(orderDetails);
                prodContext.SaveChanges();

                OrderForm of = new OrderForm();
                Hide();
                of.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Źle wypełniony formularz",
                    "Zamknij", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            Hide();
            mainForm.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            var product = allProds[comboBox1.SelectedIndex];
            if (numericUpDown1.Value >= product.UnitsInStock)
            {
                MessageBox.Show(
                    "Nie ma tylu sztuk w magazynie",
                    "Zamknij",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                totalValueNumber.Text = (product.UnitPrice * numericUpDown1.Value).ToString();
            }
            
        }
    }
}
