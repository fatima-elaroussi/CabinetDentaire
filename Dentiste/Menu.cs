using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentiste
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AccueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.IsMdiContainer = true;
          
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
           
        }

        private void PatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

           Patients p = new Patients();
           p.MdiParent = this;
            p.Show();
          
        }

        private void RendezVousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

           RendezVous rdv = new RendezVous();
           rdv.MdiParent = this;
            

            rdv.Show();
        }

        private void CaisseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

           Caisse c = new Caisse();
           c.MdiParent = this;
            

            c.Show();
        }

        private void DepensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Depenses d = new Depenses();
            d.MdiParent = this;
           

            d.Show();
        }

        private void TraitementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Traitements t = new Traitements();
            t.MdiParent = this;


            t.Show();
        }

        private void DentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Dents dn = new Dents();
            dn.MdiParent = this;


            dn.Show();
        }

        private void MedcinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Medcin md = new Medcin();
            md.MdiParent = this;


            md.Show();
        }

        private void TypesDépensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Types_Dépenses td = new Types_Dépenses();
            td.MdiParent = this;


            td.Show();
        }

        private void UtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Utilisateur u = new Utilisateur();
           u.MdiParent = this;


            u.Show();
        }

        
    }
}
