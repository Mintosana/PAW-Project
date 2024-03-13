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

    public partial class Feedback : Form
    {
        string[] intrebari =
{
            "Am probleme cu inregistrarea!",
            "Mi-am uitat parola",
            "Imi arata ca am introdus datele gresit ",
            "Pot face un cont fara adresa de mail?"

        };
        public Feedback()
        {
            InitializeComponent();
            listBox1.AllowDrop = true;
            listBox2.AllowDrop = true;
            for (int i = 0; i < intrebari.Length; i++)
            {
                listBox1.Items.Add(intrebari[i] + "\n");
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count > 0)
                try { listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy | DragDropEffects.Move); }
                catch (Exception ex)
                {
                    MessageBox.Show("No string selected!");
                }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.Text));
            listBox1.Items.Remove(e.Data.GetData(DataFormats.Text));
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand plangere = new OleDbCommand();
                plangere.Connection = conexiune;
                plangere.CommandText = "SELECT MAX(Id_Plangere) FROM Plangeri";
                int id_max = Convert.ToInt32(plangere.ExecuteScalar());
                plangere.CommandText = "INSERT INTO Plangeri VALUES(?,?,?)";
                plangere.Parameters.Add("Id_Plangere", OleDbType.Integer).Value = id_max + 1;
                plangere.Parameters.Add("Destinatar", OleDbType.Char,20).Value = cbDestinatar.Text;
                plangere.Parameters.Add("Problema", OleDbType.Char,50).Value = listBox2.Text;
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
                MessageBox.Show("Mesaj primit cu succes!");
                ((Form)this.TopLevelControl).Close();
            }
        }

            private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (cbDestinatar.Text != "Suport Tehnic" && cbDestinatar.Text != "Administratie" && cbDestinatar.Text != "Relatii cu Clientii")
            {
                errorProvider1.SetError(cbDestinatar, "Selectati una din cele trei variante");
                cbDestinatar.Focus();
            }
            else if (cbDestinatar.Text == "")
            {
                errorProvider1.SetError(cbDestinatar, "Trebuie selectata adresa");
            }
        }



        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
