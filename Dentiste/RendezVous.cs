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
    public partial class RendezVous : Form
    {
        ADO d = new ADO();
        public RendezVous()
        {
            InitializeComponent();
        }

        private void RendezVous_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = " select nom_patient,prenom_patient,dateRndv,heurRndv,Traitement,dent,montant_traitm from RendezVous r,Patient p,Traitement t where p.nDossier= r.Ndossier and r.traitement=t.desi_traitm";
            d.cmd.Connection = d.cn;
            d.dr = d.cmd.ExecuteReader();
            //d.dt.Load(d.dr);
            //dataGridRendezVous.DataSource = d.dt;
            //d.deconnecter();
            while (d.dr.Read())
            {
                dataGridRendezVous.Rows.Add( d.dr[0], d.dr[1], d.dr[2], d.dr[3], d.dr[4], d.dr[5], d.dr[6]);
            }
            d.dr.Close();
            d.deconnecter();
        }

        private void AjouterRendezVous_Click(object sender, EventArgs e)
        {
          
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AjouterRendezVous_Click_1(object sender, EventArgs e)
        {
            Nouveau_Rendez_Vous nv = new Nouveau_Rendez_Vous();
            nv.Show();
        }
    }
}
