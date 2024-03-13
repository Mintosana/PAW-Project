using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Productie
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tbUser.Text == "cristian" && tbPass.Text == "rece")
            {
                MessageBox.Show("Welcome, " + tbUser.Text + "!");
                Admin form3 = new Admin();
                form3.Show();
            }
            else
            {
                OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT parola FROM Aplicanti where username ='" + tbUser.Text + "'";
                    string pass = Convert.ToString(comanda.ExecuteScalar());
                    if (pass == tbPass.Text && tbUser.Text != "" && tbPass.Text != "")
                    {
                        MessageBox.Show("Welcome, " + tbUser.Text + "!");
                        comanda.CommandText = "SELECT ID FROM Aplicanti where username ='" + tbUser.Text + "'";
                        int id = Convert.ToInt32(comanda.ExecuteScalar());
                        Aplicant form2 = new Aplicant(id);
                        form2.ShowDialog();
                    }
                    else if ((tbUser.Text == "" && tbPass.Text == ""))
                    {
                        MessageBox.Show("Input your username and password!");
                    }
                    else { MessageBox.Show("Invalid user or password! Try Again!"); }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                }
            }
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = true;
        }
    }
}
