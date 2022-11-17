namespace WF_PhoneManagement
{
    partial class frmPhoneDetail
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
            this.txtPhoneName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYearOfWarranty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnModel = new System.Windows.Forms.Button();
            this.cbModelID = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtPhoneID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPhoneName
            // 
            this.txtPhoneName.Enabled = false;
            this.txtPhoneName.Location = new System.Drawing.Point(138, 77);
            this.txtPhoneName.Name = "txtPhoneName";
            this.txtPhoneName.ReadOnly = true;
            this.txtPhoneName.Size = new System.Drawing.Size(183, 23);
            this.txtPhoneName.TabIndex = 0;
            this.txtPhoneName.TextChanged += new System.EventHandler(this.txtPhoneName_TextChanged);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(138, 156);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(183, 23);
            this.txtType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Type:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(305, 298);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Save";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(410, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Model ID:";
            // 
            // txtModelName
            // 
            this.txtModelName.Enabled = false;
            this.txtModelName.Location = new System.Drawing.Point(504, 77);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.ReadOnly = true;
            this.txtModelName.Size = new System.Drawing.Size(180, 23);
            this.txtModelName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Model Name:";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Enabled = false;
            this.txtOrigin.Location = new System.Drawing.Point(504, 117);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.ReadOnly = true;
            this.txtOrigin.Size = new System.Drawing.Size(180, 23);
            this.txtOrigin.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Origin:";
            // 
            // txtYearOfWarranty
            // 
            this.txtYearOfWarranty.Enabled = false;
            this.txtYearOfWarranty.Location = new System.Drawing.Point(504, 156);
            this.txtYearOfWarranty.Name = "txtYearOfWarranty";
            this.txtYearOfWarranty.ReadOnly = true;
            this.txtYearOfWarranty.Size = new System.Drawing.Size(180, 23);
            this.txtYearOfWarranty.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Year of Warranty:";
            // 
            // txtBrand
            // 
            this.txtBrand.Enabled = false;
            this.txtBrand.Location = new System.Drawing.Point(504, 198);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(180, 23);
            this.txtBrand.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Brand:";
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(504, 245);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(75, 23);
            this.btnModel.TabIndex = 2;
            this.btnModel.Text = "Model...";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // cbModelID
            // 
            this.cbModelID.AllowDrop = true;
            this.cbModelID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelID.FormattingEnabled = true;
            this.cbModelID.Location = new System.Drawing.Point(504, 38);
            this.cbModelID.Name = "cbModelID";
            this.cbModelID.Size = new System.Drawing.Size(180, 23);
            this.cbModelID.TabIndex = 4;
            this.cbModelID.SelectedIndexChanged += new System.EventHandler(this.cbModelID_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(138, 117);
            this.txtPrice.Mask = "00000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 23);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.ValidatingType = typeof(int);
            // 
            // txtPhoneID
            // 
            this.txtPhoneID.Location = new System.Drawing.Point(138, 41);
            this.txtPhoneID.Name = "txtPhoneID";
            this.txtPhoneID.ReadOnly = true;
            this.txtPhoneID.Size = new System.Drawing.Size(181, 23);
            this.txtPhoneID.TabIndex = 6;
            // 
            // frmPhoneDetail
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 348);
            this.Controls.Add(this.txtPhoneID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cbModelID);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtYearOfWarranty);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.txtPhoneName);
            this.Name = "frmPhoneDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Detail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPhoneDetail_FormClosed);
            this.Load += new System.EventHandler(this.frmPhoneDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtPhoneName;
        private TextBox txtType;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button btnOK;
        private Button btnCancel;
        private Label label6;
        private TextBox txtModelName;
        private Label label4;
        private TextBox txtOrigin;
        private Label label7;
        private TextBox txtYearOfWarranty;
        private Label label8;
        private TextBox txtBrand;
        private Label label9;
        private Button btnModel;
        private ComboBox cbModelID;
        private MaskedTextBox txtPrice;
        private TextBox txtPhoneID;
    }
}