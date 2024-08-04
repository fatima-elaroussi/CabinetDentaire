namespace Dentiste
{
    partial class Traitements
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
            this.EnregistrerTraitement = new System.Windows.Forms.Button();
            this.obsTrait = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desiTraitement = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MontantTrait = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Dentiste.Properties.Resources.backg9;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(841, 392);
            this.panel4.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Dentiste.Properties.Resources.tamplate1;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.EnregistrerTraitement);
            this.groupBox1.Controls.Add(this.obsTrait);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.desiTraitement);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MontantTrait);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 386);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NEVEAU TRAITEMENT";
            // 
            // EnregistrerTraitement
            // 
            this.EnregistrerTraitement.BackColor = System.Drawing.Color.Crimson;
            this.EnregistrerTraitement.ForeColor = System.Drawing.Color.White;
            this.EnregistrerTraitement.Location = new System.Drawing.Point(316, 248);
            this.EnregistrerTraitement.Name = "EnregistrerTraitement";
            this.EnregistrerTraitement.Size = new System.Drawing.Size(183, 37);
            this.EnregistrerTraitement.TabIndex = 26;
            this.EnregistrerTraitement.Text = "Enregistrer";
            this.EnregistrerTraitement.UseVisualStyleBackColor = false;
            this.EnregistrerTraitement.Click += new System.EventHandler(this.EnregistrerTraitement_Click);
            // 
            // obsTrait
            // 
            this.obsTrait.Location = new System.Drawing.Point(316, 158);
            this.obsTrait.Name = "obsTrait";
            this.obsTrait.Size = new System.Drawing.Size(178, 51);
            this.obsTrait.TabIndex = 25;
            this.obsTrait.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(198, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Observation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Désignation :";
            // 
            // desiTraitement
            // 
            this.desiTraitement.Location = new System.Drawing.Point(135, 61);
            this.desiTraitement.Name = "desiTraitement";
            this.desiTraitement.Size = new System.Drawing.Size(174, 21);
            this.desiTraitement.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(472, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Montant :";
            // 
            // MontantTrait
            // 
            this.MontantTrait.Location = new System.Drawing.Point(549, 61);
            this.MontantTrait.Name = "MontantTrait";
            this.MontantTrait.Size = new System.Drawing.Size(100, 21);
            this.MontantTrait.TabIndex = 9;
            // 
            // Traitements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 392);
            this.Controls.Add(this.panel4);
            this.Name = "Traitements";
            this.Text = "Traitements";
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EnregistrerTraitement;
        private System.Windows.Forms.RichTextBox obsTrait;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox desiTraitement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MontantTrait;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
    }
}