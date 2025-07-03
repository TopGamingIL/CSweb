using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LielWebProject.App_Code
{
    public class Helper
    {
        public static SqlConnection ConnectToDb(string fileName)
        {
            string path = HttpContext.Current.Server.MapPath("App_Data/") + fileName;

            //  Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\source\repos\Orelproject\Orelproject\App_Data\OrelDataBase.mdf; Integrated Security = True; Connect Timeout = 30

            //  string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\OrelDataBase.mdf;Integrated Security=True;Connect Timeout=30";
            string connString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\source\repos\Orelproject\Orelproject\App_Data\OrelDataBase.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

        public static void DoQuery(string fileName, string sql)
        {
            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }



        public static bool IsExist(string fileName, string sql)
        {

            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader data = com.ExecuteReader();

            bool found = Convert.ToBoolean(data.Read());
            conn.Close();
            return found;

        }

        public static DataTable ExecuteDataTable(string fileName, string sql)
        {
            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();

            DataTable dt = new DataTable();

            SqlDataAdapter tableAdapter = new SqlDataAdapter(sql, conn);

            tableAdapter.Fill(dt);

            conn.Close();
            return dt;
        }
    }
}