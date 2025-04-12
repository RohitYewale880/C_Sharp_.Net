
namespace Shree_Mobile_Shopee_App
{
    partial class frm_Add_New_Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Customer_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Bill_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Bill_Date = new System.Windows.Forms.Label();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Customer_Id = new System.Windows.Forms.Label();
            this.gb_Puechase_Details = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.dgv_List_Of_Perchase_Mobile = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Mobiles = new System.Windows.Forms.ComboBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Sale_Price = new System.Windows.Forms.TextBox();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gb_Customer_Details.SuspendLayout();
            this.gb_Puechase_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Perchase_Mobile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.btn_Log_Out);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 67);
            this.panel1.TabIndex = 111;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Log_Out.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(815, -2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(140, 39);
            this.btn_Log_Out.TabIndex = 13;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.TextChanged += new System.EventHandler(this.Text_Changed);
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Back.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Red;
            this.btn_Back.Location = new System.Drawing.Point(-2, -2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(140, 39);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Header.Location = new System.Drawing.Point(297, 6);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(348, 54);
            this.lbl_Header.TabIndex = 100;
            this.lbl_Header.Text = "Add New Customer";
            // 
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.BackColor = System.Drawing.Color.OldLace;
            this.gb_Customer_Details.Controls.Add(this.dtp_Bill_Date);
            this.gb_Customer_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Customer_Details.Controls.Add(this.tb_Customer_Name);
            this.gb_Customer_Details.Controls.Add(this.tb_Customer_ID);
            this.gb_Customer_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Customer_Details.Controls.Add(this.lbl_Bill_Date);
            this.gb_Customer_Details.Controls.Add(this.lbl_Customer_Name);
            this.gb_Customer_Details.Controls.Add(this.lbl_Customer_Id);
            this.gb_Customer_Details.Location = new System.Drawing.Point(2, 75);
            this.gb_Customer_Details.Name = "gb_Customer_Details";
            this.gb_Customer_Details.Size = new System.Drawing.Size(952, 110);
            this.gb_Customer_Details.TabIndex = 1;
            this.gb_Customer_Details.TabStop = false;
            this.gb_Customer_Details.Text = "Customer Details";
            // 
            // dtp_Bill_Date
            // 
            this.dtp_Bill_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Bill_Date.Location = new System.Drawing.Point(714, 27);
            this.dtp_Bill_Date.Name = "dtp_Bill_Date";
            this.dtp_Bill_Date.Size = new System.Drawing.Size(229, 30);
            this.dtp_Bill_Date.TabIndex = 3;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(714, 66);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(229, 30);
            this.tb_Mobile_No.TabIndex = 4;
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(229, 66);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(322, 30);
            this.tb_Customer_Name.TabIndex = 2;
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Enabled = false;
            this.tb_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(229, 28);
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(322, 30);
            this.tb_Customer_ID.TabIndex = 1;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(583, 66);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(125, 29);
            this.lbl_Mobile_No.TabIndex = 1;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Bill_Date
            // 
            this.lbl_Bill_Date.AutoSize = true;
            this.lbl_Bill_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Date.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Bill_Date.Location = new System.Drawing.Point(583, 28);
            this.lbl_Bill_Date.Name = "lbl_Bill_Date";
            this.lbl_Bill_Date.Size = new System.Drawing.Size(103, 29);
            this.lbl_Bill_Date.TabIndex = 1;
            this.lbl_Bill_Date.Text = "Bill Date";
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Customer_Name.Location = new System.Drawing.Point(32, 66);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(188, 29);
            this.lbl_Customer_Name.TabIndex = 1;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // lbl_Customer_Id
            // 
            this.lbl_Customer_Id.AutoSize = true;
            this.lbl_Customer_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Id.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Customer_Id.Location = new System.Drawing.Point(32, 28);
            this.lbl_Customer_Id.Name = "lbl_Customer_Id";
            this.lbl_Customer_Id.Size = new System.Drawing.Size(146, 29);
            this.lbl_Customer_Id.TabIndex = 1;
            this.lbl_Customer_Id.Text = "Customer ID";
            // 
            // gb_Puechase_Details
            // 
            this.gb_Puechase_Details.BackColor = System.Drawing.Color.OldLace;
            this.gb_Puechase_Details.Controls.Add(this.btn_Refresh);
            this.gb_Puechase_Details.Controls.Add(this.btn_Save);
            this.gb_Puechase_Details.Controls.Add(this.tb_Total_Bill);
            this.gb_Puechase_Details.Controls.Add(this.lbl_Total_Bill);
            this.gb_Puechase_Details.Controls.Add(this.dgv_List_Of_Perchase_Mobile);
            this.gb_Puechase_Details.Controls.Add(this.btn_Add);
            this.gb_Puechase_Details.Controls.Add(this.cmb_Brand_Name);
            this.gb_Puechase_Details.Controls.Add(this.cmb_Mobiles);
            this.gb_Puechase_Details.Controls.Add(this.tb_Total);
            this.gb_Puechase_Details.Controls.Add(this.tb_Quantity);
            this.gb_Puechase_Details.Controls.Add(this.tb_Sale_Price);
            this.gb_Puechase_Details.Controls.Add(this.lbl_Total_Price);
            this.gb_Puechase_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Puechase_Details.Controls.Add(this.lbl_Price);
            this.gb_Puechase_Details.Controls.Add(this.lbl_Brand);
            this.gb_Puechase_Details.Controls.Add(this.lbl_Mobile);
            this.gb_Puechase_Details.Location = new System.Drawing.Point(2, 191);
            this.gb_Puechase_Details.Name = "gb_Puechase_Details";
            this.gb_Puechase_Details.Size = new System.Drawing.Size(952, 354);
            this.gb_Puechase_Details.TabIndex = 2;
            this.gb_Puechase_Details.TabStop = false;
            this.gb_Puechase_Details.Text = "Purchasee Details";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(10, 305);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 39);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(682, 300);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(132, 49);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(390, 309);
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(178, 35);
            this.tb_Total_Bill.TabIndex = 10;
            this.tb_Total_Bill.Text = "0";
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(172, 308);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(130, 36);
            this.lbl_Total_Bill.TabIndex = 12;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // dgv_List_Of_Perchase_Mobile
            // 
            this.dgv_List_Of_Perchase_Mobile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_List_Of_Perchase_Mobile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List_Of_Perchase_Mobile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.Brand_Name,
            this.Mobile,
            this.Price,
            this.Quantity,
            this.Total_Price});
            this.dgv_List_Of_Perchase_Mobile.Location = new System.Drawing.Point(0, 118);
            this.dgv_List_Of_Perchase_Mobile.Name = "dgv_List_Of_Perchase_Mobile";
            this.dgv_List_Of_Perchase_Mobile.Size = new System.Drawing.Size(955, 172);
            this.dgv_List_Of_Perchase_Mobile.TabIndex = 11;
            this.dgv_List_Of_Perchase_Mobile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_List_Of_Perchase_Mobile_CellContentClick);
            // 
            // Sr_No
            // 
            this.Sr_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Sr_No.HeaderText = "Sr No";
            this.Sr_No.Name = "Sr_No";
            this.Sr_No.Width = 59;
            // 
            // Brand_Name
            // 
            this.Brand_Name.HeaderText = "Brand Name";
            this.Brand_Name.Name = "Brand_Name";
            // 
            // Mobile
            // 
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.Name = "Mobile";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total_Price
            // 
            this.Total_Price.HeaderText = "Total Price";
            this.Total_Price.Name = "Total_Price";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Add.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Red;
            this.btn_Add.Location = new System.Drawing.Point(810, 44);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(123, 39);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cmb_Brand_Name
            // 
            this.cmb_Brand_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Brand_Name.FormattingEnabled = true;
            this.cmb_Brand_Name.ItemHeight = 25;
            this.cmb_Brand_Name.Location = new System.Drawing.Point(6, 62);
            this.cmb_Brand_Name.Name = "cmb_Brand_Name";
            this.cmb_Brand_Name.Size = new System.Drawing.Size(178, 33);
            this.cmb_Brand_Name.TabIndex = 6;
            this.cmb_Brand_Name.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // cmb_Mobiles
            // 
            this.cmb_Mobiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mobiles.Enabled = false;
            this.cmb_Mobiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mobiles.FormattingEnabled = true;
            this.cmb_Mobiles.ItemHeight = 25;
            this.cmb_Mobiles.Location = new System.Drawing.Point(190, 62);
            this.cmb_Mobiles.Name = "cmb_Mobiles";
            this.cmb_Mobiles.Size = new System.Drawing.Size(178, 33);
            this.cmb_Mobiles.TabIndex = 6;
            this.cmb_Mobiles.TextChanged += new System.EventHandler(this.cmb_Mobiles_TextChanged);
            // 
            // tb_Total
            // 
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(631, 62);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(146, 30);
            this.tb_Total.TabIndex = 8;
            this.tb_Total.Text = "0";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Enabled = false;
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(526, 62);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(99, 30);
            this.tb_Quantity.TabIndex = 8;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            // 
            // tb_Sale_Price
            // 
            this.tb_Sale_Price.Enabled = false;
            this.tb_Sale_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sale_Price.Location = new System.Drawing.Point(374, 62);
            this.tb_Sale_Price.Name = "tb_Sale_Price";
            this.tb_Sale_Price.Size = new System.Drawing.Size(146, 30);
            this.tb_Sale_Price.TabIndex = 8;
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Total_Price.Location = new System.Drawing.Point(640, 30);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(130, 29);
            this.lbl_Total_Price.TabIndex = 2;
            this.lbl_Total_Price.Text = "Total Price";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Quantity.Location = new System.Drawing.Point(525, 30);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(100, 29);
            this.lbl_Quantity.TabIndex = 2;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Price.Location = new System.Drawing.Point(409, 30);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(69, 29);
            this.lbl_Price.TabIndex = 2;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Brand.Location = new System.Drawing.Point(21, 30);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(148, 29);
            this.lbl_Brand.TabIndex = 2;
            this.lbl_Brand.Text = "Brand Name";
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Mobile.Location = new System.Drawing.Point(231, 30);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(87, 29);
            this.lbl_Mobile.TabIndex = 2;
            this.lbl_Mobile.Text = "Mobile";
            // 
            // frm_Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(957, 547);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Puechase_Details);
            this.Controls.Add(this.gb_Customer_Details);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Add_New_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.frm_Add_New_Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Customer_Details.ResumeLayout(false);
            this.gb_Customer_Details.PerformLayout();
            this.gb_Puechase_Details.ResumeLayout(false);
            this.gb_Puechase_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Perchase_Mobile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.GroupBox gb_Puechase_Details;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Bill_Date;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_Customer_Id;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.DateTimePicker dtp_Bill_Date;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.DataGridView dgv_List_Of_Perchase_Mobile;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Brand_Name;
        private System.Windows.Forms.ComboBox cmb_Mobiles;
        private System.Windows.Forms.TextBox tb_Sale_Price;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
    }
}