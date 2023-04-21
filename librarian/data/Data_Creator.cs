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
    class Data_Creator
    {
        dataservice m_CreatorData = new dataservice();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);

        public DataTable LayDsCreator()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_creator");
            m_CreatorData.Load(cmd);
            return m_CreatorData;
        }

        public DataRow ThemDongMoi()
        {
            return m_CreatorData.NewRow();
        }

        public void ThemCreator(DataRow m_Row)
        {
            m_CreatorData.Rows.Add(m_Row);
        }

        public bool LuuCreator()
        {
            return m_CreatorData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_creator WHERE creatorId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_CreatorData.Load(cmd);
            return m_CreatorData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_creator WHERE creatorName LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_CreatorData.Load(cmd);
            return m_CreatorData;
        }
    }
}
