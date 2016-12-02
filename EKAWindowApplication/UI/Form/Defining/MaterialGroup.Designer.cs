namespace EKAWindowApplication.UI.Form.Defining
{
    partial class MaterialGroup
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvList = new Telerik.WinControls.UI.RadGridView();
            this.txtMaterialGroupID = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkJustExists = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlsContainer)).BeginInit();
            this.ControlsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperation)).BeginInit();
            this.pnlOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.PanelContainer.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialGroupID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkJustExists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Location = new System.Drawing.Point(0, 503);
            // 
            // ControlsContainer
            // 
            this.ControlsContainer.Padding = new System.Windows.Forms.Padding(1);
            // 
            // btnAdd
            // 
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Size = new System.Drawing.Size(101, 105);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSearch
            // 
            // 
            // pnlSearch.PanelContainer
            // 
            this.pnlSearch.PanelContainer.Controls.Add(this.chkJustExists);
            this.pnlSearch.PanelContainer.Controls.Add(this.txtMaterialGroupID);
            this.pnlSearch.PanelContainer.Controls.Add(this.label1);
            this.pnlSearch.PanelContainer.Location = new System.Drawing.Point(1, 1);
            this.pnlSearch.PanelContainer.Size = new System.Drawing.Size(990, 130);
            this.pnlSearch.Size = new System.Drawing.Size(992, 159);
            // 
            // rgvList
            // 
            this.rgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvList.Location = new System.Drawing.Point(0, 214);
            // 
            // 
            // 
            this.rgvList.MasterTemplate.AllowAddNewRow = false;
            this.rgvList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "MaterialGroupID";
            gridViewTextBoxColumn1.HeaderText = "کد";
            gridViewTextBoxColumn1.Name = "MaterialGroupID";
            gridViewTextBoxColumn1.Width = 24;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "نام";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 27;
            gridViewTextBoxColumn3.FieldName = "AvailableAmount";
            gridViewTextBoxColumn3.HeaderText = "مقدار موجود";
            gridViewTextBoxColumn3.Name = "AvailableAmount";
            gridViewTextBoxColumn3.Width = 86;
            gridViewTextBoxColumn4.FieldName = "UnitName";
            gridViewTextBoxColumn4.HeaderText = "واحد";
            gridViewTextBoxColumn4.Name = "UnitName";
            gridViewTextBoxColumn4.Width = 837;
            this.rgvList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.rgvList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvList.Name = "rgvList";
            this.rgvList.ReadOnly = true;
            this.rgvList.Size = new System.Drawing.Size(992, 289);
            this.rgvList.TabIndex = 4;
            this.rgvList.Text = "radGridView1";
            // 
            // txtMaterialGroupID
            // 
            this.txtMaterialGroupID.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtMaterialGroupID.Location = new System.Drawing.Point(807, 10);
            this.txtMaterialGroupID.Name = "txtMaterialGroupID";
            this.txtMaterialGroupID.Size = new System.Drawing.Size(103, 24);
            this.txtMaterialGroupID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(910, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "کد گروه کالا:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkJustExists
            // 
            this.chkJustExists.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJustExists.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkJustExists.Location = new System.Drawing.Point(718, 10);
            this.chkJustExists.Name = "chkJustExists";
            this.chkJustExists.Size = new System.Drawing.Size(89, 22);
            this.chkJustExists.TabIndex = 8;
            this.chkJustExists.Text = "فقط موجود";
            this.chkJustExists.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // MaterialGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(992, 558);
            this.Controls.Add(this.rgvList);
            this.Name = "MaterialGroup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Tag = "تعریف گروه کالایی";
            this.Text = "تعریف گروه کالایی";
            this.Controls.SetChildIndex(this.pnlOperation, 0);
            this.Controls.SetChildIndex(this.pnlSearch, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.rgvList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlsContainer)).EndInit();
            this.ControlsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperation)).EndInit();
            this.pnlOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.pnlSearch.PanelContainer.ResumeLayout(false);
            this.pnlSearch.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialGroupID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkJustExists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvList;
        private Telerik.WinControls.UI.RadTextBox txtMaterialGroupID;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadCheckBox chkJustExists;
    }
}
