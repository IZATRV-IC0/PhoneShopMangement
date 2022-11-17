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
            this.grPhone = new System.Windows.Forms.GroupBox();
            this.txtPhoneID = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btndeletePhone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneName = new System.Windows.Forms.TextBox();
            this.btnAddphone = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPhoneList = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grImport = new System.Windows.Forms.GroupBox();
            this.txtReceiptDate = new System.Windows.Forms.TextBox();
            this.txtReceiptID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grbRe_CInfo.SuspendLayout();
            this.grPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).BeginInit();
            this.grImport.SuspendLayout();
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
            this.grbRe_CInfo.Location = new System.Drawing.Point(352, 16);
            this.grbRe_CInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbRe_CInfo.Name = "grbRe_CInfo";
            this.grbRe_CInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbRe_CInfo.Size = new System.Drawing.Size(982, 200);
            this.grbRe_CInfo.TabIndex = 20;
            this.grbRe_CInfo.TabStop = false;
            this.grbRe_CInfo.Text = "Customer";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCustomerID.FormattingEnabled = true;
            this.txtCustomerID.Location = new System.Drawing.Point(106, 39);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(161, 28);
            this.txtCustomerID.TabIndex = 18;
            this.txtCustomerID.SelectedIndexChanged += new System.EventHandler(this.txtCustomerID_SelectedIndexChanged);
            // 
            // lblReCID
            // 
            this.lblReCID.AutoSize = true;
            this.lblReCID.Location = new System.Drawing.Point(33, 43);
            this.lblReCID.Name = "lblReCID";
            this.lblReCID.Size = new System.Drawing.Size(27, 20);
            this.lblReCID.TabIndex = 1;
            this.lblReCID.Text = "ID:";
            // 
            // btnRe_Customer
            // 
            this.btnRe_Customer.Enabled = false;
            this.btnRe_Customer.Location = new System.Drawing.Point(726, 37);
            this.btnRe_Customer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRe_Customer.Name = "btnRe_Customer";
            this.btnRe_Customer.Size = new System.Drawing.Size(161, 31);
            this.btnRe_Customer.TabIndex = 17;
            this.btnRe_Customer.Text = "Customer...";
            this.btnRe_Customer.UseVisualStyleBackColor = true;
            // 
            // lblReCPhone
            // 
            this.lblReCPhone.AutoSize = true;
            this.lblReCPhone.Location = new System.Drawing.Point(327, 43);
            this.lblReCPhone.Name = "lblReCPhone";
            this.lblReCPhone.Size = new System.Drawing.Size(53, 20);
            this.lblReCPhone.TabIndex = 1;
            this.lblReCPhone.Text = "Phone:";
            // 
            // txtCutomerName
            // 
            this.txtCutomerName.Enabled = false;
            this.txtCutomerName.Location = new System.Drawing.Point(106, 84);
            this.txtCutomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCutomerName.Name = "txtCutomerName";
            this.txtCutomerName.ReadOnly = true;
            this.txtCutomerName.Size = new System.Drawing.Size(561, 27);
            this.txtCutomerName.TabIndex = 0;
            // 
            // lblReCName
            // 
            this.lblReCName.AutoSize = true;
            this.lblReCName.Location = new System.Drawing.Point(33, 88);
            this.lblReCName.Name = "lblReCName";
            this.lblReCName.Size = new System.Drawing.Size(52, 20);
            this.lblReCName.TabIndex = 1;
            this.lblReCName.Text = "Name:";
            // 
            // lblReCAddress
            // 
            this.lblReCAddress.AutoSize = true;
            this.lblReCAddress.Location = new System.Drawing.Point(33, 135);
            this.lblReCAddress.Name = "lblReCAddress";
            this.lblReCAddress.Size = new System.Drawing.Size(65, 20);
            this.lblReCAddress.TabIndex = 1;
            this.lblReCAddress.Text = "Address:";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Enabled = false;
            this.txtCustomerAddress.Location = new System.Drawing.Point(106, 131);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(780, 27);
            this.txtCustomerAddress.TabIndex = 0;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Enabled = false;
            this.txtCustomerPhone.Location = new System.Drawing.Point(391, 39);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(276, 27);
            this.txtCustomerPhone.TabIndex = 0;
            // 
            // grPhone
            // 
            this.grPhone.Controls.Add(this.txtPhoneID);
            this.grPhone.Controls.Add(this.txtQuantity);
            this.grPhone.Controls.Add(this.label1);
            this.grPhone.Controls.Add(this.btndeletePhone);
            this.grPhone.Controls.Add(this.label3);
            this.grPhone.Controls.Add(this.label4);
            this.grPhone.Controls.Add(this.txtPhoneName);
            this.grPhone.Controls.Add(this.btnAddphone);
            this.grPhone.Controls.Add(this.txtPrice);
            this.grPhone.Controls.Add(this.label5);
            this.grPhone.Location = new System.Drawing.Point(37, 315);
            this.grPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grPhone.Name = "grPhone";
            this.grPhone.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grPhone.Size = new System.Drawing.Size(417, 509);
            this.grPhone.TabIndex = 21;
            this.grPhone.TabStop = false;
            this.grPhone.Text = "Product Detail";
            // 
            // txtPhoneID
            // 
            this.txtPhoneID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPhoneID.FormattingEnabled = true;
            this.txtPhoneID.Location = new System.Drawing.Point(104, 48);
            this.txtPhoneID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneID.Name = "txtPhoneID";
            this.txtPhoneID.Size = new System.Drawing.Size(138, 28);
            this.txtPhoneID.TabIndex = 23;
            this.txtPhoneID.SelectedIndexChanged += new System.EventHandler(this.txtPhoneID_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(105, 215);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(137, 27);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.ValueChanged += new System.EventHandler(this.txtQuantity_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // btndeletePhone
            // 
            this.btndeletePhone.Location = new System.Drawing.Point(26, 384);
            this.btndeletePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndeletePhone.Name = "btndeletePhone";
            this.btndeletePhone.Size = new System.Drawing.Size(194, 53);
            this.btndeletePhone.TabIndex = 10;
            this.btndeletePhone.Text = "Delete phone from list";
            this.btndeletePhone.UseVisualStyleBackColor = true;
            this.btndeletePhone.Click += new System.EventHandler(this.btndeletePhone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity:";
            // 
            // txtPhoneName
            // 
            this.txtPhoneName.Enabled = false;
            this.txtPhoneName.Location = new System.Drawing.Point(104, 99);
            this.txtPhoneName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneName.Name = "txtPhoneName";
            this.txtPhoneName.ReadOnly = true;
            this.txtPhoneName.Size = new System.Drawing.Size(266, 27);
            this.txtPhoneName.TabIndex = 0;
            // 
            // btnAddphone
            // 
            this.btnAddphone.Location = new System.Drawing.Point(26, 296);
            this.btnAddphone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddphone.Name = "btnAddphone";
            this.btnAddphone.Size = new System.Drawing.Size(194, 53);
            this.btnAddphone.TabIndex = 11;
            this.btnAddphone.Text = "Add phone to list";
            this.btnAddphone.UseVisualStyleBackColor = true;
            this.btnAddphone.Click += new System.EventHandler(this.btnAddphone_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(104, 155);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(138, 27);
            this.txtPrice.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price:";
            // 
            // dgvPhoneList
            // 
            this.dgvPhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneList.Location = new System.Drawing.Point(494, 315);
            this.dgvPhoneList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPhoneList.Name = "dgvPhoneList";
            this.dgvPhoneList.RowHeadersWidth = 51;
            this.dgvPhoneList.RowTemplate.Height = 25;
            this.dgvPhoneList.Size = new System.Drawing.Size(840, 509);
            this.dgvPhoneList.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(848, 925);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 40);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save Receipt";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(1071, 925);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grImport
            // 
            this.grImport.Controls.Add(this.txtReceiptDate);
            this.grImport.Controls.Add(this.txtReceiptID);
            this.grImport.Controls.Add(this.label6);
            this.grImport.Controls.Add(this.label2);
            this.grImport.Location = new System.Drawing.Point(24, 16);
            this.grImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grImport.Name = "grImport";
            this.grImport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grImport.Size = new System.Drawing.Size(301, 200);
            this.grImport.TabIndex = 28;
            this.grImport.TabStop = false;
            this.grImport.Text = "Receipt";
            this.grImport.Visible = false;
            // 
            // txtReceiptDate
            // 
            this.txtReceiptDate.Location = new System.Drawing.Point(114, 103);
            this.txtReceiptDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReceiptDate.Name = "txtReceiptDate";
            this.txtReceiptDate.ReadOnly = true;
            this.txtReceiptDate.Size = new System.Drawing.Size(161, 27);
            this.txtReceiptDate.TabIndex = 2;
            // 
            // txtReceiptID
            // 
            this.txtReceiptID.Location = new System.Drawing.Point(114, 45);
            this.txtReceiptID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReceiptID.Name = "txtReceiptID";
            this.txtReceiptID.ReadOnly = true;
            this.txtReceiptID.Size = new System.Drawing.Size(161, 27);
            this.txtReceiptID.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Import Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Import ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1089, 863);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1165, 859);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(114, 27);
            this.txtTotal.TabIndex = 30;
            // 
            // frmReceiptDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 1011);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grImport);
            this.Controls.Add(this.dgvPhoneList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grPhone);
            this.Controls.Add(this.grbRe_CInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReceiptDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Detail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReceiptDetail_FormClosed);
            this.Load += new System.EventHandler(this.frmReceiptDetail_Load);
            this.grbRe_CInfo.ResumeLayout(false);
            this.grbRe_CInfo.PerformLayout();
            this.grPhone.ResumeLayout(false);
            this.grPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).EndInit();
            this.grImport.ResumeLayout(false);
            this.grImport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private GroupBox grPhone;
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
        private GroupBox grImport;
        private TextBox txtReceiptDate;
        private TextBox txtReceiptID;
        private Label label6;
        private Label label2;
        private Label label7;
        private TextBox txtTotal;
    }
}