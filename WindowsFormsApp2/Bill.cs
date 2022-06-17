using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Bill : UserControl
    {
        public Bill()
        {
            InitializeComponent();
            tbEnable(false);
            btnEnable(true);
        }
        private void btnEnable(bool value)
        {
            btnAddBill.Enabled = value;
            btnUpdateBill.Enabled = value;

            btnSaveBill.Enabled = !value;
            btnClearBill.Enabled = !value;
        }
        private void tbEnable(bool value)
        {
            tbbillID.Text = "";
            tbbillKH.Text = "";
            tbbillMP.Text = "";
            tbbillNV.Text = "";
            tbbillSD.Text = "";
            tbbillTT.Text = "";
            tbbillSK.Text = "";
            billDPK.Value = DateTime.Today;

            tbbillID.Enabled = value;
            tbbillKH.Enabled = value;
            tbbillMP.Enabled = value;
            tbbillNV.Enabled = value;
            tbbillSD.Enabled = value;
            tbbillTT.Enabled = value;
            tbbillSK.Enabled = value;
            billDPK.Enabled = value;
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            tbEnable(true);
            btnEnable(false);
            tbbillID.Focus();
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            tbEnable(true);
            btnEnable(false);
            tbbillID.Enabled = false;
            tbbillNV.Focus();
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            tbEnable(false);
            btnEnable(true);
        }

        private void btnClearBill_Click(object sender, EventArgs e)
        {
            tbEnable(false);
            btnEnable(true);
        }
        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            tbEnable(false);
            btnEnable(true);
        }
    }
}
