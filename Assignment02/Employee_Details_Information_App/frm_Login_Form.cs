using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Details_Information_App
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JQI0KIJ;Initial Catalog=Employee_Details_Information_App_DB;Integrated Security=True;Pooling=False");
        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
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
            Con.Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Login_Details Where Username =@Unm And Password =@Psd";

            Cmd.Parameters.Add("@Unm", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("@Psd", SqlDbType.NVarChar).Value = tb_Password.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt>0)
            {
                MessageBox.Show("Login Succesful", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Content.UNAME = "WELCOME" + tb_Username.Text;

                frm_Add_Employee_Details obj = new frm_Add_Employee_Details();
                obj.Show();
                this.Hide();
            }

            else
            {
                lbl_Note.Text = "Invalid Credentials, Enter Correct Details!!";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_Username.Clear();
            tb_Password.Clear();



            tb_Password.Enabled = true;
            btn_Submit.Enabled = true;

            tb_Username.Focus();
            Con.Close();

            
        }

       
        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Note.Visible = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

    }
}
