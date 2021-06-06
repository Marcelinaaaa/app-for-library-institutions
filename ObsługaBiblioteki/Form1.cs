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
using System.Configuration;

namespace ObsługaBiblioteki
{
    public partial class Form1 : Form
    {
        //// Obiekt DataSet dla całej klasy Form.
        //private DataSet BazaBibliotekaDS = new DataSet("BazaBiblioteka");
        
        //// łańcuch połączenia dla całej klasy Form
        //private string cnStr = string.Empty;

        public Form1()
        {
            InitializeComponent();

            //// Get connection string.
            //cnStr =
            //  ConfigurationManager.ConnectionStrings["BazaBibliotekaSqlProvider"].ConnectionString;

        }
        #region obsługa przycisków menu
        private void buttonglowna1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonksiazka1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void buttonautorwydawnictwo1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void buttonklienci_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void buttonwypożyczenia1_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void buttonwyszukiwanie1_Click(object sender, EventArgs e)
        {
            new Search_EngineModels.Form1().Show();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string komunikat;
            komunikat = "BIBLIOBSŁUGA\nProgram do obsługi biblioteki\n\n" ;
            komunikat += "Wykonała: Marcelina Filo\n";
            komunikat += "Zimnodół, 2019r.\n\n";
            komunikat += "Obsługa programu jest prosta.\n" +
                "Działania należy wykonywać wprost na tabelach." +
                "Można dodawać, edytować oraz usuwać książki, wydawnictwa, autorów, czytelników oraz wypożyczenia.\n";

            MessageBox.Show(komunikat, "Informacje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
