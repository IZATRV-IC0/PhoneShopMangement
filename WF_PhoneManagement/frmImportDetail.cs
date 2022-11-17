using Microsoft.VisualBasic.Devices;
using MobileSaleLibrary.BussinessObject;
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
    public partial class frmImportDetail : Form
    {

        IPhoneRepository phoneRepository;
        ISupplierRepository supplierRepository;
        IImportInfoRepository importInfoRepository;
        IImportRepository importRepository;
        IModelRepository modelRepository;
        BindingSource sourse;
        List<PhoneCart> phoneList;
        
        public frmImportDetail()
        {
            InitializeComponent();
            phoneRepository = new PhoneRepository();
            supplierRepository = new SupplierRepository();
            importInfoRepository = new ImportInfoRepository();
            importRepository = new ImportRepository();
            modelRepository = new ModelRepository();
            phoneList = new List<PhoneCart>();
        }

        
        void setup()
        {
            var phoneList = phoneRepository.GetPhones();
            var supplierList = supplierRepository.GetSupplierList();
            foreach (var phone in phoneList)
            {
                txtPhoneID.Items.Add(phone.PhoneId);
            }
            foreach (var supplier in supplierList)
            {
                txtSupplierID.Items.Add(supplier.SupplierId);
            }
            txtSupplierID.SelectedIndex = 0;
            txtPhoneID.SelectedIndex = 0;
        }

        private void frmImportDetail_Load(object sender, EventArgs e)
        {
            setup();
            LoadPhoneList();
        }


        private void frmImportDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhoneID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int phoneID = (int)txtPhoneID.SelectedItem;
            var phone = phoneRepository.GetPhoneByID(phoneID);
            txtPhoneName.Text = modelRepository.GetModelByID(phone.ModelId).ModelName;
            txtPrice.Text = phone.ShowPrice.ToString();
        }

        private void txtSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int supplierID = (int)txtSupplierID.SelectedItem;  
            var supplier = supplierRepository.GetSupplierByID(supplierID);
            txtSupplierName.Text = supplier.SupplierName;
            txtSupplierPhone.Text = supplier.SupplierPhoneNumber;
            txtSupplierAddress.Text = supplier.SupplierAddress;
            txtQuantity.Value = 1;
        }
        PhoneCart getPhoneCart(int id)
        {
            foreach (PhoneCart phone in phoneList)
            {
                if (phone.PhoneID == id)
                {
                    return phone;
                }
            }
            return null;
        }
        private void btnAddphone_Click(object sender, EventArgs e)
        {
            try
            {
                Phone phone = phoneRepository.GetPhoneByID((int)txtPhoneID.SelectedItem);
                Model model = modelRepository.GetModelByID(phone.ModelId);
                PhoneCart phoneCart = getPhoneCart(phone.PhoneId);
                if (phoneCart == null)
                {
                    phoneCart = new PhoneCart
                    {
                        PhoneID = phone.PhoneId,
                        Price = phone.ShowPrice,
                        Quantity = (int)txtQuantity.Value,
                        PhoneName = model.ModelName,
                        Brand = model.ModelBrand,
                        Type = phone.Type,
                    };
                    phoneList.Add(phoneCart);
                }
                else
                {
                    phoneCart.updateQuantity((int)txtQuantity.Value);
                }
                LoadPhoneList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadPhoneList()
        {
            sourse = new BindingSource();
            sourse.DataSource = this.phoneList;

            dgvPhoneList.DataSource = null;
            dgvPhoneList.DataSource = sourse;
        }
        private void btndeletePhone_Click(object sender, EventArgs e)
        {
            int id = (int)dgvPhoneList.CurrentRow.Cells[0].Value;
            PhoneCart phone = getPhoneCart(id);
            if (phone != null)
            {
                phoneList.Remove(phone);
                LoadPhoneList();
            }
        }
    }
}
