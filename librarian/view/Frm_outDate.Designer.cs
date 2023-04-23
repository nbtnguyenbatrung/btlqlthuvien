
namespace librarian.view
{
    partial class Frm_outDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_outDate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btntk = new DevComponents.DotNetBar.ButtonX();
            this.bindingNavigatoroutdate = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorrefresh = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorexit = new System.Windows.Forms.ToolStripButton();
            this.dgvoutdate = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.ctxmenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnrefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnimportexcel = new DevComponents.DotNetBar.ButtonItem();
            this.btnexportexcel = new DevComponents.DotNetBar.ButtonItem();
            this.btnsave = new DevComponents.DotNetBar.ButtonItem();
            this.btnthoat = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtnamebook = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxtenbook = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtnameuser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxtenuser = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatoroutdate)).BeginInit();
            this.bindingNavigatoroutdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvoutdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntk
            // 
            this.btntk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntk.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btntk.Location = new System.Drawing.Point(691, 42);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(138, 26);
            this.btntk.TabIndex = 13;
            this.btntk.Text = "Tìm Kiếm";
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // bindingNavigatoroutdate
            // 
            this.bindingNavigatoroutdate.AddNewItem = null;
            this.bindingNavigatoroutdate.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatoroutdate.DeleteItem = null;
            this.bindingNavigatoroutdate.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatoroutdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorrefresh,
            this.bindingNavigatorexit});
            this.bindingNavigatoroutdate.Location = new System.Drawing.Point(0, 151);
            this.bindingNavigatoroutdate.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatoroutdate.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatoroutdate.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatoroutdate.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatoroutdate.Name = "bindingNavigatoroutdate";
            this.bindingNavigatoroutdate.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatoroutdate.Size = new System.Drawing.Size(1123, 33);
            this.bindingNavigatoroutdate.TabIndex = 9;
            this.bindingNavigatoroutdate.Text = "bindingNavigator1";
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
            // bindingNavigatorrefresh
            // 
            this.bindingNavigatorrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorrefresh.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorrefresh.Image")));
            this.bindingNavigatorrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorrefresh.Name = "bindingNavigatorrefresh";
            this.bindingNavigatorrefresh.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorrefresh.Text = "Làm mới dữ liệu ";
            this.bindingNavigatorrefresh.Click += new System.EventHandler(this.bindingNavigatorrefresh_Click);
            // 
            // bindingNavigatorexit
            // 
            this.bindingNavigatorexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorexit.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorexit.Image")));
            this.bindingNavigatorexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorexit.Name = "bindingNavigatorexit";
            this.bindingNavigatorexit.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorexit.Text = "exit";
            this.bindingNavigatorexit.Click += new System.EventHandler(this.bindingNavigatorexit_Click);
            // 
            // dgvoutdate
            // 
            this.dgvoutdate.AllowUserToAddRows = false;
            this.dgvoutdate.AllowUserToResizeRows = false;
            this.dgvoutdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvoutdate.BackgroundColor = System.Drawing.Color.White;
            this.dgvoutdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvoutdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.nameUser,
            this.bookId,
            this.nameBook,
            this.diff,
            this.amount});
            this.contextMenuBar1.SetContextMenuEx(this.dgvoutdate, this.ctxmenu);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvoutdate.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvoutdate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvoutdate.Location = new System.Drawing.Point(0, 197);
            this.dgvoutdate.Name = "dgvoutdate";
            this.dgvoutdate.RowHeadersWidth = 62;
            this.dgvoutdate.RowTemplate.Height = 28;
            this.dgvoutdate.Size = new System.Drawing.Size(1123, 325);
            this.dgvoutdate.TabIndex = 10;
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ctxmenu});
            this.contextMenuBar1.Location = new System.Drawing.Point(499, 308);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(75, 33);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.contextMenuBar1.TabIndex = 11;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // ctxmenu
            // 
            this.ctxmenu.AutoExpandOnClick = true;
            this.ctxmenu.ImagePaddingHorizontal = 8;
            this.ctxmenu.Name = "ctxmenu";
            this.ctxmenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnrefresh,
            this.btnimportexcel,
            this.btnexportexcel,
            this.btnsave,
            this.btnthoat});
            this.ctxmenu.Text = "Menu";
            // 
            // btnrefresh
            // 
            this.btnrefresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.ImagePaddingHorizontal = 8;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnrefresh.Text = "làm mới dữ liệu ";
            // 
            // btnimportexcel
            // 
            this.btnimportexcel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnimportexcel.ImagePaddingHorizontal = 8;
            this.btnimportexcel.Name = "btnimportexcel";
            this.btnimportexcel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO);
            this.btnimportexcel.Text = "import excel";
            // 
            // btnexportexcel
            // 
            this.btnexportexcel.ImagePaddingHorizontal = 8;
            this.btnexportexcel.Name = "btnexportexcel";
            this.btnexportexcel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.btnexportexcel.Text = "export excel ";
            // 
            // btnsave
            // 
            this.btnsave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImagePaddingHorizontal = 8;
            this.btnsave.Name = "btnsave";
            this.btnsave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnsave.Text = "lưu dữ liệu ";
            // 
            // btnthoat
            // 
            this.btnthoat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImagePaddingHorizontal = 8;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlW);
            this.btnthoat.Text = "thoát";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtnamebook);
            this.groupPanel1.Controls.Add(this.cbxtenbook);
            this.groupPanel1.Controls.Add(this.txtnameuser);
            this.groupPanel1.Controls.Add(this.cbxtenuser);
            this.groupPanel1.Controls.Add(this.btntk);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1123, 151);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 8;
            this.groupPanel1.Text = "Danh sách sách được mượn quá han";
            // 
            // txtnamebook
            // 
            // 
            // 
            // 
            this.txtnamebook.Border.Class = "TextBoxBorder";
            this.txtnamebook.Location = new System.Drawing.Point(471, 73);
            this.txtnamebook.Name = "txtnamebook";
            this.txtnamebook.Size = new System.Drawing.Size(196, 26);
            this.txtnamebook.TabIndex = 19;
            this.txtnamebook.WatermarkText = "Nhập thông tin tim kiếm ";
            // 
            // cbxtenbook
            // 
            this.cbxtenbook.Location = new System.Drawing.Point(333, 73);
            this.cbxtenbook.Name = "cbxtenbook";
            this.cbxtenbook.Size = new System.Drawing.Size(112, 26);
            this.cbxtenbook.TabIndex = 18;
            this.cbxtenbook.Text = "Tên sách :";
            // 
            // txtnameuser
            // 
            // 
            // 
            // 
            this.txtnameuser.Border.Class = "TextBoxBorder";
            this.txtnameuser.Location = new System.Drawing.Point(471, 20);
            this.txtnameuser.Name = "txtnameuser";
            this.txtnameuser.Size = new System.Drawing.Size(196, 26);
            this.txtnameuser.TabIndex = 16;
            this.txtnameuser.WatermarkText = "Nhập thông tin tim kiếm ";
            // 
            // cbxtenuser
            // 
            this.cbxtenuser.BackColor = System.Drawing.Color.Transparent;
            this.cbxtenuser.Checked = true;
            this.cbxtenuser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxtenuser.CheckValue = "Y";
            this.cbxtenuser.Location = new System.Drawing.Point(333, 17);
            this.cbxtenuser.Name = "cbxtenuser";
            this.cbxtenuser.Size = new System.Drawing.Size(112, 29);
            this.cbxtenuser.TabIndex = 15;
            this.cbxtenuser.Text = "Tên độc giả :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAHV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã học viên ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên học viên ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIEMNGHE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Điểm nghe ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIEMDOC";
            this.dataGridViewTextBoxColumn4.HeaderText = "Điểm đọc ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIEMTONG";
            this.dataGridViewTextBoxColumn5.HeaderText = "Điểm tổng ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "point";
            this.dataGridViewTextBoxColumn6.HeaderText = "Điểm thi";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "Mã độc giả";
            this.userId.MinimumWidth = 8;
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Width = 150;
            // 
            // nameUser
            // 
            this.nameUser.DataPropertyName = "nameUser";
            this.nameUser.HeaderText = "Tên độc giả";
            this.nameUser.MinimumWidth = 8;
            this.nameUser.Name = "nameUser";
            this.nameUser.ReadOnly = true;
            this.nameUser.Width = 150;
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
            this.nameBook.HeaderText = "Tên sách";
            this.nameBook.MinimumWidth = 8;
            this.nameBook.Name = "nameBook";
            this.nameBook.ReadOnly = true;
            this.nameBook.Width = 150;
            // 
            // diff
            // 
            this.diff.DataPropertyName = "diff";
            this.diff.HeaderText = "Số ngày quá hạn";
            this.diff.MinimumWidth = 8;
            this.diff.Name = "diff";
            this.diff.Width = 150;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Số tiền phạt";
            this.amount.MinimumWidth = 8;
            this.amount.Name = "amount";
            this.amount.Width = 150;
            // 
            // Frm_outDate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1123, 522);
            this.Controls.Add(this.bindingNavigatoroutdate);
            this.Controls.Add(this.dgvoutdate);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_outDate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Độc giả mượn sách quá hạn ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_outDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatoroutdate)).EndInit();
            this.bindingNavigatoroutdate.ResumeLayout(false);
            this.bindingNavigatoroutdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvoutdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btntk;
        private System.Windows.Forms.BindingNavigator bindingNavigatoroutdate;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorrefresh;
        private System.Windows.Forms.ToolStripButton bindingNavigatorexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvoutdate;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem ctxmenu;
        private DevComponents.DotNetBar.ButtonItem btnrefresh;
        private DevComponents.DotNetBar.ButtonItem btnimportexcel;
        private DevComponents.DotNetBar.ButtonItem btnexportexcel;
        private DevComponents.DotNetBar.ButtonItem btnsave;
        private DevComponents.DotNetBar.ButtonItem btnthoat;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnameuser;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxtenuser;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnamebook;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxtenbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn diff;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}