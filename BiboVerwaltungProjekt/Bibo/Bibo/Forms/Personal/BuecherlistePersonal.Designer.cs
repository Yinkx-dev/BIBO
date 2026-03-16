namespace Bibo.Forms.Personal
{
    partial class BuecherlistePersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuecherlistePersonal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeaderBuecherliste = new System.Windows.Forms.Panel();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.homeText = new System.Windows.Forms.Label();
            this.buttonHomeBuecherListe = new System.Windows.Forms.PictureBox();
            this.buttonNeuesBuch = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSuche = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSuche = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableBuecherliste = new System.Windows.Forms.DataGridView();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErscheinungsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeihstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderBuecherliste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHomeBuecherListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNeuesBuch)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSuche)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBuecherliste)).BeginInit();
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
            this.HeaderBuecherliste.TabIndex = 1;
            // 
            // pictureHome
            // 
            this.pictureHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(481, 0);
            this.pictureHome.Margin = new System.Windows.Forms.Padding(4);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(51, 49);
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
            this.homeText.Text = "Bücherliste";
            this.homeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHomeBuecherListe
            // 
            this.buttonHomeBuecherListe.Image = ((System.Drawing.Image)(resources.GetObject("buttonHomeBuecherListe.Image")));
            this.buttonHomeBuecherListe.Location = new System.Drawing.Point(-1, 3);
            this.buttonHomeBuecherListe.Name = "buttonHomeBuecherListe";
            this.buttonHomeBuecherListe.Size = new System.Drawing.Size(49, 38);
            this.buttonHomeBuecherListe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHomeBuecherListe.TabIndex = 2;
            this.buttonHomeBuecherListe.TabStop = false;
            // 
            // buttonNeuesBuch
            // 
            this.buttonNeuesBuch.Image = ((System.Drawing.Image)(resources.GetObject("buttonNeuesBuch.Image")));
            this.buttonNeuesBuch.Location = new System.Drawing.Point(-1, -1);
            this.buttonNeuesBuch.Name = "buttonNeuesBuch";
            this.buttonNeuesBuch.Size = new System.Drawing.Size(49, 42);
            this.buttonNeuesBuch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonNeuesBuch.TabIndex = 3;
            this.buttonNeuesBuch.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonHomeBuecherListe);
            this.panel1.Location = new System.Drawing.Point(1201, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 42);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonNeuesBuch);
            this.panel2.Location = new System.Drawing.Point(14, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 42);
            this.panel2.TabIndex = 5;
            // 
            // textBoxSuche
            // 
            this.textBoxSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuche.Location = new System.Drawing.Point(52, 8);
            this.textBoxSuche.Name = "textBoxSuche";
            this.textBoxSuche.Size = new System.Drawing.Size(370, 30);
            this.textBoxSuche.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonSuche);
            this.panel3.Controls.Add(this.textBoxSuche);
            this.panel3.Location = new System.Drawing.Point(413, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 46);
            this.panel3.TabIndex = 7;
            // 
            // buttonSuche
            // 
            this.buttonSuche.Image = ((System.Drawing.Image)(resources.GetObject("buttonSuche.Image")));
            this.buttonSuche.Location = new System.Drawing.Point(4, 8);
            this.buttonSuche.Name = "buttonSuche";
            this.buttonSuche.Size = new System.Drawing.Size(43, 30);
            this.buttonSuche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSuche.TabIndex = 3;
            this.buttonSuche.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.tableBuecherliste);
            this.panel4.Location = new System.Drawing.Point(14, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1236, 626);
            this.panel4.TabIndex = 8;
            // 
            // tableBuecherliste
            // 
            this.tableBuecherliste.AllowUserToAddRows = false;
            this.tableBuecherliste.AllowUserToDeleteRows = false;
            this.tableBuecherliste.AllowUserToResizeColumns = false;
            this.tableBuecherliste.AllowUserToResizeRows = false;
            this.tableBuecherliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableBuecherliste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableBuecherliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableBuecherliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colISBN,
            this.colTitel,
            this.colAutor,
            this.colErscheinungsdatum,
            this.colAlter,
            this.colGenre,
            this.colLeihstatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableBuecherliste.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableBuecherliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBuecherliste.EnableHeadersVisualStyles = false;
            this.tableBuecherliste.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableBuecherliste.Location = new System.Drawing.Point(0, 0);
            this.tableBuecherliste.Margin = new System.Windows.Forms.Padding(4);
            this.tableBuecherliste.MultiSelect = false;
            this.tableBuecherliste.Name = "tableBuecherliste";
            this.tableBuecherliste.ReadOnly = true;
            this.tableBuecherliste.RowHeadersVisible = false;
            this.tableBuecherliste.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableBuecherliste.RowTemplate.Height = 75;
            this.tableBuecherliste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableBuecherliste.Size = new System.Drawing.Size(1236, 626);
            this.tableBuecherliste.TabIndex = 2;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.MinimumWidth = 6;
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            // 
            // colTitel
            // 
            this.colTitel.HeaderText = "Titel";
            this.colTitel.MinimumWidth = 6;
            this.colTitel.Name = "colTitel";
            this.colTitel.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 6;
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colErscheinungsdatum
            // 
            this.colErscheinungsdatum.HeaderText = "Erscheinungsdatum";
            this.colErscheinungsdatum.MinimumWidth = 6;
            this.colErscheinungsdatum.Name = "colErscheinungsdatum";
            this.colErscheinungsdatum.ReadOnly = true;
            // 
            // colAlter
            // 
            this.colAlter.HeaderText = "Altersgruppe";
            this.colAlter.MinimumWidth = 6;
            this.colAlter.Name = "colAlter";
            this.colAlter.ReadOnly = true;
            // 
            // colGenre
            // 
            this.colGenre.HeaderText = "Genre";
            this.colGenre.MinimumWidth = 6;
            this.colGenre.Name = "colGenre";
            this.colGenre.ReadOnly = true;
            // 
            // colLeihstatus
            // 
            this.colLeihstatus.HeaderText = "Leihstatus";
            this.colLeihstatus.MinimumWidth = 6;
            this.colLeihstatus.Name = "colLeihstatus";
            this.colLeihstatus.ReadOnly = true;
            // 
            // BuecherlistePersonal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderBuecherliste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BuecherlistePersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibo";
            this.HeaderBuecherliste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHomeBuecherListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNeuesBuch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSuche)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBuecherliste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBuecherliste;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Label homeText;
        private System.Windows.Forms.PictureBox buttonHomeBuecherListe;
        private System.Windows.Forms.PictureBox buttonNeuesBuch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSuche;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox buttonSuche;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tableBuecherliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErscheinungsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeihstatus;
    }
}