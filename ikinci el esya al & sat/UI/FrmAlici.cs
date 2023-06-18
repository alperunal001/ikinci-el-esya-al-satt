using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikinci_el_esya_al___sat.UI
{
    public partial class FrmAlici : Form
    {
        public FrmAlici()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNTAMAM_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(TXTAD)) return;
            if (!ErrorControl(TXTSOYAD)) return;
            if (!ErrorControl(TXTCINSIYET)) return;
            if (!ErrorControl(TXTTEL)) return;
            if (!ErrorControl(TXTE_POSTA)) return;
            if (!ErrorControl(TXTADRES)) return;

            DialogResult = DialogResult.OK;

        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(TXTAD, "");return true;
                }
            }
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, ""); return true;
                }
            }
            return true;
        }
            


        private void BTNIPTAL_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
