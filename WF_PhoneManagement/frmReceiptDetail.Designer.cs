namespace WF_PhoneManagement
{
    partial class frmReceiptDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbRe_CInfo = new System.Windows.Forms.GroupBox();
            this.txtCustomerID = new System.Windows.Forms.ComboBox();
            this.lblReCID = new System.Windows.Forms.Label();
            this.btnRe_Customer = new System.Windows.Forms.Button();
            this.lblReCPhone = new System.Windows.Forms.Label();
            this.txtCutomerName = new System.Windows.Forms.TextBox();
            this.lblReCName = new System.Windows.Forms.Label();
            this.lblReCAddress = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.grbRe_PDetail = new System.Windows.Forms.GroupBox();
            this.txtPhoneID = new System.Windows.Forms.ComboBox();
            this.dgvPhoneList = new System.Windows.Forms.DataGridView();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btndeletePhone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneName = new System.Windows.Forms.TextBox();
            this.btnAddphone = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbRe_CInfo.SuspendLayout();
            this.grbRe_PDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // grbRe_CInfo
            // 
            this.grbRe_CInfo.Controls.Add(this.txtCustomerID);
            this.grbRe_CInfo.Controls.Add(this.lblReCID);
            this.grbRe_CInfo.Controls.Add(this.btnRe_Customer);
            this.grbRe_CInfo.Controls.Add(this.lblReCPhone);
            this.grbRe_CInfo.Controls.Add(this.txtCutomerName);
            this.grbRe_CInfo.Controls.Add(this.lblReCName);
            this.grbRe_CInfo.Controls.Add(this.lblReCAddress);
            this.grbRe_CInfo.Controls.Add(this.txtCustomerAddress);
            this.grbRe_CInfo.Controls.Add(this.txtCustomerPhone);
            this.grbRe_CInfo.Location = new System.Drawing.Point(44, 12);
            this.grbRe_CInfo.Name = "grbRe_CInfo";
            this.grbRe_CInfo.Size = new System.Drawing.Size(993, 150);
            this.grbRe_CInfo.TabIndex = 20;
            this.grbRe_CInfo.TabStop = false;
            this.grbRe_CInfo.Text = "Customer";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCustomerID.FormattingEnabled = true;
            this.txtCustomerID.Location = new System.Drawing.Point(93, 29);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(141, 23);
            this.txtCustomerID.TabIndex = 18;
            this.txtCustomerID.SelectedIndexChanged += new System.EventHandler(this.txtCustomerID_SelectedIndexChanged);
            // 
            // lblReCID
            // 
            this.lblReCID.AutoSize = true;
            this.lblReCID.Location = new System.Drawing.Point(29, 32);
            this.lblReCID.Name = "lblReCID";
            this.lblReCID.Size = new System.Drawing.Size(21, 15);
            this.lblReCID.TabIndex = 1;
            this.lblReCID.Text = "ID:";
            // 
            // btnRe_Customer
            // 
            this.btnRe_Customer.Enabled = false;
            this.btnRe_Customer.Location = new System.Drawing.Point(635, 28);
            this.btnRe_Customer.Name = "btnRe_Customer";
            this.btnRe_Customer.Size = new System.Drawing.Size(141, 23);
            this.btnRe_Customer.TabIndex = 17;
            this.btnRe_Customer.Text = "Customer...";
            this.btnRe_Customer.UseVisualStyleBackColor = true;
            // 
            // lblReCPhone
            // 
            this.lblReCPhone.AutoSize = true;
            this.lblReCPhone.Location = new System.Drawing.Point(286, 32);
            this.lblReCPhone.Name = "lblReCPhone";
            this.lblReCPhone.Size = new System.Drawing.Size(44, 15);
            this.lblReCPhone.TabIndex = 1;
            this.lblReCPhone.Text = "Phone:";
            // 
            // txtCutomerName
            // 
            this.txtCutomerName.Enabled = false;
            this.txtCutomerName.Location = new System.Drawing.Point(93, 63);
            this.txtCutomerName.Name = "txtCutomerName";
            this.txtCutomerName.ReadOnly = true;
            this.txtCutomerName.Size = new System.Drawing.Size(491, 23);
            this.txtCutomerName.TabIndex = 0;
            // 
            // lblReCName
            // 
            this.lblReCName.AutoSize = true;
            this.lblReCName.Location = new System.Drawing.Point(29, 66);
            this.lblReCName.Name = "lblReCName";
            this.lblReCName.Size = new System.Drawing.Size(42, 15);
            this.lblReCName.TabIndex = 1;
            this.lblReCName.Text = "Name:";
            // 
            // lblReCAddress
            // 
            this.lblReCAddress.AutoSize = true;
            this.lblReCAddress.Location = new System.Drawing.Point(29, 101);
            this.lblReCAddress.Name = "lblReCAddress";
            this.lblReCAddress.Size = new System.Drawing.Size(52, 15);
            this.lblReCAddress.TabIndex = 1;
            this.lblReCAddress.Text = "Address:";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Enabled = false;
            this.txtCustomerAddress.Location = new System.Drawing.Point(93, 98);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(683, 23);
            this.txtCustomerAddress.TabIndex = 0;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Enabled = false;
            this.txtCustomerPhone.Location = new System.Drawing.Point(342, 29);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(242, 23);
            this.txtCustomerPhone.TabIndex = 0;
            // 
            // grbRe_PDetail
            // 
            this.grbRe_PDetail.Controls.Add(this.txtPhoneID);
            this.grbRe_PDetail.Controls.Add(this.dgvPhoneList);
            this.grbRe_PDetail.Controls.Add(this.txtQuantity);
            this.grbRe_PDetail.Controls.Add(this.label1);
            this.grbRe_PDetail.Controls.Add(this.btndeletePhone);
            this.grbRe_PDetail.Controls.Add(this.label3);
            this.grbRe_PDetail.Controls.Add(this.label4);
            this.grbRe_PDetail.Controls.Add(this.txtPhoneName);
            this.grbRe_PDetail.Controls.Add(this.btnAddphone);
            this.grbRe_PDetail.Controls.Add(this.txtPrice);
            this.grbRe_PDetail.Controls.Add(this.label5);
            this.grbRe_PDetail.Location = new System.Drawing.Point(44, 200);
            this.grbRe_PDetail.Name = "grbRe_PDetail";
            this.grbRe_PDetail.Size = new System.Drawing.Size(993, 382);
            this.grbRe_PDetail.TabIndex = 21;
            this.grbRe_PDetail.TabStop = false;
            this.grbRe_PDetail.Text = "Product Detail";
            // 
            // txtPhoneID
            // 
            this.txtPhoneID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPhoneID.FormattingEnabled = true;
            this.txtPhoneID.Location = new System.Drawing.Point(91, 36);
            this.txtPhoneID.Name = "txtPhoneID";
            this.txtPhoneID.Size = new System.Drawing.Size(121, 23);
            this.txtPhoneID.TabIndex = 23;
            this.txtPhoneID.SelectedIndexChanged += new System.EventHandler(this.txtPhoneID_SelectedIndexChanged);
            // 
            // dgvPhoneList
            // 
            this.dgvPhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneList.Location = new System.Drawing.Point(342, 36);
            this.dgvPhoneList.Name = "dgvPhoneList";
            this.dgvPhoneList.RowTemplate.Height = 25;
            this.dgvPhoneList.Size = new System.Drawing.Size(602, 318);
            this.dgvPhoneList.TabIndex = 22;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(92, 161);
            this.txtQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 23);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // btndeletePhone
            // 
            this.btndeletePhone.Location = new System.Drawing.Point(23, 288);
            this.btndeletePhone.Name = "btndeletePhone";
            this.btndeletePhone.Size = new System.Drawing.Size(170, 40);
            this.btndeletePhone.TabIndex = 10;
            this.btndeletePhone.Text = "Delete phone from list";
            this.btndeletePhone.UseVisualStyleBackColor = true;
            this.btndeletePhone.Click += new System.EventHandler(this.btndeletePhone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity:";
            // 
            // txtPhoneName
            // 
            this.txtPhoneName.Enabled = false;
            this.txtPhoneName.Location = new System.Drawing.Point(91, 74);
            this.txtPhoneName.Name = "txtPhoneName";
            this.txtPhoneName.ReadOnly = true;
            this.txtPhoneName.Size = new System.Drawing.Size(233, 23);
            this.txtPhoneName.TabIndex = 0;
            // 
            // btnAddphone
            // 
            this.btnAddphone.Location = new System.Drawing.Point(23, 222);
            this.btnAddphone.Name = "btnAddphone";
            this.btnAddphone.Size = new System.Drawing.Size(170, 40);
            this.btnAddphone.TabIndex = 11;
            this.btnAddphone.Text = "Add phone to list";
            this.btnAddphone.UseVisualStyleBackColor = true;
            this.btnAddphone.Click += new System.EventHandler(this.btnAddphone_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(91, 116);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(121, 23);
            this.txtPrice.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(742, 694);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 30);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save Receipt";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(937, 694);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmReceiptDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 758);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbRe_PDetail);
            this.Controls.Add(this.grbRe_CInfo);
            this.Name = "frmReceiptDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Detail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReceiptDetail_FormClosed);
            this.Load += new System.EventHandler(this.frmReceiptDetail_Load);
            this.grbRe_CInfo.ResumeLayout(false);
            this.grbRe_CInfo.PerformLayout();
            this.grbRe_PDetail.ResumeLayout(false);
            this.grbRe_PDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grbRe_CInfo;
        private Label lblReCID;
        private Button btnRe_Customer;
        private Label lblReCPhone;
        private TextBox txtCutomerName;
        private Label lblReCName;
        private Label lblReCAddress;
        private TextBox txtCustomerAddress;
        private TextBox txtCustomerPhone;
        private GroupBox grbRe_PDetail;
        private DataGridView dgvPhoneList;
        private NumericUpDown txtQuantity;
        private Label label1;
        private Button btndeletePhone;
        private Label label3;
        private Label label4;
        private TextBox txtPhoneName;
        private Button btnAddphone;
        private TextBox txtPrice;
        private Label label5;
        private ComboBox txtCustomerID;
        private ComboBox txtPhoneID;
        private Button btnSave;
        private Button button2;
    }
}