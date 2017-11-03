using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp3.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceAnOrderForm placeAnOrderForm = new PlaceAnOrderForm();
            Hide();
            placeAnOrderForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            Hide();
            orderForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var reader = new System.IO.StreamReader("MyFilename.txt");
            var fileContents = reader.ReadToEnd();
            reader.Close();

            loggedAsText.Text = fileContents;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }
    }
}
