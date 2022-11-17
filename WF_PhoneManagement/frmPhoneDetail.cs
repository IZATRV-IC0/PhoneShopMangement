using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.IdentityModel.Tokens;
using MobileSaleLibrary.Models;
using MobileSaleLibrary.Repository;
using MobileSaleLibrary.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WF_PhoneManagement
{
    public partial class frmPhoneDetail : Form
    {
        public IPhoneRepository phoneRepository = new PhoneRepository();
        public IModelRepository modelRepository = new ModelRepository();
        public Phone Phone { get; set; }
        public bool isAdd { get; set; }
        public frmPhoneDetail()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string phoneID = txtPhoneID.Text;
                if (phoneID.IsNullOrEmpty())
                {
                    phoneID = "0";
                }

                int quantity = 0;
                if( !isAdd )
                {
                    quantity = Phone.Quanity;

                }

                var phone = new Phone
                {
                    
                    PhoneId = int.Parse(phoneID),
                    ModelId = int.Parse(cbModelID.Text),
                    Type = txtType.Text,
                    ShowPrice = int.Parse(txtPrice.Text),
                    Quanity = quantity,
                };
                if (isAdd)
                {
                    phoneRepository.AddNewPhone(phone);
                }
                else
                {
                    phoneRepository.UpdatePhone(phone);
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, isAdd ? "Add new phone" : "Update phone");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhoneDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void frmPhoneDetail_Load(object sender, EventArgs e)
        {
            loadModel();
            loadPhone();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
        }

        private void txtModelID_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void loadModel()
        {
            var modelList = modelRepository.GetModelsList();
            foreach(Model model in modelList)
            {
                cbModelID.Items.Add(model.ModelId);
            }
            cbModelID.SelectedIndex = 0;
        }

        private void cbModelID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cbModelID.SelectedItem;
            var model = modelRepository.GetModelByID(id);
            txtModelName.Text = model.ModelName;
            txtBrand.Text = model.ModelBrand;
            txtOrigin.Text = model.ModelOrigin;
            txtYearOfWarranty.Text = model.ModelYearOfWarranty.ToString();
        }
        public void loadPhone()
        {
            if (isAdd)
            {
                txtPhoneID.Text = "";
            }
            else
            {
                txtPhoneID.Text = Phone.PhoneId.ToString();
                cbModelID.SelectedItem = Phone.ModelId;
                txtPrice.Text = Phone.ShowPrice.ToString();
                txtType.Text = Phone.Type;
            }
        }

        private void txtPhoneName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
