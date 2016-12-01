namespace EKAWindowApplication.UI.Form.Defining
{
    partial class UnitGroup
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvList = new Telerik.WinControls.UI.RadGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Location = new System.Drawing.Point(0, 503);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(498, 13);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(392, 13);
            // 
            // ControlsContainer
            // 
            this.ControlsContainer.Padding = new System.Windows.Forms.Padding(1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(861, 13);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(754, 13);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(647, 13);
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
            this.pnlSearch.PanelContainer.Location = new System.Drawing.Point(1, 1);
            this.pnlSearch.PanelContainer.Size = new System.Drawing.Size(990, 130);
            this.pnlSearch.Size = new System.Drawing.Size(992, 159);
            this.pnlSearch.Visible = false;
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
            gridViewTextBoxColumn1.FieldName = "UnitGroupID";
            gridViewTextBoxColumn1.HeaderText = "کد";
            gridViewTextBoxColumn1.Name = "UnitGroupID";
            gridViewTextBoxColumn1.Width = 551;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "نام";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 421;
            this.rgvList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.rgvList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvList.Name = "rgvList";
            this.rgvList.ReadOnly = true;
            this.rgvList.Size = new System.Drawing.Size(992, 289);
            this.rgvList.TabIndex = 4;
            this.rgvList.Text = "radGridView1";
            // 
            // UnitGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(992, 558);
            this.Controls.Add(this.rgvList);
            this.Name = "UnitGroup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Tag = "تعریف گروه واحدی";
            this.Text = "تعریف گروه واحدی";
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
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvList;
    }
}
