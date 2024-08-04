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
    public partial class ModifierPatient : Form
    {
        ADO d = new ADO();
        string age;
        string assurance;
        string sexe;

        public ModifierPatient()
        {
            InitializeComponent();
        }

        private void ModifierPatient_Load(object sender, EventArgs e)
        {
            typeAssurance.Items.Add("Mutuel");
            typeAssurance.Items.Add("CNOPS");
            typeAssurance.Items.Add("CNSS");

            d.connecter();
            d.cmd.CommandText = "select* from Patient where nDossier='" + Patients.idPatient + "'";
            d.cmd.Connection = d.cn;
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                nomPa.Text = d.dr["nom_patient"].ToString();
                prenomPa.Text = d.dr["prenom_patient"].ToString();
                cinPa.Text = d.dr["cin_patient"].ToString();
                if (d.dr["age_patient"].ToString() == "Adulte")
                { radioButton2.Checked = true; }
                else radioButton1.Checked = true;
                if (d.dr["sexe_patient"].ToString() == "Féminin")
                { féminin.Checked = true; }
                else masculin.Checked = true;
                adressePa.Text = d.dr["adresse_patient"].ToString();
                telePa.Text = d.dr["tele_patient"].ToString();
                fixePa.Text = d.dr["fixe_patient"].ToString();
                emailPa.Text = d.dr["email_patient"].ToString();
                dateNaissance.Value = (DateTime)d.dr["dateNaissance"];
                if (d.dr["assurance"].ToString() == "Non")
                { non.Checked = true; }
                else oui.Checked = true;
                typeAssurance.Text = d.dr["typeAssurance"].ToString();
                obsPa.Text = d.dr["obs"].ToString();

              
            }
            d.dr.Close();
            d.deconnecter();
        }

        private void EnregistrerPatient_Click(object sender, EventArgs e)
        {
            if (nomPa.Text == "" || prenomPa.Text == "" || age == "" || sexe == "" || telePa.Text == "" || assurance == "")
            {
                MessageBox.Show("Il faut Remplir les champs obligatoire");
                return;
            }
            else
                d.connecter();
            d.cmd.CommandText = "Update Patient set  nom_patient='" + nomPa.Text + "',prenom_patient='" + prenomPa.Text + "',cin_patient='" + cinPa.Text + "',age_patient='" + age + "',sexe_patient='" + sexe + "',adresse_patient='" + adressePa.Text + "',tele_patient='" + telePa.Text + "',fixe_patient='" + fixePa.Text + "',email_patient='" + emailPa.Text + "',dateNaissance='" + dateNaissance.Value + "',assurance='" + assurance + "',typeAssurance='" + typeAssurance.SelectedItem + "',obs='" + obsPa.Text + "',date_dossier=getdate()where nDossier='" + Patients.idPatient + "'";
            d.cmd.Connection = d.cn;
            d.cmd.ExecuteNonQuery();
            d.deconnecter();
            MessageBox.Show("la modification a été effectué");
            this.Hide();

           
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            age = "Adulte";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            age = "Enfant";

        }

        private void Masculin_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "Masculin";
        }

        private void Féminin_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "Féminin";

        }

        private void Oui_CheckedChanged(object sender, EventArgs e)
        {
            assurance = "Oui";
           
            typeAssurance.Visible = true;
        }

        private void Non_CheckedChanged(object sender, EventArgs e)
        {
            assurance = "Non";
        }
    }

}