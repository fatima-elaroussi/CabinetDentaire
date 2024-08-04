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
    public partial class Utilisateur : Form
    {
        ADO d = new ADO();
        public Utilisateur()
        {
            InitializeComponent();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
           


            if (nomUtlisateur.Text == "" || login.Text == "" || Password.Text == "" )
            {
                MessageBox.Show("Il faut Remplir les champs obligatoire");
                return;
            }
            else
            {

                d.connecter();

                d.cmd.CommandText = "Insert into Utilisateu Values ('" + nomUtlisateur.Text + "','" + login.Text + "','" + Password.Text + "')";
                d.cmd.Connection = d.cn;
                d.cmd.ExecuteNonQuery();
                d.deconnecter();

                MessageBox.Show("L'enregistrement a été effectué");
            }


           
        }
    }
}
