using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using MobileSaleLibrary.Models;
using MobileSaleLibrary.Repository;
using MobileSaleLibrary.Repository.IRepository;

namespace WF_PhoneManagement
{
    public partial class frmRe_Im : Form
    {
        IReceiptInfoRepository recInfoRepos = new ReceiptInfoRepository();
        IReceiptRepository recRepos = new ReceiptRepository();
        IImportInfoRepository impInfoRepos = new ImportInfoRepository();
        IImportRepository impRepos = new ImportRepository();
        ICustomerRepository cRepos = new CustomerRepository();
        ISupplierRepository sRepos = new SupplierRepository();


        //Object clarifies source data.
        public Customer? customer;
        public Supplier? supplier;

        //Control determines action and basic settings.
        String? control;

        //Two list used to get temporarily data while add.
        List<ReceiptInfo> recInfo;
        List<ImportInfo> impInfo;

        //Boolean type setup to push back to parent form.
        public bool hasClosed;

        //Constructor
        public frmRe_Im()
        {
            InitializeComponent();
            recInfo = new List<ReceiptInfo>();
            impInfo = new List<ImportInfo>();
            
            Receipt r = new Receipt();
            Import i = new Import();
            MobileSaleLibrary.Models.Model m = new MobileSaleLibrary.Models.Model();
            m.ModelId = 1;
            m.ModelName = "Model";
            Phone p = new Phone();
            p.Model = m;
            p.ModelId = m.ModelId;
            p.PhoneId = 1;
            p.ShowPrice = 1;
            p.Type = "Type";
            customer = new Customer();
            customer.CustomerId = 1;
            customer.CustomerName = "a";
            customer.CustomerAddress = "here";
            customer.CustomerPhoneNumber = "0x";
            customer.Gender = "Male";
            supplier = new Supplier();
            supplier.SupplierId = 1;
            supplier.SupplierName = "a";
            supplier.SupplierAddress = "here";
            supplier.SupplierPhoneNumber = "0x";
            r.ReceiptId = 1;
            r.ReceiptDate = DateTime.Now;
            r.Customer = customer;
            r.CustomerId = customer.CustomerId;
            ReceiptInfo re = new ReceiptInfo();
            re.Receipt = r;
            re.ReceiptId = r.ReceiptId;
            re.Phone = p;
            re.PhoneId = p.PhoneId;
            re.Quantity = 1;
            re.SellPricePerUnit = p.ShowPrice;
            i.ImportId = 1;
            i.ImportDate = DateTime.Now;
            i.Supplier = supplier;
            i.SupplierId = i.Supplier.SupplierId;
            ImportInfo im = new ImportInfo();
            im.Import = i;
            im.ImportId = im.Import.ImportId;
            im.Phone = p;
            im.PhoneId = p.PhoneId;
            im.BuyPricePerUnit = p.ShowPrice;
            im.Quantity = 1;

            recInfo.Add(re);
            impInfo.Add(im);
            dgvRe_DetailList.DataSource = recInfo;
            dgvIm_DetailList.DataSource = impInfo;
            cbbRe_PID.DataBindings.Add("Text", recInfo, "PhoneId");
            txtRe_PName.DataBindings.Add("Text", recInfo, "PhoneName");
            txtRe_PPrice.DataBindings.Add("Text", recInfo, "SellPricePerUnit");
            nudRe_PQuantity.DataBindings.Add("Text", recInfo, "Quantity");
            txtRe_PTotal.DataBindings.Add("Text", recInfo, "Total");
            cbbIm_PID.DataBindings.Add("Text", impInfo, "PhoneId");
            txtIm_PName.DataBindings.Add("Text", impInfo, "PhoneName");
            txtIm_PPrice.DataBindings.Add("Text", impInfo, "BuyPricePerUnit");
            nudIm_PQuantity.DataBindings.Add("Text", impInfo, "Quantity");
            txtIm_PTotal.DataBindings.Add("Text", impInfo, "Total");
        }

        //Settings for different purposes
        public void DefaultSettings()
        {

            foreach (Control c in this.Controls)
            {
                if ((c is Label) || (c is Button) || (c is DataGridView) || (c is GroupBox) || (c is TabControl))
                {
                    c.Enabled = true;
                }
                if ((c is TextBox) || (c is ComboBox) || (c is NumericUpDown))
                {
                    c.Enabled = false;
                }
            }
            this.btn_Action.Text = "Action";
            dgvRe_DetailList.DataSource = recInfo;
            dgvRe_DetailList.Columns["ReceiptId"].Visible = false;
            dgvRe_DetailList.Columns["Receipt"].Visible = false;
            dgvRe_DetailList.Columns["Phone"].Visible = false;
            dgvIm_DetailList.DataSource = impInfo;
            dgvIm_DetailList.Columns["ImportId"].Visible = false;
            dgvIm_DetailList.Columns["Import"].Visible = false;
            dgvIm_DetailList.Columns["Phone"].Visible = false;           
            control = "Default";
        }
        public void AddSettings()
        {
            
            this.btn_Action.Text = "Cart Finish...";
            control = "Add";
        }

