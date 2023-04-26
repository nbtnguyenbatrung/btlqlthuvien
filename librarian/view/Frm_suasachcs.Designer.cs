
namespace librarian.view
{
    partial class Frm_suasachcs
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttentg = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txttensach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbmadocgia = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 76;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(188, 365);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 45);
            this.btnadd.TabIndex = 75;
            this.btnadd.Text = "CẬP NHẬT";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(248, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 74;
            this.label1.Text = "Sửa sách";
            // 
            // txttentg
            // 
            // 
            // 
            // 
            this.txttentg.Border.Class = "TextBoxBorder";
            this.txttentg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttentg.Location = new System.Drawing.Point(333, 254);
            this.txttentg.Name = "txttentg";
            this.txttentg.Size = new System.Drawing.Size(442, 44);
            this.txttentg.TabIndex = 73;
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(18, 245);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(255, 52);
            this.labelX3.TabIndex = 72;
            this.labelX3.Text = "Tên tác giả";
            // 
            // txttensach
            // 
            // 
            // 
            // 
            this.txttensach.Border.Class = "TextBoxBorder";
            this.txttensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttensach.Location = new System.Drawing.Point(333, 174);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(442, 44);
            this.txttensach.TabIndex = 71;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(18, 165);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(255, 52);
            this.labelX2.TabIndex = 70;
            this.labelX2.Text = "Tên sách ";
            // 
            // cmbmadocgia
            // 
            this.cmbmadocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbmadocgia.FormattingEnabled = true;
            this.cmbmadocgia.Location = new System.Drawing.Point(330, 93);
            this.cmbmadocgia.Name = "cmbmadocgia";
            this.cmbmadocgia.Size = new System.Drawing.Size(445, 45);
            this.cmbmadocgia.TabIndex = 85;
            this.cmbmadocgia.SelectedIndexChanged += new System.EventHandler(this.cmbmadocgia_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(18, 93);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(171, 41);
            this.labelX1.TabIndex = 84;
            this.labelX1.Text = "Mã sách";
            // 
            // Frm_suasachcs
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
            this.Name = "Frm_suasachcs";
            this.Text = "Frm_suasachcs";
            this.Load += new System.EventHandler(this.Frm_suasachcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttentg;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txttensach;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ComboBox cmbmadocgia;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}