﻿
namespace librarian.view
{
    partial class Frm_xoadocgia
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
            this.cmbmadocgia = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtCMT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtdiachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtchucdanh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dtpns = new System.Windows.Forms.DateTimePicker();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txttendocgia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbmadocgia
            // 
            this.cmbmadocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbmadocgia.FormattingEnabled = true;
            this.cmbmadocgia.Location = new System.Drawing.Point(410, 78);
            this.cmbmadocgia.Name = "cmbmadocgia";
            this.cmbmadocgia.Size = new System.Drawing.Size(445, 45);
            this.cmbmadocgia.TabIndex = 98;
            this.cmbmadocgia.SelectedIndexChanged += new System.EventHandler(this.cmbmadocgia_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(180, 65);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(171, 41);
            this.labelX1.TabIndex = 97;
            this.labelX1.Text = "Mã độc giả";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 96;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(329, 571);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 45);
            this.btnadd.TabIndex = 95;
            this.btnadd.Text = "XÓA";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtCMT
            // 
            // 
            // 
            // 
            this.txtCMT.Border.Class = "TextBoxBorder";
            this.txtCMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtCMT.Location = new System.Drawing.Point(410, 461);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(445, 37);
            this.txtCMT.TabIndex = 94;
            // 
            // labelX6
            // 
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX6.Location = new System.Drawing.Point(131, 446);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(236, 52);
            this.labelX6.TabIndex = 93;
            this.labelX6.Text = "Số chứng minh thư";
            // 
            // txtdiachi
            // 
            // 
            // 
            // 
            this.txtdiachi.Border.Class = "TextBoxBorder";
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtdiachi.Location = new System.Drawing.Point(410, 382);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(445, 37);
            this.txtdiachi.TabIndex = 92;
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX5.Location = new System.Drawing.Point(180, 371);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(171, 52);
            this.labelX5.TabIndex = 91;
            this.labelX5.Text = "Địa chỉ";
            // 
            // txtchucdanh
            // 
            // 
            // 
            // 
            this.txtchucdanh.Border.Class = "TextBoxBorder";
            this.txtchucdanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtchucdanh.Location = new System.Drawing.Point(410, 314);
            this.txtchucdanh.Name = "txtchucdanh";
            this.txtchucdanh.Size = new System.Drawing.Size(445, 37);
            this.txtchucdanh.TabIndex = 90;
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX4.Location = new System.Drawing.Point(180, 290);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(171, 52);
            this.labelX4.TabIndex = 89;
            this.labelX4.Text = "Chức danh";
            // 
            // dtpns
            // 
            this.dtpns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtpns.Location = new System.Drawing.Point(413, 230);
            this.dtpns.Name = "dtpns";
            this.dtpns.Size = new System.Drawing.Size(445, 37);
            this.dtpns.TabIndex = 88;
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(180, 215);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(171, 52);
            this.labelX3.TabIndex = 87;
            this.labelX3.Text = "Ngày sinh";
            // 
            // txttendocgia
            // 
            // 
            // 
            // 
            this.txttendocgia.Border.Class = "TextBoxBorder";
            this.txttendocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txttendocgia.Location = new System.Drawing.Point(413, 156);
            this.txttendocgia.Name = "txttendocgia";
            this.txttendocgia.Size = new System.Drawing.Size(442, 37);
            this.txttendocgia.TabIndex = 86;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(180, 151);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(171, 41);
            this.labelX2.TabIndex = 85;
            this.labelX2.Text = "Tên độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 37);
            this.label1.TabIndex = 84;
            this.label1.Text = "Xóa độc giả";
            // 
            // Frm_xoadocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 649);
            this.Controls.Add(this.cmbmadocgia);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtCMT);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtchucdanh);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.dtpns);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txttendocgia);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_xoadocgia";
            this.Text = "Frm_xoadocgia";
            this.Load += new System.EventHandler(this.Frm_xoadocgia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmadocgia;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCMT;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdiachi;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtchucdanh;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.DateTimePicker dtpns;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txttendocgia;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Label label1;
    }
}