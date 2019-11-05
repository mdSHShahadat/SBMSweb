namespace SBMS.User_Control
{
    partial class PurchaseRecordosUserControlUi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displayPurchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.displayPurchaseDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TtlPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayPurchaseDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayPurchaseDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.displayPurchaseDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(3, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Purchases";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // displayPurchaseDataGridView
            // 
            this.displayPurchaseDataGridView.AllowUserToAddRows = false;
            this.displayPurchaseDataGridView.AllowUserToDeleteRows = false;
            this.displayPurchaseDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayPurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayPurchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.PurchaseId,
            this.PurchaseCode,
            this.PurchaseDate,
            this.InvoiceNumber,
            this.SupplierName,
            this.TotalPrice,
            this.Action});
            this.displayPurchaseDataGridView.Location = new System.Drawing.Point(7, 22);
            this.displayPurchaseDataGridView.Name = "displayPurchaseDataGridView";
            this.displayPurchaseDataGridView.ReadOnly = true;
            this.displayPurchaseDataGridView.RowTemplate.Height = 24;
            this.displayPurchaseDataGridView.Size = new System.Drawing.Size(941, 182);
            this.displayPurchaseDataGridView.TabIndex = 0;
            this.displayPurchaseDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayPurchaseDataGridView_CellContentDoubleClick);
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.FillWeight = 25F;
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // PurchaseId
            // 
            this.PurchaseId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchaseId.HeaderText = "PurchaseId";
            this.PurchaseId.Name = "PurchaseId";
            this.PurchaseId.ReadOnly = true;
            this.PurchaseId.Visible = false;
            // 
            // PurchaseCode
            // 
            this.PurchaseCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchaseCode.FillWeight = 87.05584F;
            this.PurchaseCode.HeaderText = "Purchase Code";
            this.PurchaseCode.Name = "PurchaseCode";
            this.PurchaseCode.ReadOnly = true;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchaseDate.FillWeight = 87.05584F;
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceNumber.FillWeight = 87.05584F;
            this.InvoiceNumber.HeaderText = "Invoice No.";
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierName.FillWeight = 87.05584F;
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.FillWeight = 87.05584F;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Action.FillWeight = 87.05584F;
            this.Action.HeaderText = "View Details";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "View Details";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.displayPurchaseDetailsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(3, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 293);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase Details";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // displayPurchaseDetailsDataGridView
            // 
            this.displayPurchaseDetailsDataGridView.AllowUserToAddRows = false;
            this.displayPurchaseDetailsDataGridView.AllowUserToDeleteRows = false;
            this.displayPurchaseDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayPurchaseDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayPurchaseDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ProductName,
            this.ManufacturedDate,
            this.ExpireDate,
            this.Quantity,
            this.UnitPrice,
            this.TtlPrice,
            this.MRP,
            this.Remarks});
            this.displayPurchaseDetailsDataGridView.Location = new System.Drawing.Point(6, 21);
            this.displayPurchaseDetailsDataGridView.Name = "displayPurchaseDetailsDataGridView";
            this.displayPurchaseDetailsDataGridView.ReadOnly = true;
            this.displayPurchaseDetailsDataGridView.RowTemplate.Height = 24;
            this.displayPurchaseDetailsDataGridView.Size = new System.Drawing.Size(941, 266);
            this.displayPurchaseDetailsDataGridView.TabIndex = 0;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.No.FillWeight = 25F;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ManufacturedDate
            // 
            this.ManufacturedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManufacturedDate.HeaderText = "Manufactured Date";
            this.ManufacturedDate.Name = "ManufacturedDate";
            this.ManufacturedDate.ReadOnly = true;
            // 
            // ExpireDate
            // 
            this.ExpireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpireDate.HeaderText = "ExpireDate";
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.HeaderText = "Unit Price (TK)";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // TtlPrice
            // 
            this.TtlPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TtlPrice.HeaderText = "Total Price (TK)";
            this.TtlPrice.Name = "TtlPrice";
            this.TtlPrice.ReadOnly = true;
            // 
            // MRP
            // 
            this.MRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MRP.HeaderText = "MRP (TK)";
            this.MRP.Name = "MRP";
            this.MRP.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightGreen;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(853, 8);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(103, 30);
            this.SearchButton.TabIndex = 77;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(336, 11);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(513, 22);
            this.searchTextBox.TabIndex = 76;
            this.searchTextBox.Text = "Search by Product Code, Date";
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.BackColor = System.Drawing.Color.LightGreen;
            this.ShowAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllButton.Location = new System.Drawing.Point(10, 7);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(103, 30);
            this.ShowAllButton.TabIndex = 77;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = false;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // PurchaseRecordosUserControlUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseRecordosUserControlUi";
            this.Size = new System.Drawing.Size(960, 562);
            this.Load += new System.EventHandler(this.PurchaseRecordosUserControlUi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayPurchaseDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayPurchaseDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView displayPurchaseDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView displayPurchaseDetailsDataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TtlPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}
