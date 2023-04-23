
namespace librarian.view
{
    partial class Frm_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_list));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.coltensach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmasach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvchuaphan = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colnumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvphan = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colmadocgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltendocgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colnumbermoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colnumberquahan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colnumbertra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefreshbook = new DevComponents.DotNetBar.ButtonX();
            this.btnRefreshuser = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnRefreshbook);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(564, 78);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Danh sách sách đang được mượn";
            // 
            // coltensach
            // 
            this.coltensach.Text = "Tên sách";
            this.coltensach.Width = 150;
            // 
            // colmasach
            // 
            this.colmasach.Text = "Mã sách";
            this.colmasach.Width = 150;
            // 
            // lvchuaphan
            // 
            // 
            // 
            // 
            this.lvchuaphan.Border.Class = "ListViewBorder";
            this.lvchuaphan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmasach,
            this.coltensach,
            this.colnumber});
            this.lvchuaphan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvchuaphan.FullRowSelect = true;
            this.lvchuaphan.GridLines = true;
            this.lvchuaphan.Location = new System.Drawing.Point(0, 78);
            this.lvchuaphan.Name = "lvchuaphan";
            this.lvchuaphan.Size = new System.Drawing.Size(564, 571);
            this.lvchuaphan.SmallImageList = this.imageList1;
            this.lvchuaphan.TabIndex = 2;
            this.lvchuaphan.UseCompatibleStateImageBehavior = false;
            this.lvchuaphan.View = System.Windows.Forms.View.Details;
            // 
            // colnumber
            // 
            this.colnumber.Text = "Số lượng đang  mượn";
            this.colnumber.Width = 150;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvphan);
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1128, 649);
            this.splitContainer1.SplitterDistance = 564;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvchuaphan);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 649);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 78);
            this.panel3.TabIndex = 1;
            // 
            // lvphan
            // 
            // 
            // 
            // 
            this.lvphan.Border.Class = "ListViewBorder";
            this.lvphan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmadocgia,
            this.coltendocgia,
            this.colnumbermoi,
            this.colnumbertra,
            this.colnumberquahan});
            this.lvphan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvphan.FullRowSelect = true;
            this.lvphan.GridLines = true;
            this.lvphan.Location = new System.Drawing.Point(0, 78);
            this.lvphan.Name = "lvphan";
            this.lvphan.Size = new System.Drawing.Size(560, 571);
            this.lvphan.SmallImageList = this.imageList1;
            this.lvphan.TabIndex = 1;
            this.lvphan.UseCompatibleStateImageBehavior = false;
            this.lvphan.View = System.Windows.Forms.View.Details;
            // 
            // colmadocgia
            // 
            this.colmadocgia.Text = "Mã độc giả";
            this.colmadocgia.Width = 150;
            // 
            // coltendocgia
            // 
            this.coltendocgia.Text = "Tên độc giả";
            this.coltendocgia.Width = 150;
            // 
            // colnumbermoi
            // 
            this.colnumbermoi.Text = "Số sách đang mượn";
            this.colnumbermoi.Width = 200;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnRefreshuser);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(560, 78);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "Danh sách độc giả mươn sách";
            // 
            // colnumberquahan
            // 
            this.colnumberquahan.Text = "Số sách mượn quá hạn";
            // 
            // colnumbertra
            // 
            this.colnumbertra.Text = "Số sách đã trả";
            // 
            // btnRefreshbook
            // 
            this.btnRefreshbook.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefreshbook.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRefreshbook.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshbook.Image")));
            this.btnRefreshbook.Location = new System.Drawing.Point(225, 14);
            this.btnRefreshbook.Name = "btnRefreshbook";
            this.btnRefreshbook.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshbook.TabIndex = 0;
            this.btnRefreshbook.Tooltip = "làm mới ứng dụng";
            this.btnRefreshbook.Click += new System.EventHandler(this.btnRefreshbook_Click);
            // 
            // btnRefreshuser
            // 
            this.btnRefreshuser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefreshuser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRefreshuser.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshuser.Image")));
            this.btnRefreshuser.Location = new System.Drawing.Point(258, 14);
            this.btnRefreshuser.Name = "btnRefreshuser";
            this.btnRefreshuser.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshuser.TabIndex = 0;
            this.btnRefreshuser.Tooltip = "làm mới dữ liệu";
            this.btnRefreshuser.Click += new System.EventHandler(this.btnRefreshuser_Click);
            // 
            // Frm_list
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1128, 649);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_list";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sách mượn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_list_Load);
            this.groupPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.ColumnHeader coltensach;
        private System.Windows.Forms.ColumnHeader colmasach;
        private DevComponents.DotNetBar.Controls.ListViewEx lvchuaphan;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.ListViewEx lvphan;
        private System.Windows.Forms.ColumnHeader colmadocgia;
        private System.Windows.Forms.ColumnHeader coltendocgia;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColumnHeader colnumber;
        private System.Windows.Forms.ColumnHeader colnumbermoi;
        private System.Windows.Forms.ColumnHeader colnumbertra;
        private System.Windows.Forms.ColumnHeader colnumberquahan;
        private DevComponents.DotNetBar.ButtonX btnRefreshbook;
        private DevComponents.DotNetBar.ButtonX btnRefreshuser;
    }
}