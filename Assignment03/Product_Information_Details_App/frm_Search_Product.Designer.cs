
namespace Product_Information_Details_App
{
    partial class frm_Search_Product
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
            this.lbl_Hrader = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Expiry_Date = new System.Windows.Forms.Label();
            this.lbl_Packing_Date = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Product_Id = new System.Windows.Forms.Label();
            this.dtp_Expiry_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Packing_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Product_Id = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Add_Product = new System.Windows.Forms.Button();
            this.btn_Product_List = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Hrader
            // 
            this.lbl_Hrader.AutoSize = true;
            this.lbl_Hrader.BackColor = System.Drawing.Color.Azure;
            this.lbl_Hrader.Font = new System.Drawing.Font("Georgia", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hrader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Hrader.Location = new System.Drawing.Point(251, 9);
            this.lbl_Hrader.Name = "lbl_Hrader";
            this.lbl_Hrader.Size = new System.Drawing.Size(350, 54);
            this.lbl_Hrader.TabIndex = 3;
            this.lbl_Hrader.Text = "Search  Product";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Azure;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Price.Location = new System.Drawing.Point(88, 373);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(76, 31);
            this.lbl_Price.TabIndex = 4;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Expiry_Date
            // 
            this.lbl_Expiry_Date.AutoSize = true;
            this.lbl_Expiry_Date.BackColor = System.Drawing.Color.Azure;
            this.lbl_Expiry_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expiry_Date.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Expiry_Date.Location = new System.Drawing.Point(88, 291);
            this.lbl_Expiry_Date.Name = "lbl_Expiry_Date";
            this.lbl_Expiry_Date.Size = new System.Drawing.Size(154, 31);
            this.lbl_Expiry_Date.TabIndex = 5;
            this.lbl_Expiry_Date.Text = "Expiry Date";
            // 
            // lbl_Packing_Date
            // 
            this.lbl_Packing_Date.AutoSize = true;
            this.lbl_Packing_Date.BackColor = System.Drawing.Color.Azure;
            this.lbl_Packing_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Packing_Date.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Packing_Date.Location = new System.Drawing.Point(88, 226);
            this.lbl_Packing_Date.Name = "lbl_Packing_Date";
            this.lbl_Packing_Date.Size = new System.Drawing.Size(176, 31);
            this.lbl_Packing_Date.TabIndex = 6;
            this.lbl_Packing_Date.Text = "Packing Date";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Azure;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Product_Name.Location = new System.Drawing.Point(88, 155);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(187, 31);
            this.lbl_Product_Name.TabIndex = 7;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Product_Id
            // 
            this.lbl_Product_Id.AutoSize = true;
            this.lbl_Product_Id.BackColor = System.Drawing.Color.Azure;
            this.lbl_Product_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Id.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Product_Id.Location = new System.Drawing.Point(88, 83);
            this.lbl_Product_Id.Name = "lbl_Product_Id";
            this.lbl_Product_Id.Size = new System.Drawing.Size(138, 31);
            this.lbl_Product_Id.TabIndex = 8;
            this.lbl_Product_Id.Text = "Product Id";
            // 
            // dtp_Expiry_Date
            // 
            this.dtp_Expiry_Date.Enabled = false;
            this.dtp_Expiry_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Expiry_Date.Location = new System.Drawing.Point(405, 289);
            this.dtp_Expiry_Date.Name = "dtp_Expiry_Date";
            this.dtp_Expiry_Date.Size = new System.Drawing.Size(311, 35);
            this.dtp_Expiry_Date.TabIndex = 12;
            // 
            // dtp_Packing_Date
            // 
            this.dtp_Packing_Date.Enabled = false;
            this.dtp_Packing_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Packing_Date.Location = new System.Drawing.Point(405, 224);
            this.dtp_Packing_Date.Name = "dtp_Packing_Date";
            this.dtp_Packing_Date.Size = new System.Drawing.Size(311, 35);
            this.dtp_Packing_Date.TabIndex = 13;
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(405, 373);
            this.tb_Price.MaxLength = 5;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(311, 35);
            this.tb_Price.TabIndex = 9;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Enabled = false;
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(405, 155);
            this.tb_Product_Name.MaxLength = 20;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(311, 35);
            this.tb_Product_Name.TabIndex = 10;
            // 
            // tb_Product_Id
            // 
            this.tb_Product_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Id.Location = new System.Drawing.Point(405, 83);
            this.tb_Product_Id.MaxLength = 5;
            this.tb_Product_Id.Name = "tb_Product_Id";
            this.tb_Product_Id.Size = new System.Drawing.Size(311, 35);
            this.tb_Product_Id.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Beige;
            this.btn_Refresh.Location = new System.Drawing.Point(94, 464);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(94, 42);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Add_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Product.ForeColor = System.Drawing.Color.Beige;
            this.btn_Add_Product.Location = new System.Drawing.Point(238, 464);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(174, 42);
            this.btn_Add_Product.TabIndex = 4;
            this.btn_Add_Product.Text = "Add Product ";
            this.btn_Add_Product.UseVisualStyleBackColor = false;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // btn_Product_List
            // 
            this.btn_Product_List.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Product_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product_List.ForeColor = System.Drawing.Color.Beige;
            this.btn_Product_List.Location = new System.Drawing.Point(475, 464);
            this.btn_Product_List.Name = "btn_Product_List";
            this.btn_Product_List.Size = new System.Drawing.Size(148, 42);
            this.btn_Product_List.TabIndex = 5;
            this.btn_Product_List.Text = "Product List";
            this.btn_Product_List.UseVisualStyleBackColor = false;
            this.btn_Product_List.Click += new System.EventHandler(this.btn_Product_List_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Beige;
            this.btn_Close.Location = new System.Drawing.Point(679, 464);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(134, 42);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Azure;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(761, 9);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(118, 42);
            this.btn_Log_Out.TabIndex = 6;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Brown;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Search.Location = new System.Drawing.Point(722, 83);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(82, 35);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Search_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(891, 518);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Product_List);
            this.Controls.Add(this.btn_Add_Product);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dtp_Expiry_Date);
            this.Controls.Add(this.dtp_Packing_Date);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.tb_Product_Id);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Expiry_Date);
            this.Controls.Add(this.lbl_Packing_Date);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.lbl_Product_Id);
            this.Controls.Add(this.lbl_Hrader);
            this.Name = "frm_Search_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Hrader;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Expiry_Date;
        private System.Windows.Forms.Label lbl_Packing_Date;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Product_Id;
        private System.Windows.Forms.DateTimePicker dtp_Expiry_Date;
        private System.Windows.Forms.DateTimePicker dtp_Packing_Date;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_Id;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Add_Product;
        private System.Windows.Forms.Button btn_Product_List;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Search;
    }
}