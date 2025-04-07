
namespace Shree_Mobile_Shopee_App
{
    partial class frm_Add_New_Mobile
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Mobile_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Sale_Rate = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Rate = new System.Windows.Forms.TextBox();
            this.tb_Mobile_Brand = new System.Windows.Forms.TextBox();
            this.tb_Mobile_Name = new System.Windows.Forms.TextBox();
            this.tb_Mobile_ID = new System.Windows.Forms.TextBox();
            this.lbl_Sale_Rate = new System.Windows.Forms.Label();
            this.lbl_Purchase_Rate = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Mobile_Brand = new System.Windows.Forms.Label();
            this.lbl_Mobile_Name = new System.Windows.Forms.Label();
            this.lbl_Mobile_ID = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.gb_Mobile_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnl_Header.Controls.Add(this.btn_Log_Out);
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Location = new System.Drawing.Point(1, 1);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(916, 86);
            this.pnl_Header.TabIndex = 113;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Log_Out.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(776, 0);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(140, 39);
            this.btn_Log_Out.TabIndex = 9;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Back.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Red;
            this.btn_Back.Location = new System.Drawing.Point(-1, -1);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(140, 39);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Header.Location = new System.Drawing.Point(264, 8);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(350, 68);
            this.lbl_Header.TabIndex = 100;
            this.lbl_Header.Text = "Add New Mobile";
            // 
            // gb_Mobile_Details
            // 
            this.gb_Mobile_Details.BackColor = System.Drawing.Color.OldLace;
            this.gb_Mobile_Details.Controls.Add(this.dtp_Date);
            this.gb_Mobile_Details.Controls.Add(this.tb_Sale_Rate);
            this.gb_Mobile_Details.Controls.Add(this.tb_Purchase_Rate);
            this.gb_Mobile_Details.Controls.Add(this.tb_Mobile_Brand);
            this.gb_Mobile_Details.Controls.Add(this.tb_Mobile_Name);
            this.gb_Mobile_Details.Controls.Add(this.tb_Mobile_ID);
            this.gb_Mobile_Details.Controls.Add(this.lbl_Sale_Rate);
            this.gb_Mobile_Details.Controls.Add(this.lbl_Purchase_Rate);
            this.gb_Mobile_Details.Controls.Add(this.lbl_Date);
            this.gb_Mobile_Details.Controls.Add(this.lbl_Mobile_Brand);
            this.gb_Mobile_Details.Controls.Add(this.lbl_Mobile_Name);
            this.gb_Mobile_Details.Controls.Add(this.lbl_Mobile_ID);
            this.gb_Mobile_Details.Location = new System.Drawing.Point(1, 103);
            this.gb_Mobile_Details.Name = "gb_Mobile_Details";
            this.gb_Mobile_Details.Size = new System.Drawing.Size(916, 356);
            this.gb_Mobile_Details.TabIndex = 111;
            this.gb_Mobile_Details.TabStop = false;
            this.gb_Mobile_Details.Text = "Mobile Details";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(687, 35);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(215, 32);
            this.dtp_Date.TabIndex = 4;
            // 
            // tb_Sale_Rate
            // 
            this.tb_Sale_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sale_Rate.Location = new System.Drawing.Point(687, 271);
            this.tb_Sale_Rate.Name = "tb_Sale_Rate";
            this.tb_Sale_Rate.Size = new System.Drawing.Size(215, 32);
            this.tb_Sale_Rate.TabIndex = 6;
            // 
            // tb_Purchase_Rate
            // 
            this.tb_Purchase_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Rate.Location = new System.Drawing.Point(687, 154);
            this.tb_Purchase_Rate.Name = "tb_Purchase_Rate";
            this.tb_Purchase_Rate.Size = new System.Drawing.Size(215, 32);
            this.tb_Purchase_Rate.TabIndex = 5;
            // 
            // tb_Mobile_Brand
            // 
            this.tb_Mobile_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_Brand.Location = new System.Drawing.Point(214, 271);
            this.tb_Mobile_Brand.Name = "tb_Mobile_Brand";
            this.tb_Mobile_Brand.Size = new System.Drawing.Size(215, 32);
            this.tb_Mobile_Brand.TabIndex = 3;
            // 
            // tb_Mobile_Name
            // 
            this.tb_Mobile_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_Name.Location = new System.Drawing.Point(214, 154);
            this.tb_Mobile_Name.Name = "tb_Mobile_Name";
            this.tb_Mobile_Name.Size = new System.Drawing.Size(215, 32);
            this.tb_Mobile_Name.TabIndex = 2;
            // 
            // tb_Mobile_ID
            // 
            this.tb_Mobile_ID.Enabled = false;
            this.tb_Mobile_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_ID.Location = new System.Drawing.Point(214, 38);
            this.tb_Mobile_ID.Name = "tb_Mobile_ID";
            this.tb_Mobile_ID.Size = new System.Drawing.Size(215, 32);
            this.tb_Mobile_ID.TabIndex = 1;
            // 
            // lbl_Sale_Rate
            // 
            this.lbl_Sale_Rate.AutoSize = true;
            this.lbl_Sale_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sale_Rate.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Sale_Rate.Location = new System.Drawing.Point(485, 268);
            this.lbl_Sale_Rate.Name = "lbl_Sale_Rate";
            this.lbl_Sale_Rate.Size = new System.Drawing.Size(133, 31);
            this.lbl_Sale_Rate.TabIndex = 114;
            this.lbl_Sale_Rate.Text = "Sale Rate";
            // 
            // lbl_Purchase_Rate
            // 
            this.lbl_Purchase_Rate.AutoSize = true;
            this.lbl_Purchase_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Rate.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Purchase_Rate.Location = new System.Drawing.Point(485, 151);
            this.lbl_Purchase_Rate.Name = "lbl_Purchase_Rate";
            this.lbl_Purchase_Rate.Size = new System.Drawing.Size(194, 31);
            this.lbl_Purchase_Rate.TabIndex = 115;
            this.lbl_Purchase_Rate.Text = "Purchase Rate";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Date.Location = new System.Drawing.Point(485, 35);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(72, 31);
            this.lbl_Date.TabIndex = 116;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Mobile_Brand
            // 
            this.lbl_Mobile_Brand.AutoSize = true;
            this.lbl_Mobile_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_Brand.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Mobile_Brand.Location = new System.Drawing.Point(11, 268);
            this.lbl_Mobile_Brand.Name = "lbl_Mobile_Brand";
            this.lbl_Mobile_Brand.Size = new System.Drawing.Size(172, 31);
            this.lbl_Mobile_Brand.TabIndex = 117;
            this.lbl_Mobile_Brand.Text = "Mobile Brand";
            // 
            // lbl_Mobile_Name
            // 
            this.lbl_Mobile_Name.AutoSize = true;
            this.lbl_Mobile_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_Name.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Mobile_Name.Location = new System.Drawing.Point(11, 151);
            this.lbl_Mobile_Name.Name = "lbl_Mobile_Name";
            this.lbl_Mobile_Name.Size = new System.Drawing.Size(172, 31);
            this.lbl_Mobile_Name.TabIndex = 118;
            this.lbl_Mobile_Name.Text = "Mobile Name";
            // 
            // lbl_Mobile_ID
            // 
            this.lbl_Mobile_ID.AutoSize = true;
            this.lbl_Mobile_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_ID.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Mobile_ID.Location = new System.Drawing.Point(11, 35);
            this.lbl_Mobile_ID.Name = "lbl_Mobile_ID";
            this.lbl_Mobile_ID.Size = new System.Drawing.Size(128, 31);
            this.lbl_Mobile_ID.TabIndex = 119;
            this.lbl_Mobile_ID.Text = "Mobile ID";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(388, 465);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(140, 48);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // frm_Add_New_Mobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(916, 525);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Mobile_Details);
            this.Controls.Add(this.pnl_Header);
            this.Name = "frm_Add_New_Mobile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Mobile";
            this.Load += new System.EventHandler(this.frm_Add_New_Mobile_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Mobile_Details.ResumeLayout(false);
            this.gb_Mobile_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.GroupBox gb_Mobile_Details;
        private System.Windows.Forms.TextBox tb_Sale_Rate;
        private System.Windows.Forms.TextBox tb_Purchase_Rate;
        private System.Windows.Forms.TextBox tb_Mobile_Brand;
        private System.Windows.Forms.TextBox tb_Mobile_Name;
        private System.Windows.Forms.TextBox tb_Mobile_ID;
        private System.Windows.Forms.Label lbl_Sale_Rate;
        private System.Windows.Forms.Label lbl_Purchase_Rate;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Mobile_Brand;
        private System.Windows.Forms.Label lbl_Mobile_Name;
        private System.Windows.Forms.Label lbl_Mobile_ID;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_Save;
    }
}