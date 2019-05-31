namespace MVCHIS.Billing {
    partial class ContractForm {
        /// <summaryClient
        /// Required designer variable.
        /// </summaryClient
        private System.ComponentModel.IContainer components = null;

        /// <summaryClient
        /// Clean up any resources being used.
        /// </summaryClient
        /// <param name="disposing"Clienttrue if managed resources should be disposed; otherwise, false.</paramClient
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summaryClient
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summaryClient
        private void InitializeComponent(){
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            MVCHIS.Billing.ContractModel contractModel1 = new MVCHIS.Billing.ContractModel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtUpdatedOn = new System.Windows.Forms.TextBox();
            this.txtUpdatedBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreatedOn = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContractCode = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lookUpButtonContract = new MVCHIS.Common.LookUpButton();
            this.btnDateOfBirth = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lookUpButton1 = new MVCHIS.Common.LookUpButton();
            this.txtClientShortName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConditions = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnEditService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BillingCategoryColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EffectiveFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CurrencyColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(67, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(283, 420);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(221, 346);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 19;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(141, 346);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 18;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(221, 320);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 17;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(141, 320);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 16;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(141, 16);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            this.txtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Record Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Contract Code";
            // 
            // txtContractCode
            // 
            this.txtContractCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContractCode.Location = new System.Drawing.Point(141, 49);
            this.txtContractCode.Name = "txtContractCode";
            this.txtContractCode.Size = new System.Drawing.Size(154, 20);
            this.txtContractCode.TabIndex = 1;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(141, 78);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(102, 20);
            this.txtStartDate.TabIndex = 3;
            this.txtStartDate.Tag = "yyyy-MM-dd";
            this.txtStartDate.Leave += new System.EventHandler(this.TxtStartDate_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Start Date";
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(141, 380);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 20;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Read Only";
            // 
            // lookUpButtonContract
            // 
            this.lookUpButtonContract.AssociatedControl = "txtContractCode";
            this.lookUpButtonContract.Controller = "Contract";
            this.lookUpButtonContract.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonContract.Location = new System.Drawing.Point(297, 48);
            this.lookUpButtonContract.Name = "lookUpButtonContract";
            this.lookUpButtonContract.SelectedValueIndex = 0;
            this.lookUpButtonContract.ShowFieldsInLookUp.Add("ContractCode");
            this.lookUpButtonContract.ShowFieldsInLookUp.Add("Id");
            this.lookUpButtonContract.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonContract.TabIndex = 2;
            this.lookUpButtonContract.TabStop = false;
            this.lookUpButtonContract.LookUpSelected += new System.EventHandler(this.LookUpButton1LookUpSelected);
            // 
            // btnDateOfBirth
            // 
            this.btnDateOfBirth.Enabled = false;
            this.btnDateOfBirth.Location = new System.Drawing.Point(245, 77);
            this.btnDateOfBirth.Name = "btnDateOfBirth";
            this.btnDateOfBirth.Size = new System.Drawing.Size(23, 22);
            this.btnDateOfBirth.TabIndex = 4;
            this.btnDateOfBirth.TabStop = false;
            this.btnDateOfBirth.Tag = "CALENDAR";
            this.btnDateOfBirth.Text = "📅";
            this.btnDateOfBirth.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "End Date";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(141, 106);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(102, 20);
            this.txtEndDate.TabIndex = 5;
            this.txtEndDate.Tag = "yyyy-MM-dd";
            this.txtEndDate.Leave += new System.EventHandler(this.TxtEndDate_Leave);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(245, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 22);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Tag = "CALENDAR";
            this.button1.Text = "📅";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Client";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(141, 132);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.ReadOnly = true;
            this.txtClientId.Size = new System.Drawing.Size(36, 20);
            this.txtClientId.TabIndex = 7;
            this.txtClientId.TextChanged += new System.EventHandler(this.TxtClient_TextChanged);
            // 
            // lookUpButton1
            // 
            this.lookUpButton1.AssociatedControl = "txtClientId";
            this.lookUpButton1.Controller = "Client";
            this.lookUpButton1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButton1.Location = new System.Drawing.Point(179, 131);
            this.lookUpButton1.Name = "lookUpButton1";
            this.lookUpButton1.SelectedValueIndex = 2;
            this.lookUpButton1.ShowFieldsInLookUp.Add("ShortName");
            this.lookUpButton1.ShowFieldsInLookUp.Add("LongName");
            this.lookUpButton1.ShowFieldsInLookUp.Add("Id");
            this.lookUpButton1.Size = new System.Drawing.Size(22, 22);
            this.lookUpButton1.TabIndex = 8;
            this.lookUpButton1.TabStop = false;
            // 
            // txtClientShortName
            // 
            this.txtClientShortName.Enabled = false;
            this.txtClientShortName.Location = new System.Drawing.Point(204, 132);
            this.txtClientShortName.Name = "txtClientShortName";
            this.txtClientShortName.Size = new System.Drawing.Size(186, 20);
            this.txtClientShortName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Services / Prices";
            // 
            // txtConditions
            // 
            this.txtConditions.Font = new System.Drawing.Font("Consolas", 8F);
            this.txtConditions.Location = new System.Drawing.Point(402, 30);
            this.txtConditions.Multiline = true;
            this.txtConditions.Name = "txtConditions";
            this.txtConditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConditions.Size = new System.Drawing.Size(334, 123);
            this.txtConditions.TabIndex = 10;
            this.txtConditions.Text = "1-\r\n2-\r\n3-\r\n4-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Terms and Conditions";
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteService.Enabled = false;
            this.btnDeleteService.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnDeleteService.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteService.Location = new System.Drawing.Point(740, 167);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(32, 28);
            this.btnDeleteService.TabIndex = 12;
            this.btnDeleteService.TabStop = false;
            this.btnDeleteService.Text = "✖";
            this.toolTip1.SetToolTip(this.btnDeleteService, "Delete");
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.BtnDeleteService_Click);
            // 
            // btnEditService
            // 
            this.btnEditService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditService.Enabled = false;
            this.btnEditService.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnEditService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditService.Location = new System.Drawing.Point(740, 208);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(32, 28);
            this.btnEditService.TabIndex = 13;
            this.btnEditService.TabStop = false;
            this.btnEditService.Text = "✎";
            this.toolTip1.SetToolTip(this.btnEditService, "Edit");
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.BtnEditService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.Enabled = false;
            this.btnAddService.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnAddService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddService.Location = new System.Drawing.Point(740, 249);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(32, 28);
            this.btnAddService.TabIndex = 14;
            this.btnAddService.TabStop = false;
            this.btnAddService.Text = "➕";
            this.toolTip1.SetToolTip(this.btnAddService, "Add");
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.BtnAddService_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Is Active";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(141, 295);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(15, 14);
            this.chkIsActive.TabIndex = 15;
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillingCategoryColumn,
            this.EffectiveFromColumn,
            this.ExpiredColumn,
            this.CurrencyColumn,
            this.PriceColumn,
            this.VATColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(141, 158);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(593, 131);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 54;
            // 
            // BillingCategoryColumn
            // 
            this.BillingCategoryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillingCategoryColumn.DataPropertyName = "BillingCategoryId";
            this.BillingCategoryColumn.HeaderText = "Category";
            this.BillingCategoryColumn.Name = "BillingCategoryColumn";
            this.BillingCategoryColumn.ReadOnly = true;
            this.BillingCategoryColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BillingCategoryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EffectiveFromColumn
            // 
            this.EffectiveFromColumn.DataPropertyName = "EffectiveFromDate";
            dataGridViewCellStyle1.Format = "yyyy-MM-dd";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EffectiveFromColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.EffectiveFromColumn.HeaderText = "Effective";
            this.EffectiveFromColumn.Name = "EffectiveFromColumn";
            this.EffectiveFromColumn.ReadOnly = true;
            // 
            // ExpiredColumn
            // 
            this.ExpiredColumn.DataPropertyName = "Expired";
            this.ExpiredColumn.HeaderText = "Expired";
            this.ExpiredColumn.Name = "ExpiredColumn";
            this.ExpiredColumn.ReadOnly = true;
            // 
            // CurrencyColumn
            // 
            this.CurrencyColumn.DataPropertyName = "CurrencyId";
            this.CurrencyColumn.HeaderText = "Currency";
            this.CurrencyColumn.Name = "CurrencyColumn";
            this.CurrencyColumn.ReadOnly = true;
            this.CurrencyColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CurrencyColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "Price";
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // VATColumn
            // 
            this.VATColumn.DataPropertyName = "VATId";
            this.VATColumn.HeaderText = "VAT";
            this.VATColumn.Name = "VATColumn";
            this.VATColumn.ReadOnly = true;
            this.VATColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VATColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.btnEditService);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtConditions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtClientShortName);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDateOfBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lookUpButton1);
            this.Controls.Add(this.lookUpButtonContract);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContractCode);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreatedBy);
            contractModel1.ClientId = 0;
            contractModel1.Conditions = null;
            contractModel1.ContractCode = null;
            contractModel1.CreatedBy = null;
            contractModel1.CreatedOn = null;
            contractModel1.EndDate = null;
            contractModel1.Id = 0;
            contractModel1.IsActive = false;
            contractModel1.ReadOnly = false;
            contractModel1.StartDate = new System.DateTime(((long)(0)));
            contractModel1.UpdatedBy = null;
            contractModel1.UpdatedOn = null;
            this.Model = contractModel1;
            this.Name = "ContractForm";
            this.Size = new System.Drawing.Size(785, 452);
            this.Load += new System.EventHandler(this.ContractFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtUpdatedOn;
        private System.Windows.Forms.TextBox txtUpdatedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreatedOn;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContractCode;
        private Common.LookUpButton lookUpButtonContract;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClientId;
        private Common.LookUpButton lookUpButton1;
        private System.Windows.Forms.TextBox txtClientShortName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConditions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn BillingCategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveFromColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExpiredColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CurrencyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn VATColumn;
    }
}