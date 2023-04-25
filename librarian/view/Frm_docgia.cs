using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using librarian.component;
using librarian.control;
using DevComponents.DotNetBar;

namespace librarian.view
{
    public partial class Frm_docgia : Form
    {

        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        #endregion

        public Frm_docgia()
        {
            InitializeComponent();
        }

        private void Frm_docgia_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            loadData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txttendocgia.Text = "";
            txtdiachi.Text = "";
            txtchucdanh.Text = "";
            txtCMT.Text = "";
            dtpns.Value = DateTime.Today;
            btnedit.Visible = false;
            btnxoa.Visible = false;
            btnluu.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtmadocgia.Text != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = " UPDATE tb_user SET nameUser ='" + txttendocgia.Text.Trim() + "'," +
                    "birthday='" + dtpns.Value.ToString() + "', jobTitle='" + txtchucdanh.Text.Trim() + "'," +
                    "address='" + txtdiachi.Text.Trim() + "', cmt='" + txtCMT.Text.Trim() + "'" +
                    " WHERE userId = " + Int64.Parse(txtmadocgia.Text);
                m_Command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                loadData();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu(txttendocgia.Text))
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = " insert into tb_user(nameUser,birthday,jobTitle,address,cmt) " +
                    "values('" + txttendocgia.Text.Trim() +
                    "','" + dtpns.Value.ToString() + "','" + txtchucdanh.Text.Trim() + "'," +
                    "'" + txtdiachi.Text.Trim() + "','" + txtCMT.Text.Trim() + "')";
                m_Command.ExecuteNonQuery();

                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo!");


                loadData();
                // Trả tài nguyên

                btnedit.Visible = true;
                btnxoa.Visible = true;
                btnluu.Visible = false;
                btnHuy.Visible = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txttendocgia.Text = "";
            txtdiachi.Text = "";
            txtchucdanh.Text = "";
            txtCMT.Text = "";
            dtpns.Value = DateTime.Today;
            btnedit.Visible = true;
            btnxoa.Visible = true;
            btnluu.Visible = false;
            btnHuy.Visible = false;
            loadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmadocgia.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Thuc hien xoa du lieu
                    m_Command.CommandText = "delete from tb_user where userId =" + txtmadocgia.Text;
                    m_Command.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                    loadData();
                    txttendocgia.Text = "";
                    txtdiachi.Text = "";
                    txtchucdanh.Text = "";
                    txtCMT.Text = "";
                    dtpns.Value = DateTime.Today;
                }
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            if (txttk.Text.Trim() != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "SELECT * FROM tb_user WHERE nameUser LIKE '%" + txttk.Text.Trim() + "%'";
                m_Command.ExecuteNonQuery();
                m_DataAdapter.SelectCommand = m_Command;
                table.Clear();
                m_DataAdapter.Fill(table);
                dgvuser.DataSource = table;
            }
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            loadData();
        }

        private void loadData()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_user ";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            table.Clear();
            m_DataAdapter.Fill(table);
            dgvuser.DataSource = table;
        }

        private void dgvuser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow slc_row = dgvuser.Rows[e.RowIndex];
            for (int i = 0; i < slc_row.Cells.Count; i++)
            {
                txtmadocgia.Text = slc_row.Cells[1].Value.ToString();
                txttendocgia.Text = slc_row.Cells[2].Value.ToString();
                dtpns.Value = DateTime.Parse(slc_row.Cells[3].Value.ToString());
                txtchucdanh.Text = slc_row.Cells[4].Value.ToString();
                txtdiachi.Text = slc_row.Cells[5].Value.ToString();
                txtCMT.Text = slc_row.Cells[6].Value.ToString();
            }
        }

        private void dgvuser_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvuser.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        #region kiểm tr trươc khi luu 
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            if (cellString.Trim() == "")
            {
                MessageBoxEx.Show("Giá trị của ô * không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion
    }
}
