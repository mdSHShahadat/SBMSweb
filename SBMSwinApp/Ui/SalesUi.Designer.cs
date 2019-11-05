namespace SBMS.Ui
{
    partial class SalesUi
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.availableTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.MRPTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.salesDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loyaltyPointTextBox = new System.Windows.Forms.TextBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ExitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.NextLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PreviousLinkLabel = new System.Windows.Forms.LinkLabel();
            this.HomeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.payableAmountTextBox = new System.Windows.Forms.TextBox();
            this.discountAmountTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.grandTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.customerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.productDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(407, 379);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 30);
            this.SubmitButton.TabIndex = 78;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.availableTextBox);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.totalPriceTextBox);
            this.groupBox1.Controls.Add(this.MRPTextBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.productComboBox);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(5, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 287);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(157, 82);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(229, 22);
            this.codeTextBox.TabIndex = 63;
            this.codeTextBox.Text = "<View>";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(45, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 17);
            this.label16.TabIndex = 49;
            this.label16.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Available Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 50;
            this.label13.Text = "Total Price (TK)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "MRP(TK)";
            // 
            // availableTextBox
            // 
            this.availableTextBox.Location = new System.Drawing.Point(210, 111);
            this.availableTextBox.Name = "availableTextBox";
            this.availableTextBox.Size = new System.Drawing.Size(176, 22);
            this.availableTextBox.TabIndex = 53;
            this.availableTextBox.Text = "<View>";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(210, 143);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(176, 22);
            this.quantityTextBox.TabIndex = 54;
            this.quantityTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QuantityTextBox_KeyUp);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(210, 206);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(176, 22);
            this.totalPriceTextBox.TabIndex = 54;
            this.totalPriceTextBox.Text = "<View>";
            // 
            // MRPTextBox
            // 
            this.MRPTextBox.Location = new System.Drawing.Point(210, 174);
            this.MRPTextBox.Name = "MRPTextBox";
            this.MRPTextBox.Size = new System.Drawing.Size(176, 22);
            this.MRPTextBox.TabIndex = 55;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DisplayMember = "Id";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(157, 20);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(229, 24);
            this.categoryComboBox.TabIndex = 59;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // productComboBox
            // 
            this.productComboBox.DisplayMember = "Id";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(157, 51);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(229, 24);
            this.productComboBox.TabIndex = 59;
            this.productComboBox.ValueMember = "Id";
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(311, 250);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 31);
            this.AddButton.TabIndex = 57;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.salesDate);
            this.customerGroupBox.Controls.Add(this.label6);
            this.customerGroupBox.Controls.Add(this.label7);
            this.customerGroupBox.Controls.Add(this.loyaltyPointTextBox);
            this.customerGroupBox.Controls.Add(this.customerComboBox);
            this.customerGroupBox.Controls.Add(this.label8);
            this.customerGroupBox.Location = new System.Drawing.Point(5, 53);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(402, 123);
            this.customerGroupBox.TabIndex = 76;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer";
            // 
            // salesDate
            // 
            this.salesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.salesDate.Location = new System.Drawing.Point(159, 52);
            this.salesDate.Name = "salesDate";
            this.salesDate.Size = new System.Drawing.Size(225, 22);
            this.salesDate.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Loyalty Point";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Date";
            // 
            // loyaltyPointTextBox
            // 
            this.loyaltyPointTextBox.Location = new System.Drawing.Point(159, 78);
            this.loyaltyPointTextBox.Name = "loyaltyPointTextBox";
            this.loyaltyPointTextBox.Size = new System.Drawing.Size(225, 22);
            this.loyaltyPointTextBox.TabIndex = 53;
            this.loyaltyPointTextBox.Text = "<View>";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DisplayMember = "Id";
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(159, 22);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(225, 24);
            this.customerComboBox.TabIndex = 59;
            this.customerComboBox.ValueMember = "Id";
            this.customerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Customer";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(630, 7);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 30);
            this.SearchButton.TabIndex = 75;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(378, 11);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(246, 22);
            this.searchTextBox.TabIndex = 74;
            this.searchTextBox.Text = "Search by Code, Date, Customer";
            // 
            // ExitLinkLabel
            // 
            this.ExitLinkLabel.AutoSize = true;
            this.ExitLinkLabel.Location = new System.Drawing.Point(299, 14);
            this.ExitLinkLabel.Name = "ExitLinkLabel";
            this.ExitLinkLabel.Size = new System.Drawing.Size(30, 17);
            this.ExitLinkLabel.TabIndex = 70;
            this.ExitLinkLabel.TabStop = true;
            this.ExitLinkLabel.Text = "Exit";
            this.ExitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExitLinkLabel_LinkClicked);
            // 
            // NextLinkLabel
            // 
            this.NextLinkLabel.AutoSize = true;
            this.NextLinkLabel.Location = new System.Drawing.Point(235, 14);
            this.NextLinkLabel.Name = "NextLinkLabel";
            this.NextLinkLabel.Size = new System.Drawing.Size(36, 17);
            this.NextLinkLabel.TabIndex = 71;
            this.NextLinkLabel.TabStop = true;
            this.NextLinkLabel.Text = "Next";
            this.NextLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextLinkLabel_LinkClicked);
            // 
            // PreviousLinkLabel
            // 
            this.PreviousLinkLabel.AutoSize = true;
            this.PreviousLinkLabel.Location = new System.Drawing.Point(157, 14);
            this.PreviousLinkLabel.Name = "PreviousLinkLabel";
            this.PreviousLinkLabel.Size = new System.Drawing.Size(63, 17);
            this.PreviousLinkLabel.TabIndex = 72;
            this.PreviousLinkLabel.TabStop = true;
            this.PreviousLinkLabel.Text = "Previous";
            this.PreviousLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PreviousLinkLabel_LinkClicked);
            // 
            // HomeLinkLabel
            // 
            this.HomeLinkLabel.AutoSize = true;
            this.HomeLinkLabel.Location = new System.Drawing.Point(79, 14);
            this.HomeLinkLabel.Name = "HomeLinkLabel";
            this.HomeLinkLabel.Size = new System.Drawing.Size(45, 17);
            this.HomeLinkLabel.TabIndex = 73;
            this.HomeLinkLabel.TabStop = true;
            this.HomeLinkLabel.Text = "Home";
            this.HomeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HomeLinkLabel_LinkClicked);
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Id,
            this.ProductName,
            this.Quantity,
            this.MRP,
            this.TotalMRP,
            this.Action});
            this.displayDataGridView.Location = new System.Drawing.Point(6, 27);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.RowTemplate.Height = 24;
            this.displayDataGridView.Size = new System.Drawing.Size(486, 204);
            this.displayDataGridView.TabIndex = 69;
            this.displayDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayDataGridView_CellContentDoubleClick);
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.FillWeight = 50F;
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.FillWeight = 82.08122F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.FillWeight = 82.08122F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // MRP
            // 
            this.MRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MRP.HeaderText = "MRP (TK)";
            this.MRP.Name = "MRP";
            // 
            // TotalMRP
            // 
            this.TotalMRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalMRP.FillWeight = 82.08122F;
            this.TotalMRP.HeaderText = "Total MRP (TK)";
            this.TotalMRP.Name = "TotalMRP";
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Action.FillWeight = 75F;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Text = "Delete";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // productDetailsGroupBox
            // 
            this.productDetailsGroupBox.Controls.Add(this.payableAmountTextBox);
            this.productDetailsGroupBox.Controls.Add(this.discountAmountTextBox);
            this.productDetailsGroupBox.Controls.Add(this.discountTextBox);
            this.productDetailsGroupBox.Controls.Add(this.grandTextBox);
            this.productDetailsGroupBox.Controls.Add(this.label10);
            this.productDetailsGroupBox.Controls.Add(this.label4);
            this.productDetailsGroupBox.Controls.Add(this.label3);
            this.productDetailsGroupBox.Controls.Add(this.label2);
            this.productDetailsGroupBox.Controls.Add(this.displayDataGridView);
            this.productDetailsGroupBox.Controls.Add(this.SubmitButton);
            this.productDetailsGroupBox.Location = new System.Drawing.Point(413, 53);
            this.productDetailsGroupBox.Name = "productDetailsGroupBox";
            this.productDetailsGroupBox.Size = new System.Drawing.Size(498, 416);
            this.productDetailsGroupBox.TabIndex = 79;
            this.productDetailsGroupBox.TabStop = false;
            this.productDetailsGroupBox.Text = "Product Details";
            // 
            // payableAmountTextBox
            // 
            this.payableAmountTextBox.Location = new System.Drawing.Point(268, 338);
            this.payableAmountTextBox.Name = "payableAmountTextBox";
            this.payableAmountTextBox.Size = new System.Drawing.Size(175, 22);
            this.payableAmountTextBox.TabIndex = 80;
            this.payableAmountTextBox.Text = "<View>";
            // 
            // discountAmountTextBox
            // 
            this.discountAmountTextBox.Location = new System.Drawing.Point(268, 311);
            this.discountAmountTextBox.Name = "discountAmountTextBox";
            this.discountAmountTextBox.Size = new System.Drawing.Size(175, 22);
            this.discountAmountTextBox.TabIndex = 80;
            this.discountAmountTextBox.Text = "<View>";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(268, 284);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(175, 22);
            this.discountTextBox.TabIndex = 80;
            this.discountTextBox.Text = "<View>";
            // 
            // grandTextBox
            // 
            this.grandTextBox.Location = new System.Drawing.Point(268, 258);
            this.grandTextBox.Name = "grandTextBox";
            this.grandTextBox.Size = new System.Drawing.Size(175, 22);
            this.grandTextBox.TabIndex = 80;
            this.grandTextBox.Text = "<View>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 17);
            this.label10.TabIndex = 79;
            this.label10.Text = "Payable Amount (Tk)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "Discount Amount (Tk)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Discount (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Grand Total (Tk)";
            // 
            // SalesUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 483);
            this.Controls.Add(this.productDetailsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerGroupBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ExitLinkLabel);
            this.Controls.Add(this.NextLinkLabel);
            this.Controls.Add(this.PreviousLinkLabel);
            this.Controls.Add(this.HomeLinkLabel);
            this.Name = "SalesUi";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesUi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            this.productDetailsGroupBox.ResumeLayout(false);
            this.productDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox availableTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox MRPTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.DateTimePicker salesDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox loyaltyPointTextBox;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.LinkLabel ExitLinkLabel;
        private System.Windows.Forms.LinkLabel NextLinkLabel;
        private System.Windows.Forms.LinkLabel PreviousLinkLabel;
        private System.Windows.Forms.LinkLabel HomeLinkLabel;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.GroupBox productDetailsGroupBox;
        private System.Windows.Forms.TextBox payableAmountTextBox;
        private System.Windows.Forms.TextBox discountAmountTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox grandTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMRP;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox codeTextBox;
    }
}