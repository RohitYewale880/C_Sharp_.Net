using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shree_Mobile_Shopee_App
{
    public partial class frm_Search_Customer_Details : Form
    {
        public frm_Search_Customer_Details()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Customer_Menu obj = new frm_Customer_Menu();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
