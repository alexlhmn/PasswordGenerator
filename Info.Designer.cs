namespace PasswordGenerator___alexlhmn
{
    partial class frmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo));
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGrafik = new System.Windows.Forms.Label();
            this.lblGrafik2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 35);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(91, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version: 1.0.0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(175, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "alexlhmn - PasswortGenerator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PasswordGenerator___alexlhmn.Properties.Resources._40_104848;
            this.pictureBox1.InitialImage = global::PasswordGenerator___alexlhmn.Properties.Resources._40_104848;
            this.pictureBox1.Location = new System.Drawing.Point(13, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblGrafik
            // 
            this.lblGrafik.AutoSize = true;
            this.lblGrafik.Location = new System.Drawing.Point(53, 80);
            this.lblGrafik.Name = "lblGrafik";
            this.lblGrafik.Size = new System.Drawing.Size(103, 13);
            this.lblGrafik.TabIndex = 3;
            this.lblGrafik.Text = "Grafik/Icon von:";
            // 
            // lblGrafik2
            // 
            this.lblGrafik2.AutoSize = true;
            this.lblGrafik2.Location = new System.Drawing.Point(53, 100);
            this.lblGrafik2.Name = "lblGrafik2";
            this.lblGrafik2.Size = new System.Drawing.Size(55, 13);
            this.lblGrafik2.TabIndex = 4;
            this.lblGrafik2.TabStop = true;
            this.lblGrafik2.Text = "Trinh Ho";
            this.lblGrafik2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGrafik2_LinkClicked);
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(313, 124);
            this.Controls.Add(this.lblGrafik2);
            this.Controls.Add(this.lblGrafik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfo";
            this.ShowInTaskbar = false;
            this.Text = "Info";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGrafik;
        private System.Windows.Forms.LinkLabel lblGrafik2;
    }
}