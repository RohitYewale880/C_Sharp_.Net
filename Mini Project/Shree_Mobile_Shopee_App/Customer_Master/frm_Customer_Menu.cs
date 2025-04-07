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
    public partial class frm_Customer_Menu : Form
    {
        public frm_Customer_Menu()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Customer_Click(object sender, EventArgs e)
        {
            frm_Add_New_Customer obj = new frm_Add_New_Customer();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Customer_Click(object sender, EventArgs e)
        {
            frm_Search_Customer_Details obj = new frm_Search_Customer_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_Login_Form obj = new frm_Login_Form();
                obj.Show();
                this.Hide();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main_Mainu obj = new frm_Main_Mainu();
            obj.Show();
            this.Hide();
        }
    }
}
