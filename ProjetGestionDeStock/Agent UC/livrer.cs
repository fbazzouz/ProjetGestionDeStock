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
    public partial class Livrer : UserControl
    {

        private static Livrer _instance;
        public static Livrer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Livrer();
                return _instance;
            }
        }
        public Livrer()
        {
            InitializeComponent();
        }
        private void Livrer_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                DataTable dta = DatabaseOperations.produitsAlivrer();
                DG_livrer.DataSource = dta;
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DG_lastproduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_AjouterCategorie_Click(object sender, EventArgs e)
        {

        }
        private void DG_lastproduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedIndex = DG_livrer.SelectedRows[0].Index;

           
        }
    }
}
