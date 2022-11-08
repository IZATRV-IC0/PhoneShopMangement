using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_PhoneManagement
{
    public partial class frmPhoneDetail : Form
    {
        public bool hasClosed;
        public string dataString = "";
        public frmPhoneDetail()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dataString = txtPhoneID.Text + ',' + txtModelID.Text + ',' + txtPrice.Text + ',' + txtType.Text;
            dataString.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhoneDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }

        private void frmPhoneDetail_Load(object sender, EventArgs e)
        {
            hasClosed = false;
        }
    }
}
