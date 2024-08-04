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
    public partial class Traitements : Form
    {
        ADO d = new ADO();
        public Traitements()
        {
            InitializeComponent();
        }

        private void EnregistrerTraitement_Click(object sender, EventArgs e)
        { if(desiTraitement.Text=="" || MontantTrait.Text == "")
            {
                MessageBox.Show("il faut remplir les champs obligatoire");
            }
            else {
                d.connecter();
                d.cmd.CommandText = "insert into Traitement values('" + desiTraitement.Text + "','" + MontantTrait.Text + "','" + obsTrait.Text + "')";
                d.cmd.Connection = d.cn;
                d.cmd.ExecuteNonQuery();

                d.deconnecter();
                MessageBox.Show("l'enregistrement a été effectuè avec succés");
                desiTraitement.Clear();
                MontantTrait.Clear();
                obsTrait.Clear();
            }
            

        }
    }
}
