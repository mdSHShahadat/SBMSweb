namespace SBMS.Ui
{
    partial class CategoryUi
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
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(640, 23);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 30);
            this.SearchButton.TabIndex = 35;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(388, 27);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(246, 22);
            this.searchTextBox.TabIndex = 34;
            this.searchTextBox.Text = "Search by Code, Name";
            // 
            // ExitLinkLabel
            // 
            this.ExitLinkLabel.AutoSize = true;
            this.ExitLinkLabel.Location = new System.Drawing.Point(309, 30);
            this.ExitLinkLabel.Name = "ExitLinkLabel";
            this.ExitLinkLabel.Size = new System.Drawing.Size(30, 17);
            this.ExitLinkLabel.TabIndex = 30;
            this.ExitLinkLabel.TabStop = true;
            this.ExitLinkLabel.Text = "Exit";
            this.ExitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExitLinkLabel_LinkClicked);
            // 
            // NextLinkLabel
            // 
            this.NextLinkLabel.AutoSize = true;
            this.NextLinkLabel.Location = new System.Drawing.Point(245, 30);
            this.NextLinkLabel.Name = "NextLinkLabel";
            this.NextLinkLabel.Size = new System.Drawing.Size(36, 17);
            this.NextLinkLabel.TabIndex = 31;
            this.NextLinkLabel.TabStop = true;
            this.NextLinkLabel.Text = "Next";
            this.NextLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextLinkLabel_LinkClicked);
            // 
            // PreviousLinkLabel
            // 
            this.PreviousLinkLabel.AutoSize = true;
            this.PreviousLinkLabel.Location = new System.Drawing.Point(167, 30);
            this.PreviousLinkLabel.Name = "PreviousLinkLabel";
            this.PreviousLinkLabel.Size = new System.Drawing.Size(63, 17);
            this.PreviousLinkLabel.TabIndex = 32;
            this.PreviousLinkLabel.TabStop = true;
            this.PreviousLinkLabel.Text = "Previous";
            this.PreviousLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PreviousLinkLabel_LinkClicked);
            // 
            // HomeLinkLabel
            // 
            this.HomeLinkLabel.AutoSize = true;
            this.HomeLinkLabel.Location = new System.Drawing.Point(89, 30);
            this.HomeLinkLabel.Name = "HomeLinkLabel";
            this.HomeLinkLabel.Size = new System.Drawing.Size(45, 17);
            this.HomeLinkLabel.TabIndex = 33;
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
            this.Code,
            this.Name,
            this.Action});
            this.displayDataGridView.Location = new System.Drawing.Point(86, 250);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.RowTemplate.Height = 24;
            this.displayDataGridView.Size = new System.Drawing.Size(623, 177);
            this.displayDataGridView.TabIndex = 29;
            this.displayDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayDataGridView_CellClick);
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.FillWeight = 76.14214F;
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
            this.Code.FillWeight = 111.9289F;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.FillWeight = 111.9289F;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Text = "Edit";
            this.Action.ToolTipText = "Edit";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(524, 203);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 31);
            this.SaveButton.TabIndex = 28;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(307, 164);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(292, 22);
            this.categoryNameTextBox.TabIndex = 27;
            // 
            // categoryCodeTextBox
            // 
            this.categoryCodeTextBox.Location = new System.Drawing.Point(307, 127);
            this.categoryCodeTextBox.Name = "categoryCodeTextBox";
            this.categoryCodeTextBox.Size = new System.Drawing.Size(292, 22);
            this.categoryCodeTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Code";
            // 
            // CategoryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ExitLinkLabel);
            this.Controls.Add(this.NextLinkLabel);
            this.Controls.Add(this.PreviousLinkLabel);
            this.Controls.Add(this.HomeLinkLabel);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.categoryCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            //this.Name = "CategoryUi";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.CategoryUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.TextBox categoryCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}