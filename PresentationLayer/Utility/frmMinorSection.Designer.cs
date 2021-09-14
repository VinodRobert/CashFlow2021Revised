namespace CashFlow
{
    partial class frmMinorSection
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridSections = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.lblOrder = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtMinorSection = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbMajorSection = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtPosition = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.btnDelete = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinorSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMajorSection)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel1.Location = new System.Drawing.Point(381, 20);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(142, 23);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Minor Section";
            // 
            // gridSections
            // 
            this.gridSections.AccessibleName = "Table";
            gridTextColumn1.HeaderText = "Major Section";
            gridTextColumn1.MappingName = "MAJORSECTION";
            gridTextColumn1.Width = 300D;
            gridTextColumn2.HeaderText = "Order #";
            gridTextColumn2.MappingName = "POSITION";
            gridTextColumn2.Width = 100D;
            gridTextColumn3.HeaderText = "Minor Section";
            gridTextColumn3.MappingName = "MINORSECTION";
            gridTextColumn3.Width = 350D;
            gridTextColumn4.HeaderText = "MinorSectionID";
            gridTextColumn4.MappingName = "MINORSECTIONID";
            gridTextColumn4.Visible = false;
            gridTextColumn4.Width = 0D;
            this.gridSections.Columns.Add(gridTextColumn1);
            this.gridSections.Columns.Add(gridTextColumn2);
            this.gridSections.Columns.Add(gridTextColumn3);
            this.gridSections.Columns.Add(gridTextColumn4);
            this.gridSections.Location = new System.Drawing.Point(56, 237);
            this.gridSections.Name = "gridSections";
            this.gridSections.PreviewRowHeight = 35;
            this.gridSections.Size = new System.Drawing.Size(797, 342);
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
            this.autoLabel2.Location = new System.Drawing.Point(56, 78);
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
            this.btnAdd.Location = new System.Drawing.Point(576, 78);
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
            // txtMinorSection
            // 
            this.txtMinorSection.BeforeTouchSize = new System.Drawing.Size(397, 24);
            this.txtMinorSection.Location = new System.Drawing.Point(173, 126);
            this.txtMinorSection.Name = "txtMinorSection";
            this.txtMinorSection.Size = new System.Drawing.Size(397, 24);
            this.txtMinorSection.TabIndex = 9;
            // 
            // autoLabel3
            // 
            this.autoLabel3.Location = new System.Drawing.Point(56, 133);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(90, 17);
            this.autoLabel3.TabIndex = 8;
            this.autoLabel3.Text = "Minor Section";
            // 
            // cmbMajorSection
            // 
            this.cmbMajorSection.DisplayMember = "MajorSection";
            this.cmbMajorSection.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbMajorSection.Location = new System.Drawing.Point(174, 78);
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
            this.btnDelete.Location = new System.Drawing.Point(728, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMinorSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 638);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.cmbMajorSection);
            this.Controls.Add(this.txtMinorSection);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridSections);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMinorSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minor Section";
            this.Load += new System.EventHandler(this.frmMinorSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinorSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMajorSection)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMinorSection;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.WinForms.ListView.SfComboBox cmbMajorSection;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtPosition;
        private Syncfusion.WinForms.Controls.SfButton btnDelete;
    }
}