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
    public partial class Frm_listdocgia : Form
    {

        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        #endregion

        public Frm_listdocgia()
        {
            InitializeComponent();
        }

        private void Frm_listdocgia_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
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

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvuser.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
