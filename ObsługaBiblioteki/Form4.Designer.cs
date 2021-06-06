namespace ObsługaBiblioteki
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonwyszukiwanie4 = new System.Windows.Forms.Button();
            this.buttonwypożyczenia4 = new System.Windows.Forms.Button();
            this.buttonklienci4 = new System.Windows.Forms.Button();
            this.buttonautorwydawnictwo4 = new System.Windows.Forms.Button();
            this.buttonksiazka4 = new System.Windows.Forms.Button();
            this.buttonglowna4 = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.dataGridViewCzytelnik = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUsunCzytelnik = new System.Windows.Forms.Button();
            this.textBoxUsunCzytelnik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonwyszukajwypozyczenia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxwyszukajwypozyczenia = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCzytelnik)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonwyszukiwanie4);
            this.panel1.Controls.Add(this.buttonwypożyczenia4);
            this.panel1.Controls.Add(this.buttonklienci4);
            this.panel1.Controls.Add(this.buttonautorwydawnictwo4);
            this.panel1.Controls.Add(this.buttonksiazka4);
            this.panel1.Controls.Add(this.buttonglowna4);
            this.panel1.Controls.Add(this.buttonZapisz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 461);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 14;
            this.button1.Text = "Zapisz jako XML czytelników";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonwyszukiwanie4
            // 
            this.buttonwyszukiwanie4.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonwyszukiwanie4.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonwyszukiwanie4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwyszukiwanie4.Location = new System.Drawing.Point(0, 300);
            this.buttonwyszukiwanie4.Name = "buttonwyszukiwanie4";
            this.buttonwyszukiwanie4.Size = new System.Drawing.Size(100, 60);
            this.buttonwyszukiwanie4.TabIndex = 13;
            this.buttonwyszukiwanie4.Text = "Wyszukiwanie";
            this.buttonwyszukiwanie4.UseVisualStyleBackColor = false;
            this.buttonwyszukiwanie4.Click += new System.EventHandler(this.buttonwyszukiwanie4_Click);
            // 
            // buttonwypożyczenia4
            // 
            this.buttonwypożyczenia4.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonwypożyczenia4.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonwypożyczenia4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwypożyczenia4.Location = new System.Drawing.Point(0, 240);
            this.buttonwypożyczenia4.Name = "buttonwypożyczenia4";
            this.buttonwypożyczenia4.Size = new System.Drawing.Size(100, 60);
            this.buttonwypożyczenia4.TabIndex = 4;
            this.buttonwypożyczenia4.Text = "Wypożyczenia";
            this.buttonwypożyczenia4.UseVisualStyleBackColor = false;
            this.buttonwypożyczenia4.Click += new System.EventHandler(this.buttonwypożyczenia4_Click);
            // 
            // buttonklienci4
            // 
            this.buttonklienci4.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonklienci4.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonklienci4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonklienci4.Location = new System.Drawing.Point(0, 180);
            this.buttonklienci4.Name = "buttonklienci4";
            this.buttonklienci4.Size = new System.Drawing.Size(100, 60);
            this.buttonklienci4.TabIndex = 3;
            this.buttonklienci4.Text = "Czytelnicy";
            this.buttonklienci4.UseVisualStyleBackColor = false;
            this.buttonklienci4.Click += new System.EventHandler(this.buttonklienci4_Click);
            // 
            // buttonautorwydawnictwo4
            // 
            this.buttonautorwydawnictwo4.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonautorwydawnictwo4.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonautorwydawnictwo4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonautorwydawnictwo4.Location = new System.Drawing.Point(0, 120);
            this.buttonautorwydawnictwo4.Name = "buttonautorwydawnictwo4";
            this.buttonautorwydawnictwo4.Size = new System.Drawing.Size(100, 60);
            this.buttonautorwydawnictwo4.TabIndex = 2;
            this.buttonautorwydawnictwo4.Text = "Autorzy i wydawnictwa";
            this.buttonautorwydawnictwo4.UseVisualStyleBackColor = false;
            this.buttonautorwydawnictwo4.Click += new System.EventHandler(this.buttonautorwydawnictwo4_Click);
            // 
            // buttonksiazka4
            // 
            this.buttonksiazka4.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonksiazka4.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonksiazka4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonksiazka4.Location = new System.Drawing.Point(0, 60);
            this.buttonksiazka4.Name = "buttonksiazka4";
            this.buttonksiazka4.Size = new System.Drawing.Size(100, 60);
            this.buttonksiazka4.TabIndex = 1;
            this.buttonksiazka4.Text = "Książki";
            this.buttonksiazka4.UseVisualStyleBackColor = false;
            this.buttonksiazka4.Click += new System.EventHandler(this.buttonksiazka4_Click);
            // 
            // buttonglowna4
            // 
            this.buttonglowna4.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonglowna4.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonglowna4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonglowna4.Location = new System.Drawing.Point(0, 0);
            this.buttonglowna4.Name = "buttonglowna4";
            this.buttonglowna4.Size = new System.Drawing.Size(100, 60);
            this.buttonglowna4.TabIndex = 0;
            this.buttonglowna4.Text = "Strona główna";
            this.buttonglowna4.UseVisualStyleBackColor = false;
            this.buttonglowna4.Click += new System.EventHandler(this.buttonglowna4_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonZapisz.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZapisz.Location = new System.Drawing.Point(0, 414);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(100, 47);
            this.buttonZapisz.TabIndex = 12;
            this.buttonZapisz.Text = "Zapisz zmiany w bazie";
            this.buttonZapisz.UseVisualStyleBackColor = false;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // dataGridViewCzytelnik
            // 
            this.dataGridViewCzytelnik.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCzytelnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCzytelnik.Location = new System.Drawing.Point(106, 21);
            this.dataGridViewCzytelnik.Name = "dataGridViewCzytelnik";
            this.dataGridViewCzytelnik.Size = new System.Drawing.Size(743, 276);
            this.dataGridViewCzytelnik.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonUsunCzytelnik);
            this.groupBox1.Controls.Add(this.textBoxUsunCzytelnik);
            this.groupBox1.Location = new System.Drawing.Point(231, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 146);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuń czytelnika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Wprowadź ID czytelnika";
            // 
            // buttonUsunCzytelnik
            // 
            this.buttonUsunCzytelnik.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonUsunCzytelnik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUsunCzytelnik.Location = new System.Drawing.Point(65, 63);
            this.buttonUsunCzytelnik.Name = "buttonUsunCzytelnik";
            this.buttonUsunCzytelnik.Size = new System.Drawing.Size(63, 23);
            this.buttonUsunCzytelnik.TabIndex = 14;
            this.buttonUsunCzytelnik.Text = "Usuń";
            this.buttonUsunCzytelnik.UseVisualStyleBackColor = false;
            this.buttonUsunCzytelnik.Click += new System.EventHandler(this.buttonUsunCzytelnik_Click);
            // 
            // textBoxUsunCzytelnik
            // 
            this.textBoxUsunCzytelnik.Location = new System.Drawing.Point(45, 37);
            this.textBoxUsunCzytelnik.Name = "textBoxUsunCzytelnik";
            this.textBoxUsunCzytelnik.Size = new System.Drawing.Size(83, 20);
            this.textBoxUsunCzytelnik.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Wpisz imię";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(6, 36);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(99, 20);
            this.textBoxImie.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Wpisz nazwisko";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(9, 75);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(96, 20);
            this.textBoxNazwisko.TabIndex = 23;
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonWyszukaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWyszukaj.Location = new System.Drawing.Point(30, 101);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(75, 34);
            this.buttonWyszukaj.TabIndex = 25;
            this.buttonWyszukaj.Text = "Wyszukaj czytelnika";
            this.buttonWyszukaj.UseVisualStyleBackColor = false;
            this.buttonWyszukaj.Click += new System.EventHandler(this.buttonWyszukaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonWyszukaj);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxNazwisko);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxImie);
            this.groupBox2.Location = new System.Drawing.Point(106, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 146);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyszukaj czytelnika";
            // 
            // buttonwyszukajwypozyczenia
            // 
            this.buttonwyszukajwypozyczenia.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonwyszukajwypozyczenia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwyszukajwypozyczenia.Location = new System.Drawing.Point(69, 78);
            this.buttonwyszukajwypozyczenia.Name = "buttonwyszukajwypozyczenia";
            this.buttonwyszukajwypozyczenia.Size = new System.Drawing.Size(63, 23);
            this.buttonwyszukajwypozyczenia.TabIndex = 27;
            this.buttonwyszukajwypozyczenia.Text = "Wyszukaj";
            this.buttonwyszukajwypozyczenia.UseVisualStyleBackColor = false;
            this.buttonwyszukajwypozyczenia.Click += new System.EventHandler(this.buttonwyszukajwypozyczenia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.buttonwyszukajwypozyczenia);
            this.groupBox3.Controls.Add(this.textBoxwyszukajwypozyczenia);
            this.groupBox3.Location = new System.Drawing.Point(375, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 146);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wyszukaj wypożyczenia czytelnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Wprowadź ID czytelnika";
            // 
            // textBoxwyszukajwypozyczenia
            // 
            this.textBoxwyszukajwypozyczenia.Location = new System.Drawing.Point(49, 52);
            this.textBoxwyszukajwypozyczenia.Name = "textBoxwyszukajwypozyczenia";
            this.textBoxwyszukajwypozyczenia.Size = new System.Drawing.Size(83, 20);
            this.textBoxwyszukajwypozyczenia.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ObsługaBiblioteki.Properties.Resources.men_2763099_1280;
            this.pictureBox1.Location = new System.Drawing.Point(852, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Czytelnicy";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCzytelnik);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Czytelnicy";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCzytelnik)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonwypożyczenia4;
        private System.Windows.Forms.Button buttonklienci4;
        private System.Windows.Forms.Button buttonautorwydawnictwo4;
        private System.Windows.Forms.Button buttonksiazka4;
        private System.Windows.Forms.Button buttonglowna4;
        private System.Windows.Forms.DataGridView dataGridViewCzytelnik;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUsunCzytelnik;
        private System.Windows.Forms.TextBox textBoxUsunCzytelnik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonwyszukajwypozyczenia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxwyszukajwypozyczenia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonwyszukiwanie4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}