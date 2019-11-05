namespace SBMS.Ui
{
    partial class PurchaseUi
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ExitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.NextLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PreviousLinkLabel = new System.Windows.Forms.LinkLabel();
            this.HomeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.availableTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierGroupBox = new System.Windows.Forms.GroupBox();
            this.purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expiredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.manufactureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.displayStatusLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.previousUPTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.MRPTextBox = new System.Windows.Forms.TextBox();
            this.previousMRPTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.supplierGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(638, 9);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 30);
            this.SearchButton.TabIndex = 65;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(386, 13);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(246, 22);
            this.searchTextBox.TabIndex = 64;
            this.searchTextBox.Text = "Search by Product Code, Date";
            // 
            // ExitLinkLabel
            // 
            this.ExitLinkLabel.AutoSize = true;
            this.ExitLinkLabel.Location = new System.Drawing.Point(307, 16);
            this.ExitLinkLabel.Name = "ExitLinkLabel";
            this.ExitLinkLabel.Size = new System.Drawing.Size(30, 17);
            this.ExitLinkLabel.TabIndex = 60;
            this.ExitLinkLabel.TabStop = true;
            this.ExitLinkLabel.Text = "Exit";
            this.ExitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExitLinkLabel_LinkClicked);
            // 
            // NextLinkLabel
            // 
            this.NextLinkLabel.AutoSize = true;
            this.NextLinkLabel.Location = new System.Drawing.Point(243, 16);
            this.NextLinkLabel.Name = "NextLinkLabel";
            this.NextLinkLabel.Size = new System.Drawing.Size(36, 17);
            this.NextLinkLabel.TabIndex = 61;
            this.NextLinkLabel.TabStop = true;
            this.NextLinkLabel.Text = "Next";
            this.NextLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextLinkLabel_LinkClicked);
            // 
            // PreviousLinkLabel
            // 
            this.PreviousLinkLabel.AutoSize = true;
            this.PreviousLinkLabel.Location = new System.Drawing.Point(165, 16);
            this.PreviousLinkLabel.Name = "PreviousLinkLabel";
            this.PreviousLinkLabel.Size = new System.Drawing.Size(63, 17);
            this.PreviousLinkLabel.TabIndex = 62;
            this.PreviousLinkLabel.TabStop = true;
            this.PreviousLinkLabel.Text = "Previous";
            this.PreviousLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PreviousLinkLabel_LinkClicked);
            // 
            // HomeLinkLabel
            // 
            this.HomeLinkLabel.AutoSize = true;
            this.HomeLinkLabel.Location = new System.Drawing.Point(87, 16);
            this.HomeLinkLabel.Name = "HomeLinkLabel";
            this.HomeLinkLabel.Size = new System.Drawing.Size(45, 17);
            this.HomeLinkLabel.TabIndex = 63;
            this.HomeLinkLabel.TabStop = true;
            this.HomeLinkLabel.Text = "Home";
            this.HomeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HomeLinkLabel_LinkClicked);
            // 
            // productComboBox
            // 
            this.productComboBox.DisplayMember = "Id";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(146, 50);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(229, 24);
            this.productComboBox.TabIndex = 59;
            this.productComboBox.ValueMember = "Id";
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Id,
            this.ProductCode,
            this.ManufacturedDate,
            this.ExpireDate,
            this.Quantity,
            this.UnitPrice,
            this.TotalPrice,
            this.MRP,
            this.Remarks,
            this.Action});
            this.displayDataGridView.Location = new System.Drawing.Point(13, 500);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.RowTemplate.Height = 24;
            this.displayDataGridView.Size = new System.Drawing.Size(775, 177);
            this.displayDataGridView.TabIndex = 58;
            this.displayDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayDataGridView_CellClick);
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
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode.FillWeight = 82.08122F;
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            // 
            // ManufacturedDate
            // 
            this.ManufacturedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManufacturedDate.FillWeight = 82.08122F;
            this.ManufacturedDate.HeaderText = "Manufactured Date";
            this.ManufacturedDate.Name = "ManufacturedDate";
            // 
            // ExpireDate
            // 
            this.ExpireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpireDate.HeaderText = "Expire Date";
            this.ExpireDate.Name = "ExpireDate";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.FillWeight = 82.08122F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.FillWeight = 82.08122F;
            this.UnitPrice.HeaderText = "Unit Price (TK)";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.FillWeight = 82.08122F;
            this.TotalPrice.HeaderText = "Total Price (TK)";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // MRP
            // 
            this.MRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MRP.HeaderText = "MRP (TK)";
            this.MRP.Name = "MRP";
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
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
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(693, 293);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 31);
            this.AddButton.TabIndex = 57;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.Location = new System.Drawing.Point(146, 220);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(622, 66);
            this.remarkTextBox.TabIndex = 56;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(146, 80);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(229, 22);
            this.codeTextBox.TabIndex = 54;
            this.codeTextBox.Text = "<View>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Remarks";
            // 
            // availableTextBox
            // 
            this.availableTextBox.Location = new System.Drawing.Point(146, 136);
            this.availableTextBox.Name = "availableTextBox";
            this.availableTextBox.Size = new System.Drawing.Size(229, 22);
            this.availableTextBox.TabIndex = 53;
            this.availableTextBox.Text = "<View>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Manufactured Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Available Quantity";
            // 
            // supplierGroupBox
            // 
            this.supplierGroupBox.Controls.Add(this.purchaseDate);
            this.supplierGroupBox.Controls.Add(this.label6);
            this.supplierGroupBox.Controls.Add(this.label7);
            this.supplierGroupBox.Controls.Add(this.billTextBox);
            this.supplierGroupBox.Controls.Add(this.supplierComboBox);
            this.supplierGroupBox.Controls.Add(this.label8);
            this.supplierGroupBox.Location = new System.Drawing.Point(90, 55);
            this.supplierGroupBox.Name = "supplierGroupBox";
            this.supplierGroupBox.Size = new System.Drawing.Size(623, 100);
            this.supplierGroupBox.TabIndex = 66;
            this.supplierGroupBox.TabStop = false;
            this.supplierGroupBox.Text = "Supplier";
            // 
            // purchaseDate
            // 
            this.purchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.purchaseDate.Location = new System.Drawing.Point(256, 15);
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.Size = new System.Drawing.Size(291, 22);
            this.purchaseDate.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Bill / Invoice No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Date";
            // 
            // billTextBox
            // 
            this.billTextBox.Location = new System.Drawing.Point(256, 42);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(292, 22);
            this.billTextBox.TabIndex = 53;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DisplayMember = "Id";
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(256, 69);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(292, 24);
            this.supplierComboBox.TabIndex = 59;
            this.supplierComboBox.ValueMember = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Supplier";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.expiredDateTimePicker);
            this.groupBox1.Controls.Add(this.manufactureDateTimePicker);
            this.groupBox1.Controls.Add(this.displayStatusLabel);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.unitPriceTextBox);
            this.groupBox1.Controls.Add(this.previousUPTextBox);
            this.groupBox1.Controls.Add(this.availableTextBox);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.totalPriceTextBox);
            this.groupBox1.Controls.Add(this.reorderLevelTextBox);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.MRPTextBox);
            this.groupBox1.Controls.Add(this.previousMRPTextBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.productComboBox);
            this.groupBox1.Controls.Add(this.remarkTextBox);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 330);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // expiredDateTimePicker
            // 
            this.expiredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiredDateTimePicker.Location = new System.Drawing.Point(146, 189);
            this.expiredDateTimePicker.Name = "expiredDateTimePicker";
            this.expiredDateTimePicker.Size = new System.Drawing.Size(229, 22);
            this.expiredDateTimePicker.TabIndex = 63;
            // 
            // manufactureDateTimePicker
            // 
            this.manufactureDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.manufactureDateTimePicker.Location = new System.Drawing.Point(146, 161);
            this.manufactureDateTimePicker.Name = "manufactureDateTimePicker";
            this.manufactureDateTimePicker.Size = new System.Drawing.Size(229, 22);
            this.manufactureDateTimePicker.TabIndex = 63;
            // 
            // displayStatusLabel
            // 
            this.displayStatusLabel.AutoSize = true;
            this.displayStatusLabel.Location = new System.Drawing.Point(265, 312);
            this.displayStatusLabel.Name = "displayStatusLabel";
            this.displayStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.displayStatusLabel.TabIndex = 62;
            this.displayStatusLabel.Text = "Showing Records";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(427, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 17);
            this.label16.TabIndex = 49;
            this.label16.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Category";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(427, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "Unit Price (TK)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(427, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 17);
            this.label14.TabIndex = 48;
            this.label14.Text = "Previous Unit Price (TK)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(427, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 50;
            this.label13.Text = "Total Price (TK)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 17);
            this.label17.TabIndex = 50;
            this.label17.Text = "Reorder Level";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "MRP(TK)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Expire Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(427, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "Previous MRP (TK)";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(592, 49);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(176, 22);
            this.unitPriceTextBox.TabIndex = 53;
            this.unitPriceTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UnitPriceTextBox_KeyUp);
            // 
            // previousUPTextBox
            // 
            this.previousUPTextBox.Location = new System.Drawing.Point(592, 111);
            this.previousUPTextBox.Name = "previousUPTextBox";
            this.previousUPTextBox.Size = new System.Drawing.Size(176, 22);
            this.previousUPTextBox.TabIndex = 53;
            this.previousUPTextBox.Text = "<View>";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(592, 18);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(176, 22);
            this.quantityTextBox.TabIndex = 54;
            this.quantityTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QuantityTextBox_KeyUp);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(592, 80);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(176, 22);
            this.totalPriceTextBox.TabIndex = 54;
            this.totalPriceTextBox.Text = "<View>";
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(146, 108);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(229, 22);
            this.reorderLevelTextBox.TabIndex = 54;
            this.reorderLevelTextBox.Text = "<View>";
            // 
            // MRPTextBox
            // 
            this.MRPTextBox.Location = new System.Drawing.Point(592, 172);
            this.MRPTextBox.Name = "MRPTextBox";
            this.MRPTextBox.Size = new System.Drawing.Size(176, 22);
            this.MRPTextBox.TabIndex = 55;
            // 
            // previousMRPTextBox
            // 
            this.previousMRPTextBox.Location = new System.Drawing.Point(592, 142);
            this.previousMRPTextBox.Name = "previousMRPTextBox";
            this.previousMRPTextBox.Size = new System.Drawing.Size(176, 22);
            this.previousMRPTextBox.TabIndex = 55;
            this.previousMRPTextBox.Text = "<View>";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DisplayMember = "Id";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(146, 20);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(229, 24);
            this.categoryComboBox.TabIndex = 59;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(707, 686);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 27);
            this.SubmitButton.TabIndex = 68;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PurchaseUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 721);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.supplierGroupBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ExitLinkLabel);
            this.Controls.Add(this.NextLinkLabel);
            this.Controls.Add(this.PreviousLinkLabel);
            this.Controls.Add(this.HomeLinkLabel);
            this.Controls.Add(this.displayDataGridView);
            this.Name = "PurchaseUi";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PurchaseUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            this.supplierGroupBox.ResumeLayout(false);
            this.supplierGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.LinkLabel ExitLinkLabel;
        private System.Windows.Forms.LinkLabel NextLinkLabel;
        private System.Windows.Forms.LinkLabel PreviousLinkLabel;
        private System.Windows.Forms.LinkLabel HomeLinkLabel;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox availableTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox supplierGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox previousUPTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox MRPTextBox;
        private System.Windows.Forms.TextBox previousMRPTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DateTimePicker purchaseDate;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label displayStatusLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.DateTimePicker expiredDateTimePicker;
        private System.Windows.Forms.DateTimePicker manufactureDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}