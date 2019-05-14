namespace DBManagerLibrary.Utils.TableDesigner {
    partial class TableDesignerView {
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
            this.tableDesignerForm1 = new DBManagerLibrary.Utils.TableDesigner.TableDesignerForm();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableDesignerForm1
            // 
            this.tableDesignerForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDesignerForm1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableDesignerForm1.Location = new System.Drawing.Point(233, 0);
            this.tableDesignerForm1.Name = "tableDesignerForm1";
            this.tableDesignerForm1.Size = new System.Drawing.Size(679, 426);
            this.tableDesignerForm1.TabIndex = 0;
            this.tableDesignerForm1.Load += new System.EventHandler(this.TableDesignerForm1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(233, 426);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(7, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 414);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.ListBox1_SelectedValueChanged);
            // 
            // TableDesignerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 426);
            this.Controls.Add(this.tableDesignerForm1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TableDesignerView";
            this.Text = "TableDesignerView";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableDesignerForm tableDesignerForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}