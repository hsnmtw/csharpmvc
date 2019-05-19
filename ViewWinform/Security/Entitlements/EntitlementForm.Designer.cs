namespace ViewWinform.Security.Entitlements {
    partial class EntitlementForm {
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
            this.Entitlement_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Entitlement_Name_Lookup = new ViewWinform.Common.LookUpButton();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(79, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Updated_On_TextBox
            // 
            this.Updated_On_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Updated_On_TextBox.Location = new System.Drawing.Point(233, 143);
            this.Updated_On_TextBox.Name = "Updated_On_TextBox";
            this.Updated_On_TextBox.ReadOnly = true;
            this.Updated_On_TextBox.Size = new System.Drawing.Size(137, 20);
            this.Updated_On_TextBox.TabIndex = 37;
            this.Updated_On_TextBox.TabStop = false;
            // 
            // Updated_By_TextBox
            // 
            this.Updated_By_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Updated_By_TextBox.Location = new System.Drawing.Point(158, 143);
            this.Updated_By_TextBox.Name = "Updated_By_TextBox";
            this.Updated_By_TextBox.ReadOnly = true;
            this.Updated_By_TextBox.Size = new System.Drawing.Size(69, 20);
            this.Updated_By_TextBox.TabIndex = 36;
            this.Updated_By_TextBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Updated by";
            // 
            // Created_On_TextBox
            // 
            this.Created_On_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Created_On_TextBox.Location = new System.Drawing.Point(233, 117);
            this.Created_On_TextBox.Name = "Created_On_TextBox";
            this.Created_On_TextBox.ReadOnly = true;
            this.Created_On_TextBox.Size = new System.Drawing.Size(137, 20);
            this.Created_On_TextBox.TabIndex = 35;
            this.Created_On_TextBox.TabStop = false;
            // 
            // Created_By_TextBox
            // 
            this.Created_By_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Created_By_TextBox.Location = new System.Drawing.Point(158, 117);
            this.Created_By_TextBox.Name = "Created_By_TextBox";
            this.Created_By_TextBox.ReadOnly = true;
            this.Created_By_TextBox.Size = new System.Drawing.Size(69, 20);
            this.Created_By_TextBox.TabIndex = 34;
            this.Created_By_TextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Entitlement Name";
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Location = new System.Drawing.Point(159, 12);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.ReadOnly = true;
            this.Id_TextBox.Size = new System.Drawing.Size(68, 20);
            this.Id_TextBox.TabIndex = 32;
            this.Id_TextBox.TabStop = false;
            this.Id_TextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id";
            // 
            // Entitlement_Name_TextBox
            // 
            this.Entitlement_Name_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Entitlement_Name_TextBox.Location = new System.Drawing.Point(159, 42);
            this.Entitlement_Name_TextBox.Name = "Entitlement_Name_TextBox";
            this.Entitlement_Name_TextBox.Size = new System.Drawing.Size(192, 20);
            this.Entitlement_Name_TextBox.TabIndex = 1;
            this.Entitlement_Name_TextBox.TabStop = false;
            // 
            // Entitlement_Name_Lookup
            // 
            this.Entitlement_Name_Lookup.AssociatedControl = "Entitlement_Name_TextBox";
            this.Entitlement_Name_Lookup.Controller = "Entitlement";
            this.Entitlement_Name_Lookup.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Entitlement_Name_Lookup.Location = new System.Drawing.Point(351, 41);
            this.Entitlement_Name_Lookup.Name = "Entitlement_Name_Lookup";
            this.Entitlement_Name_Lookup.Size = new System.Drawing.Size(22, 22);
            this.Entitlement_Name_Lookup.TabIndex = 2;
            this.Entitlement_Name_Lookup.OnLookUpSelected += new System.EventHandler(this.Entitlement_Name_Lookup_OnLookUpSelected);
            // 
            // EntitlementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 229);
            this.Controls.Add(this.Entitlement_Name_TextBox);
            this.Controls.Add(this.Entitlement_Name_Lookup);
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
            this.Name = "EntitlementForm";
            this.Text = "Entitlements";
            this.Load += new System.EventHandler(this.EntitlementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.LookUpButton Entitlement_Name_Lookup;
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
        private System.Windows.Forms.TextBox Entitlement_Name_TextBox;
    }
}