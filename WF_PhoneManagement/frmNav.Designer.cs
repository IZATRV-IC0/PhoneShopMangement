
namespace WF_PhoneManagement
{
    partial class frmNav
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
            this.grbManage = new System.Windows.Forms.GroupBox();
            this.btnInStock = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRI = new System.Windows.Forms.Button();
            this.grbOther = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSupport = new System.Windows.Forms.Button();
            this.grbManage.SuspendLayout();
            this.grbOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbManage
            // 
            this.grbManage.Controls.Add(this.btnInStock);
            this.grbManage.Controls.Add(this.btnSales);
            this.grbManage.Controls.Add(this.btnView);
            this.grbManage.Controls.Add(this.btnRI);
            this.grbManage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbManage.Location = new System.Drawing.Point(30, 24);
            this.grbManage.Name = "grbManage";
            this.grbManage.Size = new System.Drawing.Size(438, 187);
            this.grbManage.TabIndex = 0;
            this.grbManage.TabStop = false;
            this.grbManage.Text = "Manage";
            // 
            // btnInStock
            // 
            this.btnInStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInStock.Location = new System.Drawing.Point(228, 50);
            this.btnInStock.Name = "btnInStock";
            this.btnInStock.Size = new System.Drawing.Size(142, 23);
            this.btnInStock.TabIndex = 0;
            this.btnInStock.Text = "In-stock";
            this.btnInStock.UseVisualStyleBackColor = true;
            this.btnInStock.Click += new System.EventHandler(this.btnInStock_Click);
            // 
            // btnSales
            // 
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSales.Location = new System.Drawing.Point(228, 116);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(142, 23);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(25, 116);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(142, 23);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View...";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRI
            // 
            this.btnRI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRI.Location = new System.Drawing.Point(25, 50);
            this.btnRI.Name = "btnRI";
            this.btnRI.Size = new System.Drawing.Size(142, 23);
            this.btnRI.TabIndex = 0;
            this.btnRI.Text = "New Receipt/Import";
            this.btnRI.UseVisualStyleBackColor = true;
            this.btnRI.Click += new System.EventHandler(this.btnRI_Click);
            // 
            // grbOther
            // 
            this.grbOther.Controls.Add(this.btnLogout);
            this.grbOther.Controls.Add(this.btnSupport);
            this.grbOther.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbOther.Location = new System.Drawing.Point(30, 241);
            this.grbOther.Name = "grbOther";
            this.grbOther.Size = new System.Drawing.Size(438, 130);
            this.grbOther.TabIndex = 0;
            this.grbOther.TabStop = false;
            this.grbOther.Text = "Other";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(228, 54);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSupport.Location = new System.Drawing.Point(25, 54);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(142, 23);
            this.btnSupport.TabIndex = 0;
            this.btnSupport.Text = "Help/Options";
            this.btnSupport.UseVisualStyleBackColor = true;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 406);
            this.Controls.Add(this.grbOther);
            this.Controls.Add(this.grbManage);
            this.Name = "frmMain";
            this.Text = "Navigation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.grbManage.ResumeLayout(false);
            this.grbOther.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grbOther;
        private GroupBox grbManage;
        private Button btnView;
        private Button btnRI;
        private Button btnInStock;
        private Button btnSupport;
        private Button btnSales;
        private Button btnLogout;
    }
}