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
    class Data_card
    {
        dataservice m_CardData = new dataservice();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);

        public DataTable LayDsCard()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_card");
            m_CardData.Load(cmd);
            return m_CardData;
        }

        public DataRow ThemDongMoi()
        {
            return m_CardData.NewRow();
        }

        public void ThemCard(DataRow m_Row)
        {
            m_CardData.Rows.Add(m_Row);
        }

        public bool LuuCard()
        {
            return m_CardData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_card WHERE cardId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_CardData.Load(cmd);
            return m_CardData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_card C INNER JOIN tb_user U" +
                "ON C.userId = U.userId" +
                " WHERE nameUser LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_CardData.Load(cmd);
            return m_CardData;
        }
    }
}
