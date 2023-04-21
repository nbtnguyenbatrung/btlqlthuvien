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
    class Ctr_book
    {
        Data_book m_BookData = new Data_book();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_BookData.LayDsBook();
            comboBox.DisplayMember = "nameBook";
            comboBox.ValueMember = "bookId";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_BookData.LayDsBook();
            cmbColumn.DisplayMember = "nameBook";
            cmbColumn.ValueMember = "bookId";
            cmbColumn.DataPropertyName = "bookId";
            cmbColumn.HeaderText = "Tên sách * ";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_BookData.LayDsBook();

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_BookData.ThemDongMoi();
        }

        public void ThemBook(DataRow m_Row)
        {
            m_BookData.ThemBook(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuBook()
        {
            return m_BookData.LuuBook();
        }
        #endregion
        #region Tim kiem

        public void TimTheoTen(String m_tenkh)
        {
            m_BookData.TimTheoTen(m_tenkh);
        }
        #endregion
    }
}
