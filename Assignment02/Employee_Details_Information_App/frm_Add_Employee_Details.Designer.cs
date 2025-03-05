
namespace Employee_Details_Information_App
{
    partial class frm_Add_Employee_Details
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Employee_Id = new System.Windows.Forms.Label();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Joinning_Date = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.tb_Employee_Id = new System.Windows.Forms.TextBox();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.dtp_Joinning_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Employee_List = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_UNAME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Snow;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Header.Location = new System.Drawing.Point(206, 12);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(501, 62);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Add New Employee";
            // 
            // lbl_Employee_Id
            // 
            this.lbl_Employee_Id.AutoSize = true;
            this.lbl_Employee_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Employee_Id.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Id.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Employee_Id.Location = new System.Drawing.Point(112, 109);
            this.lbl_Employee_Id.Name = "lbl_Employee_Id";
            this.lbl_Employee_Id.Size = new System.Drawing.Size(167, 31);
            this.lbl_Employee_Id.TabIndex = 2;
            this.lbl_Employee_Id.Text = "Employee Id";
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Employee_Name.Location = new System.Drawing.Point(112, 164);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(212, 31);
            this.lbl_Employee_Name.TabIndex = 2;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(112, 217);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(141, 31);
            this.lbl_Mobile_No.TabIndex = 2;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Joinning_Date
            // 
            this.lbl_Joinning_Date.AutoSize = true;
            this.lbl_Joinning_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Joinning_Date.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Joinning_Date.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Joinning_Date.Location = new System.Drawing.Point(112, 272);
            this.lbl_Joinning_Date.Name = "lbl_Joinning_Date";
            this.lbl_Joinning_Date.Size = new System.Drawing.Size(184, 31);
            this.lbl_Joinning_Date.TabIndex = 2;
            this.lbl_Joinning_Date.Text = "Joinning Date";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Salary.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Salary.Location = new System.Drawing.Point(112, 384);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(89, 31);
            this.lbl_Salary.TabIndex = 2;
            this.lbl_Salary.Text = "Salary";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Department.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Department.Location = new System.Drawing.Point(112, 327);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(158, 31);
            this.lbl_Department.TabIndex = 2;
            this.lbl_Department.Text = "Department";
            // 
            // tb_Employee_Id
            // 
            this.tb_Employee_Id.Enabled = false;
            this.tb_Employee_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.tb_Employee_Id.Location = new System.Drawing.Point(466, 108);
            this.tb_Employee_Id.MaxLength = 5;
            this.tb_Employee_Id.Name = "tb_Employee_Id";
            this.tb_Employee_Id.Size = new System.Drawing.Size(379, 33);
            this.tb_Employee_Id.TabIndex = 1;
            this.tb_Employee_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.tb_Employee_Name.Location = new System.Drawing.Point(466, 163);
            this.tb_Employee_Name.MaxLength = 20;
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(379, 33);
            this.tb_Employee_Name.TabIndex = 2;
            this.tb_Employee_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.tb_Mobile_No.Location = new System.Drawing.Point(466, 216);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(379, 33);
            this.tb_Mobile_No.TabIndex = 3;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.tb_Salary.Location = new System.Drawing.Point(466, 383);
            this.tb_Salary.MaxLength = 5;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(379, 33);
            this.tb_Salary.TabIndex = 6;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numbers);
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "Accountant",
            "Manager",
            "Cashier",
            "Machine Operater",
            "Canteen"});
            this.cmb_Department.Location = new System.Drawing.Point(466, 326);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(379, 37);
            this.cmb_Department.TabIndex = 5;
            // 
            // dtp_Joinning_Date
            // 
            this.dtp_Joinning_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Joinning_Date.Location = new System.Drawing.Point(466, 270);
            this.dtp_Joinning_Date.Name = "dtp_Joinning_Date";
            this.dtp_Joinning_Date.Size = new System.Drawing.Size(379, 33);
            this.dtp_Joinning_Date.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Save.Location = new System.Drawing.Point(349, 454);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(122, 39);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Employee_List
            // 
            this.btn_Employee_List.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Employee_List.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_List.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Employee_List.Location = new System.Drawing.Point(90, 454);
            this.btn_Employee_List.Name = "btn_Employee_List";
            this.btn_Employee_List.Size = new System.Drawing.Size(206, 39);
            this.btn_Employee_List.TabIndex = 8;
            this.btn_Employee_List.Text = "Employee List";
            this.btn_Employee_List.UseVisualStyleBackColor = false;
            this.btn_Employee_List.Click += new System.EventHandler(this.btn_Employee_List_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Refresh.Location = new System.Drawing.Point(532, 454);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(122, 39);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Close.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Close.Location = new System.Drawing.Point(723, 454);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(122, 39);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Log_Out.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Log_Out.Location = new System.Drawing.Point(850, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(91, 39);
            this.btn_Log_Out.TabIndex = 11;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_UNAME
            // 
            this.lbl_UNAME.AutoSize = true;
            this.lbl_UNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UNAME.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_UNAME.Location = new System.Drawing.Point(12, 12);
            this.lbl_UNAME.Name = "lbl_UNAME";
            this.lbl_UNAME.Size = new System.Drawing.Size(57, 17);
            this.lbl_UNAME.TabIndex = 12;
            this.lbl_UNAME.Text = "UMANE";
            // 
            // frm_Add_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(962, 559);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_UNAME);
            this.Controls.Add(this.btn_Employee_List);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_Joinning_Date);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.tb_Salary);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Employee_Name);
            this.Controls.Add(this.tb_Employee_Id);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.lbl_Joinning_Date);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.lbl_Employee_Id);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Add_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee Details";
            this.Load += new System.EventHandler(this.frm_Add_Employee_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Employee_Id;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Joinning_Date;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.TextBox tb_Employee_Id;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.DateTimePicker dtp_Joinning_Date;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Employee_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_UNAME;
    }
}