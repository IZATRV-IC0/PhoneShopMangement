namespace WF_PhoneManagement
{
    partial class frmSale
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvSaleList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtSearch = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 418);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(416, 31);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvSaleList
            // 
            this.dgvSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleList.Location = new System.Drawing.Point(53, 73);
            this.dgvSaleList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSaleList.Name = "dgvSaleList";
            this.dgvSaleList.RowHeadersWidth = 51;
            this.dgvSaleList.RowTemplate.Height = 25;
            this.dgvSaleList.Size = new System.Drawing.Size(752, 317);
            this.dgvSaleList.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(515, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 31);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtSearch
            // 
            this.dtSearch.Location = new System.Drawing.Point(235, 28);
            this.dtSearch.Name = "dtSearch";
            this.dtSearch.Size = new System.Drawing.Size(250, 27);
            this.dtSearch.TabIndex = 22;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(635, 24);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 31);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 478);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvSaleList);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmSale";
            this.Text = "frmSale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExit;
        private DataGridView dgvSaleList;
        private Button btnSearch;
        private DateTimePicker dtSearch;
        private Button btnReset;
    }
}