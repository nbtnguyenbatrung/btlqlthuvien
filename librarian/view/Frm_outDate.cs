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

namespace librarian.view
{
    public partial class Frm_outDate : Form
    {

        #region Fields
        Ctr_BorrowedBook m_dataCtrl = new Ctr_BorrowedBook();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        public Frm_outDate()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        private void Frm_outDate_Load(object sender, EventArgs e)
        {
            m_dataCtrl.HienThi(dgvoutdate, bindingNavigatoroutdate);
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            m_dataCtrl.HienThiTk(dgvoutdate, bindingNavigatoroutdate,
                cbxtenuser.Checked, cbxtenbook.Checked, 
                txtnameuser.Text.Trim(), txtnamebook.Text.Trim());
        }

        private void bindingNavigatorexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorrefresh_Click(object sender, EventArgs e)
        {
            m_dataCtrl.HienThi(dgvoutdate, bindingNavigatoroutdate);
        }
    }
}
