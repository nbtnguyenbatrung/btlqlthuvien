
namespace librarian.view
{
    partial class Frm_themsach
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
            this.txttentg = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txttensach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttentg
            // 
            // 
            // 
            // 
            this.txttentg.Border.Class = "TextBoxBorder";
            this.txttentg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttentg.Location = new System.Drawing.Point(346, 213);
            this.txttentg.Name = "txttentg";
            this.txttentg.Size = new System.Drawing.Size(442, 44);
            this.txttentg.TabIndex = 52;
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(31, 204);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(255, 52);
            this.labelX3.TabIndex = 51;
            this.labelX3.Text = "Tên tác giả";
            // 
            // txttensach
            // 
            // 
            // 
            // 
            this.txttensach.Border.Class = "TextBoxBorder";
            this.txttensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttensach.Location = new System.Drawing.Point(346, 133);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(442, 44);
            this.txttensach.TabIndex = 50;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(31, 124);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(255, 52);
            this.labelX2.TabIndex = 48;
            this.labelX2.Text = "Tên sách ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(261, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 53;
            this.label1.Text = "Thêm sách";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 69;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(201, 324);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 45);
            this.btnadd.TabIndex = 68;
            this.btnadd.Text = "THÊM";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Frm_themsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttentg);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.labelX2);
            this.Name = "Frm_themsach";
            this.Text = "Frm_themsach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txttentg;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txttensach;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
    }
}