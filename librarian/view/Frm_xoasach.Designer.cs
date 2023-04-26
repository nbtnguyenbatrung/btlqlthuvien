
namespace librarian.view
{
    partial class Frm_xoasach
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttentg = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txttensach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cmbmadocgia
            // 
            this.cmbmadocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbmadocgia.FormattingEnabled = true;
            this.cmbmadocgia.Location = new System.Drawing.Point(334, 99);
            this.cmbmadocgia.Name = "cmbmadocgia";
            this.cmbmadocgia.Size = new System.Drawing.Size(445, 45);
            this.cmbmadocgia.TabIndex = 94;
            this.cmbmadocgia.SelectedIndexChanged += new System.EventHandler(this.cmbmadocgia_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(22, 99);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(171, 41);
            this.labelX1.TabIndex = 93;
            this.labelX1.Text = "Mã sách";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 92;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(192, 371);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 45);
            this.btnadd.TabIndex = 91;
            this.btnadd.Text = "XÓA";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(252, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 90;
            this.label1.Text = "Xóa sách";
            // 
            // txttentg
            // 
            // 
            // 
            // 
            this.txttentg.Border.Class = "TextBoxBorder";
            this.txttentg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttentg.Location = new System.Drawing.Point(337, 260);
            this.txttentg.Name = "txttentg";
            this.txttentg.Size = new System.Drawing.Size(442, 44);
            this.txttentg.TabIndex = 89;
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(22, 251);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(255, 52);
            this.labelX3.TabIndex = 88;
            this.labelX3.Text = "Tên tác giả";
            // 
            // txttensach
            // 
            // 
            // 
            // 
            this.txttensach.Border.Class = "TextBoxBorder";
            this.txttensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttensach.Location = new System.Drawing.Point(337, 180);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(442, 44);
            this.txttensach.TabIndex = 87;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(22, 171);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(255, 52);
            this.labelX2.TabIndex = 86;
            this.labelX2.Text = "Tên sách ";
            // 
            // Frm_xoasach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbmadocgia);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttentg);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.labelX2);
            this.Name = "Frm_xoasach";
            this.Text = "Frm_xoasach";
            this.Load += new System.EventHandler(this.Frm_xoasach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmadocgia;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttentg;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txttensach;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}