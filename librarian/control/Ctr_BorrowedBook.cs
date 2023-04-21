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
    class Ctr_BorrowedBook
    {
        Data_BorrowedBook m_Data = new Data_BorrowedBook();

        #region hiển thị danh sách học viên chưa được phân lớp 
        public void HienThiDsBB(ListViewEx lV)
        {
            DataTable m_DT = m_Data.LayDsBorrwedBook();

            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["bookIdView"].ToString();
                item.SubItems.Add(Row["nameBookView"].ToString());
                item.SubItems.Add(Row["Soluong"].ToString());

                lV.Items.Add(item);
            }
        }

        public void HienThiDsSV(ListViewEx lV)
        {
            DataTable m_DT = m_Data.LayDsUser();

            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["userIdView"].ToString();
                item.SubItems.Add(Row["nameUserView"].ToString());
                item.SubItems.Add(Row["Soluong"].ToString());

                lV.Items.Add(item);
            }           
        }        
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_Data.LayDsOutDate();

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public void HienThiTk(DataGridViewX dGV,
                               BindingNavigator bN,
                               bool checknameuser,
                               bool checknamebook,
                               string nameuser,
                               string namebook)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_Data.LayDsOutDateTk(checknameuser, checknamebook, nameuser, namebook);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
    }
}
