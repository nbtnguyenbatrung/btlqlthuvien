using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librarian.component;
using DevComponents.DotNetBar;
using System.Data.OleDb;

namespace librarian.view
{
    public partial class main : Form
    {
        #region Fields
        private static OleDbConnection m_Connection1;
        Form_connect m_Connection = null;
        #endregion
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            if (dataservice.OpenConnection())
            {
            }
            else
            {
                độcGiảToolStripMenuItem.Enabled = false;
                sáchToolStripMenuItem.Enabled = false;
                ReConnection(true);
            }
        }

        #region Kết nối lại CSDL
        public void ReConnection(Boolean check)
        {
            if (check)
                MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new Form_connect();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                if (checkConnect())
                {
                    độcGiảToolStripMenuItem.Enabled = true;
                    sáchToolStripMenuItem.Enabled = true;
                }
                else
                {
                    ReConnection(true);
                }
            }
            else
                return;
        }
        #endregion

        private bool checkConnect()
        {
            try
            {
                string m_ConnectString = dataservice.ConnectionStringNew();
                m_Connection1 = new OleDbConnection(m_ConnectString);
                m_Connection1.Open();
                return true;
            }
            catch
            {
                m_Connection1.Close();
                return false;
            }
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listdocgia f = new Frm_listdocgia();
            f.Show();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_themdocgia f = new Frm_themdocgia();
            f.Show();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_suadocgia f = new Frm_suadocgia();
            f.Show();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_xoadocgia f = new Frm_xoadocgia();
            f.Show();
        }

        private void danhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_listsach f = new Frm_listsach();
            f.Show();
        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_themsach f = new Frm_themsach();
            f.Show();
        }

        private void sửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_suasachcs f = new Frm_suasachcs();
            f.Show();
        }

        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_xoasach f = new Frm_xoasach();
            f.Show();
        }
    }
}
