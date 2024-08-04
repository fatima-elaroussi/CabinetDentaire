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
    public partial class Dents : Form
    {
        ADO d = new ADO();
        public Dents()
        {
            InitializeComponent();
        }

        private void EnregistrerDepense_Click(object sender, EventArgs e)
        {
            if (desiDent.Text == ""  )
            {
                MessageBox.Show("Il faut Remplir les champs obligatoire");
                return;
            }
            else
                d.connecter();
            d.cmd.CommandText = "insert into Dent values('"+desiDent.Text +"','"+obsDent.Text+"')";
            d.cmd.Connection = d.cn;
            d.cmd.ExecuteNonQuery();
            
            d.deconnecter();
            MessageBox.Show("L'enregistrement a été effectué");

        }
    }
}
