using MobileSaleLibrary.Models;
using MobileSaleLibrary.Repository;
using MobileSaleLibrary.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WF_PhoneManagement
{
    public partial class frmSupplierDetail : Form
    {
        ISupplierRepository supplierRepository = new SupplierRepository();
        public bool isAdd { get; set; }
        public Supplier Supplier { get; set; }
        public frmSupplierDetail()
        {
            InitializeComponent();
        }

       
        private void setup()
        {
            if(isAdd == false)
            {
                txtSupplierID.Text = Supplier.SupplierId.ToString();
                txtSupplierName.Text = Supplier.SupplierName.ToString();
                txtAddress.Text = Supplier.SupplierAddress;
                txtPhone.Text = Supplier.SupplierPhoneNumber;
            }
        }


        private void frmSupplierDetail_Load(object sender, EventArgs e)
        {
            setup();    
        }

        private void frmSupplierDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmSupplierDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier
            {
                SupplierId = int.Parse(txtSupplierID.Text),
                SupplierName = txtSupplierName.Text,
                SupplierAddress = txtAddress.Text,
                SupplierPhoneNumber = txtPhone.Text,
            };
            try
            {
                if (isAdd)
                {
                    supplierRepository.AddNewSupplier(supplier);
                }
                else
                {
                    supplierRepository.UpdateSupplier(supplier);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, isAdd ? "Add new supplier" : "Update supplier");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
