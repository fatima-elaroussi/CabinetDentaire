namespace Dentiste
{
    partial class Nouveau_Rendez_Vous
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
            this.EnregistrerRendezVous = new System.Windows.Forms.Button();
            this.obsRendez = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateRdv = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.motifRendez = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.traitemantRdv = new System.Windows.Forms.ComboBox();
            this.type_assu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dentRdv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.medcinRdv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.heureRdv = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Montant = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnregistrerRendezVous
            // 
            this.EnregistrerRendezVous.BackColor = System.Drawing.Color.Crimson;
            this.EnregistrerRendezVous.ForeColor = System.Drawing.Color.White;
            this.EnregistrerRendezVous.Location = new System.Drawing.Point(304, 325);
            this.EnregistrerRendezVous.Name = "EnregistrerRendezVous";
            this.EnregistrerRendezVous.Size = new System.Drawing.Size(183, 37);
            this.EnregistrerRendezVous.TabIndex = 26;
            this.EnregistrerRendezVous.Text = "Enregistrer";
            this.EnregistrerRendezVous.UseVisualStyleBackColor = false;
            this.EnregistrerRendezVous.Click += new System.EventHandler(this.EnregistrerRendezVous_Click);
            // 
            // obsRendez
            // 
            this.obsRendez.Location = new System.Drawing.Point(582, 193);
            this.obsRendez.Name = "obsRendez";
            this.obsRendez.Size = new System.Drawing.Size(216, 92);
            this.obsRendez.TabIndex = 25;
            this.obsRendez.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(485, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Observation :";
            // 
            // dateRdv
            // 
            this.dateRdv.Location = new System.Drawing.Point(127, 42);
            this.dateRdv.Name = "dateRdv";
            this.dateRdv.Size = new System.Drawing.Size(219, 21);
            this.dateRdv.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(23, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Date  :";
            // 
            // motifRendez
            // 
            this.motifRendez.Location = new System.Drawing.Point(127, 222);
            this.motifRendez.Name = "motifRendez";
            this.motifRendez.Size = new System.Drawing.Size(178, 51);
            this.motifRendez.TabIndex = 21;
            this.motifRendez.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(23, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Motif :";
            // 
            // traitemantRdv
            // 
            this.traitemantRdv.FormattingEnabled = true;
            this.traitemantRdv.Location = new System.Drawing.Point(582, 44);
            this.traitemantRdv.Name = "traitemantRdv";
            this.traitemantRdv.Size = new System.Drawing.Size(121, 23);
            this.traitemantRdv.TabIndex = 19;
            this.traitemantRdv.SelectedIndexChanged += new System.EventHandler(this.TraitemantRdv_SelectedIndexChanged);
            // 
            // type_assu
            // 
            this.type_assu.AutoSize = true;
            this.type_assu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_assu.ForeColor = System.Drawing.Color.Navy;
            this.type_assu.Location = new System.Drawing.Point(485, 47);
            this.type_assu.Name = "type_assu";
            this.type_assu.Size = new System.Drawing.Size(84, 15);
            this.type_assu.TabIndex = 18;
            this.type_assu.Text = "Traitement :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Montant);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dentRdv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.medcinRdv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EnregistrerRendezVous);
            this.groupBox1.Controls.Add(this.obsRendez);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dateRdv);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.motifRendez);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.traitemantRdv);
            this.groupBox1.Controls.Add(this.type_assu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.heureRdv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 402);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NOUVEAU RENDEZ-VOUS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(485, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Montant :";
            // 
            // dentRdv
            // 
            this.dentRdv.FormattingEnabled = true;
            this.dentRdv.Location = new System.Drawing.Point(582, 95);
            this.dentRdv.Name = "dentRdv";
            this.dentRdv.Size = new System.Drawing.Size(121, 23);
            this.dentRdv.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(485, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Dent :";
            // 
            // medcinRdv
            // 
            this.medcinRdv.FormattingEnabled = true;
            this.medcinRdv.Location = new System.Drawing.Point(127, 154);
            this.medcinRdv.Name = "medcinRdv";
            this.medcinRdv.Size = new System.Drawing.Size(121, 23);
            this.medcinRdv.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(23, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Médcin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heure :";
            // 
            // heureRdv
            // 
            this.heureRdv.Location = new System.Drawing.Point(127, 97);
            this.heureRdv.Multiline = true;
            this.heureRdv.Name = "heureRdv";
            this.heureRdv.Size = new System.Drawing.Size(121, 21);
            this.heureRdv.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Dentiste.Properties.Resources.backg9;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(927, 474);
            this.panel4.TabIndex = 9;
            // 
            // Montant
            // 
            this.Montant.Location = new System.Drawing.Point(582, 143);
            this.Montant.Multiline = true;
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(121, 21);
            this.Montant.TabIndex = 33;
            // 
            // Nouveau_Rendez_Vous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 474);
            this.Controls.Add(this.panel4);
            this.Name = "Nouveau_Rendez_Vous";
            this.Text = "Nouveau_Rendez_Vous";
            this.Load += new System.EventHandler(this.Nouveau_Rendez_Vous_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EnregistrerRendezVous;
        private System.Windows.Forms.RichTextBox obsRendez;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateRdv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox motifRendez;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox traitemantRdv;
        private System.Windows.Forms.Label type_assu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox dentRdv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox medcinRdv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox heureRdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Montant;
    }
}