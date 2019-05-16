namespace ViewWinform.Housing.Compounds {
    partial class CompoundForm {
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
            this.Compound_Name_TextBox = new ViewWinform.Common.LookUpField();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Updated_On_TextBox = new System.Windows.Forms.TextBox();
            this.Updated_By_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Created_On_TextBox = new System.Windows.Forms.TextBox();
            this.Created_By_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Compound_Name_TextBox
            // 
            this.Compound_Name_TextBox.Location = new System.Drawing.Point(119, 47);
            this.Compound_Name_TextBox.Name = "Compound_Name_TextBox";
            this.Compound_Name_TextBox.ShowFieldsInLookUp.Add("Compound_Name");
            this.Compound_Name_TextBox.Size = new System.Drawing.Size(104, 22);
            this.Compound_Name_TextBox.TabIndex = 17;
            this.Compound_Name_TextBox.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Compound_Name_TextBox.OnLookUpSelected += new ViewWinform.Common.LookUpField.LookUpSelectedHandler(this.Compound_Code_TextBox_OnLookUpSelected);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Updated_On_TextBox
            // 
            this.Updated_On_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Updated_On_TextBox.Location = new System.Drawing.Point(194, 152);
            this.Updated_On_TextBox.Name = "Updated_On_TextBox";
            this.Updated_On_TextBox.ReadOnly = true;
            this.Updated_On_TextBox.Size = new System.Drawing.Size(137, 20);
            this.Updated_On_TextBox.TabIndex = 23;
            this.Updated_On_TextBox.TabStop = false;
            // 
            // Updated_By_TextBox
            // 
            this.Updated_By_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Updated_By_TextBox.Location = new System.Drawing.Point(119, 152);
            this.Updated_By_TextBox.Name = "Updated_By_TextBox";
            this.Updated_By_TextBox.ReadOnly = true;
            this.Updated_By_TextBox.Size = new System.Drawing.Size(69, 20);
            this.Updated_By_TextBox.TabIndex = 22;
            this.Updated_By_TextBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Updated by";
            // 
            // Created_On_TextBox
            // 
            this.Created_On_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Created_On_TextBox.Location = new System.Drawing.Point(194, 126);
            this.Created_On_TextBox.Name = "Created_On_TextBox";
            this.Created_On_TextBox.ReadOnly = true;
            this.Created_On_TextBox.Size = new System.Drawing.Size(137, 20);
            this.Created_On_TextBox.TabIndex = 21;
            this.Created_On_TextBox.TabStop = false;
            // 
            // Created_By_TextBox
            // 
            this.Created_By_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Created_By_TextBox.Location = new System.Drawing.Point(119, 126);
            this.Created_By_TextBox.Name = "Created_By_TextBox";
            this.Created_By_TextBox.ReadOnly = true;
            this.Created_By_TextBox.Size = new System.Drawing.Size(69, 20);
            this.Created_By_TextBox.TabIndex = 20;
            this.Created_By_TextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Comound Name";
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Location = new System.Drawing.Point(120, 21);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.ReadOnly = true;
            this.Id_TextBox.Size = new System.Drawing.Size(68, 20);
            this.Id_TextBox.TabIndex = 16;
            this.Id_TextBox.TabStop = false;
            this.Id_TextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id";
            // 
            // CompoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 237);
            this.Controls.Add(this.Compound_Name_TextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Updated_On_TextBox);
            this.Controls.Add(this.Updated_By_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Created_On_TextBox);
            this.Controls.Add(this.Created_By_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "CompoundForm";
            this.Text = "Comounds";
            this.Load += new System.EventHandler(this.CompoundForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.LookUpField Compound_Name_TextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Updated_On_TextBox;
        private System.Windows.Forms.TextBox Updated_By_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Created_On_TextBox;
        private System.Windows.Forms.TextBox Created_By_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id_TextBox;
        private System.Windows.Forms.Label label1;
    }
}