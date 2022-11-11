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
        public void setDefaultData(ReceiptInfo rI)
        {
            txtRe_PID.Text = "" + rI.PhoneId;
            txtRe_PName.Text = rI.PhoneName;
            txtRe_PPrice.Text = "" + rI.SellPricePerUnit;
            txtRe_PTotal.Text = "" + rI.Total;
            nudRe_PQuantity.Value = rI.Quantity;
        }
        private void LoadMethod()
        {

        }
        public void ResetForm()
        {
            foreach (TextBox txt in this.Controls)
            {
                txt.Text = "";
            }
            txtRe_PID.Text = "0";
            dataString = "";
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
            dataString = txtRe_PID.Text + ',' + txtRe_PPrice + ',' + nudRe_PQuantity;
            dataString = dataString.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            frmView view = new();
            view.SetListPickIndex(5);
            view.index = 5;
            view.mainFeature = true;
            view.instock = false;
            view.sales = false;
            view.DefaultSettings();
            view.ShowDialog();
        }
    }
}
