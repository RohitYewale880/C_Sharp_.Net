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
    public partial class frm_Add_New_Customer : Form
    {
        public frm_Add_New_Customer()
        {
            InitializeComponent();
        }

        int PCnt = 1;

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

        void Clear_Controls()
        {
            tb_Customer_ID.Text = Convert.ToString(Auto_Incr());
            tb_Customer_Name.Clear();
            dtp_Bill_Date.ResetText();
            tb_Mobile_No.Clear();
            cmb_Brand_Name.SelectedIndex = -1;
            cmb_Mobiles.SelectedIndex = -1;
            tb_Sale_Price.Clear();
            tb_Total.Clear();
            tb_Total_Bill.Clear();


            tb_Customer_ID.Focus();
        }

        private void frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            tb_Customer_ID.Text = Convert.ToString(Auto_Incr());
            tb_Customer_ID.Focus();

            Con_Start();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Mobile_Brand) From Product_Details";

            SqlDataReader Dr = Cmd.ExecuteReader();

            cmb_Brand_Name.Items.Clear();

            while (Dr.Read())
            {
                cmb_Brand_Name.Items.Add(Dr["Mobile_Brand"].ToString());
            }

            Con_Stop();
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            Con_Start();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Mobile_Name) From Product_Details where Mobile_Brand = '" + cmb_Brand_Name.Text + "'";

            SqlDataReader Dr = Cmd.ExecuteReader();

            cmb_Mobiles.Items.Clear();

            while (Dr.Read())
            {
                cmb_Mobiles.Items.Add(Dr["Mobile_Name"].ToString());
            }

            Con_Stop();
            cmb_Mobiles.Enabled = true;
        }

        private void cmb_Mobiles_TextChanged(object sender, EventArgs e)
        {
            Con_Start();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Sale_Rate) From Product_Details where Mobile_Brand = '" + cmb_Brand_Name.Text + "' And Mobile_Name =  '" + cmb_Mobiles.Text + "'";

            SqlDataReader Dr = Cmd.ExecuteReader();

            tb_Sale_Price.Clear();

            while (Dr.Read())
            {
                tb_Sale_Price.Text = (Dr["Sale_Rate"].ToString());
            }

            Con_Stop();
            tb_Quantity.Enabled = true;
        }

        int Auto_Incr()
        {
            Con_Start();
            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "select count (*) from Customer_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "select max(Customer_Id) from Customer_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            }
            else
            {
                Cnt = 100;
            }

            tb_Customer_ID.Text = Convert.ToString(Cnt);

            Con_Stop();

            return Cnt + 1;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Total.Text != "")
            {
                dgv_List_Of_Perchase_Mobile.Rows.Add(PCnt, cmb_Brand_Name.Text, cmb_Mobiles.Text, tb_Sale_Price.Text, tb_Quantity.Text, tb_Quantity.Text, tb_Total.Text);
                PCnt++;
            }

            double

            double Total_Bill = Convert.ToDouble(tb_Total_Bill.Text) + Convert.ToDouble(tb_Total.Text);
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("You Want To LogOut??", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login_Form Obj = new frm_Login_Form();
                Obj.Show();
                this.Hide();
            }
        }
    }
}
