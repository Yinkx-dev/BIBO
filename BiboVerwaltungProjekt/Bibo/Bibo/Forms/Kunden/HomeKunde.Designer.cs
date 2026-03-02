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
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.panelTable = new System.Windows.Forms.Panel();
            this.birthdateText = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.Label();
            this.homeHeaderBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKundeHome)).BeginInit();
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
            this.homeHeaderBackground.Name = "homeHeaderBackground";
            this.homeHeaderBackground.Size = new System.Drawing.Size(1008, 51);
            this.homeHeaderBackground.TabIndex = 0;
            // 
            // pictureHome
            // 
            this.pictureHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(408, 3);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(44, 51);
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
            this.homeText.MinimumSize = new System.Drawing.Size(90, 31);
            this.homeText.Name = "homeText";
            this.homeText.Size = new System.Drawing.Size(1008, 51);
            this.homeText.TabIndex = 0;
            this.homeText.Text = "Home";
            this.homeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buchlisteHeader
            // 
            this.buchlisteHeader.AutoSize = true;
            this.buchlisteHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buchlisteHeader.Location = new System.Drawing.Point(19, 71);
            this.buchlisteHeader.Name = "buchlisteHeader";
            this.buchlisteHeader.Size = new System.Drawing.Size(141, 24);
            this.buchlisteHeader.TabIndex = 1;
            this.buchlisteHeader.Text = "Meine Bücher";
            // 
            // nameHeader
            // 
            this.nameHeader.AutoSize = true;
            this.nameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameHeader.Location = new System.Drawing.Point(94, 634);
            this.nameHeader.Name = "nameHeader";
            this.nameHeader.Size = new System.Drawing.Size(52, 18);
            this.nameHeader.TabIndex = 6;
            this.nameHeader.Text = "Name";
            // 
            // birthdateHeader
            // 
            this.birthdateHeader.AutoSize = true;
            this.birthdateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateHeader.Location = new System.Drawing.Point(798, 634);
            this.birthdateHeader.Name = "birthdateHeader";
            this.birthdateHeader.Size = new System.Drawing.Size(114, 18);
            this.birthdateHeader.TabIndex = 7;
            this.birthdateHeader.Text = "Geburtsdatum";
            // 
            // addressHeader
            // 
            this.addressHeader.AutoSize = true;
            this.addressHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressHeader.Location = new System.Drawing.Point(440, 634);
            this.addressHeader.Name = "addressHeader";
            this.addressHeader.Size = new System.Drawing.Size(69, 18);
            this.addressHeader.TabIndex = 8;
            this.addressHeader.Text = "Adresse";
            // 
            // discoverNewButton
            // 
            this.discoverNewButton.AutoSize = true;
            this.discoverNewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.discoverNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(191)))));
            this.discoverNewButton.FlatAppearance.BorderSize = 0;
            this.discoverNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discoverNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discoverNewButton.Location = new System.Drawing.Point(350, 532);
            this.discoverNewButton.Name = "discoverNewButton";
            this.discoverNewButton.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.discoverNewButton.Size = new System.Drawing.Size(301, 50);
            this.discoverNewButton.TabIndex = 9;
            this.discoverNewButton.Text = "Neue Meisterwerke entdecken";
            this.discoverNewButton.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.Location = new System.Drawing.Point(937, 67);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(59, 28);
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
            this.tableKundeHome.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableKundeHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableKundeHome.Enabled = false;
            this.tableKundeHome.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableKundeHome.Location = new System.Drawing.Point(23, 102);
            this.tableKundeHome.Name = "tableKundeHome";
            this.tableKundeHome.ReadOnly = true;
            this.tableKundeHome.RowHeadersVisible = false;
            this.tableKundeHome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tableKundeHome.Size = new System.Drawing.Size(957, 150);
            this.tableKundeHome.TabIndex = 12;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // panelTable
            // 
            this.panelTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTable.BackColor = System.Drawing.Color.Silver;
            this.panelTable.Location = new System.Drawing.Point(23, 102);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(957, 387);
            this.panelTable.TabIndex = 13;
            // 
            // birthdateText
            // 
            this.birthdateText.AutoSize = true;
            this.birthdateText.Location = new System.Drawing.Point(800, 661);
            this.birthdateText.Name = "birthdateText";
            this.birthdateText.Size = new System.Drawing.Size(68, 13);
            this.birthdateText.TabIndex = 14;
            this.birthdateText.Text = "Geburtseeee";
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Location = new System.Drawing.Point(94, 661);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(65, 13);
            this.nameText.TabIndex = 15;
            this.nameText.Text = "Nameeeeee";
            // 
            // addressText
            // 
            this.addressText.AutoSize = true;
            this.addressText.Location = new System.Drawing.Point(440, 661);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(64, 13);
            this.addressText.TabIndex = 16;
            this.addressText.Text = "Adreseeeee";
            // 
            // HomeKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.birthdateText);
            this.Controls.Add(this.tableKundeHome);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.discoverNewButton);
            this.Controls.Add(this.addressHeader);
            this.Controls.Add(this.birthdateHeader);
            this.Controls.Add(this.nameHeader);
            this.Controls.Add(this.buchlisteHeader);
            this.Controls.Add(this.homeHeaderBackground);
            this.Controls.Add(this.panelTable);
            this.Name = "HomeKunde";
            this.Text = "Bibo";
            this.homeHeaderBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKundeHome)).EndInit();
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
    }
}