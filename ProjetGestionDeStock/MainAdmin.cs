using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionDeStock
{
    
    public partial class MainAdmin : Form
    {
       

        public MainAdmin(string Nom,string Prenom)
        {
            InitializeComponent();
            Lb_admin.Text = Nom + " " + Prenom;
        }

        private void Slider_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 50)
            {
                PanelMenu.Visible = false;
                PanelMenu.Width = 230;
                PanelAnimator2.ShowSync(PanelMenu);
                LogoAnimator.ShowSync(Lb_admin);
            }
            else
            {
                LogoAnimator.HideSync(Lb_admin);
                PanelMenu.Visible = false;
                PanelMenu.Width = 50;
                PanelAnimator.ShowSync(PanelMenu);
                
            }
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {
        
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e) //Ajouterunecategorie
        {
            if(!Main.Controls.Contains(Admin_UC.AjouterCategorie.Instance))
            {
                Main.Controls.Add(Admin_UC.AjouterCategorie.Instance);
                Admin_UC.AjouterCategorie.Instance.Dock = DockStyle.Fill;
                Admin_UC.AjouterCategorie.Instance.BringToFront();
            }
            else
                Admin_UC.AjouterCategorie.Instance.BringToFront();

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            dashboard2.BringToFront();
        }

        private void bunifuFlatButton3_Click_2(object sender, EventArgs e)
        {
            ajouterCategorie1.BringToFront();
            
        }
        private void ajouterCategorie_load(object sender, EventArgs e)
        {
           

        }

        private void dashboard2_Load(object sender, EventArgs e)
        {

        }
    }
}
