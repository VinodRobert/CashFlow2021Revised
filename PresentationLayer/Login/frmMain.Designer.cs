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
            this.fundTransferRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wORKSHEETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCurrentMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapReMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadGSTCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lCDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledgerMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.unMappedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fundTransferRequestToolStripMenuItem,
            this.utilityToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1434, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fundTransferRequestToolStripMenuItem
            // 
            this.fundTransferRequestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wORKSHEETToolStripMenuItem});
            this.fundTransferRequestToolStripMenuItem.Name = "fundTransferRequestToolStripMenuItem";
            this.fundTransferRequestToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.fundTransferRequestToolStripMenuItem.Text = "FTR";
            // 
            // wORKSHEETToolStripMenuItem
            // 
            this.wORKSHEETToolStripMenuItem.Name = "wORKSHEETToolStripMenuItem";
            this.wORKSHEETToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.wORKSHEETToolStripMenuItem.Text = "Work Sheet";
            this.wORKSHEETToolStripMenuItem.Click += new System.EventHandler(this.wORKSHEETToolStripMenuItem_Click);
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mappingToolStripMenuItem,
            this.uploadGSTCreditToolStripMenuItem,
            this.userInputToolStripMenuItem,
            this.lCDetailsToolStripMenuItem,
            this.ledgerMappingToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // mappingToolStripMenuItem
            // 
            this.mappingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCurrentMappingToolStripMenuItem,
            this.unMappedToolStripMenuItem,
            this.mapReMappingToolStripMenuItem});
            this.mappingToolStripMenuItem.Name = "mappingToolStripMenuItem";
            this.mappingToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.mappingToolStripMenuItem.Text = "Mapping";
            // 
            // viewCurrentMappingToolStripMenuItem
            // 
            this.viewCurrentMappingToolStripMenuItem.Name = "viewCurrentMappingToolStripMenuItem";
            this.viewCurrentMappingToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.viewCurrentMappingToolStripMenuItem.Text = "View Current Mapping";
            this.viewCurrentMappingToolStripMenuItem.Click += new System.EventHandler(this.viewCurrentMappingToolStripMenuItem_Click);
            // 
            // mapReMappingToolStripMenuItem
            // 
            this.mapReMappingToolStripMenuItem.Name = "mapReMappingToolStripMenuItem";
            this.mapReMappingToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.mapReMappingToolStripMenuItem.Text = "Map / Re-Mapping";
            this.mapReMappingToolStripMenuItem.Click += new System.EventHandler(this.mapReMappingToolStripMenuItem_Click);
            // 
            // uploadGSTCreditToolStripMenuItem
            // 
            this.uploadGSTCreditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.uploadToolStripMenuItem});
            this.uploadGSTCreditToolStripMenuItem.Name = "uploadGSTCreditToolStripMenuItem";
            this.uploadGSTCreditToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.uploadGSTCreditToolStripMenuItem.Text = "GST Credit";
            this.uploadGSTCreditToolStripMenuItem.Click += new System.EventHandler(this.uploadGSTCreditToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // userInputToolStripMenuItem
            // 
            this.userInputToolStripMenuItem.Name = "userInputToolStripMenuItem";
            this.userInputToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.userInputToolStripMenuItem.Text = "User Input";
            this.userInputToolStripMenuItem.Click += new System.EventHandler(this.userInputToolStripMenuItem_Click);
            // 
            // lCDetailsToolStripMenuItem
            // 
            this.lCDetailsToolStripMenuItem.Name = "lCDetailsToolStripMenuItem";
            this.lCDetailsToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.lCDetailsToolStripMenuItem.Text = "LC Details";
            this.lCDetailsToolStripMenuItem.Click += new System.EventHandler(this.lCDetailsToolStripMenuItem_Click);
            // 
            // ledgerMappingToolStripMenuItem
            // 
            this.ledgerMappingToolStripMenuItem.Name = "ledgerMappingToolStripMenuItem";
            this.ledgerMappingToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.ledgerMappingToolStripMenuItem.Text = "Ledger Mapping";
            this.ledgerMappingToolStripMenuItem.Click += new System.EventHandler(this.ledgerMappingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLoginName});
            this.statusStrip.Location = new System.Drawing.Point(0, 665);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1434, 28);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // stripLoginName
            // 
            this.stripLoginName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripLoginName.ForeColor = System.Drawing.Color.Red;
            this.stripLoginName.Name = "stripLoginName";
            this.stripLoginName.Size = new System.Drawing.Size(102, 23);
            this.stripLoginName.Text = "UserName";
            // 
            // unMappedToolStripMenuItem
            // 
            this.unMappedToolStripMenuItem.Name = "unMappedToolStripMenuItem";
            this.unMappedToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.unMappedToolStripMenuItem.Text = "Un Mapped";
            this.unMappedToolStripMenuItem.Click += new System.EventHandler(this.unMappedToolStripMenuItem_Click);
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
            this.Text = "FTR  | Menu";
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
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stripLoginName;
        private System.Windows.Forms.ToolStripMenuItem fundTransferRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wORKSHEETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCurrentMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapReMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadGSTCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lCDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledgerMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unMappedToolStripMenuItem;
    }
}



