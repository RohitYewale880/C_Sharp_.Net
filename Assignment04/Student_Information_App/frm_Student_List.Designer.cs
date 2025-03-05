
namespace Student_Information_App
{
    partial class frm_Student_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Student_List));
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.pnl_Menu_Button = new System.Windows.Forms.Panel();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btn_Search_Student = new System.Windows.Forms.Button();
            this.btn_Update_Student = new System.Windows.Forms.Button();
            this.pnl_Add_Student = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.dgv_Student_Details = new System.Windows.Forms.DataGridView();
            this.pnl_Menu_Button.SuspendLayout();
            this.pnl_Add_Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(851, 0);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(108, 36);
            this.btn_Log_Out.TabIndex = 5;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Red;
            this.btn_Close.Location = new System.Drawing.Point(536, 462);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(108, 44);
            this.btn_Close.TabIndex = 49;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.BackColor = System.Drawing.Color.DimGray;
            this.btn_Student_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_List.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btn_Student_List.Location = new System.Drawing.Point(12, 289);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(201, 44);
            this.btn_Student_List.TabIndex = 6;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(12, 21);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(201, 44);
            this.btn_Add_New_Student.TabIndex = 6;
            this.btn_Add_New_Student.Text = "Add Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // pnl_Menu_Button
            // 
            this.pnl_Menu_Button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_Menu_Button.Controls.Add(this.lbl_UserName);
            this.pnl_Menu_Button.Controls.Add(this.btn_Search_Student);
            this.pnl_Menu_Button.Controls.Add(this.btn_Student_List);
            this.pnl_Menu_Button.Controls.Add(this.btn_Update_Student);
            this.pnl_Menu_Button.Controls.Add(this.btn_Add_New_Student);
            this.pnl_Menu_Button.Location = new System.Drawing.Point(-3, 84);
            this.pnl_Menu_Button.Name = "pnl_Menu_Button";
            this.pnl_Menu_Button.Size = new System.Drawing.Size(228, 425);
            this.pnl_Menu_Button.TabIndex = 36;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_UserName.Location = new System.Drawing.Point(0, 371);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(225, 54);
            this.lbl_UserName.TabIndex = 51;
            this.lbl_UserName.Text = "Welcome User";
            // 
            // btn_Search_Student
            // 
            this.btn_Search_Student.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Search_Student.Location = new System.Drawing.Point(12, 200);
            this.btn_Search_Student.Name = "btn_Search_Student";
            this.btn_Search_Student.Size = new System.Drawing.Size(201, 44);
            this.btn_Search_Student.TabIndex = 8;
            this.btn_Search_Student.Text = "Search Student";
            this.btn_Search_Student.UseVisualStyleBackColor = false;
            this.btn_Search_Student.Click += new System.EventHandler(this.btn_Search_Student_Click);
            // 
            // btn_Update_Student
            // 
            this.btn_Update_Student.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Update_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Student.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Update_Student.Location = new System.Drawing.Point(12, 111);
            this.btn_Update_Student.Name = "btn_Update_Student";
            this.btn_Update_Student.Size = new System.Drawing.Size(201, 44);
            this.btn_Update_Student.TabIndex = 6;
            this.btn_Update_Student.Text = "Update Student";
            this.btn_Update_Student.UseVisualStyleBackColor = false;
            this.btn_Update_Student.Click += new System.EventHandler(this.btn_Update_Student_Click);
            // 
            // pnl_Add_Student
            // 
            this.pnl_Add_Student.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_Add_Student.Controls.Add(this.lbl_Header);
            this.pnl_Add_Student.Controls.Add(this.pb_Logo);
            this.pnl_Add_Student.Controls.Add(this.btn_Log_Out);
            this.pnl_Add_Student.Location = new System.Drawing.Point(-3, -1);
            this.pnl_Add_Student.Name = "pnl_Add_Student";
            this.pnl_Add_Student.Size = new System.Drawing.Size(962, 89);
            this.pnl_Add_Student.TabIndex = 37;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Header.Location = new System.Drawing.Point(315, 14);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(500, 54);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Search Student Details";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = global::Student_Information_App.Properties.Resources.logo;
            this.pb_Logo.Location = new System.Drawing.Point(0, 0);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(228, 88);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 1;
            this.pb_Logo.TabStop = false;
            // 
            // dgv_Student_Details
            // 
            this.dgv_Student_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_Details.Location = new System.Drawing.Point(234, 94);
            this.dgv_Student_Details.Name = "dgv_Student_Details";
            this.dgv_Student_Details.Size = new System.Drawing.Size(711, 362);
            this.dgv_Student_Details.TabIndex = 50;
            // 
            // frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(957, 508);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Student_Details);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.pnl_Menu_Button);
            this.Controls.Add(this.pnl_Add_Student);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentSearch";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            this.pnl_Menu_Button.ResumeLayout(false);
            this.pnl_Add_Student.ResumeLayout(false);
            this.pnl_Add_Student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Panel pnl_Menu_Button;
        private System.Windows.Forms.Button btn_Update_Student;
        private System.Windows.Forms.Panel pnl_Add_Student;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dgv_Student_Details;
        private System.Windows.Forms.Button btn_Search_Student;
        private System.Windows.Forms.Label lbl_UserName;
    }
}