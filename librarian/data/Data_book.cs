using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using librarian.component;
using System.Data.OleDb;

namespace librarian.data
{
    class Data_book
    {
        dataservice m_BookData = new dataservice();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);

        public DataTable LayDsBook()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_book");
            m_BookData.Load(cmd);
            return m_BookData;
        }

        public DataRow ThemDongMoi()
        {
            return m_BookData.NewRow();
        }

        public void ThemBook(DataRow m_Row)
        {
            m_BookData.Rows.Add(m_Row);
        }

        public bool LuuBook()
        {
            return m_BookData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_book WHERE bookId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_BookData.Load(cmd);
            return m_BookData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_book WHERE nameBook LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_BookData.Load(cmd);
            return m_BookData;
        }
    }
}
