using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_App
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-JQI0KIJ;Initial Catalog=Student_Details_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "select count(*) from Login_Details where Username = @unm AND Password = @psd";

            Cmd.Parameters.Add("unm", SqlDbType.NVarChar).Value = tb_Password.Text;
            Cmd.Parameters.Add("psd", SqlDbType.NVarChar).Value = tb_Password.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Successful", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shaired_Containt.UName = "Welcome" + tb_Username.Text;

                frm_Add_Student_Details obj = new frm_Add_Student_Details();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Invalid Credentials, Enter Correct details";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;

            tb_Username.Focus();
            Con_Close();
        }

        private void tb_Username_Text_Change(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Note.Visible = true;
        }

        private void tb_Password_Visiblechange(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }

}
