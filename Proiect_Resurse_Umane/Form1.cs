namespace Proiect_Resurse_Umane
{
    public partial class Form1 : Form
    {
        List<Persoana> persoane = new List<Persoana>();
        List<Curs> cursuri = new List<Curs>();
        List<Job> joburi = new List<Job>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugarePersoana_Click(object sender, EventArgs e)
        {
            string numePersoana = tbNumePersoana.Text;
            int varsta = Convert.ToInt32(tbVarstaPersoana.Text);
            string facultate = tbFacultatePersoana.Text;

            Persoana p = new Persoana(numePersoana, varsta, facultate);
            persoane.Add(p);
            //MessageBox.Show("A fost introdusa persoana " + numePersoana);
        }

        private void btnAdaugareCurs_Click(object sender, EventArgs e)
        {
            string numeCurs = tbNumeCurs.Text;
            var tip = (Curs.tipCurs)System.Enum.Parse(typeof(Curs.tipCurs),cbTipCurs.Text);

            Curs c = new Curs(numeCurs,tip);
            cursuri.Add(c);

            //MessageBox.Show("A fost introdus Cursul " + numeCurs + ' ' + tip);
        }

        private void btnAdaugareJob_Click(object sender, EventArgs e)
        {
            string numeJob = tbNumeJob.Text;
            string departament = tbDepartamentJob.Text;
            float salariu = float.Parse(tbSalariuJob.Text);

            Job j = new Job(numeJob, departament, salariu);
            joburi.Add(j);

            //MessageBox.Show("A fost introdusa Job-ul" + numeJob + ' ' + departament + ' ' + salariu);
        }

        private void btnAfisarePersoane_Click(object sender, EventArgs e)
        {
            DataGrid.DataSource = null;
            DataGrid.DataSource = persoane;
            DataGrid.Refresh();

        }

        private void btnAfisareCursuri_Click(object sender, EventArgs e)
        {
            DataGrid.DataSource = null;
            DataGrid.DataSource = cursuri;
            DataGrid.Refresh();
        }

        private void btnAfisareJoburi_Click(object sender, EventArgs e)
        {
            DataGrid.DataSource = null;
            DataGrid.DataSource = joburi;
            DataGrid.Refresh();
        }
    }
}