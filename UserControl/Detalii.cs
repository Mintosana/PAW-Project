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
    public partial class Detalii : UserControl
    {
        public Detalii()
        {
            InitializeComponent();
        }

        private void Detalii_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                int nrAplicatii = 0, nrAdmis = 0, nrRespins = 0;
                comanda.CommandText = "Select count(ID) from Aplicatii where idAngajat=" + Aplicant.id + " AND Admis = false AND Pending = false";
                nrRespins = Convert.ToInt32(comanda.ExecuteScalar());
                comanda.CommandText = "Select count(ID) from Aplicatii where idAngajat=" + Aplicant.id + " AND Admis = true";
                nrAdmis = Convert.ToInt32(comanda.ExecuteScalar());
                comanda.CommandText = "Select count(ID) from Aplicatii where idAngajat=" + Aplicant.id + "";
                nrAplicatii = Convert.ToInt32(comanda.ExecuteScalar());
                ListViewItem itm1 = new ListViewItem(nrAplicatii.ToString());
                itm1.SubItems.Add(nrRespins.ToString());
                itm1.SubItems.Add(nrAdmis.ToString());
                listView2.Items.Add(itm1);
                comanda.CommandText = "SELECT nume,email,telefon,educatie FROM Aplicanti WHERE ID =" + Aplicant.id + "";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["nume"].ToString());
                    itm.SubItems.Add(reader["email"].ToString());
                    itm.SubItems.Add(reader["telefon"].ToString());
                    itm.SubItems.Add(reader["educatie"].ToString());
                    listView1.Items.Add(itm);
                }

               
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
}