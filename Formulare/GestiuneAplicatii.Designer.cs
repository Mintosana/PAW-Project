namespace Productie.Formulare
{
    partial class GestiuneAplicatii
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader ID;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestiuneAplicatii));
            this.cbFiltru = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Educatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Engleza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gestiuneHRDataSet = new Productie.GestiuneHRDataSet();
            this.gestiuneHRDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter = new Productie.GestiuneHRDataSetTableAdapters.JobTableAdapter();
            this.btnAdmis = new System.Windows.Forms.Button();
            this.btnRespins = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.gestiuneHRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiuneHRDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            ID.DisplayIndex = 5;
            ID.Text = "ID";
            ID.Width = 0;
            // 
            // cbFiltru
            // 
            this.cbFiltru.FormattingEnabled = true;
            this.cbFiltru.Location = new System.Drawing.Point(144, 29);
            this.cbFiltru.Name = "cbFiltru";
            this.cbFiltru.Size = new System.Drawing.Size(121, 21);
            this.cbFiltru.TabIndex = 30;
            this.cbFiltru.SelectedIndexChanged += new System.EventHandler(this.cbFiltru_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.Telefon,
            this.Email,
            this.Educatie,
            this.Engleza,
            ID});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 82);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(602, 290);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume Aplicant";
            this.Nume.Width = 108;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume Aplicant";
            this.Prenume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prenume.Width = 113;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefon.Width = 80;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 84;
            // 
            // Educatie
            // 
            this.Educatie.Text = "Educatie";
            this.Educatie.Width = 90;
            // 
            // Engleza
            // 
            this.Engleza.DisplayIndex = 6;
            this.Engleza.Text = "Cunostinte Engleza";
            this.Engleza.Width = 144;
            // 
            // gestiuneHRDataSet
            // 
            this.gestiuneHRDataSet.DataSetName = "GestiuneHRDataSet";
            this.gestiuneHRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestiuneHRDataSetBindingSource
            // 
            this.gestiuneHRDataSetBindingSource.DataSource = this.gestiuneHRDataSet;
            this.gestiuneHRDataSetBindingSource.Position = 0;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.gestiuneHRDataSetBindingSource;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdmis
            // 
            this.btnAdmis.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdmis.Location = new System.Drawing.Point(174, 393);
            this.btnAdmis.Name = "btnAdmis";
            this.btnAdmis.Size = new System.Drawing.Size(107, 35);
            this.btnAdmis.TabIndex = 32;
            this.btnAdmis.Text = "Accepta Candidat";
            this.btnAdmis.UseVisualStyleBackColor = false;
            this.btnAdmis.Click += new System.EventHandler(this.btnAdmis_Click);
            // 
            // btnRespins
            // 
            this.btnRespins.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRespins.ForeColor = System.Drawing.Color.Snow;
            this.btnRespins.Location = new System.Drawing.Point(340, 393);
            this.btnRespins.Name = "btnRespins";
            this.btnRespins.Size = new System.Drawing.Size(106, 35);
            this.btnRespins.TabIndex = 33;
            this.btnRespins.Text = "Respinge Candidat";
            this.btnRespins.UseVisualStyleBackColor = false;
            this.btnRespins.Click += new System.EventHandler(this.btnRespins_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Filtru Pozitii";
            // 
            // GestiuneAplicatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(662, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRespins);
            this.Controls.Add(this.btnAdmis);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbFiltru);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestiuneAplicatii";
            this.Text = "Gestiune Aplicatii";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestiuneHRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiuneHRDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFiltru;
        private System.Windows.Forms.BindingSource gestiuneHRDataSetBindingSource;
        private GestiuneHRDataSet gestiuneHRDataSet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Educatie;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private GestiuneHRDataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.ColumnHeader Engleza;
        private System.Windows.Forms.Button btnAdmis;
        private System.Windows.Forms.Button btnRespins;
        private System.Windows.Forms.Label label1;
    }
}