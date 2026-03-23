namespace Bibo
{
    partial class HomeKunde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeKunde));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.homeHeaderBackground = new System.Windows.Forms.Panel();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.homeText = new System.Windows.Forms.Label();
            this.buchlisteHeader = new System.Windows.Forms.Label();
            this.nameHeader = new System.Windows.Forms.Label();
            this.birthdateHeader = new System.Windows.Forms.Label();
            this.addressHeader = new System.Windows.Forms.Label();
            this.discoverNewButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.tableKundeHome = new System.Windows.Forms.DataGridView();
            this.colCover = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeihfrist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBewertung = new System.Windows.Forms.DataGridViewImageColumn();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.panelTable = new System.Windows.Forms.Panel();
            this.birthdateText = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.homeHeaderBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKundeHome)).BeginInit();
            this.panelTable.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeHeaderBackground
            // 
            this.homeHeaderBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeHeaderBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.homeHeaderBackground.Controls.Add(this.pictureHome);
            this.homeHeaderBackground.Controls.Add(this.homeText);
            this.homeHeaderBackground.Location = new System.Drawing.Point(0, 0);
            this.homeHeaderBackground.Margin = new System.Windows.Forms.Padding(4);
            this.homeHeaderBackground.Name = "homeHeaderBackground";
            this.homeHeaderBackground.Size = new System.Drawing.Size(1264, 49);
            this.homeHeaderBackground.TabIndex = 0;
            // 
            // pictureHome
            // 
            this.pictureHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(535, 4);
            this.pictureHome.Margin = new System.Windows.Forms.Padding(4);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(41, 45);
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
            this.homeText.Text = "Home";
            this.homeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buchlisteHeader
            // 
            this.buchlisteHeader.AutoSize = true;
            this.buchlisteHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buchlisteHeader.Location = new System.Drawing.Point(13, 65);
            this.buchlisteHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buchlisteHeader.Name = "buchlisteHeader";
            this.buchlisteHeader.Size = new System.Drawing.Size(141, 24);
            this.buchlisteHeader.TabIndex = 1;
            this.buchlisteHeader.Text = "Meine Bücher";
            // 
            // nameHeader
            // 
            this.nameHeader.AutoSize = true;
            this.nameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameHeader.Location = new System.Drawing.Point(122, 699);
            this.nameHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameHeader.Name = "nameHeader";
            this.nameHeader.Size = new System.Drawing.Size(55, 20);
            this.nameHeader.TabIndex = 6;
            this.nameHeader.Text = "Name";
            // 
            // birthdateHeader
            // 
            this.birthdateHeader.AutoSize = true;
            this.birthdateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateHeader.Location = new System.Drawing.Point(1031, 699);
            this.birthdateHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdateHeader.Name = "birthdateHeader";
            this.birthdateHeader.Size = new System.Drawing.Size(124, 20);
            this.birthdateHeader.TabIndex = 7;
            this.birthdateHeader.Text = "Geburtsdatum";
            // 
            // addressHeader
            // 
            this.addressHeader.AutoSize = true;
            this.addressHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressHeader.Location = new System.Drawing.Point(583, 699);
            this.addressHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressHeader.Name = "addressHeader";
            this.addressHeader.Size = new System.Drawing.Size(75, 20);
            this.addressHeader.TabIndex = 8;
            this.addressHeader.Text = "Adresse";
            // 
            // discoverNewButton
            // 
            this.discoverNewButton.AutoSize = true;
            this.discoverNewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.discoverNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(191)))));
            this.discoverNewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discoverNewButton.FlatAppearance.BorderSize = 0;
            this.discoverNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discoverNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discoverNewButton.Location = new System.Drawing.Point(463, 616);
            this.discoverNewButton.Margin = new System.Windows.Forms.Padding(4);
            this.discoverNewButton.Name = "discoverNewButton";
            this.discoverNewButton.Padding = new System.Windows.Forms.Padding(27, 12, 27, 12);
            this.discoverNewButton.Size = new System.Drawing.Size(315, 54);
            this.discoverNewButton.TabIndex = 9;
            this.discoverNewButton.Text = "Neue Meisterwerke entdecken";
            this.discoverNewButton.UseVisualStyleBackColor = false;
            this.discoverNewButton.Click += new System.EventHandler(this.discoverNewButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.Location = new System.Drawing.Point(4, 3);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(38, 34);
            this.logoutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutButton.TabIndex = 10;
            this.logoutButton.TabStop = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // tableKundeHome
            // 
            this.tableKundeHome.AllowUserToAddRows = false;
            this.tableKundeHome.AllowUserToDeleteRows = false;
            this.tableKundeHome.AllowUserToResizeColumns = false;
            this.tableKundeHome.AllowUserToResizeRows = false;
            this.tableKundeHome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableKundeHome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableKundeHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableKundeHome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCover,
            this.colTitle,
            this.colAutor,
            this.colLeihfrist,
            this.colBewertung});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableKundeHome.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableKundeHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableKundeHome.EnableHeadersVisualStyles = false;
            this.tableKundeHome.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableKundeHome.Location = new System.Drawing.Point(0, 0);
            this.tableKundeHome.Margin = new System.Windows.Forms.Padding(4);
            this.tableKundeHome.MultiSelect = false;
            this.tableKundeHome.Name = "tableKundeHome";
            this.tableKundeHome.ReadOnly = true;
            this.tableKundeHome.RowHeadersVisible = false;
            this.tableKundeHome.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableKundeHome.RowTemplate.Height = 75;
            this.tableKundeHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableKundeHome.Size = new System.Drawing.Size(1236, 476);
            this.tableKundeHome.TabIndex = 0;
            this.tableKundeHome.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableKundeHome_CellMouseClick);
            // 
            // colCover
            // 
            this.colCover.FillWeight = 30F;
            this.colCover.HeaderText = "Cover";
            this.colCover.Image = ((System.Drawing.Image)(resources.GetObject("colCover.Image")));
            this.colCover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colCover.MinimumWidth = 6;
            this.colCover.Name = "colCover";
            this.colCover.ReadOnly = true;
            this.colCover.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Titel";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.FillWeight = 25F;
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 6;
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colLeihfrist
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.colLeihfrist.DefaultCellStyle = dataGridViewCellStyle5;
            this.colLeihfrist.FillWeight = 25F;
            this.colLeihfrist.HeaderText = "Leihfrist";
            this.colLeihfrist.MinimumWidth = 6;
            this.colLeihfrist.Name = "colLeihfrist";
            this.colLeihfrist.ReadOnly = true;
            // 
            // colBewertung
            // 
            this.colBewertung.FillWeight = 25F;
            this.colBewertung.HeaderText = "Rezension schreiben";
            this.colBewertung.Image = ((System.Drawing.Image)(resources.GetObject("colBewertung.Image")));
            this.colBewertung.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colBewertung.MinimumWidth = 6;
            this.colBewertung.Name = "colBewertung";
            this.colBewertung.ReadOnly = true;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // panelTable
            // 
            this.panelTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTable.BackColor = System.Drawing.Color.Silver;
            this.panelTable.Controls.Add(this.tableKundeHome);
            this.panelTable.Location = new System.Drawing.Point(13, 102);
            this.panelTable.Margin = new System.Windows.Forms.Padding(4);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(1236, 476);
            this.panelTable.TabIndex = 13;
            // 
            // birthdateText
            // 
            this.birthdateText.AutoSize = true;
            this.birthdateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateText.Location = new System.Drawing.Point(1034, 733);
            this.birthdateText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdateText.Name = "birthdateText";
            this.birthdateText.Size = new System.Drawing.Size(91, 17);
            this.birthdateText.TabIndex = 14;
            this.birthdateText.Text = "Geburtseeee";
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(123, 733);
            this.nameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(85, 17);
            this.nameText.TabIndex = 15;
            this.nameText.Text = "Nameeeeee";
            // 
            // addressText
            // 
            this.addressText.AutoSize = true;
            this.addressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(584, 733);
            this.addressText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(85, 17);
            this.addressText.TabIndex = 16;
            this.addressText.Text = "Adreseeeee";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.logoutButton);
            this.panel3.Location = new System.Drawing.Point(1200, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(49, 42);
            this.panel3.TabIndex = 37;
            // 
            // HomeKunde
            // 
            this.AcceptButton = this.discoverNewButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.birthdateText);
            this.Controls.Add(this.discoverNewButton);
            this.Controls.Add(this.addressHeader);
            this.Controls.Add(this.birthdateHeader);
            this.Controls.Add(this.nameHeader);
            this.Controls.Add(this.buchlisteHeader);
            this.Controls.Add(this.homeHeaderBackground);
            this.Controls.Add(this.panelTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HomeKunde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibo";
            this.homeHeaderBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKundeHome)).EndInit();
            this.panelTable.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel homeHeaderBackground;
        private System.Windows.Forms.Label homeText;
        private System.Windows.Forms.Label buchlisteHeader;
        private System.Windows.Forms.Label nameHeader;
        private System.Windows.Forms.Label birthdateHeader;
        private System.Windows.Forms.Label addressHeader;
        private System.Windows.Forms.Button discoverNewButton;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.PictureBox logoutButton;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.DataGridView tableKundeHome;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Label birthdateText;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label addressText;
        private System.Windows.Forms.DataGridViewImageColumn colCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeihfrist;
        private System.Windows.Forms.DataGridViewImageColumn colBewertung;
        private System.Windows.Forms.Panel panel3;
    }
}