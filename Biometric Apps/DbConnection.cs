using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Biometric_Apps
{
    class DbConnection
    {
        public static MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString);

       public static void CloseConnection()
       {
           if (DbConnection.con.State == ConnectionState.Open)
           {
               DbConnection.con.Close();
           }
       }
    }
        
}
