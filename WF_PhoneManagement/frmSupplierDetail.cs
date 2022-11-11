using MobileSaleLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WF_PhoneManagement
{
    public partial class frmSupplierDetail : Form
    {
        public bool hasClosed;
        public string dataString = "";
        public frmSupplierDetail()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            foreach (TextBox txt in this.Controls)
            {
                txt.Text = "";
            }
            txtSupplierID.Text = "0";
            dataString = "";
        }
        public void setDefaultData(Supplier s)
        {
            txtSupplierID.Text = "" + s.SupplierId;
            txtSupplierName.Text = s.SupplierName;
            txtPhone.Text = s.SupplierPhoneNumber;
            txtAddress.Text = s.SupplierAddress;
        }


        private void frmSupplierDetail_Load(object sender, EventArgs e)
        {
            ResetForm();
            hasClosed = false;
        }

        private void frmSupplierDetail_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmSupplierDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataString = txtSupplierID.Text + ','
                        + txtSupplierName.Text + ','
                        + txtPhone.Text + ','
                        + txtAddress.Text;
            dataString = dataString.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
