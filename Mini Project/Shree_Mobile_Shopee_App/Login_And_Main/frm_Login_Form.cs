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

namespace Shree_Mobile_Shopee_App
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JQI0KIJ;Initial Catalog=Shree_Mobile_App_DB;Integrated Security=True;Pooling=False");
        void Con_Start()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Stop()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Con_Start();

            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select count(*) From Login_Details Where Username = @unm And Password = @Pwd";

            Cmd.Parameters.Add("@Unm", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("@Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Success", "Welcome ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Main_Mainu obj = new frm_Main_Mainu();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed", "Re-Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tb_Username.Clear();
            tb_Password.Clear();
            tb_Password.Enabled = false;
            btn_Login.Enabled = false;

            Con_Stop();
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void Text_Change(object sender, EventArgs e)
        {
            btn_Login.Enabled = true;
        }
    }
}
