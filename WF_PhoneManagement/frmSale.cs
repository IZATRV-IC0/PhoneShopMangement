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
using MobileSaleLibrary.BussinessObject;
using System.Runtime.CompilerServices;

namespace WF_PhoneManagement
{
    public partial class frmSale : Form
    {
        BindingSource bindingSource;
        IReceiptRepository rRepos = new ReceiptRepository();
        IReceiptInfoRepository rInfoRepos = new ReceiptInfoRepository();

        public frmSale()
        {
            InitializeComponent();
            dgvSaleList.ReadOnly = true;
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            LoadList(GetSalesList());
        }

        public void LoadList(List<Sales> toLoadList)
        {

            bindingSource = new BindingSource();
            bindingSource.DataSource = toLoadList;
            dgvSaleList.DataSource = bindingSource;

        }

        public List<Sales> GetSalesList()
        {
            List<Sales> Slist;
            Slist = new List<Sales>();



            rInfoRepos.GetReceiptInfoList();

            var rIList = rInfoRepos.GetReceiptInfoList();
            var rList = rRepos.GetReceiptList();

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
                                        );

            var DateList = (from date in rIrJoinList
                            select date.Date).Distinct();

            foreach (DateTime date in DateList)
            {
                Slist.Add(new Sales(date));
            }

            foreach (Sales s in Slist)
            {
                int temp = (from temporarily in rIrJoinList
                            where temporarily.Date.Equals(s.Date)
                            select temporarily.Total).Sum();
                s.Total = temp;
            }

            return Slist;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtSearch.Value;
            var list = GetSalesList();
            var result = new List<Sales>();
            //MessageBox.Show(dateTime.ToString());
            //s.Date.ToShortDateString(),dateTime.ToShortDateString()
            result = list.Where(s => s.Date.ToShortDateString().Equals(dateTime.ToShortDateString())).ToList();
            LoadList(result);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadList(GetSalesList());
        }
    }
}