        public void ViewRecSettings(int ReId)
        {
            tabRI.TabPages.Remove(tabpgImport);
            this.btn_Action.Hide();
            this.btnRe_PAdd.Hide();
            this.btnRe_PDelete.Hide();
            this.btnRe_PUpdate.Hide();
            this.btnRe_CChange.Hide();
            
            var list = from ReceiptInfo rI in recInfoRepos.GetReceiptInfoList()
                       where rI.ReceiptId == ReId
                       select rI;
            recInfo = (List<ReceiptInfo>)list;
            dgvRe_DetailList.DataSource = recInfo;
            control = "ViewRec";
        }

        public void ViewImpSettings(int ImId)
        {
            tabRI.TabPages.Remove(tabpgReceipt);
            this.btn_Action.Hide();
            this.btnIm_PAdd.Hide();
            this.btnIm_PDelete.Hide();
            this.btnIm_PUpdate.Hide();
            this.btnRe_CChange.Hide();
            var list = from ImportInfo iI in impInfoRepos.GetImportInfoList()
                       where iI.ImportId == ImId
                       select iI;
            impInfo = (List<ImportInfo>)list;
            dgvIm_DetailList.DataSource = impInfo;
            control = "ViewImp";
        }

        //Load form
        private void LoadMethod()
        {
            
            switch (control)
            {
                case "Add":
                    AddSettings();
                    dgvRe_DetailList.DataSource = recInfo;
                    dgvIm_DetailList.DataSource = impInfo;
                    break;
                case "ViewRec":
                    ViewRecSettings(Int32.Parse(this.txtReID.Text));
                    var currReceipt = recRepos.GetReceiptByID(Int32.Parse(this.txtReID.Text));
                    customer = cRepos.GetCustomerByID(currReceipt.CustomerId);
                    break;
                case "ViewImp":
                    ViewImpSettings(Int32.Parse(this.txtImID.Text));
                    var currImport = impRepos.GetImportByID(Int32.Parse(this.txtImID.Text));
                    supplier = sRepos.GetSupplierByID(currImport.SupplierId);
                    break;
                default:
                    DefaultSettings();
                    break;
            }
            if (customer is not null)
            {
                txtRe_CAddress.Text = customer.CustomerAddress;
                txtRe_CName.Text = customer.CustomerName;
                txtRe_CPhone.Text = customer.CustomerPhoneNumber;
            } else
            {
                txtRe_CAddress.Text = "";
                txtRe_CName.Text = "";
                txtRe_CPhone.Text = "";
            }
            if (supplier is not null)
            {
                txtIm_SAddress.Text = supplier.SupplierAddress;
                txtIm_SName.Text = supplier.SupplierName;
                txtIm_SPhone.Text = supplier.SupplierPhoneNumber;
            } else
            {
                txtIm_SAddress.Text = "";
                txtIm_SName.Text = "";
                txtIm_SPhone.Text = "";
            }
        }
        
        //Close notify
        static bool CloseHandling()
        {
            string message = "Close the manager?";
            string caption = "Close";
            DialogResult result = MessageBox.Show(message, caption,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void frmRe_Im_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseHandling())
            {
                e.Cancel = true;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRe_Im_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
            LoadMethod();
            recInfo = new List<ReceiptInfo>();
            impInfo = new List<ImportInfo>();
            customer = null;
            supplier = null;
            dgvRe_DetailList.DataSource = null;
            dgvIm_DetailList.DataSource = null;
        }



        private void frmRe_Im_Load(object sender, EventArgs e) => LoadMethod();

        private void btn_Action_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabRI.SelectedTab.Equals(tabpgReceipt))
                {
                    if (customer is null)
                    {
                        throw new Exception("You haven't selected customer yet!");
                    } else
                    {
                        Receipt rec = new Receipt();
                        rec.ReceiptDate = DateTime.Now;
                        rec.CustomerId = customer.CustomerId;
                        recRepos.AddNewReceipt(rec);
                        rec = recRepos.GetReceiptList().Last();
                        foreach(ReceiptInfo recI in recInfo)
                        {
                            recI.ReceiptId = rec.ReceiptId;
                            recInfoRepos.CreateReceiptInfo(recI);
                        }
                    }
                    MessageBox.Show("Receipt create successfully.\n" +
                                    "To view full detail of receipt, go to View.", 
                                    "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (supplier is null)
                    {
                        throw new Exception("You haven't selected supplier yet!");
                    }
                    else
                    {
                        Import imp = new Import();
                        imp.ImportDate = DateTime.Now;
                        imp.SupplierId = supplier.SupplierId;
                        impRepos.AddNewImport(imp);
                        imp = impRepos.GetImportList().Last();
                        foreach (ImportInfo impI in impInfo)
                        {
                            impI.ImportId = imp.ImportId;
                            impInfoRepos.AddNewImportInfo(impI);
                        }
                    }
                    MessageBox.Show("Import create successfully.\n" +
                                    "To view full detail of import, go to View.",
                                    "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult result = MessageBox.Show("Reload as new run in the current tab page?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (tabRI.SelectedTab == tabpgReceipt)
                    {
                        recInfo.Clear();
                        customer = new Customer();
                        LoadMethod();
                    } else
                    {
                        impInfo.Clear();
                        supplier = new Supplier();
                        LoadMethod();
                    }
                }
            }
        }

