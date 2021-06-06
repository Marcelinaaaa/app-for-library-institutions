namespace ObsługaBiblioteki
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonwyszukiwanie1 = new System.Windows.Forms.Button();
            this.buttonwypożyczenia1 = new System.Windows.Forms.Button();
            this.buttonklienci1 = new System.Windows.Forms.Button();
            this.buttonautorwydawnictwo1 = new System.Windows.Forms.Button();
            this.buttonksiazka1 = new System.Windows.Forms.Button();
            this.buttonglowna1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.buttonwyszukiwanie1);
            this.panel1.Controls.Add(this.buttonwypożyczenia1);
            this.panel1.Controls.Add(this.buttonklienci1);
            this.panel1.Controls.Add(this.buttonautorwydawnictwo1);
            this.panel1.Controls.Add(this.buttonksiazka1);
            this.panel1.Controls.Add(this.buttonglowna1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 361);
            this.panel1.TabIndex = 9;
            // 
            // buttonwyszukiwanie1
            // 
            this.buttonwyszukiwanie1.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonwyszukiwanie1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonwyszukiwanie1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwyszukiwanie1.Location = new System.Drawing.Point(0, 300);
            this.buttonwyszukiwanie1.Name = "buttonwyszukiwanie1";
            this.buttonwyszukiwanie1.Size = new System.Drawing.Size(100, 60);
            this.buttonwyszukiwanie1.TabIndex = 5;
            this.buttonwyszukiwanie1.Text = "Wyszukiwanie";
            this.buttonwyszukiwanie1.UseVisualStyleBackColor = false;
            this.buttonwyszukiwanie1.Click += new System.EventHandler(this.buttonwyszukiwanie1_Click);
            // 
            // buttonwypożyczenia1
            // 
            this.buttonwypożyczenia1.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonwypożyczenia1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonwypożyczenia1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonwypożyczenia1.Location = new System.Drawing.Point(0, 240);
            this.buttonwypożyczenia1.Name = "buttonwypożyczenia1";
            this.buttonwypożyczenia1.Size = new System.Drawing.Size(100, 60);
            this.buttonwypożyczenia1.TabIndex = 4;
            this.buttonwypożyczenia1.Text = "Wypożyczenia";
            this.buttonwypożyczenia1.UseVisualStyleBackColor = false;
            this.buttonwypożyczenia1.Click += new System.EventHandler(this.buttonwypożyczenia1_Click);
            // 
            // buttonklienci1
            // 
            this.buttonklienci1.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonklienci1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonklienci1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonklienci1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonklienci1.Location = new System.Drawing.Point(0, 180);
            this.buttonklienci1.Name = "buttonklienci1";
            this.buttonklienci1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonklienci1.Size = new System.Drawing.Size(100, 60);
            this.buttonklienci1.TabIndex = 3;
            this.buttonklienci1.Text = "Czytelnicy";
            this.buttonklienci1.UseVisualStyleBackColor = false;
            this.buttonklienci1.Click += new System.EventHandler(this.buttonklienci_Click);
            // 
            // buttonautorwydawnictwo1
            // 
            this.buttonautorwydawnictwo1.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonautorwydawnictwo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonautorwydawnictwo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonautorwydawnictwo1.Location = new System.Drawing.Point(0, 120);
            this.buttonautorwydawnictwo1.Name = "buttonautorwydawnictwo1";
            this.buttonautorwydawnictwo1.Size = new System.Drawing.Size(100, 60);
            this.buttonautorwydawnictwo1.TabIndex = 2;
            this.buttonautorwydawnictwo1.Text = "Autorzy i wydawnictwa";
            this.buttonautorwydawnictwo1.UseVisualStyleBackColor = false;
            this.buttonautorwydawnictwo1.Click += new System.EventHandler(this.buttonautorwydawnictwo1_Click);
            // 
            // buttonksiazka1
            // 
            this.buttonksiazka1.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonksiazka1.BackgroundImage = global::ObsługaBiblioteki.Properties.Resources.floral_309762_1280;
            this.buttonksiazka1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonksiazka1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonksiazka1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonksiazka1.Location = new System.Drawing.Point(0, 60);
            this.buttonksiazka1.Name = "buttonksiazka1";
            this.buttonksiazka1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonksiazka1.Size = new System.Drawing.Size(100, 60);
            this.buttonksiazka1.TabIndex = 1;
            this.buttonksiazka1.Text = "Książki";
            this.buttonksiazka1.UseVisualStyleBackColor = false;
            this.buttonksiazka1.Click += new System.EventHandler(this.buttonksiazka1_Click);
            // 
            // buttonglowna1
            // 
            this.buttonglowna1.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonglowna1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonglowna1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonglowna1.Location = new System.Drawing.Point(0, 0);
            this.buttonglowna1.Name = "buttonglowna1";
            this.buttonglowna1.Size = new System.Drawing.Size(100, 60);
            this.buttonglowna1.TabIndex = 0;
            this.buttonglowna1.Text = "Strona główna";
            this.buttonglowna1.UseVisualStyleBackColor = false;
            this.buttonglowna1.Click += new System.EventHandler(this.buttonglowna1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(205, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "BIBLIOBSŁUGA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(187, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Witaj w programie wspomagającym obsługę biblioteki!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(166, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Z bocznego menu wybierz zakładkę, do której chcesz przejść.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(435, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Miłej pracy!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(481, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Informacje\r\no aplikacji";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strona główna";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonwypożyczenia1;
        private System.Windows.Forms.Button buttonklienci1;
        private System.Windows.Forms.Button buttonautorwydawnictwo1;
        private System.Windows.Forms.Button buttonksiazka1;
        private System.Windows.Forms.Button buttonglowna1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonwyszukiwanie1;
        private System.Windows.Forms.Button button1;
    }
}

