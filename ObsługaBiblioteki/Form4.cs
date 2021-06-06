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
    public partial class Form4 : Form
    {
        #region 
        // Obiekt DataSet dla całej klasy Form.
        private DataSet BazaBibliotekaDS = new DataSet("BazaBiblioteka");

        // używając obiektów CommandBuilder, upraszczamy konfigurację adaptera danych
        private SqlCommandBuilder sqlCBAutor;
        private SqlCommandBuilder sqlCBKsiazka;
        private SqlCommandBuilder sqlCBCzytelnik;
        private SqlCommandBuilder sqlCBWydawnictwo;
        private SqlCommandBuilder sqlCBWypozyczenie;

        // adaptery danych dla każdej tabeli
        private SqlDataAdapter wypTableAdapter;
        private SqlDataAdapter czyTableAdapter;
        private SqlDataAdapter ksiTableAdapter;
        private SqlDataAdapter autTableAdapter;
        private SqlDataAdapter wydTableAdapter;

        // łańcuch połączenia dla całej klasy Form
        private string cnStr = string.Empty;

        //DataTable KsiazkaTable = new DataTable();
        #endregion

        public static void SaveAsXml(DataSet BazaBibliotekaDS)
        {
            // Zapisz jako Xml.
            BazaBibliotekaDS.WriteXml("Baza_Biblioteka.xml");
        }

        public Form4()
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
            dataGridViewCzytelnik.DataSource = BazaBibliotekaDS.Tables["CZYTELNIK"];

            BuildTableRelationship();
            #endregion
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                czyTableAdapter.Update(BazaBibliotekaDS, "CZYTELNIK");
                MessageBox.Show("Baza została zaktualizowana!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        }

            private void buttonUsunCzytelnik_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] rowToDelete = BazaBibliotekaDS.Tables["CZYTELNIK"].Select(string.Format("czy_id={0}", int.Parse(textBoxUsunCzytelnik.Text)));

                DialogResult dialog = MessageBox.Show("Czy napewno chcesz usunąć rekord?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    rowToDelete[0].Delete();
                    czyTableAdapter.Update(BazaBibliotekaDS, "CZYTELNIK");
                    MessageBox.Show("Rekord został usunięty!");
                    textBoxUsunCzytelnik.Clear();
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("Rekord {0} nie został usunięty!", textBoxUsunCzytelnik.Text);
                    textBoxUsunCzytelnik.Clear();
                }
                //BazaBibliotekaDS.Tables["KSIAZKA"].AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonWyszukaj_Click(object sender, EventArgs e)
        {
            DataView dv = this.BazaBibliotekaDS.Tables["CZYTELNIK"].DefaultView;
            dv.RowFilter = string.Format("czy_imie like '%{0}%' and czy_nazwisko like '%{1}%'", textBoxImie.Text, textBoxNazwisko.Text);
            dataGridViewCzytelnik.DataSource = dv.ToTable();
            textBoxImie.Clear();
            textBoxNazwisko.Clear();
        }

        #region obsługa przycisków menu
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

        }

        private void buttonwypożyczenia4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }

        private void buttonwyszukiwanie4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Search_EngineModels.Form1().Show();
        }
        #endregion

        private void buttonwyszukajwypozyczenia_Click(object sender, EventArgs e)
        {
            string strWypozyczenieInfo = string.Empty;
            DataRow[] drsCzy = null;
            DataRow[] drsWyp = null;
            DataRow[] drsKsi = null;

            // uzyskaj aut_id z pola tekstowego
            int czy_id = int.Parse(this.textBoxwyszukajwypozyczenia.Text);

            // na podstawie aut_id pobierz właściwy wiersz z tabeli AUTOR
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
                drsKsi = drsWyp[0].GetParentRows(BazaBibliotekaDS.Relations["Wypozyczenie_Ksiazka"]);

                strWypozyczenieInfo += string.Format("Ksiażka nr {0}: {1}\n",
                  drsKsi[0]["ksi_id"].ToString(),
                  drsKsi[0]["ksi_tytul"].ToString().Trim());

                strWypozyczenieInfo += string.Format("data wypożyczenia: {0}\n", wypozyczenie["wyp_data_wyp"]);
                strWypozyczenieInfo += string.Format("data zwrotu: {0}\n", wypozyczenie["wyp_data_zwr"]);
            }
            MessageBox.Show(strWypozyczenieInfo, "Wypożyczone książki czytelnika", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxwyszukajwypozyczenia.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAsXml(BazaBibliotekaDS);
            MessageBox.Show("Baza czytelników została zapisana");
        }
    }
}
