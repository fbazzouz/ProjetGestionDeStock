﻿using System;
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
       

        public MainAgent(string Nom, string Prenom)
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!Main.Controls.Contains(Agent_UC.Livrer.Instance))
            {
                Main.Controls.Add(Agent_UC.Livrer.Instance);
                Agent_UC.Livrer.Instance.Dock = DockStyle.Fill;
                Agent_UC.Livrer.Instance.BringToFront();
            }
            else
                Agent_UC.Livrer.Instance.BringToFront();
        }
        

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!Main.Controls.Contains(Agent_UC.confirmer.Instance))
            {
                Main.Controls.Add(Agent_UC.confirmer.Instance);
                Agent_UC.confirmer.Instance.Dock = DockStyle.Fill;
                Agent_UC.confirmer.Instance.BringToFront();
            }
            else
                Agent_UC.confirmer.Instance.BringToFront();
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Authentification A = new Authentification();
            A.Show();
            Hide();
        }
    }
}
