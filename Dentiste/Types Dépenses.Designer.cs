namespace Dentiste
{
    partial class Types_Dépenses
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
            this.EnregistrerTypeDepenses = new System.Windows.Forms.Button();
            this.obsTypDep = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desiTypDep = new System.Windows.Forms.TextBox();
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
            this.panel4.Size = new System.Drawing.Size(823, 352);
            this.panel4.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EnregistrerTypeDepenses);
            this.groupBox1.Controls.Add(this.obsTypDep);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.desiTypDep);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 346);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NEVEAU TYPES DEPENSES";
            // 
            // EnregistrerTypeDepenses
            // 
            this.EnregistrerTypeDepenses.BackColor = System.Drawing.Color.Crimson;
            this.EnregistrerTypeDepenses.ForeColor = System.Drawing.Color.White;
            this.EnregistrerTypeDepenses.Location = new System.Drawing.Point(258, 163);
            this.EnregistrerTypeDepenses.Name = "EnregistrerTypeDepenses";
            this.EnregistrerTypeDepenses.Size = new System.Drawing.Size(183, 37);
            this.EnregistrerTypeDepenses.TabIndex = 26;
            this.EnregistrerTypeDepenses.Text = "Enregistrer";
            this.EnregistrerTypeDepenses.UseVisualStyleBackColor = false;
            this.EnregistrerTypeDepenses.Click += new System.EventHandler(this.EnregistrerTypeDepenses_Click);
            // 
            // obsTypDep
            // 
            this.obsTypDep.Location = new System.Drawing.Point(538, 46);
            this.obsTypDep.Name = "obsTypDep";
            this.obsTypDep.Size = new System.Drawing.Size(178, 51);
            this.obsTypDep.TabIndex = 25;
            this.obsTypDep.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(384, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Observation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Désignation :";
            // 
            // desiTypDep
            // 
            this.desiTypDep.Location = new System.Drawing.Point(135, 61);
            this.desiTypDep.Name = "desiTypDep";
            this.desiTypDep.Size = new System.Drawing.Size(174, 21);
            this.desiTypDep.TabIndex = 1;
            // 
            // Types_Dépenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 352);
            this.Controls.Add(this.panel4);
            this.Name = "Types_Dépenses";
            this.Text = "Types_Dépenses";
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EnregistrerTypeDepenses;
        private System.Windows.Forms.RichTextBox obsTypDep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox desiTypDep;
        private System.Windows.Forms.Panel panel4;
    }
}