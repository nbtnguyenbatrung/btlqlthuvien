﻿
namespace librarian.view
{
    partial class Frm_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_book));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnthoat = new DevComponents.DotNetBar.ButtonItem();
            this.dgvuser = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnluu = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorbook = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorthem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorxoa = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorsave = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorexit = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorcancel = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnall = new DevComponents.DotNetBar.ButtonX();
            this.btntk = new DevComponents.DotNetBar.ButtonX();
            this.ckbtimkiemten = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txttimkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btntimkiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnthem = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.ctxmenu = new DevComponents.DotNetBar.ButtonItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new librarian.component.CalendarColumn();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.publishingCompanyId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fieldId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.yearPublishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorbook)).BeginInit();
            this.bindingNavigatorbook.SuspendLayout();
            this.navigationPanePanel2.SuspendLayout();
            this.navigationPane1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImagePaddingHorizontal = 8;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlW);
            this.btnthoat.Text = "đóng tab hiện tại ";
            // 
            // dgvuser
            // 
            this.dgvuser.AllowUserToAddRows = false;
            this.dgvuser.AllowUserToResizeColumns = false;
            this.dgvuser.AllowUserToResizeRows = false;
            this.dgvuser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvuser.ColumnHeadersHeight = 34;
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.nameBook,
            this.creatorId,
            this.publishingCompanyId,
            this.typeId,
            this.fieldId,
            this.yearPublishing,
            this.numberBook,
            this.numberPage,
            this.format,
            this.status,
            this.price});
            this.contextMenuBar1.SetContextMenuEx(this.dgvuser, this.ctxmenu);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvuser.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvuser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvuser.Location = new System.Drawing.Point(3, 55);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.RowHeadersWidth = 62;
            this.dgvuser.RowTemplate.Height = 28;
            this.dgvuser.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvuser.Size = new System.Drawing.Size(838, 526);
            this.dgvuser.TabIndex = 1;
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImagePaddingHorizontal = 8;
            this.btnluu.Name = "btnluu";
            this.btnluu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnluu.Text = "Lưu dữ liệu ";
            // 
            // bindingNavigatorbook
            // 
            this.bindingNavigatorbook.AddNewItem = null;
            this.bindingNavigatorbook.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorbook.DeleteItem = null;
            this.bindingNavigatorbook.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorbook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorthem,
            this.bindingNavigatorxoa,
            this.bindingNavigatorsave,
            this.bindingNavigatorexit,
            this.bindingNavigatorcancel});
            this.bindingNavigatorbook.Location = new System.Drawing.Point(3, 22);
            this.bindingNavigatorbook.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorbook.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorbook.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorbook.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorbook.Name = "bindingNavigatorbook";
            this.bindingNavigatorbook.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorbook.Size = new System.Drawing.Size(838, 33);
            this.bindingNavigatorbook.TabIndex = 0;
            this.bindingNavigatorbook.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorthem
            // 
            this.bindingNavigatorthem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorthem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorthem.Image")));
            this.bindingNavigatorthem.Name = "bindingNavigatorthem";
            this.bindingNavigatorthem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorthem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorthem.Text = "Add new";
            this.bindingNavigatorthem.Click += new System.EventHandler(this.bindingNavigatorthem_Click);
            // 
            // bindingNavigatorxoa
            // 
            this.bindingNavigatorxoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorxoa.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorxoa.Image")));
            this.bindingNavigatorxoa.Name = "bindingNavigatorxoa";
            this.bindingNavigatorxoa.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorxoa.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorxoa.Text = "Delete";
            this.bindingNavigatorxoa.Click += new System.EventHandler(this.bindingNavigatorxoa_Click);
            // 
            // bindingNavigatorsave
            // 
            this.bindingNavigatorsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorsave.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorsave.Image")));
            this.bindingNavigatorsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorsave.Name = "bindingNavigatorsave";
            this.bindingNavigatorsave.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorsave.Text = "lưu";
            this.bindingNavigatorsave.Click += new System.EventHandler(this.bindingNavigatorsave_Click);
            // 
            // bindingNavigatorexit
            // 
            this.bindingNavigatorexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorexit.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorexit.Image")));
            this.bindingNavigatorexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorexit.Name = "bindingNavigatorexit";
            this.bindingNavigatorexit.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorexit.Text = "thoát";
            this.bindingNavigatorexit.Click += new System.EventHandler(this.bindingNavigatorexit_Click);
            // 
            // bindingNavigatorcancel
            // 
            this.bindingNavigatorcancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorcancel.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorcancel.Image")));
            this.bindingNavigatorcancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorcancel.Name = "bindingNavigatorcancel";
            this.bindingNavigatorcancel.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorcancel.Text = "làm mới";
            this.bindingNavigatorcancel.Click += new System.EventHandler(this.bindingNavigatorcancel_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImagePaddingHorizontal = 8;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnxoa.Text = "xóa dữ liệu";
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel2.Controls.Add(this.btnall);
            this.navigationPanePanel2.Controls.Add(this.btntk);
            this.navigationPanePanel2.Controls.Add(this.ckbtimkiemten);
            this.navigationPanePanel2.Controls.Add(this.txttimkiem);
            this.navigationPanePanel2.Controls.Add(this.labelX3);
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.btntimkiem;
            this.navigationPanePanel2.Size = new System.Drawing.Size(292, 506);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // btnall
            // 
            this.btnall.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnall.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnall.Location = new System.Drawing.Point(40, 285);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(144, 24);
            this.btnall.TabIndex = 5;
            this.btnall.Text = "All";
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // btntk
            // 
            this.btntk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntk.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btntk.Location = new System.Drawing.Point(40, 227);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(144, 26);
            this.btntk.TabIndex = 4;
            this.btntk.Text = "Search";
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // ckbtimkiemten
            // 
            this.ckbtimkiemten.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbtimkiemten.Checked = true;
            this.ckbtimkiemten.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbtimkiemten.CheckValue = "Y";
            this.ckbtimkiemten.Location = new System.Drawing.Point(11, 144);
            this.ckbtimkiemten.Name = "ckbtimkiemten";
            this.ckbtimkiemten.Size = new System.Drawing.Size(196, 24);
            this.ckbtimkiemten.TabIndex = 3;
            this.ckbtimkiemten.Text = "Tìm kiếm theo tên ";
            // 
            // txttimkiem
            // 
            // 
            // 
            // 
            this.txttimkiem.Border.Class = "TextBoxBorder";
            this.txttimkiem.Location = new System.Drawing.Point(12, 70);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(196, 26);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.WatermarkText = "Nhập thông tin tim kiếm ";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(12, 14);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(209, 37);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Nhập thông tin tìm kiếm :";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Checked = true;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btntimkiem.ImagePaddingHorizontal = 8;
            this.btntimkiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.OptionGroup = "navBar";
            this.btntimkiem.Text = "Tìm kiếm dữ liệu ";
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImagePaddingHorizontal = 8;
            this.btnthem.Name = "btnthem";
            this.btnthem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btnthem.Text = "Thêm dữ liệu ";
            // 
            // navigationPane1
            // 
            this.navigationPane1.CanCollapse = true;
            this.navigationPane1.Controls.Add(this.navigationPanePanel2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btntimkiem});
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 52;
            this.navigationPane1.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane1.Size = new System.Drawing.Size(294, 584);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane1.TabIndex = 10;
            // 
            // 
            // 
            this.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPane1.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navigationPane1.TitlePanel.Name = "panelTitle";
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(292, 24);
            this.navigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPane1.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navigationPane1.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navigationPane1.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPane1.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navigationPane1.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPane1.TitlePanel.Style.GradientAngle = 90;
            this.navigationPane1.TitlePanel.Style.MarginLeft = 4;
            this.navigationPane1.TitlePanel.TabIndex = 0;
            this.navigationPane1.TitlePanel.Text = "Tìm kiếm dữ liệu ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.contextMenuBar1);
            this.groupBox1.Controls.Add(this.dgvuser);
            this.groupBox1.Controls.Add(this.bindingNavigatorbook);
            this.groupBox1.Location = new System.Drawing.Point(294, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 584);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sách";
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ctxmenu});
            this.contextMenuBar1.Location = new System.Drawing.Point(388, 243);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(75, 33);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.contextMenuBar1.TabIndex = 2;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // ctxmenu
            // 
            this.ctxmenu.AutoExpandOnClick = true;
            this.ctxmenu.ImagePaddingHorizontal = 8;
            this.ctxmenu.Name = "ctxmenu";
            this.ctxmenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnthem,
            this.btnxoa,
            this.btnluu,
            this.btnthoat});
            this.ctxmenu.Text = "menu";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã khóa học ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khóa học ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "yearPublishing";
            this.dataGridViewTextBoxColumn3.HeaderText = "Chức danh";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "numberBook";
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numberPage";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số chứng minh thư";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "format";
            this.dataGridViewTextBoxColumn6.HeaderText = "Khổ sách";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Trạng thái sách";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Giá sách";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.HeaderText = "Ngày sinh";
            this.calendarColumn1.MinimumWidth = 8;
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.calendarColumn1.Width = 150;
            // 
            // bookId
            // 
            this.bookId.DataPropertyName = "bookId";
            this.bookId.HeaderText = "Mã sách";
            this.bookId.MinimumWidth = 8;
            this.bookId.Name = "bookId";
            this.bookId.ReadOnly = true;
            this.bookId.Width = 150;
            // 
            // nameBook
            // 
            this.nameBook.DataPropertyName = "nameBook";
            this.nameBook.HeaderText = "Tên sách *";
            this.nameBook.MinimumWidth = 8;
            this.nameBook.Name = "nameBook";
            this.nameBook.Width = 150;
            // 
            // creatorId
            // 
            this.creatorId.DataPropertyName = "creatorId";
            this.creatorId.HeaderText = "Tên độc giả *";
            this.creatorId.MinimumWidth = 8;
            this.creatorId.Name = "creatorId";
            this.creatorId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.creatorId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.creatorId.Width = 150;
            // 
            // publishingCompanyId
            // 
            this.publishingCompanyId.DataPropertyName = "publishingCompanyId";
            this.publishingCompanyId.HeaderText = "Nhà xuất bản *";
            this.publishingCompanyId.MinimumWidth = 8;
            this.publishingCompanyId.Name = "publishingCompanyId";
            this.publishingCompanyId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.publishingCompanyId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.publishingCompanyId.Width = 150;
            // 
            // typeId
            // 
            this.typeId.DataPropertyName = "typeId";
            this.typeId.HeaderText = "Thể loại *";
            this.typeId.MinimumWidth = 8;
            this.typeId.Name = "typeId";
            this.typeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeId.Width = 150;
            // 
            // fieldId
            // 
            this.fieldId.DataPropertyName = "fieldId";
            this.fieldId.HeaderText = "Lĩnh vực *";
            this.fieldId.MinimumWidth = 8;
            this.fieldId.Name = "fieldId";
            this.fieldId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fieldId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fieldId.Width = 150;
            // 
            // yearPublishing
            // 
            this.yearPublishing.DataPropertyName = "yearPublishing";
            this.yearPublishing.HeaderText = "Năm xuất bản";
            this.yearPublishing.MinimumWidth = 8;
            this.yearPublishing.Name = "yearPublishing";
            this.yearPublishing.Width = 150;
            // 
            // numberBook
            // 
            this.numberBook.DataPropertyName = "numberBook";
            this.numberBook.HeaderText = "Số sách";
            this.numberBook.MinimumWidth = 8;
            this.numberBook.Name = "numberBook";
            this.numberBook.Width = 150;
            // 
            // numberPage
            // 
            this.numberPage.DataPropertyName = "numberPage";
            this.numberPage.HeaderText = "Số trang";
            this.numberPage.MinimumWidth = 8;
            this.numberPage.Name = "numberPage";
            this.numberPage.Width = 150;
            // 
            // format
            // 
            this.format.DataPropertyName = "format";
            this.format.HeaderText = "Khổ sách";
            this.format.MinimumWidth = 8;
            this.format.Name = "format";
            this.format.Width = 150;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Trạng thái sách";
            this.status.Items.AddRange(new object[] {
            "bình thường",
            "hủy"});
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.Width = 150;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá sách *";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // Frm_book
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1128, 584);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_book";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorbook)).EndInit();
            this.bindingNavigatorbook.ResumeLayout(false);
            this.bindingNavigatorbook.PerformLayout();
            this.navigationPanePanel2.ResumeLayout(false);
            this.navigationPane1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevComponents.DotNetBar.ButtonItem btnthoat;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvuser;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem ctxmenu;
        private DevComponents.DotNetBar.ButtonItem btnthem;
        private DevComponents.DotNetBar.ButtonItem btnxoa;
        private DevComponents.DotNetBar.ButtonItem btnluu;
        private System.Windows.Forms.BindingNavigator bindingNavigatorbook;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorthem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorxoa;
        private System.Windows.Forms.ToolStripButton bindingNavigatorsave;
        private System.Windows.Forms.ToolStripButton bindingNavigatorexit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorcancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private component.CalendarColumn calendarColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.ButtonX btnall;
        private DevComponents.DotNetBar.ButtonX btntk;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbtimkiemten;
        private DevComponents.DotNetBar.Controls.TextBoxX txttimkiem;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonItem btntimkiem;
        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBook;
        private System.Windows.Forms.DataGridViewComboBoxColumn creatorId;
        private System.Windows.Forms.DataGridViewComboBoxColumn publishingCompanyId;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeId;
        private System.Windows.Forms.DataGridViewComboBoxColumn fieldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearPublishing;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn format;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}