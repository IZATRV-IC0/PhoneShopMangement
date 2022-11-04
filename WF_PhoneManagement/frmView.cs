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
    public partial class frmView : Form
    {
        public bool hasClosed;

        Object curr;

        List<Object> list;

        public List<String> control;

        public frmView()
        {
            InitializeComponent();
            hasClosed = false;
            curr = new Object();
        }

        public void ViewSettings()
        {
            btnPick.Hide();
        }

        public void PickSettings()
        {
            cbbListPick.Hide();
            btnAdd.Text = "New...";
        }

        public void SalesSettings()
        {
            cbbListPick.Hide();
            btnPick.Hide();
            btnAdd.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
        }

        public void InStockSettings()
        {
            cbbListPick.Hide();
            btnPick.Hide();
            btnAdd.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
        }

        void LoadMethod()
        {
            
        }
        static bool CloseHandling()
        {
            string message = "Return to main menu?";
            string caption = "Close";
            DialogResult result = MessageBox.Show(message, caption,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        private void rbtnSortDsc_CheckedChanged(object sender, EventArgs e)
        {
            rbtnSortAsc.Checked = !rbtnSortDsc.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseHandling())
            {
                e.Cancel = true;
            }
        }

        private void frmView_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasClosed = true;
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            LoadMethod();
            hasClosed = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            
        }
    }
}
