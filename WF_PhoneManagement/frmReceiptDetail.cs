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

namespace WF_PhoneManagement
{
    public partial class frmReceiptDetail : Form
    {
        public bool hasClosed;
        public String dataString = "";

        public frmReceiptDetail()
        {
            InitializeComponent();
        }
        private void LoadMethod()
        {

        }

        public ReceiptInfo GetReceiptInfo()
        {
            ReceiptInfo reInfo = new ReceiptInfo();
            return reInfo;
        }

        private void frmReceiptDetail_Load(object sender, EventArgs e)
        {

            LoadMethod();
            hasClosed = false;
        }


        private void frmReceiptDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            hasClosed = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dataString = cbbRe_PID.Text + ',' + txtRe_PPrice + ',' + nudRe_PQuantity;
            dataString.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
