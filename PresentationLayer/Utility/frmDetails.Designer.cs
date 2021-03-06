namespace CashFlow
{
    partial class frmDetails
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridSections = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.lblOrder = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtDetails = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbMajorSection = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtPosition = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.btnDelete = new Syncfusion.WinForms.Controls.SfButton();
            this.cmbMinorSection = new Syncfusion.WinForms.ListView.SfComboBox();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMajorSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMinorSection)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel1.Location = new System.Drawing.Point(378, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(153, 23);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Details Section";
            // 
            // gridSections
            // 
            this.gridSections.AccessibleName = "Table";
            gridTextColumn8.HeaderText = "MajorSectionID";
            gridTextColumn8.MappingName = "MajorSectionID";
            gridTextColumn8.Visible = false;
            gridTextColumn8.Width = 0D;
            gridTextColumn9.HeaderText = "Major Section";
            gridTextColumn9.MappingName = "MAJORSECTION";
            gridTextColumn9.Width = 200D;
            gridTextColumn10.HeaderText = "MinorSectionID";
            gridTextColumn10.MappingName = "MinorSectionID";
            gridTextColumn10.Visible = false;
            gridTextColumn10.Width = 0D;
            gridTextColumn11.HeaderText = "Minor Section";
            gridTextColumn11.MappingName = "MINORSECTION";
            gridTextColumn11.Width = 300D;
            gridTextColumn12.HeaderText = "DetailsID";
            gridTextColumn12.MappingName = "DetailsID";
            gridTextColumn12.Visible = false;
            gridTextColumn12.Width = 0D;
            gridTextColumn13.HeaderText = "Order #";
            gridTextColumn13.MappingName = "Position";
            gridTextColumn13.Width = 70D;
            gridTextColumn14.HeaderText = "Details";
            gridTextColumn14.MappingName = "Details";
            gridTextColumn14.Width = 300D;
            this.gridSections.Columns.Add(gridTextColumn8);
            this.gridSections.Columns.Add(gridTextColumn9);
            this.gridSections.Columns.Add(gridTextColumn10);
            this.gridSections.Columns.Add(gridTextColumn11);
            this.gridSections.Columns.Add(gridTextColumn12);
            this.gridSections.Columns.Add(gridTextColumn13);
            this.gridSections.Columns.Add(gridTextColumn14);
            this.gridSections.Location = new System.Drawing.Point(12, 237);
            this.gridSections.Name = "gridSections";
            this.gridSections.PreviewRowHeight = 35;
            this.gridSections.Size = new System.Drawing.Size(876, 342);
            this.gridSections.TabIndex = 1;
            this.gridSections.Text = "sfDataGrid1";
            this.gridSections.DrawCell += new Syncfusion.WinForms.DataGrid.Events.DrawCellEventHandler(this.gridSections_DrawCell);
            this.gridSections.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridSections_QueryRowStyle);
            this.gridSections.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.gridSections_CellDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(749, 598);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 38);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Red;
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(56, 35);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(91, 17);
            this.autoLabel2.TabIndex = 3;
            this.autoLabel2.Text = "Major Section";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "Button";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(575, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 28);
            this.btnAdd.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.Location = new System.Drawing.Point(56, 190);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(188, 17);
            this.lblOrder.TabIndex = 6;
            this.lblOrder.Text = "Order (Keep Difference of 10)";
            // 
            // txtDetails
            // 
            this.txtDetails.BeforeTouchSize = new System.Drawing.Size(397, 24);
            this.txtDetails.Location = new System.Drawing.Point(173, 126);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(397, 24);
            this.txtDetails.TabIndex = 9;
            // 
            // autoLabel3
            // 
            this.autoLabel3.Location = new System.Drawing.Point(57, 75);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(90, 17);
            this.autoLabel3.TabIndex = 8;
            this.autoLabel3.Text = "Minor Section";
            // 
            // cmbMajorSection
            // 
            this.cmbMajorSection.DisplayMember = "MajorSection";
            this.cmbMajorSection.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbMajorSection.Location = new System.Drawing.Point(173, 35);
            this.cmbMajorSection.Name = "cmbMajorSection";
            this.cmbMajorSection.Size = new System.Drawing.Size(396, 32);
            this.cmbMajorSection.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMajorSection.TabIndex = 10;
            this.cmbMajorSection.ValueMember = "MajorSectionID";
            this.cmbMajorSection.SelectedIndexChanged += new System.EventHandler(this.cmbMajorSection_SelectedIndexChanged);
            // 
            // txtPosition
            // 
            this.txtPosition.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPosition.Location = new System.Drawing.Point(272, 183);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 24);
            this.txtPosition.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleName = "Button";
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(737, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbMinorSection
            // 
            this.cmbMinorSection.DisplayMember = "MinorSection";
            this.cmbMinorSection.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbMinorSection.Location = new System.Drawing.Point(174, 75);
            this.cmbMinorSection.Name = "cmbMinorSection";
            this.cmbMinorSection.Size = new System.Drawing.Size(396, 32);
            this.cmbMinorSection.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMinorSection.TabIndex = 13;
            this.cmbMinorSection.ValueMember = "MinorSectionID";
            this.cmbMinorSection.SelectedIndexChanged += new System.EventHandler(this.cmbMinorSection_SelectedIndexChanged);
            // 
            // autoLabel4
            // 
            this.autoLabel4.Location = new System.Drawing.Point(57, 126);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(47, 17);
            this.autoLabel4.TabIndex = 14;
            this.autoLabel4.Text = "Details";
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 638);
            this.Controls.Add(this.autoLabel4);
            this.Controls.Add(this.cmbMinorSection);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.cmbMajorSection);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridSections);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details Section";
            this.Load += new System.EventHandler(this.frmDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMajorSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMinorSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridSections;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.WinForms.Controls.SfButton btnAdd;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblOrder;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDetails;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.WinForms.ListView.SfComboBox cmbMajorSection;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtPosition;
        private Syncfusion.WinForms.Controls.SfButton btnDelete;
        private Syncfusion.WinForms.ListView.SfComboBox cmbMinorSection;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
    }
}