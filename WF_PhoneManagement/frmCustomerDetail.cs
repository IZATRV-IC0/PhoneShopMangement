using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileSaleLibrary;
using MobileSaleLibrary.Models;
using MobileSaleLibrary.Repository;
using MobileSaleLibrary.Repository.IRepository;

namespace WF_PhoneManagement
{
    public partial class frmCustomerDetail : Form
    {
        public bool hasClosed;
        Customer? customer;

        public frmCustomerDetail()
        {
            InitializeComponent();
            ResetForm();
            ResetData();
        }

        public Customer? GetCustomer()
        {
            return customer;
        }

        public void ResetData()
        {
            customer = new Customer();
        }

        public void ResetForm()
        {
            txtAddress.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to apply changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    throw new Exception("Cancelled.");
                }
                customer = new Customer();
                if (!txtID.Text.Equals(""))
                {
                    customer.CustomerId = Int32.Parse(txtID.Text);
                }
                customer.CustomerName = txtName.Text;
                customer.CustomerPhoneNumber = txtPhone.Text;
                customer.CustomerAddress = txtAddress.Text;
                if (rbtn_Male.Checked)
                {
                    customer.Gender = "Male";
                } 
                else
                {
                    if (rbtn_Female.Checked)
                    {
                        customer.Gender = "Female";
                    } 
                    else
                    {
                        customer.Gender = "X";
                    }
                }
                ResetForm();
                this.Close();
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Cancelled."))
                {
                    MessageBox.Show("Receive request. " + ex, "Abort", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (ex is ArgumentException || ex is FormatException || ex is OverflowException)
                    {
                        MessageBox.Show("Error while parse. Check text box ID and Parse method and try again.\n"
                                        + "Info: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error occured.\n"
                                        + "Info: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                customer = null;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            customer = null;
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
    }
}
