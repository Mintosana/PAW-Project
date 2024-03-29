﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;
using Productie.Formulare;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms.DataVisualization.Charting;

namespace Productie
{
    public partial class Admin : Form
    {
        string[] vectNume = new string[20];
        string[] vectPrenume = new string[20];
        string[] vectTelefon = new string[20];

        Graphics g;
        
        int nrElem = 0;
        bool vb = false;
        const int marg = 10;
        Color culoare = Color.DarkCyan;
        Color culoareText = Color.Snow;
        Font font = new Font(FontFamily.GenericSerif, 12, FontStyle.Bold);
        public Admin()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            //if (vb == true)
            //{
            //    Graphics gr = e.Graphics;
            //    Rectangle rec = new Rectangle(e.PageBounds.X + marg, e.PageBounds.Y + 4 * marg,
            //        e.PageBounds.Width - 2 * marg, e.PageBounds.Height - 5 * marg);
            //    Pen pen = new Pen(Color.Aqua, 3);
            //    gr.DrawRectangle(pen, rec);

            //    double latime = rec.Width / nrElem / 3;
            //    double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
            //    double vMax = vect.Max();

            //    Brush br = new SolidBrush(culoare);

            //    Rectangle[] recs = new Rectangle[nrElem];
            //    for (int i = 0; i < nrElem; i++)
            //    {
            //        recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
            //            (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
            //            (int)latime,
            //            (int)(vect[i] / vMax * rec.Height));
            //        gr.FillEllipse(br, recs[i]);
            //        gr.DrawString(vect[i].ToString(), font, br, new Point(recs[i].Location.X,
            //            recs[i].Location.Y - font.Height));
            //    }
            //    for (int i = 0; i < nrElem - 1; i++)
            //        gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)recs[i].Location.Y),
            //            new Point((int)(recs[i + 1].Location.X + latime / 2), (int)recs[i + 1].Location.Y));
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vb)
            {
                chart1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TheLegend27\\Desktop\\1059_Rece_Cristian\\Proiect Resurse Umane\\GestiuneHR.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM Aplicanti";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    vectNume[nrElem] = reader["nume"].ToString();
                    vectPrenume[nrElem] = reader["prenume"].ToString();
                    vectTelefon[nrElem] = reader["telefon"].ToString();

                    nrElem++;
                    vb = true;
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
                MessageBox.Show("Date incarcate!");
                conexiune.Close();
            }
        }
        private void panel1_Paint(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //if (vb == true)
            //{
            //    Graphics gr = e.Graphics;
            //    Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + 4 * marg,
            //        panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 5 * marg);
            //    Pen pen = new Pen(Color.Aqua, 3);
            //    gr.DrawRectangle(pen, rec);

            //    double latime = rec.Width / nrElem / 3;
            //    double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
            //    double vMax = vect.Max();

            //    Brush br = new SolidBrush(culoare);

            //    Rectangle[] recs = new Rectangle[nrElem];
            //    for (int i = 0; i < nrElem; i++)
            //    {
            //        recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
            //            (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
            //            (int)latime,
            //            (int)(vect[i] / vMax * rec.Height));
            //        gr.FillEllipse(br, recs[i]);
            //        gr.DrawString(vect[i].ToString(), font, br, new Point(recs[i].Location.X,
            //            recs[i].Location.Y - font.Height));
            //    }

            //    for (int i = 0; i < nrElem - 1; i++)
            //        gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)recs[i].Location.Y),
            //            new Point((int)(recs[i + 1].Location.X + latime / 2), (int)recs[i + 1].Location.Y));
            //}
        }

        private void btnGestionare_Click(object sender, EventArgs e)
        {
            IntroduPozitie form6 = new IntroduPozitie();
            form6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GestiuneAplicatii form7 = new GestiuneAplicatii();
            form7.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // e.Graphics.DrawString("Welcome to my home", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10,10));
            // e.Graphics.DrawString("Welcome to my home", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawImage(bitmap, 0, 0);        
        }

        Bitmap bitmap;
        private void button3_Click(object sender, EventArgs e)
        {
            // printPreviewDialog1.Document = printDocument1;
            // printPreviewDialog1.ShowDialog();

            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height,graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            chart1.Visible = false;
            if (vb)
            {
                Graphics g = e.Graphics;
                Rectangle rectangle = new Rectangle(chart1.ClientRectangle.X + marg, chart1.ClientRectangle.Y + 4 * marg,
                    chart1.ClientRectangle.Width - 2 * marg, chart1.ClientRectangle.Height - 5 * marg);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rectangle);

                double latime = rectangle.Width / nrElem / 3;
                double distanta = (rectangle.Width - nrElem * latime) / (nrElem + 1);
                double vMax = 10;

                Brush brBars = new SolidBrush(culoare);
                Brush brFont = new SolidBrush(culoareText);

                Rectangle[] rectangles = new Rectangle[nrElem];
                for (int i = 0; i < rectangles.Length; i++)
                {
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rectangle.Location.Y + rectangle.Height - vectNume[i].Length / vMax * rectangle.Height),
                        (int)latime,
                    (int)(vectNume[i].Length / vMax * rectangle.Height));

                    g.DrawString(vectPrenume[i], font, brFont, new Point((int)(rectangles[i].Location.X),
                        (int)(rectangles[i].Location.Y - font.Height)));
                }
                g.FillRectangles(brBars, rectangles);

                for (int i = 0; i < nrElem - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(rectangles[i].Location.X + latime / 2), (int)(rectangles[i].Location.Y)),
                        new Point((int)(rectangles[i + 1].Location.X + latime / 2), (int)(rectangles[i + 1].Location.Y)));
                }
            }
        }
    }
}