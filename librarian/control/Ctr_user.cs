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
    class Ctr_user
    {
        Data_user m_UserData = new Data_user();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_UserData.LayDsUser();
            comboBox.DisplayMember = "nameUser";
            comboBox.ValueMember = "userId";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_UserData.LayDsUser();
            cmbColumn.DisplayMember = "nameUser";
            cmbColumn.ValueMember = "userId";
            cmbColumn.DataPropertyName = "userId";
            cmbColumn.HeaderText = "Tên độc giả * ";
        }
        public void HienThiDataGridViewComboBoxColumnCard(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_UserData.LayDsUserCard();
            cmbColumn.DisplayMember = "nameUser";
            cmbColumn.ValueMember = "userId";
            cmbColumn.DataPropertyName = "userId";
            cmbColumn.HeaderText = "Tên độc giả * ";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_UserData.LayDsUser();

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_UserData.ThemDongMoi();
        }

        public void ThemUser(DataRow m_Row)
        {
            m_UserData.ThemUser(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuUser()
        {
            return m_UserData.LuuUser();
        }
        #endregion

        #region Tim kiem

        public void TimTheoTen(String m_tenkh)
        {
            m_UserData.TimTheoTen(m_tenkh);
        }

        public void HienThioutDate(DataGridViewX dGV,
                                    BindingNavigator bN,
                                    bool check,
                                    String m_tenkh)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_UserData.TimTheoTenoutDate(check, m_tenkh);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        #endregion

    }
}
