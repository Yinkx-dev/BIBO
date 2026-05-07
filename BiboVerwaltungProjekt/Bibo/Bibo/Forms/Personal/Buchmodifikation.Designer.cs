namespace Bibo.Forms.Personal
{
    partial class Buchmodifikation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buchmodifikation));
            this.HeaderBuchmodifaktion = new System.Windows.Forms.Panel();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.homeText = new System.Windows.Forms.Label();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.dropdownGenre = new System.Windows.Forms.ComboBox();
            this.dropdownAlter = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCoverhochladen2 = new System.Windows.Forms.PictureBox();
            this.buttonCoverhochladen = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.buttonSpeichernBuchmodi = new System.Windows.Forms.Button();
            this.buttonAbbrechenBuchmodi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonHomeBuchModi = new System.Windows.Forms.PictureBox();
            this.labelTitel = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelErscheinungsdatum = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAlter = new System.Windows.Forms.Label();
            this.labelKurzbeschreibung = new System.Windows.Forms.Label();
            this.textBoxErscheinungsdatum = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.richTextBoxKurzbeschreibung = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonZurueckBuecherliste = new System.Windows.Forms.PictureBox();
            this.HeaderBuchmodifaktion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCoverhochladen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHomeBuchModi)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonZurueckBuecherliste)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBuchmodifaktion
            // 
            this.HeaderBuchmodifaktion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.HeaderBuchmodifaktion.Controls.Add(this.pictureHome);
            this.HeaderBuchmodifaktion.Controls.Add(this.homeText);
            this.HeaderBuchmodifaktion.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBuchmodifaktion.Location = new System.Drawing.Point(0, 0);
            this.HeaderBuchmodifaktion.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderBuchmodifaktion.Name = "HeaderBuchmodifaktion";
            this.HeaderBuchmodifaktion.Size = new System.Drawing.Size(1264, 49);
            this.HeaderBuchmodifaktion.TabIndex = 1;
            // 
            // pictureHome
            // 
            this.pictureHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(454, 0);
            this.pictureHome.Margin = new System.Windows.Forms.Padding(4);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(60, 49);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHome.TabIndex = 1;
            this.pictureHome.TabStop = false;
            // 
            // homeText
            // 
            this.homeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.homeText.Location = new System.Drawing.Point(0, 0);
            this.homeText.Margin = new System.Windows.Forms.Padding(0);
            this.homeText.MinimumSize = new System.Drawing.Size(120, 38);
            this.homeText.Name = "homeText";
            this.homeText.Size = new System.Drawing.Size(1264, 49);
            this.homeText.TabIndex = 0;
            this.homeText.Text = "Buchmodifikation";
            this.homeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitel.Location = new System.Drawing.Point(158, 134);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(344, 26);
            this.textBoxTitel.TabIndex = 2;
            // 
            // dropdownGenre
            // 
            this.dropdownGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownGenre.FormattingEnabled = true;
            this.dropdownGenre.Items.AddRange(new object[] {
            "Fantasy",
            "Horror",
            "Humor/Satire",
            "Kinderbuch",
            "Kochen",
            "Romance",
            "Science-Fiction",
            "Thriller",
            "True Crime",
            "Young Adult"});
            this.dropdownGenre.Location = new System.Drawing.Point(158, 304);
            this.dropdownGenre.Name = "dropdownGenre";
            this.dropdownGenre.Size = new System.Drawing.Size(344, 28);
            this.dropdownGenre.TabIndex = 4;
            // 
            // dropdownAlter
            // 
            this.dropdownAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownAlter.FormattingEnabled = true;
            this.dropdownAlter.Items.AddRange(new object[] {
            "Erwachsene",
            "Jugendliche",
            "Kind",
            "Kleinkind"});
            this.dropdownAlter.Location = new System.Drawing.Point(772, 304);
            this.dropdownAlter.Name = "dropdownAlter";
            this.dropdownAlter.Size = new System.Drawing.Size(344, 28);
            this.dropdownAlter.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBoxCover);
            this.panel1.Location = new System.Drawing.Point(160, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 238);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonCoverhochladen2);
            this.panel3.Controls.Add(this.buttonCoverhochladen);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 40);
            this.panel3.TabIndex = 29;
            // 
            // buttonCoverhochladen2
            // 
            this.buttonCoverhochladen2.BackColor = System.Drawing.Color.Transparent;
            this.buttonCoverhochladen2.Image = ((System.Drawing.Image)(resources.GetObject("buttonCoverhochladen2.Image")));
            this.buttonCoverhochladen2.Location = new System.Drawing.Point(100, 3);
            this.buttonCoverhochladen2.Name = "buttonCoverhochladen2";
            this.buttonCoverhochladen2.Size = new System.Drawing.Size(60, 32);
            this.buttonCoverhochladen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonCoverhochladen2.TabIndex = 27;
            this.buttonCoverhochladen2.TabStop = false;
            // 
            // buttonCoverhochladen
            // 
            this.buttonCoverhochladen.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCoverhochladen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCoverhochladen.FlatAppearance.BorderSize = 0;
            this.buttonCoverhochladen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCoverhochladen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCoverhochladen.Location = new System.Drawing.Point(-3, -1);
            this.buttonCoverhochladen.Name = "buttonCoverhochladen";
            this.buttonCoverhochladen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCoverhochladen.Size = new System.Drawing.Size(165, 40);
            this.buttonCoverhochladen.TabIndex = 9;
            this.buttonCoverhochladen.Text = "Ändern";
            this.buttonCoverhochladen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCoverhochladen.UseVisualStyleBackColor = false;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCover.Image")));
            this.pictureBoxCover.Location = new System.Drawing.Point(-1, 37);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(165, 196);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 0;
            this.pictureBoxCover.TabStop = false;
            // 
            // buttonSpeichernBuchmodi
            // 
            this.buttonSpeichernBuchmodi.AutoSize = true;
            this.buttonSpeichernBuchmodi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSpeichernBuchmodi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(191)))));
            this.buttonSpeichernBuchmodi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpeichernBuchmodi.FlatAppearance.BorderSize = 0;
            this.buttonSpeichernBuchmodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeichernBuchmodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeichernBuchmodi.Location = new System.Drawing.Point(290, 666);
            this.buttonSpeichernBuchmodi.Name = "buttonSpeichernBuchmodi";
            this.buttonSpeichernBuchmodi.Padding = new System.Windows.Forms.Padding(70, 15, 70, 15);
            this.buttonSpeichernBuchmodi.Size = new System.Drawing.Size(247, 64);
            this.buttonSpeichernBuchmodi.TabIndex = 10;
            this.buttonSpeichernBuchmodi.Text = "Speichern";
            this.buttonSpeichernBuchmodi.UseVisualStyleBackColor = false;
            // 
            // buttonAbbrechenBuchmodi
            // 
            this.buttonAbbrechenBuchmodi.AutoSize = true;
            this.buttonAbbrechenBuchmodi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAbbrechenBuchmodi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbbrechenBuchmodi.FlatAppearance.BorderSize = 0;
            this.buttonAbbrechenBuchmodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbbrechenBuchmodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbbrechenBuchmodi.Location = new System.Drawing.Point(688, 666);
            this.buttonAbbrechenBuchmodi.Name = "buttonAbbrechenBuchmodi";
            this.buttonAbbrechenBuchmodi.Padding = new System.Windows.Forms.Padding(70, 15, 70, 15);
            this.buttonAbbrechenBuchmodi.Size = new System.Drawing.Size(282, 71);
            this.buttonAbbrechenBuchmodi.TabIndex = 11;
            this.buttonAbbrechenBuchmodi.Text = "Abbrechen";
            this.buttonAbbrechenBuchmodi.UseVisualStyleBackColor = false;
            this.buttonAbbrechenBuchmodi.Click += new System.EventHandler(this.buttonAbbrechenBuchmodi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonHomeBuchModi);
            this.panel2.Location = new System.Drawing.Point(1180, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 42);
            this.panel2.TabIndex = 13;
            // 
            // buttonHomeBuchModi
            // 
            this.buttonHomeBuchModi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHomeBuchModi.Image = ((System.Drawing.Image)(resources.GetObject("buttonHomeBuchModi.Image")));
            this.buttonHomeBuchModi.Location = new System.Drawing.Point(-1, 3);
            this.buttonHomeBuchModi.Name = "buttonHomeBuchModi";
            this.buttonHomeBuchModi.Size = new System.Drawing.Size(49, 38);
            this.buttonHomeBuchModi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHomeBuchModi.TabIndex = 2;
            this.buttonHomeBuchModi.TabStop = false;
            this.buttonHomeBuchModi.Click += new System.EventHandler(this.buttonHomeBuchModi_Click);
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.Location = new System.Drawing.Point(155, 102);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(45, 24);
            this.labelTitel.TabIndex = 14;
            this.labelTitel.Text = "Titel";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.Location = new System.Drawing.Point(769, 102);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(52, 24);
            this.labelISBN.TabIndex = 15;
            this.labelISBN.Text = "ISBN";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(155, 174);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(55, 24);
            this.labelAutor.TabIndex = 16;
            this.labelAutor.Text = "Autor";
            // 
            // labelErscheinungsdatum
            // 
            this.labelErscheinungsdatum.AutoSize = true;
            this.labelErscheinungsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErscheinungsdatum.Location = new System.Drawing.Point(769, 186);
            this.labelErscheinungsdatum.Name = "labelErscheinungsdatum";
            this.labelErscheinungsdatum.Size = new System.Drawing.Size(179, 24);
            this.labelErscheinungsdatum.TabIndex = 17;
            this.labelErscheinungsdatum.Text = "Erscheinungsdatum";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(155, 272);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(63, 24);
            this.labelGenre.TabIndex = 18;
            this.labelGenre.Text = "Genre";
            // 
            // labelAlter
            // 
            this.labelAlter.AutoSize = true;
            this.labelAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlter.Location = new System.Drawing.Point(769, 272);
            this.labelAlter.Name = "labelAlter";
            this.labelAlter.Size = new System.Drawing.Size(118, 24);
            this.labelAlter.TabIndex = 19;
            this.labelAlter.Text = "Altersgruppe";
            // 
            // labelKurzbeschreibung
            // 
            this.labelKurzbeschreibung.AutoSize = true;
            this.labelKurzbeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKurzbeschreibung.Location = new System.Drawing.Point(364, 383);
            this.labelKurzbeschreibung.Name = "labelKurzbeschreibung";
            this.labelKurzbeschreibung.Size = new System.Drawing.Size(165, 24);
            this.labelKurzbeschreibung.TabIndex = 20;
            this.labelKurzbeschreibung.Text = "Kurzbeschreibung";
            // 
            // textBoxErscheinungsdatum
            // 
            this.textBoxErscheinungsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxErscheinungsdatum.Location = new System.Drawing.Point(772, 218);
            this.textBoxErscheinungsdatum.Name = "textBoxErscheinungsdatum";
            this.textBoxErscheinungsdatum.Size = new System.Drawing.Size(344, 26);
            this.textBoxErscheinungsdatum.TabIndex = 6;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutor.Location = new System.Drawing.Point(158, 206);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(344, 26);
            this.textBoxAutor.TabIndex = 3;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxISBN.Location = new System.Drawing.Point(772, 134);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(344, 26);
            this.textBoxISBN.TabIndex = 5;
            // 
            // richTextBoxKurzbeschreibung
            // 
            this.richTextBoxKurzbeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxKurzbeschreibung.Location = new System.Drawing.Point(369, 415);
            this.richTextBoxKurzbeschreibung.Name = "richTextBoxKurzbeschreibung";
            this.richTextBoxKurzbeschreibung.Size = new System.Drawing.Size(733, 209);
            this.richTextBoxKurzbeschreibung.TabIndex = 8;
            this.richTextBoxKurzbeschreibung.Text = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonZurueckBuecherliste);
            this.panel4.Location = new System.Drawing.Point(1180, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(49, 42);
            this.panel4.TabIndex = 21;
            // 
            // buttonZurueckBuecherliste
            // 
            this.buttonZurueckBuecherliste.Image = ((System.Drawing.Image)(resources.GetObject("buttonZurueckBuecherliste.Image")));
            this.buttonZurueckBuecherliste.Location = new System.Drawing.Point(3, 2);
            this.buttonZurueckBuecherliste.Name = "buttonZurueckBuecherliste";
            this.buttonZurueckBuecherliste.Size = new System.Drawing.Size(41, 35);
            this.buttonZurueckBuecherliste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonZurueckBuecherliste.TabIndex = 11;
            this.buttonZurueckBuecherliste.TabStop = false;
            this.buttonZurueckBuecherliste.Click += new System.EventHandler(this.buttonZurueckBuecherliste_Click);
            // 
            // Buchmodifikation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.richTextBoxKurzbeschreibung);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxErscheinungsdatum);
            this.Controls.Add(this.labelKurzbeschreibung);
            this.Controls.Add(this.labelAlter);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelErscheinungsdatum);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonAbbrechenBuchmodi);
            this.Controls.Add(this.buttonSpeichernBuchmodi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dropdownAlter);
            this.Controls.Add(this.dropdownGenre);
            this.Controls.Add(this.textBoxTitel);
            this.Controls.Add(this.HeaderBuchmodifaktion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Buchmodifikation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibo";
            this.HeaderBuchmodifaktion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonCoverhochladen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonHomeBuchModi)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonZurueckBuecherliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBuchmodifaktion;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Label homeText;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.ComboBox dropdownGenre;
        private System.Windows.Forms.ComboBox dropdownAlter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Button buttonSpeichernBuchmodi;
        private System.Windows.Forms.Button buttonAbbrechenBuchmodi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox buttonHomeBuchModi;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelErscheinungsdatum;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAlter;
        private System.Windows.Forms.Label labelKurzbeschreibung;
        private System.Windows.Forms.TextBox textBoxErscheinungsdatum;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.RichTextBox richTextBoxKurzbeschreibung;
        private System.Windows.Forms.PictureBox buttonCoverhochladen2;
        private System.Windows.Forms.Button buttonCoverhochladen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox buttonZurueckBuecherliste;
    }
}