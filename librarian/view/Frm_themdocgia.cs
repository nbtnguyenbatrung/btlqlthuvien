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
    public partial class Frm_themdocgia : Form
    {

        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        #endregion

        public Frm_themdocgia()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();

            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = " insert into tb_user(nameUser,birthday,jobTitle,address,cmt) " +
                "values('" + txttendocgia.Text.Trim() +
                "','" + dtpns.Value.ToString() + "','" + txtchucdanh.Text.Trim() + "'," +
                "'" + txtdiachi.Text.Trim() + "','" + txtCMT.Text.Trim() + "')";
            m_Command.ExecuteNonQuery();
            m_Connection.Close();
            MessageBox.Show("Độc giả đã được thêm", "Thông báo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
