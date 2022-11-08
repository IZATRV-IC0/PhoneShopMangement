namespace WF_PhoneManagement
{
    partial class frmImportDetail
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.nud_PQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblRePID = new System.Windows.Forms.Label();
            this.lblRePTotal = new System.Windows.Forms.Label();
            this.cbb_PID = new System.Windows.Forms.ComboBox();
            this.lblRePName = new System.Windows.Forms.Label();
            this.lblRePQuantity = new System.Windows.Forms.Label();
            this.txt_PName = new System.Windows.Forms.TextBox();
            this.txt_PPrice = new System.Windows.Forms.TextBox();
            this.lblRePPrice = new System.Windows.Forms.Label();
            this.txt_PTotal = new System.Windows.Forms.TextBox();
            this.btnPhone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(189, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(108, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // nud_PQuantity
            // 
            this.nud_PQuantity.Enabled = false;
            this.nud_PQuantity.Location = new System.Drawing.Point(115, 154);
            this.nud_PQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_PQuantity.Name = "nud_PQuantity";
            this.nud_PQuantity.Size = new System.Drawing.Size(120, 23);
            this.nud_PQuantity.TabIndex = 23;
            this.nud_PQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRePID
            // 
            this.lblRePID.AutoSize = true;
            this.lblRePID.Enabled = false;
            this.lblRePID.Location = new System.Drawing.Point(46, 29);
            this.lblRePID.Name = "lblRePID";
            this.lblRePID.Size = new System.Drawing.Size(21, 15);
            this.lblRePID.TabIndex = 18;
            this.lblRePID.Text = "ID:";
            // 
            // lblRePTotal
            // 
            this.lblRePTotal.AutoSize = true;
            this.lblRePTotal.Enabled = false;
            this.lblRePTotal.Location = new System.Drawing.Point(46, 202);
            this.lblRePTotal.Name = "lblRePTotal";
            this.lblRePTotal.Size = new System.Drawing.Size(35, 15);
            this.lblRePTotal.TabIndex = 19;
            this.lblRePTotal.Text = "Total:";
            // 
            // cbb_PID
            // 
            this.cbb_PID.Enabled = false;
            this.cbb_PID.FormattingEnabled = true;
            this.cbb_PID.Location = new System.Drawing.Point(114, 26);
            this.cbb_PID.Name = "cbb_PID";
            this.cbb_PID.Size = new System.Drawing.Size(121, 23);
            this.cbb_PID.TabIndex = 17;
            // 
            // lblRePName
            // 
            this.lblRePName.AutoSize = true;
            this.lblRePName.Enabled = false;
            this.lblRePName.Location = new System.Drawing.Point(46, 70);
            this.lblRePName.Name = "lblRePName";
            this.lblRePName.Size = new System.Drawing.Size(42, 15);
            this.lblRePName.TabIndex = 20;
            this.lblRePName.Text = "Name:";
            // 
            // lblRePQuantity
            // 
            this.lblRePQuantity.AutoSize = true;
            this.lblRePQuantity.Enabled = false;
            this.lblRePQuantity.Location = new System.Drawing.Point(46, 156);
            this.lblRePQuantity.Name = "lblRePQuantity";
            this.lblRePQuantity.Size = new System.Drawing.Size(56, 15);
            this.lblRePQuantity.TabIndex = 21;
            this.lblRePQuantity.Text = "Quantity:";
            // 
            // txt_PName
            // 
            this.txt_PName.Enabled = false;
            this.txt_PName.Location = new System.Drawing.Point(114, 67);
            this.txt_PName.Name = "txt_PName";
            this.txt_PName.ReadOnly = true;
            this.txt_PName.Size = new System.Drawing.Size(233, 23);
            this.txt_PName.TabIndex = 14;
            // 
            // txt_PPrice
            // 
            this.txt_PPrice.Enabled = false;
            this.txt_PPrice.Location = new System.Drawing.Point(114, 109);
            this.txt_PPrice.Name = "txt_PPrice";
            this.txt_PPrice.ReadOnly = true;
            this.txt_PPrice.Size = new System.Drawing.Size(121, 23);
            this.txt_PPrice.TabIndex = 15;
            // 
            // lblRePPrice
            // 
            this.lblRePPrice.AutoSize = true;
            this.lblRePPrice.Enabled = false;
            this.lblRePPrice.Location = new System.Drawing.Point(46, 112);
            this.lblRePPrice.Name = "lblRePPrice";
            this.lblRePPrice.Size = new System.Drawing.Size(36, 15);
            this.lblRePPrice.TabIndex = 22;
            this.lblRePPrice.Text = "Price:";
            // 
            // txt_PTotal
            // 
            this.txt_PTotal.Enabled = false;
            this.txt_PTotal.Location = new System.Drawing.Point(114, 199);
            this.txt_PTotal.Name = "txt_PTotal";
            this.txt_PTotal.ReadOnly = true;
            this.txt_PTotal.Size = new System.Drawing.Size(121, 23);
            this.txt_PTotal.TabIndex = 16;
            // 
            // btnPhone
            // 
            this.btnPhone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPhone.Location = new System.Drawing.Point(256, 25);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(91, 23);
            this.btnPhone.TabIndex = 13;
            this.btnPhone.Text = "Phone...";
            this.btnPhone.UseVisualStyleBackColor = true;
            // 
            // frmImportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 289);
            this.Controls.Add(this.nud_PQuantity);
            this.Controls.Add(this.lblRePID);
            this.Controls.Add(this.lblRePTotal);
            this.Controls.Add(this.cbb_PID);
            this.Controls.Add(this.lblRePName);
            this.Controls.Add(this.lblRePQuantity);
            this.Controls.Add(this.txt_PName);
            this.Controls.Add(this.txt_PPrice);
            this.Controls.Add(this.lblRePPrice);
            this.Controls.Add(this.txt_PTotal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnOK);
            this.Name = "frmImportDetail";
            this.Text = "Import Detail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmImportDetail_FormClosed);
            this.Load += new System.EventHandler(this.frmImportDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_PQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private NumericUpDown nud_PQuantity;
        private Label lblRePID;
        private Label lblRePTotal;
        private ComboBox cbb_PID;
        private Label lblRePName;
        private Label lblRePQuantity;
        private TextBox txt_PName;
        private TextBox txt_PPrice;
        private Label lblRePPrice;
        private TextBox txt_PTotal;
        private Button btnPhone;
    }
}