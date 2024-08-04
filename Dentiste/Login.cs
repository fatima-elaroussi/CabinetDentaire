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
    public partial class Login : Form
    {
        ADO d = new ADO();
        int cpt = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            cpt++;
            if(cpt%2!=0)
            password.PasswordChar = '\0';
            else
                password.PasswordChar = '*';

        }

        private void Connecter_Click(object sender, EventArgs e)
        {
            
                d.connecter();
                d.cmd.CommandText = "select* from Utilisateu";
                d.cmd.Connection = d.cn;
                d.dr = d.cmd.ExecuteReader();
                //d.dt.Load(d.dr);

                while (d.dr.Read())
                {
                try
                {
                    if (d.dr[1].ToString() == txtbLogin.Text && d.dr[2].ToString() == password.Text)
                    {
                        Menu m = new Menu();
                        m.Show();

                    }
                    else MessageBox.Show("mot de passe ou login est incorrecte ");
                }
                catch
                {
                    MessageBox.Show("mot de passe ou login est incorrecte ");
                }



            }
            d.dr.Close();
                d.deconnecter();
            this.Hide();

        }

        private void Login_Load(object sender, EventArgs e)
        {
           // panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
          //  panel2.BackColor= Color.FromArgb(100, 0, 0, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
