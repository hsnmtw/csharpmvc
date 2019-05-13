namespace ViewWinform.Security.Audit {
    partial class AuditFormView {
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
            this.label1 = new System.Windows.Forms.Label();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.User_Name_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Event_Comments_TextBox = new System.Windows.Forms.TextBox();
            this.Event_Date_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Id_TextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TextBox.Location = new System.Drawing.Point(121, 11);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.ReadOnly = true;
            this.Id_TextBox.Size = new System.Drawing.Size(48, 20);
            this.Id_TextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User_Name";
            // 
            // User_Name_TextBox
            // 
            this.User_Name_TextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_TextBox.Location = new System.Drawing.Point(121, 37);
            this.User_Name_TextBox.Name = "User_Name_TextBox";
            this.User_Name_TextBox.ReadOnly = true;
            this.User_Name_TextBox.Size = new System.Drawing.Size(100, 20);
            this.User_Name_TextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Event_Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Event_Comments";
            // 
            // Event_Comments_TextBox
            // 
            this.Event_Comments_TextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_Comments_TextBox.Location = new System.Drawing.Point(121, 89);
            this.Event_Comments_TextBox.Multiline = true;
            this.Event_Comments_TextBox.Name = "Event_Comments_TextBox";
            this.Event_Comments_TextBox.ReadOnly = true;
            this.Event_Comments_TextBox.Size = new System.Drawing.Size(421, 276);
            this.Event_Comments_TextBox.TabIndex = 3;
            // 
            // Event_Date_TextBox
            // 
            this.Event_Date_TextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_Date_TextBox.Location = new System.Drawing.Point(121, 63);
            this.Event_Date_TextBox.Name = "Event_Date_TextBox";
            this.Event_Date_TextBox.ReadOnly = true;
            this.Event_Date_TextBox.Size = new System.Drawing.Size(220, 20);
            this.Event_Date_TextBox.TabIndex = 2;
            // 
            // AuditFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Event_Comments_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Event_Date_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.User_Name_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "AuditFormView";
            this.Size = new System.Drawing.Size(546, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User_Name_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Event_Comments_TextBox;
        private System.Windows.Forms.TextBox Event_Date_TextBox;
    }
}
