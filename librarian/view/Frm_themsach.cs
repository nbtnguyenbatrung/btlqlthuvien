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

namespace librarian.view
{
    public partial class Frm_themsach : Form
    {

        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        #endregion

        public Frm_themsach()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();

            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = " insert into tb_book2(bookName,creatorName) " +
                "values('" + txttensach.Text.Trim() +
                "','" + txttentg.Text.Trim() + "')";
            m_Command.ExecuteNonQuery();

            MessageBox.Show("Sách được thêm thành công", "Thông báo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
