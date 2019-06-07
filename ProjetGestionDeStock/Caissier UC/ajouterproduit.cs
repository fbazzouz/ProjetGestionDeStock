using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionDeStock
{
    public partial class ajouterproduit : UserControl
    {
        SqlConnection connection = DatabaseOperations.con;
        public ajouterproduit()
        {
            InitializeComponent();
        }

        private void ajouterproduit_Load(object sender, EventArgs e)
        {
            
        }
        

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
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
            connection.Open();
            string reference = TB_Reference.Text;
            int quantite = int.Parse(TB_Quantite.Text);
            float prix = float.Parse(TB_Prix.Text);
            string marque = TB_Marque.Text;
            string description = TB_description.Text;
            string nom_categ = CB_categorie.Text;
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [produit] (reference,quantite_stk,prix,id_categorie,marque,description) values ('"+reference+"',"+quantite+","+prix+",1,'"+marque+"','"+description+"')";
            cmd.ExecuteNonQuery();
            clear();
            connection.Close();
        }

        private void ajouterproduit_Load_1(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Nom from categorie";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    CB_categorie.Items.Add(dr["Nom"].ToString());
                }
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
