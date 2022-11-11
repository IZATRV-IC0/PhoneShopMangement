using MobileSaleLibrary.Models;
using MobileSaleLibrary.Repository;
using MobileSaleLibrary.Repository.IRepository;
using System.ComponentModel;
using System.Data;
using System.Linq.Dynamic.Core;
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
            btnAdd.Hide();
            btnEdit.Hide();
            
        }

        public bool ConfirmMsgBox(string s)
        {
            return DialogResult.Yes.Equals(MessageBox.Show(s, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }
        public void AllowDataHandling(bool check)
        {
            lboxBox.Enabled = check;
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
            if (mainFeature)
            {
                switch (index)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        frmCustomerDetail getAddC = new frmCustomerDetail();
                        Customer c = new Customer();
                        c.CustomerId = 0;
                        c.Gender = "Male";
                        getAddC.setDefaultData(c);
                        getAddC.DialogResult = DialogResult.None;
                        getAddC.ShowDialog();
                        if (getAddC.DialogResult == DialogResult.OK)
                        {
                            Customer? cData = cRepos.StringConvert(getAddC.dataString);
                            if (cData is null)
                            {
                                MessageBox.Show("Please check your data again.", "DataError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                try
                                {
                                    cRepos.AddNewCustomer(cData);
                                    DefaultSettings();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Add data failed. Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                getAddC.Close();
                            }
                        }
                        if (getAddC.DialogResult == DialogResult.Cancel)
                        {
                            getAddC.Close();
                        }
                        break;
                    case 3:
                        frmSupplierDetail getAddS = new frmSupplierDetail();
                        Supplier s = new Supplier();
                        s.SupplierId = 0;
                        getAddS.setDefaultData(s);
                        getAddS.DialogResult = DialogResult.None;
                        getAddS.ShowDialog();
                       
                            if (getAddS.DialogResult == DialogResult.OK)
                            {
                                if (ConfirmMsgBox("Perform action?"))
                                {
                                    Supplier? sData = sRepos.StringConvert(getAddS.dataString);
                                    if (sData is null)
                                    {
                                        MessageBox.Show("Please check your data again.", "DataError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        getAddS.Close();
                                        try
                                        {
                                            sRepos.AddNewSupplier(sData);
                                            DefaultSettings();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Add data failed. Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                } else
                                {
                                    getAddS.DialogResult = DialogResult.None;
                                }
                            }
                            if (getAddS.DialogResult == DialogResult.Cancel)
                            {
                                getAddS.Close();
                            }
                        
                        break;
                    case 4:
                        frmModelDetail getAddM = new frmModelDetail();
                        Model m = new Model();
                        m.ModelId = 0;
                        getAddM.setDefaultData(m);
                        getAddM.DialogResult = DialogResult.None;
                        getAddM.ShowDialog();
                        
                            if (getAddM.DialogResult == DialogResult.OK)
                            {
                                if (ConfirmMsgBox("Perform action?"))
                                {
                                    Model? mData = mRepos.StringConvert(getAddM.dataString);
                                    if (mData is null)
                                    {
                                        MessageBox.Show("Please check your data again.", "DataError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        getAddM.Close();
                                        try
                                        {
                                            mRepos.AddNewModel(mData);
                                            DefaultSettings();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Add data failed. Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                } else
                                {
                                    getAddM.DialogResult = DialogResult.None;
                                }
                            }
                            if (getAddM.DialogResult == DialogResult.Cancel)
                            {
                                getAddM.Close();
                            }
                        
                        break;
                    case 5:
                        frmPhoneDetail getAddP = new frmPhoneDetail();
                        Phone p = new Phone();
                        p.ModelId = 0;
                        getAddP.setDefaultData(p);
                        getAddP.DialogResult = DialogResult.None;
                        getAddP.ShowDialog();
                        
                            if (getAddP.DialogResult == DialogResult.OK)
                            {
                                if (ConfirmMsgBox("Perform action?"))
                                {
                                    Phone? pData = pRepos.StringConvert(getAddP.dataString);
                                    if (pData is null)
                                    {
                                        MessageBox.Show("Please check your data again.", "DataError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        getAddP.Close();
                                        try
                                        {
                                            pRepos.AddNewPhone(pData);
                                            DefaultSettings();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Add data failed. Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                } else
                                {
                                    getAddP.DialogResult = DialogResult.None;
                                }
                            }
                            if (getAddP.DialogResult == DialogResult.Cancel)
                            {
                                getAddP.Close();
                            }
                        
                        break;
                    default:
                        throw new Exception("Index out of bound exception");
                }
                LoadMethod();
            }
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
                            frmCustomerDetail editC = new frmCustomerDetail();
                            editC.setDefaultData(c);
                            editC.ShowDialog();
                                if (editC.DialogResult == DialogResult.OK)
                                {
                                    if (ConfirmMsgBox("Perform action?"))
                                    {
                                        Customer? cData = cRepos.StringConvert(editC.dataString);
                                        if (cData is null)
                                        {
                                            MessageBox.Show("Please check your data again.", "DataError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            editC.Close();
                                            try
                                            {
                                                cRepos.UpdateCustomer(cData);
                                                DefaultSettings();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Edit data failed. Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    } else
                                    {
                                        editC.DialogResult = DialogResult.None;
                                    }
                                }
                                if (editC.DialogResult == DialogResult.Cancel)
                                {
                                    editC.Close();
                                }
                            
                            break;
                        case 3:
                            frmSupplierDetail editS = new frmSupplierDetail();
                            Supplier s = sRepos.GetSupplierByID(id);
                            editS.setDefaultData(s);
                            editS.DialogResult = DialogResult.None;
                            editS.ShowDialog();
                            
                                if (editS.DialogResult == DialogResult.OK)
                                {
                                    if (ConfirmMsgBox("Perform action?"))
                                    {
                                        Supplier? sData = sRepos.StringConvert(editS.dataString);
                                        if (sData is null)
                                        {
                                            MessageBox.Show("Please check your data again.", "DataError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            editS.Close();
                                            try
                                            {
                                                sRepos.AddNewSupplier(sData);
                                                DefaultSettings();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Edit data failed. Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    } else
                                    {
                                        editS.DialogResult = DialogResult.None;
                                    }
                                }
                                if (editS.DialogResult == DialogResult.Cancel)
                                {
                                    editS.Close();
                                }
                            
                            break;
                        case 4:
                            frmModelDetail editM = new frmModelDetail();
                            Model m = mRepos.GetModelByID(id);
                            editM.setDefaultData(m);
                            editM.DialogResult = DialogResult.None;
                            editM.ShowDialog();
                            
                                if (editM.DialogResult == DialogResult.OK)
                                {
                                    if (ConfirmMsgBox("Perform action?"))
                                    {
                                        Model? mData = mRepos.StringConvert(editM.dataString);
                                        if (mData is null)
                                        {
                                            MessageBox.Show("Please check your data again.", "DataError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            editM.Close();
                                            try
                                            {
                                                mRepos.AddNewModel(mData);
                                                DefaultSettings();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Add data failed. Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    } else
                                    {
                                        editM.DialogResult = DialogResult.None;
                                    }
                                }
                                if (editM.DialogResult == DialogResult.Cancel)
                                {
                                    editM.Close();
                                }
                            
                            break;
                        case 5:
                            frmPhoneDetail editP = new frmPhoneDetail();
                            Phone p = pRepos.GetPhoneByID(id);
                            editP.setDefaultData(p);
                            editP.DialogResult = DialogResult.None;
                            editP.ShowDialog();
                            
                                if (editP.DialogResult == DialogResult.OK)
                                {
                                    if (ConfirmMsgBox("Perform action?"))
                                    {
                                        Phone? pData = pRepos.StringConvert(editP.dataString);
                                        if (pData is null)
                                        {
                                            MessageBox.Show("Please check your data again.", "DataError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            editP.Close();
                                            try
                                            {
                                                pRepos.AddNewPhone(pData);
                                                DefaultSettings();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Add data failed. Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    } else
                                    {
                                        editP.DialogResult = DialogResult.None;
                                    }
                                }
                                if (editP.DialogResult == DialogResult.Cancel)
                                {
                                    editP.Close();
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

                bool valueResult = false;
                foreach (DataGridViewRow row in dgvShowList.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dgvShowList.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }
                }
                if (!valueResult)
                {
                    throw new Exception("Unable to find " + txtSearchInfo.Text);
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
                                frmRe_Im viewR = new frmRe_Im();
                                
                                viewR.setRec(id);
                                viewR.ViewRecSettings(id);
                                viewR.dataBindings();
                                viewR.ShowDialog();
                                break;
                            case 1:
                                frmRe_Im viewI = new frmRe_Im();
                                
                                viewI.setImp(id);
                                viewI.ViewImpSettings(id);
                                viewI.dataBindings();
                                viewI.ShowDialog();
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
