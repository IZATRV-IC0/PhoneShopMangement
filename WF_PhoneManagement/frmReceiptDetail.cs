using Microsoft.EntityFrameworkCore.Metadata;
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

namespace WF_PhoneManagement
{
    public partial class frmReceiptDetail : Form
    {
        IPhoneRepository phoneRepository;
        ICustomerRepository customerRepository;
        IReceiptRepository receiptRepository;
        IReceiptInfoRepository receiptInfoRepository;
        IModelRepository modelRepository;
        BindingSource sourse;
        List<PhoneCart> phoneList;
        
        public bool isAdd { get; set; }
        public Phone Phone { get; set; }
        public Customer Customer { get; set; }
        public int ReceiptID { get; set; }
        public frmReceiptDetail()
        {
            InitializeComponent();
            phoneRepository = new PhoneRepository();
            customerRepository = new CustomerRepository();
            receiptRepository = new ReceiptRepository();
            receiptInfoRepository = new ReceiptInfoRepository();
            modelRepository = new ModelRepository();
            phoneList = new List<PhoneCart>();
        }
        void setup()
        {
            if (isAdd)
            {
                var phoneList = phoneRepository.GetPhones();
                var customerList = customerRepository.GetCustomerList();
                foreach (var phone in phoneList)
                {
                    txtPhoneID.Items.Add(phone.PhoneId);
                }
                foreach (var customer in customerList)
                {
                    txtCustomerID.Items.Add(customer.CustomerId);
                }
                txtPhoneID.SelectedIndex = 0;
                txtCustomerID.SelectedIndex = 0;
            }
            else
            {
                Receipt receipt = receiptRepository.GetReceiptByID(ReceiptID);
                IEnumerable<ReceiptInfo> receiptInfos = receiptInfoRepository.GetReceiptInfoList().Where(o => o.ReceiptId == ReceiptID);
                foreach (ReceiptInfo receiptInfo in receiptInfos)
                {
                    var aphone = phoneRepository.GetPhoneByID(receiptInfo.PhoneId);
                    var model = modelRepository.GetModelByID(aphone.ModelId);
                    PhoneCart phone = new PhoneCart
                    {
                        PhoneID = receiptInfo.PhoneId,
                        Price = receiptInfo.SellPricePerUnit,
                        PhoneName = model.ModelName,
                        Brand = model.ModelBrand,
                        Type = aphone.Type,
                        Quantity = receiptInfo.Quantity,
                    };
                    phoneList.Add(phone);
                }
                grPhone.Visible = false;
                grImport.Visible = true;
                btnSave.Visible = false;
                dgvPhoneList.Location = new Point(270, 250);

                txtReceiptID.Text = receipt.ReceiptId.ToString();
                txtReceiptDate.Text = receipt.ReceiptDate.ToString();
                txtCustomerID.Items.Add(receipt.CustomerId);
                txtCustomerID.SelectedIndex = 0;

            }
            
        }
        

        private void frmReceiptDetail_Load(object sender, EventArgs e)
        {

            setup();
            LoadPhoneList();
        }


        private void frmReceiptDetail_FormClosed(object sender, FormClosedEventArgs e)
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
            
        }

        private void txtCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int customerID = (int)txtCustomerID.SelectedItem;
            var customer = customerRepository.GetCustomerByID(customerID);
            txtCustomerPhone.Text = customer.CustomerPhoneNumber;
            txtCutomerName.Text = customer.CustomerName;
            txtCustomerAddress.Text = customer.CustomerAddress;
        }

        private void txtPhoneID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int phoneID = (int)txtPhoneID.SelectedItem; 
            var phone = phoneRepository.GetPhoneByID(phoneID);
            txtPhoneName.Text = modelRepository.GetModelByID(phone.ModelId).ModelName;
            txtPrice.Text = phone.ShowPrice.ToString();
            txtQuantity.Value = 1;
        }
        PhoneCart getPhoneCart(int id)
        {
            foreach(PhoneCart phone in phoneList)
            {
                if(phone.PhoneID == id)
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
            catch(Exception ex)
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
            SetTotalPrice();
        }

        void SetTotalPrice ()
        {

            int totalPrice = 0;
            foreach (PhoneCart phoneCart in phoneList)
            {
                totalPrice += phoneCart.Price * phoneCart.Quantity;
            }

            txtTotal.Text = totalPrice.ToString();
        }

        private void btndeletePhone_Click(object sender, EventArgs e)
        {
            int id = (int)dgvPhoneList.CurrentRow.Cells[0].Value;
            PhoneCart phone = getPhoneCart(id);
            if(phone != null)
            {
                phoneList.Remove(phone);
                LoadPhoneList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addReceipt();
            addReceiptInfo();
        }
        void addReceipt()
        {
            DateTime date = DateTime.Now;
            int customerId = (int)txtCustomerID.SelectedItem;
            Receipt receipt = new Receipt
            {
                ReceiptDate = date,
                CustomerId = customerId,
            };
            receiptRepository.AddNewReceipt(receipt);
        }
        void addReceiptInfo()
        {
            int receiptId = getCurrentReceiptID();
            foreach(PhoneCart phone in phoneList)
            {
                ReceiptInfo receiptInfo = new ReceiptInfo
                {
                    ReceiptId = receiptId,
                    PhoneId = phone.PhoneID,
                    SellPricePerUnit = phone.Price,
                    Quantity = phone.Quantity,
                };
                receiptInfoRepository.CreateReceiptInfo(receiptInfo);
            }
        }
        int getCurrentReceiptID()
        {
            return receiptRepository.GetReceiptList().Max(o => o.ReceiptId);
        }
    }
}
