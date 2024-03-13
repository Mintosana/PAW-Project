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
    public partial class GestionarePozitii : UserControl
    {
        public GestionarePozitii()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        int id= Convert.ToInt32(itm.SubItems[7].Text);
                        comanda.CommandText = "Delete from Aplicatii where ID="+id+"";
                        comanda.ExecuteNonQuery();
                        MessageBox.Show("Stergere realizata cu succes!");
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

        private void cbFiltru_SelectedValueChanged(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            {
               
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                int id = Aplicant.id;
                listView1.Items.Clear();
                if (cbFiltru.SelectedIndex == 0)
                {  
                    comanda.CommandText = "SELECT * FROM Job INNER JOIN Aplicatii AS A ON A.idJob = Job.ID WHERE A.idAngajat =" + Aplicant.id + " AND A.Pending = true";
                }
                else if (cbFiltru.SelectedIndex == 1)
                {
                    comanda.CommandText = "SELECT * FROM Job INNER JOIN Aplicatii AS A ON A.idJob = Job.ID WHERE A.idAngajat =" + Aplicant.id + " AND A.Admis = true";
                }
                else
                {
                    comanda.CommandText = "SELECT * FROM Job INNER JOIN Aplicatii AS A ON A.idJob = Job.ID WHERE A.idAngajat =" + Aplicant.id + " AND A.Pending = false AND A.Admis = false";
                }
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["nume"].ToString());
                    itm.SubItems.Add(reader["departament"].ToString());
                    itm.SubItems.Add(reader["locatie"].ToString());
                    itm.SubItems.Add(reader["nivel_experienta"].ToString());
                    itm.SubItems.Add(reader["tip"].ToString());
                    itm.SubItems.Add(reader["salariu"].ToString());
                    itm.SubItems.Add(reader["engleza"].ToString());
                    itm.SubItems.Add(reader["A.ID"].ToString());
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

        private void cbFiltru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GestionarePozitii_Load(object sender, EventArgs e)
        {

        }
    }
}
