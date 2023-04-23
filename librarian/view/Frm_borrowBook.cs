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
    public partial class Frm_borrowBook : Form
    {
        public Frm_borrowBook()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        #region Fields
        Ctr_user m_userctrl = new Ctr_user();
        Ctr_book m_bookctrl = new Ctr_book();
        Ctr_borrowBook m_borrowBookctrl = new Ctr_borrowBook();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        #region load 
        private void Frm_borrowBook_Load(object sender, EventArgs e)
        {
            loadData();
        }
        #endregion

        #region thêm 
        private void bindingNavigatorthem_Click(object sender, EventArgs e)
        {
            if (dgvborrowbook.RowCount == 0)
                bindingNavigatorxoa.Enabled = true;

            DataRow m_Row = m_borrowBookctrl.ThemDongMoi();
            m_Row["deadDate"] = DateTime.Today;
            m_Row["actualDate"] = DateTime.Today;
            m_Row["status"] = "Mượn";
            m_Row["statusQuo"] = "bình thường";
            m_borrowBookctrl.ThemBorrowBook(m_Row);
            bindingNavigatorborrowbook.BindingSource.MoveLast();
        }

        #endregion

        #region xóa 
        private void bindingNavigatorxoa_Click(object sender, EventArgs e)
        {
            if (dgvborrowbook.RowCount == 0)
                bindingNavigatorxoa.Enabled = false;

            else if ((MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

                foreach (DataGridViewRow row in dgvborrowbook.SelectedRows)
                {
                    if (row.Cells["colmadg"].Value.ToString() != "")
                    {
                        OleDbCommand cmd = new OleDbCommand("delete from tb_borrowBook where borrowBookId =" + row.Cells["colmadg"].Value, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                        bindingNavigatorborrowbook.BindingSource.RemoveCurrent();
                        // Trả tài nguyên
                        cmd.Dispose();
                        conn.Close();
                    }
                    else
                    {
                        bindingNavigatorborrowbook.BindingSource.RemoveCurrent();
                    }
                     
                }

            }
        }
        #endregion

        #region kiểm tr trươc khi luu 
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvborrowbook.Rows)
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

        public Boolean KiemTraTruocKhiLuudate(String cellString1, String cellString2)
        {

            foreach (DataGridViewRow row in dgvborrowbook.Rows)
            {
                DateTime date1 = Convert.ToDateTime(row.Cells[cellString1].Value.ToString());
                DateTime date2 = Convert.ToDateTime(row.Cells[cellString2].Value.ToString());


                if (DateTime.Compare(date1, date2) > 0)
                {
                    MessageBoxEx.Show("ngày trả sách thực tế phải lớn hơn ngày trả sách ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }

            return true;
        }

        #endregion 
        #region lưu 
        private void bindingNavigatorsave_Click(object sender, EventArgs e)
        {

            if (KiemTraTruocKhiLuu("userId") == true && KiemTraTruocKhiLuu("bookId") == true &&
                KiemTraTruocKhiLuudate("deadDate" , "actualDate") == true )
            {

                bindingNavigatorPositionItem.Focus();
                m_borrowBookctrl.LuuBorrowBook();
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
            m_userctrl.HienThiDataGridViewComboBoxColumnCard(userId);
            m_bookctrl.HienThiDataGridViewComboBoxColumn(bookId);
            m_borrowBookctrl.HienThi(dgvborrowbook, bindingNavigatorborrowbook);
        }        
    }
}
