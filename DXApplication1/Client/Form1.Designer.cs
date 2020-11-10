﻿namespace DXApplication1
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTinCaNhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveData = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonItemBanDo = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBackground = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpManage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnLogin,
            this.btnChangePass,
            this.btnLogout,
            this.btnThongTinCaNhan,
            this.btnSaveData,
            this.btnRestore,
            this.skinRibbonGalleryBarItem1,
            this.barButtonItemBanDo,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHeThong,
            this.rbpManage});
            this.ribbonControl1.Size = new System.Drawing.Size(1375, 183);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.LargeImage")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Caption = "Đổi mật khẩu";
            this.btnChangePass.Id = 2;
            this.btnChangePass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.ImageOptions.Image")));
            this.btnChangePass.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangePass.ImageOptions.LargeImage")));
            this.btnChangePass.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnChangePass.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnChangePass.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ItemAppearance.Normal.Options.UseFont = true;
            this.btnChangePass.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnChangePass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePass_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 3;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnLogout.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnLogout.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ItemAppearance.Normal.Options.UseFont = true;
            this.btnLogout.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Caption = "Thông tin cá nhân";
            this.btnThongTinCaNhan.Id = 4;
            this.btnThongTinCaNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinCaNhan.ImageOptions.Image")));
            this.btnThongTinCaNhan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongTinCaNhan.ImageOptions.LargeImage")));
            this.btnThongTinCaNhan.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinCaNhan.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnThongTinCaNhan.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinCaNhan.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnThongTinCaNhan.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinCaNhan.ItemAppearance.Normal.Options.UseFont = true;
            this.btnThongTinCaNhan.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinCaNhan.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongTinCaNhan_ItemClick);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Caption = "Sao lưu dữ liệu";
            this.btnSaveData.Id = 5;
            this.btnSaveData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveData.ImageOptions.Image")));
            this.btnSaveData.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaveData.ImageOptions.LargeImage")));
            this.btnSaveData.Name = "btnSaveData";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Khôi phục dữ liệu";
            this.btnRestore.Id = 6;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.LargeImage")));
            this.btnRestore.Name = "btnRestore";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 7;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barButtonItemBanDo
            // 
            this.barButtonItemBanDo.ActAsDropDown = true;
            this.barButtonItemBanDo.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItemBanDo.Caption = "Bản đồ";
            this.barButtonItemBanDo.DropDownControl = this.popupMenu1;
            this.barButtonItemBanDo.Id = 16;
            this.barButtonItemBanDo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemBanDo.ImageOptions.Image")));
            this.barButtonItemBanDo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemBanDo.ImageOptions.LargeImage")));
            this.barButtonItemBanDo.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItemBanDo.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItemBanDo.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItemBanDo.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItemBanDo.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItemBanDo.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemBanDo.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItemBanDo.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItemBanDo.Name = "barButtonItemBanDo";
            this.barButtonItemBanDo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemBanDo_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButtonItem2);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem3);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem4);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem5);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Mô phỏng";
            this.barButtonItem2.Id = 17;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "File";
            this.barButtonItem3.Id = 18;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Phương án";
            this.barButtonItem4.Id = 19;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thoát";
            this.barButtonItem5.Id = 20;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // rbpHeThong
            // 
            this.rbpHeThong.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpHeThong.Appearance.Options.UseFont = true;
            this.rbpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbHeThong,
            this.rbBackground});
            this.rbpHeThong.Name = "rbpHeThong";
            this.rbpHeThong.Text = "Hệ thống";
            // 
            // rbHeThong
            // 
            this.rbHeThong.ItemLinks.Add(this.btnChangePass);
            this.rbHeThong.ItemLinks.Add(this.btnLogout);
            this.rbHeThong.ItemLinks.Add(this.btnThongTinCaNhan);
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ thống";
            // 
            // rbBackground
            // 
            this.rbBackground.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.rbBackground.Name = "rbBackground";
            this.rbBackground.Text = "Giao diện";
            // 
            // rbpManage
            // 
            this.rbpManage.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpManage.Appearance.Options.UseFont = true;
            this.rbpManage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpManage.Name = "rbpManage";
            this.rbpManage.Text = "Quản lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemBanDo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Công việc";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Bệnh Nhân";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 183);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1375, 446);
            this.panelMain.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 629);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbBackground;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpManage;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraTab.XtraTabPage tabHienThi;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnChangePass;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnThongTinCaNhan;
        private DevExpress.XtraBars.BarButtonItem btnSaveData;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBanDo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}

