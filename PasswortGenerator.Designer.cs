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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.btnGenerieren = new System.Windows.Forms.Button();
            this.chkErweitert = new System.Windows.Forms.CheckBox();
            this.numPasswortlänge = new System.Windows.Forms.NumericUpDown();
            this.chkSonderzeichen = new System.Windows.Forms.CheckBox();
            this.chkZwischenablage = new System.Windows.Forms.CheckBox();
            this.menStart = new System.Windows.Forms.MenuStrip();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswortlänge)).BeginInit();
            this.menStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswort.Location = new System.Drawing.Point(12, 33);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(329, 26);
            this.txtPasswort.TabIndex = 0;
            // 
            // btnGenerieren
            // 
            this.btnGenerieren.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerieren.Location = new System.Drawing.Point(13, 65);
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
            this.chkErweitert.Location = new System.Drawing.Point(262, 71);
            this.chkErweitert.Name = "chkErweitert";
            this.chkErweitert.Size = new System.Drawing.Size(80, 17);
            this.chkErweitert.TabIndex = 2;
            this.chkErweitert.Text = "Erweitert";
            this.chkErweitert.UseVisualStyleBackColor = true;
            this.chkErweitert.CheckedChanged += new System.EventHandler(this.chkErweitert_CheckedChanged);
            // 
            // numPasswortlänge
            // 
            this.numPasswortlänge.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPasswortlänge.Location = new System.Drawing.Point(13, 105);
            this.numPasswortlänge.Name = "numPasswortlänge";
            this.numPasswortlänge.Size = new System.Drawing.Size(120, 20);
            this.numPasswortlänge.TabIndex = 3;
            this.numPasswortlänge.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // chkSonderzeichen
            // 
            this.chkSonderzeichen.AutoSize = true;
            this.chkSonderzeichen.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSonderzeichen.Location = new System.Drawing.Point(166, 108);
            this.chkSonderzeichen.Name = "chkSonderzeichen";
            this.chkSonderzeichen.Size = new System.Drawing.Size(164, 17);
            this.chkSonderzeichen.TabIndex = 4;
            this.chkSonderzeichen.Text = "Sonderzeichen verwenden";
            this.chkSonderzeichen.UseVisualStyleBackColor = true;
            this.chkSonderzeichen.CheckedChanged += new System.EventHandler(this.chkSonderzeichen_CheckedChanged);
            // 
            // chkZwischenablage
            // 
            this.chkZwischenablage.AutoSize = true;
            this.chkZwischenablage.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkZwischenablage.Location = new System.Drawing.Point(166, 130);
            this.chkZwischenablage.Name = "chkZwischenablage";
            this.chkZwischenablage.Size = new System.Drawing.Size(176, 30);
            this.chkZwischenablage.TabIndex = 5;
            this.chkZwischenablage.Text = "direkt in Zwischenablage \r\nkopieren";
            this.chkZwischenablage.UseVisualStyleBackColor = true;
            // 
            // menStart
            // 
            this.menStart.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menStart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info});
            this.menStart.Location = new System.Drawing.Point(0, 0);
            this.menStart.Name = "menStart";
            this.menStart.Size = new System.Drawing.Size(354, 24);
            this.menStart.TabIndex = 6;
            this.menStart.Text = "menuStrip1";
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(43, 20);
            this.Info.Text = "Info";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(354, 175);
            this.Controls.Add(this.chkZwischenablage);
            this.Controls.Add(this.chkSonderzeichen);
            this.Controls.Add(this.numPasswortlänge);
            this.Controls.Add(this.chkErweitert);
            this.Controls.Add(this.btnGenerieren);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.menStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menStart;
            this.MaximizeBox = false;
            this.Name = "frmStart";
            this.Text = "PasswortGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.numPasswortlänge)).EndInit();
            this.menStart.ResumeLayout(false);
            this.menStart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Button btnGenerieren;
        private System.Windows.Forms.CheckBox chkErweitert;
        private System.Windows.Forms.NumericUpDown numPasswortlänge;
        private System.Windows.Forms.CheckBox chkSonderzeichen;
        private System.Windows.Forms.CheckBox chkZwischenablage;
        private System.Windows.Forms.MenuStrip menStart;
        private System.Windows.Forms.ToolStripMenuItem Info;
    }
}

