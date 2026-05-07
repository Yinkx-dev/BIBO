namespace Bibo.Forms.Personal
{
    partial class IdEingabeKunde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdEingabeKunde));
            this.textBoxKundenID = new System.Windows.Forms.TextBox();
            this.labelAutor = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelKundenID = new System.Windows.Forms.Label();
            this.labelKundeName = new System.Windows.Forms.Label();
            this.buttonCheckID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKundenID
            // 
            this.textBoxKundenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKundenID.Location = new System.Drawing.Point(44, 75);
            this.textBoxKundenID.Name = "textBoxKundenID";
            this.textBoxKundenID.Size = new System.Drawing.Size(148, 26);
            this.textBoxKundenID.TabIndex = 3;
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(40, 19);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(152, 20);
            this.labelAutor.TabIndex = 17;
            this.labelAutor.Text = "Buch verleihen an";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(12, 152);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(94, 38);
            this.buttonSubmit.TabIndex = 18;
            this.buttonSubmit.Text = "Bestätigen";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(123, 152);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 38);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelKundenID
            // 
            this.labelKundenID.AutoSize = true;
            this.labelKundenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKundenID.Location = new System.Drawing.Point(41, 56);
            this.labelKundenID.Name = "labelKundenID";
            this.labelKundenID.Size = new System.Drawing.Size(65, 16);
            this.labelKundenID.TabIndex = 20;
            this.labelKundenID.Text = "KundenID";
            // 
            // labelKundeName
            // 
            this.labelKundeName.AutoSize = true;
            this.labelKundeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKundeName.ForeColor = System.Drawing.Color.Red;
            this.labelKundeName.Location = new System.Drawing.Point(41, 111);
            this.labelKundeName.Name = "labelKundeName";
            this.labelKundeName.Size = new System.Drawing.Size(134, 16);
            this.labelKundeName.TabIndex = 21;
            this.labelKundeName.Text = "Kunde nicht gefunden";
            this.labelKundeName.Visible = false;
            // 
            // buttonCheckID
            // 
            this.buttonCheckID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckID.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheckID.Image")));
            this.buttonCheckID.Location = new System.Drawing.Point(190, 72);
            this.buttonCheckID.Name = "buttonCheckID";
            this.buttonCheckID.Size = new System.Drawing.Size(30, 32);
            this.buttonCheckID.TabIndex = 22;
            this.buttonCheckID.Text = "🔍";
            this.buttonCheckID.UseVisualStyleBackColor = true;
            this.buttonCheckID.Click += new System.EventHandler(this.buttonCheckID_Click);
            // 
            // IdEingabeKunde
            // 
            this.AcceptButton = this.buttonCheckID;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.buttonCheckID);
            this.Controls.Add(this.labelKundeName);
            this.Controls.Add(this.labelKundenID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.textBoxKundenID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IdEingabeKunde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKundenID;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelKundenID;
        private System.Windows.Forms.Label labelKundeName;
        private System.Windows.Forms.Button buttonCheckID;
    }
}