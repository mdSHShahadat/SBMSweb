namespace SBMS.Ui
{
    partial class PurchaseReportUi
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
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchButton = new System.Windows.Forms.Button();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.NextLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PreviousLinkLabel = new System.Windows.Forms.LinkLabel();
            this.HomeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(470, 35);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(110, 22);
            this.endDateTimePicker.TabIndex = 108;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(273, 35);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(110, 22);
            this.startDateTimePicker.TabIndex = 109;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(620, 33);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 30);
            this.SearchButton.TabIndex = 107;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Id,
            this.Code,
            this.Name,
            this.Category,
            this.AvailableQuantity,
            this.CostPrice,
            this.MRP,
            this.SalesProfit});
            this.displayDataGridView.Location = new System.Drawing.Point(21, 75);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.RowTemplate.Height = 24;
            this.displayDataGridView.Size = new System.Drawing.Size(674, 335);
            this.displayDataGridView.TabIndex = 106;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.FillWeight = 40F;
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AvailableQuantity.HeaderText = "Available Qty";
            this.AvailableQuantity.Name = "AvailableQuantity";
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CostPrice.HeaderText = "CP (TK)";
            this.CostPrice.Name = "CostPrice";
            // 
            // MRP
            // 
            this.MRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MRP.HeaderText = "MRP (TK)";
            this.MRP.Name = "MRP";
            // 
            // SalesProfit
            // 
            this.SalesProfit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesProfit.HeaderText = "Profit (TK)";
            this.SalesProfit.Name = "SalesProfit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 104;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Start Date";
            // 
            // ExitLinkLabel
            // 
            this.ExitLinkLabel.AutoSize = true;
            this.ExitLinkLabel.Location = new System.Drawing.Point(441, 7);
            this.ExitLinkLabel.Name = "ExitLinkLabel";
            this.ExitLinkLabel.Size = new System.Drawing.Size(30, 17);
            this.ExitLinkLabel.TabIndex = 100;
            this.ExitLinkLabel.TabStop = true;
            this.ExitLinkLabel.Text = "Exit";
            this.ExitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExitLinkLabel_LinkClicked);
            // 
            // NextLinkLabel
            // 
            this.NextLinkLabel.AutoSize = true;
            this.NextLinkLabel.Location = new System.Drawing.Point(377, 7);
            this.NextLinkLabel.Name = "NextLinkLabel";
            this.NextLinkLabel.Size = new System.Drawing.Size(36, 17);
            this.NextLinkLabel.TabIndex = 101;
            this.NextLinkLabel.TabStop = true;
            this.NextLinkLabel.Text = "Next";
            this.NextLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextLinkLabel_LinkClicked);
            // 
            // PreviousLinkLabel
            // 
            this.PreviousLinkLabel.AutoSize = true;
            this.PreviousLinkLabel.Location = new System.Drawing.Point(299, 7);
            this.PreviousLinkLabel.Name = "PreviousLinkLabel";
            this.PreviousLinkLabel.Size = new System.Drawing.Size(63, 17);
            this.PreviousLinkLabel.TabIndex = 102;
            this.PreviousLinkLabel.TabStop = true;
            this.PreviousLinkLabel.Text = "Previous";
            this.PreviousLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PreviousLinkLabel_LinkClicked);
            // 
            // HomeLinkLabel
            // 
            this.HomeLinkLabel.AutoSize = true;
            this.HomeLinkLabel.Location = new System.Drawing.Point(221, 7);
            this.HomeLinkLabel.Name = "HomeLinkLabel";
            this.HomeLinkLabel.Size = new System.Drawing.Size(45, 17);
            this.HomeLinkLabel.TabIndex = 103;
            this.HomeLinkLabel.TabStop = true;
            this.HomeLinkLabel.Text = "Home";
            this.HomeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HomeLinkLabel_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.displayDataGridView);
            this.groupBox1.Controls.Add(this.endDateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.startDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 430);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodic income Expense Report on Purchase";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 45);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 17);
            this.linkLabel1.TabIndex = 110;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show All";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // PurchaseReportUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitLinkLabel);
            this.Controls.Add(this.NextLinkLabel);
            this.Controls.Add(this.PreviousLinkLabel);
            this.Controls.Add(this.HomeLinkLabel);
            //this.Name = "PurchaseReportUi";
            this.Text = "Periodic Income Expence Report on Purchase";
            this.Load += new System.EventHandler(this.PurchaseReportUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ExitLinkLabel;
        private System.Windows.Forms.LinkLabel NextLinkLabel;
        private System.Windows.Forms.LinkLabel PreviousLinkLabel;
        private System.Windows.Forms.LinkLabel HomeLinkLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesProfit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}