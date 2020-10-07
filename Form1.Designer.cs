namespace PasswordGenerator___alexlhmn
{
    partial class frmStart
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.btnGenerieren = new System.Windows.Forms.Button();
            this.chkErweitert = new System.Windows.Forms.CheckBox();
            this.numPasswortlänge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswortlänge)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswort.Location = new System.Drawing.Point(13, 13);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(329, 26);
            this.txtPasswort.TabIndex = 0;
            // 
            // btnGenerieren
            // 
            this.btnGenerieren.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerieren.Location = new System.Drawing.Point(13, 52);
            this.btnGenerieren.Name = "btnGenerieren";
            this.btnGenerieren.Size = new System.Drawing.Size(139, 23);
            this.btnGenerieren.TabIndex = 1;
            this.btnGenerieren.Text = "Passwort generieren";
            this.btnGenerieren.UseVisualStyleBackColor = true;
            this.btnGenerieren.Click += new System.EventHandler(this.btnGenerieren_Click);
            // 
            // chkErweitert
            // 
            this.chkErweitert.AutoSize = true;
            this.chkErweitert.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkErweitert.ForeColor = System.Drawing.Color.Black;
            this.chkErweitert.Location = new System.Drawing.Point(262, 58);
            this.chkErweitert.Name = "chkErweitert";
            this.chkErweitert.Size = new System.Drawing.Size(80, 17);
            this.chkErweitert.TabIndex = 2;
            this.chkErweitert.Text = "Erweitert";
            this.chkErweitert.UseVisualStyleBackColor = true;
            this.chkErweitert.CheckedChanged += new System.EventHandler(this.chkErweitert_CheckedChanged);
            // 
            // numPasswortlänge
            // 
            this.numPasswortlänge.Location = new System.Drawing.Point(13, 94);
            this.numPasswortlänge.Name = "numPasswortlänge";
            this.numPasswortlänge.Size = new System.Drawing.Size(120, 20);
            this.numPasswortlänge.TabIndex = 3;
            this.numPasswortlänge.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(354, 191);
            this.Controls.Add(this.numPasswortlänge);
            this.Controls.Add(this.chkErweitert);
            this.Controls.Add(this.btnGenerieren);
            this.Controls.Add(this.txtPasswort);
            this.Name = "frmStart";
            this.Text = "Passwort-Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numPasswortlänge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Button btnGenerieren;
        private System.Windows.Forms.CheckBox chkErweitert;
        private System.Windows.Forms.NumericUpDown numPasswortlänge;
    }
}

