
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionDeStock
{
    class DatabaseOperations
    {
        
        public static SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|stockbd.mdf;Integrated Security = True
");
        //------------------------ opeeen conncetion ----------------------------
        private static SqlConnection getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;

        }
        public static void closeCon()
        {
            con.Close();
        }
        //------------------------ Lister les produits vendu ----------------------------

        public static DataTable produitsVendu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select date,CIN,quantite,reference,prix,marque from client c,produit p,facture f,facture_produit fp where p.id_produit=fp.id_produit and f.id_facture=fp.id_facture and c.Id=f.id_client";
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        //------------------------ Totale Produits dispo ----------------------------

        public static int totatDisponible()
        {
            int total=0;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select prix,quantite_stk from produit";
            cmd.Connection = getcon();
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                total += int.Parse(sdr[0].ToString())*int.Parse(sdr[1].ToString());
            }
            con.Close();
            return total;
        }
        //------------------------Total des produits vendu ----------------------------

        public static int totatVendre()
        {
            int total = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select prix,quantite from produit p,facture_produit fp where p.id_produit=fp.id_produit";
            cmd.Connection = getcon();
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                total += int.Parse(sdr[0].ToString()) * int.Parse(sdr[1].ToString());
            }
            con.Close();
            return total;
        }
        //----------------------- Faible stock ----------------------------

        public static DataTable faibleStock(int seuil)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select reference,marque,quantite_stk,prix,Nom from produit p,categorie c where p.id_categorie=c.id and quantite_stk < "+seuil;
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        // ------------------ login verification --------------------
        public static SqlDataReader LoginIsCorrect(string login,string mdp)
        {
            string query = "select role,Nom,Prenom from personnel where mdp=@mdp and login=@login";
            SqlCommand cmd = new SqlCommand(query,getcon());
            cmd.Parameters.AddWithValue("@mdp", mdp);
            cmd.Parameters.AddWithValue("@login", login);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            
            return sdr;
        }
        //------------------------ Ajouter une categorie ----------------------------
        public static void AjouterNewCategorie(string NewCategorie)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into categorie (Nom) values('"+NewCategorie+"')";
            cmd.Connection = getcon();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //------------------------ Lister les categories ----------------------------

        public static DataTable Categories()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Id,Nom from categorie";
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }


    }
}
