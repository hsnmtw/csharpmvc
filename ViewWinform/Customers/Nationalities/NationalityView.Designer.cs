namespace ViewWinform.Customers.Nationalities {
    partial class NationalityView {
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
        private void InitializeComponent() {
            ModelLibrary.Customers.NationalityModel nationalityModel1 = new ModelLibrary.Customers.NationalityModel();
            this.nationalityFormView1 = new ViewWinform.Customers.Nationalities.NationalityFormView();
            this.SuspendLayout();
            // 
            // nationalityFormView1
            // 
            this.nationalityFormView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nationalityFormView1.Location = new System.Drawing.Point(5, 71);
            nationalityModel1.Created_By = null;
            nationalityModel1.Created_On = new System.DateTime(((long)(0)));
            nationalityModel1.Id = -1;
            nationalityModel1.Nationality_Arabic = "";
            nationalityModel1.Nationality_Code = "";
            nationalityModel1.Nationality_Desc = "";
            nationalityModel1.Updated_By = null;
            nationalityModel1.Updated_On = new System.DateTime(((long)(0)));
            this.nationalityFormView1.model = nationalityModel1;
            this.nationalityFormView1.Name = "nationalityFormView1";
            this.nationalityFormView1.Padding = new System.Windows.Forms.Padding(3);
            this.nationalityFormView1.Size = new System.Drawing.Size(286, 139);
            this.nationalityFormView1.TabIndex = 2;
            // 
            // NationalityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 240);
            this.Controls.Add(this.nationalityFormView1);
            this.Name = "NationalityView";
            this.Text = "NationalityView";
            this.OnRecordPositionChanged += new ViewWinform.Common.CommonView.RecordPositionHandler(this.NationalityView_OnRecordPositionChanged);
            this.OnRecordOperationInvoked += new ViewWinform.Common.CommonView.RecordOperationHandler(this.NationalityView_OnRecordOperationInvoked);
            this.Controls.SetChildIndex(this.nationalityFormView1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalityFormView nationalityFormView1;
    }
}