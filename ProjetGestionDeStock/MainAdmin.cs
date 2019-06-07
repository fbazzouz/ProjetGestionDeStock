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
          
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            dashboard2.BringToFront();
        }

        private void bunifuFlatButton3_Click_2(object sender, EventArgs e)
        {
            ajouterCategorie1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            modifierCategorie1.ModifierCategorie_Load(null, null);
            modifierCategorie1.BringToFront();
        }

        private void bunifuFlatButton6_Click_1(object sender, EventArgs e)
        {
            ajouterPerso1.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            modifierPerso1.BringToFront();
        }
        private void ajouterCategorie_load(object sender, EventArgs e)
        {
           

        }

        private void dashboard2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ajouterproduit1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            modifierproduit1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
