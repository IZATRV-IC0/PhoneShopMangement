using MobileSaleLibrary.Repository.IRepository;
using MobileSaleLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MobileSaleLibrary.DataAccess;

namespace WF_PhoneManagement
{
    public partial class frmView : Form
    {
        public bool hasClosed;

        Object curr;

        List<Object> list;

        public String control;

        public frmView()
        {
            InitializeComponent();
            hasClosed = false;
            curr = new Object();
        }

        public void ViewSettings()
        {
            btnPick.Hide();
        }

        public void PickSettings()
        {
            cbbListPick.Hide();
            btnAdd.Text = "New...";
        }

        public void SalesSettings()
        {
            cbbListPick.Hide();
            btnPick.Hide();
            btnAdd.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
        }

        public void InStockSettings()
        {
            cbbListPick.Hide();
            btnPick.Hide();
            btnAdd.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
        }

        void LoadMethod()
        {
            
        }
        static bool CloseHandling()
        {
            string message = "Return to main menu?";
            string caption = "Close";
            DialogResult result = MessageBox.Show(message, caption,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        private void rbtnSortDsc_CheckedChanged(object sender, EventArgs e)
        {
            rbtnSortAsc.Checked = !rbtnSortDsc.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseHandling())
            {
                e.Cancel = true;
            }
        }

        private void frmView_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }

        internal class Sales
        {
            public DateTime Date { get; set; }
            public int? Total { get; set; }

            public Sales()
            {

            }
            public Sales(DateTime date) { Date = date; }
            public override string ToString()
            {
                return "Date=" + Date + ",Total=" + Total;
            }
        }


        private void frmView_Load(object sender, EventArgs e)
        {
            List<Sales> Slist;
            BindingSource source = new BindingSource();
            
            Slist = new List<Sales>();
            //Slist.Clear();
            IReceiptRepository rRepos = new ReceiptRepository();
            IReceiptInfoRepository rInfoRepos = new ReceiptInfoRepository();
            rInfoRepos.GetReceiptInfoList();
            var rIList = rInfoRepos.GetReceiptInfoList().ToList();
            var rList = rRepos.GetReceiptList().ToList();
            var rIrJoinList = rIList.Join(rList,
                                        receiptInfo => receiptInfo.ReceiptId,
                                        receipt => receipt.ReceiptId,
                                        (receiptInfo, receipt) => new
                                        {
                                            RecID = receiptInfo.ReceiptId,
                                            PID = receiptInfo.PhoneId,
                                            Total = receiptInfo.Total,
                                            Date = receipt.ReceiptDate
                                        }
                                        ).ToList();
            var DateList = (from date in rIrJoinList
                            select date.Date).Distinct();
            List<Sales> listSales = new List<Sales>();
            foreach (DateTime date in DateList)
            {
                listSales.Add(new Sales(date));
            }
            foreach (Sales s in listSales)
            {
                int temp = (from temporarily in rIrJoinList
                            where temporarily.Date.Equals(s.Date)
                            select temporarily.Total).Sum();
                s.Total = temp;
                MessageBox.Show(s.ToString());
            }
            source.DataSource = DateList;
            dgvShowList.DataSource = null;
            dgvShowList.DataSource = listSales;
            hasClosed = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            
        }
    }
}
