using MobileSaleLibrary.Repository.IRepository;
using MobileSaleLibrary.Repository;
using MobileSaleLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MobileSaleLibrary.DataAccess;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;
using Microsoft.VisualBasic.ApplicationServices;
using System.Linq.Expressions;
using Model = MobileSaleLibrary.Models.Model;
using System.Diagnostics;

namespace WF_PhoneManagement
{
    public partial class frmView : Form
    {
        public bool hasClosed;

        BindingSource source = new BindingSource();

        public List<Customer> cList;
        public List<Supplier> sList;
        public List<Receipt> rList;
        public List<Import> iList;
        public List<Model> mList;
        public List<Phone> pList;
        public List<Sales> ssList;

        ICustomerRepository cRepos = new CustomerRepository();
        ISupplierRepository sRepos = new SupplierRepository();
        IReceiptRepository rRepos = new ReceiptRepository();
        IImportRepository iRepos = new ImportRepository();
        IModelRepository mRepos = new ModelRepository();
        IPhoneRepository pRepos = new PhoneRepository();
        

        public bool mainFeature;

        public bool sales;

        public bool instock;

        public int index;
        public frmView()
        {
            InitializeComponent();
            hasClosed = false;
            DefaultSettings();
        }

        public void SetListPickIndex(int x)
        {
            if (x > -1 || x < 6)
            {
                lboxListPick.SelectedIndex = x;
            }
            else
            {
                lboxListPick.SelectedIndex = -1;
            }
        }
        public void DefaultSettings()
        {
            cList = cRepos.GetCustomerList().ToList();
            sList = sRepos.GetSupplierList().ToList();
            rList = rRepos.GetReceiptList().ToList();
            iList = iRepos.GetImportList().ToList();
            mList = mRepos.GetModelsList().ToList();
            pList = pRepos.GetPhones().ToList();
            ssList = Sales.GetSalesList();
        }
        public void RetrieveSettings()
        {
            btnPick.Text = "OK";
            foreach(Control c in this.Controls)
            {
                c.Enabled = true;
                c.Show();
            }
        }
        public void ViewSettings()
        {
            btnPick.Text = "Detail";
        }

        public void PickSettings()
        {
            lboxListPick.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
        }

        public void SalesSettings()
        {
            lblListPick.Hide();
            lboxListPick.Hide();
            btnPick.Hide();
            btnAdd.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
            source.DataSource = ssList;
            hasClosed = false;
        }

        public void InStockSettings()
        {
            lboxListPick.Hide();
            btnPick.Text = "Detail";
            btnAdd.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
        }

        public void ReImSettings()
        {
            btnAdd.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
        }

        public void AllowDataHandling(bool check)
        {
            lboxBox.Enabled = check;
            btnSearch.Enabled = check;
            btnSort.Enabled = check;
            txtSearchInfo.Enabled = check;
        }

        void LoadMethod()
        {
            if (mainFeature)
            {
                switch (index)
                {
                    case 0:
                        ReImSettings();
                        ViewSettings();
                        break;
                    case 1:
                        ReImSettings();
                        ViewSettings();
                        
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        source.DataSource = null;
                        break;
                }
            }
            dgvShowList.DataSource = source;
            if (dgvShowList.DataSource is not null)
            {
                lboxBox.Items.Clear();
                foreach (DataGridViewColumn c in dgvShowList.Columns)
                {
                    lboxBox.Items.Add(c.Name);
                }
                AllowDataHandling(true);
            } else
            {
                AllowDataHandling(false);
            }
            if (dgvShowList.DataSource is null || !lboxBox.Enabled)
            {
                lboxBox.SelectedIndex = -1;
            }
        }

        private void rbtnSortDsc_CheckedChanged(object sender, EventArgs e)
        {
            rbtnSortAsc.Checked = !rbtnSortDsc.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmView_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }

        


        private void frmView_Load(object sender, EventArgs e)
        {
            LoadMethod();
            hasClosed = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DefaultSettings();
            LoadMethod();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                
                
            } catch (Exception ex)
            {
                MessageBox.Show("Ex: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadMethod();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ex: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadMethod();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            
        }

        private void lboxListPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveSettings();
            if (mainFeature)
            {
                if (lboxListPick.SelectedIndex == -1)
                {
                    lboxListPick.SelectedIndex = index;
                }
                else
                {
                    index = lboxListPick.SelectedIndex;
                    switch (index)
                    {
                        case 0:
                            source.DataSource = rList;
                            break;
                        case 1:
                            source.DataSource = iList;
                            break;
                        case 2:
                            source.DataSource = cList;
                            break;
                        case 3:
                            source.DataSource = sList;
                            break;
                        case 4:
                            source.DataSource = mList;
                            break;
                        case 5:
                            source.DataSource = pList;
                            break;
                        default:
                            source.DataSource = null;
                            break;
                    }
                }
            }
            if (sales)
            {
                lboxListPick.SelectedIndex = -1;
            }
            if (instock)
            {
                lboxListPick.SelectedIndex = 5;
            }
            LoadMethod();
        }
    }

    public class Sales
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

        public static List<Sales> GetSalesList()
        {
            List<Sales> Slist;
            Slist = new List<Sales>();
            IReceiptRepository rRepos = new ReceiptRepository();
            IReceiptInfoRepository rInfoRepos = new ReceiptInfoRepository();
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
    }
}
