namespace Dentiste
{
    partial class listes_dents
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
            this.AjouterDent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recherchDent = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AjouterDent
            // 
            this.AjouterDent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AjouterDent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterDent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AjouterDent.Image = global::Dentiste.Properties.Resources.ajouter;
            this.AjouterDent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouterDent.Location = new System.Drawing.Point(796, 19);
            this.AjouterDent.Name = "AjouterDent";
            this.AjouterDent.Size = new System.Drawing.Size(140, 23);
            this.AjouterDent.TabIndex = 4;
            this.AjouterDent.Text = "Ajouter";
            this.AjouterDent.UseVisualStyleBackColor = false;
            this.AjouterDent.Click += new System.EventHandler(this.AjouterDent_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Dentiste.Properties.Resources.Search_icon;
            this.button2.Location = new System.Drawing.Point(796, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1012, 490);
            this.panel4.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Dentiste.Properties.Resources.backg9;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.AjouterDent);
            this.groupBox1.Controls.Add(this.recherchDent);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 438);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Dents";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 319);
            this.dataGridView1.TabIndex = 1;
            // 
            // recherchDent
            // 
            this.recherchDent.Location = new System.Drawing.Point(836, 50);
            this.recherchDent.Name = "recherchDent";
            this.recherchDent.Size = new System.Drawing.Size(100, 20);
            this.recherchDent.TabIndex = 2;
            // 
            // listes_dents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 490);
            this.Controls.Add(this.panel4);
            this.Name = "listes_dents";
            this.Text = "listes_dents";
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AjouterDent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox recherchDent;
    }
}