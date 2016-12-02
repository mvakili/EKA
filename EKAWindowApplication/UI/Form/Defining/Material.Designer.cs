namespace EKAWindowApplication.UI.Form.Defining
{
    partial class Material
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvList = new Telerik.WinControls.UI.RadGridView();
            this.txtMaterialID = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.breMaterialGroup = new Telerik.WinControls.UI.RadBrowseEditor();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breMaterialGroup)).BeginInit();
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
            this.pnlSearch.PanelContainer.Controls.Add(this.breMaterialGroup);
            this.pnlSearch.PanelContainer.Controls.Add(this.label2);
            this.pnlSearch.PanelContainer.Controls.Add(this.txtMaterialID);
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
            gridViewTextBoxColumn1.FieldName = "MaterialID";
            gridViewTextBoxColumn1.HeaderText = "کد کالا";
            gridViewTextBoxColumn1.Name = "MaterialID";
            gridViewTextBoxColumn1.Width = 245;
            gridViewTextBoxColumn2.FieldName = "GroupName";
            gridViewTextBoxColumn2.HeaderText = "گروه کالایی";
            gridViewTextBoxColumn2.Name = "GroupName";
            gridViewTextBoxColumn2.Width = 277;
            gridViewTextBoxColumn3.FieldName = "Qty";
            gridViewTextBoxColumn3.HeaderText = "مقدار";
            gridViewTextBoxColumn3.Name = "Qty";
            gridViewTextBoxColumn3.Width = 219;
            gridViewTextBoxColumn4.FieldName = "Unit";
            gridViewTextBoxColumn4.HeaderText = "واحد";
            gridViewTextBoxColumn4.Name = "Unit";
            gridViewTextBoxColumn4.Width = 187;
            gridViewTextBoxColumn5.FieldName = "WareHouseName";
            gridViewTextBoxColumn5.HeaderText = "انبار";
            gridViewTextBoxColumn5.Name = "WareHouseName";
            gridViewTextBoxColumn5.Width = 47;
            this.rgvList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.rgvList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvList.Name = "rgvList";
            this.rgvList.ReadOnly = true;
            this.rgvList.Size = new System.Drawing.Size(992, 289);
            this.rgvList.TabIndex = 4;
            this.rgvList.Text = "radGridView1";
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtMaterialID.Location = new System.Drawing.Point(837, 10);
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.Size = new System.Drawing.Size(103, 24);
            this.txtMaterialID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(940, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "کد کالا:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(758, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "گروه کالایی:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // breMaterialGroup
            // 
            this.breMaterialGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.breMaterialGroup.Location = new System.Drawing.Point(577, 10);
            this.breMaterialGroup.Name = "breMaterialGroup";
            this.breMaterialGroup.Size = new System.Drawing.Size(181, 24);
            this.breMaterialGroup.TabIndex = 8;
            this.breMaterialGroup.Text = "radBrowseEditor1";
            this.breMaterialGroup.Click += new System.EventHandler(this.breMaterialGroup_Click);
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(992, 558);
            this.Controls.Add(this.rgvList);
            this.Name = "Material";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Tag = "تعریف کالا";
            this.Text = "تعریف کالا";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breMaterialGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvList;
        private Telerik.WinControls.UI.RadTextBox txtMaterialID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadBrowseEditor breMaterialGroup;
    }
}
