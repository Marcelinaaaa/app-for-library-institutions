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
using ObsługaBiblioteki;

namespace ObsługaBiblioteki
{
    public partial class Form2 : Form
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

        public static void SaveAsXml(DataSet BazaBibliotekaDS)
        {
            // Zapisz jako Xml.
            BazaBibliotekaDS.WriteXml("Baza_Biblioteka.xml");
        }

        #endregion

        public Form2()
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
            dataGridViewKsiazka.DataSource = BazaBibliotekaDS.Tables["KSIAZKA"];

            BuildTableRelationship();


        }
        #region obsługa przycisków głównych

        private void buttonglowna2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void buttonksiazka2_Click(object sender, EventArgs e)
        {

        }

        private void buttonautorwydawnictwo2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void buttonklienci2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void buttonwypożyczenia2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }
        private void buttonwyszukiwanie2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Search_EngineModels.Form1().Show();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = this.BazaBibliotekaDS.Tables["KSIAZKA"].DefaultView;
            dv.RowFilter = string.Format("ksi_tytul like '%{0}%' and ksi_rok_wydania like '%{1}%'", textBox1.Text, textBox2.Text);
            dataGridViewKsiazka.DataSource = dv.ToTable();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void buttonAktualizuj_Click(object sender, EventArgs e)
        {
            try
            {
                ksiTableAdapter.Update(BazaBibliotekaDS, "KSIAZKA");
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
                DataRow[] rowToDelete = BazaBibliotekaDS.Tables["KSIAZKA"].Select(string.Format("ksi_id={0}", int.Parse(textBox3.Text)));

                DialogResult dialog = MessageBox.Show("Czy napewno chcesz usunąć rekord?", "wyjście", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    rowToDelete[0].Delete();
                    ksiTableAdapter.Update(BazaBibliotekaDS, "KSIAZKA");
                    MessageBox.Show("Rekord został usunięty!");
                    textBox3.Clear();
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("Rekord {0} nie został usunięty!", textBox3.Text);
                    textBox3.Clear();
                }
                //BazaBibliotekaDS.Tables["KSIAZKA"].AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BuildTableRelationship()
        {
            // utwórz obiekt relacji danych 
            DataRelation dr = new DataRelation("Ksiazka_Autor",
                 BazaBibliotekaDS.Tables["AUTOR"].Columns["aut_id"],
                 BazaBibliotekaDS.Tables["KSIAZKA"].Columns["aut_id"]);
            BazaBibliotekaDS.Relations.Add(dr);

            DataRelation dr2 = new DataRelation("Ksiazka_Wydawnictwo",
                 BazaBibliotekaDS.Tables["WYDAWNICTWO"].Columns["wyd_id"],
                 BazaBibliotekaDS.Tables["KSIAZKA"].Columns["wyd_id"]);
            BazaBibliotekaDS.Relations.Add(dr2);
        }

        private void buttonwyszukajautorid_Click(object sender, EventArgs e)
        {
            string strKsiazkaInfo = string.Empty;
            DataRow[] drsAut = null;
            DataRow[] drsKsi = null;
            DataRow[] drsWyd = null;

            // uzyskaj aut_id z pola tekstowego
            int aut_id = int.Parse(this.textBoxwyszukaj.Text);

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

            
                //int i=0;
                //// wykonaj pętlę na wszystkich książkach tego autora
                //foreach (DataRow ksiazka in drsKsi)
                //{
                //    strKsiazkaInfo += string.Format("----\n" + "Nr {0}: ", ksiazka["ksi_id"]);
                //    // uzyskaj informacje dla książki z tego zapytania
                //    strKsiazkaInfo += string.Format("{0}\n", ksiazka["ksi_tytul"]);
                //    strKsiazkaInfo += string.Format("Rok wydania: {0}\n", ksiazka["ksi_rok_wydania"]);

                //    // uzyskaj informacje o wydawnictwie tej książki
                //    drsWyd = drsKsi[i].GetParentRows(BazaBibliotekaDS.Relations["Ksiazka_Wydawnictwo"]);

                //    foreach (DataRow wydawnictwo in drsWyd)
                //    {
                //        // uzyskaj informacje dla książki z tego zapytania
                //        strKsiazkaInfo += string.Format("Wydawnictwo {0}: ", wydawnictwo["wyd_id"]);
                //        strKsiazkaInfo += string.Format("{0} ", wydawnictwo["wyd_nazwa"]);
                //        strKsiazkaInfo += string.Format("{0}\n", wydawnictwo["wyd_skrót"]);
                //    }
                //    i++;
                //}
                //n++;
            
            
            MessageBox.Show(strKsiazkaInfo, "Książki danego autora po ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxwyszukaj.Clear();
        }

        private void buttonwyszukajautornaz_Click(object sender, EventArgs e)
        {
            string strKsiazkaInfo = string.Empty;
            DataRow[] drsAut = null;
            DataRow[] drsKsi = null;
            DataRow[] drsWyd = null;

            // uzyskaj aut_nazwa z pola tekstowego
            drsAut = BazaBibliotekaDS.Tables["AUTOR"].Select(string.Format("aut_nazwisko like '%{0}%'", textBoxwyszukaj.Text));

            // na podstawie aut_nazwa pobierz właściwy wiersz z tabeli AUTOR
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

                    //int n++;
                    //// uzyskaj informacje o wydawnictwie tej książki
                    //drsWyd = drsKsi[n].GetParentRows(BazaBibliotekaDS.Relations["Ksiazka_Wydawnictwo"]);

                    //foreach (DataRow wydawnictwo in drsWyd)
                    //{
                    //    // uzyskaj informacje dla książki z tego zapytania
                    //    strKsiazkaInfo += string.Format("Wydawnictwo {0}: ", wydawnictwo["wyd_id"]);
                    //    strKsiazkaInfo += string.Format("{0} ", wydawnictwo["wyd_nazwa"]);
                    //    strKsiazkaInfo += string.Format("{0}\n", wydawnictwo["wyd_skrót"]);
                    //}
                    //n++;

                }
            }
            MessageBox.Show(strKsiazkaInfo, "Książki danego autora po nazwisku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxwyszukaj.Clear();
        }

        private void buttonwyszukajwydid_Click(object sender, EventArgs e)
        {
            string strWydawnictwoInfo = string.Empty;
            DataRow[] drsAut = null;
            DataRow[] drsWyd = null;
            DataRow[] drsKsi = null;

            // uzyskaj ID wydawnictwa z pola tekstowego
            int wyd_id = int.Parse(this.textBoxwyszukajwyd.Text);

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
                textBoxwyszukajwyd.Clear();
        }

        private void buttonwyszukajwydnaz_Click(object sender, EventArgs e)
        {
            string strWydawnictwoInfo = string.Empty;
            DataRow[] drsWyd = null;
            DataRow[] drsKsi = null;
            DataRow[] drsAut = null;

            // uzyskaj wyd_nazwa z pola tekstowego
            drsWyd = BazaBibliotekaDS.Tables["WYDAWNICTWO"].Select(string.Format("wyd_nazwa like '%{0}%'", textBoxwyszukajwyd.Text));

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
            textBoxwyszukajwyd.Clear();
        }

        private void buttonzapiszXML_Click(object sender, EventArgs e)
        {
            SaveAsXml(BazaBibliotekaDS);
        }

        
    }
}
