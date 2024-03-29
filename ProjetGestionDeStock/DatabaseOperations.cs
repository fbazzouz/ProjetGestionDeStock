﻿
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
        
        public static SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\stockbd.mdf;Integrated Security = True
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
            cmd.Connection = getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into categorie (Nom) values('"+NewCategorie+"')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //------------------------ Modifier une categorie ----------------------------
        public static void ModifierCategorie(int id,string nom)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [categorie] set Nom = '" + nom + "' where Id = '" + id + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //------------------------ Supprimer une categorie ----------------------------
        public static void SupprimerCategorie(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [categorie] where Id = '" + id + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //------------------------ Rechercher une categorie par nom ----------------------------
        public static DataTable RechercherCategorieNom(string text)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [categorie] where Nom like'" + text + "%'";
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        //------------------------ Rechercher une categorie par id ----------------------------
        public static DataTable RechercherCategorieId(string text)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [categorie] where Id like'" + text + "%'";
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }

        //------------------------ Lister les categories ----------------------------

        public static DataTable Categories()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Id,Nom from categorie";
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        //------------------------ Ajouter un personel ----------------------------
        public static int AjouterNewPerso(string nom,string prenom,string email,string cin,string login,string mdp,string role)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into personnel (Nom,Prenom,Email,CIN,login,mdp,role) values(@nom,@prenom,@email,@cin,@login,@mdp,@role)";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@cin", cin);
            cmd.Parameters.AddWithValue("@mdp", mdp);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@role", role);
            int i=cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        //----------------------- lister les personnels ----------------------------

        public static DataTable listerPerso()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from personnel";
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        //------------------------ Modifier un personel ----------------------------
        public static int updatePerso(int id,string nom, string prenom, string email, string cin, string login, string mdp, string role)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update personnel set Nom=@nom,Prenom=@prenom,Email=@email,CIN=@cin,login=@login,mdp=@mdp,role=@role where id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@cin", cin);
            cmd.Parameters.AddWithValue("@mdp", mdp);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@role", role);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        //------------------------ Delete un personel ----------------------------
        public static int deletePerso(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from personnel where id=@id";
            cmd.Parameters.AddWithValue("id", id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        //------------------------ Lister les produits  a livrer ----------------------------

        public static DataTable produitsAlivrer()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select date,adresse ,CIN,quantite,reference,prix from client c,produit p,facture f,facture_produit fp where p.id_produit=fp.id_produit and f.id_facture=fp.id_facture and c.Id=f.id_client and fp.livre=1 ";
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        //------------------------  confirmer la livraison ----------------------------
        public static void livrer(int id_p,int id_c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [facture_produit] set livre = '" + id_c + "' where id_produit = '" + id_p + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //------------------------ modification ----------------------------

        public static DataTable produitslivre()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select livre,adresse ,CIN,quantite,reference,prix , fp.id_produit  from client c,produit p,facture f,facture_produit fp where p.id_produit=fp.id_produit and f.id_facture=fp.id_facture and c.Id=f.id_client and fp.livre=1 ";
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
            //------------------------ max id facture ----------------------------

        public static int maxId()
        {
            int id=0;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select max(id_facture) from facture";
            cmd.Connection = getcon();
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            sdr.Read();
            id = int.Parse(sdr[0].ToString())+1;
            con.Close();
            return id;
        }

    }
}
