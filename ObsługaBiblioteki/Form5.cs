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
    public partial class Form5 : Form
    {
        #region 
        // Obiekt DataSet dla całej klasy Form.
        private DataSet BazaBibliotekaDS = new DataSet("BazaBiblioteka");

        // używając obiektów CommandBuilder, upraszczamy konfigurację adaptera danych
        //private SqlCommandBuilder sqlCBKsiazka;
        private SqlCommandBuilder sqlCBAutor;
        private SqlCommandBuilder sqlCBKsiazka;
        private SqlCommandBuilder sqlCBCzytelnik;
        private SqlCommandBuilder sqlCBWydawnictwo;
        private SqlCommandBuilder sqlCBWypozyczenie;

        // adaptery danych dla każdej tabeli
        //private SqlDataAdapter ksiTableAdapter;
        private SqlDataAdapter wypTableAdapter;
        private SqlDataAdapter czyTableAdapter;
        private SqlDataAdapter ksiTableAdapter;
        private SqlDataAdapter autTableAdapter;
        private SqlDataAdapter wydTableAdapter;

        // łańcuch połączenia dla całej klasy Form
        private string cnStr = string.Empty;

        //DataTable KsiazkaTable = new DataTable();

        public static void SaveAsXml(DataSet BazaBibliotekaDS)
        {
            // Zapisz jako Xml.
            BazaBibliotekaDS.WriteXml("Baza_Biblioteka.xml");
        }
        #endregion

        public Form5()
        {
            InitializeComponent();

            #region przypisanie do tabeli
            // Get connection string.
            cnStr =
              ConfigurationManager.ConnectionStrings["BazaBibliotekaSqlProvider"].ConnectionString;

            // Create adapters.
            wypTableAdapter = new SqlDataAdapter("Select * from WYPOZYCZENIE", cnStr);
            czyTableAdapter = new SqlDataAdapter("Select * from CZYTELNIK", cnStr);
            ksiTableAdapter = new SqlDataAdapter("Select * from KSIAZKA", cnStr);
            autTableAdapter = new SqlDataAdapter("Select * from AUTOR", cnStr);
            wydTableAdapter = new SqlDataAdapter("Select * from WYDAWNICTWO", cnStr);

            // Autogenerate commands.
            sqlCBWypozyczenie = new SqlCommandBuilder(wypTableAdapter);
            sqlCBCzytelnik = new SqlCommandBuilder(czyTableAdapter);
            sqlCBKsiazka = new SqlCommandBuilder(ksiTableAdapter);
            sqlCBAutor = new SqlCommandBuilder(autTableAdapter);
            sqlCBWydawnictwo = new SqlCommandBuilder(wydTableAdapter);

            // Add tables to DS.
            ksiTableAdapter.Fill(BazaBibliotekaDS, "KSIAZKA");
            czyTableAdapter.Fill(BazaBibliotekaDS, "CZYTELNIK");
            autTableAdapter.Fill(BazaBibliotekaDS, "AUTOR");
            wydTableAdapter.Fill(BazaBibliotekaDS, "WYDAWNICTWO");
            wypTableAdapter.Fill(BazaBibliotekaDS, "WYPOZYCZENIE");


            // Bind to grids
            dataGridViewWypozyczenie.DataSource = BazaBibliotekaDS.Tables["WYPOZYCZENIE"];

            BuildTableRelationship();
            #endregion
        }

        private void BuildTableRelationship()
        {
            // utwórz obiekt relacji danych 
            DataRelation dr = new DataRelation("Wypozyczenie_Czytelnik",
                 BazaBibliotekaDS.Tables["CZYTELNIK"].Columns["czy_id"],
                 BazaBibliotekaDS.Tables["WYPOZYCZENIE"].Columns["czy_id"]);
            BazaBibliotekaDS.Relations.Add(dr);

            DataRelation dr2 = new DataRelation("Wypozyczenie_Ksiazka",
                 BazaBibliotekaDS.Tables["KSIAZKA"].Columns["ksi_id"],
                 BazaBibliotekaDS.Tables["WYPOZYCZENIE"].Columns["ksi_id"]);
            BazaBibliotekaDS.Relations.Add(dr2);

            //DataRelation dr3 = new DataRelation("Ksiazka_Wydawnictwo",
            //     BazaBibliotekaDS.Tables["WYDAWNICTWO"].Columns["wyd_id"],
            //     BazaBibliotekaDS.Tables["KSIAZKA"].Columns["wyd_id"]);
            //BazaBibliotekaDS.Relations.Add(dr3);
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                wypTableAdapter.Update(BazaBibliotekaDS, "WYPOZYCZENIE");
                MessageBox.Show("Baza została zaktualizowana!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region obsługa przycisków
        private void buttonglowna4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void buttonksiazka4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void buttonautorwydawnictwo4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void buttonklienci4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void buttonwyszukiwanie4_Click(object sender, EventArgs e)
        {

        }

         private void buttonwyszukiwanie5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Search_EngineModels.Form1().Show();
        }
        #endregion

        private void buttonWyszukajWgCzy_Click_1(object sender, EventArgs e)
        {
            string strWypozyczenieInfo = string.Empty;
            DataRow[] drsCzy = null;
            DataRow[] drsWyp = null;
            DataRow[] drsKsi = null;

            // uzyskaj aut_id z pola tekstowego
            int czy_id = int.Parse(this.textBoxNrCzytelnika.Text);

            // na podstawie czy_id pobierz właściwy wiersz z tabeli CZYTELNIK
            drsCzy = BazaBibliotekaDS.Tables["CZYTELNIK"].Select(string.Format("czy_id = {0}", czy_id));
            strWypozyczenieInfo += string.Format("Wypożyczone książki przez czytelnika {0}: {1} {2}\n",
              drsCzy[0]["czy_id"].ToString(),
              drsCzy[0]["czy_imie"].ToString().Trim(),
              drsCzy[0]["czy_nazwisko"].ToString().Trim());

            // przejdź z tabeli CZYTELNIK do tabeli WYPOZYCZENIE
            drsWyp = drsCzy[0].GetChildRows(BazaBibliotekaDS.Relations["Wypozyczenie_Czytelnik"]);

            // wykonaj pętlę na wszystkich książkach tego autora
            foreach (DataRow wypozyczenie in drsWyp)
            {
                strWypozyczenieInfo += string.Format("----\n" + "Nr wypożyczenia: {0}\n", wypozyczenie["wyp_id"]);
                // uzyskaj informacje dla książki z tego zapytania
                //drsKsi = drsWyp[0].GetParentRows(BazaBibliotekaDS.Relations["Wypozyczenie_Ksiazka"]);

                //strWypozyczenieInfo += string.Format("Ksiażka nr {0}: {1}\n",
                //  drsKsi[0]["ksi_id"].ToString(),
                //  drsKsi[0]["ksi_tytul"].ToString().Trim());


                drsCzy = BazaBibliotekaDS.Tables["KSIAZKA"].Select(string.Format("ksi_id = {0}", wypozyczenie["ksi_id"]));
                strWypozyczenieInfo += string.Format("Ksiażka nr {0}: {1}\n",
                  drsCzy[0]["ksi_id"].ToString(),
                  drsCzy[0]["ksi_tytul"].ToString().Trim());

                strWypozyczenieInfo += string.Format("data wypożyczenia: {0}\n", wypozyczenie["wyp_data_wyp"]);
                strWypozyczenieInfo += string.Format("data zwrotu: {0}\n", wypozyczenie["wyp_data_zwr"]);
            }
            MessageBox.Show(strWypozyczenieInfo, "Wypożyczone książki czytelnika", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxNrCzytelnika.Clear();
        }

        private void buttonWyszukajWgWyp_Click(object sender, EventArgs e)
        {
            string strWypozyczenie2Info = string.Empty;
            DataRow[] drsWyp = null;
            DataRow[] drsKsi = null;
            DataRow[] drsCzy = null;

            // uzyskaj aut_id z pola tekstowego
            int wyp_id = int.Parse(this.textBoxNrWyp.Text);

            // na podstawie aut_id pobierz właściwy wiersz z tabeli AUTOR
            drsWyp = BazaBibliotekaDS.Tables["WYPOZYCZENIE"].Select(string.Format("wyp_id = {0}", wyp_id));
            strWypozyczenie2Info += string.Format("Wypożyczenie nr {0}:\n",
              drsWyp[0]["wyp_id"].ToString());

            // przejdź z tabeli CZYTELNIK do tabeli WYPOZYCZENIE
            drsKsi = drsWyp[0].GetParentRows(BazaBibliotekaDS.Relations["Wypozyczenie_Ksiazka"]);
            strWypozyczenie2Info += string.Format("Ksiażka nr {0}: {1}, rok wydania {2}\n",
                 drsKsi[0]["ksi_id"].ToString(),
                 drsKsi[0]["ksi_tytul"].ToString().Trim(),
                 drsKsi[0]["ksi_rok_wydania"].ToString().Trim());

            drsCzy = drsWyp[0].GetParentRows(BazaBibliotekaDS.Relations["Wypozyczenie_Czytelnik"]);
            strWypozyczenie2Info += string.Format("Czytelnik nr {0}: {1} {2}\n",
                 drsCzy[0]["czy_id"].ToString(),
                 drsCzy[0]["czy_imie"].ToString().Trim(),
                 drsCzy[0]["czy_nazwisko"].ToString().Trim());

            strWypozyczenie2Info += string.Format("data wypożyczenia: {0}\n", drsWyp[0]["wyp_data_wyp"].ToString());
            strWypozyczenie2Info += string.Format("data zwrotu: {0}\n", drsWyp[0]["wyp_data_zwr"].ToString());

            MessageBox.Show(strWypozyczenie2Info, "Wypożyczone książki czytelnika", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxNrWyp.Clear();
        }

        private void buttonWyszukajwgksiazki_Click(object sender, EventArgs e)
        {
            string strWypozyczenie3Info = string.Empty;
            DataRow[] drsCzy = null;
            DataRow[] drsWyp = null;
            DataRow[] drsKsi = null;

            // uzyskaj ksi_id z pola tekstowego
            int ksi_id = int.Parse(this.textBoxNrKsiazki.Text);

            // na podstawie ksi_id pobierz właściwy wiersz z tabeli KSIAZKA
            drsKsi = BazaBibliotekaDS.Tables["KSIAZKA"].Select(string.Format("ksi_id = {0}", ksi_id));
            strWypozyczenie3Info += string.Format("Książka o nr {0}: {1}, rok wydania: {2}\n",
              drsKsi[0]["ksi_id"].ToString(),
              drsKsi[0]["ksi_tytul"].ToString().Trim(),
              drsKsi[0]["ksi_rok_wydania"].ToString().Trim());


            // przejdź z tabeli KSIAZKA do tabeli WYPOZYCZENIE
            drsWyp = drsKsi[0].GetChildRows(BazaBibliotekaDS.Relations["Wypozyczenie_Ksiazka"]);

            // wykonaj pętlę na wszystkich wypożyczeniach tej książki
            foreach (DataRow wypozyczenie in drsWyp)
            {
                strWypozyczenie3Info += string.Format("----\n" + "Nr wypożyczenia: {0}\n", wypozyczenie["wyp_id"]);
                // uzyskaj informacje dla książki z tego zapytania
                //drsCzy = drsWyp[0].GetParentRows(BazaBibliotekaDS.Relations["Wypozyczenie_Czytelnik"]);
                drsCzy = BazaBibliotekaDS.Tables["CZYTELNIK"].Select(string.Format("czy_id = {0}", wypozyczenie["czy_id"]));
                strWypozyczenie3Info += string.Format("Czytelnik nr {0}: {1} {2}\n",
                  drsCzy[0]["czy_id"].ToString(),
                  drsCzy[0]["czy_imie"].ToString().Trim(),
                  drsCzy[0]["czy_nazwisko"].ToString().Trim());

                strWypozyczenie3Info += string.Format("data wypożyczenia: {0}\n", wypozyczenie["wyp_data_wyp"]);
                strWypozyczenie3Info += string.Format("data zwrotu: {0}\n", wypozyczenie["wyp_data_zwr"]);
            }
            MessageBox.Show(strWypozyczenie3Info, "Wypożyczone książki czytelnika", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxNrKsiazki.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strKsiazkaInfo = string.Empty;
            DataRow[] drsKsi = null;
            //DataRow[] drsWyd = null;

            //uzyskaj wyd_nazwa z pola tekstowego
            drsKsi = BazaBibliotekaDS.Tables["KSIAZKA"].Select(string.Format("ksi_tytul like '%{0}%'", textBoxwyszukajksiazke.Text));
            foreach (DataRow ksiazka in drsKsi)
            {
                strKsiazkaInfo += string.Format("---------------\n");
                strKsiazkaInfo += string.Format("Książka nr {0}: ", ksiazka["ksi_id"]);
                strKsiazkaInfo += string.Format("{0} \n", ksiazka["ksi_tytul"]);
                strKsiazkaInfo += string.Format("rok wydania {0}\n", ksiazka["ksi_rok_wydania"]);

                //drsWyd = drsKsi[0].GetParentRows(BazaBibliotekaDS.Relations["Ksiazka_Wydawnictwo"]);
                //strKsiazkaInfo += string.Format("Wydawnictwo nr {0}: {1} {2}\n",
                //     drsWyd[0]["wyd_id"].ToString(),
                //     drsWyd[0]["wyd_nazwa"].ToString().Trim(),
                //     drsWyd[0]["wyd_skrót"].ToString().Trim());
            }
                MessageBox.Show(strKsiazkaInfo, "ID Książki", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxwyszukajksiazke.Clear();
        }

        private void buttonwyszukajczy_Click(object sender, EventArgs e)
        {
            string strKsiazkaInfo = string.Empty;
            DataRow[] drsCzy = null;
            //DataRow[] drsWyd = null;

            //uzyskaj wyd_nazwa z pola tekstowego
            drsCzy = BazaBibliotekaDS.Tables["CZYTELNIK"].Select(string.Format("czy_nazwisko like '%{0}%'", textBoxwyszukajczytelnika.Text));
            foreach (DataRow czytelnik in drsCzy)
            {
                strKsiazkaInfo += string.Format("---------------\n");
                strKsiazkaInfo += string.Format("Czytelnik nr {0}: ", czytelnik["czy_id"]);
                strKsiazkaInfo += string.Format("{0} ", czytelnik["czy_imie"]);
                strKsiazkaInfo += string.Format("{0}\n", czytelnik["czy_nazwisko"]);
            }
            MessageBox.Show(strKsiazkaInfo, "ID Czytelnika", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxwyszukajczytelnika.Clear();
        }

        private void buttonzapiszXMLwyp_Click(object sender, EventArgs e)
        {
            SaveAsXml(BazaBibliotekaDS);
            MessageBox.Show("Baza została zapisana do pliku XML!");
        }
    }
}
