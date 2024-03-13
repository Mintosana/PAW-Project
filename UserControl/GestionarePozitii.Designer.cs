
namespace Productie
{
    partial class GestionarePozitii
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
            System.Windows.Forms.ColumnHeader ID;
            this.listView1 = new System.Windows.Forms.ListView();
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Locatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Experienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salariu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbFiltru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Denumire,
            this.Departament,
            this.Locatie,
            this.Experienta,
            this.Tip,
            this.Salariu,
            this.Admis,
            ID});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 138);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(545, 218);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Denumire
            // 
            this.Denumire.Text = "Denumire";
            this.Denumire.Width = 85;
            // 
            // Departament
            // 
            this.Departament.Text = "Departament";
            this.Departament.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Departament.Width = 99;
            // 
            // Locatie
            // 
            this.Locatie.Text = "Locatie";
            this.Locatie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Locatie.Width = 83;
            // 
            // Experienta
            // 
            this.Experienta.Text = "Experienta";
            this.Experienta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Experienta.Width = 95;
            // 
            // Tip
            // 
            this.Tip.Text = "Tip";
            // 
            // Salariu
            // 
            this.Salariu.Text = "Salariu";
            // 
            // Admis
            // 
            this.Admis.Text = "Admis?";
            // 
            // cbFiltru
            // 
            this.cbFiltru.FormattingEnabled = true;
            this.cbFiltru.Items.AddRange(new object[] {
            "Pending",
            "Admis",
            "Respins"});
            this.cbFiltru.Location = new System.Drawing.Point(78, 70);
            this.cbFiltru.Name = "cbFiltru";
            this.cbFiltru.Size = new System.Drawing.Size(121, 21);
            this.cbFiltru.TabIndex = 29;
            this.cbFiltru.SelectedIndexChanged += new System.EventHandler(this.cbFiltru_SelectedIndexChanged);
            this.cbFiltru.SelectedValueChanged += new System.EventHandler(this.cbFiltru_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Filtru";
            this.label1.UseMnemonic = false;
            // 
            // GestionarePozitii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFiltru);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionarePozitii";
            this.Size = new System.Drawing.Size(636, 459);
            this.Load += new System.EventHandler(this.GestionarePozitii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Departament;
        private System.Windows.Forms.ColumnHeader Locatie;
        private System.Windows.Forms.ColumnHeader Experienta;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.ColumnHeader Salariu;
        private System.Windows.Forms.ColumnHeader Admis;
        private System.Windows.Forms.ComboBox cbFiltru;
        private System.Windows.Forms.Label label1;
    }
}
