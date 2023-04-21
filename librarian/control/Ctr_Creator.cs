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
    class Ctr_Creator
    {
        Data_Creator m_CeatorData = new Data_Creator();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_CeatorData.LayDsCreator();
            comboBox.DisplayMember = "creatorName";
            comboBox.ValueMember = "creatorId";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_CeatorData.LayDsCreator();
            cmbColumn.DisplayMember = "creatorName";
            cmbColumn.ValueMember = "creatorId";
            cmbColumn.DataPropertyName = "creatorId";
            cmbColumn.HeaderText = "Tên tác giả *";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_CeatorData.LayDsCreator();

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_CeatorData.ThemDongMoi();
        }

        public void ThemCreator(DataRow m_Row)
        {
            m_CeatorData.ThemCreator(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuCreator()
        {
            return m_CeatorData.LuuCreator();
        }
        #endregion
        #region Tim kiem

        public void TimTheoTen(String m_tenkh)
        {
            m_CeatorData.TimTheoTen(m_tenkh);
        }
        #endregion
    }
}
