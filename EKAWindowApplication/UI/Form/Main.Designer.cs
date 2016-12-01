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
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.btnExit = new Telerik.WinControls.UI.RadButtonElement();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnMaterial = new Telerik.WinControls.UI.RadButtonElement();
            this.btnMaterialGroup = new Telerik.WinControls.UI.RadButtonElement();
            this.btnUnit = new Telerik.WinControls.UI.RadButtonElement();
            this.btnUnitGroup = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnWareHouse = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnOrder = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnMaterialExistance = new Telerik.WinControls.UI.RadButtonElement();
            this.btnOrderReport = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab3 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup5 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnUser = new Telerik.WinControls.UI.RadButtonElement();
            this.btnWareHouseManager = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblUserDetails,
            this.commandBarSeparator1,
            this.btnExit});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 519);
            this.radStatusStrip1.Margin = new System.Windows.Forms.Padding(4);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radStatusStrip1.Size = new System.Drawing.Size(695, 28);
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
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.radStatusStrip1.SetSpring(this.btnExit, false);
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radPageView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 354);
            this.panel1.TabIndex = 2;
            // 
            // radPageView1
            // 
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radPageView1.Size = new System.Drawing.Size(695, 354);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.Text = "radPageView1";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ShowItemCloseButton = true;
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2,
            this.ribbonTab3});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.StretchVertically = true;
            this.radRibbonBar1.ShowExpandButton = false;
            this.radRibbonBar1.Size = new System.Drawing.Size(695, 165);
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
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "تعاریف";
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnMaterial,
            this.btnMaterialGroup,
            this.btnUnit,
            this.btnUnitGroup});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.StretchHorizontally = false;
            this.radRibbonBarGroup1.Text = "کالا";
            // 
            // btnMaterial
            // 
            this.btnMaterial.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMaterial.Text = "کالا";
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnMaterialGroup
            // 
            this.btnMaterialGroup.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaterialGroup.Name = "btnMaterialGroup";
            this.btnMaterialGroup.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMaterialGroup.Text = "گروه کالایی";
            this.btnMaterialGroup.Click += new System.EventHandler(this.btnMaterialGroup_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUnit.Text = "واحد";
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // btnUnitGroup
            // 
            this.btnUnitGroup.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnitGroup.Name = "btnUnitGroup";
            this.btnUnitGroup.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUnitGroup.Text = "گروه های واحدی";
            this.btnUnitGroup.Click += new System.EventHandler(this.btnUnitGroup_Click);
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnWareHouse});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "انبار";
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnWareHouse.Text = "انبار";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.IsSelected = false;
            this.ribbonTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup3,
            this.radRibbonBarGroup4});
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "انبار";
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnOrder});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "عملیات";
            // 
            // btnOrder
            // 
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnOrder.Text = "حواله";
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnMaterialExistance,
            this.btnOrderReport});
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "کزارش";
            // 
            // btnMaterialExistance
            // 
            this.btnMaterialExistance.Name = "btnMaterialExistance";
            this.btnMaterialExistance.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMaterialExistance.Text = "موجودی انبار";
            // 
            // btnOrderReport
            // 
            this.btnOrderReport.Name = "btnOrderReport";
            this.btnOrderReport.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnOrderReport.Text = "حواله";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.IsSelected = false;
            this.ribbonTab3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup5});
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "کاربران";
            // 
            // radRibbonBarGroup5
            // 
            this.radRibbonBarGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnUser,
            this.btnWareHouseManager});
            this.radRibbonBarGroup5.Name = "radRibbonBarGroup5";
            this.radRibbonBarGroup5.Text = "مدیریت کاربران";
            // 
            // btnUser
            // 
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUser.Text = "کاربران";
            // 
            // btnWareHouseManager
            // 
            this.btnWareHouseManager.Name = "btnWareHouseManager";
            this.btnWareHouseManager.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnWareHouseManager.Text = "دسترسی به انبار";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radRibbonBar1);
            this.Controls.Add(this.radStatusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EKA سیستم انبارداری";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
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
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.RadButtonElement btnExit;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RibbonTab ribbonTab3;
        private Telerik.WinControls.UI.RadButtonElement btnMaterial;
        private Telerik.WinControls.UI.RadButtonElement btnMaterialGroup;
        private Telerik.WinControls.UI.RadButtonElement btnUnit;
        private Telerik.WinControls.UI.RadButtonElement btnUnitGroup;
        private Telerik.WinControls.UI.RadButtonElement btnWareHouse;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement btnOrder;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadButtonElement btnMaterialExistance;
        private Telerik.WinControls.UI.RadButtonElement btnOrderReport;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup5;
        private Telerik.WinControls.UI.RadButtonElement btnUser;
        private Telerik.WinControls.UI.RadButtonElement btnWareHouseManager;
        private Telerik.WinControls.UI.RadPageView radPageView1;
    }
}
