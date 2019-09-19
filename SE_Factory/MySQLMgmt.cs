using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SE_Factory
{
    public static class MySQLMgmt
    {
        public static string ConnStr = "Data Source=34.65.242.38;Database=DB_Factory;userid=sa;password=aavesp19;";
        public static MySqlConnection Connessione = new MySqlConnection(ConnStr);

        public static bool ApriConnessione()
        {
            try
            {
                if (Connessione.State != ConnectionState.Open)
                {
                    Connessione.ConnectionString = MySQLMgmt.ConnStr;
                    Connessione.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ChiudiConnessione()
        {
            try
            {
                if (Connessione.State != System.Data.ConnectionState.Closed)
                {
                    Connessione.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable Fill_SQL_Schede()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM DB_Factory.GC_Schede", Connessione);

            ApriConnessione();

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            ChiudiConnessione();

            return dt;
        }

        public static DataTable Fill_SQL_Software()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM DB_Factory.GC_Software", Connessione);

            ApriConnessione();

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            ChiudiConnessione();

            return dt;
        }

        public static DataTable Fill_SQL_FamProd()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM DB_Factory.GC_Fam_Prod", Connessione);

            ApriConnessione();

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            ChiudiConnessione();

            return dt;
        }

    }
}
