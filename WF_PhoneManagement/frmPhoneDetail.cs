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
    public partial class frmPhoneDetail : Form
    {
        public bool hasClosed;
        public string dataString = "";
        public frmPhoneDetail()
        {
            InitializeComponent();
        }
        public void ResetForm()
        {
            foreach (TextBox txt in this.Controls)
            {
                txt.Text = "";
            }
            txtPhoneID.Text = "0";
            txtModelID.Text = "0";
            dataString = "";
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            dataString = txtPhoneID.Text + ',' + txtModelID.Text + ',' + txtType.Text + ',' + txtPrice.Text;
            dataString = dataString.Trim();
        }
        public void setDefaultData(Phone p)
        {
            txtPhoneID.Text = "" + p.PhoneId;
            txtType.Text = p.Type;
            txtPrice.Text = "" + p.ShowPrice;
            txtModelID.Text = "" + p.ModelId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhoneDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }

        private void LoadMethod()
        {
            try
            {
                IPhoneRepository pRepos = new PhoneRepository();
                txtPhoneName.Text = pRepos.GetPhoneByID(Int32.Parse(txtPhoneID.Text)).GetPhoneName();
            } catch (Exception ex)
            {
                MessageBox.Show("Load method error: " + ex.Message + "\n" +
                                "This dialog will automatically close to prevent data corruption.", "LoadError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void frmPhoneDetail_Load(object sender, EventArgs e)
        {
            hasClosed = false;
            LoadMethod();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            frmView view = new frmView();
            view.index = 4;
            view.ViewSettings();
            view.ShowDialog();
        }

        private void txtModelID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtModelID.Text == "0")
                {
                    throw new Exception("0");
                }
                IModelRepository mRepos = new ModelRepository();
                if (mRepos.GetModelsList().Count() == 0)
                {
                    throw new Exception("Add model first.");
                }
                int idOfModel = Int32.Parse(txtModelID.Text);
                if (idOfModel < 0 || idOfModel >= mRepos.GetModelsList().Count())
                {
                    throw new Exception("ID input is out of bound.");
                } else
                {
                    Model curr = mRepos.GetModelByID(idOfModel);
                    this.txtModelName.Text = curr.ModelName;
                    this.txtOrigin.Text = curr.ModelOrigin;
                    this.txtBrand.Text = curr.ModelBrand;
                    this.txtYearOfWarranty.Text = curr.ModelYearOfWarranty + "";
                }
            }
            catch (Exception ex)
            {
                if (!ex.Message.Equals("0"))
                {
                    MessageBox.Show("Model info load error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModelID.Text = "0";
                }
            }
            LoadMethod();
        }
    }
}
