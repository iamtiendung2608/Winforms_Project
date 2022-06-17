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
    public partial class Guest : UserControl
    {
        public Guest()
        {
            InitializeComponent();
            btnEnableGuest(true);
            tbEnableGuest(false);
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            GuestTable.Rows.Add(
                new object[]
                {
                    "Tien Dung","Phuc Binh","Huu Tien","Loc Son"
                }
                );
            GuestTable.Rows.Add(
                new object[]
                {
                    "Minh Chien","Ba Loc","Binh Dinh","1234"
                }
                );
        }
        private void btnEnableGuest(bool value)
        {
            btnAddGuest.Enabled = value;
            btnUpdateGuest.Enabled = value;

            btnSaveGuest.Enabled = !value;
            btnClearGuest.Enabled = !value;
        }
        private void tbEnableGuest(bool value)
        {
            tbGuestID.Text = "";
            tbGuestName.Text = "";
            tbGuestCountry.Text = "";

            tbGuestID.Enabled = value;
            tbGuestName.Enabled = value;
            tbGuestCountry.Enabled = value;
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            btnEnableGuest(false);
            tbEnableGuest(true);
            tbGuestID.Focus();
        }

        private void btnUpdateGuest_Click(object sender, EventArgs e)
        {
            btnEnableGuest(false);
            tbEnableGuest(true);
            tbGuestID.Enabled = false;
            tbGuestName.Focus();
        }

        private void btnSaveGuest_Click(object sender, EventArgs e)
        {
            btnEnableGuest(true);
            tbEnableGuest(false);
        }

        private void btnClearGuest_Click(object sender, EventArgs e)
        {
            btnEnableGuest(true);
            tbEnableGuest(false);
        }
    }
}
