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
    class Data_PublishingCompany
    {
        dataservice m_UserData = new dataservice();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);

        public DataTable LayDsPublishingCompany()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_publishingCompany");
            m_UserData.Load(cmd);
            return m_UserData;
        }

        public DataRow ThemDongMoi()
        {
            return m_UserData.NewRow();
        }

        public void ThemPublishingCompany(DataRow m_Row)
        {
            m_UserData.Rows.Add(m_Row);
        }

        public bool LuuPublishingCompany()
        {
            return m_UserData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_publishingCompany WHERE publishingCompanyId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_UserData.Load(cmd);
            return m_UserData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_publishingCompany WHERE publishingCompanyName LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_UserData.Load(cmd);
            return m_UserData;
        }
    }
}
