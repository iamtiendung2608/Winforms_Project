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
    public partial class Service : UserControl
    {
        public Service()
        {
            InitializeComponent();
            btnEnableService(true);
            tbEnableService(false);

            btnEnableBD(true);
            tbEnableBD(false);
        }
        private void btnEnableService(bool value)
        {
            btnAddService.Enabled = value;
            btnUpdateService.Enabled = value;

            btnSaveService.Enabled = !value;
            btnClearService.Enabled = !value;
        }
        private void tbEnableService(bool value)
        {
            tbServiceID.Text = "";
            tbServiceName.Text = "";
            tbServicePrice.Text = "";

            tbServiceID.Enabled = value;
            tbServiceName.Enabled = value;
            tbServicePrice.Enabled = value;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            btnEnableService(false);
            tbEnableService(true);
            tbServiceID.Focus();
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            btnEnableService(true);
            tbEnableService(false);
            tbServiceID.Enabled = false;
            tbServiceName.Focus();
        }

        private void btnSaveService_Click(object sender, EventArgs e)
        {
            btnEnableService(false);
            tbEnableService(true);
        }

        private void btnClearService_Click(object sender, EventArgs e)
        {
            btnEnableService(false);
            tbEnableService(true);
        }
        //Bill Details controls
        private void btnEnableBD(bool value)
        {
            btnAddDetails.Enabled = value;
            btnUpdateDetails.Enabled = value;

            btnSaveDetails.Enabled = !value;
            btnClearDetails.Enabled = !value;
        }
        private void tbEnableBD(bool value)
        {
            tbBDDVID.Text = "";
            tbBDHDID.Text = "";
            tbBDID.Text = "";
            tbBDPrice.Text = "";
            tbBDQuantity.Text = "";
            tbBDTotal.Text = "";

            tbBDDVID.Enabled = value;
            tbBDHDID.Enabled = value;
            tbBDID.Enabled = value;
            tbBDPrice.Enabled = value;
            tbBDQuantity.Enabled = value;
            tbBDTotal.Enabled = value;
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            btnEnableBD(false);
            tbEnableBD(true);
            tbBDID.Focus();
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            btnEnableBD(false);
            tbEnableBD(true);
            tbBDID.Enabled = false;
            tbBDPrice.Focus();
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            btnEnableBD(true);
            tbEnableBD(false);
        }

        private void btnDeleteBDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnClearDetails_Click(object sender, EventArgs e)
        {
            btnEnableBD(true);
            tbEnableBD(false);
        }
    }
}
