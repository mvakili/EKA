namespace EKAWindowApplication.UI.Form.User
{
    partial class User
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvList = new Telerik.WinControls.UI.RadGridView();
            this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.chbIsNotActive = new Telerik.WinControls.UI.RadCheckBox();
            this.chbIsActive = new Telerik.WinControls.UI.RadCheckBox();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.chbIsNotAdmin = new Telerik.WinControls.UI.RadCheckBox();
            this.chbIsAdmin = new Telerik.WinControls.UI.RadCheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsNotActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsNotAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsAdmin)).BeginInit();
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
            this.pnlSearch.PanelContainer.Controls.Add(this.radPanel1);
            this.pnlSearch.PanelContainer.Controls.Add(this.txtUserName);
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
            gridViewTextBoxColumn1.FieldName = "UserID";
            gridViewTextBoxColumn1.HeaderText = "کد کاربری";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "UserID";
            gridViewTextBoxColumn1.Width = 48;
            gridViewTextBoxColumn2.FieldName = "UserName";
            gridViewTextBoxColumn2.HeaderText = "نام کاربری";
            gridViewTextBoxColumn2.Name = "UserName";
            gridViewTextBoxColumn2.Width = 66;
            gridViewTextBoxColumn3.FieldName = "FirstName";
            gridViewTextBoxColumn3.HeaderText = "نام";
            gridViewTextBoxColumn3.Name = "FirstName";
            gridViewTextBoxColumn3.Width = 26;
            gridViewTextBoxColumn4.FieldName = "LastName";
            gridViewTextBoxColumn4.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumn4.Name = "LastName";
            gridViewTextBoxColumn4.Width = 83;
            gridViewTextBoxColumn5.FieldName = "IsActive";
            gridViewTextBoxColumn5.HeaderText = "فعال";
            gridViewTextBoxColumn5.Name = "IsActive";
            gridViewTextBoxColumn5.Width = 37;
            gridViewTextBoxColumn6.FieldName = "IsAdmin";
            gridViewTextBoxColumn6.HeaderText = "مدیر";
            gridViewTextBoxColumn6.Name = "IsAdmin";
            gridViewTextBoxColumn6.Width = 35;
            gridViewTextBoxColumn7.FieldName = "InsertDate";
            gridViewTextBoxColumn7.HeaderText = "تاریخ عضویت";
            gridViewTextBoxColumn7.Name = "InsertDate";
            gridViewTextBoxColumn7.Width = 729;
            this.rgvList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.rgvList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvList.Name = "rgvList";
            this.rgvList.ReadOnly = true;
            this.rgvList.Size = new System.Drawing.Size(992, 289);
            this.rgvList.TabIndex = 4;
            this.rgvList.Text = "radGridView1";
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtUserName.Location = new System.Drawing.Point(816, 10);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(103, 24);
            this.txtUserName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(919, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "نام کاربری:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radLabel6);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radPanel2);
            this.radPanel1.Controls.Add(this.radPanel3);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel1.Location = new System.Drawing.Point(599, 10);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(217, 105);
            this.radPanel1.TabIndex = 6;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(175, -1);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(36, 22);
            this.radLabel6.TabIndex = 25;
            this.radLabel6.Text = "مدیر:";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(175, 31);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(39, 22);
            this.radLabel2.TabIndex = 24;
            this.radLabel2.Text = "فعال:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.chbIsNotActive);
            this.radPanel2.Controls.Add(this.chbIsActive);
            this.radPanel2.Location = new System.Drawing.Point(3, 28);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(163, 30);
            this.radPanel2.TabIndex = 27;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // chbIsNotActive
            // 
            this.chbIsNotActive.Location = new System.Drawing.Point(75, 3);
            this.chbIsNotActive.Name = "chbIsNotActive";
            this.chbIsNotActive.Size = new System.Drawing.Size(40, 22);
            this.chbIsNotActive.TabIndex = 15;
            this.chbIsNotActive.TabStop = false;
            this.chbIsNotActive.Text = "خیر";
            // 
            // chbIsActive
            // 
            this.chbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsActive.Location = new System.Drawing.Point(119, 3);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(38, 22);
            this.chbIsActive.TabIndex = 14;
            this.chbIsActive.Text = "بله";
            this.chbIsActive.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.chbIsNotAdmin);
            this.radPanel3.Controls.Add(this.chbIsAdmin);
            this.radPanel3.Location = new System.Drawing.Point(3, -1);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(163, 28);
            this.radPanel3.TabIndex = 26;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // chbIsNotAdmin
            // 
            this.chbIsNotAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsNotAdmin.Location = new System.Drawing.Point(75, 3);
            this.chbIsNotAdmin.Name = "chbIsNotAdmin";
            this.chbIsNotAdmin.Size = new System.Drawing.Size(40, 22);
            this.chbIsNotAdmin.TabIndex = 15;
            this.chbIsNotAdmin.Text = "خیر";
            this.chbIsNotAdmin.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // chbIsAdmin
            // 
            this.chbIsAdmin.Location = new System.Drawing.Point(119, 3);
            this.chbIsAdmin.Name = "chbIsAdmin";
            this.chbIsAdmin.Size = new System.Drawing.Size(38, 22);
            this.chbIsAdmin.TabIndex = 14;
            this.chbIsAdmin.TabStop = false;
            this.chbIsAdmin.Text = "بله";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(992, 558);
            this.Controls.Add(this.rgvList);
            this.Name = "User";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Tag = "تعریف کاربر";
            this.Text = "تعریف کاربر";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsNotActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsNotAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvList;
        private Telerik.WinControls.UI.RadTextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadCheckBox chbIsNotActive;
        private Telerik.WinControls.UI.RadCheckBox chbIsActive;
        private Telerik.WinControls.UI.RadCheckBox chbIsNotAdmin;
        private Telerik.WinControls.UI.RadCheckBox chbIsAdmin;
    }
}
