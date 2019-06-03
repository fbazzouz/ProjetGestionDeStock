
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
        
        public static SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\stockbd.mdf;Integrated Security = True");
        //------------------------ opeeen conncetion ----------------------------
        private static SqlConnection getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;

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
     


    }
}
