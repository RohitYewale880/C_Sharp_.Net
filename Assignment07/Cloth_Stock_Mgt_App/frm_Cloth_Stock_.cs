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
            Cmd.CommandText = "Select (Cloth_Type) From Cloth_Details Where Cloth_Type = '" + cmb_Cloth_Type + "'";


            SqlDataReader Dr = Cmd.ExecuteReader();

            cmb_Cloth_Type.Items.Clear();

            while (Dr.Read())
            {
                cmb_Cloth_Type.Items.Add(Dr.GetString(Dr.GetOrdinal("Cloth_Type")));
            }

            Con_Stop();
        }
    }
}
