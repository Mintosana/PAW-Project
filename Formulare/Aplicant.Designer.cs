
namespace Productie
{
    partial class Aplicant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplicant));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bOut = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.time1 = new Productie.time();
            this.comenzi1 = new Productie.GestionarePozitii();
            this.comanda1 = new Productie.AplicarePozitie();
            this.detalii1 = new Productie.Detalii();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.bOut);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 492);
            this.panel1.TabIndex = 0;
            // 
            // bOut
            // 
            this.bOut.FlatAppearance.BorderSize = 0;
            this.bOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.bOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bOut.ForeColor = System.Drawing.Color.Snow;
            this.bOut.Image = global::Productie.Properties.Resources.icons8_import_32__1_;
            this.bOut.Location = new System.Drawing.Point(-8, 381);
            this.bOut.Margin = new System.Windows.Forms.Padding(2);
            this.bOut.Name = "bOut";
            this.bOut.Size = new System.Drawing.Size(188, 43);
            this.bOut.TabIndex = 3;
            this.bOut.Text = "Logout";
            this.bOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bOut.UseVisualStyleBackColor = true;
            this.bOut.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Image = global::Productie.Properties.Resources.icons8_user_male_24__1_;
            this.button3.Location = new System.Drawing.Point(-8, 247);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Detalii";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Productie.Properties.Resources.icons8_activity_history_24;
            this.button2.Location = new System.Drawing.Point(-8, 162);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Istoric";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Image = global::Productie.Properties.Resources.icons8_new_26;
            this.button1.Location = new System.Drawing.Point(-8, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aplica";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // time1
            // 
            this.time1.BackColor = System.Drawing.Color.DarkCyan;
            this.time1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.time1.Location = new System.Drawing.Point(617, 423);
            this.time1.Margin = new System.Windows.Forms.Padding(2);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(162, 50);
            this.time1.TabIndex = 7;
            this.time1.Load += new System.EventHandler(this.time1_Load);
            // 
            // comenzi1
            // 
            this.comenzi1.BackColor = System.Drawing.Color.DarkCyan;
            this.comenzi1.Location = new System.Drawing.Point(182, 0);
            this.comenzi1.Margin = new System.Windows.Forms.Padding(2);
            this.comenzi1.Name = "comenzi1";
            this.comenzi1.Size = new System.Drawing.Size(606, 490);
            this.comenzi1.TabIndex = 6;
            this.comenzi1.Load += new System.EventHandler(this.comenzi1_Load);
            // 
            // comanda1
            // 
            this.comanda1.BackColor = System.Drawing.Color.DarkCyan;
            this.comanda1.Location = new System.Drawing.Point(182, 2);
            this.comanda1.Margin = new System.Windows.Forms.Padding(2);
            this.comanda1.Name = "comanda1";
            this.comanda1.Size = new System.Drawing.Size(606, 488);
            this.comanda1.TabIndex = 5;
            this.comanda1.Load += new System.EventHandler(this.comanda1_Load);
            // 
            // detalii1
            // 
            this.detalii1.BackColor = System.Drawing.Color.DarkCyan;
            this.detalii1.Location = new System.Drawing.Point(186, 0);
            this.detalii1.Margin = new System.Windows.Forms.Padding(2);
            this.detalii1.Name = "detalii1";
            this.detalii1.Size = new System.Drawing.Size(412, 366);
            this.detalii1.TabIndex = 4;
            // 
            // Aplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(790, 484);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.comenzi1);
            this.Controls.Add(this.comanda1);
            this.Controls.Add(this.detalii1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Aplicant";
            this.Text = "Generic Name";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bOut;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Detalii detalii1;
        private AplicarePozitie comanda1;
        private GestionarePozitii comenzi1;
        private time time1;
    }
}