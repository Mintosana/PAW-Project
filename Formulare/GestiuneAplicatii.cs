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

namespace Productie.Formulare
{
    public partial class GestiuneAplicatii : Form
    {
        public GestiuneAplicatii()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            

            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand job = new OleDbCommand();

                job.Connection = conexiune;
                job.CommandText = "SELECT * FROM Job";
                OleDbDataReader reader = job.ExecuteReader();

                while (reader.Read())
                {
                    cbFiltru.Items.Add(reader["nume"]);
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
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand job = new OleDbCommand();

                job.Connection = conexiune;
                job.CommandText = "SELECT * FROM (Aplicatii as A INNER JOIN Aplicanti as AP ON AP.ID = A.idAngajat) INNER JOIN Job as J ON J.ID = A.idJob WHERE J.nume = '" + cbFiltru.SelectedItem.ToString() + "' AND Pending = true";
                OleDbDataReader reader = job.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["AP.nume"].ToString());
                    itm.SubItems.Add(reader["prenume"].ToString());
                    itm.SubItems.Add(reader["telefon"].ToString());
                    itm.SubItems.Add(reader["email"].ToString());
                    itm.SubItems.Add(reader["educatie"].ToString());
                    itm.SubItems.Add(reader["AP.engleza"].ToString());
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

        private void btnAdmis_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand job = new OleDbCommand();
                job.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        //int id = Convert.ToInt32(itm.SubItems[6].Text);
                        //job.CommandText = "Update Aplicatii SET Admis = " + true +" AND Pending = " + false +" WHERE ID =" + id + "";
                        //job.ExecuteNonQuery();
                        //MessageBox.Show("Candidat Admis cu Succes");

                        int id = Convert.ToInt32(itm.SubItems[6].Text);
                        job.CommandText = "Select idAngajat from Aplicatii where ID =" + id + "";
                        int idAngajat = Convert.ToInt32(job.ExecuteScalar());
                        job.CommandText = "Select idJob from Aplicatii where ID =" + id + "";
                        int idJob = Convert.ToInt32(job.ExecuteScalar());
                        job.CommandText = "Delete from Aplicatii where ID=" + id + "";
                        job.ExecuteNonQuery();
                        job.CommandText = "INSERT INTO Aplicatii VALUES(?,?,?,?,?)";
                        job.Parameters.Add("ID", OleDbType.Numeric).Value = id;
                        job.Parameters.Add("idAngajat", OleDbType.Numeric).Value = idAngajat;
                        job.Parameters.Add("idJob", OleDbType.Numeric).Value = idJob;
                        job.Parameters.Add("Admis", OleDbType.Numeric).Value = true;
                        job.Parameters.Add("Pending", OleDbType.Boolean).Value = false;
                        job.ExecuteNonQuery();
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
                MessageBox.Show("Candidat Acceptat cu Succes");
            }
        }

        private void btnRespins_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand job = new OleDbCommand();
                job.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        //int id = Convert.ToInt32(itm.SubItems[6].Text);
                        //job.CommandText = "Update Aplicatii SET Admis = " + false +" AND Pending = " + false +" WHERE ID =" + id + "";
                        //job.ExecuteNonQuery();
                        //MessageBox.Show("Candidat Respins cu Succes");

                        int id = Convert.ToInt32(itm.SubItems[6].Text);
                        job.CommandText = "Select idAngajat from Aplicatii where ID =" + id + "";
                        int idAngajat = Convert.ToInt32(job.ExecuteScalar());
                        job.CommandText = "Select idJob from Aplicatii where ID =" + id + "";
                        int idJob = Convert.ToInt32(job.ExecuteScalar());
                        job.CommandText = "Delete from Aplicatii where ID=" + id + "";
                        job.ExecuteNonQuery();
                        job.CommandText = "INSERT INTO Aplicatii VALUES(?,?,?,?,?)";
                        job.Parameters.Add("ID", OleDbType.Numeric).Value = id;
                        job.Parameters.Add("idAngajat", OleDbType.Numeric).Value = idAngajat;
                        job.Parameters.Add("idJob", OleDbType.Numeric).Value = idJob;
                        job.Parameters.Add("Admis", OleDbType.Numeric).Value = false;
                        job.Parameters.Add("Pending", OleDbType.Boolean).Value = false;
                        job.ExecuteNonQuery();
                        
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
                MessageBox.Show("Candidat Respins cu Succes");
            }
        }
    }
}
