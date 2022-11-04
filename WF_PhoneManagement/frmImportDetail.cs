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
    
    public partial class frmImportDetail : Form
    {
        public bool hasClosed;
        
        public frmImportDetail()
        {
            InitializeComponent();
        }

        private void LoadMethod()
        {

        }

        public ImportInfo GetImportInfo()
        {
            ImportInfo imInfo = new ImportInfo();
            return imInfo;
        }

        private void frmImportDetail_Load(object sender, EventArgs e)
        {
            LoadMethod();
            hasClosed = false;
        }

        private void frmImportDetail_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmImportDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }
    }
}
