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

    public partial class modifierproduit : UserControl
    {
        SqlConnection connection = DatabaseOperations.con;
        public modifierproduit()
        {
            InitializeComponent();
        }

        internal void modifierproduit_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                display_data();
            }
        }
        private void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "select * from produit";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
            dataadp.Fill(dta);
            bunifuCustomDataGrid1.DataSource = dta;
            connection.Close();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            connection.Open();
            int SelectedRow = e.RowIndex;
            if (SelectedRow != -1)
            {
                foreach (var tb in this.Controls.OfType<ns1.BunifuMaterialTextbox>())
                {
                    tb.Enabled = true;
                    tb.LineIdleColor = Color.FromArgb(225, 155, 45);
                    tb.LineMouseHoverColor = Color.FromArgb(225, 155, 45);
                }
                DataGridViewRow row = bunifuCustomDataGrid1.Rows[SelectedRow];
                TB_Reference.Text = row.Cells["reference"].Value.ToString();
                TB_Quantite.Text = row.Cells["quantite"].Value.ToString();
                TB_Prix.Text = row.Cells["prix"].Value.ToString();
                TB_Marque.Text = row.Cells["marque"].Value.ToString();
                TB_description.Text = row.Cells["description"].Value.ToString();
                int id = int.Parse(row.Cells["categorie"].Value.ToString());
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select nom from [categorie] where id = "+id+"";
                SqlDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    CB_categorie.Text = sr["nom"].ToString();
                }
                sr.Close();
                connection.Close();

            }
        }
        private void clear()
        {
            TB_Reference.Text = "";
            TB_description.Text = "";
            TB_Marque.Text = "";
            TB_Prix.Text = "";
            TB_Quantite.Text = "";
            CB_categorie.Text = "    Choisissez une catégorie";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void TB_Quantite_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int SelectedRow = bunifuCustomDataGrid1.SelectedRows[0].Index;
            string reference = bunifuCustomDataGrid1.Rows[SelectedRow].Cells["reference"].Value.ToString();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [produit] where reference = '" + reference + "'";
            cmd.ExecuteNonQuery();
            clear();
            connection.Close();
            display_data();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int SelectedRow = bunifuCustomDataGrid1.SelectedRows[0].Index;
            int id = int.Parse(bunifuCustomDataGrid1.Rows[SelectedRow].Cells["id_produit"].Value.ToString());
            connection.Open();
            int id_categ = 0;
            string reference = TB_Reference.Text;
            int quantite = int.Parse(TB_Quantite.Text);
            float prix = float.Parse(TB_Prix.Text);
            string marque = TB_Marque.Text;
            string description = TB_description.Text;
            string nom_categ = CB_categorie.Text;
            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select id from categorie where nom='" + nom_categ + "'";
            SqlDataReader sr = cmd1.ExecuteReader();
            while (sr.Read())
            {
                id_categ = int.Parse(sr["Id"].ToString());
            }
            sr.Close();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [produit] set reference='" + reference + "',quantite_stk=" + quantite + ",prix=" + prix + ",id_categorie= "+id_categ+",marque='" + marque + "',description='" + description + "' where id_produit=" + id + "";
            cmd.ExecuteNonQuery();
            clear();
            
            connection.Close();
            display_data();
        }

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
