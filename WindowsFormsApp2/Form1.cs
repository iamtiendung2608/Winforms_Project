using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Staff staffForm = new Staff();
        private Service serviceForm = new Service();
        private Room roomForm = new Room();
        private Guest guestForm = new Guest();
        private Bill billForm = new Bill();
        private Guest deskForm = new Guest();
        
        public Form1()
        {
            InitializeComponent();
            MainLayout.Controls.Clear();
            MainLayout.Controls.Add(guestForm);
        }

        

        private void guestBTN_Click(object sender, EventArgs e)
        {
            MainLayout.Controls.Clear();
            MainLayout.Controls.Add(guestForm);
        }

        private void staffBTN_Click(object sender, EventArgs e)
        {
            MainLayout.Controls.Clear();
            MainLayout.Controls.Add(staffForm);
        }

        private void serviceBTN_Click_1(object sender, EventArgs e)
        {
            MainLayout.Controls.Clear();
            MainLayout.Controls.Add(serviceForm);
        }

        private void billBTN_Click(object sender, EventArgs e)
        {
            MainLayout.Controls.Clear();
            MainLayout.Controls.Add(billForm);
        }

        private void roomBTN_Click(object sender, EventArgs e)
        {
            MainLayout.Controls.Clear();
            MainLayout.Controls.Add(roomForm);
        }
    }
}
