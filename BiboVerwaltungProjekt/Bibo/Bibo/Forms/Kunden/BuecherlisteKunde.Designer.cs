namespace Bibo
{
    partial class BuecherlisteKunde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuecherlisteKunde));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeText = new System.Windows.Forms.Label();
            this.buttonHomeBuecherlisteKunde = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableBuecherliste = new System.Windows.Forms.DataGridView();
            this.colBewertung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCover = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeihstatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonSucheaufheben = new System.Windows.Forms.PictureBox();
            this.buttonSucheBuecherlisteKunde = new System.Windows.Forms.PictureBox();
            this.textBoxSucheBuecherlisteKunde = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHomeBuecherlisteKunde)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBuecherliste)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSucheaufheben)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSucheBuecherlisteKunde)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(491, 0);
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
            // buttonHomeBuecherlisteKunde
            // 
            this.buttonHomeBuecherlisteKunde.Image = ((System.Drawing.Image)(resources.GetObject("buttonHomeBuecherlisteKunde.Image")));
            this.buttonHomeBuecherlisteKunde.Location = new System.Drawing.Point(-1, 2);
            this.buttonHomeBuecherlisteKunde.Name = "buttonHomeBuecherlisteKunde";
            this.buttonHomeBuecherlisteKunde.Size = new System.Drawing.Size(49, 38);
            this.buttonHomeBuecherlisteKunde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHomeBuecherlisteKunde.TabIndex = 11;
            this.buttonHomeBuecherlisteKunde.TabStop = false;
            this.buttonHomeBuecherlisteKunde.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonHomeBuecherlisteKunde);
            this.panel2.Location = new System.Drawing.Point(1199, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 42);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableBuecherliste.DefaultCellStyle = dataGridViewCellStyle5;
            this.tableBuecherliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBuecherliste.EnableHeadersVisualStyles = false;
            this.tableBuecherliste.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableBuecherliste.Location = new System.Drawing.Point(0, 0);
            this.tableBuecherliste.Margin = new System.Windows.Forms.Padding(4);
            this.tableBuecherliste.MultiSelect = false;
            this.tableBuecherliste.Name = "tableBuecherliste";
            this.tableBuecherliste.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableBuecherliste.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tableBuecherliste.RowHeadersVisible = false;
            this.tableBuecherliste.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableBuecherliste.RowTemplate.Height = 75;
            this.tableBuecherliste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableBuecherliste.Size = new System.Drawing.Size(1236, 628);
            this.tableBuecherliste.TabIndex = 10;
            // 
            // colBewertung
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBewertung.DefaultCellStyle = dataGridViewCellStyle2;
            this.colBewertung.FillWeight = 50F;
            this.colBewertung.HeaderText = "Bewertung";
            this.colBewertung.Name = "colBewertung";
            this.colBewertung.ReadOnly = true;
            this.colBewertung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCover
            // 
            this.colCover.FillWeight = 50F;
            this.colCover.HeaderText = "Cover";
            this.colCover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colCover.Name = "colCover";
            this.colCover.ReadOnly = true;
            // 
            // colTitel
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colTitel.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTitel.FillWeight = 120F;
            this.colTitel.HeaderText = "Titel";
            this.colTitel.Name = "colTitel";
            this.colTitel.ReadOnly = true;
            this.colTitel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAutor
            // 
            this.colAutor.FillWeight = 50F;
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            this.colAutor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(25);
            this.colLeihstatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.colLeihstatus.FillWeight = 30F;
            this.colLeihstatus.HeaderText = "Verfügbar";
            this.colLeihstatus.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colLeihstatus.Name = "colLeihstatus";
            this.colLeihstatus.ReadOnly = true;
            this.colLeihstatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLeihstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonSucheaufheben);
            this.panel4.Controls.Add(this.buttonSucheBuecherlisteKunde);
            this.panel4.Controls.Add(this.textBoxSucheBuecherlisteKunde);
            this.panel4.Location = new System.Drawing.Point(413, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 46);
            this.panel4.TabIndex = 14;
            // 
            // buttonSucheaufheben
            // 
            this.buttonSucheaufheben.Image = ((System.Drawing.Image)(resources.GetObject("buttonSucheaufheben.Image")));
            this.buttonSucheaufheben.Location = new System.Drawing.Point(420, 9);
            this.buttonSucheaufheben.Name = "buttonSucheaufheben";
            this.buttonSucheaufheben.Size = new System.Drawing.Size(21, 26);
            this.buttonSucheaufheben.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSucheaufheben.TabIndex = 15;
            this.buttonSucheaufheben.TabStop = false;
            this.buttonSucheaufheben.Click += new System.EventHandler(this.buttonSucheaufheben_Click);
            // 
            // buttonSucheBuecherlisteKunde
            // 
            this.buttonSucheBuecherlisteKunde.Image = ((System.Drawing.Image)(resources.GetObject("buttonSucheBuecherlisteKunde.Image")));
            this.buttonSucheBuecherlisteKunde.Location = new System.Drawing.Point(4, 6);
            this.buttonSucheBuecherlisteKunde.Name = "buttonSucheBuecherlisteKunde";
            this.buttonSucheBuecherlisteKunde.Size = new System.Drawing.Size(43, 30);
            this.buttonSucheBuecherlisteKunde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSucheBuecherlisteKunde.TabIndex = 3;
            this.buttonSucheBuecherlisteKunde.TabStop = false;
            this.buttonSucheBuecherlisteKunde.Click += new System.EventHandler(this.buttonSucheBuecherlisteKunde_Click);
            // 
            // textBoxSucheBuecherlisteKunde
            // 
            this.textBoxSucheBuecherlisteKunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSucheBuecherlisteKunde.Location = new System.Drawing.Point(46, 9);
            this.textBoxSucheBuecherlisteKunde.Name = "textBoxSucheBuecherlisteKunde";
            this.textBoxSucheBuecherlisteKunde.Size = new System.Drawing.Size(370, 26);
            this.textBoxSucheBuecherlisteKunde.TabIndex = 0;
            this.textBoxSucheBuecherlisteKunde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSucheBuecherlisteKunde_KeyDown);
            // 
            // BuecherlisteKunde
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "BuecherlisteKunde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHomeBuecherlisteKunde)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBuecherliste)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSucheaufheben)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSucheBuecherlisteKunde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label homeText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox buttonHomeBuecherlisteKunde;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tableBuecherliste;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox buttonSucheBuecherlisteKunde;
        private System.Windows.Forms.TextBox textBoxSucheBuecherlisteKunde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBewertung;
        private System.Windows.Forms.DataGridViewImageColumn colCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlter;
        private System.Windows.Forms.DataGridViewImageColumn colLeihstatus;
        private System.Windows.Forms.PictureBox buttonSucheaufheben;
    }
}