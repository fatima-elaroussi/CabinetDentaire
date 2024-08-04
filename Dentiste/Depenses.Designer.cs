namespace Dentiste
{
    partial class Depenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depenses));
            this.EnregistrerDepense = new System.Windows.Forms.Button();
            this.obsDepense = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateDepense = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Virement = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.montantDepense = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typeDepense = new System.Windows.Forms.ComboBox();
            this.Especes = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnregistrerDepense
            // 
            this.EnregistrerDepense.BackColor = System.Drawing.Color.Crimson;
            this.EnregistrerDepense.ForeColor = System.Drawing.Color.White;
            this.EnregistrerDepense.Location = new System.Drawing.Point(297, 319);
            this.EnregistrerDepense.Name = "EnregistrerDepense";
            this.EnregistrerDepense.Size = new System.Drawing.Size(183, 37);
            this.EnregistrerDepense.TabIndex = 26;
            this.EnregistrerDepense.Text = "Enregistrer";
            this.EnregistrerDepense.UseVisualStyleBackColor = false;
            this.EnregistrerDepense.Click += new System.EventHandler(this.EnregistrerDepense_Click);
            // 
            // obsDepense
            // 
            this.obsDepense.Location = new System.Drawing.Point(302, 223);
            this.obsDepense.Name = "obsDepense";
            this.obsDepense.Size = new System.Drawing.Size(178, 51);
            this.obsDepense.TabIndex = 25;
            this.obsDepense.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(165, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Observation :";
            // 
            // dateDepense
            // 
            this.dateDepense.Location = new System.Drawing.Point(555, 56);
            this.dateDepense.Name = "dateDepense";
            this.dateDepense.Size = new System.Drawing.Size(219, 21);
            this.dateDepense.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(477, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Types de Dépenses :";
            // 
            // Virement
            // 
            this.Virement.AutoSize = true;
            this.Virement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Virement.ForeColor = System.Drawing.Color.Navy;
            this.Virement.Location = new System.Drawing.Point(709, 153);
            this.Virement.Name = "Virement";
            this.Virement.Size = new System.Drawing.Size(82, 19);
            this.Virement.TabIndex = 17;
            this.Virement.TabStop = true;
            this.Virement.Text = "Virement";
            this.Virement.UseVisualStyleBackColor = true;
            this.Virement.CheckedChanged += new System.EventHandler(this.Virement_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(28, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Montant :";
            // 
            // montantDepense
            // 
            this.montantDepense.Location = new System.Drawing.Point(174, 143);
            this.montantDepense.Name = "montantDepense";
            this.montantDepense.Size = new System.Drawing.Size(125, 21);
            this.montantDepense.TabIndex = 9;
            // 
            // close
            // 
            this.close.Image = global::Dentiste.Properties.Resources.Status_dialog_error_icon;
            this.close.Location = new System.Drawing.Point(1208, 1);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(1);
            this.close.Size = new System.Drawing.Size(41, 30);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1169, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 34);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeDepense);
            this.groupBox1.Controls.Add(this.EnregistrerDepense);
            this.groupBox1.Controls.Add(this.obsDepense);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dateDepense);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Virement);
            this.groupBox1.Controls.Add(this.Especes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.montantDepense);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(27, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 417);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NEVEAU DEPENSES";
            // 
            // typeDepense
            // 
            this.typeDepense.FormattingEnabled = true;
            this.typeDepense.Location = new System.Drawing.Point(174, 58);
            this.typeDepense.Name = "typeDepense";
            this.typeDepense.Size = new System.Drawing.Size(121, 23);
            this.typeDepense.TabIndex = 27;
            // 
            // Especes
            // 
            this.Especes.AutoSize = true;
            this.Especes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Especes.ForeColor = System.Drawing.Color.Navy;
            this.Especes.Location = new System.Drawing.Point(624, 154);
            this.Especes.Name = "Especes";
            this.Especes.Size = new System.Drawing.Size(79, 19);
            this.Especes.TabIndex = 16;
            this.Especes.TabStop = true;
            this.Especes.Text = "Espeses";
            this.Especes.UseVisualStyleBackColor = true;
            this.Especes.CheckedChanged += new System.EventHandler(this.Especes_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(477, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Type de Paiment :";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Dentiste.Properties.Resources.backg9;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(866, 506);
            this.panel4.TabIndex = 9;
            // 
            // Depenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "Depenses";
            this.Text = "Depenses";
            this.Load += new System.EventHandler(this.Depenses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EnregistrerDepense;
        private System.Windows.Forms.RichTextBox obsDepense;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateDepense;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Virement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox montantDepense;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton Especes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox typeDepense;
    }
}