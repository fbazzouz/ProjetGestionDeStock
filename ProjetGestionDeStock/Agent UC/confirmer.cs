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

        private void confirmer_Load(object sender, EventArgs e)
        {

        }
    }
}
