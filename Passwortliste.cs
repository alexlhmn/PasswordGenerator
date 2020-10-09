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
    public partial class frmPasswortliste : Form
    {
        public frmPasswortliste()
        {
            InitializeComponent();
            txtErstelltePasswörter.Text = String.Join(Environment.NewLine, frmStart.listPasswörter);
        }
    }
}
