
namespace Productie
{
    partial class IntroduPozitie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroduPozitie));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDepartament = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Locatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Experienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salariu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.tbExperienta = new System.Windows.Forms.TextBox();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.tbSalariu = new System.Windows.Forms.TextBox();
            this.checkEngleza = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msOptiuni = new System.Windows.Forms.MenuStrip();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.msOptiuni.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Adaugati Pozitie noua!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Afiseaza Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(584, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(584, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Departament";
            // 
            // tbDepartament
            // 
            this.tbDepartament.Location = new System.Drawing.Point(728, 141);
            this.tbDepartament.Name = "tbDepartament";
            this.tbDepartament.Size = new System.Drawing.Size(100, 20);
            this.tbDepartament.TabIndex = 23;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(728, 108);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.Salariu});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 28);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 316);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(584, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Locatie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(584, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nivel Experienta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(584, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Salariu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(584, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tip";
            // 
            // tbLocatie
            // 
            this.tbLocatie.Location = new System.Drawing.Point(728, 173);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(100, 20);
            this.tbLocatie.TabIndex = 34;
            // 
            // tbExperienta
            // 
            this.tbExperienta.Location = new System.Drawing.Point(728, 209);
            this.tbExperienta.Name = "tbExperienta";
            this.tbExperienta.Size = new System.Drawing.Size(100, 20);
            this.tbExperienta.TabIndex = 35;
            // 
            // tbTip
            // 
            this.tbTip.Location = new System.Drawing.Point(728, 244);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(100, 20);
            this.tbTip.TabIndex = 36;
            // 
            // tbSalariu
            // 
            this.tbSalariu.Location = new System.Drawing.Point(728, 277);
            this.tbSalariu.Name = "tbSalariu";
            this.tbSalariu.Size = new System.Drawing.Size(100, 20);
            this.tbSalariu.TabIndex = 37;
            // 
            // checkEngleza
            // 
            this.checkEngleza.AutoSize = true;
            this.checkEngleza.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEngleza.ForeColor = System.Drawing.Color.Snow;
            this.checkEngleza.Location = new System.Drawing.Point(651, 317);
            this.checkEngleza.Name = "checkEngleza";
            this.checkEngleza.Size = new System.Drawing.Size(147, 27);
            this.checkEngleza.TabIndex = 38;
            this.checkEngleza.Text = "Necesită engleză?";
            this.checkEngleza.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(554, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 65);
            this.label3.TabIndex = 39;
            this.label3.Text = "Introducere Pozitie";
            // 
            // msOptiuni
            // 
            this.msOptiuni.Location = new System.Drawing.Point(0, 0);
            this.msOptiuni.Name = "msOptiuni";
            this.msOptiuni.Size = new System.Drawing.Size(935, 24);
            this.msOptiuni.TabIndex = 40;
            this.msOptiuni.Text = "menuStrip1";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.xMLToolStripMenuItem.Text = "Incarcare Pozitii prin XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Image = global::Productie.Properties.Resources.icons8_delete_26;
            this.button3.Location = new System.Drawing.Point(38, 360);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 46);
            this.button3.TabIndex = 28;
            this.button3.Text = "Sterge";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IntroduPozitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkEngleza);
            this.Controls.Add(this.tbSalariu);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.tbExperienta);
            this.Controls.Add(this.tbLocatie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbDepartament);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msOptiuni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msOptiuni;
            this.Name = "IntroduPozitie";
            this.Text = "Introducere Pozitie";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.msOptiuni.ResumeLayout(false);
            this.msOptiuni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDepartament;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Departament;
        private System.Windows.Forms.ColumnHeader Locatie;
        private System.Windows.Forms.ColumnHeader Experienta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSalariu;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.TextBox tbExperienta;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.CheckBox checkEngleza;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.ColumnHeader Salariu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip msOptiuni;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
    }
}