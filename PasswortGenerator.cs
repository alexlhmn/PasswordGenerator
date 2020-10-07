using System;
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
        string strGeneriertesPasswort;
        string strZeichenpool;
        const string strZeichenpoolEinfach = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz1234567890";
        const string strZeichenpoolErweitert = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz12345678901!§$%&/()=?*+#-_.:,;><";
        #endregion

        public frmStart()
        {
            InitializeComponent();
            setzeStandardeinstellungen();
            txtPasswort.Text = generierePasswort(intPasswortlänge, strZeichenpool);
        }

        #region Funktionen + Methoden
        private static Random random = new Random((int)DateTime.Now.Ticks);

        private string generierePasswort(int Passwortlänge, string Zeichenpool)
        {
            var Zeichen = Enumerable.Range(0, Passwortlänge)
                .Select(x => Zeichenpool[random.Next(0, Zeichenpool.Length)]);
            return new string(Zeichen.ToArray());
        }

        private void setzePasswortlänge()
        {
            intPasswortlänge = Convert.ToInt32(numPasswortlänge.Value);
        }

        private void setzeZeichenpool()
        {
            if (chkSonderzeichen.Checked)
            {
                strZeichenpool = strZeichenpoolErweitert;
            }
            else
            {
                strZeichenpool = strZeichenpoolEinfach;
            }
        }

        private void setzeStandardeinstellungen()
        {
            this.MaximumSize = new Size(370, 120);
            this.Size = new Size(370, 120);
            chkErweitert.ForeColor = Color.Black;
            strZeichenpool = strZeichenpoolEinfach;
        }

        #endregion

        #region Frontend
        private void btnGenerieren_Click(object sender, EventArgs e)
        {
            setzePasswortlänge();
            strGeneriertesPasswort = generierePasswort(intPasswortlänge, strZeichenpool);
            txtPasswort.Text = strGeneriertesPasswort;
            
            if (chkErweitert.Checked && chkZwischenablage.Checked) // Erweiterte Optionen aktiviert und Kopie nach Zwischenablage aktiv?
            {
                System.Windows.Forms.Clipboard.SetText(strGeneriertesPasswort);
            }
            else
            {
                
            }
        }

        private void chkErweitert_CheckedChanged(object sender, EventArgs e)
        {
            if (chkErweitert.Checked)
            {
                this.MaximumSize = new Size(370, 190);
                this.Size = new Size(370, 190);
                chkErweitert.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                setzeStandardeinstellungen();  
            }
        }

        private void chkSonderzeichen_CheckedChanged(object sender, EventArgs e)
        {
            setzeZeichenpool();
        }

        #endregion


    }
}
