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
    public partial class frmSupplierDetail : Form
    {
        bool hasClosed;
        public frmSupplierDetail()
        {
            InitializeComponent();
        }

        private void LoadMethod()
        {

        }

        private void frmSupplierDetail_Load(object sender, EventArgs e)
        {
            LoadMethod();
            hasClosed = false;
        }

        private void frmSupplierDetail_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmSupplierDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }
    }
}
