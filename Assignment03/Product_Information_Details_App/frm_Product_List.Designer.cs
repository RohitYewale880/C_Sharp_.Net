
namespace Product_Information_Details_App
{
    partial class frm_Product_List
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
            this.dgv_Product_List = new System.Windows.Forms.DataGridView();
            this.btn_Product_Search = new System.Windows.Forms.Button();
            this.btn_Add_Product = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Hrader
            // 
            this.lbl_Hrader.AutoSize = true;
            this.lbl_Hrader.BackColor = System.Drawing.Color.Azure;
            this.lbl_Hrader.Font = new System.Drawing.Font("Georgia", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hrader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Hrader.Location = new System.Drawing.Point(291, 9);
            this.lbl_Hrader.Name = "lbl_Hrader";
            this.lbl_Hrader.Size = new System.Drawing.Size(272, 54);
            this.lbl_Hrader.TabIndex = 2;
            this.lbl_Hrader.Text = " Product list";
            // 
            // dgv_Product_List
            // 
            this.dgv_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_List.Location = new System.Drawing.Point(12, 75);
            this.dgv_Product_List.Name = "dgv_Product_List";
            this.dgv_Product_List.Size = new System.Drawing.Size(867, 383);
            this.dgv_Product_List.TabIndex = 1;
            // 
            // btn_Product_Search
            // 
            this.btn_Product_Search.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Product_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product_Search.ForeColor = System.Drawing.Color.Beige;
            this.btn_Product_Search.Location = new System.Drawing.Point(105, 464);
            this.btn_Product_Search.Name = "btn_Product_Search";
            this.btn_Product_Search.Size = new System.Drawing.Size(174, 42);
            this.btn_Product_Search.TabIndex = 3;
            this.btn_Product_Search.Text = "Product Search";
            this.btn_Product_Search.UseVisualStyleBackColor = false;
            this.btn_Product_Search.Click += new System.EventHandler(this.btn_Product_Search_Click);
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Add_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Product.ForeColor = System.Drawing.Color.Beige;
            this.btn_Add_Product.Location = new System.Drawing.Point(352, 464);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(174, 42);
            this.btn_Add_Product.TabIndex = 2;
            this.btn_Add_Product.Text = "Add Product ";
            this.btn_Add_Product.UseVisualStyleBackColor = false;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Beige;
            this.btn_Close.Location = new System.Drawing.Point(598, 464);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(134, 42);
            this.btn_Close.TabIndex = 5;
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
            this.btn_Log_Out.TabIndex = 7;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.button_Click);
            // 
            // frm_Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(891, 518);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Add_Product);
            this.Controls.Add(this.btn_Product_Search);
            this.Controls.Add(this.dgv_Product_List);
            this.Controls.Add(this.lbl_Hrader);
            this.Name = "frm_Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.frm_Product_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Hrader;
        private System.Windows.Forms.DataGridView dgv_Product_List;
        private System.Windows.Forms.Button btn_Product_Search;
        private System.Windows.Forms.Button btn_Add_Product;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}