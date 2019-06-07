namespace MVCHIS.Common {
    partial class WordLanguageForm {
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
            this.txtUpdatedOn = new System.Windows.Forms.TextBox();
            this.txtUpdatedBy = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCreatedOn = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWordInEnglish = new System.Windows.Forms.TextBox();
            this.btnPLWord = new MVCHIS.Common.PickListButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLanguageName = new System.Windows.Forms.TextBox();
            this.btnPLLanguage = new MVCHIS.Common.PickListButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWordInLanguage = new System.Windows.Forms.TextBox();
            this.txtWordId = new System.Windows.Forms.TextBox();
            this.txtLanguageId = new System.Windows.Forms.TextBox();
            this.btnPLWordLanguage = new MVCHIS.Common.PickListButton();
            this.SuspendLayout();
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.Location = new System.Drawing.Point(213, 161);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 12;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.Location = new System.Drawing.Point(140, 161);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 11;
            this.txtUpdatedBy.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(275, 237);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(167, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(213, 135);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 10;
            this.txtCreatedOn.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(59, 237);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(140, 135);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 9;
            this.txtCreatedBy.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Word";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // txtWordInEnglish
            // 
            this.txtWordInEnglish.Location = new System.Drawing.Point(179, 46);
            this.txtWordInEnglish.Name = "txtWordInEnglish";
            this.txtWordInEnglish.ReadOnly = true;
            this.txtWordInEnglish.Size = new System.Drawing.Size(148, 20);
            this.txtWordInEnglish.TabIndex = 3;
            // 
            // btnPLWord
            // 
            this.btnPLWord.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLWord.Location = new System.Drawing.Point(328, 45);
            this.btnPLWord.Name = "btnPLWord";
            this.btnPLWord.Size = new System.Drawing.Size(22, 22);
            this.btnPLWord.Source = "Word";
            this.btnPLWord.TabIndex = 4;
            this.btnPLWord.TabStop = false;
            this.btnPLWord.Text = "↓";
            
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(140, 10);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Record Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Read Only";
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(140, 195);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 13;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Language";
            // 
            // txtLanguageName
            // 
            this.txtLanguageName.Location = new System.Drawing.Point(179, 72);
            this.txtLanguageName.Name = "txtLanguageName";
            this.txtLanguageName.ReadOnly = true;
            this.txtLanguageName.Size = new System.Drawing.Size(148, 20);
            this.txtLanguageName.TabIndex = 6;
            // 
            // btnPLLanguage
            // 
            this.btnPLLanguage.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLLanguage.Location = new System.Drawing.Point(328, 71);
            this.btnPLLanguage.Name = "btnPLLanguage";
            this.btnPLLanguage.Size = new System.Drawing.Size(22, 22);
            this.btnPLLanguage.Source = "Language";
            this.btnPLLanguage.TabIndex = 7;
            this.btnPLLanguage.TabStop = false;
            this.btnPLLanguage.Text = "↓";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Word In Language";
            // 
            // txtWordInLanguage
            // 
            this.txtWordInLanguage.Location = new System.Drawing.Point(140, 98);
            this.txtWordInLanguage.Name = "txtWordInLanguage";
            this.txtWordInLanguage.Size = new System.Drawing.Size(210, 20);
            this.txtWordInLanguage.TabIndex = 8;
            // 
            // txtWordId
            // 
            this.txtWordId.Location = new System.Drawing.Point(140, 46);
            this.txtWordId.Name = "txtWordId";
            this.txtWordId.ReadOnly = true;
            this.txtWordId.Size = new System.Drawing.Size(34, 20);
            this.txtWordId.TabIndex = 2;
            this.txtWordId.TextChanged += new System.EventHandler(this.TxtWordId_TextChanged);
            // 
            // txtLanguageId
            // 
            this.txtLanguageId.Location = new System.Drawing.Point(140, 72);
            this.txtLanguageId.Name = "txtLanguageId";
            this.txtLanguageId.ReadOnly = true;
            this.txtLanguageId.Size = new System.Drawing.Size(34, 20);
            this.txtLanguageId.TabIndex = 5;
            this.txtLanguageId.TextChanged += new System.EventHandler(this.TxtLanguageId_TextChanged);
            // 
            // btnPLWordLanguage
            // 
            this.btnPLWordLanguage.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLWordLanguage.Location = new System.Drawing.Point(209, 9);
            this.btnPLWordLanguage.Name = "btnPLWordLanguage";
            this.btnPLWordLanguage.Size = new System.Drawing.Size(22, 22);
            this.btnPLWordLanguage.Source = "WordLanguage";
            this.btnPLWordLanguage.TabIndex = 1;
            this.btnPLWordLanguage.TabStop = false;
            this.btnPLWordLanguage.Text = "↓";
            
            // 
            // WordLanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPLLanguage);
            this.Controls.Add(this.btnPLWordLanguage);
            this.Controls.Add(this.btnPLWord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWordInLanguage);
            this.Controls.Add(this.txtLanguageId);
            this.Controls.Add(this.txtLanguageName);
            this.Controls.Add(this.txtWordId);
            this.Controls.Add(this.txtWordInEnglish);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreatedBy);
            this.Name = "WordLanguageForm";
            this.Size = new System.Drawing.Size(373, 273);
            this.Load += new System.EventHandler(this.DictionaryLanguageFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUpdatedOn;
        private System.Windows.Forms.TextBox txtUpdatedBy;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCreatedOn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWordInEnglish;
        private PickListButton btnPLWord;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLanguageName;
        private PickListButton btnPLLanguage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWordInLanguage;
        private System.Windows.Forms.TextBox txtWordId;
        private System.Windows.Forms.TextBox txtLanguageId;
        private PickListButton btnPLWordLanguage;
    }
}