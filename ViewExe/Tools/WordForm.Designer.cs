namespace MVCHIS.Tools {
    partial class WordForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(){
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtUpdatedOn = new System.Windows.Forms.TextBox();
            this.txtUpdatedBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreatedOn = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWordInEnglish = new System.Windows.Forms.TextBox();
            this.btnPLWord = new MVCHIS.Common.PickListButton();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstWordInLanguages = new MVCHIS.Utils.ListViewControl();
            this.btnAddWordInLanguage = new System.Windows.Forms.Button();
            this.btnEditWordInLanguage = new System.Windows.Forms.Button();
            this.btnDeleteWordInLanguage = new System.Windows.Forms.Button();
            this.contextMenuStripLanguage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(40, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(256, 383);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.Location = new System.Drawing.Point(194, 317);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 7;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.Location = new System.Drawing.Point(120, 317);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 6;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(194, 291);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 5;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(120, 291);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 4;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Word In English";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 21);
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
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Record Id";
            // 
            // txtWordInEnglish
            // 
            this.txtWordInEnglish.Location = new System.Drawing.Point(120, 49);
            this.txtWordInEnglish.Name = "txtWordInEnglish";
            this.txtWordInEnglish.Size = new System.Drawing.Size(249, 20);
            this.txtWordInEnglish.TabIndex = 2;
            // 
            // btnPLWord
            // 
            this.btnPLWord.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLWord.Location = new System.Drawing.Point(193, 20);
            this.btnPLWord.Name = "btnPLWord";
            this.btnPLWord.Size = new System.Drawing.Size(22, 22);
            this.btnPLWord.Source = "Word";
            this.btnPLWord.TabIndex = 1;
            this.btnPLWord.TabStop = false;
            this.btnPLWord.Text = "↓";
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(121, 347);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 8;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Read Only";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Translations";
            // 
            // lstWordInLanguages
            // 
            this.lstWordInLanguages.Filter = null;
            this.lstWordInLanguages.FullRowSelect = true;
            this.lstWordInLanguages.GridLines = true;
            this.lstWordInLanguages.HideSelection = false;
            this.lstWordInLanguages.LabelWrap = false;
            this.lstWordInLanguages.Location = new System.Drawing.Point(120, 80);
            this.lstWordInLanguages.MultiSelect = false;
            this.lstWordInLanguages.Name = "lstWordInLanguages";
            this.lstWordInLanguages.Size = new System.Drawing.Size(211, 205);
            this.lstWordInLanguages.TabIndex = 46;
            this.lstWordInLanguages.UseCompatibleStateImageBehavior = false;
            this.lstWordInLanguages.View = System.Windows.Forms.View.Details;
            this.lstWordInLanguages.SelectedIndexChanged += new System.EventHandler(this.LstWordInLanguages_SelectedIndexChanged);
            // 
            // btnAddWordInLanguage
            // 
            this.btnAddWordInLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWordInLanguage.Enabled = false;
            this.btnAddWordInLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddWordInLanguage.Location = new System.Drawing.Point(337, 162);
            this.btnAddWordInLanguage.Name = "btnAddWordInLanguage";
            this.btnAddWordInLanguage.Size = new System.Drawing.Size(32, 28);
            this.btnAddWordInLanguage.TabIndex = 49;
            this.btnAddWordInLanguage.TabStop = false;
            this.btnAddWordInLanguage.Text = "➕";
            this.btnAddWordInLanguage.UseVisualStyleBackColor = true;
            this.btnAddWordInLanguage.Click += new System.EventHandler(this.BtnAddWordInLanguage_Click);
            // 
            // btnEditWordInLanguage
            // 
            this.btnEditWordInLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditWordInLanguage.Enabled = false;
            this.btnEditWordInLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditWordInLanguage.Location = new System.Drawing.Point(337, 121);
            this.btnEditWordInLanguage.Name = "btnEditWordInLanguage";
            this.btnEditWordInLanguage.Size = new System.Drawing.Size(32, 28);
            this.btnEditWordInLanguage.TabIndex = 48;
            this.btnEditWordInLanguage.TabStop = false;
            this.btnEditWordInLanguage.Text = "✎";
            this.btnEditWordInLanguage.UseVisualStyleBackColor = true;
            this.btnEditWordInLanguage.Click += new System.EventHandler(this.BtnEditWordInLanguage_Click);
            // 
            // btnDeleteWordInLanguage
            // 
            this.btnDeleteWordInLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteWordInLanguage.Enabled = false;
            this.btnDeleteWordInLanguage.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteWordInLanguage.Location = new System.Drawing.Point(337, 80);
            this.btnDeleteWordInLanguage.Name = "btnDeleteWordInLanguage";
            this.btnDeleteWordInLanguage.Size = new System.Drawing.Size(32, 28);
            this.btnDeleteWordInLanguage.TabIndex = 47;
            this.btnDeleteWordInLanguage.TabStop = false;
            this.btnDeleteWordInLanguage.Text = "✖";
            this.btnDeleteWordInLanguage.UseVisualStyleBackColor = true;
            this.btnDeleteWordInLanguage.Click += new System.EventHandler(this.BtnDeleteWordInLanguage_Click);
            // 
            // contextMenuStripLanguage
            // 
            this.contextMenuStripLanguage.Name = "contextMenuStripLanguage";
            this.contextMenuStripLanguage.Size = new System.Drawing.Size(61, 4);
            // 
            // WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddWordInLanguage);
            this.Controls.Add(this.btnEditWordInLanguage);
            this.Controls.Add(this.btnDeleteWordInLanguage);
            this.Controls.Add(this.lstWordInLanguages);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPLWord);
            this.Controls.Add(this.txtWordInEnglish);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "WordForm";
            this.Size = new System.Drawing.Size(382, 418);
            this.Load += new System.EventHandler(this.DictionaryFormLoad);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWordInEnglish;
        private Common.PickListButton btnPLWord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private Utils.ListViewControl lstWordInLanguages;
        private System.Windows.Forms.Button btnAddWordInLanguage;
        private System.Windows.Forms.Button btnEditWordInLanguage;
        private System.Windows.Forms.Button btnDeleteWordInLanguage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLanguage;
        //private Common.PickListButton DictionaryNameLookupButton;
    }
}