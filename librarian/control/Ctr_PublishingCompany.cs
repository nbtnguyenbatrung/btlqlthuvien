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
    class Ctr_PublishingCompany
    {

        Data_PublishingCompany m_PublishingCompanyData = new Data_PublishingCompany();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_PublishingCompanyData.LayDsPublishingCompany();
            comboBox.DisplayMember = "publishingCompanyName";
            comboBox.ValueMember = "publishingCompanyId";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_PublishingCompanyData.LayDsPublishingCompany();
            cmbColumn.DisplayMember = "publishingCompanyName";
            cmbColumn.ValueMember = "publishingCompanyId";
            cmbColumn.DataPropertyName = "publishingCompanyId";
            cmbColumn.HeaderText = "Nhà sản xuất *";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_PublishingCompanyData.LayDsPublishingCompany();

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_PublishingCompanyData.ThemDongMoi();
        }

        public void ThemPublishingCompany(DataRow m_Row)
        {
            m_PublishingCompanyData.ThemPublishingCompany(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuPublishingCompany()
        {
            return m_PublishingCompanyData.LuuPublishingCompany();
        }
        #endregion
        #region Tim kiem

        public void TimTheoTen(String m_tenkh)
        {
            m_PublishingCompanyData.TimTheoTen(m_tenkh);
        }
        #endregion

    }
}
