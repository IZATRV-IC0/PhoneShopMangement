namespace WF_PhoneManagement
{
    partial class frmView
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
            this.cbbListPick = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchInfo = new System.Windows.Forms.TextBox();
            this.cbbBox = new System.Windows.Forms.ComboBox();
            this.lblListPick = new System.Windows.Forms.Label();
            this.dgvShowList = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblField = new System.Windows.Forms.Label();
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnSortAsc = new System.Windows.Forms.RadioButton();
            this.rbtnSortDsc = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbListPick
            // 
            this.cbbListPick.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbListPick.FormattingEnabled = true;
            this.cbbListPick.Items.AddRange(new object[] {
            "Receipt",
            "Import",
            "Customer",
            "Supplier",
            "Model",
            "Phone"});
            this.cbbListPick.Location = new System.Drawing.Point(136, 64);
            this.cbbListPick.Name = "cbbListPick";
            this.cbbListPick.Size = new System.Drawing.Size(121, 23);
            this.cbbListPick.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(658, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchInfo
            // 
            this.txtSearchInfo.Location = new System.Drawing.Point(434, 99);
            this.txtSearchInfo.Name = "txtSearchInfo";
            this.txtSearchInfo.Size = new System.Drawing.Size(187, 23);
            this.txtSearchInfo.TabIndex = 2;
            // 
            // cbbBox
            // 
            this.cbbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbBox.FormattingEnabled = true;
            this.cbbBox.Location = new System.Drawing.Point(434, 18);
            this.cbbBox.Name = "cbbBox";
            this.cbbBox.Size = new System.Drawing.Size(121, 23);
            this.cbbBox.TabIndex = 3;
            // 
            // lblListPick
            // 
            this.lblListPick.AutoSize = true;
            this.lblListPick.Location = new System.Drawing.Point(75, 67);
            this.lblListPick.Name = "lblListPick";
            this.lblListPick.Size = new System.Drawing.Size(28, 15);
            this.lblListPick.TabIndex = 4;
            this.lblListPick.Text = "List:";
            // 
            // dgvShowList
            // 
            this.dgvShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowList.Location = new System.Drawing.Point(75, 147);
            this.dgvShowList.Name = "dgvShowList";
            this.dgvShowList.RowTemplate.Height = 25;
            this.dgvShowList.Size = new System.Drawing.Size(658, 238);
            this.dgvShowList.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(353, 430);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(497, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(658, 59);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(353, 22);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(58, 15);
            this.lblField.TabIndex = 11;
            this.lblField.Text = "Category:";
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.AutoSize = true;
            this.lblSearchInfo.Location = new System.Drawing.Point(353, 102);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(33, 15);
            this.lblSearchInfo.TabIndex = 11;
            this.lblSearchInfo.Text = "Find:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(638, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 430);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnSortAsc
            // 
            this.rbtnSortAsc.AutoSize = true;
            this.rbtnSortAsc.Checked = true;
            this.rbtnSortAsc.Location = new System.Drawing.Point(382, 61);
            this.rbtnSortAsc.Name = "rbtnSortAsc";
            this.rbtnSortAsc.Size = new System.Drawing.Size(81, 19);
            this.rbtnSortAsc.TabIndex = 13;
            this.rbtnSortAsc.TabStop = true;
            this.rbtnSortAsc.Text = "Ascending";
            this.rbtnSortAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnSortDsc
            // 
            this.rbtnSortDsc.AutoSize = true;
            this.rbtnSortDsc.Location = new System.Drawing.Point(516, 61);
            this.rbtnSortDsc.Name = "rbtnSortDsc";
            this.rbtnSortDsc.Size = new System.Drawing.Size(87, 19);
            this.rbtnSortDsc.TabIndex = 14;
            this.rbtnSortDsc.Text = "Descending";
            this.rbtnSortDsc.UseVisualStyleBackColor = true;
            this.rbtnSortDsc.CheckedChanged += new System.EventHandler(this.rbtnSortDsc_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(658, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(75, 430);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 8;
            this.btnPick.Text = "OK";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 513);
            this.Controls.Add(this.rbtnSortDsc);
            this.Controls.Add(this.rbtnSortAsc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSearchInfo);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvShowList);
            this.Controls.Add(this.lblListPick);
            this.Controls.Add(this.cbbBox);
            this.Controls.Add(this.txtSearchInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbbListPick);
            this.Name = "frmView";
            this.Text = "View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmView_FormClosed);
            this.Load += new System.EventHandler(this.frmView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbbListPick;
        private Button btnSearch;
        private TextBox txtSearchInfo;
        private ComboBox cbbBox;
        private Label lblListPick;
        private DataGridView dgvShowList;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSort;
        private Label lblField;
        private Label lblSearchInfo;
        private Button btnExit;
        private Button btnAdd;
        private RadioButton rbtnSortAsc;
        private RadioButton rbtnSortDsc;
        private Button btnRefresh;
        private Button btnPick;
    }
}