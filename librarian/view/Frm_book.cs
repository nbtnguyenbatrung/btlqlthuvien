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
    public partial class Frm_book : Form
    {
        public Frm_book()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        #region Fields
        Ctr_book m_bookctrl = new Ctr_book();
        Ctr_Creator m_creatorctrl = new Ctr_Creator();
        Ctr_PublishingCompany m_PublishingCompanyctrl = new Ctr_PublishingCompany();
        Ctr_type m_typectrl = new Ctr_type();
        Ctr_field m_fieldctrl = new Ctr_field();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        #region load 
        private void Frm_book_Load(object sender, EventArgs e)
        {
            loadData();
        }
        #endregion

        #region thêm 
        private void bindingNavigatorthem_Click(object sender, EventArgs e)
        {
            if (dgvuser.RowCount == 0)
                bindingNavigatorxoa.Enabled = true;

            DataRow m_Row = m_bookctrl.ThemDongMoi();
            m_Row["status"] = "bình thường";
            m_bookctrl.ThemBook(m_Row);
            bindingNavigatorbook.BindingSource.MoveLast();
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
                        string select1 = "Select borrowBookId from tb_borrowBook where bookId=" + row.Cells["bookId"].Value;
                        OleDbCommand cmd1 = new OleDbCommand(select1, conn);
                        OleDbDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.Read())
                        {
                            MessageBox.Show("Sách đang được sử dụng không thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            reader1.Dispose();
                            cmd1.Dispose();
                            conn.Close();
                            break;
                        }

                        OleDbCommand cmd = new OleDbCommand("delete from tb_book where bookId =" + row.Cells["bookId"].Value, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                        bindingNavigatorbook.BindingSource.RemoveCurrent();
                        // Trả tài nguyên
                        cmd.Dispose();
                        conn.Close();
                    }
                    else
                    {
                        bindingNavigatorbook.BindingSource.RemoveCurrent();
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
            if (KiemTraTruocKhiLuu("creatorId") == true && KiemTraTruocKhiLuu("publishingCompanyId") == true &&
                KiemTraTruocKhiLuu("typeId") == true && KiemTraTruocKhiLuu("price") == true )
            {

                bindingNavigatorPositionItem.Focus();
                m_bookctrl.LuuBook();
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

            m_bookctrl.TimTheoTen(txttimkiem.Text);

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
            m_creatorctrl.HienThiDataGridViewComboBoxColumn(creatorId);
            m_PublishingCompanyctrl.HienThiDataGridViewComboBoxColumn(publishingCompanyId);
            m_typectrl.HienThiDataGridViewComboBoxColumn(typeId);
            m_fieldctrl.HienThiDataGridViewComboBoxColumn(fieldId);
            m_bookctrl.HienThi(dgvuser, bindingNavigatorbook);
        }

       
    }
}
