
namespace librarian
{
    partial class Frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.lblTenNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.buttonFile = new DevComponents.DotNetBar.Office2007StartButton();
            this.btnsaoluu = new DevComponents.DotNetBar.ButtonItem();
            this.btnthoat = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.ctxmenumain = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnmenumain = new DevComponents.DotNetBar.ButtonItem();
            this.btndangnhapcontext = new DevComponents.DotNetBar.ButtonItem();
            this.btndangxuatcontext = new DevComponents.DotNetBar.ButtonItem();
            this.btndoimatkhaucontext = new DevComponents.DotNetBar.ButtonItem();
            this.btnthoatcontext = new DevComponents.DotNetBar.ButtonItem();
            this.backupDialog = new System.Windows.Forms.SaveFileDialog();
            this.restoreDialog = new System.Windows.Forms.OpenFileDialog();
            this.bottomBar = new DevComponents.DotNetBar.Bar();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btnbonus = new DevComponents.DotNetBar.ButtonItem();
            this.bntdiscipline = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar6 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.btnhocvien = new DevComponents.DotNetBar.ButtonItem();
            this.btnphanlop = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnkhoahoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnlophoc = new DevComponents.DotNetBar.ButtonItem();
            this.btngiaovien = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ctxmenumain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).BeginInit();
            this.bottomBar.SuspendLayout();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiDung.ForeColor = System.Drawing.Color.Red;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(274, -3);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(235, 25);
            this.lblTenNguoiDung.TabIndex = 0;
            // 
            // buttonFile
            // 
            this.buttonFile.AutoExpandOnClick = true;
            this.buttonFile.CanCustomize = false;
            this.buttonFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.buttonFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonFile.Image")));
            this.buttonFile.ImagePaddingHorizontal = 2;
            this.buttonFile.ImagePaddingVertical = 2;
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.ShowSubItems = false;
            this.buttonFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnsaoluu,
            this.btnthoat});
            this.buttonFile.Text = "&File";
            this.buttonFile.Tooltip = "Nút điều khiển chương trình";
            // 
            // btnsaoluu
            // 
            this.btnsaoluu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnsaoluu.Image = ((System.Drawing.Image)(resources.GetObject("btnsaoluu.Image")));
            this.btnsaoluu.ImagePaddingHorizontal = 8;
            this.btnsaoluu.Name = "btnsaoluu";
            this.btnsaoluu.Text = "Kết nối cơ sở dữ liệu";
            this.btnsaoluu.Click += new System.EventHandler(this.btnsaoluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImagePaddingHorizontal = 8;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // tabStrip1
            // 
            this.tabStrip1.AutoSelectAttachedControl = true;
            this.tabStrip1.CanReorderTabs = true;
            this.tabStrip1.CloseButtonOnTabsVisible = true;
            this.tabStrip1.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabStrip1.CloseButtonVisible = false;
            this.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip1.Location = new System.Drawing.Point(4, 254);
            this.tabStrip1.MdiForm = this;
            this.tabStrip1.MdiTabbedDocuments = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.SelectedTab = null;
            this.tabStrip1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.tabStrip1.Size = new System.Drawing.Size(1131, 36);
            this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.tabStrip1.TabIndex = 11;
            this.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip1.Text = "tabstrip";
            // 
            // tabItem1
            // 
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "";
            // 
            // ctxmenumain
            // 
            this.ctxmenumain.AntiAlias = true;
            this.ctxmenumain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnmenumain});
            this.ctxmenumain.Location = new System.Drawing.Point(644, 387);
            this.ctxmenumain.Name = "ctxmenumain";
            this.ctxmenumain.Size = new System.Drawing.Size(177, 33);
            this.ctxmenumain.Stretch = true;
            this.ctxmenumain.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxmenumain.TabIndex = 12;
            this.ctxmenumain.TabStop = false;
            this.ctxmenumain.Text = "ctxmenu";
            // 
            // btnmenumain
            // 
            this.btnmenumain.AutoExpandOnClick = true;
            this.btnmenumain.ImagePaddingHorizontal = 8;
            this.btnmenumain.Name = "btnmenumain";
            this.btnmenumain.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btndangnhapcontext,
            this.btndangxuatcontext,
            this.btndoimatkhaucontext,
            this.btnthoatcontext});
            this.btnmenumain.Text = "MENU";
            // 
            // btndangnhapcontext
            // 
            this.btndangnhapcontext.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btndangnhapcontext.Image = ((System.Drawing.Image)(resources.GetObject("btndangnhapcontext.Image")));
            this.btndangnhapcontext.ImagePaddingHorizontal = 8;
            this.btndangnhapcontext.Name = "btndangnhapcontext";
            this.btndangnhapcontext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL);
            this.btndangnhapcontext.Text = "Đăng Nhập";
            // 
            // btndangxuatcontext
            // 
            this.btndangxuatcontext.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btndangxuatcontext.Image = ((System.Drawing.Image)(resources.GetObject("btndangxuatcontext.Image")));
            this.btndangxuatcontext.ImagePaddingHorizontal = 8;
            this.btndangxuatcontext.Name = "btndangxuatcontext";
            this.btndangxuatcontext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO);
            this.btndangxuatcontext.Text = "Đăng Xuất";
            // 
            // btndoimatkhaucontext
            // 
            this.btndoimatkhaucontext.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btndoimatkhaucontext.Image = ((System.Drawing.Image)(resources.GetObject("btndoimatkhaucontext.Image")));
            this.btndoimatkhaucontext.ImagePaddingHorizontal = 8;
            this.btndoimatkhaucontext.Name = "btndoimatkhaucontext";
            this.btndoimatkhaucontext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP);
            this.btndoimatkhaucontext.Text = "Đổi Mật Khẩu ";
            // 
            // btnthoatcontext
            // 
            this.btnthoatcontext.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnthoatcontext.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatcontext.Image")));
            this.btnthoatcontext.ImagePaddingHorizontal = 8;
            this.btnthoatcontext.Name = "btnthoatcontext";
            this.btnthoatcontext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnthoatcontext.Text = "Thoát Chương Trình";
            // 
            // backupDialog
            // 
            this.backupDialog.DefaultExt = "*.BAK";
            this.backupDialog.FileName = "QLHOCVIEN";
            this.backupDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.backupDialog.FilterIndex = 2;
            this.backupDialog.Title = "SAO LƯU DỮ LIỆU";
            // 
            // restoreDialog
            // 
            this.restoreDialog.DefaultExt = "*.BAK";
            this.restoreDialog.FileName = "QLHOCVIEN.BAK";
            this.restoreDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.restoreDialog.FilterIndex = 2;
            this.restoreDialog.Title = "PHỤC HỒI DỮ LIỆU";
            // 
            // bottomBar
            // 
            this.bottomBar.AccessibleDescription = "DotNetBar Bar (bottomBar)";
            this.bottomBar.AccessibleName = "DotNetBar Bar";
            this.bottomBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.bottomBar.AlwaysDisplayDockTab = true;
            this.bottomBar.AntiAlias = true;
            this.bottomBar.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.bottomBar.Controls.Add(this.lblTenNguoiDung);
            this.bottomBar.Controls.Add(this.labelX1);
            this.bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.bottomBar.ItemSpacing = 2;
            this.bottomBar.Location = new System.Drawing.Point(4, 461);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(1131, 25);
            this.bottomBar.Stretch = true;
            this.bottomBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bottomBar.TabIndex = 13;
            this.bottomBar.TabStop = false;
            this.bottomBar.Text = "barStatus";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(251, 19);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Người dùng đang đăng nhập : ";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFile,
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(1131, 253);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 10;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.ribbonBar6);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 58);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1131, 193);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnbonus,
            this.bntdiscipline});
            this.ribbonBar2.Location = new System.Drawing.Point(475, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(177, 190);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar2.TabIndex = 4;
            this.ribbonBar2.Text = "Tra cứu";
            // 
            // btnbonus
            // 
            this.btnbonus.Image = ((System.Drawing.Image)(resources.GetObject("btnbonus.Image")));
            this.btnbonus.ImagePaddingHorizontal = 8;
            this.btnbonus.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnbonus.Name = "btnbonus";
            this.btnbonus.SubItemsExpandWidth = 14;
            this.btnbonus.Text = "<div align=\"center\"> Danh sách<br/>Sách mượn</div>";
            this.btnbonus.Click += new System.EventHandler(this.btnbonus_Click);
            // 
            // bntdiscipline
            // 
            this.bntdiscipline.Image = ((System.Drawing.Image)(resources.GetObject("bntdiscipline.Image")));
            this.bntdiscipline.ImagePaddingHorizontal = 8;
            this.bntdiscipline.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.bntdiscipline.Name = "bntdiscipline";
            this.bntdiscipline.SubItemsExpandWidth = 14;
            this.bntdiscipline.Text = "<div align=\"center\">sách <br/> quá hạn mượn</div>";
            this.bntdiscipline.Click += new System.EventHandler(this.bntdiscipline_Click);
            // 
            // ribbonBar6
            // 
            this.ribbonBar6.AutoOverflowEnabled = true;
            this.ribbonBar6.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar6.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem5,
            this.btnhocvien,
            this.btnphanlop,
            this.buttonItem2,
            this.buttonItem3,
            this.buttonItem4});
            this.ribbonBar6.Location = new System.Drawing.Point(211, 0);
            this.ribbonBar6.Name = "ribbonBar6";
            this.ribbonBar6.Size = new System.Drawing.Size(264, 190);
            this.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar6.TabIndex = 3;
            this.ribbonBar6.Text = "Sách";
            // 
            // buttonItem5
            // 
            this.buttonItem5.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem5.Image")));
            this.buttonItem5.ImagePaddingHorizontal = 8;
            this.buttonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.SubItemsExpandWidth = 14;
            this.buttonItem5.Text = "<div align=\"center\">Lĩnh <br/>vực</div>";
            this.buttonItem5.Click += new System.EventHandler(this.buttonItem5_Click);
            // 
            // btnhocvien
            // 
            this.btnhocvien.Image = ((System.Drawing.Image)(resources.GetObject("btnhocvien.Image")));
            this.btnhocvien.ImagePaddingHorizontal = 8;
            this.btnhocvien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnhocvien.Name = "btnhocvien";
            this.btnhocvien.SubItemsExpandWidth = 14;
            this.btnhocvien.Text = "<div align=\"center\">Loại</div>";
            this.btnhocvien.Click += new System.EventHandler(this.btnhocvien_Click);
            // 
            // btnphanlop
            // 
            this.btnphanlop.Image = ((System.Drawing.Image)(resources.GetObject("btnphanlop.Image")));
            this.btnphanlop.ImagePaddingHorizontal = 8;
            this.btnphanlop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnphanlop.Name = "btnphanlop";
            this.btnphanlop.SubItemsExpandWidth = 14;
            this.btnphanlop.Text = "<div align=\"center\">Nhà  <br/>sản xuất</div>";
            this.btnphanlop.Click += new System.EventHandler(this.btnphanlop_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.ImagePaddingHorizontal = 8;
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 14;
            this.buttonItem2.Text = "<div align=\"center\">Tác <br/>giả</div>";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // buttonItem3
            // 
            this.buttonItem3.ImagePaddingHorizontal = 8;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.SubItemsExpandWidth = 14;
            // 
            // buttonItem4
            // 
            this.buttonItem4.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem4.Image")));
            this.buttonItem4.ImagePaddingHorizontal = 8;
            this.buttonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 14;
            this.buttonItem4.Text = "<div align=\"center\">Sách</div>";
            this.buttonItem4.Click += new System.EventHandler(this.buttonItem4_Click);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnkhoahoc,
            this.btnlophoc,
            this.btngiaovien});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(208, 190);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "độc giả";
            // 
            // btnkhoahoc
            // 
            this.btnkhoahoc.Image = ((System.Drawing.Image)(resources.GetObject("btnkhoahoc.Image")));
            this.btnkhoahoc.ImagePaddingHorizontal = 8;
            this.btnkhoahoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnkhoahoc.Name = "btnkhoahoc";
            this.btnkhoahoc.SubItemsExpandWidth = 14;
            this.btnkhoahoc.Text = "<div align=\"center\">độc <br/> giả</div>";
            this.btnkhoahoc.Click += new System.EventHandler(this.btnkhoahoc_Click);
            // 
            // btnlophoc
            // 
            this.btnlophoc.Image = ((System.Drawing.Image)(resources.GetObject("btnlophoc.Image")));
            this.btnlophoc.ImagePaddingHorizontal = 8;
            this.btnlophoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnlophoc.Name = "btnlophoc";
            this.btnlophoc.SubItemsExpandWidth = 14;
            this.btnlophoc.Text = "<div align=\"center\">Thẻ <br/>độc giả</div>";
            this.btnlophoc.Click += new System.EventHandler(this.btnlophoc_Click);
            // 
            // btngiaovien
            // 
            this.btngiaovien.Image = ((System.Drawing.Image)(resources.GetObject("btngiaovien.Image")));
            this.btngiaovien.ImagePaddingHorizontal = 8;
            this.btngiaovien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btngiaovien.Name = "btngiaovien";
            this.btngiaovien.SubItemsExpandWidth = 14;
            this.btngiaovien.Text = "<div align=\"center\">phiếu <br/>mượn sách</div>";
            this.btngiaovien.Click += new System.EventHandler(this.btngiaovien_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.ImagePaddingHorizontal = 8;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "&Quản lý";
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.ribbonBar3.Location = new System.Drawing.Point(652, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(97, 190);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar3.TabIndex = 5;
            this.ribbonBar3.Text = "Thống kê";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "<div align=\"center\">Danh sách  <br/> quá hạn mượn</div>";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 488);
            this.Controls.Add(this.tabStrip1);
            this.Controls.Add(this.ctxmenumain);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUAN LY THU VIEN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctxmenumain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).EndInit();
            this.bottomBar.ResumeLayout(false);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblTenNguoiDung;
        private DevComponents.DotNetBar.Office2007StartButton buttonFile;
        private DevComponents.DotNetBar.ButtonItem btnsaoluu;
        private DevComponents.DotNetBar.ButtonItem btnthoat;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.TabStrip tabStrip1;
        private DevComponents.DotNetBar.ContextMenuBar ctxmenumain;
        private DevComponents.DotNetBar.ButtonItem btnmenumain;
        private DevComponents.DotNetBar.ButtonItem btndangnhapcontext;
        private DevComponents.DotNetBar.ButtonItem btndangxuatcontext;
        private DevComponents.DotNetBar.ButtonItem btndoimatkhaucontext;
        private DevComponents.DotNetBar.ButtonItem btnthoatcontext;
        private DevComponents.DotNetBar.Bar bottomBar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnbonus;
        private DevComponents.DotNetBar.ButtonItem bntdiscipline;
        private DevComponents.DotNetBar.RibbonBar ribbonBar6;
        private DevComponents.DotNetBar.ButtonItem btnhocvien;
        private DevComponents.DotNetBar.ButtonItem btnphanlop;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnkhoahoc;
        private DevComponents.DotNetBar.ButtonItem btnlophoc;
        private DevComponents.DotNetBar.ButtonItem btngiaovien;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private System.Windows.Forms.SaveFileDialog backupDialog;
        private System.Windows.Forms.OpenFileDialog restoreDialog;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
    }
}

