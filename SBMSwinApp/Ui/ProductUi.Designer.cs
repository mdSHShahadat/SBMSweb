namespace SBMS.Ui
{
    partial class ProductUi
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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(638, 16);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 30);
            this.SearchButton.TabIndex = 47;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(386, 20);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(246, 22);
            this.searchTextBox.TabIndex = 46;
            this.searchTextBox.Text = "Search By Code, Name, Category";
            // 
            // ExitLinkLabel
            // 
            this.ExitLinkLabel.AutoSize = true;
            this.ExitLinkLabel.Location = new System.Drawing.Point(307, 23);
            this.ExitLinkLabel.Name = "ExitLinkLabel";
            this.ExitLinkLabel.Size = new System.Drawing.Size(30, 17);
            this.ExitLinkLabel.TabIndex = 42;
            this.ExitLinkLabel.TabStop = true;
            this.ExitLinkLabel.Text = "Exit";
            this.ExitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExitLinkLabel_LinkClicked);
            // 
            // NextLinkLabel
            // 
            this.NextLinkLabel.AutoSize = true;
            this.NextLinkLabel.Location = new System.Drawing.Point(243, 23);
            this.NextLinkLabel.Name = "NextLinkLabel";
            this.NextLinkLabel.Size = new System.Drawing.Size(36, 17);
            this.NextLinkLabel.TabIndex = 43;
            this.NextLinkLabel.TabStop = true;
            this.NextLinkLabel.Text = "Next";
            this.NextLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextLinkLabel_LinkClicked);
            // 
            // PreviousLinkLabel
            // 
            this.PreviousLinkLabel.AutoSize = true;
            this.PreviousLinkLabel.Location = new System.Drawing.Point(165, 23);
            this.PreviousLinkLabel.Name = "PreviousLinkLabel";
            this.PreviousLinkLabel.Size = new System.Drawing.Size(63, 17);
            this.PreviousLinkLabel.TabIndex = 44;
            this.PreviousLinkLabel.TabStop = true;
            this.PreviousLinkLabel.Text = "Previous";
            this.PreviousLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PreviousLinkLabel_LinkClicked);
            // 
            // HomeLinkLabel
            // 
            this.HomeLinkLabel.AutoSize = true;
            this.HomeLinkLabel.Location = new System.Drawing.Point(87, 23);
            this.HomeLinkLabel.Name = "HomeLinkLabel";
            this.HomeLinkLabel.Size = new System.Drawing.Size(45, 17);
            this.HomeLinkLabel.TabIndex = 45;
            this.HomeLinkLabel.TabStop = true;
            this.HomeLinkLabel.Text = "Home";
            this.HomeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HomeLinkLabel_LinkClicked);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DisplayMember = "Id";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(310, 79);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(292, 24);
            this.categoryComboBox.TabIndex = 41;
            this.categoryComboBox.ValueMember = "Id";
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Id,
            this.Code,
            this.Name,
            this.CategoryName,
            this.ReorderLevel,
            this.Description,
            this.CategoryID,
            this.Action});
            this.displayDataGridView.Location = new System.Drawing.Point(88, 348);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.RowTemplate.Height = 24;
            this.displayDataGridView.Size = new System.Drawing.Size(623, 177);
            this.displayDataGridView.TabIndex = 40;
            this.displayDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayDataGridView_CellClick);
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.Code.FillWeight = 82.08122F;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.FillWeight = 82.08122F;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReorderLevel.FillWeight = 82.08122F;
            this.ReorderLevel.HeaderText = "Reorder Level";
            this.ReorderLevel.Name = "ReorderLevel";
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.FillWeight = 82.08122F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // CategoryID
            // 
            this.CategoryID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryID.FillWeight = 82.08122F;
            this.CategoryID.HeaderText = "Category";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Visible = false;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Action.FillWeight = 75F;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Text = "Edit";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(527, 311);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 31);
            this.SaveButton.TabIndex = 39;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(310, 202);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(292, 102);
            this.descriptionTextBox.TabIndex = 38;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(310, 172);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(292, 22);
            this.reorderLevelTextBox.TabIndex = 37;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(310, 111);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(292, 22);
            this.codeTextBox.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(310, 141);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(292, 22);
            this.nameTextBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Reorder Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name";
            // 
            // ProductUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ExitLinkLabel);
            this.Controls.Add(this.NextLinkLabel);
            this.Controls.Add(this.PreviousLinkLabel);
            this.Controls.Add(this.HomeLinkLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            //this.Name = "ProductUi";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductUi_Load);
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
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}