
namespace Shree_Mobile_Shopee_App
{
    partial class frm_Main_Mainu
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Mobile = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.pb_Customer = new System.Windows.Forms.PictureBox();
            this.pb_Mobile = new System.Windows.Forms.PictureBox();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mobile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnl_Header.Controls.Add(this.btn_Log_Out);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(886, 115);
            this.pnl_Header.TabIndex = 12;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Log_Out.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(745, 0);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(140, 39);
            this.btn_Log_Out.TabIndex = 3;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Header.Location = new System.Drawing.Point(150, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(565, 85);
            this.lbl_Header.TabIndex = 11;
            this.lbl_Header.Text = "Shree Mobile Shopee";
            // 
            // btn_Mobile
            // 
            this.btn_Mobile.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Mobile.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mobile.ForeColor = System.Drawing.Color.Navy;
            this.btn_Mobile.Location = new System.Drawing.Point(122, 452);
            this.btn_Mobile.Name = "btn_Mobile";
            this.btn_Mobile.Size = new System.Drawing.Size(174, 39);
            this.btn_Mobile.TabIndex = 1;
            this.btn_Mobile.Text = "Mobiles";
            this.btn_Mobile.UseVisualStyleBackColor = false;
            this.btn_Mobile.Click += new System.EventHandler(this.btn_Mobile_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Customer.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.Navy;
            this.btn_Customer.Location = new System.Drawing.Point(572, 452);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(174, 39);
            this.btn_Customer.TabIndex = 2;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // pb_Customer
            // 
            this.pb_Customer.Image = global::Shree_Mobile_Shopee_App.Properties.Resources.Customer1;
            this.pb_Customer.Location = new System.Drawing.Point(441, 110);
            this.pb_Customer.Name = "pb_Customer";
            this.pb_Customer.Size = new System.Drawing.Size(443, 332);
            this.pb_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Customer.TabIndex = 7;
            this.pb_Customer.TabStop = false;
            // 
            // pb_Mobile
            // 
            this.pb_Mobile.Image = global::Shree_Mobile_Shopee_App.Properties.Resources.MOBILE1;
            this.pb_Mobile.Location = new System.Drawing.Point(0, 110);
            this.pb_Mobile.Name = "pb_Mobile";
            this.pb_Mobile.Size = new System.Drawing.Size(445, 332);
            this.pb_Mobile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Mobile.TabIndex = 6;
            this.pb_Mobile.TabStop = false;
            // 
            // frm_Main_Mainu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(886, 505);
            this.ControlBox = false;
            this.Controls.Add(this.pb_Customer);
            this.Controls.Add(this.pb_Mobile);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.btn_Mobile);
            this.Controls.Add(this.pnl_Header);
            this.Name = "frm_Main_Mainu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Mainu";
            this.Load += new System.EventHandler(this.frm_Main_Mainu_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mobile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Mobile;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.PictureBox pb_Mobile;
        private System.Windows.Forms.PictureBox pb_Customer;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}