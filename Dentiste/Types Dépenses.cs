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
    public partial class Types_Dépenses : Form
    {
        ADO d = new ADO();
        public Types_Dépenses()
        {
            InitializeComponent();
        }

        private void EnregistrerTypeDepenses_Click(object sender, EventArgs e)
        {
            if (desiTypDep.Text == "")
            {
                MessageBox.Show("Il faut Remplir les champs obligatoire");
                return;
            }
            else
                d.connecter();
            d.cmd.CommandText = "insert into TypeDepense values('" + desiTypDep.Text + "','" + obsTypDep.Text + "')";
            d.cmd.Connection = d.cn;
            d.cmd.ExecuteNonQuery();

            d.deconnecter();
            MessageBox.Show("L'enregistrement a été effectué");
        }
    }
}
