using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Autovermietung_Copy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hier werden Kunden hinzugefügt 
            KunAnlegen kunAnlegen = new KunAnlegen();
            kunAnlegen.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hier kann man neue Autos anlegen 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Hier kann man Buchungen anlegen 
            BuchAnlegen buchAnlegen = new BuchAnlegen();
            buchAnlegen.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Hier kann man Autos löschen 

        }



    }
}

/*
 * Autos hinzufügen: 
 * INSERT INTO auto (AnzahlPS, AutoID, Farbe, Marke, Modell, Tagesmietpreis)
VALUES (130, 1, "blau", "Audi", "A3", 120); 
INSERT INTO auto (AnzahlPS, AutoID, Farbe, Marke, Modell)
VALUES (180, 2, "gelb", "BMW", "3er"); 
INSERT INTO auto (AnzahlPS, AutoID, Farbe, Marke, Modell)
VALUES (370, 3, "schwarz", "Porsche", "Cayenne"); 

Buchung hinzufügen: 
INSERT INTO buchung (AutoID, BuchungsID, Datum, KundeID, ZID)
VALUES (1, 11, "22.06.2022", 3, 3) 
INSERT INTO buchung (AutoID, BuchungsID, Datum, KundeID, ZID)
VALUES (1, 11, 2022-06-24, 3, 3); 

Kunden hinzufügen: 
INSERT INTO kunde (Adresse, Geburtstag, KundeID, Nachname, PLZ, Vorname, ZID) 
VALUES ("Uhlandstraße 47", 2003-10-10, 1, "Preis", 74243, "Nico", 1); 
INSERT INTO kunde (Adresse, Geburtstag, KundeID, Nachname, PLZ, Vorname, ZID) 
VALUES ("Stuttgarterstraße 17", 2000-09-08, 2, "Bundschuh", 74072, "Benjamin", 2); 

Zahlungsdaten hinzufügen: 
INSERT INTO zahlungsdaten (Ablaufdatum, KreditkartenNR, KundeID, NameKI, ZID) 
VALUES (2027-09-09, 1357643295032434, 1, "Nico Preis", 1) 
INSERT INTO zahlungsdaten (Ablaufdatum, KreditkartenNR, KundeID, NameKI, ZID) 
VALUES (2026-08-05, 2327643395042435, 2, "Benjamin Bundschuh", 2) 
*/