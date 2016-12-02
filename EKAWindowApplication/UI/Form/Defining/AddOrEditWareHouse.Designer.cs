namespace EKAWindowApplication.UI.Form.Defining
{
    partial class AddOrEditWareHouse
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
            this.breUser = new Telerik.WinControls.UI.RadBrowseEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.rbIsNotCountable = new Telerik.WinControls.UI.RadRadioButton();
            this.rbIsCountable = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.rbAllowReceiveFalse = new Telerik.WinControls.UI.RadRadioButton();
            this.rbAllowReceiveTrue = new Telerik.WinControls.UI.RadRadioButton();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.rbAllowSendFalse = new Telerik.WinControls.UI.RadRadioButton();
            this.rbAllowSendTrue = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).BeginInit();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbIsNotCountable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbIsCountable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllowReceiveFalse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllowReceiveTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllowSendFalse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllowSendTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Location = new System.Drawing.Point(0, 239);
            this.pnlSelect.Size = new System.Drawing.Size(385, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 13);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(91, 13);
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(264, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 22);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "نام انبار";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 24);
            this.txtName.TabIndex = 6;
            // 
            // breUser
            // 
            this.breUser.Location = new System.Drawing.Point(77, 61);
            this.breUser.Name = "breUser";
            this.breUser.Size = new System.Drawing.Size(181, 24);
            this.breUser.TabIndex = 7;
            this.breUser.Text = "radBrowseEditor1";
            this.breUser.Click += new System.EventHandler(this.breUser_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(264, 63);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(52, 22);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "مسئول:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radLabel6);
            this.radPanel1.Controls.Add(this.rbIsNotCountable);
            this.radPanel1.Controls.Add(this.rbIsCountable);
            this.radPanel1.Controls.Add(this.radLabel4);
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.radPanel2);
            this.radPanel1.Controls.Add(this.radPanel3);
            this.radPanel1.Location = new System.Drawing.Point(65, 97);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(308, 105);
            this.radPanel1.TabIndex = 15;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(199, 3);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(74, 22);
            this.radLabel6.TabIndex = 25;
            this.radLabel6.Text = "اجازه ارسال:";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // rbIsNotCountable
            // 
            this.rbIsNotCountable.Location = new System.Drawing.Point(78, 59);
            this.rbIsNotCountable.Name = "rbIsNotCountable";
            this.rbIsNotCountable.Size = new System.Drawing.Size(40, 22);
            this.rbIsNotCountable.TabIndex = 26;
            this.rbIsNotCountable.TabStop = false;
            this.rbIsNotCountable.Text = "خیر";
            // 
            // rbIsCountable
            // 
            this.rbIsCountable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbIsCountable.Location = new System.Drawing.Point(122, 59);
            this.rbIsCountable.Name = "rbIsCountable";
            this.rbIsCountable.Size = new System.Drawing.Size(38, 22);
            this.rbIsCountable.TabIndex = 25;
            this.rbIsCountable.Text = "بله";
            this.rbIsCountable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(199, 59);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(107, 22);
            this.radLabel4.TabIndex = 27;
            this.radLabel4.Text = "شمارش موجودی:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(199, 31);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(81, 22);
            this.radLabel3.TabIndex = 24;
            this.radLabel3.Text = "اجازه دریافت";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.rbAllowReceiveFalse);
            this.radPanel2.Controls.Add(this.rbAllowReceiveTrue);
            this.radPanel2.Location = new System.Drawing.Point(3, 28);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(163, 30);
            this.radPanel2.TabIndex = 27;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // rbAllowReceiveFalse
            // 
            this.rbAllowReceiveFalse.Location = new System.Drawing.Point(75, 3);
            this.rbAllowReceiveFalse.Name = "rbAllowReceiveFalse";
            this.rbAllowReceiveFalse.Size = new System.Drawing.Size(40, 22);
            this.rbAllowReceiveFalse.TabIndex = 15;
            this.rbAllowReceiveFalse.TabStop = false;
            this.rbAllowReceiveFalse.Text = "خیر";
            // 
            // rbAllowReceiveTrue
            // 
            this.rbAllowReceiveTrue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbAllowReceiveTrue.Location = new System.Drawing.Point(119, 3);
            this.rbAllowReceiveTrue.Name = "rbAllowReceiveTrue";
            this.rbAllowReceiveTrue.Size = new System.Drawing.Size(38, 22);
            this.rbAllowReceiveTrue.TabIndex = 14;
            this.rbAllowReceiveTrue.Text = "بله";
            this.rbAllowReceiveTrue.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.rbAllowSendFalse);
            this.radPanel3.Controls.Add(this.rbAllowSendTrue);
            this.radPanel3.Location = new System.Drawing.Point(3, -1);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(163, 28);
            this.radPanel3.TabIndex = 26;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // rbAllowSendFalse
            // 
            this.rbAllowSendFalse.Location = new System.Drawing.Point(75, 3);
            this.rbAllowSendFalse.Name = "rbAllowSendFalse";
            this.rbAllowSendFalse.Size = new System.Drawing.Size(40, 22);
            this.rbAllowSendFalse.TabIndex = 15;
            this.rbAllowSendFalse.TabStop = false;
            this.rbAllowSendFalse.Text = "خیر";
            // 
            // rbAllowSendTrue
            // 
            this.rbAllowSendTrue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbAllowSendTrue.Location = new System.Drawing.Point(119, 3);
            this.rbAllowSendTrue.Name = "rbAllowSendTrue";
            this.rbAllowSendTrue.Size = new System.Drawing.Size(38, 22);
            this.rbAllowSendTrue.TabIndex = 14;
            this.rbAllowSendTrue.Text = "بله";
            this.rbAllowSendTrue.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // AddOrEditWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 294);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.breUser);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radLabel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddOrEditWareHouse";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Tag = "افزودن / ویرایش انبار";
            this.Text = "افزودن / ویرایش انبار";
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.breUser, 0);
            this.Controls.SetChildIndex(this.radLabel2, 0);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelect)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbIsNotCountable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbIsCountable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllowReceiveFalse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllowReceiveTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllowSendFalse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllowSendTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadBrowseEditor breUser;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadRadioButton rbIsNotCountable;
        private Telerik.WinControls.UI.RadRadioButton rbIsCountable;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadRadioButton rbAllowReceiveFalse;
        private Telerik.WinControls.UI.RadRadioButton rbAllowReceiveTrue;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadRadioButton rbAllowSendFalse;
        private Telerik.WinControls.UI.RadRadioButton rbAllowSendTrue;
    }
}
