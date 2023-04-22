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
    class Data_BorrowedBook
    {
        dataservice m_Data = new dataservice();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);

        public DataTable LayDsBorrwedBook()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT tb_book.bookId AS bookIdView , tb_book.nameBook AS nameBookView, COUNT( tb_borrowBook.borrowBookId) as Soluong " +
                                                "FROM tb_book LEFT JOIN tb_borrowBook ON tb_book.bookId = tb_borrowBook.bookId " +
                                                "group by tb_book.bookId, tb_book.nameBook " +
                                                "ORDER BY COUNT( tb_borrowBook.borrowBookId) desc");
            m_Data.Load(cmd);
            return m_Data;
        }

        public DataTable LayDsUser()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT tb_user.userId AS userIdView , tb_user.nameUser AS nameUserView, Count(tb_borrowBook.borrowBookId) AS Soluong " +
                                "FROM(SELECT * FROM tb_borrowBook WHERE tb_borrowBook.status = 'Mượn') AS B " +
                                "RIGHT JOIN tb_user ON B.userId = tb_user.userId " +
                                "GROUP BY tb_user.userId, tb_user.nameUser " +
                                "ORDER BY Count(tb_borrowBook.borrowBookId) DESC; ");
            m_Data.Load(cmd);
            return m_Data;
        }

        public DataTable LayDsOutDate()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT DateDiff('d' , deadDate, Now())-1 AS diff, U.userId, U.nameUser, BO.bookId, BO.nameBook, 0.1*Bo.price*(DateDiff('d' , deadDate, Now())-1) AS amount " +
                    "FROM((tb_borrowBook AS B INNER JOIN tb_card AS C ON B.userId = C.userId) " +
                    "INNER JOIN tb_user AS U ON B.userId = U.userId) " +
                    "INNER JOIN tb_book AS BO ON B.bookId = BO.bookId " +
                    "WHERE(DateDiff('d', deadDate, Now()) - 1) > 0 " +
                    "ORDER BY DateDiff('d', deadDate, Now()) - 1 DESC; ");
            m_Data.Load(cmd);
            return m_Data;
        }

        public DataTable LayDsOutDateTk(bool checknameuser,
                                       bool checknamebook,
                                       string nameuser,
                                       string namrbook)
        {

            String sql = "SELECT DateDiff('d' , deadDate, Now())-1 AS diff, U.userId, U.nameUser, BO.bookId, BO.nameBook, 0.1*Bo.price*(DateDiff('d' , deadDate, Now())-1) AS amount " +
                    "FROM((tb_borrowBook AS B INNER JOIN tb_card AS C ON B.userId = C.userId) " +
                    "INNER JOIN tb_user AS U ON B.userId = U.userId) " +
                    "INNER JOIN tb_book AS BO ON B.bookId = BO.bookId " +
                    "WHERE(DateDiff('d', deadDate, Now()) - 1) > 0 ";

            if (checknameuser)
            {
                sql += "And nameUser LIKE '%" + nameuser + "%' ";
            }
            if (checknamebook)
            {
                sql += "And nameBook LIKE '%" + namrbook + "%' ";
            }

            sql += "ORDER BY DateDiff('d', deadDate, Now()) - 1 DESC; ";

            OleDbCommand cmd = new OleDbCommand(sql);
            m_Data.Load(cmd);
            return m_Data;
        }
    }
}
