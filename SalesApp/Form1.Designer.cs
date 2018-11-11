namespace SalesApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
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
            this.refreshSalesbutton = new System.Windows.Forms.Button();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTargetButton = new System.Windows.Forms.Button();
            this.newAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.newDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newPersonComboBox = new System.Windows.Forms.ComboBox();
            this.newRegionComboBox = new System.Windows.Forms.ComboBox();
            this.newSaleButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleComboBox
            // 
            this.peopleComboBox.DataSource = this.salesPersonBindingSource;
            this.peopleComboBox.DisplayMember = "Fullname";
            this.peopleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.peopleComboBox.FormattingEnabled = true;
            this.peopleComboBox.Location = new System.Drawing.Point(146, 21);
            this.peopleComboBox.Name = "peopleComboBox";
            this.peopleComboBox.Size = new System.Drawing.Size(104, 20);
            this.peopleComboBox.TabIndex = 0;
            this.peopleComboBox.ValueMember = "Id";
            this.peopleComboBox.SelectedIndexChanged += new System.EventHandler(this.peopleComboBox_SelectedIndexChanged);
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
            this.regionComboBox.Location = new System.Drawing.Point(256, 21);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(104, 20);
            this.regionComboBox.TabIndex = 1;
            this.regionComboBox.ValueMember = "Id";
            // 
            // salesRegionBindingSource
            // 
            this.salesRegionBindingSource.DataSource = typeof(SalesApp.Models.SalesRegion);
            // 
            // refreshSalesbutton
            // 
            this.refreshSalesbutton.Location = new System.Drawing.Point(376, 21);
            this.refreshSalesbutton.Name = "refreshSalesbutton";
            this.refreshSalesbutton.Size = new System.Drawing.Size(70, 20);
            this.refreshSalesbutton.TabIndex = 2;
            this.refreshSalesbutton.Text = "Refresh";
            this.refreshSalesbutton.UseVisualStyleBackColor = true;
            this.refreshSalesbutton.Click += new System.EventHandler(this.refreshSalesbutton_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AllowUserToAddRows = false;
            this.salesDataGridView.AllowUserToDeleteRows = false;
            this.salesDataGridView.AutoGenerateColumns = false;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.salesDataGridView.DataSource = this.saleBindingSource;
            this.salesDataGridView.Location = new System.Drawing.Point(12, 58);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.RowTemplate.Height = 23;
            this.salesDataGridView.Size = new System.Drawing.Size(434, 242);
            this.salesDataGridView.TabIndex = 3;
            this.salesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.salesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellEndEdit);
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(SalesApp.Models.Sale);
            // 
            // salesTargetButton
            // 
            this.salesTargetButton.Location = new System.Drawing.Point(83, 21);
            this.salesTargetButton.Name = "salesTargetButton";
            this.salesTargetButton.Size = new System.Drawing.Size(57, 20);
            this.salesTargetButton.TabIndex = 4;
            this.salesTargetButton.Text = "Target";
            this.salesTargetButton.UseVisualStyleBackColor = true;
            this.salesTargetButton.Click += new System.EventHandler(this.salesTargetButton_Click);
            // 
            // newAmountNumericUpDown
            // 
            this.newAmountNumericUpDown.DecimalPlaces = 2;
            this.newAmountNumericUpDown.Location = new System.Drawing.Point(83, 325);
            this.newAmountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.newAmountNumericUpDown.Name = "newAmountNumericUpDown";
            this.newAmountNumericUpDown.Size = new System.Drawing.Size(120, 21);
            this.newAmountNumericUpDown.TabIndex = 5;
            // 
            // newDateDateTimePicker
            // 
            this.newDateDateTimePicker.Location = new System.Drawing.Point(83, 352);
            this.newDateDateTimePicker.Name = "newDateDateTimePicker";
            this.newDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.newDateDateTimePicker.TabIndex = 6;
            // 
            // newPersonComboBox
            // 
            this.newPersonComboBox.DataSource = this.salesPersonBindingSource;
            this.newPersonComboBox.DisplayMember = "Fullname";
            this.newPersonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newPersonComboBox.FormattingEnabled = true;
            this.newPersonComboBox.Location = new System.Drawing.Point(83, 379);
            this.newPersonComboBox.Name = "newPersonComboBox";
            this.newPersonComboBox.Size = new System.Drawing.Size(104, 20);
            this.newPersonComboBox.TabIndex = 7;
            this.newPersonComboBox.ValueMember = "Id";
            // 
            // newRegionComboBox
            // 
            this.newRegionComboBox.DataSource = this.salesRegionBindingSource;
            this.newRegionComboBox.DisplayMember = "Name";
            this.newRegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newRegionComboBox.FormattingEnabled = true;
            this.newRegionComboBox.Location = new System.Drawing.Point(193, 379);
            this.newRegionComboBox.Name = "newRegionComboBox";
            this.newRegionComboBox.Size = new System.Drawing.Size(104, 20);
            this.newRegionComboBox.TabIndex = 8;
            this.newRegionComboBox.ValueMember = "Id";
            // 
            // newSaleButton
            // 
            this.newSaleButton.Location = new System.Drawing.Point(303, 379);
            this.newSaleButton.Name = "newSaleButton";
            this.newSaleButton.Size = new System.Drawing.Size(75, 20);
            this.newSaleButton.TabIndex = 9;
            this.newSaleButton.Text = "New Sale";
            this.newSaleButton.UseVisualStyleBackColor = true;
            this.newSaleButton.Click += new System.EventHandler(this.newSaleButton_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.newSaleButton);
            this.Controls.Add(this.newRegionComboBox);
            this.Controls.Add(this.newPersonComboBox);
            this.Controls.Add(this.newDateDateTimePicker);
            this.Controls.Add(this.newAmountNumericUpDown);
            this.Controls.Add(this.salesTargetButton);
            this.Controls.Add(this.salesDataGridView);
            this.Controls.Add(this.refreshSalesbutton);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.peopleComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox peopleComboBox;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.BindingSource salesRegionBindingSource;
        private System.Windows.Forms.Button refreshSalesbutton;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private System.Windows.Forms.Button salesTargetButton;
        private System.Windows.Forms.NumericUpDown newAmountNumericUpDown;
        private System.Windows.Forms.DateTimePicker newDateDateTimePicker;
        private System.Windows.Forms.ComboBox newPersonComboBox;
        private System.Windows.Forms.ComboBox newRegionComboBox;
        private System.Windows.Forms.Button newSaleButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
    }
}

