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
using librarian.report;
using System.Data.OleDb;
using DevComponents.DotNetBar;

namespace librarian.report
{
    public partial class Frm_bookRemind : Form
    {
        public Frm_bookRemind()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        #region Fields
        Ctr_user m_userctrl = new Ctr_user();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        private void Frm_bookRemind_Load(object sender, EventArgs e)
        {
            m_userctrl.HienThioutDate( dgvoutdate, bindingNavigatoroutdate, false, "");
        }

        private void bindingNavigatorrefresh_Click(object sender, EventArgs e)
        {
            m_userctrl.HienThioutDate(dgvoutdate, bindingNavigatoroutdate, false, "");
        }

        private void bindingNavigatorexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            m_userctrl.HienThioutDate(dgvoutdate, bindingNavigatoroutdate, 
                true, txtnameuser.Text.Trim());
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvoutdate.SelectedRows)
            {
                Frm_xuat m_hvchungchi = new Frm_xuat(row.Cells["userIdView"].Value.ToString(),
                    row.Cells["nameUserView"].Value.ToString() );
                m_hvchungchi.Show();
            }
        }
    }
}
