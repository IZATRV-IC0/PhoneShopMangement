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
    public partial class frmModelDetail : Form
    {
        IModelRepository modelRepository = new ModelRepository();
        public bool isAdd { get; set; }
        public Model Model { get; set; }
        public frmModelDetail()
        {
            InitializeComponent();
        }
        private void setup()
        {
            if(isAdd == false)
            {
                txtModelID.Text = Model.ModelId.ToString();
                txtModelName.Text = Model.ModelName.ToString();
                txtOrigin.Text = Model.ModelOrigin;
                txtYear.Text = Model.ModelYearOfWarranty.ToString();
                txtBrand.Text = Model.ModelBrand;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var model = new Model
            {
                ModelId = int.Parse(txtModelID.Text),
                ModelName = txtModelName.Text,
                ModelOrigin = txtOrigin.Text,
                ModelYearOfWarranty = int.Parse(txtYear.Text),
                ModelBrand = txtBrand.Text,
            };
            try
            {
                if (isAdd)
                {
                    modelRepository.AddNewModel(model);
                }
                else{
                    modelRepository.UpdateModel(model);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,isAdd? "Add new Model":"Update Model");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModelDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void frmModelDetail_Load(object sender, EventArgs e)
        {
            setup();
        }
    }
}
