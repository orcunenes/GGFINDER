using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Data.SQLite;
using System.Data;
using System.Runtime.Remoting.Contexts;

namespace GGFINDER.Utils
{
    internal class DatabaseHelper
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\orcun\\OneDrive\\Belgeler\\GGFINDER\\Maindatabase.db;Version=3;");

        public static bool savequestion(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            connection.Open();
            cmd.ExecuteReader();
            connection.Close();

            return true;
        }
        public class fetchdata
        {
            static DataTable dt;
            public static DataTable Getdata(string sql)
            {
                dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection);
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
