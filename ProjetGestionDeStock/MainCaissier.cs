using System;
using System.Windows.Forms;

namespace ProjetGestionDeStock
{

    public partial class MainCaissier : Form
    {
        
       

        public MainCaissier()
        {
            InitializeComponent();
        }

        private void Slider_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 50)
            {
                PanelMenu.Visible = false;
                PanelMenu.Width = 230;
                PanelAnimator2.ShowSync(PanelMenu);
             //   LogoAnimator.ShowSync(PB_logo);
                
            }
            else
            {
             //   LogoAnimator.HideSync(PB_logo);
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

        private void ajouterproduit1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ajouterproduit1.ajouterproduit_Load_1(null, null);
            ajouterproduit1.BringToFront();

        }

        private void modifierproduit1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            modifierproduit1.modifierproduit_Load(null, null);
            modifierproduit1.BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            lister1.lister_Load(null, null);
            lister1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            ajouterCommande1.ajouterCommande_Load(null, null);
            ajouterCommande1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
