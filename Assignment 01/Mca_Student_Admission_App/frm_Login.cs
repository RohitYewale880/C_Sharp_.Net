using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mca_Student_Admission_App
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "Admin" && tb_Password.Text == "a123" || tb_Username.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Success", "Welcome Admin", MessageBoxButtons.OK);
                frm_Add_Student_Details obj = new frm_Add_Student_Details();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed", "Enter Correct User Name", MessageBoxButtons.OK);
                tb_Username.Clear();
                tb_Password.Clear();
            }
            tb_Username.Focus();
        }
    }
}
