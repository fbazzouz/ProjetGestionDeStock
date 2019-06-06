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
    
    public partial class MainAgent : Form
    {
       

        public MainAgent()
        {
            InitializeComponent();
            Agent__UC.Livrer.Instance.BringToFront();
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!Main.Controls.Contains(Agent__UC.Livrer.Instance))
            {
                Main.Controls.Add(Agent__UC.Livrer.Instance);
                Agent__UC.Livrer.Instance.Dock = DockStyle.Fill;
                Agent__UC.Livrer.Instance.BringToFront();
            }
            else
                Agent__UC.Livrer.Instance.BringToFront();
        }
        

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!Main.Controls.Contains(Agent__UC.confirmer.Instance))
            {
                Main.Controls.Add(Agent__UC.confirmer.Instance);
                Agent__UC.confirmer.Instance.Dock = DockStyle.Fill;
                Agent__UC.confirmer.Instance.BringToFront();
            }
            else
                Agent__UC.confirmer.Instance.BringToFront();
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
