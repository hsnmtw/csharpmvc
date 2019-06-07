namespace MVCHIS
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tssLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.passwordResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.encryptionToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controllersRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.txtSearchMenu = new System.Windows.Forms.TextBox();
            this.tsddbLanguage = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCurrentUser,
            this.toolStripStatusLabel2,
            this.tsProgressBar,
            this.tssLabelStatus,
            this.tsDateTime,
            this.tsddbLanguage});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // tsslCurrentUser
            // 
            this.tsslCurrentUser.Name = "tsslCurrentUser";
            resources.ApplyResources(this.tsslCurrentUser, "tsslCurrentUser");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Name = "tsProgressBar";
            resources.ApplyResources(this.tsProgressBar, "tsProgressBar");
            // 
            // tssLabelStatus
            // 
            this.tssLabelStatus.Name = "tssLabelStatus";
            resources.ApplyResources(this.tssLabelStatus, "tssLabelStatus");
            // 
            // tsDateTime
            // 
            resources.ApplyResources(this.tsDateTime, "tsDateTime");
            this.tsDateTime.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tsDateTime.Name = "tsDateTime";
            this.tsDateTime.Spring = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem11,
            this.passwordResetToolStripMenuItem,
            this.toolStripMenuItem8,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItemClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            resources.ApplyResources(this.toolStripMenuItem11, "toolStripMenuItem11");
            // 
            // passwordResetToolStripMenuItem
            // 
            this.passwordResetToolStripMenuItem.Name = "passwordResetToolStripMenuItem";
            resources.ApplyResources(this.passwordResetToolStripMenuItem, "passwordResetToolStripMenuItem");
            this.passwordResetToolStripMenuItem.Click += new System.EventHandler(this.PasswordResetToolStripMenuItemClick);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLViewerToolStripMenuItem,
            this.toolStripMenuItem7,
            this.encryptionToolToolStripMenuItem,
            this.controllersRegistryToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // sQLViewerToolStripMenuItem
            // 
            this.sQLViewerToolStripMenuItem.Name = "sQLViewerToolStripMenuItem";
            resources.ApplyResources(this.sQLViewerToolStripMenuItem, "sQLViewerToolStripMenuItem");
            this.sQLViewerToolStripMenuItem.Click += new System.EventHandler(this.SQLViewerToolStripMenuItemClick);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            // 
            // encryptionToolToolStripMenuItem
            // 
            this.encryptionToolToolStripMenuItem.Name = "encryptionToolToolStripMenuItem";
            resources.ApplyResources(this.encryptionToolToolStripMenuItem, "encryptionToolToolStripMenuItem");
            this.encryptionToolToolStripMenuItem.Click += new System.EventHandler(this.EncryptionToolToolStripMenuItemClick);
            // 
            // controllersRegistryToolStripMenuItem
            // 
            resources.ApplyResources(this.controllersRegistryToolStripMenuItem, "controllersRegistryToolStripMenuItem");
            this.controllersRegistryToolStripMenuItem.Name = "controllersRegistryToolStripMenuItem";
            this.controllersRegistryToolStripMenuItem.Click += new System.EventHandler(this.ControllersRegistryToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.TabControl1_TabIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeViewMenu);
            this.panel2.Controls.Add(this.txtSearchMenu);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.treeViewMenu, "treeViewMenu");
            this.treeViewMenu.FullRowSelect = true;
            this.treeViewMenu.HideSelection = false;
            this.treeViewMenu.ItemHeight = 15;
            this.treeViewMenu.Name = "treeViewMenu";
            this.treeViewMenu.ShowLines = false;
            this.treeViewMenu.ShowPlusMinus = false;
            this.treeViewMenu.ShowRootLines = false;
            this.treeViewMenu.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.TreeViewMenu_DrawNode);
            this.treeViewMenu.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewMenu_BeforeSelect);
            this.treeViewMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewMenu_AfterSelect);
            this.treeViewMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseDoubleClick);
            this.treeViewMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreeView1_KeyDown);
            // 
            // txtSearchMenu
            // 
            resources.ApplyResources(this.txtSearchMenu, "txtSearchMenu");
            this.txtSearchMenu.Name = "txtSearchMenu";
            this.txtSearchMenu.TextChanged += new System.EventHandler(this.TxtSearchMenu_TextChanged);
            // 
            // tsddbLanguage
            // 
            this.tsddbLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            resources.ApplyResources(this.tsddbLanguage, "tsddbLanguage");
            this.tsddbLanguage.Name = "tsddbLanguage";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // MainView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainViewFormClosing);
            this.Load += new System.EventHandler(this.MainViewLoad);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem controllersRegistryToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tssLabelStatus;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel tsDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeViewMenu;
        private System.Windows.Forms.TextBox txtSearchMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

