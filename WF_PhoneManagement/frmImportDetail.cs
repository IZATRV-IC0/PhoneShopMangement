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
    
    public partial class frmImportDetail : Form
    {
        public bool hasClosed;
        public string dataString = "";
        
        public frmImportDetail()
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

        private void frmImportDetail_Load(object sender, EventArgs e)
        {
            hasClosed = false;
        }


        private void frmImportDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dataString = cbb_PID.Text + ','
                        + txt_PPrice.Text + ','
                        + nud_PQuantity.Text;
            dataString.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
