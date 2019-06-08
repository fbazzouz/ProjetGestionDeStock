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
        static DataSet dsCompt = new DataSet("FactureCompt");
        DataTable dtCompt = new DataTable("FactureCompt");
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
                TB_total.Enabled = false;

                TB_facture_N.Text = "F2019-" + DatabaseOperations.maxId();
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
                TB_quantite.MaximumValue = int.Parse(sr["quantite_stk"].ToString());
                TB_marque.Text = sr["marque"].ToString();
            }
            TB_quantite.Value = 0;
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
            
            ////////////////////////////////////////////////

            connection.Open();
            string reference = CB_reference.Text;
            int id_produit = 0;
            int id_facture = 0;
            
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="select Id_produit,prix from produit where reference ='"+reference+"'";
            SqlDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                id_produit = int.Parse(sr["Id_produit"].ToString());
                int prixtotal=int.Parse(TB_total.Text)+int.Parse(sr["prix"].ToString()) * TB_quantite.Value;
                TB_total.Text = prixtotal.ToString();



            }
            sr.Close();
            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select max(Id_facture) from facture";
            id_facture = Convert.ToInt32(cmd1.ExecuteScalar());
            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into facture_produit(id_produit,id_facture,quantite,livre) values ("+id_produit+","+id_facture+","+TB_quantite.Value+",0)";
            cmd2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Vous pouvez ajouter tant de produit que vous voulez et cliquez sur valider commande");
            button_validerCommande.Visible = true;
            CB_reference.Text = "";
            TB_marque.Text = "";
            TB_quantite.Value = 0;
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
            
        
            int SelectedRow = bunifuCustomDataGrid1.SelectedRows[0].Index;
       
            if (SelectedRow != -1)
            {
              
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select f.id_facture,reference,marque,quantite,prix,description,id_client from produit p,facture_produit fp ,facture f where p.id_produit=fp.id_produit and fp.id_facture=f.id_facture";
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
                    tb.BackColor = Color.Silver;
                }
                else
                {
                    tb.BackColor = Color.FromArgb(57, 62, 70);
                    tb.LineIdleColor = Color.FromArgb(225, 155, 45);
                    tb.LineMouseHoverColor = Color.FromArgb(225, 155, 45);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TB_quantite_ValueChanged(object sender, EventArgs e)
        {
            seuil.Text = "Quantite : " + TB_quantite.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid2.DataSource != null)
            {
                dtCompt.Clear();
                dtCompt.Columns.Clear();
                createdsCompt();
                Print_Form obj = new Print_Form();
                obj.Show();
                dsCompt.Tables.Remove(dsCompt.Tables["FactureCompt"]);

            }
            else
            {
                MessageBox.Show("Aucune Facture à Imprimer");
            }
        }
        private void createdsCompt()
        {
            if (dtCompt.Rows.Count <= 0)
            {
                DataColumn dc1 = new DataColumn("Id_facture", typeof(string));
                DataColumn dc2 = new DataColumn("description", typeof(string));
                DataColumn dc3 = new DataColumn("reference", typeof(string));
                DataColumn dc4 = new DataColumn("quantite", typeof(int));
                DataColumn dc5 = new DataColumn("prix", typeof(decimal));
                DataColumn dc7 = new DataColumn("Date", typeof(string));
                DataColumn dc8 = new DataColumn("id_client", typeof(string));
                DataColumn dc9 = new DataColumn("marque", typeof(string));
                dtCompt.Columns.Add(dc1);
                dtCompt.Columns.Add(dc2);
                dtCompt.Columns.Add(dc3);
                dtCompt.Columns.Add(dc4);
                dtCompt.Columns.Add(dc5);
                dtCompt.Columns.Add(dc7);
                dtCompt.Columns.Add(dc8);
                dtCompt.Columns.Add(dc9);
                
                    foreach (DataGridViewRow dgr1 in bunifuCustomDataGrid2.Rows)
                    {
                        dtCompt.Rows.Add(dgr1.Cells["Id_facture"], dgr1.Cells["description"].Value, dgr1.Cells["reference"].Value, dgr1.Cells["quantite"].Value, dgr1.Cells["prix"].Value, DP.Value.ToString("dd/MM/yyyy"), dgr1.Cells["id_client"].Value, dgr1.Cells["marque"].Value);
                    }

                
                dsCompt.Tables.Add(dtCompt);
            }
            else
            {
                foreach (DataGridViewRow dgr1 in bunifuCustomDataGrid2.Rows)
                {
                    dtCompt.Rows.Add(dgr1.Cells["Id_facture"], dgr1.Cells["description"].Value, dgr1.Cells["reference"].Value, dgr1.Cells["quantite"].Value, dgr1.Cells["prix"].Value, DP.Value.ToString("dd/MM/yyyy"), dgr1.Cells["id_client"].Value, dgr1.Cells["marque"].Value);
                }

                dsCompt.Tables.Add(dtCompt);
            }
        }
        public DataSet returndata()
        {
            return dsCompt;

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
