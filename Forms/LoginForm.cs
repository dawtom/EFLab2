using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using ConsoleApp3.Model;

namespace ConsoleApp3.Forms
{
    public partial class LoginForm : Form
    {
        ProdContext prodContext = new ProdContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(loginTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text))
            {
                isValid = false;
            }

            if (isValid)
            {
                string login = loginTextBox.Text;
                string password = passwordTextBox.Text;

                var suchUserExistsAndIsSuccesfullyAuthorized = false;


                var users = (from u in prodContext.Customers
                             select u).ToList();

                var suchUserExists = users.Where(
                    m => m.CompanyName == login).Count() > 0 ? true : false;

                if (suchUserExists)
                {
                    var user = users.Where(m => m.CompanyName == login).Single();
                    var passFromDb = user.Password;
                    if (passFromDb == password)
                    {
                        suchUserExistsAndIsSuccesfullyAuthorized = true;
                    }
                }

                if (suchUserExistsAndIsSuccesfullyAuthorized)
                {
                    var writer = new System.IO.StreamWriter("MyFilename.txt");
                    writer.WriteLine(login);
                    writer.Close();
                    MainForm mainForm = new MainForm();
                    Hide();
                    mainForm.ShowDialog();


                }
                else
                {
                    MessageBox.Show(
                            "Błędna nazwa użytkownika lub hasło",
                            "Zamknij",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                        "Podaj login i hasło",
                        "Zamknij",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(loginTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text))
            {
                isValid = false;
            }

            if (isValid)
            {
                string login = loginTextBox.Text;
                string password = passwordTextBox.Text;

                var users = from u in prodContext.Customers
                            select u;

                var suchUserExists = users.Where(m => m.CompanyName == login).Count() > 0 ? true : false;

                if (!suchUserExists)
                {
                    Customer customer = new Customer()
                    {
                        CompanyName = login,
                        Password = password,
                        Description = "defaultDescription"
                    };
                    prodContext.Customers.Add(customer);
                    prodContext.SaveChanges();
                    var writer = new System.IO.StreamWriter("MyFilename.txt");
                    writer.WriteLine(login);
                    writer.Close();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();

                }
                else
                {
                    MessageBox.Show(
                            "Użytkownik podanej nazwie istnieje",
                            "Zamknij",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                        "Podaj login i hasło",
                        "Zamknij",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

            
        }
    }
}
