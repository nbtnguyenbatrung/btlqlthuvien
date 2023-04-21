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
    class Data_type
    {
        dataservice m_TypeData = new dataservice();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);

        public DataTable LayDsType()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_type");
            m_TypeData.Load(cmd);
            return m_TypeData;
        }

        public DataRow ThemDongMoi()
        {
            return m_TypeData.NewRow();
        }

        public void ThemType(DataRow m_Row)
        {
            m_TypeData.Rows.Add(m_Row);
        }

        public bool LuuType()
        {
            return m_TypeData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_type WHERE typeId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_TypeData.Load(cmd);
            return m_TypeData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_type WHERE nameType LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_TypeData.Load(cmd);
            return m_TypeData;
        }                  
    }
}
