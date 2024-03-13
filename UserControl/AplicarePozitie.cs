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
    public partial class AplicarePozitie : UserControl
    {
        public AplicarePozitie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb"); try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        comanda.CommandText = "SELECT MAX(ID) FROM Aplicatii";
                        int id;
                        if (comanda.ExecuteScalar() != DBNull.Value)
                        {
                            id = Convert.ToInt32(comanda.ExecuteScalar());
                        }
                        else
                        {
                            id = 0;
                        }
                        int id_job;
                        comanda.CommandText = "SELECT ID FROM Job WHERE nume='" + itm.SubItems[0].Text + "'";
                        id_job = Convert.ToInt32(comanda.ExecuteScalar());
                        comanda.CommandText = "INSERT INTO Aplicatii VALUES(?,?,?,?,?)";
                        comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                        comanda.Parameters.Add("idAngajat", OleDbType.Integer).Value = Aplicant.id;
                        comanda.Parameters.Add("idJob", OleDbType.Integer).Value = id_job;
                        comanda.Parameters.Add("Admis", OleDbType.Boolean).Value = false;
                        comanda.Parameters.Add("Pending", OleDbType.Boolean).Value = true;
                        comanda.ExecuteNonQuery();
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
                MessageBox.Show("Comanda adaugata");
            }
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb"); try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    foreach (ListViewItem itm in listView1.Items)
                        if (itm.Checked)
                        {
                            comanda.CommandText = "SELECT MAX(ID) FROM Aplicatii";
                            int id;
                            if (comanda.ExecuteScalar() != DBNull.Value)
                            {
                                id = Convert.ToInt32(comanda.ExecuteScalar());
                            }
                            else
                            {
                                id = 0;
                            }
                            int id_job;
                            comanda.CommandText = "SELECT ID FROM Job WHERE nume='" + itm.SubItems[0] + "'";
                            id_job = Convert.ToInt32(comanda.ExecuteScalar());
                            comanda.CommandText = "INSERT INTO Aplicatii VALUES(?,?,?,?)";
                            comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                            comanda.Parameters.Add("idAngajat", OleDbType.Integer).Value = Aplicant.id;
                            comanda.Parameters.Add("idJob", OleDbType.Integer).Value = id_job;
                            comanda.Parameters.Add("Admis", OleDbType.Boolean).Value = false;
                            comanda.Parameters.Add("Pending", OleDbType.Boolean).Value = true;
                            comanda.ExecuteNonQuery();
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
                    MessageBox.Show("Comanda adaugata");
                }
            }
        }

        private void Comanda_Load(object sender, EventArgs e)
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
