using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetGestionDeStock
{
    public partial class lister : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Source\Repos\fbazzouz\ProjetGestionDeStock\ProjetGestionDeStock\stockbd.mdf;Integrated Security=True");
        public lister()
        {
            InitializeComponent();
        }

        private void lister_Load(object sender, EventArgs e)
        {
            display_data();
        }
        private void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [produit]";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
            dataadp.Fill(dta);
            bunifuCustomDataGrid1.DataSource = dta;
            connection.Close();
        }

        

        private void TB_recherche_TextChanged(object sender, EventArgs e)
        {
            if (CB_recherche.Text == "Référence")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [produit] where reference ='"+TB_recherche.Text+"'";
                DataTable dt = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
                dataadp.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
                connection.Close();
            }
            if (CB_recherche.Text == "Marque")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [produit] where marque ='" + TB_recherche.Text + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
                dataadp.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(System.Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            excel.Visible = true;
            worksheet = workbook.ActiveSheet;

            worksheet.Name = "Liste des Clients";
           
            worksheet.Cells[1, 2] = "Référence";
            worksheet.Cells[1, 3] = "Quantité";
            worksheet.Cells[1, 4] = "Prix";
            worksheet.Cells[1, 5] = "Marque";
            worksheet.Cells[1, 6] = "Description";
            for (int j = 2; j <= bunifuCustomDataGrid1.Rows.Count; j++)
            {
                for (int i = 2; i <= 6; i++)
                {
                    worksheet.Cells[j, i].Value= bunifuCustomDataGrid1.Rows[j - 2].Cells[i - 1].Value;
                    worksheet.Columns.AutoFit();
                }

            }
        }
    }
}
