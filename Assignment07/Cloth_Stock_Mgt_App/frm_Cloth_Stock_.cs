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

namespace Cloth_Stock_Mgt_App
{
    public partial class frm_Cloth_Stock_ : Form
    {
        public frm_Cloth_Stock_()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-JQI0KIJ;Initial Catalog=Cloth_Stock_Mgt_App_DB;Integrated Security=True;Pooling=False");

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
        private void frm_Cloth_Stock__Load(object sender, EventArgs e)
        {
            Con_Start();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Category) From Category_Details";

            SqlDataReader Dr = Cmd.ExecuteReader();

            cmb_Category.Items.Clear();

            while(Dr.Read())
            {
                cmb_Category.Items.Add(Dr["Category"].ToString());
            }

            Con_Stop();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Start();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Sub_Category) From Sub_Category_Details where Category = '" + cmb_Category.Text + "' ";

            SqlDataReader Dr = Cmd.ExecuteReader();

            cmb_Sub_Category.Items.Clear();

            while (Dr.Read())
            {
                cmb_Sub_Category.Items.Add(Dr["Sub_Category"].ToString());
            }

            Con_Stop();
        }

        private void cmb_Sub_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Start();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Product_Name) From Product_Details where Category = '" + cmb_Category.Text + "' And Sub_Category = '" + cmb_Sub_Category.Text + "' ";

            SqlDataReader Dr = Cmd.ExecuteReader();

            cmb_Product_Name.Items.Clear();

            while (Dr.Read())
            {
                cmb_Product_Name.Items.Add(Dr["Product_Name"].ToString());
            }

            Con_Stop();
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Start();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Current_Stock, Sales_Price From Product_Details where Category = '" + cmb_Category.Text + "' And Sub_Category = '" + cmb_Sub_Category.Text + "' And Product_Name = '" + cmb_Product_Name.Text + "' ";

            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                lbl_Current_Stock.Text = Dr["Current_Stock"].ToString();
                tb_Price.Text = Dr["Sales_Price"].ToString();
            }

            Con_Stop();
        }
    }
}
