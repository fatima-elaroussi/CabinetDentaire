namespace Dentiste
{
    partial class Patients
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.RdvPatient = new System.Windows.Forms.Button();
            this.dataGridPatient = new System.Windows.Forms.DataGridView();
            this.nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AjouterPatient = new System.Windows.Forms.Button();
            this.recherchPatient = new System.Windows.Forms.TextBox();
            this.btnRechercherPat = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(777, 503);
            this.panel4.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackgroundImage = global::Dentiste.Properties.Resources.backg9;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.Supprimer);
            this.groupBox1.Controls.Add(this.Modifier);
            this.groupBox1.Controls.Add(this.RdvPatient);
            this.groupBox1.Controls.Add(this.dataGridPatient);
            this.groupBox1.Controls.Add(this.AjouterPatient);
            this.groupBox1.Controls.Add(this.recherchPatient);
            this.groupBox1.Controls.Add(this.btnRechercherPat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 503);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Patients";
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Supprimer.Location = new System.Drawing.Point(122, 89);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(105, 31);
            this.Supprimer.TabIndex = 7;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Modifier.Location = new System.Drawing.Point(256, 88);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(105, 32);
            this.Modifier.TabIndex = 6;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // RdvPatient
            // 
            this.RdvPatient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RdvPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdvPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RdvPatient.Location = new System.Drawing.Point(394, 88);
            this.RdvPatient.Name = "RdvPatient";
            this.RdvPatient.Size = new System.Drawing.Size(105, 32);
            this.RdvPatient.TabIndex = 5;
            this.RdvPatient.Text = "Rendez-Vous";
            this.RdvPatient.UseVisualStyleBackColor = false;
            this.RdvPatient.Click += new System.EventHandler(this.RdvPatient_Click);
            // 
            // dataGridPatient
            // 
            this.dataGridPatient.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nm,
            this.prenom,
            this.numDoss,
            this.date,
            this.tele});
            this.dataGridPatient.Location = new System.Drawing.Point(108, 127);
            this.dataGridPatient.Name = "dataGridPatient";
            this.dataGridPatient.Size = new System.Drawing.Size(593, 324);
            this.dataGridPatient.TabIndex = 1;
            // 
            // nm
            // 
            this.nm.HeaderText = "Nom";
            this.nm.Name = "nm";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            // 
            // numDoss
            // 
            this.numDoss.HeaderText = "Numéro Dossier";
            this.numDoss.Name = "numDoss";
            // 
            // date
            // 
            this.date.HeaderText = "Date ";
            this.date.Name = "date";
            // 
            // tele
            // 
            this.tele.HeaderText = "Téléphone";
            this.tele.Name = "tele";
            // 
            // AjouterPatient
            // 
            this.AjouterPatient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AjouterPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterPatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AjouterPatient.Image = global::Dentiste.Properties.Resources.ajouter;
            this.AjouterPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouterPatient.Location = new System.Drawing.Point(554, 48);
            this.AjouterPatient.Name = "AjouterPatient";
            this.AjouterPatient.Size = new System.Drawing.Size(147, 27);
            this.AjouterPatient.TabIndex = 4;
            this.AjouterPatient.Text = "Ajouter";
            this.AjouterPatient.UseVisualStyleBackColor = false;
            this.AjouterPatient.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // recherchPatient
            // 
            this.recherchPatient.Location = new System.Drawing.Point(554, 96);
            this.recherchPatient.Multiline = true;
            this.recherchPatient.Name = "recherchPatient";
            this.recherchPatient.Size = new System.Drawing.Size(147, 24);
            this.recherchPatient.TabIndex = 2;
            this.recherchPatient.TextChanged += new System.EventHandler(this.RecherchPatient_TextChanged);
            // 
            // btnRechercherPat
            // 
            this.btnRechercherPat.Image = global::Dentiste.Properties.Resources.Search_icon;
            this.btnRechercherPat.Location = new System.Drawing.Point(514, 96);
            this.btnRechercherPat.Name = "btnRechercherPat";
            this.btnRechercherPat.Size = new System.Drawing.Size(34, 24);
            this.btnRechercherPat.TabIndex = 3;
            this.btnRechercherPat.UseVisualStyleBackColor = true;
            this.btnRechercherPat.Click += new System.EventHandler(this.BtnRechercherPat_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(777, 503);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.Name = "Patients";
            this.Text = "Patients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Patients_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridPatient;
        private System.Windows.Forms.TextBox recherchPatient;
        private System.Windows.Forms.Button btnRechercherPat;
        private System.Windows.Forms.Button AjouterPatient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RdvPatient;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn tele;
    }
}