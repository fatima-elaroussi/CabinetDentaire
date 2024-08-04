using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dentiste
{
    public partial class Nouveau_Rendez_Vous : Form
    {
        ADO d = new ADO();
        public Nouveau_Rendez_Vous()
        {
            InitializeComponent();
        }

        private void EnregistrerRendezVous_Click(object sender, EventArgs e)
        {
            int idMedcin=0;
            d.connecter();

            d.cmd.CommandText = " select N_medcin from Medcin  where nom_medcin='"+medcinRdv.Text+"'"  ;
            d.cmd.Connection = d.cn;
            d.dr= d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                idMedcin = Convert.ToInt32( d.dr[0].ToString()) ;
            }

            d.deconnecter();


            if (dateRdv.Text == "" || medcinRdv.Text == ""  || traitemantRdv.Text == "" || dentRdv.Text == "")
            {
                MessageBox.Show("Il faut Remplir les champs obligatoire");
                return;
            }
            else {

                d.connecter();

                d.cmd.CommandText = "Insert into RendezVous Values ('" + Patients.idPatient + "','" + dentRdv.Text + "','" + traitemantRdv.Text + "','" + dateRdv.Value + "',"+ idMedcin + ",'" + heureRdv.Text + "','" + motifRendez.Text + "','" + obsRendez.Text + "')";
                d.cmd.Connection = d.cn;
                d.cmd.ExecuteNonQuery();
                d.deconnecter();

                MessageBox.Show("L'enregistrement a été effectué");
            }
           

            RendezVous rdv = new RendezVous();
            
           

            rdv.Show();
            
        }

        private void Nouveau_Rendez_Vous_Load(object sender, EventArgs e)
        {

            d.connecter();

            d.cmd.CommandText = "select * from Dent ";
            d.cmd.Connection = d.cn;
            d.dr = d.cmd.ExecuteReader();
            dentRdv.Items.Clear();
            while (d.dr.Read())
            {
                dentRdv.Items.Add(d.dr[0].ToString());
            }
            d.dr.Close();
            d.deconnecter();

            d.connecter();

            d.cmd.CommandText = "select * from Medcin ";
            d.cmd.Connection = d.cn;
            d.dr = d.cmd.ExecuteReader();
            medcinRdv.Items.Clear();

            while (d.dr.Read())
            {
              medcinRdv.Items.Add(d.dr[1].ToString());
            }
            d.dr.Close();

            d.deconnecter();
            d.connecter();
            d.cmd.CommandText = "select * from Traitement ";
            d.cmd.Connection = d.cn;
            d.dr = d.cmd.ExecuteReader();

            while (d.dr.Read())
            {
               traitemantRdv.Items.Add(d.dr[0].ToString());
               
            }
            d.dr.Close();

            d.deconnecter();

        }

        private void TraitemantRdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select montant_traitm from Traitement where  desi_traitm='"+traitemantRdv.SelectedItem +"'";
            d.cmd.Connection = d.cn;
            d.dr = d.cmd.ExecuteReader();
            

            while (d.dr.Read())
            {
                
                Montant.Text = d.dr[0].ToString();
            }
            d.dr.Close();

            d.deconnecter();
        }
    }
}
