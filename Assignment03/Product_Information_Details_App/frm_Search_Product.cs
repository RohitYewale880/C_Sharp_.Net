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
    public partial class frm_Search_Product : Form
    {
        public frm_Search_Product()
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
            tb_Product_Id.Clear();
            tb_Product_Name.Clear();
            dtp_Packing_Date.ResetText();
            dtp_Expiry_Date.ResetText();
            tb_Price.Clear();

            tb_Product_Id.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select * From Product_Details Where Product_Id = @pid";

            Cmd.Parameters.Add("pid", SqlDbType.Int).Value = tb_Product_Id.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();

            if(Dr.Read())
            {
                tb_Product_Name.Text = Dr.GetString(Dr.GetOrdinal("Product_Name"));
                dtp_Packing_Date.Text = (Dr["Packing_Date"].ToString());
                dtp_Expiry_Date.Text = (Dr["Expiry_Date"].ToString());
                tb_Price.Text = (Dr["Price"].ToString());

            }
            else
            {
                MessageBox.Show("Invalid Product Id", "NO PRODUCT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Product_Id.Clear();
            }
            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            frm_Add_Product_Details obj = new frm_Add_Product_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Product_List_Click(object sender, EventArgs e)
        {
            frm_Product_List obj = new frm_Product_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("You Want to Close App??", "CLOSED", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                this.Hide();
            }
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

        
    }
}
