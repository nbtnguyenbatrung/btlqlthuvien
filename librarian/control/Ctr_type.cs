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
    class Ctr_type
    {
        Data_type m_TypeData = new Data_type();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_TypeData.LayDsType();
            comboBox.DisplayMember = "nameType";
            comboBox.ValueMember = "typeId";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_TypeData.LayDsType();
            cmbColumn.DisplayMember = "nameType";
            cmbColumn.ValueMember = "typeId";
            cmbColumn.DataPropertyName = "typeId";
            cmbColumn.HeaderText = "Thể loại *";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_TypeData.LayDsType();

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_TypeData.ThemDongMoi();
        }

        public void ThemType(DataRow m_Row)
        {
            m_TypeData.ThemType(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuType()
        {
            return m_TypeData.LuuType();
        }
        #endregion
        #region Tim kiem

        public void TimTheoTen(String m_tenkh)
        {
            m_TypeData.TimTheoTen(m_tenkh);
        }
        #endregion
    }
}
