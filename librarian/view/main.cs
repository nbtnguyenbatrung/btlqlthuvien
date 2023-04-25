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

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_docgia f = new Frm_docgia();
            //set data config
            f.TopLevel = false;
            //xóa trắng panel1
            panel1.Controls.Clear();
            //add form vào panel1
            panel1.Controls.Add(f);
            //resize form theo panel1
            f.Width = panel1.Width;
            f.Height = panel1.Height;
            //show  form
            f.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_sach f = new Frm_sach();
            //set data config
            f.TopLevel = false;
            //xóa trắng panel1
            panel1.Controls.Clear();
            //add form vào panel1
            panel1.Controls.Add(f);
            //resize form theo panel1
            f.Width = panel1.Width;
            f.Height = panel1.Height;
            //show  form
            f.Show();
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
    }
}
