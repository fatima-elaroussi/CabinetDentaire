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
    public partial class Medcin : Form
    {
        ADO d = new ADO();
        public Medcin()
        {
            InitializeComponent();
        }

        private void EnregistrerMedcin_Click(object sender, EventArgs e)
        {
            if (nomMed.Text == "" || prenomMed.Text == "" || teleMed.Text == "" )
            {
                MessageBox.Show("Il faut Remplir les champs obligatoire");
                return;
            }
            else
                d.connecter();
            d.cmd.CommandText = "Insert into Medcin Values ('" + nomMed.Text + "','" + prenomMed.Text + "','" + cinMed.Text + "','" + adresseMed.Text + "','" + teleMed.Text + "','" + fixeMed.Text + "','" + emailMed.Text + "','" + obsMed.Text + "')";
            d.cmd.Connection = d.cn;
            d.cmd.ExecuteNonQuery();
            d.deconnecter();
            MessageBox.Show("L'enregistrement a été effectué");
            Nouveau_patient.ClearFormControls(this);


            


        }
    }
}
