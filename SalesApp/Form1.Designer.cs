namespace SalesApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.peopleComboBox = new System.Windows.Forms.ComboBox();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.salesRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refreshSalesButton = new System.Windows.Forms.Button();
            this.SalesDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesTargetButton = new System.Windows.Forms.Button();
            this.NewAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NewDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NewPersonComboBox = new System.Windows.Forms.ComboBox();
            this.NewRegionComboBox = new System.Windows.Forms.ComboBox();
            this.NewSalesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleComboBox
            // 
            this.peopleComboBox.DataSource = this.salesPersonBindingSource;
            this.peopleComboBox.DisplayMember = "FullName";
            this.peopleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.peopleComboBox.FormattingEnabled = true;
            this.peopleComboBox.Location = new System.Drawing.Point(270, 45);
            this.peopleComboBox.Name = "peopleComboBox";
            this.peopleComboBox.Size = new System.Drawing.Size(121, 21);
            this.peopleComboBox.TabIndex = 0;
            this.peopleComboBox.ValueMember = "Id";
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataSource = typeof(SalesApp.Models.SalesPerson);
            // 
            // regionComboBox
            // 
            this.regionComboBox.DataSource = this.salesRegionBindingSource;
            this.regionComboBox.DisplayMember = "Name";
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(397, 45);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(121, 21);
            this.regionComboBox.TabIndex = 1;
            this.regionComboBox.ValueMember = "Id";
            // 
            // salesRegionBindingSource
            // 
            this.salesRegionBindingSource.DataSource = typeof(SalesApp.Models.SalesRegion);
            // 
            // refreshSalesButton
            // 
            this.refreshSalesButton.Location = new System.Drawing.Point(612, 43);
            this.refreshSalesButton.Name = "refreshSalesButton";
            this.refreshSalesButton.Size = new System.Drawing.Size(75, 23);
            this.refreshSalesButton.TabIndex = 2;
            this.refreshSalesButton.Text = "Refresh";
            this.refreshSalesButton.UseVisualStyleBackColor = true;
            this.refreshSalesButton.Click += new System.EventHandler(this.refreshSalesButton_Click);
            // 
            // SalesDataGridView
            // 
            this.SalesDataGridView.AllowUserToAddRows = false;
            this.SalesDataGridView.AutoGenerateColumns = false;
            this.SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.SalesDataGridView.DataSource = this.saleBindingSource;
            this.SalesDataGridView.Location = new System.Drawing.Point(12, 100);
            this.SalesDataGridView.Name = "SalesDataGridView";
            this.SalesDataGridView.Size = new System.Drawing.Size(776, 184);
            this.SalesDataGridView.TabIndex = 3;
            this.SalesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesDataGridView_CellEndEdit);
            this.SalesDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.SalesDataGridView_UserDeletingRow);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "Updated By";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            this.updatedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(SalesApp.Models.Sale);
            // 
            // SalesTargetButton
            // 
            this.SalesTargetButton.Location = new System.Drawing.Point(126, 43);
            this.SalesTargetButton.Name = "SalesTargetButton";
            this.SalesTargetButton.Size = new System.Drawing.Size(75, 23);
            this.SalesTargetButton.TabIndex = 4;
            this.SalesTargetButton.Text = "Target";
            this.SalesTargetButton.UseVisualStyleBackColor = true;
            this.SalesTargetButton.Click += new System.EventHandler(this.SalesTargetButton_Click);
            // 
            // NewAmountNumericUpDown
            // 
            this.NewAmountNumericUpDown.DecimalPlaces = 2;
            this.NewAmountNumericUpDown.Location = new System.Drawing.Point(126, 365);
            this.NewAmountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NewAmountNumericUpDown.Name = "NewAmountNumericUpDown";
            this.NewAmountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.NewAmountNumericUpDown.TabIndex = 5;
            // 
            // NewDateDateTimePicker
            // 
            this.NewDateDateTimePicker.Location = new System.Drawing.Point(252, 365);
            this.NewDateDateTimePicker.Name = "NewDateDateTimePicker";
            this.NewDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.NewDateDateTimePicker.TabIndex = 6;
            // 
            // NewPersonComboBox
            // 
            this.NewPersonComboBox.DataSource = this.salesPersonBindingSource;
            this.NewPersonComboBox.DisplayMember = "FullName";
            this.NewPersonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewPersonComboBox.FormattingEnabled = true;
            this.NewPersonComboBox.Location = new System.Drawing.Point(458, 364);
            this.NewPersonComboBox.Name = "NewPersonComboBox";
            this.NewPersonComboBox.Size = new System.Drawing.Size(121, 21);
            this.NewPersonComboBox.TabIndex = 7;
            this.NewPersonComboBox.ValueMember = "Id";
            // 
            // NewRegionComboBox
            // 
            this.NewRegionComboBox.DataSource = this.salesRegionBindingSource;
            this.NewRegionComboBox.DisplayMember = "Name";
            this.NewRegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewRegionComboBox.FormattingEnabled = true;
            this.NewRegionComboBox.Location = new System.Drawing.Point(585, 364);
            this.NewRegionComboBox.Name = "NewRegionComboBox";
            this.NewRegionComboBox.Size = new System.Drawing.Size(121, 21);
            this.NewRegionComboBox.TabIndex = 8;
            this.NewRegionComboBox.ValueMember = "Id";
            // 
            // NewSalesButton
            // 
            this.NewSalesButton.Location = new System.Drawing.Point(45, 362);
            this.NewSalesButton.Name = "NewSalesButton";
            this.NewSalesButton.Size = new System.Drawing.Size(75, 23);
            this.NewSalesButton.TabIndex = 9;
            this.NewSalesButton.Text = "NewSale";
            this.NewSalesButton.UseVisualStyleBackColor = true;
            this.NewSalesButton.Click += new System.EventHandler(this.NewSalesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewSalesButton);
            this.Controls.Add(this.NewRegionComboBox);
            this.Controls.Add(this.NewPersonComboBox);
            this.Controls.Add(this.NewDateDateTimePicker);
            this.Controls.Add(this.NewAmountNumericUpDown);
            this.Controls.Add(this.SalesTargetButton);
            this.Controls.Add(this.SalesDataGridView);
            this.Controls.Add(this.refreshSalesButton);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.peopleComboBox);
            this.Name = "Form1";
            this.Text = "Sales Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox peopleComboBox;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.Button refreshSalesButton;
        private System.Windows.Forms.DataGridView SalesDataGridView;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private System.Windows.Forms.BindingSource salesRegionBindingSource;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private System.Windows.Forms.Button SalesTargetButton;
        private System.Windows.Forms.NumericUpDown NewAmountNumericUpDown;
        private System.Windows.Forms.DateTimePicker NewDateDateTimePicker;
        private System.Windows.Forms.ComboBox NewPersonComboBox;
        private System.Windows.Forms.ComboBox NewRegionComboBox;
        private System.Windows.Forms.Button NewSalesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
    }
}

