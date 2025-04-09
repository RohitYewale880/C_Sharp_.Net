
namespace Shree_Mobile_Shopee_App
{
    partial class frm_Search_Customer_Details
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
            this.dtp_Bill_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Bill_Date = new System.Windows.Forms.Label();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.gb_Customer_Details = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Customer_Id = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_List_Of_Perchase_Mobile = new System.Windows.Forms.DataGridView();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.gb_Puechase_Details = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Customer_Details.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Perchase_Mobile)).BeginInit();
            this.gb_Puechase_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_Bill_Date
            // 
            this.dtp_Bill_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Bill_Date.Location = new System.Drawing.Point(714, 27);
            this.dtp_Bill_Date.Name = "dtp_Bill_Date";
            this.dtp_Bill_Date.Size = new System.Drawing.Size(229, 30);
            this.dtp_Bill_Date.TabIndex = 23;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(714, 66);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(229, 30);
            this.tb_Mobile_No.TabIndex = 24;
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(229, 66);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(322, 30);
            this.tb_Customer_Name.TabIndex = 22;
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(229, 28);
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(196, 30);
            this.tb_Customer_ID.TabIndex = 2;
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
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.BackColor = System.Drawing.Color.OldLace;
            this.gb_Customer_Details.Controls.Add(this.btn_Search);
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
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Search.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Red;
            this.btn_Search.Location = new System.Drawing.Point(452, 27);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(99, 30);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Log_Out.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(815, -2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(140, 39);
            this.btn_Log_Out.TabIndex = 5;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
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
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Header.Location = new System.Drawing.Point(269, 3);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(449, 54);
            this.lbl_Header.TabIndex = 111;
            this.lbl_Header.Text = "Search Customer Details";
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
            this.panel1.TabIndex = 1111;
            // 
            // dgv_List_Of_Perchase_Mobile
            // 
            this.dgv_List_Of_Perchase_Mobile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List_Of_Perchase_Mobile.Location = new System.Drawing.Point(-3, 19);
            this.dgv_List_Of_Perchase_Mobile.Name = "dgv_List_Of_Perchase_Mobile";
            this.dgv_List_Of_Perchase_Mobile.Size = new System.Drawing.Size(955, 257);
            this.dgv_List_Of_Perchase_Mobile.TabIndex = 11;
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(486, 298);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(130, 36);
            this.lbl_Total_Bill.TabIndex = 12;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // tb_Total
            // 
            this.tb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(685, 299);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(184, 35);
            this.tb_Total.TabIndex = 13;
            // 
            // gb_Puechase_Details
            // 
            this.gb_Puechase_Details.BackColor = System.Drawing.Color.OldLace;
            this.gb_Puechase_Details.Controls.Add(this.btn_Refresh);
            this.gb_Puechase_Details.Controls.Add(this.tb_Total);
            this.gb_Puechase_Details.Controls.Add(this.lbl_Total_Bill);
            this.gb_Puechase_Details.Controls.Add(this.dgv_List_Of_Perchase_Mobile);
            this.gb_Puechase_Details.Location = new System.Drawing.Point(2, 191);
            this.gb_Puechase_Details.Name = "gb_Puechase_Details";
            this.gb_Puechase_Details.Size = new System.Drawing.Size(952, 354);
            this.gb_Puechase_Details.TabIndex = 5;
            this.gb_Puechase_Details.TabStop = false;
            this.gb_Puechase_Details.Text = "Purchasee Details";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(154, 299);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 39);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // frm_Search_Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 547);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Puechase_Details);
            this.Controls.Add(this.gb_Customer_Details);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Search_Customer_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Customer Details";
            this.gb_Customer_Details.ResumeLayout(false);
            this.gb_Customer_Details.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Perchase_Mobile)).EndInit();
            this.gb_Puechase_Details.ResumeLayout(false);
            this.gb_Puechase_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_Bill_Date;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Bill_Date;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.Label lbl_Customer_Id;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_List_Of_Perchase_Mobile;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.GroupBox gb_Puechase_Details;
        private System.Windows.Forms.Button btn_Refresh;
    }
}