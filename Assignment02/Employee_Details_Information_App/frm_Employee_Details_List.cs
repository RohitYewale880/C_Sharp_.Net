using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details_Information_App
{
    public partial class frm_Employee_Details_List : Form
    {
        public frm_Employee_Details_List()
        {
            InitializeComponent();
        }

        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_Employee_Details obj = new frm_Add_Employee_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res= MessageBox.Show("You Want To LogOut??", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login_Form Obj = new frm_Login_Form();
                Obj.Show();
                this.Hide();
            }
        }

        private void frm_Employee_Details_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Details_Information_App_DBDataSet4.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.employee_Details_Information_App_DBDataSet4.Employee_Details);
            lbl_UNAME.Text = Shared_Content.UNAME;

        }
    }
}
