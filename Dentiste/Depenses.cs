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
    public partial class Depenses : Form
    {
        ADO d= new ADO();
        string typePaiment;
        public Depenses()
        {
            InitializeComponent();
        }

        private void EnregistrerDepense_Click(object sender, EventArgs e)
        {
            if (typeDepense.Text == "" || montantDepense.Text == ""  ||  dateDepense.Text == "" )
            {
                MessageBox.Show("Il faut Remplir les champs obligatoire");
                return;
            }
            else
                d.connecter();
            d.cmd.CommandText = "Insert into Depense Values ('" + typeDepense.Text + "','" + montantDepense.Text + "','" + dateDepense.Value + "','" + typePaiment + "','" + obsDepense.Text + "')";
            d.cmd.Connection = d.cn;
            d.cmd.ExecuteNonQuery();
            MessageBox.Show("L'enregistrement a été effectué");
        }

        private void Especes_CheckedChanged(object sender, EventArgs e)
        {
            typePaiment = "Especes";
        }

        private void Virement_CheckedChanged(object sender, EventArgs e)
        {
            typePaiment = "Virement";

        }

        private void Depenses_Load(object sender, EventArgs e)
        {
            d.connecter();

            d.cmd.CommandText = "select * from TypeDepense ";
            d.cmd.Connection = d.cn;
            d.dr = d.cmd.ExecuteReader();
            typeDepense.Items.Clear();
            while (d.dr.Read())
            {
                typeDepense.Items.Add(d.dr[0].ToString());
            }
            d.dr.Close();
            d.deconnecter();

        }
    }
}
