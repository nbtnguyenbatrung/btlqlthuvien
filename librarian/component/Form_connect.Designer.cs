
namespace librarian.component
{
    partial class Form_connect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_connect));
            this.btncencel = new DevComponents.DotNetBar.ButtonX();
            this.btnok = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntestconnect = new DevComponents.DotNetBar.ButtonX();
            this.txtserver = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncencel
            // 
            this.btncencel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncencel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncencel.Location = new System.Drawing.Point(692, 444);
            this.btncencel.Name = "btncencel";
            this.btncencel.Size = new System.Drawing.Size(111, 33);
            this.btncencel.TabIndex = 37;
            this.btncencel.Text = "CENCEL";
            this.btncencel.Click += new System.EventHandler(this.btncencel_Click);
            // 
            // btnok
            // 
            this.btnok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(535, 444);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(138, 33);
            this.btnok.TabIndex = 36;
            this.btnok.Text = "OK";
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(228, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 2);
            this.panel1.TabIndex = 35;
            // 
            // btntestconnect
            // 
            this.btntestconnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntestconnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btntestconnect.Location = new System.Drawing.Point(535, 265);
            this.btntestconnect.Name = "btntestconnect";
            this.btntestconnect.Size = new System.Drawing.Size(203, 40);
            this.btntestconnect.TabIndex = 34;
            this.btntestconnect.Text = "Test Connect";
            this.btntestconnect.Click += new System.EventHandler(this.btntestconnect_Click);
            // 
            // txtserver
            // 
            // 
            // 
            // 
            this.txtserver.Border.Class = "TextBoxBorder";
            this.txtserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserver.Location = new System.Drawing.Point(450, 132);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(338, 35);
            this.txtserver.TabIndex = 33;
            this.txtserver.WatermarkText = "Tên Server ";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(279, 128);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(88, 36);
            this.labelX1.TabIndex = 32;
            this.labelX1.Text = "Server :";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.reflectionImage1);
            this.groupPanel1.Location = new System.Drawing.Point(0, 29);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(269, 518);
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
            this.groupPanel1.TabIndex = 31;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackColor = System.Drawing.Color.Transparent;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(16, 2);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(230, 506);
            this.reflectionImage1.TabIndex = 0;
            // 
            // Form_connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(976, 606);
            this.Controls.Add(this.btncencel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btntestconnect);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_connect";
            this.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU";
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btncencel;
        private DevComponents.DotNetBar.ButtonX btnok;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btntestconnect;
        private DevComponents.DotNetBar.Controls.TextBoxX txtserver;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
    }
}