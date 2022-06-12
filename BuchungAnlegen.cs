using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Autovermietung_Copy
{

    public partial class BuchAnlegen : Form
    {
        public BuchAnlegen()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo");
            string hi = richTextBox10.Text;
            DatenAbfragen(Convert.ToInt32(richTextBox10.Text));
        }

        public void DatenAbfragen(int AutoID)
        {
          
            string query = "SELECT * FROM auto WHERE AutoID = @AutoID";
            string MySqlConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=autovermietung";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);

            databaseConnection.Open();
            cmd.Parameters.Add("@AutoID", MySqlDbType.Int32).Value = AutoID;

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            DataColumn a = table.Columns["AutoID"];
            Console.WriteLine(a);

            try
            {
              //  databaseConnection.Open();
              //  cmd.Parameters.Add("@AutoID", MySqlDbType.Int32).Value = AutoID;

                // MySqlDataReader myReader = cmd.ExecuteReader();
               
                
                
             /*   while(myReader.Read())
                {
                   
                } */
            }



            catch (Exception ex)
            {
                
            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {
            int AutoIDEingabe = Convert.ToInt32(richTextBox10.Text);
            
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

