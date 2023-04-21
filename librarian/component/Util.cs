using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using librarian.view;
using librarian.report;

namespace librarian.component
{
    class uti
    {
        public static String DatabaseName;
    }

    #region Các hàm xử lý tập tin XML
    public class XML
    {
        public static XmlDocument XMLReader(String filename)
        {
            XmlDocument xmlR = new XmlDocument();
            try
            {
                xmlR.Load(filename);
            }
            catch
            {
                MessageBoxEx.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return xmlR;
        }

        public static void XMLWriter(String filename, String servname, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }

        public static void XMLWriter(String filename, String servname, String username, String password, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString(username);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString(password);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }
    }
    #endregion

    #region ThamSo
    public static class ThamSo
    {
        #region Fields

        public static Form_connect m_FrmConnection = null;
        public static Frm_User m_FrmUser = null;
        public static Frm_card m_FrmCard = null;
        public static Frm_borrowBook m_FrmBorrowBook = null;
        public static Frm_type m_FrmType = null;
        public static Frm_PublishingCompany m_FrmPublishingCompany = null;
        public static Frm_Creator m_FrmCreator = null;
        public static Frm_book m_FrmBook = null;
        public static Frm_field m_FrmField = null;
        public static Frm_list m_FrmList = null;
        public static Frm_outDate m_FrmOutDate = null;
        public static Frm_bookRemind m_FrmBookRemind = null;
        #endregion

        #region show form 

        public static void ShowFormUser()
        {

            if (m_FrmUser == null || m_FrmUser.IsDisposed)
            {
                try
                {
                    m_FrmUser = new Frm_User();
                    m_FrmUser.MdiParent = Frm_main.ActiveForm;
                    m_FrmUser.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmUser.Activate();
        }
        public static void ShowFormCard()
        {

            if (m_FrmCard == null || m_FrmCard.IsDisposed)
            {
                try
                {
                    m_FrmCard = new Frm_card();
                    m_FrmCard.MdiParent = Frm_main.ActiveForm;
                    m_FrmCard.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmCard.Activate();
        }
        public static void ShowFormBorrowBook()
        {

            if (m_FrmBorrowBook == null || m_FrmBorrowBook.IsDisposed)
            {
                try
                {
                    m_FrmBorrowBook = new Frm_borrowBook();
                    m_FrmBorrowBook.MdiParent = Frm_main.ActiveForm;
                    m_FrmBorrowBook.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmBorrowBook.Activate();
        }
        public static void ShowFormType()
        {

            if (m_FrmType == null || m_FrmType.IsDisposed)
            {
                try
                {
                    m_FrmType = new Frm_type();
                    m_FrmType.MdiParent = Frm_main.ActiveForm;
                    m_FrmType.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmType.Activate();
        }
        public static void ShowFormPublishCompany()
        {

            if (m_FrmPublishingCompany == null || m_FrmPublishingCompany.IsDisposed)
            {
                try
                {
                    m_FrmPublishingCompany = new Frm_PublishingCompany();
                    m_FrmPublishingCompany.MdiParent = Frm_main.ActiveForm;
                    m_FrmPublishingCompany.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmPublishingCompany.Activate();
        }
        public static void ShowFormCreator()
        {

            if (m_FrmCreator == null || m_FrmCreator.IsDisposed)
            {
                try
                {
                    m_FrmCreator = new Frm_Creator();
                    m_FrmCreator.MdiParent = Frm_main.ActiveForm;
                    m_FrmCreator.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmCreator.Activate();
        }
        public static void ShowFormBook()
        {

            if (m_FrmBook == null || m_FrmBook.IsDisposed)
            {
                try
                {
                    m_FrmBook = new Frm_book();
                    m_FrmBook.MdiParent = Frm_main.ActiveForm;
                    m_FrmBook.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmBook.Activate();
        }
        public static void ShowFormField()
        {

            if (m_FrmField == null || m_FrmField.IsDisposed)
            {
                try
                {
                    m_FrmField = new Frm_field();
                    m_FrmField.MdiParent = Frm_main.ActiveForm;
                    m_FrmField.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmField.Activate();
        }
        public static void ShowFormList()
        {

            if (m_FrmList == null || m_FrmList.IsDisposed)
            {
                try
                {
                    m_FrmList = new Frm_list();
                    m_FrmList.MdiParent = Frm_main.ActiveForm;
                    m_FrmList.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmList.Activate();
        }
        public static void ShowFormOutDate()
        {

            if (m_FrmOutDate == null || m_FrmOutDate.IsDisposed)
            {
                try
                {
                    m_FrmOutDate = new Frm_outDate();
                    m_FrmOutDate.MdiParent = Frm_main.ActiveForm;
                    m_FrmOutDate.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmOutDate.Activate();
        }
        public static void ShowFormBookRemind()
        {

            if (m_FrmBookRemind == null || m_FrmBookRemind.IsDisposed)
            {
                try
                {
                    m_FrmBookRemind = new Frm_bookRemind();
                    m_FrmBookRemind.MdiParent = Frm_main.ActiveForm;
                    m_FrmBookRemind.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmBookRemind.Activate();
        }

        #endregion
    }
    #endregion
}
