using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Productie
{
    public partial class IntroduPozitie : Form
    {
        public IntroduPozitie()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand job = new OleDbCommand();
                job.Connection = conexiune;
                job.CommandText = "SELECT MAX(ID) FROM Job";
                int id;
                if (job.ExecuteScalar() != DBNull.Value)
                {
                    id = Convert.ToInt32(job.ExecuteScalar());
                }
                else
                {
                    id = 1;
                }
                job.CommandText = "INSERT INTO Job VALUES(?,?,?,?,?,?,?,?)";
                job.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                job.Parameters.Add("nume", OleDbType.Char, 20).Value = tbNume.Text;
                job.Parameters.Add("departament", OleDbType.Char, 20).Value = tbDepartament.Text;
                job.Parameters.Add("locatie", OleDbType.Char, 20).Value = tbLocatie.Text;
                job.Parameters.Add("nivel_experienta", OleDbType.Char, 20).Value = tbExperienta.Text;
                job.Parameters.Add("tip", OleDbType.Char, 20).Value = tbTip.Text;
                job.Parameters.Add("salariu", OleDbType.Integer).Value = tbSalariu.Text;
                job.Parameters.Add("engleza", OleDbType.Boolean).Value = checkEngleza.Checked;
                job.ExecuteNonQuery();
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
                tbNume.Clear();
                tbDepartament.Clear();
                tbLocatie.Clear();
                tbExperienta.Clear();
                tbTip.Clear();
                tbSalariu.Clear();
                checkEngleza.Checked= false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            {
                listView1.Items.Clear();
                conexiune.Open();
                OleDbCommand joburi = new OleDbCommand();
                joburi.Connection = conexiune;
                joburi.CommandText = "SELECT * FROM Job";
                OleDbDataReader reader = joburi.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["nume"].ToString());
                    itm.SubItems.Add(reader["departament"].ToString());
                    itm.SubItems.Add(reader["locatie"].ToString());
                    itm.SubItems.Add(reader["nivel_experienta"].ToString());
                    itm.SubItems.Add(reader["tip"].ToString());
                    itm.SubItems.Add(reader["salariu"].ToString());
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

        private void button3_Click(object sender, EventArgs e)
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
                        string denumire = itm.SubItems[0].Text;
                        job.CommandText = "Delete from Job where nume='" + denumire + "'";
                        job.ExecuteNonQuery();
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

        private void fisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"Pozitii.xml");
            XmlNodeList xnList = xmlDocument.SelectNodes("/catalog");
            foreach(XmlNode xn in xnList)
            {
                XmlNodeList xmlNodeList = xn.ChildNodes;
                foreach(XmlNode node in xmlNodeList)
                {
                    string nume = node["nume"].InnerText;
                    OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
                    try
                    {
                        conexiune.Open();
                        OleDbCommand job = new OleDbCommand();
                        job.Connection = conexiune;
                        job.CommandText = "SELECT MAX(ID) FROM Job";
                        int id;
                        if (job.ExecuteScalar() != DBNull.Value)
                        {
                            id = Convert.ToInt32(job.ExecuteScalar());
                        }
                        else
                        {
                            id = 1;
                        }
                        job.CommandText = "INSERT INTO Job VALUES(?,?,?,?,?,?,?,?)";
                        job.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                        job.Parameters.Add("nume", OleDbType.Char, 20).Value = node["nume"].InnerText;
                        job.Parameters.Add("departament", OleDbType.Char, 20).Value = node["departament"].InnerText;
                        job.Parameters.Add("locatie", OleDbType.Char, 20).Value = node["locatie"].InnerText;
                        job.Parameters.Add("nivel_experienta", OleDbType.Char, 20).Value = node["nivel_experienta"].InnerText;
                        job.Parameters.Add("tip", OleDbType.Char, 20).Value = node["tip"].InnerText;
                        job.Parameters.Add("salariu", OleDbType.Integer).Value = node["salariu"].InnerText;
                        job.Parameters.Add("engleza", OleDbType.Boolean).Value = node["engleza"].InnerText;
                        job.ExecuteNonQuery();
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
                        MessageBox.Show("Fisierul XML a fost citit iar baza de date a fost actualizata!");
                        conexiune.Close();
                    }
                }
            }
        }
    }
}
