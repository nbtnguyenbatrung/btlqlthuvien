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
using Microsoft.Reporting.WinForms;

namespace librarian.report
{
    public partial class Frm_xuat : Form
    {

        string m_userId;
        string m_userName;
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        public Frm_xuat(string userId, string userName)
        {
            InitializeComponent();
            m_userId = userId;
            m_userName = userName;
        }

        private void Frm_xuat_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT BO.nameBook, 0.1*Bo.price*(DateDiff('d',deadDate,Now())-1) AS amount " +
                "FROM((tb_borrowBook AS B INNER JOIN tb_card AS C ON B.userId = C.userId) " +
                "INNER JOIN tb_user AS U ON B.userId = U.userId) " +
                "INNER JOIN tb_book AS BO ON B.bookId = BO.bookId " +
                "WHERE(((DateDiff('d',[deadDate], Now()) - 1) > 0)) AND U.userId = " + Int64.Parse(m_userId) +
                " ORDER BY DateDiff('d',[deadDate], Now()) - 1 DESC; ", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("ViewXuat", dt);
            reportViewer1.LocalReport.ReportPath = @"D:\librarian\librarian\report\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("userId", m_userId));
            param.Add(new ReportParameter("userName", m_userName));
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
            conn.Close();
        }
    }
}
