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
    public partial class Frm_User : Form
    {
        public Frm_User()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        #region Fields
        Ctr_user m_userctrl = new Ctr_user();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        #region load 
        private void Frm_User_Load(object sender, EventArgs e)
        {
            loadData();
        }
        #endregion

        #region thêm 
        private void bindingNavigatorthem_Click(object sender, EventArgs e)
        {
            if (dgvuser.RowCount == 0)
                bindingNavigatorxoa.Enabled = true;

            DataRow m_Row = m_userctrl.ThemDongMoi();
            m_Row["nameUser"] = "";
            m_Row["birthday"] = DateTime.Today;
            m_Row["jobTitle"] = "";
            m_Row["address"] = "";
            m_Row["cmt"] = "";
            m_userctrl.ThemUser(m_Row);
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
                        string select1 = "Select cardId from tb_card where userId=" + row.Cells["colmadg"].Value;
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

                        OleDbCommand cmd = new OleDbCommand("delete from tb_user where userId =" + row.Cells["colmadg"].Value, conn);
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
            if (KiemTraTruocKhiLuu("nameUser") == true)
            {

                bindingNavigatorPositionItem.Focus();
                m_userctrl.LuuUser();
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
            
            m_userctrl.TimTheoTen(txttimkiem.Text);
            
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
            m_userctrl.HienThi(dgvuser, bindingNavigatoruser);
        }

    }
}
