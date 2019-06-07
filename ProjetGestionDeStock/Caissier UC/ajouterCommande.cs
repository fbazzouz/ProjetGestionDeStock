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
    public partial class ajouterCommande : UserControl
    {
        SqlConnection connection = DatabaseOperations.con;
        public ajouterCommande()
        {
            InitializeComponent();
            TB_marque.Enabled = false;
            TB_quantite.Enabled = false;
            TB_prix.Enabled = false;
            TB_facture_N.Enabled = false;
            button_ajouterClient.Visible = false;
            button_validerCommande.Visible = false;
            TB_nom.Enabled = false;
            CB_reference.Enabled = false;
            button_ajouterProduit.Visible = false;
            TB_prenom.Enabled = false;
            TB_Adresse.Enabled = false;
            TB_CIN.Enabled = false;
            TB_Email.Enabled = false;
            color();
        }

        internal void ajouterCommande_Load(object sender, EventArgs e)
        {
            
            if (!DesignMode)
            {
                display_data();
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select reference from produit";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    CB_reference.Items.Add(dr["reference"].ToString());
                }
                connection.Close();
            }
        }
        private void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from facture";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
            dataadp.Fill(dta);
            bunifuCustomDataGrid1.DataSource = dta;
            connection.Close();
        }
        private void CB_reference_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produit where reference = '" +CB_reference.Text+"'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                TB_prix.Text = sr["prix"].ToString();
                TB_quantite.Text = sr["quantite_stk"].ToString();
                TB_marque.Text = sr["marque"].ToString();
            }
            sr.Close();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            button2.Visible = false;
            TB_nom.Enabled = true;
            TB_prenom.Enabled = true;
            TB_Email.Enabled = true;
            TB_CIN.Enabled = true;
            TB_Adresse.Enabled = true;
            button_ajouterClient.Visible = true;
            MessageBox.Show("La facture est créée, Veuillez ajouter votre client");
            TB_total.Enabled = false;
            DP.Enabled = false;
            CB_status.Enabled = false;
            color();
           
        }

        private void button_ajouterClient_Click(object sender, EventArgs e)
        {

            //Pour verifier si les champs textes sont vides 
            ns1.BunifuMaterialTextbox[] TBtable = new ns1.BunifuMaterialTextbox[5];
            TBtable[0] = TB_nom;
            TBtable[1] = TB_prenom;
            TBtable[2] = TB_Email;
            TBtable[3] = TB_Adresse;
            TBtable[4] = TB_CIN;
            foreach (var tb in TBtable)
            {
                if (tb.Text == "")
                {
                    tb.Focus();

                    MessageBox.Show(tb, "Le champ ne doit pas etre vide ex : " + tb.HintText);
                    return;
                }
            }
            ////////////////////////////////////////////////
            string nom = TB_nom.Text;
            string prenom = TB_prenom.Text;
            string Email = TB_Email.Text;
            string CIN = TB_CIN.Text;
            string Adresse = TB_Adresse.Text;
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into client (nom,prenom,email,CIN,adresse) values ('"+nom+"','"+prenom+"','"+Email+"','"+CIN+"','"+Adresse+"')";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("votre client est créé, Veuillez ajouter vos produits");
            button_ajouterProduit.Visible = true;
            TB_marque.Enabled = true;
            TB_quantite.Enabled = true;
            TB_prix.Enabled = true;
            CB_reference.Enabled = true;
            TB_nom.Text = "";
            TB_prenom.Text = "";
            TB_Email.Text = "";
            TB_CIN.Text = "";
            TB_Adresse.Text = "";
            string status = CB_status.Text;
            float Total = float.Parse(TB_total.Text);
           
            string date = ((DateTime)DP.Value).ToString("yyyy.MM.dd");
            int id_client = 0;
            connection.Open();
            SqlCommand cmd4 = connection.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select max(Id) from client";
            id_client = Convert.ToInt32(cmd4.ExecuteScalar());
            SqlCommand cmd3 = connection.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "insert into facture (total,date,statut,id_client) values (" + Total + ",'" + date + "','" + status + "'," + id_client + ")";
            cmd3.ExecuteNonQuery();
            connection.Close();
            TB_nom.Text = "";
            TB_prenom.Text = "";
            TB_CIN.Text = "";
            TB_Adresse.Text = "";
            TB_Email.Text = "";
            button_ajouterClient.Visible = false;
            TB_nom.Enabled = false;
            TB_prenom.Enabled = false;
            TB_Email.Enabled = false;
            TB_CIN.Enabled = false;
            TB_Adresse.Enabled = false;
            color();
        }

        private void button_ajouterProduit_Click(object sender, EventArgs e)
        {
            //Pour verifier si les champs textes sont vides 
            ns1.BunifuMaterialTextbox[] TBtable = new ns1.BunifuMaterialTextbox[3];
            TBtable[0] = TB_marque;
            TBtable[1] = TB_quantite;
            TBtable[2] = TB_prix;
            foreach (var tb in TBtable)
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
            string reference = CB_reference.Text;
            int id_produit = 0;
            int id_facture = 0;
            
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="select Id_produit from produit where reference ='"+reference+"'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                id_produit = int.Parse(sr["Id_produit"].ToString());
                
            }
            sr.Close();
            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select max(Id_facture) from facture";
            id_facture = Convert.ToInt32(cmd1.ExecuteScalar());
            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into facture_produit(id_produit,id_facture,quantite,livre) values ("+id_produit+","+id_facture+",0,0)";
            cmd2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Vous pouvez ajouter tant de produit que vous voulez et cliquez sur valider commande");
            button_validerCommande.Visible = true;
            CB_reference.Text = "";
            TB_marque.Text = "";
            TB_quantite.Text = "";
            TB_prix.Text = "";
            color();

        }


        private void button_validerCommande_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez effectué votre commande");
            color();
            button_validerCommande.Visible = false;
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            color();
            connection.Open();
            int id_produit = 0;
        
            int SelectedRow = bunifuCustomDataGrid1.SelectedRows[0].Index;
       
            if (SelectedRow != -1)
            {
                int id_facture = int.Parse(bunifuCustomDataGrid1.Rows[SelectedRow].Cells["Id_facture"].Value.ToString());
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id_produit from facture_produit where id_facture=" + id_facture + "";
                SqlDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    id_produit = int.Parse(sr["id_produit"].ToString());
                }
                sr.Close();
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from produit where id_produit=" + id_produit + "";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd1.CommandText, connection);
                dataadp.Fill(dta);
                bunifuCustomDataGrid2.DataSource = dta;
                connection.Close();
            }

        }
        private void color()
        {
            foreach (var tb in this.Controls.OfType<ns1.BunifuMaterialTextbox>())
            {
                if (tb.Enabled == false) {
                    tb.LineIdleColor = Color.Silver;
                }
                else
                {
                    tb.LineIdleColor = Color.FromArgb(225, 155, 45);
                    tb.LineMouseHoverColor = Color.FromArgb(225, 155, 45);
                }
            }
        }
}
}
