namespace EKAWindowApplication.UI.Form.Defining
{
    partial class AddOrEditMaterial
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
            this.txtQty = new Telerik.WinControls.UI.RadTextBox();
            this.breMaterialGroup = new Telerik.WinControls.UI.RadBrowseEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.lblUnitName = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breMaterialGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUnitName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Location = new System.Drawing.Point(0, 119);
            this.pnlSelect.Size = new System.Drawing.Size(386, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(283, 31);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(76, 22);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "گروه کالایی:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(96, 61);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(181, 24);
            this.txtQty.TabIndex = 6;
            // 
            // breMaterialGroup
            // 
            this.breMaterialGroup.Location = new System.Drawing.Point(96, 31);
            this.breMaterialGroup.Name = "breMaterialGroup";
            this.breMaterialGroup.Size = new System.Drawing.Size(181, 24);
            this.breMaterialGroup.TabIndex = 7;
            this.breMaterialGroup.Text = "radBrowseEditor1";
            this.breMaterialGroup.Click += new System.EventHandler(this.breMaterialGroup_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(283, 63);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(42, 22);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "مقدار:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUnitName
            // 
            this.lblUnitName.Location = new System.Drawing.Point(22, 63);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(2, 2);
            this.lblUnitName.TabIndex = 8;
            this.lblUnitName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddOrEditMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 174);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.breMaterialGroup);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.radLabel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddOrEditMaterial";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Tag = "افزودن / ویرایش کالا";
            this.Text = "افزودن / ویرایش کالا";
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.txtQty, 0);
            this.Controls.SetChildIndex(this.breMaterialGroup, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.lblUnitName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breMaterialGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUnitName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtQty;
        private Telerik.WinControls.UI.RadBrowseEditor breMaterialGroup;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lblUnitName;
    }
}
