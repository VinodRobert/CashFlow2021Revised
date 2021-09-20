namespace CashFlow.PresentationLayer.Login
{
    partial class frmMain
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuCashFlow = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCashFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapLedgerCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curentMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reMappingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subContractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentMappingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.missedMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reMappingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripProjectName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fundTransferRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subContractorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCashFlow,
            this.utilityToolStripMenuItem,
            this.fundTransferRequestToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1434, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menuCashFlow
            // 
            this.menuCashFlow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCashFlowToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.menuCashFlow.Name = "menuCashFlow";
            this.menuCashFlow.Size = new System.Drawing.Size(108, 24);
            this.menuCashFlow.Text = "Cash Flow";
            // 
            // viewCashFlowToolStripMenuItem
            // 
            this.viewCashFlowToolStripMenuItem.Name = "viewCashFlowToolStripMenuItem";
            this.viewCashFlowToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.viewCashFlowToolStripMenuItem.Text = "View Cash Flow";
            this.viewCashFlowToolStripMenuItem.Click += new System.EventHandler(this.viewCashFlowToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.mapLedgerCodeToolStripMenuItem,
            this.subContractorToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentMappingToolStripMenuItem,
            this.missingToolStripMenuItem,
            this.remappingToolStripMenuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.logoutToolStripMenuItem.Text = "Ledger Code";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // currentMappingToolStripMenuItem
            // 
            this.currentMappingToolStripMenuItem.Name = "currentMappingToolStripMenuItem";
            this.currentMappingToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.currentMappingToolStripMenuItem.Text = "Current Mapping";
            this.currentMappingToolStripMenuItem.Click += new System.EventHandler(this.currentMappingToolStripMenuItem_Click);
            // 
            // missingToolStripMenuItem
            // 
            this.missingToolStripMenuItem.Name = "missingToolStripMenuItem";
            this.missingToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.missingToolStripMenuItem.Text = "Map Missed Items";
            this.missingToolStripMenuItem.Click += new System.EventHandler(this.missingToolStripMenuItem_Click);
            // 
            // remappingToolStripMenuItem
            // 
            this.remappingToolStripMenuItem.Name = "remappingToolStripMenuItem";
            this.remappingToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.remappingToolStripMenuItem.Text = "Re-Mapping";
            this.remappingToolStripMenuItem.Click += new System.EventHandler(this.remappingToolStripMenuItem_Click);
            // 
            // mapLedgerCodeToolStripMenuItem
            // 
            this.mapLedgerCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curentMappingToolStripMenuItem,
            this.missingToolStripMenuItem1,
            this.reMappingToolStripMenuItem1});
            this.mapLedgerCodeToolStripMenuItem.Name = "mapLedgerCodeToolStripMenuItem";
            this.mapLedgerCodeToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.mapLedgerCodeToolStripMenuItem.Text = "Supplier";
            // 
            // curentMappingToolStripMenuItem
            // 
            this.curentMappingToolStripMenuItem.Name = "curentMappingToolStripMenuItem";
            this.curentMappingToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.curentMappingToolStripMenuItem.Text = "Curent Mapping";
            this.curentMappingToolStripMenuItem.Click += new System.EventHandler(this.curentMappingToolStripMenuItem_Click);
            // 
            // missingToolStripMenuItem1
            // 
            this.missingToolStripMenuItem1.Name = "missingToolStripMenuItem1";
            this.missingToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.missingToolStripMenuItem1.Text = "Missed - Mapping";
            this.missingToolStripMenuItem1.Click += new System.EventHandler(this.missingToolStripMenuItem1_Click);
            // 
            // reMappingToolStripMenuItem1
            // 
            this.reMappingToolStripMenuItem1.Name = "reMappingToolStripMenuItem1";
            this.reMappingToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.reMappingToolStripMenuItem1.Text = "Re-Mapping";
            this.reMappingToolStripMenuItem1.Click += new System.EventHandler(this.reMappingToolStripMenuItem1_Click);
            // 
            // subContractorToolStripMenuItem
            // 
            this.subContractorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentMappingToolStripMenuItem1,
            this.missedMappingToolStripMenuItem,
            this.reMappingToolStripMenuItem2});
            this.subContractorToolStripMenuItem.Name = "subContractorToolStripMenuItem";
            this.subContractorToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.subContractorToolStripMenuItem.Text = "Sub Contractor";
            // 
            // currentMappingToolStripMenuItem1
            // 
            this.currentMappingToolStripMenuItem1.Name = "currentMappingToolStripMenuItem1";
            this.currentMappingToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.currentMappingToolStripMenuItem1.Text = "Current Mapping";
            this.currentMappingToolStripMenuItem1.Click += new System.EventHandler(this.currentMappingToolStripMenuItem1_Click);
            // 
            // missedMappingToolStripMenuItem
            // 
            this.missedMappingToolStripMenuItem.Name = "missedMappingToolStripMenuItem";
            this.missedMappingToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.missedMappingToolStripMenuItem.Text = "Missed - Mapping";
            this.missedMappingToolStripMenuItem.Click += new System.EventHandler(this.missedMappingToolStripMenuItem_Click);
            // 
            // reMappingToolStripMenuItem2
            // 
            this.reMappingToolStripMenuItem2.Name = "reMappingToolStripMenuItem2";
            this.reMappingToolStripMenuItem2.Size = new System.Drawing.Size(235, 26);
            this.reMappingToolStripMenuItem2.Text = "Re-Mapping";
            this.reMappingToolStripMenuItem2.Click += new System.EventHandler(this.reMappingToolStripMenuItem2_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLoginName,
            this.stripProjectName});
            this.statusStrip.Location = new System.Drawing.Point(0, 668);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1434, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // stripLoginName
            // 
            this.stripLoginName.Name = "stripLoginName";
            this.stripLoginName.Size = new System.Drawing.Size(78, 20);
            this.stripLoginName.Text = "UserName";
            // 
            // stripProjectName
            // 
            this.stripProjectName.Name = "stripProjectName";
            this.stripProjectName.Size = new System.Drawing.Size(95, 20);
            this.stripProjectName.Text = "ProjectName";
            // 
            // fundTransferRequestToolStripMenuItem
            // 
            this.fundTransferRequestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subContractorsToolStripMenuItem});
            this.fundTransferRequestToolStripMenuItem.Name = "fundTransferRequestToolStripMenuItem";
            this.fundTransferRequestToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.fundTransferRequestToolStripMenuItem.Text = "FTR";
            // 
            // subContractorsToolStripMenuItem
            // 
            this.subContractorsToolStripMenuItem.Name = "subContractorsToolStripMenuItem";
            this.subContractorsToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.subContractorsToolStripMenuItem.Text = "Sub Contractors";
            this.subContractorsToolStripMenuItem.Click += new System.EventHandler(this.subContractorsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1434, 693);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Flow | Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuCashFlow;
        private System.Windows.Forms.ToolStripMenuItem viewCashFlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stripLoginName;
        private System.Windows.Forms.ToolStripStatusLabel stripProjectName;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mapLedgerCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reMappingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curentMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subContractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentMappingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem missedMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reMappingToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fundTransferRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subContractorsToolStripMenuItem;
    }
}



