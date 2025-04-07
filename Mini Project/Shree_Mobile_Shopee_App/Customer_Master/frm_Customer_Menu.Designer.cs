
namespace Shree_Mobile_Shopee_App
{
    partial class frm_Customer_Menu
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
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Add_New_Customer = new System.Windows.Forms.Button();
            this.btn_Search_Customer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Log_Out.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(734, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(140, 39);
            this.btn_Log_Out.TabIndex = 4;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Back.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Red;
            this.btn_Back.Location = new System.Drawing.Point(437, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(140, 39);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Add_New_Customer
            // 
            this.btn_Add_New_Customer.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Add_New_Customer.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Customer.ForeColor = System.Drawing.Color.Navy;
            this.btn_Add_New_Customer.Location = new System.Drawing.Point(472, 126);
            this.btn_Add_New_Customer.Name = "btn_Add_New_Customer";
            this.btn_Add_New_Customer.Size = new System.Drawing.Size(387, 65);
            this.btn_Add_New_Customer.TabIndex = 1;
            this.btn_Add_New_Customer.Text = "Add New Customer";
            this.btn_Add_New_Customer.UseVisualStyleBackColor = false;
            this.btn_Add_New_Customer.Click += new System.EventHandler(this.btn_Add_New_Customer_Click);
            // 
            // btn_Search_Customer
            // 
            this.btn_Search_Customer.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Search_Customer.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Customer.ForeColor = System.Drawing.Color.Navy;
            this.btn_Search_Customer.Location = new System.Drawing.Point(472, 290);
            this.btn_Search_Customer.Name = "btn_Search_Customer";
            this.btn_Search_Customer.Size = new System.Drawing.Size(387, 65);
            this.btn_Search_Customer.TabIndex = 2;
            this.btn_Search_Customer.Text = "Search Customer";
            this.btn_Search_Customer.UseVisualStyleBackColor = false;
            this.btn_Search_Customer.Click += new System.EventHandler(this.btn_Search_Customer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shree_Mobile_Shopee_App.Properties.Resources.Customer2;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Customer_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(886, 459);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Search_Customer);
            this.Controls.Add(this.btn_Add_New_Customer);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Log_Out);
            this.Name = "frm_Customer_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Add_New_Customer;
        private System.Windows.Forms.Button btn_Search_Customer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}