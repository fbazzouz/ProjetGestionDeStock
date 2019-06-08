using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

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
            //Pour verifier si les champs textes sont vides 
            foreach (var tb in this.Controls.OfType<ns1.BunifuMaterialTextbox>())
            {
                if (tb.Text == "")
                {
                    tb.Focus();

                    MessageBox.Show(tb, "Le champ ne doit pas etre vide ex : " + tb.HintText);
                    return;
                }
            }
            ////////////////////////////////////////////////
            DatabaseOperations.AjouterNewCategorie(TF_NewCategorie.Text);
            DataTable dta = DatabaseOperations.Categories();
            DG_Categories.DataSource = dta;
            TF_NewCategorie.Text = "";

        }

        internal void AjouterCategorie_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                DataTable dta = DatabaseOperations.Categories();
                DG_Categories.DataSource = dta;
            }
        }
    }
}
