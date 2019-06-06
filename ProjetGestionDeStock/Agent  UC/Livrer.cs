using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionDeStock.Agent__UC
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
            DataTable dta = DatabaseOperations.produitsAlivrer();
            DG_livrer.DataSource = dta;
        }

        private void DG_livrer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
