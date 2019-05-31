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
    
    public partial class MainUser : Form
    {
       

        public MainUser()
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
                LogoAnimator.ShowSync(PB_logo);
            }
            else
            {
                LogoAnimator.HideSync(PB_logo);
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
    }
}
