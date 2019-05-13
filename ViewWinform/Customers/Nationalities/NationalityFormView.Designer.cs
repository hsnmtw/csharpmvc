namespace ViewWinform.Customers.Nationalities {
    partial class NationalityFormView {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Nationality_Code_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nationality_Desc_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nationality_Arabic_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nationality_Code_TextBox
            // 
            this.Nationality_Code_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Nationality_Code_TextBox.Location = new System.Drawing.Point(124, 40);
            this.Nationality_Code_TextBox.Name = "Nationality_Code_TextBox";
            this.Nationality_Code_TextBox.Size = new System.Drawing.Size(68, 20);
            this.Nationality_Code_TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code";
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Location = new System.Drawing.Point(124, 13);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.ReadOnly = true;
            this.Id_TextBox.Size = new System.Drawing.Size(68, 20);
            this.Id_TextBox.TabIndex = 0;
            this.Id_TextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nationality En";
            // 
            // Nationality_Desc_TextBox
            // 
            this.Nationality_Desc_TextBox.BackColor = System.Drawing.Color.White;
            this.Nationality_Desc_TextBox.Location = new System.Drawing.Point(124, 66);
            this.Nationality_Desc_TextBox.Name = "Nationality_Desc_TextBox";
            this.Nationality_Desc_TextBox.Size = new System.Drawing.Size(151, 20);
            this.Nationality_Desc_TextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nationality Ar";
            // 
            // Nationality_Arabic_TextBox
            // 
            this.Nationality_Arabic_TextBox.BackColor = System.Drawing.Color.White;
            this.Nationality_Arabic_TextBox.Location = new System.Drawing.Point(124, 92);
            this.Nationality_Arabic_TextBox.Name = "Nationality_Arabic_TextBox";
            this.Nationality_Arabic_TextBox.Size = new System.Drawing.Size(151, 20);
            this.Nationality_Arabic_TextBox.TabIndex = 3;
            // 
            // NationalityFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Nationality_Arabic_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nationality_Desc_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nationality_Code_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "NationalityFormView";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(293, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Nationality_Code_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nationality_Desc_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nationality_Arabic_TextBox;
    }
}
