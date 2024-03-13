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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            register1.Visible = false;
            time2.Visible = true;
            login1.Visible = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           time2.Visible = false;
           register1.Visible = true;
           login1.Visible = false;
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           time2.Visible = true;
           register1.Visible = false;
           login1.Visible = false;
            label1.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           time2.Visible = false;
           register1.Visible = false;
           login1.Visible = true;
            label1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Feedback form5 = new Feedback();
            form5.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void register1_Load(object sender, EventArgs e)
        {

        }
    }
}
