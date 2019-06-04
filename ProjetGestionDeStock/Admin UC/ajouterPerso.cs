using System;
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
            DataTable dta = DatabaseOperations.produitsVendu();
            DG_lastproduit.DataSource = dta;
            DataTable dta2 = DatabaseOperations.faibleStock(bunifuSlider1.Value);
            DG_faiblestock.DataSource = dta2;
            int totalvendu = DatabaseOperations.totatVendre();
            produitsVendu.Text = totalvendu.ToString() + "Dh";
            circleVendu.MaxValue = DatabaseOperations.totatDisponible() + totalvendu;
            circleVendu.Value = totalvendu;
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            seuil.Text = "Seuil : " + bunifuSlider1.Value.ToString();
            DG_faiblestock.DataSource = null;
            DataTable dta2 = DatabaseOperations.faibleStock(bunifuSlider1.Value);
            DG_faiblestock.DataSource = dta2;
        }
    }
}
