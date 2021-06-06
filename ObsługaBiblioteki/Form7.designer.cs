namespace Search_EngineModels
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtRequestURI10 = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.wyszukaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequestURI11 = new System.Windows.Forms.TextBox();
            this.wyszukaj2 = new System.Windows.Forms.Button();
            this.wyszukaj3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonwyszukiwanie5 = new System.Windows.Forms.Button();
            this.buttonwyszukiwanie4 = new System.Windows.Forms.Button();
            this.buttonklienci4 = new System.Windows.Forms.Button();
            this.buttonautorwydawnictwo4 = new System.Windows.Forms.Button();
            this.buttonksiazka4 = new System.Windows.Forms.Button();
            this.buttonglowna4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRequestURI10
            // 
            this.txtRequestURI10.Location = new System.Drawing.Point(276, 22);
            this.txtRequestURI10.Name = "txtRequestURI10";
            this.txtRequestURI10.Size = new System.Drawing.Size(185, 20);
            this.txtRequestURI10.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(145, 94);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(653, 335);
            this.txtResponse.TabIndex = 1;
            // 
            // wyszukaj
            // 
            this.wyszukaj.BackColor = System.Drawing.Color.BurlyWood;
            this.wyszukaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wyszukaj.Location = new System.Drawing.Point(353, 50);
            this.wyszukaj.Name = "wyszukaj";
            this.wyszukaj.Size = new System.Drawing.Size(108, 38);
            this.wyszukaj.TabIndex = 4;
            this.wyszukaj.Text = "Wyszukaj informacji po tytule";
            this.wyszukaj.UseVisualStyleBackColor = false;
            this.wyszukaj.Click += new System.EventHandler(this.wyszukaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wprowadź tytuł książki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Wprowadź autora";
            // 
            // txtRequestURI11
            // 
            this.txtRequestURI11.Location = new System.Drawing.Point(585, 22);
            this.txtRequestURI11.Name = "txtRequestURI11";
            this.txtRequestURI11.Size = new System.Drawing.Size(185, 20);
            this.txtRequestURI11.TabIndex = 14;
            // 
            // wyszukaj2
            // 
            this.wyszukaj2.BackColor = System.Drawing.Color.BurlyWood;
            this.wyszukaj2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wyszukaj2.Location = new System.Drawing.Point(659, 50);
            this.wyszukaj2.Name = "wyszukaj2";
            this.wyszukaj2.Size = new System.Drawing.Size(111, 38);
            this.wyszukaj2.TabIndex = 16;
            this.wyszukaj2.Text = "Wyszukaj informacji po autorze";
            this.wyszukaj2.UseVisualStyleBackColor = false;
            this.wyszukaj2.Click += new System.EventHandler(this.wyszukaj2_Click);
            // 
            // wyszukaj3
            // 
            this.wyszukaj3.BackColor = System.Drawing.Color.BurlyWood;
            this.wyszukaj3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wyszukaj3.Location = new System.Drawing.Point(799, 22);
            this.wyszukaj3.Name = "wyszukaj3";
            this.wyszukaj3.Size = new System.Drawing.Size(87, 58);
            this.wyszukaj3.TabIndex = 17;
            this.wyszukaj3.Text = "Wyszukaj wspólnych informacji";
            this.wyszukaj3.UseVisualStyleBackColor = false;
            this.wyszukaj3.Click += new System.EventHandler(this.wyszukaj3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonwyszukiwanie5);
            this.panel1.Controls.Add(this.buttonwyszukiwanie4);
            this.panel1.Controls.Add(this.buttonklienci4);
            this.panel1.Controls.Add(this.buttonautorwydawnictwo4);
            this.panel1.Controls.Add(this.buttonksiazka4);
            this.panel1.Controls.Add(this.buttonglowna4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 461);
            this.panel1.TabIndex = 18;
            // 
            // buttonwyszukiwanie5
            // 
            this.buttonwyszukiwanie5.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonwyszukiwanie5.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonwyszukiwanie5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwyszukiwanie5.Location = new System.Drawing.Point(0, 300);
            this.buttonwyszukiwanie5.Name = "buttonwyszukiwanie5";
            this.buttonwyszukiwanie5.Size = new System.Drawing.Size(100, 60);
            this.buttonwyszukiwanie5.TabIndex = 32;
            this.buttonwyszukiwanie5.Text = "Wyszukiwanie";
            this.buttonwyszukiwanie5.UseVisualStyleBackColor = false;
            this.buttonwyszukiwanie5.Click += new System.EventHandler(this.buttonwyszukiwanie5_Click);
            // 
            // buttonwyszukiwanie4
            // 
            this.buttonwyszukiwanie4.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonwyszukiwanie4.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonwyszukiwanie4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwyszukiwanie4.Location = new System.Drawing.Point(0, 240);
            this.buttonwyszukiwanie4.Name = "buttonwyszukiwanie4";
            this.buttonwyszukiwanie4.Size = new System.Drawing.Size(100, 60);
            this.buttonwyszukiwanie4.TabIndex = 4;
            this.buttonwyszukiwanie4.Text = "Wypożyczenia";
            this.buttonwyszukiwanie4.UseVisualStyleBackColor = false;
            this.buttonwyszukiwanie4.Click += new System.EventHandler(this.buttonwyszukiwanie4_Click);
            // 
            // buttonklienci4
            // 
            this.buttonklienci4.BackColor = System.Drawing.Color.NavajoWhite;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ObsługaBiblioteki.Properties.Resources.information_1657276_1280;
            this.pictureBox2.Location = new System.Drawing.Point(818, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wyszukaj3);
            this.Controls.Add(this.wyszukaj2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRequestURI11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wyszukaj);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRequestURI10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wyszukiwanie internetowe";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequestURI10;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button wyszukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequestURI11;
        private System.Windows.Forms.Button wyszukaj2;
        private System.Windows.Forms.Button wyszukaj3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonwyszukiwanie5;
        private System.Windows.Forms.Button buttonwyszukiwanie4;
        private System.Windows.Forms.Button buttonklienci4;
        private System.Windows.Forms.Button buttonautorwydawnictwo4;
        private System.Windows.Forms.Button buttonksiazka4;
        private System.Windows.Forms.Button buttonglowna4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