        private void btnRe_PAdd_Click(object sender, EventArgs e)
        {
            frmReceiptDetail ReDetail = new frmReceiptDetail();
            ReDetail.ShowDialog();
            while (!ReDetail.hasClosed)
            {
            }
            if (ReDetail.GetReceiptInfo() != null)
            {
                recInfo.Add(ReDetail.GetReceiptInfo());
            }
            LoadMethod();
        }

        private void btnRe_PUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmReceiptDetail ReDetail = new frmReceiptDetail();
                ReDetail.ShowDialog();
                while (!ReDetail.hasClosed)
                {
                }
                if (ReDetail.GetReceiptInfo() != null)
                {
                    int i = 0;
                    bool findCurr = false;
                    while (i < recInfo.Count && !findCurr)
                    {
                        if (recInfo[i].PhoneId == Int32.Parse(cbbRe_PID.Text))
                        {
                            findCurr = true;
                        }
                        i++;
                    }
                    if (i == recInfo.Count && !findCurr)
                    {
                        throw new Exception("Can't find selected item exception.");
                    }
                    else
                    {
                        recInfo[i] = ReDetail.GetReceiptInfo();
                        MessageBox.Show("Update successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadMethod();
        }

        private void btnRe_PDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (recInfo is null)
                {
                    throw new Exception("Cart is empty!");
                }
                DialogResult result = MessageBox.Show("Do you want to delete chosen items in cart?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int i = 0;
                    bool findCurr = false;
                    while (i < recInfo.Count && !findCurr)
                    {
                        if (recInfo[i].PhoneId == Int32.Parse(cbbRe_PID.Text))
                        {
                            findCurr = true;
                        }
                        i++;
                    }
                    if (i == recInfo.Count && !findCurr)
                    {
                        throw new Exception("Can't find selected item exception.");
                    }
                    else
                    {
                        recInfo.Remove(recInfo[i - 1]);
                        if (recInfo.Count == 0)
                        {
                            recInfo = null;
                        }
                        MessageBox.Show("Delete successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Exception:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadMethod();
        }

        private void btnRe_CChange_Click(object sender, EventArgs e)
        {

        }
        private void btnIm_PAdd_Click(object sender, EventArgs e)
        {
            frmImportDetail ImDetail = new frmImportDetail();
            ImDetail.ShowDialog();
            while (!ImDetail.hasClosed)
            {
            }
            if (ImDetail.GetImportInfo() != null)
            {
                impInfo.Add(ImDetail.GetImportInfo());
                MessageBox.Show("Add successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            LoadMethod();
        }
        private void btnIm_PUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmImportDetail ImDetail = new frmImportDetail();
                ImDetail.ShowDialog();
                while (!ImDetail.hasClosed)
                {
                }
                if (ImDetail.GetImportInfo() != null)
                {
                    int i = 0;
                    bool findCurr = false;
                    while (i < impInfo.Count && !findCurr)
                    {
                        if (impInfo[i].PhoneId == Int32.Parse(cbbIm_PID.Text))
                        {
                            findCurr = true;
                        }
                        i++;
                    }
                    if (i == impInfo.Count && !findCurr)
                    {
                        throw new Exception("Can't find selected item exception.");
                    }
                    else
                    {
                        impInfo[i] = ImDetail.GetImportInfo();
                        MessageBox.Show("Update successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadMethod();
        }

        private void btnIm_PDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (impInfo is null)
                {
                    throw new Exception("Cart is empty!");
                }
                DialogResult result = MessageBox.Show("Do you want to delete chosen items in cart?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int i = 0;
                    bool findCurr = false;
                    while (i < impInfo.Count && !findCurr)
                    {
                        if (impInfo[i].PhoneId == Int32.Parse(cbbIm_PID.Text))
                        {
                            findCurr = true;
                        }
                        i++;
                    }
                    if (i == impInfo.Count && !findCurr)
                    {
                        throw new Exception("Can't find selected item exception.");
                    }
                    else
                    {
                        impInfo.Remove(impInfo[i - 1]);
                        if (impInfo.Count == 0)
                        {
                            impInfo = null;
                        }
                        MessageBox.Show("Delete successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadMethod();
        }
    }
}
