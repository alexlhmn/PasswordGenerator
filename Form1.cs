﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator___alexlhmn
{
    public partial class frmStart : Form
    {

        #region Variablen
        int intPasswortlänge = 7;
        #endregion

        public frmStart()
        {
            InitializeComponent();
            setzeStandardeinstellungen();
            txtPasswort.Text = generierePasswort(intPasswortlänge);
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);

        private string generierePasswort(int Passwortlänge)
        {
            const string Zeichenpool = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz1234567890";
            var Zeichen = Enumerable.Range(0, Passwortlänge)
                .Select(x => Zeichenpool[random.Next(0, Zeichenpool.Length)]);
            return new string(Zeichen.ToArray());
        }

        private void setzePasswortlänge()
        {
            intPasswortlänge = Convert.ToInt32(numPasswortlänge.Value);
        }

        private void setzeStandardeinstellungen()
        {
            this.MaximumSize = new Size(370, 120);
            this.Size = new Size(370, 120);
            chkErweitert.ForeColor = Color.Black;
        }

        #region Frontend
        private void btnGenerieren_Click(object sender, EventArgs e)
        {
            setzePasswortlänge();
            txtPasswort.Text = generierePasswort(intPasswortlänge);
        }

        private void chkErweitert_CheckedChanged(object sender, EventArgs e)
        {
            if (chkErweitert.Checked)
            {
                this.MaximumSize = new Size(370, 180);
                this.Size = new Size(370, 180);
                chkErweitert.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                setzeStandardeinstellungen();  
            }
        }
        #endregion

  
    }
}