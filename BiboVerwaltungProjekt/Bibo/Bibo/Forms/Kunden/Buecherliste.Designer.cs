namespace Bibo
{
    partial class Buecherliste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buecherliste));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeText = new System.Windows.Forms.Label();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.buttonSearchbar = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableBuecherliste = new System.Windows.Forms.DataGridView();
            this.colBewertung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCover = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeihstatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearchbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBuecherliste)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.homeText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 49);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(486, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.homeText.TabIndex = 1;
            this.homeText.Text = "Bücherliste";
            this.homeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchbar
            // 
            this.searchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbar.Location = new System.Drawing.Point(432, 82);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(343, 24);
            this.searchbar.TabIndex = 9;
            // 
            // buttonSearchbar
            // 
            this.buttonSearchbar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchbar.Image")));
            this.buttonSearchbar.Location = new System.Drawing.Point(772, 83);
            this.buttonSearchbar.Name = "buttonSearchbar";
            this.buttonSearchbar.Size = new System.Drawing.Size(28, 23);
            this.buttonSearchbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSearchbar.TabIndex = 10;
            this.buttonSearchbar.TabStop = false;
            // 
            // buttonHome
            // 
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(-1, -1);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(49, 48);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHome.TabIndex = 11;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonHome);
            this.panel2.Location = new System.Drawing.Point(1199, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 48);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.tableBuecherliste);
            this.panel3.Location = new System.Drawing.Point(12, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1236, 628);
            this.panel3.TabIndex = 13;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableBuecherliste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableBuecherliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableBuecherliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBewertung,
            this.colCover,
            this.colTitel,
            this.colAutor,
            this.colGenre,
            this.colAlter,
            this.colLeihstatus});
            this.tableBuecherliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBuecherliste.EnableHeadersVisualStyles = false;
            this.tableBuecherliste.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableBuecherliste.Location = new System.Drawing.Point(0, 0);
            this.tableBuecherliste.Margin = new System.Windows.Forms.Padding(4);
            this.tableBuecherliste.MultiSelect = false;
            this.tableBuecherliste.Name = "tableBuecherliste";
            this.tableBuecherliste.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableBuecherliste.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableBuecherliste.RowHeadersVisible = false;
            this.tableBuecherliste.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableBuecherliste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableBuecherliste.Size = new System.Drawing.Size(1236, 628);
            this.tableBuecherliste.TabIndex = 1;
            // 
            // colBewertung
            // 
            this.colBewertung.FillWeight = 50F;
            this.colBewertung.HeaderText = "Bewertung";
            this.colBewertung.Name = "colBewertung";
            this.colBewertung.ReadOnly = true;
            this.colBewertung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBewertung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCover
            // 
            this.colCover.FillWeight = 50F;
            this.colCover.HeaderText = "Cover";
            this.colCover.Name = "colCover";
            this.colCover.ReadOnly = true;
            // 
            // colTitel
            // 
            this.colTitel.FillWeight = 120F;
            this.colTitel.HeaderText = "Titel";
            this.colTitel.Name = "colTitel";
            this.colTitel.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.FillWeight = 50F;
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colGenre
            // 
            this.colGenre.FillWeight = 40F;
            this.colGenre.HeaderText = "Genre";
            this.colGenre.Name = "colGenre";
            this.colGenre.ReadOnly = true;
            // 
            // colAlter
            // 
            this.colAlter.FillWeight = 40F;
            this.colAlter.HeaderText = "Altersgruppe";
            this.colAlter.Name = "colAlter";
            this.colAlter.ReadOnly = true;
            // 
            // colLeihstatus
            // 
            this.colLeihstatus.FillWeight = 30F;
            this.colLeihstatus.HeaderText = "Verfügbar";
            this.colLeihstatus.Name = "colLeihstatus";
            this.colLeihstatus.ReadOnly = true;
            this.colLeihstatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLeihstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Buecherliste
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonSearchbar);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Buecherliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearchbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBuecherliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label homeText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.PictureBox buttonSearchbar;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tableBuecherliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBewertung;
        private System.Windows.Forms.DataGridViewImageColumn colCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colLeihstatus;
    }
}