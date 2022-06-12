using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Autovermietung_Copy
{
    public partial class KunAnlegen : Form
    {
        public KunAnlegen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e) // KundeID
        {

        }
        private void richTextBox2_TextChanged(object sender, EventArgs e) // Vorname 
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e) // Nachname 
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e) // Geburtstag 
        {
           /* var ageInput = richTextBox4.Text;
            DateTime dt_now = DateTime.Now;
            int age = Convert.ToInt32(ageInput);

            int dtInt = Convert.ToInt32(DateTime.Now);
            

            if ((age - 18) < dtInt)
            {
                MessageBox.Show("Registrierung nicht möglich ");
                this.Visible = false;
            }
            else
            {
                return; 
            } */
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e) // Adresse 
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e) // PLZ 
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e) // ZID
        {


        }



        private void button1_Click(object sender, EventArgs e)
        {
            //  InsertData("datasource=127.0.0.1;port=3306;username=root;password=;database=test;", 4, "Peter", "Mayer", "2004 - 10 - 10", "Petersdomstraße 7", 74243, 4);
            // InsertDataMySQL(5, "Max", "Mustermann", '1975-11-11', "Musterstraße 7", 12345, 5);
        }

        public void InsertDataMySQL(int KundeID, string Vorname, string Nachname, DateTime Geburtstag, string Adresse, int PLZ, int ZID)
        {
            // string query = "UPDATE auto SET Tagesmietpreis = 225 WHERE AutoID = ";
           string query = @"INSERT INTO kunde (KundeID, Vorname, Nachname, Geburtstag, Adresse, PLZ, ZID) VALUES (5, 'Peter' , 'Müller', 1993-05-03, 'Heilbronnerstraße 7', 12456, 5)";
            // Funktionierende Query: INSERT INTO kunde (KundeID, Vorname, Nachname, Geburtstag, Adresse, PLZ, ZID) VALUES (4, 'Peter' , 'Mayer', 1998-10-10, 'Domstraße 7', 61234, 4)

            string MySqlConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=autovermietung";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                cmd.Parameters.Add("@KundeID", MySqlDbType.Int64).Value = KundeID;
                cmd.Parameters.Add("@Vorname", MySqlDbType.VarChar).Value = Vorname;
                cmd.Parameters.Add("@Nachname", MySqlDbType.VarChar).Value = Nachname;
                cmd.Parameters.Add("@Geburtstag", MySqlDbType.DateTime).Value = Geburtstag;
                cmd.Parameters.Add("@Adresse", MySqlDbType.VarChar).Value = Adresse;
                cmd.Parameters.Add("@PLZ", MySqlDbType.Int32).Value = PLZ;
                cmd.Parameters.Add("@ZID", MySqlDbType.Int32 ).Value = ZID;

                MySqlDataReader myReader = cmd.ExecuteReader();
                MessageBox.Show("Der Kunde wurde hinzugefügt");
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  Fehler");
            }

            
        }
  /*      public void InsertData(string connectionString, int KundeID, string Vorname, string Nachname, string Geburtstag, string Adresse, int PLZ, int ZID)

        {
            string query = "INSERT INTO kunde (KundeID, Vorname, Nachname, Geburtstag, Adresse, PLZ, ZID)" +

                " VALUES(@KundeID, @Vorname, @Nachname, @Geburtstag, @Adresse, @PLZ, @ZID)";

            using (SqlConnection connection = new SqlConnection(@"Datasource=127.0.0.1;port=3306;username=root;password=;database=autovermietung"))  

            // @"Datasource= 127.0.0.1;port=3306;username=root;password=;database=autovermietung;"
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))

                {


                    /*   cmd.Parameters.AddWithValue("@KundeID", SqlDbType.Int = KundeID);
                       cmd.Parameters.Add("@KundeID", SqlDbType.Int).Value = KundeID;

                       cmd.Parameters.Add("@Vorname", Sq                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lDbType.TinyInt).Value = Vorname;

                       cmd.Parameters.Add("@Nachname", SqlDbType.VarChar).Value = Nachname;

                       cmd.Parameters.Add("@Geburtstag", SqlDbType.DateTime).Value = Geburtstag;

                       cmd.Parameters.Add("@Adresse", SqlDbType.VarChar).Value = Adresse;

                       cmd.Parameters.Add("@PLZ", SqlDbType.VarChar).Value = PLZ;

                       cmd.Parameters.Add("@ZID", SqlDbType.VarChar).Value = ZID; 





                    try

                    {
                        connection.Open();

                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Hinzufügen erfolgreich");

                        Console.ReadKey();

                    }

                    catch (SqlException e)

                    {
                        Console.WriteLine("Ein Fehler ist aufgetreten: " + e.ToString());

                        Console.ReadKey();

                    }

                    finally

                    {
                        connection.Close();

                        Console.WriteLine("Fehler");

                        Console.ReadKey();

                    }

                }

            }

        } */
    }
}
    

