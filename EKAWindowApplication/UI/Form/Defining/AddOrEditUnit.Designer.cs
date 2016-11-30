namespace EKAWindowApplication.UI.Form.Defining
{
    partial class AddOrEditUnit
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.breUnitGroup = new Telerik.WinControls.UI.RadBrowseEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtFactor = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breUnitGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Location = new System.Drawing.Point(0, 149);
            this.pnlSelect.Size = new System.Drawing.Size(385, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 13);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(75, 13);
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(283, 31);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 22);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "نام واحد";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 24);
            this.txtName.TabIndex = 6;
            // 
            // breUnitGroup
            // 
            this.breUnitGroup.Location = new System.Drawing.Point(96, 59);
            this.breUnitGroup.Name = "breUnitGroup";
            this.breUnitGroup.Size = new System.Drawing.Size(181, 24);
            this.breUnitGroup.TabIndex = 7;
            this.breUnitGroup.Text = "radBrowseEditor1";
            this.breUnitGroup.Click += new System.EventHandler(this.breUnitGroup_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(283, 61);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(74, 22);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "گروه واحدی";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFactor
            // 
            this.txtFactor.Location = new System.Drawing.Point(96, 90);
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.NullText = "1";
            this.txtFactor.SelectionStart = 1;
            this.txtFactor.Size = new System.Drawing.Size(181, 24);
            this.txtFactor.TabIndex = 8;
            this.txtFactor.Text = "1";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(283, 92);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(45, 22);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "ضریب";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddOrEditUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 204);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txtFactor);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.breUnitGroup);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radLabel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddOrEditUnit";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Tag = "افزودن / ویرایش واحد";
            this.Text = "افزودن / ویرایش واحد";
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.breUnitGroup, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.txtFactor, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breUnitGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadBrowseEditor breUnitGroup;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtFactor;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
