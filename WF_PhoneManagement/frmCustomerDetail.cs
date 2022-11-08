using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileSaleLibrary;
using MobileSaleLibrary.Models;
using MobileSaleLibrary.Repository;
using MobileSaleLibrary.Repository.IRepository;

namespace WF_PhoneManagement
{
    public partial class frmCustomerDetail : Form
    {
        public bool hasClosed;
        public string dataString = "";

        public frmCustomerDetail()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            foreach (TextBox txt in this.Controls)
            {
                txt.Text = "";
            }
            dataString = "";
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            dataString = txtID.Text + ','
                        + txtName.Text + ','
                        + txtPhone.Text + ','
                        + txtAddress.Text + ',';
            if (rbtn_Male.Checked) { dataString += "Male"; }
            else if (rbtn_Female.Checked) { dataString += "Female"; }
            else { dataString += "X"; }
            dataString.Trim();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 1 in 3 radio button choice.
        private void rbtn_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Male.Checked)
            {
                rbtn_Female.Checked = false;
                rbtn_X.Checked = false;
            }
            else
            {
                rbtn_Male.Checked = false;
            }
        }

        private void rbtn_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Female.Checked)
            {
                rbtn_Male.Checked = false;
                rbtn_X.Checked = false;
            }
            else
            {
                rbtn_Female.Checked = false;
            }
        }

        private void rbtn_X_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_X.Checked)
            {
                rbtn_Male.Checked = false;
                rbtn_Female.Checked = false;
            }
            else
            {
                rbtn_X.Checked = false;
            }
        }

        private void frmCustomerDetail_Load(object sender, EventArgs e)
        {
            this.hasClosed = false;
        }

        private void frmCustomerDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }
    }
}
