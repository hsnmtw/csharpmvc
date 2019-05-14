namespace ViewWinform.Housing.Compounds {
    partial class CompoundFormView {
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
            this.Compound_Name_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Compound_Name_TextBox
            // 
            this.Compound_Name_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Compound_Name_TextBox.Location = new System.Drawing.Point(108, 39);
            this.Compound_Name_TextBox.Name = "Compound_Name_TextBox";
            this.Compound_Name_TextBox.Size = new System.Drawing.Size(195, 20);
            this.Compound_Name_TextBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Compound Name";
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Location = new System.Drawing.Point(108, 12);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.ReadOnly = true;
            this.Id_TextBox.Size = new System.Drawing.Size(54, 20);
            this.Id_TextBox.TabIndex = 29;
            this.Id_TextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Id";
            // 
            // CompoundFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Compound_Name_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "CompoundFormView";
            this.Size = new System.Drawing.Size(311, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Compound_Name_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id_TextBox;
        private System.Windows.Forms.Label label1;
    }
}
