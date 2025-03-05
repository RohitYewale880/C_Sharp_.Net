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

namespace Product_Information_Details_App
{
    public partial class frm_Add_Product_Details : Form
    {
        public frm_Add_Product_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JQI0KIJ;Initial Catalog=Product_Information_Details_App_DB;Integrated Security=True;Pooling=False");

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

        void Clear_Controls()
        {
            tb_Product_Id.Text = Convert.ToString(Auto_Incr());
            tb_Product_Name.Clear();
            dtp_Packing_Date.ResetText();
            dtp_Expiry_Date.ResetText();
            tb_Price.Clear();

            tb_Product_Id.Focus();
        }

        int Auto_Incr()
        {
            Con_Open();
            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "select count (*) from Product_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "select max(Product_Id) from Product_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            }
            else
            {
                Cnt = 0;
            }

            tb_Product_Id.Text = Convert.ToString(Cnt);

            Con_Close();

            return Cnt + 1;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_Id.Text != "" && tb_Product_Name.Text != "" && tb_Price.Text != "" )
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Product_Details Values (@PId, @PName, @PD, @ED, @Price)";

                Cmd.Parameters.Add("PId", SqlDbType.Int).Value = tb_Product_Id.Text;
                Cmd.Parameters.Add("PName", SqlDbType.VarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("PD", SqlDbType.Date).Value = dtp_Packing_Date.Text;
                Cmd.Parameters.Add("ED", SqlDbType.Date).Value = dtp_Expiry_Date.Text;
                Cmd.Parameters.Add("Price", SqlDbType.Money).Value = tb_Price.Text;


                Cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Succesfully", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();


            }
            else
            {
                MessageBox.Show("Incomplet Data", "Error", MessageBoxButtons.OK);
                Clear_Controls();

            }
            

            Con_Close();
        }

        private void btn_Product_List_Click(object sender, EventArgs e)
        {
            frm_Product_List obj = new frm_Product_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Product_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Product obj = new frm_Search_Product();
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("You Want to Close App??", "CLOSED", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Only_Numric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;

            }
        }

        private void Onky_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
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

        private void frm_Add_Product_Details_Load(object sender, EventArgs e)
        {
            tb_Product_Id.Text = Convert.ToString(Auto_Incr());
            tb_Product_Id.Focus();
        }
    }
}
