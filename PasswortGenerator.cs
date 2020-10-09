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
        int intAnzahlPasswörter = 5;
        string strGeneriertesPasswort;
        string strZeichenpool;
        const string strZeichenpoolEinfach = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz1234567890";
        const string strZeichenpoolErweitert = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz12345678901!§$%&/()=?*+#-_.:,;><";

        public static List<string> listPasswörter;
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

        private void generiereMehrerePasswörter(int Passwortlänge, int Passwortanzahl, string Zeichenpool)
        {
            int i = 0;
            listPasswörter = new List<string>();

            for (i = 0; i < Passwortanzahl; i++)
            {
                listPasswörter.Add(generierePasswort(Passwortlänge, Zeichenpool));     
            }

            frmPasswortliste frmPasswortliste = new frmPasswortliste();
            frmPasswortliste.Show();
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
            this.MaximumSize = new Size(460, 160);
            this.Size = new Size(460, 160);
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
                this.MaximumSize = new Size(460, 280);
                this.Size = new Size(460, 280);
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

        private void Info_Click(object sender, EventArgs e)
        {
            frmInfo frmInfo = new frmInfo();
            frmInfo.ShowDialog();      }

        private void btnMehrereGenerieren_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAnzahlPasswörter.Text))
            {
                generiereMehrerePasswörter(intPasswortlänge, intAnzahlPasswörter, strZeichenpool);
            }
            else if (Int32.TryParse(txtAnzahlPasswörter.Text, out var outParse))
            {
                intAnzahlPasswörter = Convert.ToInt32(txtAnzahlPasswörter.Text);
                generiereMehrerePasswörter(intPasswortlänge, intAnzahlPasswörter, strZeichenpool);
            }
            else
            {
                MessageBox.Show("Es wurde keine gültige Anzahl eingegeben. Bitte nur Zahlen verwenden!", "Fehler");
            }

        }

        #endregion


    }
}
