namespace Dentiste
{
    partial class RendezVous
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
            this.dataGridRendezVous = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Traitement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ndossier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AjouterRendezVous = new System.Windows.Forms.Button();
            this.recherchRendezvous = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRendezVous)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1010, 479);
            this.panel4.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Dentiste.Properties.Resources.backg9;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridRendezVous);
            this.groupBox1.Controls.Add(this.AjouterRendezVous);
            this.groupBox1.Controls.Add(this.recherchRendezvous);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(4, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 460);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Rendez_Vous";
            // 
            // dataGridRendezVous
            // 
            this.dataGridRendezVous.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridRendezVous.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRendezVous.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prenom,
            this.Date,
            this.Heure,
            this.Traitement,
            this.Dent,
            this.Ndossier,
            this.Montant});
            this.dataGridRendezVous.Location = new System.Drawing.Point(56, 77);
            this.dataGridRendezVous.Name = "dataGridRendezVous";
            this.dataGridRendezVous.Size = new System.Drawing.Size(844, 325);
            this.dataGridRendezVous.TabIndex = 1;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Heure
            // 
            this.Heure.HeaderText = "Heure";
            this.Heure.Name = "Heure";
            // 
            // Traitement
            // 
            this.Traitement.HeaderText = "Traitement";
            this.Traitement.Name = "Traitement";
            // 
            // Dent
            // 
            this.Dent.HeaderText = "Dent";
            this.Dent.Name = "Dent";
            // 
            // Ndossier
            // 
            this.Ndossier.HeaderText = "Numéro de Dossier";
            this.Ndossier.Name = "Ndossier";
            // 
            // Montant
            // 
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            // 
            // AjouterRendezVous
            // 
            this.AjouterRendezVous.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AjouterRendezVous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterRendezVous.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AjouterRendezVous.Image = global::Dentiste.Properties.Resources.ajouter;
            this.AjouterRendezVous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouterRendezVous.Location = new System.Drawing.Point(760, 22);
            this.AjouterRendezVous.Name = "AjouterRendezVous";
            this.AjouterRendezVous.Size = new System.Drawing.Size(140, 23);
            this.AjouterRendezVous.TabIndex = 4;
            this.AjouterRendezVous.Text = "Ajouter";
            this.AjouterRendezVous.UseVisualStyleBackColor = false;
            this.AjouterRendezVous.Click += new System.EventHandler(this.AjouterRendezVous_Click_1);
            // 
            // recherchRendezvous
            // 
            this.recherchRendezvous.Location = new System.Drawing.Point(800, 51);
            this.recherchRendezvous.Name = "recherchRendezvous";
            this.recherchRendezvous.Size = new System.Drawing.Size(100, 20);
            this.recherchRendezvous.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Image = global::Dentiste.Properties.Resources.Search_icon;
            this.button2.Location = new System.Drawing.Point(760, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 479);
            this.Controls.Add(this.panel4);
            this.Name = "RendezVous";
            this.Text = "RendezVous";
            this.Load += new System.EventHandler(this.RendezVous_Load);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRendezVous)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridRendezVous;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Traitement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ndossier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.Button AjouterRendezVous;
        private System.Windows.Forms.TextBox recherchRendezvous;
        private System.Windows.Forms.Button button2;
    }
}