using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_No_5
{
    public partial class frm_Employee_Details : Form
    {
        public frm_Employee_Details()
        {
            InitializeComponent();
        }

        private void frm_Employee_Details_Load(object sender, EventArgs e)
        {
            tb_Employee_Name.Focus();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Text = "";
            cmb_Employee_Dept.SelectedIndex = -1;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = " ";
            bool flag = false;

            if (tb_Employee_Name.Text != " ")
            {
                Result = tb_Employee_Name.Text;

                if (cmb_Employee_Dept.Text != " ")
                {
                    Result += " From Department " + cmb_Employee_Dept.Text + " is ";

                    if (rb_Male.Checked == true)
                    {
                        Result += rb_Male.Text + " Candidate Prefers Shift Timing ";
                    }
                    else if (rb_Female.Checked == true)
                    {
                        Result += rb_Female.Text + " Candidate Prefers Shift Timing ";
                    }
                    else
                    {
                        MessageBox.Show(" Select Gender Of Employee ");
                    }


                    if (rb_Morning.Checked == true)
                    {
                        Result += rb_Morning.Text + ".";
                    }
                    else if (rb_Evening.Checked == true)
                    {
                        Result += rb_Evening.Text + ".";
                    }
                    else if (rb_Night.Checked == true)
                    {
                        Result += rb_Night.Text + ".";
                    }
                    else
                    {
                        MessageBox.Show("Select Shift Timing");
                        flag = true;
                    }
                }
                else
                {
                    MessageBox.Show("Select Employee Department");
                    flag = true;
                }
            }
            else
            {
                MessageBox.Show("Enter Employee Name");
                flag = true;
            }

            if (flag == false)
            {
                tb_Output.Text = Result;
            }
        }
    }
}
