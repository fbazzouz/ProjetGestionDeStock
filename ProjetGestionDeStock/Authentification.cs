using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionDeStock
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }

        private void Connecter_Click(object sender, EventArgs e)
        {
            SqlDataReader sdr=DatabaseOperations.LoginIsCorrect(Tb_login.Text, Tb_mdp.Text);
            if (sdr.Read())
            {
                if (sdr[0].ToString() == "admin")
                {
                    string Nom = sdr[1].ToString(),Prenom= sdr[2].ToString();
                    sdr.Close();
                    MainAdmin mainAdmin = new MainAdmin(Nom, Prenom);
                    mainAdmin.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Votre Login est inccorect");
                sdr.Close();
            }
            
            DatabaseOperations.closeCon();
        }
    }
}
