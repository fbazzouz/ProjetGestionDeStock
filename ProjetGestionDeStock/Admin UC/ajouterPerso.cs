﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionDeStock.Admin_UC
{
    public partial class ajouterPerso : UserControl
    {
        public ajouterPerso()
        {
            InitializeComponent();
          

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                DataTable dta = DatabaseOperations.listerPerso();
                DG_personnel.DataSource = dta;
            }
        }
        private void BTN_AjouterCategorie_Click(object sender, EventArgs e)
        {
            if (DatabaseOperations.AjouterNewPerso(TB_nom.Text, TB_prenom.Text, TB_email.Text, TB_cin.Text, TB_login.Text, TB_password.Text, DD_role.selectedValue.ToString().ToLower()) == 1)
            {
                MessageBox.Show("le Personnel est Ajouté");
                DG_personnel.DataSource = null;
                DataTable dta = DatabaseOperations.listerPerso();
                DG_personnel.DataSource = dta;
            }
        }

        private void TB_nom_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TB_prenom_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TB_email_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TB_login_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TB_cin_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TB_password_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
