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
    class Ctr_card
    {
        Data_card m_CardData = new Data_card();

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_CardData.LayDsCard();

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_CardData.ThemDongMoi();
        }

        public void ThemCard(DataRow m_Row)
        {
            m_CardData.ThemCard(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuCard()
        {
            return m_CardData.LuuCard();
        }
        #endregion

        #region Tim kiem

        public void TimTheoTen(String m_tenkh)
        {
            m_CardData.TimTheoTen(m_tenkh);
        }
        #endregion
    }
}
