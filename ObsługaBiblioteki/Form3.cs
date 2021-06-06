using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace ObsługaBiblioteki
{
    public partial class Form3 : Form
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
        #endregion

        public static void SaveAsXml(DataSet BazaBibliotekaDS)
        {
            // Zapisz jako Xml.
            BazaBibliotekaDS.WriteXml("Baza_Biblioteka.xml");
        }

        public Form3()
        {
            InitializeComponent();

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
            dataGridViewAutor.DataSource = BazaBibliotekaDS.Tables["AUTOR"];
            dataGridViewWydawnictwo.DataSource = BazaBibliotekaDS.Tables["WYDAWNICTWO"];

            BuildTableRelationship();

        }

        private void BuildTableRelationship()
        {
            // obiekty relacji danych 
            DataRelation dr = new DataRelation("Ksiazka_Autor",
                 BazaBibliotekaDS.Tables["AUTOR"].Columns["aut_id"],
                 BazaBibliotekaDS.Tables["KSIAZKA"].Columns["aut_id"]);
            BazaBibliotekaDS.Relations.Add(dr);

            DataRelation dr2 = new DataRelation("Ksiazka_Wydawnictwo",
                 BazaBibliotekaDS.Tables["WYDAWNICTWO"].Columns["wyd_id"],
                 BazaBibliotekaDS.Tables["KSIAZKA"].Columns["wyd_id"]);
            BazaBibliotekaDS.Relations.Add(dr2);
        }

        #region obsługa przycików menu
        private void buttonglowna3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void buttonksiazka3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void buttonautorwydawnictwo3_Click(object sender, EventArgs e)
        {

        }

        private void buttonklienci3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void buttonwypożyczenia3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }
        private void buttonwyszukiwanie3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Search_EngineModels.Form1().Show();
        }
        #endregion

        private void buttonWyszukajAutor_Click(object sender, EventArgs e)
        {
            DataView dv = this.BazaBibliotekaDS.Tables["AUTOR"].DefaultView;
            dv.RowFilter = string.Format("aut_imie like '%{0}%' and aut_nazwisko like '%{1}%'", textBoximie.Text, textBoxnazwisko.Text);
            dataGridViewAutor.DataSource = dv.ToTable();
            textBoximie.Clear();
            textBoxnazwisko.Clear();
        }

        private void buttonWyszukajWyd_Click(object sender, EventArgs e)
        {
            DataView dv = this.BazaBibliotekaDS.Tables["WYDAWNICTWO"].DefaultView;
            dv.RowFilter = string.Format("wyd_nazwa like '%{0}%'", textBoxnazwa.Text);
            dataGridViewWydawnictwo.DataSource = dv.ToTable();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                autTableAdapter.Update(BazaBibliotekaDS, "AUTOR");
                wydTableAdapter.Update(BazaBibliotekaDS, "WYDAWNICTWO");
                MessageBox.Show("Baza została zaktualizowana!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUsunKsiazke_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] rowToDelete = BazaBibliotekaDS.Tables["AUTOR"].Select(string.Format("aut_id={0}", int.Parse(textBoxUsunAutor.Text)));

                DialogResult dialog = MessageBox.Show("Czy napewno chcesz usunąć rekord?", "wyjście", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    rowToDelete[0].Delete();
                    autTableAdapter.Update(BazaBibliotekaDS, "AUTOR");
                    MessageBox.Show("Rekord został usunięty!");
                    textBoxUsunAutor.Clear();
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("Rekord {0} nie został usunięty!", textBoxUsunAutor.Text);
                    textBoxUsunAutor.Clear();
                }
                //BazaBibliotekaDS.Tables["KSIAZKA"].AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonusunwyd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] rowToDelete = BazaBibliotekaDS.Tables["WYDAWNICTWO"].Select(string.Format("wyd_id={0}", int.Parse(textBoxUsunWydawnictwo.Text)));

                DialogResult dialog = MessageBox.Show("Czy napewno chcesz usunąć rekord?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    rowToDelete[0].Delete();
                    wydTableAdapter.Update(BazaBibliotekaDS, "WYDAWNICTWO");
                    MessageBox.Show("Rekord został usunięty!");
                    textBoxUsunWydawnictwo.Clear();
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("Rekord {0} nie został usunięty!", textBoxUsunWydawnictwo.Text);
                    textBoxUsunWydawnictwo.Clear();
                }
                //BazaBibliotekaDS.Tables["KSIAZKA"].AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region wyszukiwanie wszystkich książek danego autora lub wydawnictwa
        private void buttonwyszukajksiazkiautora_Click(object sender, EventArgs e)
        {
            string strKsiazkaInfo = string.Empty;
            DataRow[] drsAut = null;
            DataRow[] drsKsi = null;
            DataRow[] drsWyd = null;

            //uzyskaj wyd_nazwa z pola tekstowego
            drsAut = BazaBibliotekaDS.Tables["AUTOR"].Select(string.Format("aut_nazwisko like '%{0}%'", textBoxwyszukajksiazkiautora.Text));

            // na podstawie aut_nazwa pobierz właściwy wiersz z tabeli Wydawnictwo
            foreach (DataRow autor in drsAut)
            {
                strKsiazkaInfo += string.Format("---------------\n");
                strKsiazkaInfo += string.Format("Autor nr {0}: ", autor["aut_id"]);
                strKsiazkaInfo += string.Format("{0} ", autor["aut_imie"]);
                strKsiazkaInfo += string.Format("{0}\nPosiada książki: \n", autor["aut_nazwisko"]);

                // przejdź z tabeli AUTOR do tabeli KSIAZKA
                drsKsi = autor.GetChildRows(BazaBibliotekaDS.Relations["Ksiazka_Autor"]);

                // wykonaj pętlę na wszystkich książkach tego autora
                foreach (DataRow ksiazka in drsKsi)
                {
                    strKsiazkaInfo += string.Format("----\n" + "Nr {0}: ", ksiazka["ksi_id"]);
                    // uzyskaj informacje dla książki z tego zapytania
                    strKsiazkaInfo += string.Format("{0}\n", ksiazka["ksi_tytul"]);
                    strKsiazkaInfo += string.Format("Rok wydania: {0}\n", ksiazka["ksi_rok_wydania"]);
                    drsWyd = BazaBibliotekaDS.Tables["WYDAWNICTWO"].Select(string.Format("wyd_id = {0}", ksiazka["wyd_id"]));
                    strKsiazkaInfo += string.Format("Wydawnictwo nr {0}: {1} {2}\n",
                      drsWyd[0]["wyd_id"].ToString(),
                      drsWyd[0]["wyd_nazwa"].ToString().Trim(),
                      drsWyd[0]["wyd_skrót"].ToString().Trim());
                }
            }
            MessageBox.Show(strKsiazkaInfo, "Książki danego autora po nazwisku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxwyszukajksiazkiautora.Clear();
        }

        private void buttonwyszukajksiazkiautoraid_Click(object sender, EventArgs e)
        {
            string strKsiazkaInfo = string.Empty;
            DataRow[] drsAut = null;
            DataRow[] drsKsi = null;
            DataRow[] drsWyd = null;

            // uzyskaj aut_id z pola tekstowego
            int aut_id = int.Parse(this.textBoxwyszukajksiazkiautora.Text);

            // na podstawie aut_id pobierz właściwy wiersz z tabeli AUTOR
            drsAut = BazaBibliotekaDS.Tables["AUTOR"].Select(string.Format("aut_id = {0}", aut_id));
            strKsiazkaInfo += string.Format("Książki autorstwa {0}: {1} {2}\n",
              drsAut[0]["aut_id"].ToString(),
              drsAut[0]["aut_imie"].ToString().Trim(),
              drsAut[0]["aut_nazwisko"].ToString().Trim());
            int n = 0;
            {
                // przejdź z tabeli AUTOR do tabeli KSIAZKA
                drsKsi = drsAut[n].GetChildRows(BazaBibliotekaDS.Relations["Ksiazka_Autor"]);

                // wykonaj pętlę na wszystkich książkach tego autora
                foreach (DataRow ksiazka in drsKsi)
                {
                    strKsiazkaInfo += string.Format("----\n" + "Nr {0}: ", ksiazka["ksi_id"]);
                    // uzyskaj informacje dla książki z tego zapytania
                    strKsiazkaInfo += string.Format("{0}\n", ksiazka["ksi_tytul"]);
                    strKsiazkaInfo += string.Format("Rok wydania: {0}\n", ksiazka["ksi_rok_wydania"]);
                    // uzyskaj informacje o wydawnictwie tej książki
                    drsWyd = BazaBibliotekaDS.Tables["WYDAWNICTWO"].Select(string.Format("wyd_id = {0}", ksiazka["wyd_id"]));
                    strKsiazkaInfo += string.Format("Wydawnictwo nr {0}: {1} {2}\n",
                      drsWyd[0]["wyd_id"].ToString(),
                      drsWyd[0]["wyd_nazwa"].ToString().Trim(),
                      drsWyd[0]["wyd_skrót"].ToString().Trim());
                }
            }
            n++;
            MessageBox.Show(strKsiazkaInfo, "Książki danego autora po ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxwyszukajksiazkiautora.Clear();
        }

        private void buttonwyszukajksiazkiwyd_Click(object sender, EventArgs e)
        {
            string strWydawnictwoInfo = string.Empty;
            DataRow[] drsWyd = null;
            DataRow[] drsKsi = null;
            DataRow[] drsAut = null;

            //uzyskaj wyd_nazwa z pola tekstowego
            drsWyd = BazaBibliotekaDS.Tables["WYDAWNICTWO"].Select(string.Format("wyd_nazwa like '%{0}%'", textBoxwyszukajksiazkiwyd.Text));

            // na podstawie wyd_nazwa pobierz właściwy wiersz z tabeli WYDAWNICTWO
            foreach (DataRow wydawnictwo in drsWyd)
            {
                strWydawnictwoInfo += string.Format("---------------\n");
                strWydawnictwoInfo += string.Format("Wydawnictwo nr {0}: ", wydawnictwo["wyd_id"]);
                strWydawnictwoInfo += string.Format("{0} ", wydawnictwo["wyd_nazwa"]);
                strWydawnictwoInfo += string.Format("{0}\nPosiada książki: \n", wydawnictwo["wyd_skrót"]);

                // przejdź z tabeli WYDAWNICTWO do tabeli KSIAZKA
                drsKsi = wydawnictwo.GetChildRows(BazaBibliotekaDS.Relations["Ksiazka_Wydawnictwo"]);

                // wykonaj pętlę na wszystkich książkach tego wydawnictwa
                foreach (DataRow ksiazka in drsKsi)
                {
                    strWydawnictwoInfo += string.Format("---\n" + "Nr {0}: ", ksiazka["ksi_id"]);
                    // uzyskaj informacje dla książki z tego zapytania
                    strWydawnictwoInfo += string.Format("{0}\n", ksiazka["ksi_tytul"]);
                    strWydawnictwoInfo += string.Format("Rok: {0},".PadRight(14), ksiazka["ksi_rok_wydania"]);
                    drsAut = BazaBibliotekaDS.Tables["AUTOR"].Select(string.Format("aut_id = {0}", ksiazka["aut_id"]));
                    strWydawnictwoInfo += string.Format("Autor {0}: {1} {2}\n",
                      drsAut[0]["aut_id"].ToString(),
                      drsAut[0]["aut_imie"].ToString().Trim(),
                      drsAut[0]["aut_nazwisko"].ToString().Trim());
                }
            }
            MessageBox.Show(strWydawnictwoInfo, "Książki danego wydawnictwa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxwyszukajksiazkiwyd.Clear();
        }
        
        private void buttonwyszukajksiazkiwydid_Click(object sender, EventArgs e)
        {
            string strWydawnictwoInfo = string.Empty;
            DataRow[] drsWyd = null;
            DataRow[] drsKsi = null;
            DataRow[] drsAut = null;

            // uzyskaj ID wydawnictwa z pola tekstowego
            int wyd_id = int.Parse(this.textBoxwyszukajksiazkiwyd.Text);

            // na podstawie Wydawnictwo_ID pobierz właściwy wiersz z tabeli Wydawnictwo
            drsWyd = BazaBibliotekaDS.Tables["WYDAWNICTWO"].Select(string.Format("wyd_id = {0}", wyd_id));
            strWydawnictwoInfo += string.Format("Wydawnictwo nr {0}: {1} {2}\nPosiada książki:\n",
              drsWyd[0]["wyd_id"].ToString(),
              drsWyd[0]["wyd_nazwa"].ToString().Trim(),
              drsWyd[0]["wyd_skrót"].ToString().Trim());

            // przejdź z tabeli Wydawnictwo do tabeli Związki
            drsKsi = drsWyd[0].GetChildRows(BazaBibliotekaDS.Relations["Ksiazka_Wydawnictwo"]);

            // wykonaj pętlę na wszystkich książkach tego wydawnictwa
            foreach (DataRow ksiazka in drsKsi)
            {
                strWydawnictwoInfo += string.Format("---\n" + "Nr {0}: ", ksiazka["ksi_id"]);
                // uzyskaj informacje dla książki z tego zapytania
                strWydawnictwoInfo += string.Format("{0}\n", ksiazka["ksi_tytul"]);
                strWydawnictwoInfo += string.Format("Rok: {0},".PadRight(14), ksiazka["ksi_rok_wydania"]);
                drsAut = BazaBibliotekaDS.Tables["AUTOR"].Select(string.Format("aut_id = {0}", ksiazka["aut_id"]));
                strWydawnictwoInfo += string.Format("Autor {0}: {1} {2}\n",
                  drsAut[0]["aut_id"].ToString(),
                  drsAut[0]["aut_imie"].ToString().Trim(),
                  drsAut[0]["aut_nazwisko"].ToString().Trim());

            }
            MessageBox.Show(strWydawnictwoInfo, "Książki danego autora po ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxwyszukajksiazkiwyd.Clear();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAsXml(BazaBibliotekaDS);
            MessageBox.Show("Baza została zapisana");
        }
    }
}
