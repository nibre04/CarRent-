using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data; 
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autovermietung_Copy
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            SqlConnection();
            

        }

        public static void SqlConnection()
        {
           string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=autovermietung;";
            string query2 = "SELECT farbe FROM auto WHERE AutoID = 1";
            Console.WriteLine(query2);
        }

            

    }
}

