namespace ViewWinform.Configurations {
    partial class CryptoForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHashed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Text";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(91, 21);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(304, 20);
            this.txtInput.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Encrypted";
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(91, 47);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.ReadOnly = true;
            this.txtEncrypted.Size = new System.Drawing.Size(304, 20);
            this.txtEncrypted.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Decrypted";
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(91, 73);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ReadOnly = true;
            this.txtDecrypted.Size = new System.Drawing.Size(304, 20);
            this.txtDecrypted.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hashed";
            // 
            // txtHashed
            // 
            this.txtHashed.Location = new System.Drawing.Point(91, 99);
            this.txtHashed.Name = "txtHashed";
            this.txtHashed.ReadOnly = true;
            this.txtHashed.Size = new System.Drawing.Size(304, 20);
            this.txtHashed.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // CryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 186);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHashed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "CryptoForm";
            this.Text = "CryptoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHashed;
        private System.Windows.Forms.Button button1;
    }
}