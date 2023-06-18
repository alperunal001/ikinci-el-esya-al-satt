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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        public FrmAlici Alici{ get; set; }

        private void BTNTAMAM_Click(object sender, EventArgs e)
        {
            if (NMFIYAT.Value == 0)
            {
                errorProvider1.SetError(NMFIYAT, "LÜTFEN FİYAT GİRİNİZ!");
                NMFIYAT.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(NMFIYAT, "");
            }

            DialogResult = DialogResult.OK;
        }

        private void BTNIPTAL_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
