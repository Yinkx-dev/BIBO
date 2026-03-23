namespace Bibo.Forms.Personal
{
    partial class HomePersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePersonal));
            this.homeHeaderPersonal = new System.Windows.Forms.Panel();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.homeText = new System.Windows.Forms.Label();
            this.buttonKundenliste = new System.Windows.Forms.Button();
            this.buttonLeihstatus = new System.Windows.Forms.Button();
            this.buttonNeuesBuch = new System.Windows.Forms.Button();
            this.buttonNeuerKunde = new System.Windows.Forms.Button();
            this.buttonBuecherliste = new System.Windows.Forms.Button();
            this.logoutButtonPersonal = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeHeaderPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButtonPersonal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeHeaderPersonal
            // 
            this.homeHeaderPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.homeHeaderPersonal.Controls.Add(this.pictureHome);
            this.homeHeaderPersonal.Controls.Add(this.homeText);
            this.homeHeaderPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeHeaderPersonal.Location = new System.Drawing.Point(0, 0);
            this.homeHeaderPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.homeHeaderPersonal.Name = "homeHeaderPersonal";
            this.homeHeaderPersonal.Size = new System.Drawing.Size(1264, 49);
            this.homeHeaderPersonal.TabIndex = 1;
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
            // buttonKundenliste
            // 
            this.buttonKundenliste.AutoSize = true;
            this.buttonKundenliste.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonKundenliste.FlatAppearance.BorderSize = 0;
            this.buttonKundenliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKundenliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKundenliste.Location = new System.Drawing.Point(200, 190);
            this.buttonKundenliste.Name = "buttonKundenliste";
            this.buttonKundenliste.Padding = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.buttonKundenliste.Size = new System.Drawing.Size(277, 79);
            this.buttonKundenliste.TabIndex = 12;
            this.buttonKundenliste.Text = "Kundenliste";
            this.buttonKundenliste.UseVisualStyleBackColor = false;
            this.buttonKundenliste.Click += new System.EventHandler(this.buttonKundenliste_Click);
            // 
            // buttonLeihstatus
            // 
            this.buttonLeihstatus.AutoSize = true;
            this.buttonLeihstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(191)))));
            this.buttonLeihstatus.FlatAppearance.BorderSize = 0;
            this.buttonLeihstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeihstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeihstatus.Location = new System.Drawing.Point(413, 575);
            this.buttonLeihstatus.Name = "buttonLeihstatus";
            this.buttonLeihstatus.Padding = new System.Windows.Forms.Padding(70, 15, 70, 15);
            this.buttonLeihstatus.Size = new System.Drawing.Size(440, 79);
            this.buttonLeihstatus.TabIndex = 16;
            this.buttonLeihstatus.Text = "Leihstatus einsehen";
            this.buttonLeihstatus.UseVisualStyleBackColor = false;
            this.buttonLeihstatus.Click += new System.EventHandler(this.buttonLeihstatus_Click);
            // 
            // buttonNeuesBuch
            // 
            this.buttonNeuesBuch.AutoSize = true;
            this.buttonNeuesBuch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonNeuesBuch.FlatAppearance.BorderSize = 0;
            this.buttonNeuesBuch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNeuesBuch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNeuesBuch.Location = new System.Drawing.Point(794, 341);
            this.buttonNeuesBuch.Name = "buttonNeuesBuch";
            this.buttonNeuesBuch.Padding = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.buttonNeuesBuch.Size = new System.Drawing.Size(266, 79);
            this.buttonNeuesBuch.TabIndex = 15;
            this.buttonNeuesBuch.Text = "Neues Buch";
            this.buttonNeuesBuch.UseVisualStyleBackColor = false;
            this.buttonNeuesBuch.Click += new System.EventHandler(this.buttonNeuesBuch_Click);
            // 
            // buttonNeuerKunde
            // 
            this.buttonNeuerKunde.AutoSize = true;
            this.buttonNeuerKunde.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonNeuerKunde.FlatAppearance.BorderSize = 0;
            this.buttonNeuerKunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNeuerKunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNeuerKunde.Location = new System.Drawing.Point(200, 341);
            this.buttonNeuerKunde.Name = "buttonNeuerKunde";
            this.buttonNeuerKunde.Padding = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.buttonNeuerKunde.Size = new System.Drawing.Size(279, 79);
            this.buttonNeuerKunde.TabIndex = 13;
            this.buttonNeuerKunde.Text = "Neuer Kunde";
            this.buttonNeuerKunde.UseVisualStyleBackColor = false;
            this.buttonNeuerKunde.Click += new System.EventHandler(this.buttonNeuerKunde_Click);
            // 
            // buttonBuecherliste
            // 
            this.buttonBuecherliste.AutoSize = true;
            this.buttonBuecherliste.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonBuecherliste.FlatAppearance.BorderSize = 0;
            this.buttonBuecherliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuecherliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuecherliste.Location = new System.Drawing.Point(794, 190);
            this.buttonBuecherliste.Name = "buttonBuecherliste";
            this.buttonBuecherliste.Padding = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.buttonBuecherliste.Size = new System.Drawing.Size(261, 79);
            this.buttonBuecherliste.TabIndex = 14;
            this.buttonBuecherliste.Text = "Bücherliste";
            this.buttonBuecherliste.UseVisualStyleBackColor = false;
            this.buttonBuecherliste.Click += new System.EventHandler(this.buttonBuecherliste_Click);
            // 
            // logoutButtonPersonal
            // 
            this.logoutButtonPersonal.Image = ((System.Drawing.Image)(resources.GetObject("logoutButtonPersonal.Image")));
            this.logoutButtonPersonal.Location = new System.Drawing.Point(5, 7);
            this.logoutButtonPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButtonPersonal.Name = "logoutButtonPersonal";
            this.logoutButtonPersonal.Size = new System.Drawing.Size(49, 38);
            this.logoutButtonPersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutButtonPersonal.TabIndex = 11;
            this.logoutButtonPersonal.TabStop = false;
            this.logoutButtonPersonal.Click += new System.EventHandler(this.logoutButtonPersonal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.logoutButtonPersonal);
            this.panel1.Location = new System.Drawing.Point(1164, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 54);
            this.panel1.TabIndex = 17;
            // 
            // HomePersonal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBuecherliste);
            this.Controls.Add(this.buttonNeuerKunde);
            this.Controls.Add(this.buttonNeuesBuch);
            this.Controls.Add(this.buttonLeihstatus);
            this.Controls.Add(this.buttonKundenliste);
            this.Controls.Add(this.homeHeaderPersonal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomePersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibo";
            this.homeHeaderPersonal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButtonPersonal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel homeHeaderPersonal;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Label homeText;
        private System.Windows.Forms.Button buttonKundenliste;
        private System.Windows.Forms.Button buttonLeihstatus;
        private System.Windows.Forms.Button buttonNeuesBuch;
        private System.Windows.Forms.Button buttonNeuerKunde;
        private System.Windows.Forms.Button buttonBuecherliste;
        private System.Windows.Forms.PictureBox logoutButtonPersonal;
        private System.Windows.Forms.Panel panel1;
    }
}