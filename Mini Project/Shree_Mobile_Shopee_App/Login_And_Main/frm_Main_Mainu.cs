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
    public partial class frm_Main_Mainu : Form
    {
        public frm_Main_Mainu()
        {
            InitializeComponent();
        }

        private void btn_Mobile_Click(object sender, EventArgs e)
        {
            frm_Mobile_Menu obj = new frm_Mobile_Menu();
            obj.Show();
            this.Hide();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            frm_Customer_Menu obj = new frm_Customer_Menu();
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

        private void frm_Main_Mainu_Load(object sender, EventArgs e)
        {

        }
    }
}
