using firstLevel2.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace firstLevel2
{
    public class DB
    {
        private IConfiguration configuration;
        public static bool Insert(UserrInfo obj, string connectionString)
        {
            // string connectionString = configuration.GetConnectionString("IbrDB"); //@"Trusted_Connection=True; Provider = SQLOLEDB.1; Persist Security Info = False; User ID = StoreDB; Data Source = DESKTOP - V7HBF70";
            // @"Trusted_Connection=True;Persist Security Info=False;Initial Catalog=StoreDB;Data Source=DESKTOP-CEL38JB\SQLEXPRESS;";
           // string connectionStringg = @"Trusted_Connection=True;MultipleActiveResultSets=true;Initial Catalog=StoreDB;Data Source=DESKTOP-CEL38JB\SQLEXPRESS;";

            string queryString =
           @"INSERT INTO [dbo].[UserrInfo]
           ([UserName]
           ,[Password])
           VALUES
           ('" + obj.UserName+ @"',
            '" + obj.Password + @"')";

            int EffectRows = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand comm = new SqlCommand(queryString, conn);
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();

                    EffectRows = comm.ExecuteNonQuery();

                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
            }
                catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
          
            return EffectRows >= 1 ? true : false;

        }

        public static bool Login(UserrInfo obj, string connectionString)
        {

            string queryString =
         @"[ath]";

            int auth = -1;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand comm = new SqlCommand(queryString, conn);
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@UserName", obj.UserName);
                    comm.Parameters.AddWithValue("@password", obj.Password);

                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();

                 SqlDataReader dr = comm.ExecuteReader();
                   // dr.Read();

                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    auth = Convert.ToInt32(dt.Rows[0]["auth"]);
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
            }
                catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
          
            return auth == 1 ? true : false;

        }


        #region
        public static DataTable reEmpInfo(string connectionString)
        {
            DataTable dt = null;
            string queryString =
            @"[Re_Emp_Info]";

           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
               
                try
                {
                    SqlCommand comm = new SqlCommand(queryString, conn);
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                 
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();

                    SqlDataReader dr = comm.ExecuteReader();
                    // dr.Read();

                    dt = new DataTable();
                    dt.Load(dr);

                    
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                }
            }

            return dt;

        }
        public static DataTable reEmpInfoByID(int ID ,string connectionString2)
        {
            DataTable dt = null;
            string queryString =
            @"[Re_Emp_InfoByID]";


            using (SqlConnection conn = new SqlConnection(connectionString2))
            {

                try
                {
                    SqlCommand comm = new SqlCommand(queryString, conn);
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@ID", ID);

                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();

                    SqlDataReader dr = comm.ExecuteReader();
                    // dr.Read();

                    dt = new DataTable();
                    dt.Load(dr);


                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                }
            }

            return dt;
        }
        #endregion
    }
}
