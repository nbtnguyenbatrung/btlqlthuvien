using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librarian.control;
using librarian.component;

namespace librarian.view
{
    public partial class Frm_list : Form
    {

        Ctr_BorrowedBook m_dataCtrl = new Ctr_BorrowedBook();
        public Frm_list()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        private void Frm_list_Load(object sender, EventArgs e)
        {
            m_dataCtrl.HienThiDsBB(lvchuaphan);
            m_dataCtrl.HienThiDsSV(lvphan);
        }
    }
}
