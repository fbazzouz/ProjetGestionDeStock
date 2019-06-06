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

    public partial class AjouterCategorie : UserControl
    {
       
        public AjouterCategorie()
        {
          InitializeComponent();
          
        }

        private void BTN_AjouterCategorie_Click(object sender, EventArgs e)
        {
            DatabaseOperations.AjouterNewCategorie(TF_NewCategorie.Text);
            DataTable dta = DatabaseOperations.Categories();
            DG_Categories.DataSource = dta;
            TF_NewCategorie.Text = "";

        }

        private void AjouterCategorie_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                DataTable dta = DatabaseOperations.Categories();
                DG_Categories.DataSource = dta;
            }
        }
    }
}