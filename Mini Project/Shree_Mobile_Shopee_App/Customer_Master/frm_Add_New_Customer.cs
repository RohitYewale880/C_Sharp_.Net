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

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if(tb_Sale_Price.Text != "" && tb_Quantity.Text != "")
            {
                double Total = Convert.ToDouble(tb_Sale_Price.Text) * Convert.ToDouble(tb_Quantity.Text);
                tb_Total.Text = Convert.ToString(Total);
            }         
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
            if (cmb_Brand_Name.Text != "" && cmb_Mobiles.Text != "" && tb_Sale_Price.Text != "" &&tb_Quantity.Text != "" && tb_Total.Text != "")
            {
                bool Flag = true;
                for (int i = 0; i < dgv_List_Of_Perchase_Mobile.RowCount; i++)
                {
                    if(cmb_Mobiles.Text == Convert.ToString(dgv_List_Of_Perchase_Mobile.Rows[i].Cells[2].Value))
                    {
                        int NewQut = Convert.ToInt32(dgv_List_Of_Perchase_Mobile.Rows[i].Cells[4].Value) + Convert.ToInt32(tb_Quantity.Text);
                        dgv_List_Of_Perchase_Mobile.Rows[i].Cells[4].Value = NewQut;

                        double Amt = Convert.ToDouble(dgv_List_Of_Perchase_Mobile.Rows[i].Cells[5].Value) + Convert.ToDouble(tb_Total.Text);
                        dgv_List_Of_Perchase_Mobile.Rows[i].Cells[5].Value = Amt;

                        Flag = false;
                        break;
                    }               
                }

                if(Flag == true)
                {
                    dgv_List_Of_Perchase_Mobile.Rows.Add(PCnt, cmb_Brand_Name.Text, cmb_Mobiles.Text, tb_Sale_Price.Text, tb_Quantity.Text, tb_Total.Text);
                }

                double Bill = Convert.ToDouble(tb_Total_Bill.Text) + Convert.ToDouble(tb_Total.Text);
                tb_Total_Bill.Text = Convert.ToString(Bill);
            }

            cmb_Brand_Name.SelectedIndex = -1;
            cmb_Mobiles.SelectedIndex = -1;
            tb_Sale_Price.Clear();
            tb_Quantity.Clear();
            tb_Total.Clear();

            PCnt++;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Start();

            if (tb_Customer_ID.Text != "" && tb_Customer_Name.Text != "" && dtp_Bill_Date.Text != "" && tb_Mobile_No.Text != "" && tb_Total_Bill.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Customer_Details Values (@CId, @CName, @BDate, @MNo, @TBill)";

                Cmd.Parameters.Add("CId", SqlDbType.Int).Value = tb_Customer_ID.Text;
                Cmd.Parameters.Add("CName", SqlDbType.NVarChar).Value = tb_Customer_Name.Text;
                Cmd.Parameters.Add("BDate", SqlDbType.Date).Value = dtp_Bill_Date.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("TBill", SqlDbType.Money).Value = tb_Total_Bill.Text;

                Cmd.ExecuteNonQuery();

                for (int i = 0; i < dgv_List_Of_Perchase_Mobile.Rows.Count; i++)
                {
                    SqlCommand Cmd1 = new SqlCommand();
                    Cmd1.Connection = Con;
                    Cmd1.CommandText = "Insert Into Customer_Product Values (@C_Id,@srno, @BName, @MName, @Price, @Quantity, @Total)";

                    Cmd1.Parameters.Add("C_Id", SqlDbType.Int).Value = tb_Customer_ID.Text;
                    Cmd1.Parameters.Add("srno", SqlDbType.Int).Value = dgv_List_Of_Perchase_Mobile.Rows[i].Cells[0].Value;
                    Cmd1.Parameters.Add("BName", SqlDbType.NVarChar).Value = dgv_List_Of_Perchase_Mobile.Rows[i].Cells[1].Value;
                    Cmd1.Parameters.Add("MName", SqlDbType.NVarChar).Value = dgv_List_Of_Perchase_Mobile.Rows[i].Cells[2].Value;
                    Cmd1.Parameters.Add("Price", SqlDbType.Money).Value = dgv_List_Of_Perchase_Mobile.Rows[i].Cells[3].Value;
                    Cmd1.Parameters.Add("Quantity", SqlDbType.Int).Value = dgv_List_Of_Perchase_Mobile.Rows[i].Cells[4].Value;
                    Cmd1.Parameters.Add("Total", SqlDbType.Money).Value = dgv_List_Of_Perchase_Mobile.Rows[i].Cells[5].Value;

                    Cmd1.ExecuteNonQuery();
                }

                MessageBox.Show("Saved Succesfully", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();


            }
            else
            {
                MessageBox.Show("Incomplet Data", "Error", MessageBoxButtons.OK);
                Clear_Controls();

            }


            Con_Stop();
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Customer_Menu obj = new frm_Customer_Menu();
            obj.Show();
            this.Hide();
        }

        private void dgv_List_Of_Perchase_Mobile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
