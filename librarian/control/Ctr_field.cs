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
    class Ctr_field
    {
        Data_field m_FieldData = new Data_field();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_FieldData.LayDsField();
            comboBox.DisplayMember = "fieldName";
            comboBox.ValueMember = "fieldId";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_FieldData.LayDsField();
            cmbColumn.DisplayMember = "fieldName";
            cmbColumn.ValueMember = "fieldId";
            cmbColumn.DataPropertyName = "fieldId";
            cmbColumn.HeaderText = "Lĩnh vực *";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_FieldData.LayDsField();

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_FieldData.ThemDongMoi();
        }

        public void ThemField(DataRow m_Row)
        {
            m_FieldData.ThemField(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuField()
        {
            return m_FieldData.LuuField();
        }
        #endregion
        #region Tim kiem

        public void TimTheoTen(String m_tenkh)
        {
            m_FieldData.TimTheoTen(m_tenkh);
        }
        #endregion
    }
}
