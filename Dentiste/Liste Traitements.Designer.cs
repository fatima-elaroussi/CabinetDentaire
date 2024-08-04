namespace Dentiste
{
    partial class Liste_Traitements
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recherchTrait = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AjouterTraitement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            // recherchTrait
            // 
            this.recherchTrait.Location = new System.Drawing.Point(836, 50);
            this.recherchTrait.Name = "recherchTrait";
            this.recherchTrait.Size = new System.Drawing.Size(100, 20);
            this.recherchTrait.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Dentiste.Properties.Resources.backg9;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.AjouterTraitement);
            this.groupBox1.Controls.Add(this.recherchTrait);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 427);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Traitements";
            // 
            // AjouterTraitement
            // 
            this.AjouterTraitement.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AjouterTraitement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterTraitement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AjouterTraitement.Image = global::Dentiste.Properties.Resources.ajouter;
            this.AjouterTraitement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouterTraitement.Location = new System.Drawing.Point(796, 19);
            this.AjouterTraitement.Name = "AjouterTraitement";
            this.AjouterTraitement.Size = new System.Drawing.Size(140, 23);
            this.AjouterTraitement.TabIndex = 4;
            this.AjouterTraitement.Text = "Ajouter";
            this.AjouterTraitement.UseVisualStyleBackColor = false;
            this.AjouterTraitement.Click += new System.EventHandler(this.AjouterTraitement_Click);
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
            this.panel4.Size = new System.Drawing.Size(1021, 476);
            this.panel4.TabIndex = 9;
            // 
            // Liste_Traitements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 476);
            this.Controls.Add(this.panel4);
            this.Name = "Liste_Traitements";
            this.Text = "Liste_Traitements";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AjouterTraitement;
        private System.Windows.Forms.TextBox recherchTrait;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
    }
}