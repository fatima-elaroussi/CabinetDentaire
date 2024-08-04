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
    public partial class Nouveau_patient : Form
    {
        ADO d = new ADO();
        string age;
        string assurance;
        string sexe;
        public static void ClearFormControls(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Text = string.Empty;
                }
                else if (control is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)control;
                    chkbox.Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)control;
                    rdbtn.Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
            }
        }


        public Nouveau_patient()
        {
            InitializeComponent();
        }

      

        

        private void Enregistrer_Click(object sender, EventArgs e)
        { 

          

                if (nomPa.Text == "" || prenomPa.Text == "" || age == "" || sexe == "" || telePa.Text == "" || assurance == "")
                {
                    MessageBox.Show("Il faut Remplir les champs obligatoire");
                    return;
                }
                else
                    d.connecter();
                d.cmd.CommandText = "Insert into Patient Values ('" + nomPa.Text + "','" + prenomPa.Text + "','" + cinPa.Text + "','" + age + "','" + sexe + "','" + adressePa.Text + "','" + telePa.Text + "','" + fixePa.Text + "','" + emailPa.Text + "','" + dateNaissance.Value + "','" + assurance + "','" + typeAssurance.SelectedItem +"','" + obsPa.Text + "',getdate())";
                d.cmd.Connection = d.cn;
            d.cmd.ExecuteNonQuery();
            
                MessageBox.Show("L'enregistrement a été effectué");

            d.deconnecter();


            Patients patient = new Patients();
            this.Hide();
            Menu m = new Menu();

            patient.Show();

        }

        private void Oui_CheckedChanged(object sender, EventArgs e)
        {
            assurance = "Oui";
            type_assu.Visible = true;
            typeAssurance.Visible = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            age = "Adulte";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            age = "Enfant";

        }

        private void Non_CheckedChanged(object sender, EventArgs e)
        {
            assurance = "Non";

        }

        private void Masculin_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "Masculin";
        }

        private void Féminin_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "Féminin";

        }

        private void Nouveau_patient_Load(object sender, EventArgs e)
        {
            typeAssurance.Items.Add("Mutuel");
            typeAssurance.Items.Add("CNOPS");
            typeAssurance.Items.Add("CNSS");
           
             
              

            }


        }
    }
