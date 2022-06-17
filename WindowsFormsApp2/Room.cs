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
    public partial class Room : UserControl
    {
        public Room()
        {
            InitializeComponent();
            btnEnableRD(true);
            btnEnableR(true);

            tbEnableR(false);
            tbEnableRD(false);

        }
        //Room Details Controls
        private void btnEnableRD(bool value)
        {
            btnAddRD.Enabled = value;
            btnUpdateRD.Enabled = value;

            btnSaveRD.Enabled = !value;
            btnClearRD.Enabled = !value;
        }

        private void tbEnableRD(bool value)
        {
            tbRDID.Text = "";
            tbRDName.Text = "";

            tbRDID.Enabled = value;
            tbRDName.Enabled = value;
        }
        private void btnAddRD_Click(object sender, EventArgs e)
        {
            btnEnableRD(false);
            tbEnableRD(true);
            tbRDID.Focus();
        }
        private void btnUpdateRD_Click(object sender, EventArgs e)
        {
            btnEnableRD(false);
            tbEnableRD(true);
            tbRDID.Enabled = false;
            tbRDName.Focus();
        }
        private void btnSaveRD_Click(object sender, EventArgs e)
        {
            btnEnableRD(true);
            tbEnableRD(false);
        }

        private void btnClearRD_Click(object sender, EventArgs e)
        {
            btnEnableRD(true);
            tbEnableRD(false);
        }
        //Room Controls
        private void btnEnableR(bool value)
        {
            btnAddR.Enabled = value;
            btnUpdateR.Enabled = value;

            btnSaveR.Enabled = !value;
            btnClearR.Enabled = !value;
        }

        private void tbEnableR(bool value)
        {
            tbRID.Text = "";
            tbRPrice.Text = "";
            tbRType.Text = "";

            tbRID.Enabled = value;
            tbRPrice.Enabled = value;
            tbRType.Enabled = value;
        }

        private void btnAddR_Click(object sender, EventArgs e)
        {
            btnEnableR(false);
            tbEnableR(true);
            tbRID.Focus();
        }

        private void btnUpdateR_Click(object sender, EventArgs e)
        {
            btnEnableR(false);
            tbEnableR(true);
            tbRID.Enabled=false;
            tbRPrice.Focus();
        }

        private void btnSaveR_Click(object sender, EventArgs e)
        {
            btnEnableR(true);
            tbEnableR(false);
        }

        private void btnClearR_Click(object sender, EventArgs e)
        {
            btnEnableR(true);
            tbEnableR(false);
        }
    }
}
