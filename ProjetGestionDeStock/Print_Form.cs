using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionDeStock
{
    public partial class Print_Form : Form
    {
        public Print_Form()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalFacture rpt = new CrystalFacture();
            ajouterCommande LBE = new ajouterCommande();
            DataSet dscompt = new DataSet();
            dscompt = LBE.returndata();
            rpt.SetDataSource(dscompt.Tables["FactureCompt"]);
            this.crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();
        }
    }
}
