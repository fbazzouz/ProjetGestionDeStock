using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionDeStock.Agent_UC
{
    public partial class confirmer : UserControl
    {

        private static confirmer _instance;
        public static confirmer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new confirmer();
                return _instance;
            }
        }

        public confirmer()
        {
            InitializeComponent();
        }

        internal void confirmer_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                DataTable dta = DatabaseOperations.produitslivre();
                DG_livrer.DataSource = dta;
                
            }
        }

        private void DG_livrer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DG_livrer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedIndex = DG_livrer.SelectedRows[0].Index;
            etat.Text = DG_livrer.Rows[SelectedIndex].Cells[3].Value.ToString();
        }

        private void BTN_AjouterCategorie_Click(object sender, EventArgs e)
        {
            int SelectedIndex = DG_livrer.SelectedRows[0].Index;
            etat.Text = DG_livrer.Rows[SelectedIndex].Cells[3].Value.ToString();
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
            DatabaseOperations.ModifierCategorie(SelectedIndex, etat.Text);
        }
    }
}
