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
    class Data_user
    {
        dataservice m_UserData = new dataservice();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);

        public DataTable LayDsUser()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_user");
            m_UserData.Load(cmd);
            return m_UserData;
        }

        public DataRow ThemDongMoi()
        {
            return m_UserData.NewRow();
        }

        public void ThemUser(DataRow m_Row)
        {
            m_UserData.Rows.Add(m_Row);
        }

        public bool LuuUser()
        {
            return m_UserData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_user WHERE userId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_UserData.Load(cmd);
            return m_UserData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_user WHERE nameUser LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_UserData.Load(cmd);
            return m_UserData;
        }

        public DataTable TimTheoTenoutDate(bool check, String ten)
        {

            String sql = "SELECT DISTINCT U.userId AS userIdView , U.nameUser AS nameUserView " +
                        "FROM((tb_borrowBook AS B INNER JOIN tb_card AS C ON B.userId = C.userId) " +
                        "INNER JOIN tb_user AS U ON B.userId = U.userId) " +
                        "INNER JOIN tb_book AS BO ON B.bookId = BO.bookId " +
                        "WHERE(((DateDiff('d', [deadDate], Now()) - 1) > 0)) ";

            if (check && ten != "") {
                sql += "WHERE U.nameUser LIKE '%" + ten + "%'";
            }

            sql += "GROUP BY U.userId, U.nameUser; ";
            OleDbCommand cmd = new OleDbCommand(sql);

            m_UserData.Load(cmd);
            return m_UserData;
        }

    }
}
