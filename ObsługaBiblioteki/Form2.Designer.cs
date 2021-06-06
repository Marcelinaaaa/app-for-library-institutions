namespace ObsługaBiblioteki
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridViewKsiazka = new System.Windows.Forms.DataGridView();
            this.buttonAktualizuj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonzapiszXML = new System.Windows.Forms.Button();
            this.buttonwyszukiwanie2 = new System.Windows.Forms.Button();
            this.buttonwypozyczenia2 = new System.Windows.Forms.Button();
            this.buttonklienci2 = new System.Windows.Forms.Button();
            this.buttonautorwydawnictwo2 = new System.Windows.Forms.Button();
            this.buttonksiazka2 = new System.Windows.Forms.Button();
            this.buttonglowna2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUsunKsiazke = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonwyszukajautorid = new System.Windows.Forms.Button();
            this.textBoxwyszukaj = new System.Windows.Forms.TextBox();
            this.buttonwyszukajautornaz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonwyszukajwydnaz = new System.Windows.Forms.Button();
            this.textBoxwyszukajwyd = new System.Windows.Forms.TextBox();
            this.buttonwyszukajwydid = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKsiazka)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKsiazka
            // 
            this.dataGridViewKsiazka.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKsiazka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKsiazka.Location = new System.Drawing.Point(124, 25);
            this.dataGridViewKsiazka.Name = "dataGridViewKsiazka";
            this.dataGridViewKsiazka.Size = new System.Drawing.Size(560, 275);
            this.dataGridViewKsiazka.TabIndex = 0;
            // 
            // buttonAktualizuj
            // 
            this.buttonAktualizuj.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonAktualizuj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAktualizuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAktualizuj.Location = new System.Drawing.Point(0, 414);
            this.buttonAktualizuj.Name = "buttonAktualizuj";
            this.buttonAktualizuj.Size = new System.Drawing.Size(100, 47);
            this.buttonAktualizuj.TabIndex = 7;
            this.buttonAktualizuj.Text = "Zapisz zmiany w bazie";
            this.buttonAktualizuj.UseVisualStyleBackColor = false;
            this.buttonAktualizuj.Click += new System.EventHandler(this.buttonAktualizuj_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonzapiszXML);
            this.panel1.Controls.Add(this.buttonwyszukiwanie2);
            this.panel1.Controls.Add(this.buttonAktualizuj);
            this.panel1.Controls.Add(this.buttonwypozyczenia2);
            this.panel1.Controls.Add(this.buttonklienci2);
            this.panel1.Controls.Add(this.buttonautorwydawnictwo2);
            this.panel1.Controls.Add(this.buttonksiazka2);
            this.panel1.Controls.Add(this.buttonglowna2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 461);
            this.panel1.TabIndex = 10;
            // 
            // buttonzapiszXML
            // 
            this.buttonzapiszXML.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonzapiszXML.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonzapiszXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonzapiszXML.Location = new System.Drawing.Point(0, 367);
            this.buttonzapiszXML.Name = "buttonzapiszXML";
            this.buttonzapiszXML.Size = new System.Drawing.Size(100, 47);
            this.buttonzapiszXML.TabIndex = 9;
            this.buttonzapiszXML.Text = "Zapisz jako XML tabelę książek";
            this.buttonzapiszXML.UseVisualStyleBackColor = false;
            this.buttonzapiszXML.Click += new System.EventHandler(this.buttonzapiszXML_Click);
            // 
            // buttonwyszukiwanie2
            // 
            this.buttonwyszukiwanie2.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonwyszukiwanie2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonwyszukiwanie2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwyszukiwanie2.Location = new System.Drawing.Point(0, 300);
            this.buttonwyszukiwanie2.Name = "buttonwyszukiwanie2";
            this.buttonwyszukiwanie2.Size = new System.Drawing.Size(100, 60);
            this.buttonwyszukiwanie2.TabIndex = 8;
            this.buttonwyszukiwanie2.Text = "Wyszukiwanie";
            this.buttonwyszukiwanie2.UseVisualStyleBackColor = false;
            this.buttonwyszukiwanie2.Click += new System.EventHandler(this.buttonwyszukiwanie2_Click);
            // 
            // buttonwypozyczenia2
            // 
            this.buttonwypozyczenia2.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonwypozyczenia2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonwypozyczenia2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwypozyczenia2.Location = new System.Drawing.Point(0, 240);
            this.buttonwypozyczenia2.Name = "buttonwypozyczenia2";
            this.buttonwypozyczenia2.Size = new System.Drawing.Size(100, 60);
            this.buttonwypozyczenia2.TabIndex = 4;
            this.buttonwypozyczenia2.Text = "Wypożyczenia";
            this.buttonwypozyczenia2.UseVisualStyleBackColor = false;
            this.buttonwypozyczenia2.Click += new System.EventHandler(this.buttonwypożyczenia2_Click);
            // 
            // buttonklienci2
            // 
            this.buttonklienci2.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonklienci2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonklienci2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonklienci2.Location = new System.Drawing.Point(0, 180);
            this.buttonklienci2.Name = "buttonklienci2";
            this.buttonklienci2.Size = new System.Drawing.Size(100, 60);
            this.buttonklienci2.TabIndex = 3;
            this.buttonklienci2.Text = "Czytelnicy";
            this.buttonklienci2.UseVisualStyleBackColor = false;
            this.buttonklienci2.Click += new System.EventHandler(this.buttonklienci2_Click);
            // 
            // buttonautorwydawnictwo2
            // 
            this.buttonautorwydawnictwo2.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonautorwydawnictwo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonautorwydawnictwo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonautorwydawnictwo2.Location = new System.Drawing.Point(0, 120);
            this.buttonautorwydawnictwo2.Name = "buttonautorwydawnictwo2";
            this.buttonautorwydawnictwo2.Size = new System.Drawing.Size(100, 60);
            this.buttonautorwydawnictwo2.TabIndex = 2;
            this.buttonautorwydawnictwo2.Text = "Autorzy i wydawnictwa";
            this.buttonautorwydawnictwo2.UseVisualStyleBackColor = false;
            this.buttonautorwydawnictwo2.Click += new System.EventHandler(this.buttonautorwydawnictwo2_Click);
            // 
            // buttonksiazka2
            // 
            this.buttonksiazka2.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonksiazka2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonksiazka2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonksiazka2.Location = new System.Drawing.Point(0, 60);
            this.buttonksiazka2.Name = "buttonksiazka2";
            this.buttonksiazka2.Size = new System.Drawing.Size(100, 60);
            this.buttonksiazka2.TabIndex = 1;
            this.buttonksiazka2.Text = "Książki";
            this.buttonksiazka2.UseVisualStyleBackColor = false;
            this.buttonksiazka2.Click += new System.EventHandler(this.buttonksiazka2_Click);
            // 
            // buttonglowna2
            // 
            this.buttonglowna2.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonglowna2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonglowna2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonglowna2.Location = new System.Drawing.Point(0, 0);
            this.buttonglowna2.Name = "buttonglowna2";
            this.buttonglowna2.Size = new System.Drawing.Size(100, 60);
            this.buttonglowna2.TabIndex = 0;
            this.buttonglowna2.Text = "Strona główna";
            this.buttonglowna2.UseVisualStyleBackColor = false;
            this.buttonglowna2.Click += new System.EventHandler(this.buttonglowna2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(38, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Wyszukaj książki";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUsunKsiazke
            // 
            this.buttonUsunKsiazke.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonUsunKsiazke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUsunKsiazke.Location = new System.Drawing.Point(17, 59);
            this.buttonUsunKsiazke.Name = "buttonUsunKsiazke";
            this.buttonUsunKsiazke.Size = new System.Drawing.Size(96, 23);
            this.buttonUsunKsiazke.TabIndex = 14;
            this.buttonUsunKsiazke.Text = "Usuń";
            this.buttonUsunKsiazke.UseVisualStyleBackColor = false;
            this.buttonUsunKsiazke.Click += new System.EventHandler(this.buttonUsunKsiazke_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Wprowadź ID książki";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonUsunKsiazke);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(302, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuń książkę";
            // 
            // buttonwyszukajautorid
            // 
            this.buttonwyszukajautorid.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonwyszukajautorid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwyszukajautorid.Location = new System.Drawing.Point(15, 58);
            this.buttonwyszukajautorid.Name = "buttonwyszukajautorid";
            this.buttonwyszukajautorid.Size = new System.Drawing.Size(66, 34);
            this.buttonwyszukajautorid.TabIndex = 14;
            this.buttonwyszukajautorid.Text = "Wyszukaj po ID";
            this.buttonwyszukajautorid.UseVisualStyleBackColor = false;
            this.buttonwyszukajautorid.Click += new System.EventHandler(this.buttonwyszukajautorid_Click);
            // 
            // textBoxwyszukaj
            // 
            this.textBoxwyszukaj.Location = new System.Drawing.Point(11, 32);
            this.textBoxwyszukaj.Name = "textBoxwyszukaj";
            this.textBoxwyszukaj.Size = new System.Drawing.Size(159, 20);
            this.textBoxwyszukaj.TabIndex = 15;
            // 
            // buttonwyszukajautornaz
            // 
            this.buttonwyszukajautornaz.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonwyszukajautornaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwyszukajautornaz.Location = new System.Drawing.Point(87, 58);
            this.buttonwyszukajautornaz.Name = "buttonwyszukajautornaz";
            this.buttonwyszukajautornaz.Size = new System.Drawing.Size(74, 34);
            this.buttonwyszukajautornaz.TabIndex = 16;
            this.buttonwyszukajautornaz.Text = "Wyszukaj po nazwisku";
            this.buttonwyszukajautornaz.UseVisualStyleBackColor = false;
            this.buttonwyszukajautornaz.Click += new System.EventHandler(this.buttonwyszukajautornaz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Wprowadź tytuł";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Wprowadź rok wydania";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonwyszukajautornaz);
            this.groupBox2.Controls.Add(this.textBoxwyszukaj);
            this.groupBox2.Controls.Add(this.buttonwyszukajautorid);
            this.groupBox2.Location = new System.Drawing.Point(472, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 133);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyszukaj autora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Wprowadź ID lub nazwisko autora";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(124, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 134);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wyszukaj książkę";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.buttonwyszukajwydnaz);
            this.groupBox4.Controls.Add(this.textBoxwyszukajwyd);
            this.groupBox4.Controls.Add(this.buttonwyszukajwydid);
            this.groupBox4.Location = new System.Drawing.Point(658, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 133);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wyszukaj wydawnictwo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Wprowadź ID lub nazwę wydawnictwa";
            // 
            // buttonwyszukajwydnaz
            // 
            this.buttonwyszukajwydnaz.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonwyszukajwydnaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwyszukajwydnaz.Location = new System.Drawing.Point(101, 57);
            this.buttonwyszukajwydnaz.Name = "buttonwyszukajwydnaz";
            this.buttonwyszukajwydnaz.Size = new System.Drawing.Size(74, 34);
            this.buttonwyszukajwydnaz.TabIndex = 16;
            this.buttonwyszukajwydnaz.Text = "Wyszukaj po nazwie";
            this.buttonwyszukajwydnaz.UseVisualStyleBackColor = false;
            this.buttonwyszukajwydnaz.Click += new System.EventHandler(this.buttonwyszukajwydnaz_Click);
            // 
            // textBoxwyszukajwyd
            // 
            this.textBoxwyszukajwyd.Location = new System.Drawing.Point(8, 32);
            this.textBoxwyszukajwyd.Name = "textBoxwyszukajwyd";
            this.textBoxwyszukajwyd.Size = new System.Drawing.Size(185, 20);
            this.textBoxwyszukajwyd.TabIndex = 15;
            // 
            // buttonwyszukajwydid
            // 
            this.buttonwyszukajwydid.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonwyszukajwydid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwyszukajwydid.Location = new System.Drawing.Point(17, 57);
            this.buttonwyszukajwydid.Name = "buttonwyszukajwydid";
            this.buttonwyszukajwydid.Size = new System.Drawing.Size(66, 34);
            this.buttonwyszukajwydid.TabIndex = 14;
            this.buttonwyszukajwydid.Text = "Wyszukaj po ID";
            this.buttonwyszukajwydid.UseVisualStyleBackColor = false;
            this.buttonwyszukajwydid.Click += new System.EventHandler(this.buttonwyszukajwydid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Książki";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::ObsługaBiblioteki.Properties.Resources.floral_309762_1280;
            this.pictureBox1.Location = new System.Drawing.Point(750, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewKsiazka);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Książki";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKsiazka)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKsiazka;
        private System.Windows.Forms.Button buttonAktualizuj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonwypozyczenia2;
        private System.Windows.Forms.Button buttonklienci2;
        private System.Windows.Forms.Button buttonautorwydawnictwo2;
        private System.Windows.Forms.Button buttonksiazka2;
        private System.Windows.Forms.Button buttonglowna2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUsunKsiazke;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonwyszukajautorid;
        private System.Windows.Forms.TextBox textBoxwyszukaj;
        private System.Windows.Forms.Button buttonwyszukajautornaz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonwyszukajwydnaz;
        private System.Windows.Forms.TextBox textBoxwyszukajwyd;
        private System.Windows.Forms.Button buttonwyszukajwydid;
        private System.Windows.Forms.Button buttonwyszukiwanie2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonzapiszXML;
    }
}