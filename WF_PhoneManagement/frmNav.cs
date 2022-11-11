using WF_PhoneManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace WF_PhoneManagement
{
    public partial class frmNav : Form
    {
        frmRe_Im frmRe_Im = new frmRe_Im();
        frmView frmView = new frmView();
        public bool hasClosed;
        public frmNav()
        {
            InitializeComponent();
            hasClosed = false;
        }

        static bool LogoutHandling()
        {
            string message = "Are you sure you want to log out? This will send you to login screen.";
            string caption = "Log out";
            DialogResult result = MessageBox.Show(message, caption,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void btnLogout_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (!LogoutHandling())
            {
                e.Cancel = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }

        private void btnRI_Click(object sender, EventArgs e)
        {
            foreach (Control c in frmRe_Im.Controls)
            {
                c.DataBindings.Clear();
            }
            this.Hide();
            frmRe_Im.DefaultSettings();
            frmRe_Im.dataBindings();
            frmRe_Im.AddSettings();
            frmRe_Im.ShowDialog();
            while (!frmRe_Im.hasClosed) { }
            this.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmView.SetListPickIndex(0);
            frmView.index = 0;
            frmView.mainFeature = true;
            frmView.instock = false;
            frmView.sales = false;
            frmView.ShowDialog();
            while (!frmView.hasClosed) { }
            this.Show();
        }


        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmView.mainFeature = false;
            frmView.sales = true;
            frmView.instock = false;
            frmView.SalesSettings();
            frmView.ShowDialog();
            while (!frmView.hasClosed) { }
            this.Show();
        }

        private void btnInStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmView.mainFeature = false;
            frmView.sales = false;
            frmView.instock = true;
            frmView.ShowDialog();
            while (!frmView.hasClosed) { }
            this.Show();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet!","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
