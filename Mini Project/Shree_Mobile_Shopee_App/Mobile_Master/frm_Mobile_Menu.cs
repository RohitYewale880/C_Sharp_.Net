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
    public partial class frm_Mobile_Menu : Form
    {
        public frm_Mobile_Menu()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main_Mainu obj = new frm_Main_Mainu();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("You Want To LogOut??", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login_Form Obj = new frm_Login_Form();
                Obj.Show();
                this.Hide();
            }
        }

        private void btn_Add_New_Mobile_Click(object sender, EventArgs e)
        {
            frm_Add_New_Mobile obj = new frm_Add_New_Mobile();
            obj.Show();
            this.Hide();
        }

        private void btn_Update_Mobile_Click(object sender, EventArgs e)
        {
            frm_Update_Product obj = new frm_Update_Product();
            obj.Show();
            this.Hide();
        }

        private void btn_View_Mobile_List_Click(object sender, EventArgs e)
        {
            frm_Mobile_List obj = new frm_Mobile_List();
            obj.Show();
            this.Hide();
        }

        private void frm_Mobile_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
