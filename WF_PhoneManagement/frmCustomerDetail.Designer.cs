namespace WF_PhoneManagement
{
    partial class frmCustomerDetail
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rbtn_X = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 139);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(176, 23);
            this.txtAddress.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(135, 185);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(176, 23);
            this.txtPhone.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(49, 142);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 15);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(49, 188);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 15);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone:";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(84, 294);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(212, 294);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.Location = new System.Drawing.Point(135, 239);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(63, 19);
            this.rbtn_Female.TabIndex = 3;
            this.rbtn_Female.Text = "Female";
            this.rbtn_Female.UseVisualStyleBackColor = true;
            this.rbtn_Female.CheckedChanged += new System.EventHandler(this.rbtn_Female_CheckedChanged);
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.Checked = true;
            this.rbtn_Male.Location = new System.Drawing.Point(40, 239);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(51, 19);
            this.rbtn_Male.TabIndex = 3;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Male";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            this.rbtn_Male.CheckedChanged += new System.EventHandler(this.rbtn_Male_CheckedChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(49, 49);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(135, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 23);
            this.txtID.TabIndex = 0;
            // 
            // rbtn_X
            // 
            this.rbtn_X.AutoSize = true;
            this.rbtn_X.Location = new System.Drawing.Point(236, 239);
            this.rbtn_X.Name = "rbtn_X";
            this.rbtn_X.Size = new System.Drawing.Size(90, 19);
            this.rbtn_X.TabIndex = 3;
            this.rbtn_X.Text = "X (Enclosed)";
            this.rbtn_X.UseVisualStyleBackColor = true;
            this.rbtn_X.CheckedChanged += new System.EventHandler(this.rbtn_X_CheckedChanged);
            // 
            // frmCustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 362);
            this.Controls.Add(this.rbtn_Male);
            this.Controls.Add(this.rbtn_X);
            this.Controls.Add(this.rbtn_Female);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Name = "frmCustomerDetail";
            this.Text = "Customer Detail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomerDetail_FormClosed);
            this.Load += new System.EventHandler(this.frmCustomerDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Label lblName;
        private Label lblAddress;
        private Label lblPhone;
        private Button btn_OK;
        private Button btn_Cancel;
        private RadioButton rbtn_Female;
        private RadioButton rbtn_Male;
        private Label lblID;
        private TextBox txtID;
        private RadioButton rbtn_X;
    }
}