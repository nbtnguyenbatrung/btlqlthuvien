
namespace librarian.view
{
    partial class Frm_listsach
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvsach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(194, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sách";
            // 
            // dgvsach
            // 
            this.dgvsach.AllowUserToAddRows = false;
            this.dgvsach.AllowUserToDeleteRows = false;
            this.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.bookId,
            this.bookName,
            this.creatorName});
            this.dgvsach.Location = new System.Drawing.Point(12, 152);
            this.dgvsach.Name = "dgvsach";
            this.dgvsach.ReadOnly = true;
            this.dgvsach.RowHeadersWidth = 62;
            this.dgvsach.RowTemplate.Height = 28;
            this.dgvsach.Size = new System.Drawing.Size(773, 246);
            this.dgvsach.TabIndex = 3;
            this.dgvsach.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 150;
            // 
            // bookId
            // 
            this.bookId.DataPropertyName = "bookId";
            this.bookId.HeaderText = "Mã sách";
            this.bookId.MinimumWidth = 8;
            this.bookId.Name = "bookId";
            this.bookId.Width = 150;
            // 
            // bookName
            // 
            this.bookName.DataPropertyName = "bookName";
            this.bookName.HeaderText = "Tên sách";
            this.bookName.MinimumWidth = 8;
            this.bookName.Name = "bookName";
            this.bookName.Width = 150;
            // 
            // creatorName
            // 
            this.creatorName.DataPropertyName = "creatorName";
            this.creatorName.HeaderText = "Tên tác giả";
            this.creatorName.MinimumWidth = 8;
            this.creatorName.Name = "creatorName";
            this.creatorName.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_listsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvsach);
            this.Controls.Add(this.label1);
            this.Name = "Frm_listsach";
            this.Text = "Frm_listsach";
            this.Load += new System.EventHandler(this.Frm_listsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvsach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorName;
    }
}