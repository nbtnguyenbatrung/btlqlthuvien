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
    public partial class Frm_suasachcs : Form
    {

        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        DataTable tabledocgia = new DataTable();
        #endregion

        public Frm_suasachcs()
        {
            InitializeComponent();
        }

        private void Frm_suasachcs_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            HienThiComboBox();
        }

        private void HienThiComboBox()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_book2";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            m_DataAdapter.Fill(table);
            cmbmadocgia.DataSource = table;
            cmbmadocgia.DisplayMember = "bookName";
            cmbmadocgia.ValueMember = "bookId";
        }

        private void cmbmadocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbmadocgia.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "SELECT * FROM tb_book2 WHERE bookId=" + cmbmadocgia.SelectedValue;
                m_Command.ExecuteNonQuery();
                m_DataAdapter.SelectCommand = m_Command;
                tabledocgia.Clear();
                m_DataAdapter.Fill(tabledocgia);
                txttensach.Text = tabledocgia.Rows[0]["bookName"].ToString();
                txttentg.Text = tabledocgia.Rows[0]["creatorName"].ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = " UPDATE tb_book2 SET bookName ='" + txttensach.Text.Trim() + "'," +
                " creatorName='" + txttentg.Text.Trim() + "'" +
                " WHERE bookId = " + cmbmadocgia.SelectedValue;
            m_Command.ExecuteNonQuery();

            MessageBox.Show("Cậ nhật sách thành công", "Thông báo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
