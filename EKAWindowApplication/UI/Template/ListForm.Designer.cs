namespace EKAWindowApplication.UI.Template
{
    partial class ListForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            this.pnlSelect = new Telerik.WinControls.UI.RadPanel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnAccept = new Telerik.WinControls.UI.RadButton();
            this.ControlsContainer = new Telerik.WinControls.UI.CollapsiblePanelControlsContainer();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnRemove = new Telerik.WinControls.UI.RadButton();
            this.pnlOperation = new Telerik.WinControls.UI.RadPanel();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.pnlSearch = new Telerik.WinControls.UI.RadCollapsiblePanel();
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
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.btnCancel);
            this.pnlSelect.Controls.Add(this.btnAccept);
            this.pnlSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSelect.Location = new System.Drawing.Point(0, 456);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlSelect.Size = new System.Drawing.Size(974, 55);
            this.pnlSelect.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(508, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "رد";
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccept.Location = new System.Drawing.Point(402, 13);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(80, 30);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "تایید";
            // 
            // ControlsContainer
            // 
            this.ControlsContainer.Location = new System.Drawing.Point(0, 26);
            this.ControlsContainer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ControlsContainer.Name = "ControlsContainer";
            this.ControlsContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ControlsContainer.Size = new System.Drawing.Size(974, 121);
            this.ControlsContainer.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(882, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "افزودن";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(796, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "ویرایش";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(710, 13);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 30);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "حذف";
            // 
            // pnlOperation
            // 
            this.pnlOperation.Controls.Add(this.btnRemove);
            this.pnlOperation.Controls.Add(this.btnEdit);
            this.pnlOperation.Controls.Add(this.btnAdd);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlOperation.Size = new System.Drawing.Size(974, 55);
            this.pnlOperation.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(7, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جستجو";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.HeaderText = "جستجو";
            this.pnlSearch.Location = new System.Drawing.Point(0, 55);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.OwnerBoundsCache = new System.Drawing.Rectangle(0, 55, 731, 250);
            // 
            // pnlSearch.PanelContainer
            // 
            this.pnlSearch.PanelContainer.Controls.Add(this.btnSearch);
            this.pnlSearch.PanelContainer.Size = new System.Drawing.Size(972, 142);
            this.pnlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlSearch.Size = new System.Drawing.Size(974, 171);
            this.pnlSearch.TabIndex = 1;
            this.pnlSearch.Text = "جستجو";
            // 
            // ListForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 511);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlOperation);
            this.Name = "ListForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
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
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Telerik.WinControls.UI.RadPanel pnlSelect;
        public Telerik.WinControls.UI.RadButton btnCancel;
        public Telerik.WinControls.UI.RadButton btnAccept;
        public Telerik.WinControls.UI.CollapsiblePanelControlsContainer ControlsContainer;
        public Telerik.WinControls.UI.RadButton btnAdd;
        public Telerik.WinControls.UI.RadButton btnEdit;
        public Telerik.WinControls.UI.RadButton btnRemove;
        public Telerik.WinControls.UI.RadPanel pnlOperation;
        public Telerik.WinControls.UI.RadButton btnSearch;
        public Telerik.WinControls.UI.RadCollapsiblePanel pnlSearch;
    }
}
