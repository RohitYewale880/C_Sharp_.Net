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
    public partial class frm_Add_Employee_Details : Form
    {
        public frm_Add_Employee_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JQI0KIJ;Initial Catalog=Employee_Details_Information_App_DB;Integrated Security=True;Pooling=False");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        int Auto_Incr()
        {
            Con_Open();
            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "select count (*) from Employee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "select max(Employee_Id) from Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            }
            else
            {
                Cnt = 1;
            }

            tb_Employee_Id.Text = Convert.ToString(Cnt);

            Con_Close();

            return Cnt+1;
        }

       


        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;

            }

        }

        private void Only_Numbers(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;

            }
        }
        void Clear_Controls()
        {
            tb_Employee_Id.Clear();
            tb_Employee_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_Joinning_Date.ResetText();
            cmb_Department.SelectedIndex = 1;
            tb_Salary.Clear();

            tb_Employee_Id.Focus();
        }

      
        private void frm_Add_Employee_Details_Load(object sender, EventArgs e)
        {
            lbl_UNAME.Text = Shared_Content.UNAME;
            tb_Employee_Id.Text = Convert.ToString(Auto_Incr());
            tb_Employee_Id.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Employee_Id.Text != "" && tb_Employee_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Department.Text != "" && tb_Salary.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Employee_Details Values (@Id, @Name, @MNo, @DOJ, @Dpt, @Slry)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Employee_Id.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Employee_Name.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("DOJ", SqlDbType.Date).Value = dtp_Joinning_Date.Text;
                Cmd.Parameters.Add("Dpt", SqlDbType.NVarChar).Value = cmb_Department.Text;
                Cmd.Parameters.Add("Slry", SqlDbType.Money).Value = tb_Salary.Text;


                Cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Succesfully", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();


            }
            else
            {
                MessageBox.Show("Incomplet Data", "Error", MessageBoxButtons.OK);
                Clear_Controls();

            }

            Con.Close();

            
            
        }

        private void btn_Employee_List_Click(object sender, EventArgs e)
        {
            frm_Employee_Details_List obj = new frm_Employee_Details_List();
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("You Want to Close App??", "CLOSED", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                this.Hide();
            }
        }

       
    }
}
