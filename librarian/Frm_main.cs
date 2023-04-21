using DevComponents.DotNetBar;
using librarian.component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarian
{
    public partial class Frm_main : Office2007RibbonForm
    {

        #region Fields
        Form_connect m_Connection = null;
        #endregion

        #region Main
        #region Constructor
        public Frm_main()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void Frm_main_Load(object sender, EventArgs e)
        {
            Default();
            if (dataservice.OpenConnection())
            {
            }
            else
            {
                ReConnection(true);
            }
        }
        #endregion

        #region Kết nối lại CSDL
        public void ReConnection(Boolean check)
        {
            if (check)
                MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new Form_connect();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                return;
        }
        #endregion

        private void Frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult TL;
            TL = MessageBoxEx.Show("Bạn Có Muốn Thoát khỏi hệ thống không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (TL == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        #endregion

        #region Giao diện mặc định
        public void Default()
        {

            btndangnhapcontext.Enabled = true;
            btnthoat.Enabled = true;
            btnthoatcontext.Enabled = true;

            btndangxuatcontext.Enabled = false;
            btndoimatkhaucontext.Enabled = false;
            btnsaoluu.Enabled = true;
        }

        #endregion

        #region Form show
        #region Menu start
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsaoluu_Click(object sender, EventArgs e)
        {
            ReConnection(false);
        }

        #endregion

        #endregion

        private void btnkhoahoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormUser();
        }

        private void btnlophoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormCard();
        }

        private void btngiaovien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormBorrowBook();
        }

        private void btnhocvien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormType();
        }

        private void btnphanlop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPublishCompany();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormCreator();
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormBook();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormField();
        }

        private void btnbonus_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormList();
        }

        private void bntdiscipline_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormOutDate();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormBookRemind();
        }
    }
}
