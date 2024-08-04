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
    public partial class Patients : Form
    {
        public static int idPatient;
        public static bool modifier = false;
        public static bool ajouter = false;

        ADO d = new ADO();
        public  void afficherPatient()
        {
            d.connecter();
            d.cmd.CommandText = "Select * from Patient";
            d.cmd.Connection = d.cn;
            d.dr = d.cmd.ExecuteReader();
             while (d.dr.Read())
            {
                dataGridPatient.Rows.Add(d.dr[1], d.dr[2], d.dr[0], d.dr[14], d.dr[7]);
            }
            d.deconnecter();
        }
        public Patients()
        {
            InitializeComponent();
        }




        private void Ajouter_Click(object sender, EventArgs e)
        {
            ajouter = true;

            Nouveau_patient nvPatient = new Nouveau_patient();


            nvPatient.Show();

        }

        private void Patients_Load(object sender, EventArgs e)
        {

            afficherPatient();
            

        }

        private void RdvPatient_Click(object sender, EventArgs e)
        {
            idPatient = Convert.ToInt32(dataGridPatient.Rows[dataGridPatient.CurrentRow.Index].Cells[2].Value);
            Nouveau_Rendez_Vous nv = new Nouveau_Rendez_Vous();
            nv.Show();

        }

        private void BtnRechercherPat_Click(object sender, EventArgs e)
        {   
            dataGridPatient.Rows.Clear();
            d.connecter();
            d.cmd.CommandText = "select * from Patient where nom_patient='" + recherchPatient.Text + "' or prenom_patient='" + recherchPatient.Text + "'  or tele_patient='" + recherchPatient.Text + "'or nDossier = " + recherchPatient.Text ;
            //'
            d.cmd.Connection = d.cn;
            d.dr = d.cmd.ExecuteReader();
            //if (d.dr.HasRows)
            //{
            while (d.dr.Read())
            {
                dataGridPatient.Rows.Add(d.dr[1], d.dr[2], d.dr[0], d.dr[14], d.dr[7]);
            }
           // d.dr.Close();
            d.deconnecter();
        }
        //else MessageBox.Show("Ce patient n'existe pas");

        //d.da = new System.Data.SqlClient.SqlDataAdapter("select * from Patient where nom_patient='" + recherchPatient.Text.ToString() + "' or prenom_patient='" + recherchPatient.Text.ToString() + "' or nDossier='" + Convert.ToInt32(recherchPatient.Text) + "'  or tele_patient='" + recherchPatient.Text.ToString() + "'", d.cn);
        //d.da.Fill(d.ds, "patient");
        //dataGridPatient.Rows.Add ( d.ds.Tables["patient"]);

       
            
        private void Modifier_Click(object sender, EventArgs e)
        {
            modifier = true;
            idPatient = Convert.ToInt32(dataGridPatient.Rows[dataGridPatient.CurrentRow.Index].Cells[2].Value);
            ModifierPatient mdfP = new ModifierPatient();
            mdfP.Show();

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            idPatient = Convert.ToInt32(dataGridPatient.Rows[dataGridPatient.CurrentRow.Index].Cells[2].Value);
            DialogResult cnf = MessageBox.Show("voulez vous vraiment suprimer ce patient ?","message",MessageBoxButtons.OKCancel);
            if(cnf== DialogResult.OK)
            {
                d.connecter();
                d.cmd.CommandText = "delete  from Patient where nDossier='"+idPatient+"'";
                d.cmd.Connection = d.cn;
                d.cmd.ExecuteNonQuery();
                d.deconnecter();
                MessageBox.Show("vouz avez supprimer ce patinet");
                afficherPatient();

            }


        }

        private void RecherchPatient_TextChanged(object sender, EventArgs e)
        {
            if(recherchPatient.Text == "")
            {
                dataGridPatient.Rows.Clear();
                afficherPatient();
            }
        }
    }

   
    
}
