using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librarian.control;
using librarian.component;
using System.Data.OleDb;
using DevComponents.DotNetBar;

namespace librarian.view
{
    public partial class Frm_field : Form
    {
        public Frm_field()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        #region Fields
        Ctr_field m_fieldctrl = new Ctr_field();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        #region load 
        private void Frm_field_Load(object sender, EventArgs e)
        {
            loadData();
        }
        #endregion

        #region thêm 
        private void bindingNavigatorthem_Click(object sender, EventArgs e)
        {
            if (dgvfield.RowCount == 0)
                bindingNavigatorxoa.Enabled = true;

            DataRow m_Row = m_fieldctrl.ThemDongMoi();
            m_fieldctrl.ThemField(m_Row);
            bindingNavigatorfieldview.BindingSource.MoveLast();
        }

        #endregion

        #region xóa 
        private void bindingNavigatorxoa_Click(object sender, EventArgs e)
        {
            if (dgvfield.RowCount == 0)
                bindingNavigatorxoa.Enabled = false;

            else if ((MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

                foreach (DataGridViewRow row in dgvfield.SelectedRows)
                {
                    if (row.Cells["colmadg"].Value.ToString() != "")
                    {
                        conn.Open();
                        string select1 = "Select bookId from tb_book where fieldId=" + row.Cells["fieldId"].Value;
                        OleDbCommand cmd1 = new OleDbCommand(select1, conn);
                        OleDbDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.Read())
                        {
                            MessageBox.Show("Thể loại đang được sử dụng không thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            reader1.Dispose();
                            cmd1.Dispose();
                            conn.Close();
                            break;
                        }

                        OleDbCommand cmd = new OleDbCommand("delete from tb_field where fieldId =" + row.Cells["fieldId"].Value, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                        bindingNavigatorfieldview.BindingSource.RemoveCurrent();
                        // Trả tài nguyên
                        cmd.Dispose();
                        conn.Close();
                    }
                    else
                    {
                        bindingNavigatorfieldview.BindingSource.RemoveCurrent();
                    }
                        
                }

            }
        }
        #endregion

        #region kiểm tr trươc khi luu 
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvfield.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng! hoặc bạn chưa nhấn enter", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion 
        #region lưu 
        private void bindingNavigatorsave_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("fieldName") == true)
            {

                bindingNavigatorPositionItem.Focus();
                m_fieldctrl.LuuField();
                loadData();
                MessageBox.Show("Cập nhật dữ liệu thành công ", "Thông báo!");
            }
        }
        #endregion

        #region thoát 
        private void bindingNavigatorexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvkhoahoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            TimKiemUser();
        }

        void TimKiemUser()
        {

            m_fieldctrl.TimTheoTen(txttimkiem.Text);

        }

        private void btnall_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void bindingNavigatorcancel_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            m_fieldctrl.HienThi(dgvfield, bindingNavigatorfieldview);
        }

       
    }
}
