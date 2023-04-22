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
    public partial class Frm_Creator : Form
    {
        public Frm_Creator()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }
        #region Fields
        Ctr_Creator m_creatorctrl = new Ctr_Creator();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        #region load
        private void Frm_Creator_Load(object sender, EventArgs e)
        {
            loadData();
        }
        #endregion

        #region thêm 
        private void bindingNavigatorthem_Click(object sender, EventArgs e)
        {
            if (dgvuser.RowCount == 0)
                bindingNavigatorxoa.Enabled = true;

            DataRow m_Row = m_creatorctrl.ThemDongMoi();
            m_creatorctrl.ThemCreator(m_Row);
            bindingNavigatoruser.BindingSource.MoveLast();
        }

        #endregion

        #region xóa 
        private void bindingNavigatorxoa_Click(object sender, EventArgs e)
        {
            if (dgvuser.RowCount == 0)
                bindingNavigatorxoa.Enabled = false;

            else if ((MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

                foreach (DataGridViewRow row in dgvuser.SelectedRows)
                {
                    if (row.Cells["colmadg"].Value.ToString() != "")
                    {
                        conn.Open();
                        string select1 = "Select bookId from tb_book where creatorId=" + row.Cells["creatorId"].Value;
                        OleDbCommand cmd1 = new OleDbCommand(select1, conn);
                        OleDbDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.Read())
                        {
                            MessageBox.Show("Độc giả đang được sử dụng không thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            reader1.Dispose();
                            cmd1.Dispose();
                            conn.Close();
                            break;
                        }

                        OleDbCommand cmd = new OleDbCommand("delete from tb_creator where creatorId =" + row.Cells["creatorId"].Value, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                        bindingNavigatoruser.BindingSource.RemoveCurrent();
                        // Trả tài nguyên
                        cmd.Dispose();
                        conn.Close();
                    }
                    else
                    {
                        bindingNavigatoruser.BindingSource.RemoveCurrent();
                    }
                        
                }

            }
        }
        #endregion

        #region kiểm tr trươc khi luu 
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvuser.Rows)
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
            if (KiemTraTruocKhiLuu("creatorName") == true)
            {

                bindingNavigatorPositionItem.Focus();
                m_creatorctrl.LuuCreator();
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

            m_creatorctrl.TimTheoTen(txttimkiem.Text);

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
            m_creatorctrl.HienThi(dgvuser, bindingNavigatoruser);
        }

        
    }
}
