using Microsoft.IdentityModel.Tokens;
using MobileSaleLibrary.Models;
using MobileSaleLibrary.Repository;
using MobileSaleLibrary.Repository.IRepository;
using System.ComponentModel;
using System.Data;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Model = MobileSaleLibrary.Models.Model;

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
        IReceiptInfoRepository rInfoRepos = new ReceiptInfoRepository();
        IImportInfoRepository iInfoRepos = new ImportInfoRepository();


        public bool mainFeature;

        public bool sales;

        public bool instock;

        public int index;
        public frmView()
        {
            InitializeComponent();
            hasClosed = false;
            DefaultSettings();
            btnPick.Text = "Detail";
            dgvShowList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            foreach(Control c in this.Controls)
            {
                c.Enabled = true;
                c.Show();
            }
        }
        public void ViewSettings()
        {
            if (index != 0 && index != 1)
            {
                btnPick.Hide();
            }
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
            btnAdd.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
        }

        public void ReImSettings()
        {
            /*btnAdd.Hide();*/
            btnEdit.Hide();
            
        }

        public bool ConfirmMsgBox(string s)
        {
            return DialogResult.Yes.Equals(MessageBox.Show(s, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }
        public void AllowDataHandling(bool check)
        {
            btnSearch.Enabled = check;
            txtSearchInfo.Enabled = check;
        }

        void LoadMethod()
        {
            dgvShowList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                        RetrieveSettings();
                        ViewSettings();
                        break;
                    case 3:
                        RetrieveSettings();
                        ViewSettings();
                        break;
                    case 4:
                        RetrieveSettings();
                        ViewSettings();
                        break;
                    case 5:
                        RetrieveSettings();
                        ViewSettings();
                        break;
                    default:
                        source.DataSource = null;
                        break;
                }
            }
            dgvShowList.DataSource = source;
            if (dgvShowList.DataSource is not null)
            {
                AllowDataHandling(true);
            } else
            {
                AllowDataHandling(false);
            }
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
            lboxListPick.SelectedIndex = 0;
            hasClosed = false;
            SetListPickIndex(0);
            ReloadReceiptList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mainFeature)
            {
                switch (index)
                {
                    case 0:
                        frmReceiptDetail frmReceiptDetail = new frmReceiptDetail
                        {
                            isAdd = true,
                        };
                        frmReceiptDetail.ShowDialog();
                        if(frmReceiptDetail.DialogResult == DialogResult.OK)
                        {
                            ReloadReceiptList();
                            source.Position = source.Count - 1;
                        }
                        break;
                    case 1:
                        frmImportDetail frmImportDetail = new frmImportDetail
                        {
                            isAdd = true,
                        };
                        frmImportDetail.ShowDialog();
                        if( frmImportDetail.DialogResult == DialogResult.OK)
                        {
                            ReloadImportList();
                            source.Position = source.Count - 1;
                        }
                        break;
                    case 2:
                        frmCustomerDetail customerDetail = new frmCustomerDetail
                        {
                            isAdd = true,
                            Text = "Add new customer",
                        };
                        customerDetail.ShowDialog();
                        if (customerDetail.DialogResult == DialogResult.OK)
                        {
                            ReloadCustomerList();
                            source.Position = source.Count - 1;
                        }
                        break;
                    case 3:
                        frmSupplierDetail supplierDetail = new frmSupplierDetail
                        {
                            isAdd = true,
                            Text = "Add new supplier"
                        };
                        supplierDetail.ShowDialog();
                        if (supplierDetail.DialogResult == DialogResult.OK)
                        {
                            ReloadSupplierList();
                            source.Position = source.Count - 1;
                        }
                        break;
                    case 4:
                        frmModelDetail model = new frmModelDetail
                        {
                            isAdd = true,
                            Text = "Add new Model"
                        };
                        model.ShowDialog();
                        if (model.DialogResult == DialogResult.OK)
                        {
                            ReloadModelList();
                            source.Position = source.Count - 1;
                        }
                        break;
                    case 5:
                        frmPhoneDetail phoneDetail = new frmPhoneDetail
                        {
                            isAdd = true,
                            Text = "Add new phone"
                        };
                        phoneDetail.ShowDialog();
                        if(phoneDetail.DialogResult == DialogResult.OK)
                        {
                            ReloadPhoneList();
                            source.Position = source.Count - 1;
                        }

                        break;
                    default:
                        throw new Exception("Index out of bound exception");
                }
                LoadMethod();
            }
        }
        private void ReloadPhoneList([Optional] string txtsearch)
        {
            var phoneList = pRepos.GetPhones();
            var modelList = mRepos.GetModelsList();
            if (!txtsearch.IsNullOrEmpty())
            {
                phoneList = phoneList.Where(o => o.PhoneId.ToString().Equals(txtsearch) || o.GetPhoneName().ToLower().Contains(txtsearch.ToLower())).ToList();
            }
            var list = phoneList.Join(modelList, o1 => o1.ModelId, o2 => o2.ModelId, (o1, o2) => new { o1.PhoneId, o1.ShowPrice,o1.Quanity, o2.ModelId, o2.ModelName, o2.ModelBrand, o2.ModelYearOfWarranty });
           
            source.DataSource = list;
            dgvShowList.DataSource = source;
        }
        private void ReloadModelList([Optional] string txtsearch)
        {
            var list = mRepos.GetModelsList();
            if (!txtsearch.IsNullOrEmpty())
            {
                list = list.Where(o1 => o1.ModelId.ToString().Equals(txtsearch) || o1.ModelName.ToLower().Contains(txtsearch.ToLower())).ToList();
            }
            source.DataSource = list;
            dgvShowList.DataSource = source;
            dgvShowList.Columns[5].Visible = false;
        }
        private void ReloadCustomerList([Optional] string txtsearch)
        {
            var list = cRepos.GetCustomerList();
            if (!txtsearch.IsNullOrEmpty())
            {
                list = list.Where(o1 => o1.CustomerId.ToString().Equals(txtsearch) || o1.CustomerName.ToLower().Contains(txtsearch.ToLower())).ToList();
            }
            source.DataSource = list;
            dgvShowList.DataSource = source;
            dgvShowList.Columns[5].Visible = false;
        }
        private void ReloadSupplierList([Optional] string txtsearch)
        {
            var list = sRepos.GetSupplierList();
            if (!txtsearch.IsNullOrEmpty())
            {
                list = list.Where(o1 => o1.SupplierId.ToString().Equals(txtsearch) || o1.SupplierName.ToLower().Contains(txtsearch.ToLower())).ToList();
            }
            source.DataSource = list;
            dgvShowList.DataSource = source;
            dgvShowList.Columns[4].Visible = false;
        }

        private void ReloadReceiptList([Optional] string txtsearch)
        {
            var receiptList = rRepos.GetReceiptList();
            var customer = cRepos.GetCustomerList();
            var list = receiptList.Join(customer, o1 => o1.CustomerId, o2 => o2.CustomerId, (o1, o2) => new { o1.ReceiptId, o1.ReceiptDate, o2.CustomerId, o2.CustomerName, o2.CustomerPhoneNumber });
            if (!txtsearch.IsNullOrEmpty())
            {
                list = list.Where(o1 => o1.ReceiptId.ToString().Equals(txtsearch) || o1.CustomerName.ToLower().Contains(txtsearch.ToLower())).ToList();
            }
            source.DataSource = list;
            dgvShowList.DataSource = source;

        }

        private void ReloadImportList([Optional] string txtsearch)
        {
            var importList = iRepos.GetImportList();
            var supplierList = sRepos.GetSupplierList();
            var list = importList.Join(supplierList, o1 => o1.SupplierId, o2 => o2.SupplierId, (o1, o2) => new { o1.ImportId, o1.ImportDate, o2.SupplierId, o2.SupplierName, o2.SupplierPhoneNumber });
            if (!txtsearch.IsNullOrEmpty())
            {
                list = list.Where(o1 => o1.ImportId.ToString().Equals(txtsearch) || o1.SupplierName.ToLower().Contains(txtsearch.ToLower())).ToList();
            }
            source.DataSource = list;
            dgvShowList.DataSource = source;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowList.SelectedRows.Count == 0 || dgvShowList.SelectedRows.Count > 1)
                {
                    throw new Exception("Select only ONE row belongs to your designated data row before pressing Edit.");
                }
                else
                {
                    int id;
                    id = Int32.Parse(dgvShowList.SelectedRows[0].Cells[0].Value.ToString());
                    switch (index)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        case 2:
                            Customer c = cRepos.GetCustomerByID(id);
                            frmCustomerDetail customerDetail = new frmCustomerDetail
                            {
                                isAdd = false,
                                Customer = c,
                                Text = "Update customer",
                            };
                            customerDetail.ShowDialog();
                            if (customerDetail.DialogResult == DialogResult.OK)
                            {
                                ReloadCustomerList();
                            }
                            break;
                        case 3:
                            Supplier s = sRepos.GetSupplierByID(id);
                            frmSupplierDetail supplierDetail = new frmSupplierDetail
                            {
                                isAdd = false,
                                Supplier = s,
                                Text = "Update supplier",
                            };
                            supplierDetail.ShowDialog();
                            if (supplierDetail.DialogResult == DialogResult.OK)
                            {
                                ReloadSupplierList();
                            }
                            break;
                        case 4:
                            Model m = mRepos.GetModelByID(id);
                            frmModelDetail modelDetail = new frmModelDetail
                            {
                                isAdd = false,
                                Model = m,
                                Text = "Update model",
                            };
                            modelDetail.ShowDialog();
                            if (modelDetail.DialogResult == DialogResult.OK)
                            {
                                ReloadModelList();
                            }
                            break;
                        case 5:
                            Phone p = pRepos.GetPhoneByID(id);
                            frmPhoneDetail phoneDetail = new frmPhoneDetail
                            {
                                isAdd = false,
                                Phone = p,
                                Text = "Update phone",
                            };
                            phoneDetail.ShowDialog();
                            if(phoneDetail.DialogResult == DialogResult.OK)
                            {
                                ReloadPhoneList();
                            }
                            break;
                        default:
                            throw new Exception("Index out of bound exception");
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "EditError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadMethod();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConfirmMsgBox("Perform action?"))
                {
                    if (dgvShowList.SelectedRows.Count == 0 || dgvShowList.SelectedRows.Count > 1)
                    {
                        throw new Exception("Select only ONE row belongs to your designated data row before pressing Edit.");
                    }
                    else
                    {
                        int id;
                        id = Int32.Parse(dgvShowList.SelectedRows[0].Cells[0].Value.ToString());
                        switch (index)
                        {
                            case 0:
                                var relationRI = rInfoRepos.GetReceiptInfoListByRecieptID(id);
                                if (relationRI is not null)
                                {
                                    if (relationRI.Count() > 0)
                                    {
                                        if (ConfirmMsgBox("Delete all data of this receipt?"))
                                        {
                                            foreach(ReceiptInfo ri in relationRI)
                                            {
                                                rInfoRepos.DeleteReceiptInfoByReceiptIDAndPhoneID(ri.ReceiptId, ri.PhoneId);
                                            }
                                        } else
                                        {
                                            MessageBox.Show("Cancelled.","Abort",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                                        }
                                    }
                                }
                                rRepos.RemoveReceipt(id);
                                ReloadReceiptList();
                                break;
                            case 1:
                                var relationII = from ImportInfo i in iInfoRepos.GetImportInfoList()
                                                 where i.ImportId == id
                                                 select i;
                                if (relationII is not null)
                                {
                                    if (relationII.Count() > 0)
                                    {
                                        if (ConfirmMsgBox("Delete all data of this import?"))
                                        {
                                            foreach (ImportInfo ii in relationII)
                                            {
                                                iInfoRepos.RemoveImportInfo(ii.ImportId, ii.PhoneId);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Cancelled.", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        }
                                    }
                                }
                                iRepos.RemoveImport(id);
                                ReloadImportList();
                                break;
                            case 2:
                                
                                var relationR = from Receipt r in rRepos.GetReceiptList()
                                                where r.CustomerId == id
                                                select r.ReceiptId;
                                if (relationR is not null && relationR.Count() > 0)
                                {
                                    throw new Exception("Detected dependent data affected. Please take action with internal data first.");
                                }
                                cRepos.RemoveCustomer(id);
                                ReloadCustomerList();
                                break;
                            case 3:
                                var relationI = from Import i in iRepos.GetImportList()
                                                where i.SupplierId == id
                                                select i.ImportId;
                                if (relationI is not null && relationI.Count() > 0)
                                {
                                    throw new Exception("Detected dependent data affected. Please take action with internal data first.");
                                }
                                sRepos.RemoveSupplier(id);
                                ReloadSupplierList();
                                break;
                            case 4:
                                var relationP = from Phone p in pRepos.GetPhones()
                                                where p.ModelId == id
                                                select p.PhoneId;
                                if (relationP is not null && relationP.Count() > 0)
                                {
                                    throw new Exception("Detected dependent data affected. Please take action with internal data first.");
                                }
                                mRepos.DeleteModel(id);
                                ReloadModelList();
                                break;
                            case 5:
                                var relationPR = from ReceiptInfo rI in rInfoRepos.GetReceiptInfoList()
                                                 where rI.PhoneId == id
                                                 select rI;
                                var relationPI = from ImportInfo iI in iInfoRepos.GetImportInfoList()
                                                 where iI.PhoneId == id
                                                 select iI;
                                var condition = (relationPR is not null && relationPR.Count() > 0)
                                            || (relationPI is not null && relationPI.Count() > 0);
                                if (condition)
                                {
                                    throw new Exception("Detected dependent data affected. Please take action with internal data first.");
                                }
                                pRepos.DeletePhone(id);
                                ReloadPhoneList();
                                break;
                            default:
                                throw new Exception("Index out of bound exception");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "DeleteError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DefaultSettings();
                LoadMethod();
            }
        }
        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DefaultSettings();
            LoadMethod();
        }



 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtSearchInfo.Text;
                dgvShowList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int index = lboxListPick.SelectedIndex;
                switch(index){
                    case 0:
                        ReloadReceiptList(searchValue);
                        break;
                    case 1:
                        ReloadImportList(searchValue);
                        break;
                    case 2:
                        ReloadCustomerList(searchValue);
                        break;
                    case 3:
                        ReloadSupplierList(searchValue);
                        break;
                    case 4:
                        ReloadModelList(searchValue);
                        break;
                    case 5:
                        ReloadPhoneList(searchValue);
                        break;
                }
            }    
            catch (Exception ex)
            {
                MessageBox.Show("Ex: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadMethod();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            try 
            {
                if (mainFeature && (index == 0 || index == 1))
                {
                    if (dgvShowList.SelectedRows.Count == 0 || dgvShowList.SelectedRows.Count > 1)
                    {
                        throw new Exception("Select only ONE row belongs to your designated data row before pressing Detail.");
                    }
                    else
                    {
                        int id;
                        id = Int32.Parse(dgvShowList.SelectedRows[0].Cells[0].Value.ToString());
                        switch (index)
                        {
                            case 0:
                                frmReceiptDetail frmReceiptDetail = new frmReceiptDetail
                                {
                                    isAdd = false,
                                    ReceiptID = id,
                                    
                                };
                                frmReceiptDetail.ShowDialog();
                                break;
                            case 1:
                                frmImportDetail frmImportDetail = new frmImportDetail
                                {
                                    isAdd = false,
                                    ImportID = id,
                                };
                                frmImportDetail.ShowDialog();
                                break;
                            default:
                                throw new Exception("Index out of bound exception.");
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "EditError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadMethod();
            }
        }

        private void lboxListPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveSettings();
            DefaultSettings();
            txtSearchInfo.Text = "";
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
                            ReloadReceiptList();
                            break;
                        case 1:
                            ReloadImportList();
                            break;
                        case 2:
                            ReloadCustomerList();
                            break;
                        case 3:
                            ReloadSupplierList();
                            break;
                        case 4:
                            ReloadModelList();
                            break;
                        case 5:
                            ReloadPhoneList();
                            break;
                        default:
                            source.DataSource = null;
                            dgvShowList.DataSource = source;
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
