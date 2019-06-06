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
    public partial class modifierPerso : UserControl
    {
        int SelectedIndex;
        public modifierPerso()
        {
            InitializeComponent();
          

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            BTN_Modifier.Visible = false;
            Btn_Supprimer.Visible = false;
            if (!DesignMode)
            {
                DataTable dta = DatabaseOperations.listerPerso();
                DG_personnel.DataSource = dta;
            }
        }
        private void BTN_AjouterCategorie_Click(object sender, EventArgs e)
        {
            if (DatabaseOperations.updatePerso(SelectedIndex+1, TB_nom.Text, TB_prenom.Text, TB_email.Text, TB_cin.Text, TB_login.Text, TB_password.Text, DD_role.selectedValue.ToString().ToLower()) == 1)
            {
                MetroFramework.MetroMessageBox.Show(this,"le Personnel est Modifier");
                DG_personnel.DataSource = null;
                DataTable dta = DatabaseOperations.listerPerso();
                DG_personnel.DataSource = dta;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Les informations ne sont pas corrects ");
            }
        }

        private void DG_personnel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedIndex = DG_personnel.SelectedRows[0].Index;
            TB_nom.Text = DG_personnel.Rows[SelectedIndex].Cells[1].Value.ToString();
            TB_prenom.Text = DG_personnel.Rows[SelectedIndex].Cells[2].Value.ToString();
            TB_email.Text = DG_personnel.Rows[SelectedIndex].Cells[3].Value.ToString();
            TB_cin.Text = DG_personnel.Rows[SelectedIndex].Cells[4].Value.ToString();
            TB_login.Text = DG_personnel.Rows[SelectedIndex].Cells[5].Value.ToString();
            TB_password.Text = DG_personnel.Rows[SelectedIndex].Cells[6].Value.ToString();
            string role=DG_personnel.Rows[SelectedIndex].Cells[6].Value.ToString();
            if (role == "admin") DD_role.selectedIndex = 0;
            else if (role == "agent") DD_role.selectedIndex = 1;
            else DD_role.selectedIndex = 2;
            DD_role.Enabled = true;
            DD_role.NomalColor = Color.FromArgb(225, 155, 45);
                foreach (var tb in this.Controls.OfType<ns1.BunifuMaterialTextbox>())
                {
                    tb.Enabled = true;
                    tb.LineIdleColor= Color.FromArgb(225, 155, 45);
                    tb.LineMouseHoverColor = Color.FromArgb(225, 155, 45);
                }
            Btn_Supprimer.Visible = true;
            BTN_Modifier.Visible= true;

        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (DatabaseOperations.deletePerso(SelectedIndex + 1)== 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "le Personnel est Supprimé");
                DG_personnel.DataSource = null;
                DataTable dta = DatabaseOperations.listerPerso();
                DG_personnel.DataSource = dta;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Les informations ne sont pas corrects ");
            }
        }
    }
}
