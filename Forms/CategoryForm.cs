using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp3
{

    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            this.Load += CategoryForm_Load;

        }
        ProdContext prodContext = new ProdContext();

        private void loadCatForm()
        {
            List<Category> allCategories = new List<Category>();

            prodContext.Configuration.LazyLoadingEnabled = true;
            var allCats = from c in prodContext.Categories
                          select c;

            foreach (var cat in allCats)
            {
                Category tmpCategory = new Category()
                {
                    CategoryID = cat.CategoryID,
                    Name = cat.Name,
                    Description = cat.Description
                };
                allCategories.Add(tmpCategory);
            }



            //dataGridView1.DataSource = allCategories;
            this.dataGridView1.DataSource = allCategories;
            //this.dataGridView1.Columns["CategoryID"].ReadOnly = true;
            //this.categoryBindingSource.DataSource = catSet;
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'consoleApp3DataSet11.Products' . Możesz go przenieść lub usunąć.
            this.productsTableAdapter.Fill(this.consoleApp3DataSet11.Products);

            this.loadCatForm();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.Name = "ddd";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new Exception() ;
        }
        //category name below
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void descriptionTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string catName = NameTB.Text;
            string catDescription = descriptionTB.Text;
            Category category = new Category()
            {
                Name = catName,
                Description = catDescription
            };
            prodContext.Categories.Add(category);
            prodContext.SaveChanges();
            this.loadCatForm();

        }
        //save button
        private void button1_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                var fromDb = prodContext.Categories.FirstOrDefault
                    (m => m.CategoryID == id);
                if (dataGridView1.Rows[i].Cells[1].Value == null)
                {
                    //fromDb.Name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                } else
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() != fromDb.Name)
                    {
                        fromDb.Name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    }
                }
                if (dataGridView1.Rows[i].Cells[2].Value == null)
                {
                    //fromDb.Name = dataGridView1.Rows[i].Cells[2].Value.ToString();
                }
                else
                {
                    if (dataGridView1.Rows[i].Cells[2].Value.ToString() != fromDb.Name)
                    {
                        fromDb.Description = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    }
                }
                
            }
            //var data = prodContext.Categories.SingleOrDefault(m => m.CategoryID == 5);
            //if (data != null)
            //{
            //    data.Description = "trololololololololol";
            //}
            prodContext.SaveChanges();
            this.loadCatForm();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.loadProdsByCategory(sender, e);
        }
        private void loadProdsByCategory(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            var filteredProducts = this.consoleApp3DataSet11.Products.Where(m => m.CategoryID == id);

            var filteredProductsl2e = from x in this.consoleApp3DataSet11.Products
                                      where x.CategoryID == id
                                   select x;

            List < Product > displayProds = new List<Product>();
            foreach (var fp in filteredProductsl2e)
            {
                var tmpProduct = new Product
                {
                    CategoryID = fp.CategoryID,
                    Name = fp.Name,
                    ProductID = fp.ProductID,
                    UnitPrice = fp.UnitPrice,
                    UnitsInStock = fp.UnitsInStock
                };
                displayProds.Add(tmpProduct);
            }

            this.dataGridView2.DataSource = displayProds;
        }
    }
}
