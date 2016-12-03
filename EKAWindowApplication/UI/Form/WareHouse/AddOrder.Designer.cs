namespace EKAWindowApplication.UI.Form.WareHouse
{
    partial class AddOrder
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
            this.breMaterial = new Telerik.WinControls.UI.RadBrowseEditor();
            this.breWareHouse = new Telerik.WinControls.UI.RadBrowseEditor();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.lblFromWareHouse = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.lblQty = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breWareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFromWareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Location = new System.Drawing.Point(0, 276);
            this.pnlSelect.Size = new System.Drawing.Size(396, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 13);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(63, 13);
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // breMaterial
            // 
            this.breMaterial.Location = new System.Drawing.Point(114, 63);
            this.breMaterial.Name = "breMaterial";
            this.breMaterial.Size = new System.Drawing.Size(181, 24);
            this.breMaterial.TabIndex = 9;
            this.breMaterial.Text = "radBrowseEditor1";
            this.breMaterial.Click += new System.EventHandler(this.breMaterial_Click);
            // 
            // breWareHouse
            // 
            this.breWareHouse.Location = new System.Drawing.Point(114, 152);
            this.breWareHouse.Name = "breWareHouse";
            this.breWareHouse.Size = new System.Drawing.Size(181, 24);
            this.breWareHouse.TabIndex = 10;
            this.breWareHouse.Text = "radBrowseEditor1";
            this.breWareHouse.Click += new System.EventHandler(this.breWareHouse_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(301, 63);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(29, 22);
            this.radLabel1.TabIndex = 11;
            this.radLabel1.Text = "کالا:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(301, 154);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(48, 22);
            this.radLabel2.TabIndex = 12;
            this.radLabel2.Text = "به انبار:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFromWareHouse
            // 
            this.lblFromWareHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFromWareHouse.Location = new System.Drawing.Point(187, 130);
            this.lblFromWareHouse.Name = "lblFromWareHouse";
            this.lblFromWareHouse.Size = new System.Drawing.Size(2, 2);
            this.lblFromWareHouse.TabIndex = 12;
            this.lblFromWareHouse.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(301, 126);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(46, 22);
            this.radLabel4.TabIndex = 12;
            this.radLabel4.Text = "از انبار:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(301, 98);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(42, 22);
            this.radLabel3.TabIndex = 13;
            this.radLabel3.Text = "مقدار:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQty
            // 
            this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQty.Location = new System.Drawing.Point(187, 102);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(2, 2);
            this.lblQty.TabIndex = 14;
            this.lblQty.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 331);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblFromWareHouse);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.breWareHouse);
            this.Controls.Add(this.breMaterial);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddOrder";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Tag = "ثبت حواله";
            this.Text = "ثبت حواله";
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.breMaterial, 0);
            this.Controls.SetChildIndex(this.breWareHouse, 0);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.lblFromWareHouse, 0);
            this.Controls.SetChildIndex(this.lblQty, 0);
            this.Controls.SetChildIndex(this.radLabel4, 0);
            this.Controls.SetChildIndex(this.radLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breWareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFromWareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadBrowseEditor breMaterial;
        private Telerik.WinControls.UI.RadBrowseEditor breWareHouse;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lblFromWareHouse;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel lblQty;
    }
}
