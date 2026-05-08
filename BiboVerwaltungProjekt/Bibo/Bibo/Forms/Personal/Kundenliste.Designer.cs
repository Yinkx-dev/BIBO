namespace Bibo.Forms.Personal
{
    partial class Kundenliste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kundenliste));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeaderBuecherliste = new System.Windows.Forms.Panel();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.homeText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSucheaufheben = new System.Windows.Forms.PictureBox();
            this.buttonSucheKundenListe = new System.Windows.Forms.PictureBox();
            this.textBoxSucheKundenListe = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNeuerKunde = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHomeKundenListe = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableKundenliste = new System.Windows.Forms.DataGridView();
            this.colKundenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNutzername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPasswort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGeburtsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStrasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHausnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWohnort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeleteButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.HeaderBuecherliste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSucheaufheben)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSucheKundenListe)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNeuerKunde)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHomeKundenListe)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableKundenliste)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBuecherliste
            // 
            this.HeaderBuecherliste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.HeaderBuecherliste.Controls.Add(this.pictureHome);
            this.HeaderBuecherliste.Controls.Add(this.homeText);
            this.HeaderBuecherliste.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBuecherliste.Location = new System.Drawing.Point(0, 0);
            this.HeaderBuecherliste.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderBuecherliste.Name = "HeaderBuecherliste";
            this.HeaderBuecherliste.Size = new System.Drawing.Size(1264, 49);
            this.HeaderBuecherliste.TabIndex = 2;
            // 
            // pictureHome
            // 
            this.pictureHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(500, 4);
            this.pictureHome.Margin = new System.Windows.Forms.Padding(4);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(46, 36);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHome.TabIndex = 1;
            this.pictureHome.TabStop = false;
            // 
            // homeText
            // 
            this.homeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.homeText.Location = new System.Drawing.Point(0, 0);
            this.homeText.Margin = new System.Windows.Forms.Padding(0);
            this.homeText.MinimumSize = new System.Drawing.Size(120, 38);
            this.homeText.Name = "homeText";
            this.homeText.Size = new System.Drawing.Size(1264, 49);
            this.homeText.TabIndex = 0;
            this.homeText.Text = "Kundenliste";
            this.homeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonSucheaufheben);
            this.panel3.Controls.Add(this.buttonSucheKundenListe);
            this.panel3.Controls.Add(this.textBoxSucheKundenListe);
            this.panel3.Location = new System.Drawing.Point(413, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 46);
            this.panel3.TabIndex = 8;
            // 
            // buttonSucheaufheben
            // 
            this.buttonSucheaufheben.Image = ((System.Drawing.Image)(resources.GetObject("buttonSucheaufheben.Image")));
            this.buttonSucheaufheben.Location = new System.Drawing.Point(400, 8);
            this.buttonSucheaufheben.Name = "buttonSucheaufheben";
            this.buttonSucheaufheben.Size = new System.Drawing.Size(21, 26);
            this.buttonSucheaufheben.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSucheaufheben.TabIndex = 16;
            this.buttonSucheaufheben.TabStop = false;
            this.buttonSucheaufheben.Click += new System.EventHandler(this.buttonSucheaufheben_Click);
            // 
            // buttonSucheKundenListe
            // 
            this.buttonSucheKundenListe.Image = ((System.Drawing.Image)(resources.GetObject("buttonSucheKundenListe.Image")));
            this.buttonSucheKundenListe.Location = new System.Drawing.Point(4, 8);
            this.buttonSucheKundenListe.Name = "buttonSucheKundenListe";
            this.buttonSucheKundenListe.Size = new System.Drawing.Size(43, 30);
            this.buttonSucheKundenListe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSucheKundenListe.TabIndex = 3;
            this.buttonSucheKundenListe.TabStop = false;
            this.buttonSucheKundenListe.Click += new System.EventHandler(this.buttonSucheKundenListe_Click);
            // 
            // textBoxSucheKundenListe
            // 
            this.textBoxSucheKundenListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSucheKundenListe.Location = new System.Drawing.Point(52, 8);
            this.textBoxSucheKundenListe.Name = "textBoxSucheKundenListe";
            this.textBoxSucheKundenListe.Size = new System.Drawing.Size(342, 26);
            this.textBoxSucheKundenListe.TabIndex = 6;
            this.textBoxSucheKundenListe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSucheKundenListe_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonNeuerKunde);
            this.panel2.Location = new System.Drawing.Point(14, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 42);
            this.panel2.TabIndex = 9;
            // 
            // buttonNeuerKunde
            // 
            this.buttonNeuerKunde.Image = ((System.Drawing.Image)(resources.GetObject("buttonNeuerKunde.Image")));
            this.buttonNeuerKunde.Location = new System.Drawing.Point(-1, -1);
            this.buttonNeuerKunde.Name = "buttonNeuerKunde";
            this.buttonNeuerKunde.Size = new System.Drawing.Size(49, 42);
            this.buttonNeuerKunde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonNeuerKunde.TabIndex = 3;
            this.buttonNeuerKunde.TabStop = false;
            this.buttonNeuerKunde.Click += new System.EventHandler(this.buttonNeuerKunde_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonHomeKundenListe);
            this.panel1.Location = new System.Drawing.Point(1201, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 42);
            this.panel1.TabIndex = 10;
            // 
            // buttonHomeKundenListe
            // 
            this.buttonHomeKundenListe.Image = ((System.Drawing.Image)(resources.GetObject("buttonHomeKundenListe.Image")));
            this.buttonHomeKundenListe.Location = new System.Drawing.Point(-1, 3);
            this.buttonHomeKundenListe.Name = "buttonHomeKundenListe";
            this.buttonHomeKundenListe.Size = new System.Drawing.Size(49, 38);
            this.buttonHomeKundenListe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHomeKundenListe.TabIndex = 2;
            this.buttonHomeKundenListe.TabStop = false;
            this.buttonHomeKundenListe.Click += new System.EventHandler(this.buttonHomeKundenListe_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.tableKundenliste);
            this.panel4.Location = new System.Drawing.Point(14, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1236, 626);
            this.panel4.TabIndex = 11;
            // 
            // tableKundenliste
            // 
            this.tableKundenliste.AllowUserToAddRows = false;
            this.tableKundenliste.AllowUserToDeleteRows = false;
            this.tableKundenliste.AllowUserToResizeColumns = false;
            this.tableKundenliste.AllowUserToResizeRows = false;
            this.tableKundenliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableKundenliste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableKundenliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableKundenliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKundenID,
            this.colNutzername,
            this.colPasswort,
            this.colName,
            this.colGeburtsdatum,
            this.colStrasse,
            this.colHausnummer,
            this.colPlz,
            this.colWohnort,
            this.colDeleteButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableKundenliste.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableKundenliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableKundenliste.EnableHeadersVisualStyles = false;
            this.tableKundenliste.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableKundenliste.Location = new System.Drawing.Point(0, 0);
            this.tableKundenliste.Margin = new System.Windows.Forms.Padding(4);
            this.tableKundenliste.MultiSelect = false;
            this.tableKundenliste.Name = "tableKundenliste";
            this.tableKundenliste.ReadOnly = true;
            this.tableKundenliste.RowHeadersVisible = false;
            this.tableKundenliste.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableKundenliste.RowTemplate.Height = 75;
            this.tableKundenliste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableKundenliste.Size = new System.Drawing.Size(1236, 626);
            this.tableKundenliste.TabIndex = 2;
            this.tableKundenliste.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableKundenliste_CellMouseClick);
            // 
            // colKundenID
            // 
            this.colKundenID.FillWeight = 47.37235F;
            this.colKundenID.HeaderText = "ID";
            this.colKundenID.Name = "colKundenID";
            this.colKundenID.ReadOnly = true;
            // 
            // colNutzername
            // 
            this.colNutzername.FillWeight = 94.7447F;
            this.colNutzername.HeaderText = "Nutzername";
            this.colNutzername.MinimumWidth = 6;
            this.colNutzername.Name = "colNutzername";
            this.colNutzername.ReadOnly = true;
            // 
            // colPasswort
            // 
            this.colPasswort.FillWeight = 94.7447F;
            this.colPasswort.HeaderText = "Passwort";
            this.colPasswort.MinimumWidth = 6;
            this.colPasswort.Name = "colPasswort";
            this.colPasswort.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.FillWeight = 94.7447F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colGeburtsdatum
            // 
            this.colGeburtsdatum.FillWeight = 94.7447F;
            this.colGeburtsdatum.HeaderText = "Geburtsdatum";
            this.colGeburtsdatum.MinimumWidth = 6;
            this.colGeburtsdatum.Name = "colGeburtsdatum";
            this.colGeburtsdatum.ReadOnly = true;
            // 
            // colStrasse
            // 
            this.colStrasse.FillWeight = 94.7447F;
            this.colStrasse.HeaderText = "Straße";
            this.colStrasse.MinimumWidth = 6;
            this.colStrasse.Name = "colStrasse";
            this.colStrasse.ReadOnly = true;
            // 
            // colHausnummer
            // 
            this.colHausnummer.FillWeight = 94.7447F;
            this.colHausnummer.HeaderText = "Hausnummer";
            this.colHausnummer.MinimumWidth = 6;
            this.colHausnummer.Name = "colHausnummer";
            this.colHausnummer.ReadOnly = true;
            // 
            // colPlz
            // 
            this.colPlz.FillWeight = 94.7447F;
            this.colPlz.HeaderText = "PLZ";
            this.colPlz.MinimumWidth = 6;
            this.colPlz.Name = "colPlz";
            this.colPlz.ReadOnly = true;
            // 
            // colWohnort
            // 
            this.colWohnort.FillWeight = 94.7447F;
            this.colWohnort.HeaderText = "Wohnort";
            this.colWohnort.MinimumWidth = 6;
            this.colWohnort.Name = "colWohnort";
            this.colWohnort.ReadOnly = true;
            // 
            // colDeleteButton
            // 
            this.colDeleteButton.FillWeight = 25F;
            this.colDeleteButton.HeaderText = "";
            this.colDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("colDeleteButton.Image")));
            this.colDeleteButton.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDeleteButton.Name = "colDeleteButton";
            this.colDeleteButton.ReadOnly = true;
            // 
            // Kundenliste
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.HeaderBuecherliste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kundenliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibo";
            this.HeaderBuecherliste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSucheaufheben)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSucheKundenListe)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonNeuerKunde)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonHomeKundenListe)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableKundenliste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBuecherliste;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Label homeText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox buttonSucheKundenListe;
        private System.Windows.Forms.TextBox textBoxSucheKundenListe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox buttonNeuerKunde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox buttonHomeKundenListe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tableKundenliste;
        private System.Windows.Forms.PictureBox buttonSucheaufheben;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKundenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNutzername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPasswort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGeburtsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStrasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHausnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlz;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWohnort;
        private System.Windows.Forms.DataGridViewImageColumn colDeleteButton;
    }
}