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
    public partial class Frm_card : Form
    {
        public Frm_card()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        #region Fields
        Ctr_user m_userctrl = new Ctr_user();
        Ctr_card m_cardctrl = new Ctr_card();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        #region load 
        private void Frm_card_Load(object sender, EventArgs e)
        {
            loadData();
        }
        #endregion

        #region thêm 
        private void bindingNavigatorthem_Click(object sender, EventArgs e)
        {
            if (dgvcard.RowCount == 0)
                bindingNavigatorxoa.Enabled = true;

            DataRow m_Row = m_cardctrl.ThemDongMoi();
            m_Row["fromDate"] = DateTime.Today;
            m_Row["toDate"] = DateTime.Today;
            m_Row["numberBook"] = 1;
            m_Row["borrowedTime"] = 3;
            m_Row["depositMoney"] = 0;
            m_Row["status"] = "Mới phát hành";
            m_cardctrl.ThemCard(m_Row);
            bindingNavigatorcard.BindingSource.MoveLast();
        }

        #endregion

        #region xóa 
        private void bindingNavigatorxoa_Click(object sender, EventArgs e)
        {
            if (dgvcard.RowCount == 0)
                bindingNavigatorxoa.Enabled = false;

            else if ((MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

                foreach (DataGridViewRow row in dgvcard.SelectedRows)
                {
                    if (row.Cells["colmadg"].Value.ToString() != "")
                    {
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand("delete from tb_card where cardId =" + row.Cells["cardId"].Value, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                        bindingNavigatorcard.BindingSource.RemoveCurrent();
                        // Trả tài nguyên
                        cmd.Dispose();
                        conn.Close();
                    }
                    else
                    {
                        bindingNavigatorcard.BindingSource.RemoveCurrent();
                    }
                       
                }

            }
        }
        #endregion

        #region kiểm tr trươc khi luu 
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvcard.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô có * không được rỗng! hoặc bạn chưa nhấn enter", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (KiemTraTruocKhiLuu("userId") == true && KiemTraTruocKhiLuu("numberBook") == true &&
                KiemTraTruocKhiLuu("borrowedTime") == true && KiemTraTruocKhiLuu("depositMoney") == true &&
                KiemTraTruocKhiLuu("fromDate") == true && KiemTraTruocKhiLuu("toDate") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_cardctrl.LuuCard();
                /*loadData();*/
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
            TimKiemCard();
        }

        void TimKiemCard()
        {

            m_cardctrl.TimTheoTen(txttimkiem.Text);

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
            m_userctrl.HienThiDataGridViewComboBoxColumn(userId);
            m_cardctrl.HienThi(dgvcard, bindingNavigatorcard);
        }

        
    }
}
