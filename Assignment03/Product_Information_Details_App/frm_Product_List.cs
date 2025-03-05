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
    public partial class frm_Product_List : Form
    {
        public frm_Product_List()
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

        private void frm_Product_List_Load(object sender, EventArgs e)
        {
            Con_Open();

            dgv_Product_List.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter("select * From Product_Details", Con);

            DataTable dt = new DataTable();
            SDA.Fill(dt);

            dgv_Product_List.DataSource = dt;

            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("You Want to Close App??", "CLOSED", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            frm_Add_Product_Details obj = new frm_Add_Product_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Product_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Product obj = new frm_Search_Product();
            obj.Show();
            this.Hide();
        }

        private void button_Click(object sender, EventArgs e)
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
