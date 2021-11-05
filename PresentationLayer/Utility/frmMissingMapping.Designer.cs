namespace CashFlow
{
    partial class frmMissingMapping
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.lblMajorCategory = new System.Windows.Forms.Label();
            this.cmbMajorCategory = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblMinorCategory = new System.Windows.Forms.Label();
            this.cmbMinorCategory = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblVendorType = new System.Windows.Forms.Label();
            this.chkListParties = new Syncfusion.WinForms.ListView.SfListView();
            this.lblPartyCodes = new System.Windows.Forms.Label();
            this.cmbVendorType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.rdUnMapped = new System.Windows.Forms.RadioButton();
            this.rdRemap = new System.Windows.Forms.RadioButton();
            this.btnFetch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMajorCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMinorCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVendorType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mapping Vendors";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "Button";
            this.btnSave.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(964, 220);
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
            this.btnClose.Location = new System.Drawing.Point(964, 56);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Red;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMajorCategory
            // 
            this.lblMajorCategory.AutoSize = true;
            this.lblMajorCategory.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajorCategory.Location = new System.Drawing.Point(8, 503);
            this.lblMajorCategory.Name = "lblMajorCategory";
            this.lblMajorCategory.Size = new System.Drawing.Size(117, 22);
            this.lblMajorCategory.TabIndex = 14;
            this.lblMajorCategory.Text = "Major Category";
            // 
            // cmbMajorCategory
            // 
            this.cmbMajorCategory.DisplayMember = "MAJORCATEGORY";
            this.cmbMajorCategory.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbMajorCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMajorCategory.Location = new System.Drawing.Point(190, 503);
            this.cmbMajorCategory.Name = "cmbMajorCategory";
            this.cmbMajorCategory.Size = new System.Drawing.Size(541, 32);
            this.cmbMajorCategory.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMajorCategory.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMajorCategory.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMajorCategory.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMajorCategory.TabIndex = 15;
            this.cmbMajorCategory.ValueMember = "MAJORCATEGORY";
            this.cmbMajorCategory.SelectedIndexChanged += new System.EventHandler(this.cmbMajorCategory_SelectedIndexChanged);
            // 
            // lblMinorCategory
            // 
            this.lblMinorCategory.AutoSize = true;
            this.lblMinorCategory.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinorCategory.Location = new System.Drawing.Point(8, 551);
            this.lblMinorCategory.Name = "lblMinorCategory";
            this.lblMinorCategory.Size = new System.Drawing.Size(118, 22);
            this.lblMinorCategory.TabIndex = 16;
            this.lblMinorCategory.Text = "Minor Category";
            // 
            // cmbMinorCategory
            // 
            this.cmbMinorCategory.DisplayMember = "MINORCATEGORY";
            this.cmbMinorCategory.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbMinorCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinorCategory.Location = new System.Drawing.Point(190, 551);
            this.cmbMinorCategory.Name = "cmbMinorCategory";
            this.cmbMinorCategory.Size = new System.Drawing.Size(541, 32);
            this.cmbMinorCategory.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinorCategory.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinorCategory.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMinorCategory.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinorCategory.TabIndex = 17;
            this.cmbMinorCategory.ValueMember = "MAPPINGID";
            this.cmbMinorCategory.SelectedIndexChanged += new System.EventHandler(this.cmbMinorCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(8, 601);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 22);
            this.lblCategory.TabIndex = 18;
            this.lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DisplayMember = "CATEGORY";
            this.cmbCategory.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.Location = new System.Drawing.Point(190, 601);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(541, 32);
            this.cmbCategory.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategory.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.TabIndex = 19;
            this.cmbCategory.ValueMember = "MAPPINGID";
            // 
            // lblVendorType
            // 
            this.lblVendorType.AutoSize = true;
            this.lblVendorType.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorType.Location = new System.Drawing.Point(8, 56);
            this.lblVendorType.Name = "lblVendorType";
            this.lblVendorType.Size = new System.Drawing.Size(98, 22);
            this.lblVendorType.TabIndex = 20;
            this.lblVendorType.Text = "Vendor Type";
            // 
            // chkListParties
            // 
            this.chkListParties.AccessibleName = "ScrollControl";
            this.chkListParties.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListParties.Location = new System.Drawing.Point(190, 95);
            this.chkListParties.Name = "chkListParties";
            this.chkListParties.Size = new System.Drawing.Size(742, 386);
            this.chkListParties.TabIndex = 23;
            this.chkListParties.Text = "sfListView1";
            // 
            // lblPartyCodes
            // 
            this.lblPartyCodes.AutoSize = true;
            this.lblPartyCodes.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyCodes.Location = new System.Drawing.Point(8, 226);
            this.lblPartyCodes.Name = "lblPartyCodes";
            this.lblPartyCodes.Size = new System.Drawing.Size(154, 22);
            this.lblPartyCodes.TabIndex = 22;
            this.lblPartyCodes.Text = "Select Party Code(s) ";
            // 
            // cmbVendorType
            // 
            this.cmbVendorType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbVendorType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendorType.Location = new System.Drawing.Point(190, 56);
            this.cmbVendorType.Name = "cmbVendorType";
            this.cmbVendorType.Size = new System.Drawing.Size(226, 32);
            this.cmbVendorType.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendorType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendorType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbVendorType.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendorType.TabIndex = 21;
            // 
            // rdUnMapped
            // 
            this.rdUnMapped.AutoSize = true;
            this.rdUnMapped.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUnMapped.ForeColor = System.Drawing.Color.Red;
            this.rdUnMapped.Location = new System.Drawing.Point(476, 56);
            this.rdUnMapped.Name = "rdUnMapped";
            this.rdUnMapped.Size = new System.Drawing.Size(114, 23);
            this.rdUnMapped.TabIndex = 24;
            this.rdUnMapped.TabStop = true;
            this.rdUnMapped.Text = "Un-Mapped";
            this.rdUnMapped.UseVisualStyleBackColor = true;
            // 
            // rdRemap
            // 
            this.rdRemap.AutoSize = true;
            this.rdRemap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRemap.ForeColor = System.Drawing.Color.Blue;
            this.rdRemap.Location = new System.Drawing.Point(632, 56);
            this.rdRemap.Name = "rdRemap";
            this.rdRemap.Size = new System.Drawing.Size(118, 23);
            this.rdRemap.TabIndex = 25;
            this.rdRemap.TabStop = true;
            this.rdRemap.Text = "Re-Mapping";
            this.rdRemap.UseVisualStyleBackColor = true;
            // 
            // btnFetch
            // 
            this.btnFetch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetch.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnFetch.Location = new System.Drawing.Point(810, 56);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(122, 34);
            this.btnFetch.TabIndex = 26;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // frmMissingMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 715);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.rdRemap);
            this.Controls.Add(this.rdUnMapped);
            this.Controls.Add(this.chkListParties);
            this.Controls.Add(this.lblPartyCodes);
            this.Controls.Add(this.cmbVendorType);
            this.Controls.Add(this.lblVendorType);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbMinorCategory);
            this.Controls.Add(this.lblMinorCategory);
            this.Controls.Add(this.cmbMajorCategory);
            this.Controls.Add(this.lblMajorCategory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "frmMissingMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party | Re Mapping";
            this.Load += new System.EventHandler(this.frmLedgerMapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbMajorCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMinorCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVendorType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.Label lblMajorCategory;
        private Syncfusion.WinForms.ListView.SfComboBox cmbMajorCategory;
        private System.Windows.Forms.Label lblMinorCategory;
        private Syncfusion.WinForms.ListView.SfComboBox cmbMinorCategory;
        private System.Windows.Forms.Label lblCategory;
        private Syncfusion.WinForms.ListView.SfComboBox cmbCategory;
        private System.Windows.Forms.Label lblVendorType;
        private Syncfusion.WinForms.ListView.SfListView chkListParties;
        private System.Windows.Forms.Label lblPartyCodes;
        private Syncfusion.WinForms.ListView.SfComboBox cmbVendorType;
        private System.Windows.Forms.RadioButton rdUnMapped;
        private System.Windows.Forms.RadioButton rdRemap;
        private System.Windows.Forms.Button btnFetch;
    }
}