namespace EKAWindowApplication.UI.Form
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblUserDetails = new Telerik.WinControls.UI.RadLabelElement();
            this.panel1 = new System.Windows.Forms.Panel();

            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblUserDetails});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 503);
            this.radStatusStrip1.Margin = new System.Windows.Forms.Padding(4);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radStatusStrip1.Size = new System.Drawing.Size(677, 28);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.Name = "lblUserDetails";
            this.radStatusStrip1.SetSpring(this.lblUserDetails, false);
            this.lblUserDetails.Text = "";
            this.lblUserDetails.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblUserDetails.TextWrap = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 359);
            this.panel1.TabIndex = 2;
            // 
            // radRibbonBarGroup2
            // 
  
            this.radRibbonBar1.RootElement.StretchVertically = true;
            this.radRibbonBar1.ShowExpandButton = false;
            this.radRibbonBar1.Size = new System.Drawing.Size(677, 144);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 5;
            this.radRibbonBar1.Text = "EKA سیستم انبارداری";
            this.radRibbonBar1.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).Text = "EKA سیستم انبارداری";
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RibbonBar.RibbonBarCaptionFillPrimitive)(this.radRibbonBar1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadQuickAccessToolBar)(this.radRibbonBar1.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadRibbonBarCaption)(this.radRibbonBar1.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RibbonTabStripElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(4))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RibbonTabStripElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(4))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadApplicationMenuButtonElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(5))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadApplicationMenuButtonElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(5))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(6))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // ribbonTab1
            // 

            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radRibbonBar1);
            this.Controls.Add(this.radStatusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EKA سیستم انبارداری";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadLabelElement lblUserDetails;


        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;

    }
}
