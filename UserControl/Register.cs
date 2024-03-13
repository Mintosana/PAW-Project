using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.IO;

namespace Productie
{
    public partial class Register : UserControl
    {
        List<Persoana> ListaPersoane = new List<Persoana>();
        public Persoana p = new Persoana();
        public Register()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            string nume = tbNume.Text;
            string prenume = tbPrenume.Text;
            string telefon = tbTelefon.Text;
            string email = tbMail.Text;
            string educatie = cbEducatie.Text;
            bool engleza = checkEngleza.Checked;
            string parola = tbParola.Text;
            string confParola = tbCParola.Text;

            string username = tbNume.Text + "-" + tbPrenume.Text;

            if (tbNume.Text == "" || tbPrenume.Text == "" || tbTelefon.Text == "" || tbMail.Text == "" || cbEducatie.Text == "" || tbParola.Text == "" || tbCParola.Text == "")
            {
                MessageBox.Show("Unul sau mai multe câmpuri sunt goale!");

            }
            else
            {
                ListaPersoane.Add(new Persoana(nume,prenume,telefon,email,educatie,engleza,username,parola,confParola));
                foreach (var persoana in ListaPersoane)
                {
                    MessageBox.Show(persoana.ToString() + "\n");
                }
            }
            try
            {
                p.Parola = parola;
                p.ParolaConf = confParola;
                p.Engleza = engleza;
                p.Educatie = educatie;
                p.Email = email;
                p.Nume = nume;
                p.Prenume = prenume;
                p.Telefon = telefon;
                p.Username = username;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            TextWriter PersonWrite = new StreamWriter("LoginInfo.txt");
            foreach (Persoana p in ListaPersoane)
            {
                PersonWrite.WriteLine(p.Username);
                PersonWrite.WriteLine(p.Parola);
            }
            PersonWrite.Close();
            TextWriter tw = new StreamWriter("UserList.txt");
            foreach (var p in ListaPersoane)
            {
                tw.WriteLine(p);
            }
            tw.Close();
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            { 
                conexiune.Open();
                OleDbCommand persoana = new OleDbCommand();
                persoana.Connection = conexiune;
                persoana.CommandText = "SELECT MAX(ID) FROM Aplicanti";
                int id;
                if (persoana.ExecuteScalar() != DBNull.Value)
                {
                    id = Convert.ToInt32(persoana.ExecuteScalar());
                }
                else
                {
                    id = 0;
                }
                persoana.CommandText = "INSERT INTO Aplicanti VALUES(?,?,?,?,?,?,?,?,?)";
                persoana.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                persoana.Parameters.Add("nume", OleDbType.Char, 20).Value = tbNume.Text;
                persoana.Parameters.Add("prenume", OleDbType.Char, 20).Value = tbPrenume.Text;
                persoana.Parameters.Add("telefon", OleDbType.Integer).Value = Convert.ToInt32(tbTelefon.Text);
                persoana.Parameters.Add("email", OleDbType.Char, 50).Value = tbMail.Text;
                persoana.Parameters.Add("educatie", OleDbType.Char, 20).Value = cbEducatie.Text;
                persoana.Parameters.Add("engleza", OleDbType.Boolean).Value = checkEngleza.Checked;

                persoana.Parameters.Add("username", OleDbType.Char, 50).Value = tbNume.Text + "-" + tbPrenume.Text;
                persoana.Parameters.Add("parola", OleDbType.Char, 20).Value = tbParola.Text;
               
                persoana.ExecuteNonQuery();
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
               tbNume.Clear();
               tbPrenume.Clear();
               tbTelefon.Clear();
               tbMail.Clear();
               cbEducatie.Items.Clear();
               checkEngleza.Checked = false;
               tbParola.Clear();
               tbCParola.Clear();
            }
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (tbNume.Text == "")
            {
                eroare.SetError(tbNume, "Nume nu a fost introdus!");
                tbNume.Focus();
            }
            else if (!Regex.IsMatch(tbNume.Text, @"^[a-zA-Z]+$"))
            {
                eroare.SetError(tbNume, "Numele nu a fost introdus corect, nu ai voie cu cifre!");
                tbNume.Focus();
            }
            else
            {
                eroare.SetError(tbNume, "");
            }
        }
        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrenume.Text == "")
            {
                eroare.SetError(tbPrenume, "Prenumele nu a fost introdus!");
                tbPrenume.Focus();
            }
            else
            {
                eroare.SetError(tbPrenume, "");
            }

            if (!Regex.IsMatch(tbPrenume.Text, @"^[a-zA-Z]+$"))
            {
                eroare.SetError(tbPrenume, "Prenumele nu a fost introdus corect, nu ai voie cu cifre!");
                tbPrenume.Focus();
            }
            else
            {
                eroare.SetError(tbPrenume, "");
            }
        }
        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (tbTelefon.Text == "")
            {
                eroare.SetError(tbTelefon, "Nu ati adaugat numarul de telefon");
                tbTelefon.Focus();
            }
            else if (!Regex.IsMatch(tbTelefon.Text, @"^(\+4|)?(07[0-8]{1}[0-9]{1}|02[0-9]{2}|03[0-9]{2}){1}?(\s|\.|\-)?([0-9]{3}(\s|\.|\-|)){2}$"))
            {
                eroare.SetError(tbTelefon, "Numarul trebuie sa respecte formatul valid");
                tbTelefon.Focus();
            }
            else
            {
                eroare.SetError(tbTelefon, "");
            }
        }
        private void tbMail_Validating(object sender, CancelEventArgs e)
        {
            if (tbMail.Text == "")
            {
                eroare.SetError(tbMail, "Ati uitat sa introduceti mailul!");
                tbMail.Focus();
            }
            else if (!Regex.IsMatch(tbMail.Text, @"[a-zA-Z0-9_\.-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9\.]{2,5}$"))
            {
                eroare.SetError(tbMail, "Email-ul nu este introdus corect");
                tbMail.Focus();
            }
            else
            {
                eroare.SetError(tbMail, "");
            }
        }
        private void tbCParola_TextChanged(object sender, EventArgs e)
        {
            tbCParola.UseSystemPasswordChar = true;
        }

        private void tbParola_TextChanged(object sender, EventArgs e)
        {
            tbParola.UseSystemPasswordChar = true;
        }

        private void tbParola_Validating(object sender, CancelEventArgs e)
        {
            if (tbCParola.Text == "")
            {
                eroare.SetError(tbCParola, "Parola introdusa gresit");
                tbCParola.Focus();
            }
            else
            {
                eroare.SetError(tbCParola, "");
            }
        }

        private void tbCParola_Validating(object sender, CancelEventArgs e)
        {
            if (tbCParola.Text != tbParola.Text)
            {
                eroare.SetError(tbParola, "Parolele nu se potrivesc!");
                tbParola.Focus();
            }
            else if (tbParola.Text == "")
            {
                eroare.SetError(tbParola, "Trebuie sa confirmi parola");
            }
            else
            {
                eroare.SetError(tbParola, "");
            }
        }
    }
}