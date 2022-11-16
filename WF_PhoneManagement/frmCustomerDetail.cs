using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using MobileSaleLibrary;
using MobileSaleLibrary.Models;
using MobileSaleLibrary.Repository;
using MobileSaleLibrary.Repository.IRepository;

namespace WF_PhoneManagement
{
    public partial class frmCustomerDetail : Form
    {
        ICustomerRepository customerRepository;
        public bool isAdd { get; set; }
        public Customer Customer { get; set; }

        public frmCustomerDetail()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
        }

       
        private void setup()
        {
            if (isAdd)
            {
                rbtn_X.Checked = true;
            }
            else
            {
                txtID.Text = Customer.CustomerId.ToString();
                txtName.Text = Customer.CustomerName;
                txtAddress.Text = Customer.CustomerAddress;
                txtPhone.Text = Customer.CustomerPhoneNumber;
                string gender = Customer.Gender;
                if (gender.Equals("Male"))
                {
                    rbtn_Male.Checked = true;
                } else if (gender.Equals("Female"))
                {
                    rbtn_Female.Checked = true;
                }
                else
                {
                    rbtn_X.Checked = true;
                }
            }
        }


       

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (id.IsNullOrEmpty())
            {
                id = "0";
            }
            string gender = "X";
            if (rbtn_Female.Checked)
            {
                gender = "Female";
            }else if (rbtn_Male.Checked)
            {
                gender = "Male";
            }
            var customer = new Customer
            {
                CustomerId = int.Parse(id),
                CustomerName = txtName.Text,
                CustomerAddress = txtAddress.Text,
                Gender = gender,
                CustomerPhoneNumber = txtPhone.Text,
            };
            if (isAdd)
            {
                customerRepository.AddNewCustomer(customer);
            }
            else
            {
                customerRepository.UpdateCustomer(customer);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 1 in 3 radio button choice.
        private void rbtn_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Male.Checked)
            {
                rbtn_Female.Checked = false;
                rbtn_X.Checked = false;
            }
            else
            {
                rbtn_Male.Checked = false;
            }
        }

        private void rbtn_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Female.Checked)
            {
                rbtn_Male.Checked = false;
                rbtn_X.Checked = false;
            }
            else
            {
                rbtn_Female.Checked = false;
            }
        }

        private void rbtn_X_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_X.Checked)
            {
                rbtn_Male.Checked = false;
                rbtn_Female.Checked = false;
            }
            else
            {
                rbtn_X.Checked = false;
            }
        }

        private void frmCustomerDetail_Load(object sender, EventArgs e)
        {
            setup();
        }

        private void frmCustomerDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
           this.Close();
        }
    }
}
