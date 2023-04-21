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
    class Data_borrowBook
    {
        dataservice m_BorrowBookData = new dataservice();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);

        public DataTable LayDsBorrowBook()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_borrowBook");
            m_BorrowBookData.Load(cmd);
            return m_BorrowBookData;
        }

        public DataRow ThemDongMoi()
        {
            return m_BorrowBookData.NewRow();
        }

        public void ThemBorrowBook(DataRow m_Row)
        {
            m_BorrowBookData.Rows.Add(m_Row);
        }

        public bool LuuBorrowBook()
        {
            return m_BorrowBookData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_borrowBook WHERE borrowBookId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_BorrowBookData.Load(cmd);
            return m_BorrowBookData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_borrowBook WHERE userName LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_BorrowBookData.Load(cmd);
            return m_BorrowBookData;
        }
    }
}
