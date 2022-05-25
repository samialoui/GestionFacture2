using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacture
{
   public  class Facture
    {
        public int FactureID { get; set; }
        public string Designation { get; set; }
        public string PrixUnitaire { get; set; }
        public string Quantite { get; set; }
        public string Montant { get; set; }
        public Facture(string desig,string prix,string quntite, string mont)
        {
            this.Designation = desig;
            this.PrixUnitaire = prix;
            this.Quantite = quntite;
            this.Montant = mont;
        }

        public Facture()
        {
        }

        static string MyConnection = ConfigurationManager.ConnectionStrings["connexion"].ConnectionString;


        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(MyConnection);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM facture";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool Insert(Facture facture)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(MyConnection);
            try
            {
                String sql = "INSERT INTO facture (Designation,PrixUnitaire,Quantite,Montant) VALUES (@Designation,@PrixUnitaire,@Quantite,@Montant)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Designation", facture.Designation);
                cmd.Parameters.AddWithValue("@PrixUnitaire", facture.PrixUnitaire);
                cmd.Parameters.AddWithValue("@Quantite", facture.Quantite);
                cmd.Parameters.AddWithValue("@Montant", facture.Montant);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }


            return isSuccess;
        }

        public bool Delete(Facture facture)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(MyConnection);
            try
            {
                String sql = "DELETE FROM facture WHERE Designation= @Designation";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Designation", facture.Designation);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else{
                    isSuccess = false;
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public double CalculMontant(string PrixUnitaire, string Quantite)
        {
            Double prix = Double.Parse(PrixUnitaire);
            Double Quan = Double.Parse(Quantite);

            return prix * Quan;
        }

        public string CalculTotHT()
        {

            SqlConnection conn = new SqlConnection(MyConnection);
            DataTable dt = new DataTable();
            string sum = "";
            try
            {
                String sql = "SELECT SUM(Montant) FROM facture";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                sum = dt.ToString();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
       return sum;

        }

    

    }
}
