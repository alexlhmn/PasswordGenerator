namespace PasswordGenerator___alexlhmn
{
    partial class frmPasswortliste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswortliste));
            this.txtErstelltePasswörter = new System.Windows.Forms.TextBox();
            this.lblErstelltePasswörter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtErstelltePasswörter
            // 
            this.txtErstelltePasswörter.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErstelltePasswörter.Location = new System.Drawing.Point(12, 33);
            this.txtErstelltePasswörter.Multiline = true;
            this.txtErstelltePasswörter.Name = "txtErstelltePasswörter";
            this.txtErstelltePasswörter.ReadOnly = true;
            this.txtErstelltePasswörter.Size = new System.Drawing.Size(330, 165);
            this.txtErstelltePasswörter.TabIndex = 0;
            // 
            // lblErstelltePasswörter
            // 
            this.lblErstelltePasswörter.AutoSize = true;
            this.lblErstelltePasswörter.Location = new System.Drawing.Point(13, 14);
            this.lblErstelltePasswörter.Name = "lblErstelltePasswörter";
            this.lblErstelltePasswörter.Size = new System.Drawing.Size(175, 13);
            this.lblErstelltePasswörter.TabIndex = 1;
            this.lblErstelltePasswörter.Text = "Deine erstellten Passwörter:";
            // 
            // frmPasswortliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(349, 206);
            this.Controls.Add(this.lblErstelltePasswörter);
            this.Controls.Add(this.txtErstelltePasswörter);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPasswortliste";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PasswortGenerator - Erstellte Passwörter";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtErstelltePasswörter;
        private System.Windows.Forms.Label lblErstelltePasswörter;
    }
}