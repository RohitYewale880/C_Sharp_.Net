
namespace Assignment_No_6
{
    partial class frm_Employee_Details
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
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.gb_Shift_Time = new System.Windows.Forms.GroupBox();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.cmb_Employee_Dept = new System.Windows.Forms.ComboBox();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Employee_Department = new System.Windows.Forms.Label();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Known_Language = new System.Windows.Forms.Label();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.gb_Known_Language = new System.Windows.Forms.GroupBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lbl_Error_Name = new System.Windows.Forms.Label();
            this.lbl_Error_Department = new System.Windows.Forms.Label();
            this.lbl_Error_Gender = new System.Windows.Forms.Label();
            this.lbl_Error_Shift_Time = new System.Windows.Forms.Label();
            this.lbl_Error_Language = new System.Windows.Forms.Label();
            this.lbl_Error_Hobbies = new System.Windows.Forms.Label();
            this.gb_Shift_Time.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.gb_Known_Language.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(184, 464);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(766, 29);
            this.tb_Output.TabIndex = 20;
            // 
            // rb_Night
            // 
            this.rb_Night.AutoSize = true;
            this.rb_Night.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Night.Location = new System.Drawing.Point(227, 19);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(59, 21);
            this.rb_Night.TabIndex = 7;
            this.rb_Night.TabStop = true;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            // 
            // rb_Evening
            // 
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Evening.Location = new System.Drawing.Point(126, 19);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(77, 21);
            this.rb_Evening.TabIndex = 6;
            this.rb_Evening.TabStop = true;
            this.rb_Evening.Text = "Evening";
            this.rb_Evening.UseVisualStyleBackColor = true;
            // 
            // gb_Shift_Time
            // 
            this.gb_Shift_Time.BackColor = System.Drawing.Color.LightGray;
            this.gb_Shift_Time.Controls.Add(this.rb_Night);
            this.gb_Shift_Time.Controls.Add(this.rb_Evening);
            this.gb_Shift_Time.Controls.Add(this.rb_Morning);
            this.gb_Shift_Time.ForeColor = System.Drawing.Color.Black;
            this.gb_Shift_Time.Location = new System.Drawing.Point(223, 324);
            this.gb_Shift_Time.Name = "gb_Shift_Time";
            this.gb_Shift_Time.Size = new System.Drawing.Size(304, 54);
            this.gb_Shift_Time.TabIndex = 19;
            this.gb_Shift_Time.TabStop = false;
            this.gb_Shift_Time.Text = "Time";
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Morning.Location = new System.Drawing.Point(31, 19);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(77, 21);
            this.rb_Morning.TabIndex = 5;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(175, 19);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(72, 21);
            this.rb_Female.TabIndex = 4;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.Color.LightGray;
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.ForeColor = System.Drawing.Color.Black;
            this.gb_Gender.Location = new System.Drawing.Point(223, 247);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(304, 54);
            this.gb_Gender.TabIndex = 18;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(52, 19);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(56, 21);
            this.rb_Male.TabIndex = 3;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // cmb_Employee_Dept
            // 
            this.cmb_Employee_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Employee_Dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee_Dept.FormattingEnabled = true;
            this.cmb_Employee_Dept.Items.AddRange(new object[] {
            "Development",
            "Analist",
            "Tester",
            "Manager",
            "Coder"});
            this.cmb_Employee_Dept.Location = new System.Drawing.Point(223, 173);
            this.cmb_Employee_Dept.Name = "cmb_Employee_Dept";
            this.cmb_Employee_Dept.Size = new System.Drawing.Size(304, 28);
            this.cmb_Employee_Dept.TabIndex = 17;
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Name.Location = new System.Drawing.Point(223, 99);
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(304, 27);
            this.tb_Employee_Name.TabIndex = 16;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Refresh.Location = new System.Drawing.Point(370, 405);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(130, 39);
            this.btn_Refresh.TabIndex = 21;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Submit.Location = new System.Drawing.Point(679, 405);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(130, 39);
            this.btn_Submit.TabIndex = 22;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Output.Location = new System.Drawing.Point(94, 464);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(84, 29);
            this.lbl_Output.TabIndex = 10;
            this.lbl_Output.Text = "Output";
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.AutoSize = true;
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Shift_Time.Location = new System.Drawing.Point(12, 324);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(100, 25);
            this.lbl_Shift_Time.TabIndex = 11;
            this.lbl_Shift_Time.Text = "Shift Time";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Gender.Location = new System.Drawing.Point(12, 247);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(77, 25);
            this.lbl_Gender.TabIndex = 12;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Employee_Department
            // 
            this.lbl_Employee_Department.AutoSize = true;
            this.lbl_Employee_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Department.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Employee_Department.Location = new System.Drawing.Point(12, 172);
            this.lbl_Employee_Department.Name = "lbl_Employee_Department";
            this.lbl_Employee_Department.Size = new System.Drawing.Size(205, 25);
            this.lbl_Employee_Department.TabIndex = 13;
            this.lbl_Employee_Department.Text = "Employee Department";
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Employee_Name.Location = new System.Drawing.Point(12, 99);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(156, 25);
            this.lbl_Employee_Name.TabIndex = 14;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Header.Location = new System.Drawing.Point(324, 17);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(386, 54);
            this.lbl_Header.TabIndex = 15;
            this.lbl_Header.Text = "Employee Details";
            // 
            // lbl_Known_Language
            // 
            this.lbl_Known_Language.AutoSize = true;
            this.lbl_Known_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Known_Language.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Known_Language.Location = new System.Drawing.Point(576, 98);
            this.lbl_Known_Language.Name = "lbl_Known_Language";
            this.lbl_Known_Language.Size = new System.Drawing.Size(176, 25);
            this.lbl_Known_Language.TabIndex = 23;
            this.lbl_Known_Language.Text = "Known Languages";
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Hobbies.Location = new System.Drawing.Point(576, 247);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(84, 25);
            this.lbl_Hobbies.TabIndex = 24;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // gb_Known_Language
            // 
            this.gb_Known_Language.BackColor = System.Drawing.Color.LightGray;
            this.gb_Known_Language.Controls.Add(this.cb_French);
            this.gb_Known_Language.Controls.Add(this.cb_Hindi);
            this.gb_Known_Language.Controls.Add(this.cb_English);
            this.gb_Known_Language.Controls.Add(this.cb_Marathi);
            this.gb_Known_Language.Location = new System.Drawing.Point(679, 138);
            this.gb_Known_Language.Name = "gb_Known_Language";
            this.gb_Known_Language.Size = new System.Drawing.Size(298, 82);
            this.gb_Known_Language.TabIndex = 25;
            this.gb_Known_Language.TabStop = false;
            this.gb_Known_Language.Text = "Known Language";
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_French.Location = new System.Drawing.Point(167, 46);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(71, 21);
            this.cb_French.TabIndex = 3;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Hindi.Location = new System.Drawing.Point(167, 19);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(59, 21);
            this.cb_Hindi.TabIndex = 2;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_English.Location = new System.Drawing.Point(25, 46);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(73, 21);
            this.cb_English.TabIndex = 1;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Marathi.Location = new System.Drawing.Point(25, 19);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(74, 21);
            this.cb_Marathi.TabIndex = 0;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.LightGray;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Reading",
            "Dancing",
            "Cycling",
            "Gamming",
            "Coocking",
            "Driving"});
            this.checkedListBox1.Location = new System.Drawing.Point(679, 247);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(298, 130);
            this.checkedListBox1.TabIndex = 26;
            // 
            // lbl_Error_Name
            // 
            this.lbl_Error_Name.AutoSize = true;
            this.lbl_Error_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Name.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Name.Location = new System.Drawing.Point(413, 129);
            this.lbl_Error_Name.Name = "lbl_Error_Name";
            this.lbl_Error_Name.Size = new System.Drawing.Size(114, 17);
            this.lbl_Error_Name.TabIndex = 27;
            this.lbl_Error_Name.Text = "Enter Name First";
            this.lbl_Error_Name.Visible = false;
            // 
            // lbl_Error_Department
            // 
            this.lbl_Error_Department.AutoSize = true;
            this.lbl_Error_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Department.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Department.Location = new System.Drawing.Point(407, 203);
            this.lbl_Error_Department.Name = "lbl_Error_Department";
            this.lbl_Error_Department.Size = new System.Drawing.Size(120, 17);
            this.lbl_Error_Department.TabIndex = 28;
            this.lbl_Error_Department.Text = "Enter Department";
            this.lbl_Error_Department.Visible = false;
            // 
            // lbl_Error_Gender
            // 
            this.lbl_Error_Gender.AutoSize = true;
            this.lbl_Error_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Gender.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Gender.Location = new System.Drawing.Point(369, 304);
            this.lbl_Error_Gender.Name = "lbl_Error_Gender";
            this.lbl_Error_Gender.Size = new System.Drawing.Size(158, 17);
            this.lbl_Error_Gender.TabIndex = 29;
            this.lbl_Error_Gender.Text = "Select Any One Gender";
            this.lbl_Error_Gender.Visible = false;
            // 
            // lbl_Error_Shift_Time
            // 
            this.lbl_Error_Shift_Time.AutoSize = true;
            this.lbl_Error_Shift_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Shift_Time.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Shift_Time.Location = new System.Drawing.Point(389, 380);
            this.lbl_Error_Shift_Time.Name = "lbl_Error_Shift_Time";
            this.lbl_Error_Shift_Time.Size = new System.Drawing.Size(138, 17);
            this.lbl_Error_Shift_Time.TabIndex = 30;
            this.lbl_Error_Shift_Time.Text = "Select Any One Shift";
            this.lbl_Error_Shift_Time.Visible = false;
            // 
            // lbl_Error_Language
            // 
            this.lbl_Error_Language.AutoSize = true;
            this.lbl_Error_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Language.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Language.Location = new System.Drawing.Point(826, 223);
            this.lbl_Error_Language.Name = "lbl_Error_Language";
            this.lbl_Error_Language.Size = new System.Drawing.Size(151, 17);
            this.lbl_Error_Language.TabIndex = 31;
            this.lbl_Error_Language.Text = "Select The Languages";
            this.lbl_Error_Language.Visible = false;
            // 
            // lbl_Error_Hobbies
            // 
            this.lbl_Error_Hobbies.AutoSize = true;
            this.lbl_Error_Hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Hobbies.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Hobbies.Location = new System.Drawing.Point(845, 380);
            this.lbl_Error_Hobbies.Name = "lbl_Error_Hobbies";
            this.lbl_Error_Hobbies.Size = new System.Drawing.Size(132, 17);
            this.lbl_Error_Hobbies.TabIndex = 32;
            this.lbl_Error_Hobbies.Text = "Select The Hobbies";
            this.lbl_Error_Hobbies.Visible = false;
            // 
            // frm_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 510);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Error_Hobbies);
            this.Controls.Add(this.lbl_Error_Language);
            this.Controls.Add(this.lbl_Error_Shift_Time);
            this.Controls.Add(this.lbl_Error_Gender);
            this.Controls.Add(this.lbl_Error_Department);
            this.Controls.Add(this.lbl_Error_Name);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.gb_Known_Language);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.lbl_Known_Language);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.gb_Shift_Time);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.cmb_Employee_Dept);
            this.Controls.Add(this.tb_Employee_Name);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Shift_Time);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employee_Department);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.frm_Employee_Details_Load);
            this.gb_Shift_Time.ResumeLayout(false);
            this.gb_Shift_Time.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Known_Language.ResumeLayout(false);
            this.gb_Known_Language.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.RadioButton rb_Evening;
        private System.Windows.Forms.GroupBox gb_Shift_Time;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.ComboBox cmb_Employee_Dept;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Employee_Department;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Known_Language;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.GroupBox gb_Known_Language;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lbl_Error_Name;
        private System.Windows.Forms.Label lbl_Error_Department;
        private System.Windows.Forms.Label lbl_Error_Gender;
        private System.Windows.Forms.Label lbl_Error_Shift_Time;
        private System.Windows.Forms.Label lbl_Error_Language;
        private System.Windows.Forms.Label lbl_Error_Hobbies;
    }
}

