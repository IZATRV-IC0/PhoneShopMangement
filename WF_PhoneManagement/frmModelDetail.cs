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
    public partial class frmModelDetail : Form
    {
        public bool hasClosed;
        public string dataString = "";

        public void ResetForm()
        {
            foreach (TextBox txt in this.Controls)
            {
                txt.Text = "";
            }
            dataString = "";
        }
        public frmModelDetail()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dataString = txtModelID.Text + ','
                        + txtModelName.Text + ','
                        + txtOrigin.Text + ','
                        + txtYearOfWarranty.Text + ','
                        + txtBrand.Text;
            dataString.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModelDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.hasClosed = true;
        }

        private void frmModelDetail_Load(object sender, EventArgs e)
        {
            this.hasClosed = false;
        }
    }
}
