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
    public partial class ModifierCategorie : UserControl
    {
        private static ModifierCategorie _instance;
        public static ModifierCategorie Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ModifierCategorie();
                return _instance;
            }
        }
        public ModifierCategorie()
        {
            InitializeComponent();
            DataTable dta = DatabaseOperations.Categories();
            DG_CategoriesM.DataSource = dta;
        }

        private void BTN_ModifierCategorie_Click(object sender, EventArgs e)
        {
            int SelectedIndex = DG_CategoriesM.SelectedRows[0].Index;
            int rowID = int.Parse(DG_CategoriesM.Rows[SelectedIndex].Cells["IdC"].Value.ToString());
            DatabaseOperations.ModifierCategorie(rowID,TF_ModifiedCategorie.Text);

            DataTable dta = DatabaseOperations.Categories();
            DG_CategoriesM.DataSource = dta;
            TF_ModifiedCategorie.Text = "";
        }

        private void BTN_SupprimerCategorie_Click(object sender, EventArgs e)
        {
            int SelectedIndex = DG_CategoriesM.SelectedRows[0].Index;
            int rowID = int.Parse(DG_CategoriesM.Rows[SelectedIndex].Cells["IdC"].Value.ToString());
            DatabaseOperations.SupprimerCategorie(rowID);

            DataTable dta = DatabaseOperations.Categories();
            DG_CategoriesM.DataSource = dta;
        }

        private void TF_Recherche_OnValueChanged(object sender, EventArgs e)
        {
            if(DD_Recherche.selectedIndex == 0)
            {
                DatabaseOperations.RechercherCategorieId(TF_Recherche.Text);
                DataTable dta = DatabaseOperations.Categories();
                DG_CategoriesM.DataSource = dta;
            }
            else if(DD_Recherche.selectedIndex == 1)
            {
                DatabaseOperations.RechercherCategorieNom(TF_Recherche.Text);
                DataTable dta = DatabaseOperations.Categories();
                DG_CategoriesM.DataSource = dta;

            }
        }

        private void ModifierCategorie_Load(object sender, EventArgs e)
        {

        }
    }
}
