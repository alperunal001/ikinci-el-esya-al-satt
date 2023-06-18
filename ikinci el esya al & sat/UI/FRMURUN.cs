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
    public partial class FRMURUN : Form
    {
        public FRMURUN()
        {
            InitializeComponent();
        }

        private void BTNIPTAL_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
        public FrmAlici alici { get; set; }


        private void BTNTAMAM_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(CINS)) return;
            if (!ErrorControl(TXTMARKA)) return;
            if (!ErrorControl(TXTMODEL)) return;
            if (!ErrorControl(TXTRENK)) return;
            if (!ErrorControl(NMFIYAT)) return;

            


            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(CBCINS, ""); return true;
                }
            }
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
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
    }
}
