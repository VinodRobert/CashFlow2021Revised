namespace CashFlow
{
    partial class frmCreditorReMapping
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
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.chkListLedgerCode = new Syncfusion.WinForms.ListView.SfListView();
            this.cmbCashFlowMarkers = new Syncfusion.Windows.Forms.Tools.MultiColumnComboBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblConfirmYesNo = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCashFlowMarkers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creditor  Re-Mapping";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Party Code(s) ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select CashFlow Marker";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "Button";
            this.btnSave.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(190, 675);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 28);
            this.btnSave.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Update";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(344, 675);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Red;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkListLedgerCode
            // 
            this.chkListLedgerCode.AccessibleName = "ScrollControl";
            this.chkListLedgerCode.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListLedgerCode.Location = new System.Drawing.Point(190, 61);
            this.chkListLedgerCode.Name = "chkListLedgerCode";
            this.chkListLedgerCode.Size = new System.Drawing.Size(742, 411);
            this.chkListLedgerCode.TabIndex = 9;
            this.chkListLedgerCode.Text = "sfListView1";
            // 
            // cmbCashFlowMarkers
            // 
            this.cmbCashFlowMarkers.AllowFiltering = false;
            this.cmbCashFlowMarkers.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cmbCashFlowMarkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.cmbCashFlowMarkers.BeforeTouchSize = new System.Drawing.Size(742, 25);
            this.cmbCashFlowMarkers.DropDownWidth = 1300;
            this.cmbCashFlowMarkers.Filter = null;
            this.cmbCashFlowMarkers.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCashFlowMarkers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCashFlowMarkers.Location = new System.Drawing.Point(190, 490);
            this.cmbCashFlowMarkers.MaxDropDownItems = 15;
            this.cmbCashFlowMarkers.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cmbCashFlowMarkers.Name = "cmbCashFlowMarkers";
            this.cmbCashFlowMarkers.ScrollMetroColorTable = metroColorTable1;
            this.cmbCashFlowMarkers.Size = new System.Drawing.Size(742, 25);
            this.cmbCashFlowMarkers.Style = Syncfusion.Windows.Forms.VisualStyle.Office2010;
            this.cmbCashFlowMarkers.TabIndex = 10;
            this.cmbCashFlowMarkers.Text = "multiColumnComboBox1";
            this.cmbCashFlowMarkers.ThemeName = "Office2010";
            this.cmbCashFlowMarkers.SelectedIndexChanged += new System.EventHandler(this.cmbCashFlowMarkers_SelectedIndexChanged);
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Blue;
            this.lblConfirm.Location = new System.Drawing.Point(12, 573);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(54, 19);
            this.lblConfirm.TabIndex = 11;
            this.lblConfirm.Text = "label4";
            // 
            // lblConfirmYesNo
            // 
            this.lblConfirmYesNo.AutoSize = true;
            this.lblConfirmYesNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmYesNo.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmYesNo.Location = new System.Drawing.Point(13, 606);
            this.lblConfirmYesNo.Name = "lblConfirmYesNo";
            this.lblConfirmYesNo.Size = new System.Drawing.Size(159, 19);
            this.lblConfirmYesNo.TabIndex = 12;
            this.lblConfirmYesNo.Text = "Confirm (YES/NO) ?";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(190, 602);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(100, 22);
            this.txtConfirm.TabIndex = 13;
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            // 
            // frmCreditorReMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 715);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblConfirmYesNo);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.cmbCashFlowMarkers);
            this.Controls.Add(this.chkListLedgerCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreditorReMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creditor | Re Mapping";
            this.Load += new System.EventHandler(this.frmLedgerMapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCashFlowMarkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.ListView.SfListView chkListLedgerCode;
        private Syncfusion.Windows.Forms.Tools.MultiColumnComboBox cmbCashFlowMarkers;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblConfirmYesNo;
        private System.Windows.Forms.TextBox txtConfirm;
    }
}