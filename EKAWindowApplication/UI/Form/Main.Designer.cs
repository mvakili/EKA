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
            this.ribbonMenu = new Telerik.WinControls.UI.RadRibbonBar();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonMenu
            // 
            this.ribbonMenu.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView;
            // 
            // 
            // 
            this.ribbonMenu.ExitButton.Text = "Exit";
            this.ribbonMenu.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ribbonMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ribbonMenu.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonMenu.MaximizeButton = false;
            this.ribbonMenu.Name = "ribbonMenu";
            // 
            // 
            // 
            this.ribbonMenu.OptionsButton.Text = "Options";
            this.ribbonMenu.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // 
            // 
            this.ribbonMenu.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.ribbonMenu.Size = new System.Drawing.Size(640, 148);
            this.ribbonMenu.TabIndex = 0;
            this.ribbonMenu.Text = "EKA سیستم انبارداری";
            this.ribbonMenu.ThemeName = "ControlDefault";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 503);
            this.radStatusStrip1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(640, 28);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 355);
            this.panel1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.ribbonMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EKA سیستم انبارداری";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar ribbonMenu;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}
