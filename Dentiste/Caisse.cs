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
    public partial class Caisse : Form
    {
        public Caisse()
        {
            InitializeComponent();
        }

        private void Caiss_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Accueil_Click(object sender, EventArgs e)
        {
            Form1 accueil = new Form1();
            this.Hide();
            accueil.Show();
        }

        private void Patient_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();
            this.Hide();
            patient.Show();
        }

        private void RendezVous_Click(object sender, EventArgs e)
        {
            RendezVous rdv = new RendezVous();
            this.Hide();
            rdv.Show();
        }
    }
}
