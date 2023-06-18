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
    public partial class FRMODEME : Form
    {
        public FRMODEME()
        {
            InitializeComponent();
        }

        private void BTNIPTAL_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BTNTAMAM_Click(object sender, EventArgs e)
        {
            if (NMTUTARR.Value == 0)
            {
                errorProvider1.SetError(NMTUTARR, "LÜTFEN TUTAR GİRİNİZ!");
                NMTUTARR.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(NMTUTARR, "");
            }
            if (CBODEMETURU.SelectedItem == null)
            {
                errorProvider1.SetError(CBODEMETURU, "Ödeme türü seçiniz");
                CBODEMETURU.Focus();
            }
            else
            {
                errorProvider1.SetError(CBODEMETURU, "");
            }
            if (TXTACIKLAMA.Text == "")
            {
                errorProvider1.SetError(TXTACIKLAMA, "Eksik veya hatalı bilgi!");
                TXTACIKLAMA.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(TXTACIKLAMA, "");
            }
            DialogResult = DialogResult.OK;
        }
    }
}
