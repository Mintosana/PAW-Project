
namespace Productie
{
    partial class Detalii
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Educatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.NrAplicatii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NrRespinse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NrAdmiteri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Email,
            this.Telefon,
            this.Educatie});
            this.listView1.ForeColor = System.Drawing.Color.Snow;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 53);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 53);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 51;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 133;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefon.Width = 112;
            // 
            // Educatie
            // 
            this.Educatie.Text = "Educatie";
            this.Educatie.Width = 99;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NrAplicatii,
            this.NrRespinse,
            this.NrAdmiteri});
            this.listView2.ForeColor = System.Drawing.Color.Snow;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(64, 171);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(327, 80);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // NrAplicatii
            // 
            this.NrAplicatii.Text = "Numar Aplicari";
            this.NrAplicatii.Width = 81;
            // 
            // NrRespinse
            // 
            this.NrRespinse.Text = "Numar Respingeri";
            this.NrRespinse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NrRespinse.Width = 133;
            // 
            // NrAdmiteri
            // 
            this.NrAdmiteri.Text = "Numar Admis";
            this.NrAdmiteri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NrAdmiteri.Width = 112;
            // 
            // Detalii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Detalii";
            this.Size = new System.Drawing.Size(463, 304);
            this.Load += new System.EventHandler(this.Detalii_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Educatie;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader NrAplicatii;
        private System.Windows.Forms.ColumnHeader NrRespinse;
        private System.Windows.Forms.ColumnHeader NrAdmiteri;
    }
}
