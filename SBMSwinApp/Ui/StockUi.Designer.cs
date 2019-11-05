namespace SBMS.Ui
{
    partial class StockUi
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
            this.ExitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.NextLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PreviousLinkLabel = new System.Windows.Forms.LinkLabel();
            this.HomeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitLinkLabel
            // 
            this.ExitLinkLabel.AutoSize = true;
            this.ExitLinkLabel.Location = new System.Drawing.Point(442, 9);
            this.ExitLinkLabel.Name = "ExitLinkLabel";
            this.ExitLinkLabel.Size = new System.Drawing.Size(30, 17);
            this.ExitLinkLabel.TabIndex = 74;
            this.ExitLinkLabel.TabStop = true;
            this.ExitLinkLabel.Text = "Exit";
            this.ExitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExitLinkLabel_LinkClicked);
            // 
            // NextLinkLabel
            // 
            this.NextLinkLabel.AutoSize = true;
            this.NextLinkLabel.Location = new System.Drawing.Point(378, 9);
            this.NextLinkLabel.Name = "NextLinkLabel";
            this.NextLinkLabel.Size = new System.Drawing.Size(36, 17);
            this.NextLinkLabel.TabIndex = 75;
            this.NextLinkLabel.TabStop = true;
            this.NextLinkLabel.Text = "Next";
            this.NextLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextLinkLabel_LinkClicked);
            // 
            // PreviousLinkLabel
            // 
            this.PreviousLinkLabel.AutoSize = true;
            this.PreviousLinkLabel.Location = new System.Drawing.Point(300, 9);
            this.PreviousLinkLabel.Name = "PreviousLinkLabel";
            this.PreviousLinkLabel.Size = new System.Drawing.Size(63, 17);
            this.PreviousLinkLabel.TabIndex = 76;
            this.PreviousLinkLabel.TabStop = true;
            this.PreviousLinkLabel.Text = "Previous";
            this.PreviousLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PreviousLinkLabel_LinkClicked);
            // 
            // HomeLinkLabel
            // 
            this.HomeLinkLabel.AutoSize = true;
            this.HomeLinkLabel.Location = new System.Drawing.Point(222, 9);
            this.HomeLinkLabel.Name = "HomeLinkLabel";
            this.HomeLinkLabel.Size = new System.Drawing.Size(45, 17);
            this.HomeLinkLabel.TabIndex = 77;
            this.HomeLinkLabel.TabStop = true;
            this.HomeLinkLabel.Text = "Home";
            this.HomeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HomeLinkLabel_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 78;
            this.label9.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 79;
            this.label5.Text = "Product";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(132, 86);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(235, 22);
            this.categoryTextBox.TabIndex = 80;
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(132, 58);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(235, 22);
            this.productTextBox.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "End Date";
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
            this.ReorderLevel,
            this.OpeningBalance,
            this.In,
            this.Out,
            this.ClosingBalance});
            this.displayDataGridView.Location = new System.Drawing.Point(12, 160);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.RowTemplate.Height = 24;
            this.displayDataGridView.Size = new System.Drawing.Size(674, 283);
            this.displayDataGridView.TabIndex = 83;
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
            // ReorderLevel
            // 
            this.ReorderLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReorderLevel.HeaderText = "Reorder Level";
            this.ReorderLevel.Name = "ReorderLevel";
            // 
            // OpeningBalance
            // 
            this.OpeningBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OpeningBalance.HeaderText = "Opening Balance";
            this.OpeningBalance.Name = "OpeningBalance";
            // 
            // In
            // 
            this.In.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.In.HeaderText = "In";
            this.In.Name = "In";
            // 
            // Out
            // 
            this.Out.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Out.HeaderText = "Out";
            this.Out.Name = "Out";
            // 
            // ClosingBalance
            // 
            this.ClosingBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClosingBalance.HeaderText = "Closing Balance";
            this.ClosingBalance.Name = "ClosingBalance";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(611, 123);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 30);
            this.SearchButton.TabIndex = 84;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(502, 58);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(110, 22);
            this.startDateTimePicker.TabIndex = 85;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(502, 88);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(110, 22);
            this.endDateTimePicker.TabIndex = 85;
            // 
            // StockUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 455);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExitLinkLabel);
            this.Controls.Add(this.NextLinkLabel);
            this.Controls.Add(this.PreviousLinkLabel);
            this.Controls.Add(this.HomeLinkLabel);
            //this.Name = "StockUi";
            this.Text = "Periodical Stock Report";
            this.Load += new System.EventHandler(this.StockUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ExitLinkLabel;
        private System.Windows.Forms.LinkLabel NextLinkLabel;
        private System.Windows.Forms.LinkLabel PreviousLinkLabel;
        private System.Windows.Forms.LinkLabel HomeLinkLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpeningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosingBalance;
    }
}