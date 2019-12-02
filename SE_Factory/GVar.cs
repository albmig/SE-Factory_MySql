using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SE_Factory
{
    public static class GVar
    {
        public static string glob_tipo_item = "";
        public static string glob_hex_id = "";
        public static char[] glob_bin_id = new char[12]; //contiene il binario delle scelte su palmare/controller
        public static char[] glob_result_id = new char[4]; //contiene il risultato dell'ID
        //public static string glob_bin_id = "";
        //public static string glob_result_id="";
        public static string glob_default_printer = "";

        public static string glob_form_status = "V"; //N - new - E - edit - V - view

        //array di stringhe per l'elenco delle schede compatibili
        public static ArrayList glob_schede_compatibili = new ArrayList();

        public static int Last_SW_ID_Record = 0;

        public static bool CloseSplash = false;
    }
}
