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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            dgvRe_DetailList.DataSource = recInfo;
            dgvIm_DetailList.DataSource = impInfo;
            btnRe_Customer.Enabled = true;
            btnIm_Supplier.Enabled = true;
            dgvRe_DetailList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIm_DetailList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void dataBindings()
        {
            txtRe_PID.DataBindings.Add("Text", dgvRe_DetailList.DataSource, "PhoneId");
            txtRe_PName.DataBindings.Add("Text", dgvRe_DetailList.DataSource, "PhoneName");
            txtRe_PPrice.DataBindings.Add("Text", dgvRe_DetailList.DataSource, "SellPricePerUnit");
            nudRe_PQuantity.DataBindings.Add("Text", dgvRe_DetailList.DataSource, "Quantity");
            txtRe_PTotal.DataBindings.Add("Text", dgvRe_DetailList.DataSource, "Total");
            txtIm_PID.DataBindings.Add("Text", dgvIm_DetailList.DataSource, "PhoneId");
            txtIm_PName.DataBindings.Add("Text", dgvIm_DetailList.DataSource, "PhoneName");
            txtIm_PPrice.DataBindings.Add("Text", dgvIm_DetailList.DataSource, "BuyPricePerUnit");
            nudIm_PQuantity.DataBindings.Add("Text", dgvIm_DetailList.DataSource, "Quantity");
            txtIm_PTotal.DataBindings.Add("Text", dgvIm_DetailList.DataSource, "Total");
        }

        void TotalSet()
        {
            if (recInfo is null || recInfo.Count == 0)
            {
                txtReTotal.Text = "0";
            } else
            {
                int total = 0;
                foreach(ReceiptInfo r in recInfo)
                {
                    total += r.Total;
                }
                txtReTotal.Text = "" + total;
            }
            if (impInfo is null || impInfo.Count == 0)
            {
                txtImTotal.Text = "0";
            }
            else
            {
                int total = 0;
                foreach (ImportInfo i in impInfo)
                {
                    total += i.Total;
                }
                txtImTotal.Text = "" + total;
            }
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
        public void setRec(int ReId)
        {
            txtReID.Text = "" + ReId;
        }
        public void setImp(int ImId)
        {
            txtReID.Text = "" + ImId;
        }
        public void ViewRecSettings(int ReId)
        {
            tabRI.TabPages.Remove(tabpgImport);
            this.btn_Action.Hide();
            this.btnRe_PAdd.Hide();
            this.btnRe_PDelete.Hide();
            this.btnRe_PUpdate.Hide();
            this.btnRe_Customer.Hide();
            
            var list = recInfoRepos.GetReceiptInfoListByRecieptID(ReId);
            recInfo = list.ToList();
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
            this.btnRe_Customer.Hide();
            var list = from ImportInfo iI in impInfoRepos.GetImportInfoList()
                       where iI.ImportId == ImId
                       select iI;
            impInfo = list.ToList();
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
                    if (recInfo is null || recInfo.Count == 0)
                    {
                        dgvRe_DetailList.DataSource = null;
                        dgvRe_DetailList.Enabled = false;
                        btnRe_PDelete.Enabled = false;
                        btnRe_PUpdate.Enabled = false;
                    } else
                    {
                        dgvRe_DetailList.DataSource = recInfo;
                        dgvRe_DetailList.Enabled = true;
                        btnRe_PDelete.Enabled = true;
                        btnRe_PUpdate.Enabled = true;
                    }
                    if (impInfo is null || impInfo.Count == 0)
                    {
                        dgvIm_DetailList.DataSource = null;
                        dgvIm_DetailList.Enabled = false;
                        btnIm_PDelete.Enabled = false;
                        btnIm_PUpdate.Enabled = false;
                    } else
                    {
                        dgvIm_DetailList.DataSource = impInfo;
                        dgvIm_DetailList.Enabled = true;
                        btnIm_PDelete.Enabled = true;
                        btnIm_PUpdate.Enabled = true;
                    }
                    break;
                case "ViewRec":
                    ViewRecSettings(Int32.Parse(this.txtReID.Text));
                    var currReceipt = recRepos.GetReceiptByID(Int32.Parse(this.txtReID.Text));
                    var customer = cRepos.GetCustomerByID(currReceipt.CustomerId);
                    txtRe_CID.Text = "" + customer.CustomerId;
                    txtRe_CAddress.Text = customer.CustomerAddress;
                    txtRe_CName.Text = customer.CustomerName;
                    txtRe_CPhone.Text = customer.CustomerPhoneNumber;
                    break;
                case "ViewImp":
                    var currImport = impRepos.GetImportByID(Int32.Parse(this.txtReID.Text));
                    var supplier = sRepos.GetSupplierByID(currImport.SupplierId);
                    txtIm_PID.Text = "" + supplier.SupplierId;
                    txtIm_SAddress.Text = supplier.SupplierAddress;
                    txtIm_SName.Text = supplier.SupplierName;
                    txtIm_SPhone.Text = supplier.SupplierPhoneNumber;
                    break;
                default:
                    DefaultSettings();
                    break;
            }
            TotalSet();
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
                    Receipt rec = new Receipt();
                    rec.ReceiptDate = DateTime.Now;
                    rec.CustomerId = Int32.Parse(txtRe_CID.Text);
                    recRepos.AddNewReceipt(rec);
                    rec = recRepos.GetReceiptList().Last();
                    foreach (ReceiptInfo recI in recInfo)
                    {
                        recI.ReceiptId = rec.ReceiptId;
                        recInfoRepos.CreateReceiptInfo(recI);
                    }
                    MessageBox.Show("Receipt create successfully.\n" +
                                    "To view full detail of receipt, go to View.",
                                    "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    Import imp = new Import();
                    imp.ImportDate = DateTime.Now;
                    imp.SupplierId = Int32.Parse(txtIm_SID.Text);
                    impRepos.AddNewImport(imp);
                    imp = impRepos.GetImportList().Last();
                    foreach (ImportInfo impI in impInfo)
                    {
                        impI.ImportId = imp.ImportId;
                        impInfoRepos.AddNewImportInfo(impI);
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
                        LoadMethod();
                    } else
                    {
                        impInfo.Clear();
                        LoadMethod();
                    }
                }
            }
        }

        private void btnRe_PAdd_Click(object sender, EventArgs e)
        {
            frmReceiptDetail ReDetail = new frmReceiptDetail();
            ReDetail.ShowDialog();
            if (ReDetail.dataString != null && ReDetail.dataString != ",," && !ReDetail.DialogResult.Equals(DialogResult.Cancel))
            {
                var rI = recInfoRepos.StringConvert(ReDetail.dataString);
                recInfo.Add(rI);
            }
            LoadMethod();
        }

        private void btnRe_PUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmReceiptDetail ReDetail = new frmReceiptDetail();
                ReDetail.ShowDialog();
                if (ReDetail.dataString is not null && ReDetail.dataString != ",," && !ReDetail.DialogResult.Equals(DialogResult.Cancel))
                {
                    int i = 0;
                    bool findCurr = false;
                    while (recInfo != null && i < recInfo.Count && !findCurr)
                    {
                        if (recInfo[i].PhoneId == Int32.Parse(txtReID.Text))
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
                        recInfo[i] = recInfoRepos.StringConvert(ReDetail.dataString);
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
                        if (recInfo[i].PhoneId == Int32.Parse(txtRe_PID.Text))
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
        private void btnIm_PAdd_Click(object sender, EventArgs e)
        {
            frmImportDetail ImDetail = new frmImportDetail();
            ImDetail.ShowDialog();
            if (ImDetail.dataString is not null && ImDetail.dataString != ",," && !ImDetail.DialogResult.Equals(DialogResult.Cancel))
            {
                var iI = impInfoRepos.StringConvert(ImDetail.dataString);
                impInfo.Add(iI);
            }
            
            LoadMethod();
        }
        private void btnIm_PUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmImportDetail ImDetail = new frmImportDetail();
                ImDetail.ShowDialog();
                if (ImDetail.dataString is not null && ImDetail.dataString != ",," && !ImDetail.DialogResult.Equals(DialogResult.Cancel))
                {
                    int i = 0;
                    bool findCurr = false;
                    while (impInfo != null && i < impInfo.Count && !findCurr)
                    {
                        if (impInfo[i].PhoneId == Int32.Parse(txtImID.Text))
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
                        impInfo[i] = impInfoRepos.StringConvert(ImDetail.dataString);
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
                        if (impInfo[i].PhoneId == Int32.Parse(txtIm_PID.Text))
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

        private void txtRe_CID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var customer = cRepos.GetCustomerByID(Int32.Parse(txtRe_CID.Text));
                if (customer is null)
                {
                    throw new Exception("No customer with id inputted.");
                }
                txtRe_CName.Text = customer.CustomerName;
                txtRe_CPhone.Text = customer.CustomerPhoneNumber;
                txtRe_CAddress.Text = customer.CustomerAddress;
            } catch (Exception ex)
            {
                MessageBox.Show("Please input right id. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIm_SID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                var supplier = sRepos.GetSupplierByID(Int32.Parse(txtIm_SID.Text));
                if (supplier is null)
                {
                    throw new Exception("No customer with id inputted.");
                }
                txtIm_SName.Text = supplier.SupplierName;
                txtIm_SPhone.Text = supplier.SupplierPhoneNumber;
                txtIm_SAddress.Text = supplier.SupplierAddress;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input right id. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRe_Customer_Click(object sender, EventArgs e)
        {
            frmView view = new frmView();
            view.SetListPickIndex(2);
            view.index = 2;
            view.mainFeature = true;
            view.instock = false;
            view.sales = false;
            view.DefaultSettings();
            view.ShowDialog();
        }

        private void btnIm_Supplier_Click(object sender, EventArgs e)
        {
            frmView view = new frmView();
            view.SetListPickIndex(3);
            view.index = 3;
            view.mainFeature = true;
            view.instock = false;
            view.sales = false;
            view.DefaultSettings();
            view.ShowDialog();
        }
    }
}
