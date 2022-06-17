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
    public partial class Staff : UserControl
    {
        public Staff()
        {
            InitializeComponent();
            tbEnableWS(false);
            tbEnableStaff(false);
            btnEnableWS(true);
            btnEnableStaff(true);
        }
        //Work schedule control
        private void btnEnableWS(bool value)
        {
            btnAddWS.Enabled = value;
            btnUpdateWS.Enabled = value;

            btnSaveWS.Enabled = !value;
            btnClearWS.Enabled = !value;
        }
        
        private void tbEnableWS(bool value)
        {
            tbWSID.Text = "";
            tbWSCa.Text = "";
            tbWSNV.Text = "";
            WSDPK.Value = DateTime.Today;

            tbWSID.Enabled = value;
            tbWSCa.Enabled = value;
            tbWSNV.Enabled = value;
            WSDPK.Enabled = value;
        }
        

        private void btnAddWS_Click(object sender, EventArgs e)
        {
            tbEnableWS(true);
            btnEnableWS(false);
            tbWSID.Focus();
        }

        private void btnUpdateWS_Click(object sender, EventArgs e)
        {
            tbEnableWS(true);
            btnEnableWS(false);
            tbWSID.Enabled=false;
            tbWSNV.Focus();
        }

        private void btnSaveWS_Click(object sender, EventArgs e)
        {
            tbEnableWS(false);
            btnEnableWS(true);
        }

        private void btnClearWS_Click(object sender, EventArgs e)
        {
            tbEnableWS(false);
            btnEnableWS(true);
        }
        //Staff control
        private void btnEnableStaff(bool value)
        {
            btnAddStaff.Enabled = value;
            btnUpdateStaff.Enabled = value;

            btnSaveStaff.Enabled = !value;
            btnClearStaff.Enabled = !value;
        }
        private void tbEnableStaff(bool value)
        {
            tbStaffID.Text = "";
            tbStaffName.Text = "";
            tbStaffProfile.Text = "";

            tbStaffID.Enabled = value;
            tbStaffName.Enabled = value;
            tbStaffProfile.Enabled = value;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            btnEnableStaff(false);
            tbEnableStaff(true);
            tbStaffID.Focus();
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            btnEnableStaff(false);
            tbEnableStaff(true);
            tbStaffID.Enabled = false;
            tbStaffName.Focus();
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            btnEnableStaff(true);
            tbEnableStaff(false);
        }

        private void btnClearStaff_Click(object sender, EventArgs e)
        {
            btnEnableStaff(true);
            tbEnableStaff(false);
        }
    }
}
