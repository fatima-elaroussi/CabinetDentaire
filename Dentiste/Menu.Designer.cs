namespace Dentiste
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caisseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traitementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medcinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesDépensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Denty Care";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Dentiste.Properties.Resources.template2;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.rendezVousToolStripMenuItem,
            this.caisseToolStripMenuItem,
            this.depensesToolStripMenuItem,
            this.parametrageToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(157, 463);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueilToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.accueilToolStripMenuItem.Image = global::Dentiste.Properties.Resources.home3;
            this.accueilToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 90, 0, 20);
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(144, 27);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.AccueilToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.patientsToolStripMenuItem.Image = global::Dentiste.Properties.Resources.dentist__1_;
            this.patientsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(144, 27);
            this.patientsToolStripMenuItem.Text = "Patients";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.PatientsToolStripMenuItem_Click);
            // 
            // rendezVousToolStripMenuItem
            // 
            this.rendezVousToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendezVousToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.rendezVousToolStripMenuItem.Image = global::Dentiste.Properties.Resources.medical_appointment__2_;
            this.rendezVousToolStripMenuItem.Margin = new System.Windows.Forms.Padding(11, 0, 0, 20);
            this.rendezVousToolStripMenuItem.Name = "rendezVousToolStripMenuItem";
            this.rendezVousToolStripMenuItem.Size = new System.Drawing.Size(133, 27);
            this.rendezVousToolStripMenuItem.Text = "Rendez-Vous";
            this.rendezVousToolStripMenuItem.Click += new System.EventHandler(this.RendezVousToolStripMenuItem_Click);
            // 
            // caisseToolStripMenuItem
            // 
            this.caisseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caisseToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.caisseToolStripMenuItem.Image = global::Dentiste.Properties.Resources.dollar;
            this.caisseToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.caisseToolStripMenuItem.Name = "caisseToolStripMenuItem";
            this.caisseToolStripMenuItem.Size = new System.Drawing.Size(124, 27);
            this.caisseToolStripMenuItem.Text = "Caisse";
            this.caisseToolStripMenuItem.Click += new System.EventHandler(this.CaisseToolStripMenuItem_Click);
            // 
            // depensesToolStripMenuItem
            // 
            this.depensesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depensesToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.depensesToolStripMenuItem.Image = global::Dentiste.Properties.Resources.caisse;
            this.depensesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 20);
            this.depensesToolStripMenuItem.Name = "depensesToolStripMenuItem";
            this.depensesToolStripMenuItem.Size = new System.Drawing.Size(141, 27);
            this.depensesToolStripMenuItem.Text = "Depenses";
            this.depensesToolStripMenuItem.Click += new System.EventHandler(this.DepensesToolStripMenuItem_Click);
            // 
            // parametrageToolStripMenuItem
            // 
            this.parametrageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traitementsToolStripMenuItem,
            this.dentsToolStripMenuItem,
            this.medcinToolStripMenuItem,
            this.typesDépensesToolStripMenuItem,
            this.utilisateurToolStripMenuItem});
            this.parametrageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parametrageToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.parametrageToolStripMenuItem.Image = global::Dentiste.Properties.Resources.Settings_icon__1_;
            this.parametrageToolStripMenuItem.Margin = new System.Windows.Forms.Padding(9, 0, 0, 20);
            this.parametrageToolStripMenuItem.Name = "parametrageToolStripMenuItem";
            this.parametrageToolStripMenuItem.Size = new System.Drawing.Size(135, 27);
            this.parametrageToolStripMenuItem.Text = "Parametrage";
            // 
            // traitementsToolStripMenuItem
            // 
            this.traitementsToolStripMenuItem.BackgroundImage = global::Dentiste.Properties.Resources.background1;
            this.traitementsToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.traitementsToolStripMenuItem.Image = global::Dentiste.Properties.Resources.treatement2;
            this.traitementsToolStripMenuItem.Name = "traitementsToolStripMenuItem";
            this.traitementsToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.traitementsToolStripMenuItem.Text = "Traitements";
            this.traitementsToolStripMenuItem.Click += new System.EventHandler(this.TraitementsToolStripMenuItem_Click);
            // 
            // dentsToolStripMenuItem
            // 
            this.dentsToolStripMenuItem.BackgroundImage = global::Dentiste.Properties.Resources.background1;
            this.dentsToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.dentsToolStripMenuItem.Image = global::Dentiste.Properties.Resources.teeth;
            this.dentsToolStripMenuItem.Name = "dentsToolStripMenuItem";
            this.dentsToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.dentsToolStripMenuItem.Text = "Dents";
            this.dentsToolStripMenuItem.Click += new System.EventHandler(this.DentsToolStripMenuItem_Click);
            // 
            // medcinToolStripMenuItem
            // 
            this.medcinToolStripMenuItem.BackgroundImage = global::Dentiste.Properties.Resources.background1;
            this.medcinToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.medcinToolStripMenuItem.Image = global::Dentiste.Properties.Resources.dentist__4_;
            this.medcinToolStripMenuItem.Name = "medcinToolStripMenuItem";
            this.medcinToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.medcinToolStripMenuItem.Text = "Medcin";
            this.medcinToolStripMenuItem.Click += new System.EventHandler(this.MedcinToolStripMenuItem_Click);
            // 
            // typesDépensesToolStripMenuItem
            // 
            this.typesDépensesToolStripMenuItem.BackgroundImage = global::Dentiste.Properties.Resources.background1;
            this.typesDépensesToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.typesDépensesToolStripMenuItem.Image = global::Dentiste.Properties.Resources.rising;
            this.typesDépensesToolStripMenuItem.Name = "typesDépensesToolStripMenuItem";
            this.typesDépensesToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.typesDépensesToolStripMenuItem.Text = "Types Dépenses";
            this.typesDépensesToolStripMenuItem.Click += new System.EventHandler(this.TypesDépensesToolStripMenuItem_Click);
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.BackgroundImage = global::Dentiste.Properties.Resources.background1;
            this.utilisateurToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.utilisateurToolStripMenuItem.Image = global::Dentiste.Properties.Resources.user;
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.utilisateurToolStripMenuItem.Text = "utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.UtilisateurToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 24);
            this.toolStripMenuItem1.Text = "\'";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendezVousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caisseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traitementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medcinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesDépensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}