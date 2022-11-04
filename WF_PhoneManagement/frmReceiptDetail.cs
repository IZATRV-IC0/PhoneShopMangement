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

        private void frmReceiptDetail_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmReceiptDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }
    }
}
