using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librarian.data;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using System.Data;


namespace librarian.control
{
    class Ctr_borrowBook
    {
        Data_borrowBook m_BorrowBookData = new Data_borrowBook();

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_BorrowBookData.LayDsBorrowBook();

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_BorrowBookData.ThemDongMoi();
        }

        public void ThemBorrowBook(DataRow m_Row)
        {
            m_BorrowBookData.ThemBorrowBook(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuBorrowBook()
        {
            return m_BorrowBookData.LuuBorrowBook();
        }
        #endregion
    }
}
