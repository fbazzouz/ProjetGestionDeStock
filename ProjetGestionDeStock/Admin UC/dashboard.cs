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
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
           DataTable dta = DatabaseOperations.produitsVendu();
           DG_lastproduit.DataSource = dta;
            int totalvendu = DatabaseOperations.totatVendre();
            produitsVendu.Text = totalvendu.ToString()+"Dh";
            circleVendu.MaxValue = DatabaseOperations.totatDisponible()+ totalvendu;
            circleVendu.Value = totalvendu;

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
