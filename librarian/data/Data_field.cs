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
    class Data_field
    {
        dataservice m_FieldData = new dataservice();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);

        public DataTable LayDsField()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_field");
            m_FieldData.Load(cmd);
            return m_FieldData;
        }

        public DataRow ThemDongMoi()
        {
            return m_FieldData.NewRow();
        }

        public void ThemField(DataRow m_Row)
        {
            m_FieldData.Rows.Add(m_Row);
        }

        public bool LuuField()
        {
            return m_FieldData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_field WHERE fieldId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_FieldData.Load(cmd);
            return m_FieldData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_field WHERE fieldName LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_FieldData.Load(cmd);
            return m_FieldData;
        }
    }
}
