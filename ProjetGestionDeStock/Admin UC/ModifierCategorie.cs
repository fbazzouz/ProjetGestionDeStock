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
        
        public ModifierCategorie()
        {
            InitializeComponent();
           
        }

        private void BTN_ModifierCategorie_Click(object sender, EventArgs e)
        {
            int SelectedIndex = DG_CategoriesM.SelectedRows[0].Index;
            int rowID = int.Parse(DG_CategoriesM.Rows[SelectedIndex].Cells["IdC"].Value.ToString());
            //Pour verifier si les champs textes sont vides 
            foreach (var tb in this.Controls.OfType<ns1.BunifuMaterialTextbox>())
            {
                if (tb.Text == "" && tb != TF_Recherche)
                {
                    tb.Focus();

                    MessageBox.Show(tb, "Le champ ne doit pas etre vide ex : " + tb.HintText);
                    return;
                }
            }
            ////////////////////////////////////////////////
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
            if (DD_Recherche.selectedValue == "Id")
            {  
                DataTable dta = DatabaseOperations.RechercherCategorieId(TF_Recherche.Text);
                DG_CategoriesM.DataSource = dta;
            }
            else if (DD_Recherche.selectedValue == "Nom")
            {
                DataTable dta = DatabaseOperations.RechercherCategorieNom(TF_Recherche.Text);
                DG_CategoriesM.DataSource = dta;
            }
        }

        internal void ModifierCategorie_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                DataTable dta = DatabaseOperations.Categories();
                DG_CategoriesM.DataSource = dta;
            }
        }



        private void DG_CategoriesM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedIndex = DG_CategoriesM.SelectedRows[0].Index;
            TF_ModifiedCategorie.Text = DG_CategoriesM.Rows[SelectedIndex].Cells["Nom"].Value.ToString();
            TB_ID.Text = DG_CategoriesM.Rows[SelectedIndex].Cells["IdC"].Value.ToString();
        }

    }
}
