
namespace Cloth_Stock_Mgt_App
{
    partial class frm_Cloth_Stock_
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
            this.lbl_Cloth_Type = new System.Windows.Forms.Label();
            this.lbl_Cloth_Name = new System.Windows.Forms.Label();
            this.lbl_Cloth_Brand = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmb_Cloth_Type = new System.Windows.Forms.ComboBox();
            this.cmb_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Brand = new System.Windows.Forms.ComboBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Current_Stock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Header.Location = new System.Drawing.Point(208, 18);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(303, 63);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Cloth Stock";
            // 
            // lbl_Cloth_Type
            // 
            this.lbl_Cloth_Type.AutoSize = true;
            this.lbl_Cloth_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cloth_Type.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Cloth_Type.Location = new System.Drawing.Point(57, 118);
            this.lbl_Cloth_Type.Name = "lbl_Cloth_Type";
            this.lbl_Cloth_Type.Size = new System.Drawing.Size(146, 31);
            this.lbl_Cloth_Type.TabIndex = 1;
            this.lbl_Cloth_Type.Text = "Cloth Type";
            // 
            // lbl_Cloth_Name
            // 
            this.lbl_Cloth_Name.AutoSize = true;
            this.lbl_Cloth_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cloth_Name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Cloth_Name.Location = new System.Drawing.Point(57, 208);
            this.lbl_Cloth_Name.Name = "lbl_Cloth_Name";
            this.lbl_Cloth_Name.Size = new System.Drawing.Size(86, 31);
            this.lbl_Cloth_Name.TabIndex = 1;
            this.lbl_Cloth_Name.Text = "Name";
            // 
            // lbl_Cloth_Brand
            // 
            this.lbl_Cloth_Brand.AutoSize = true;
            this.lbl_Cloth_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cloth_Brand.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Cloth_Brand.Location = new System.Drawing.Point(57, 300);
            this.lbl_Cloth_Brand.Name = "lbl_Cloth_Brand";
            this.lbl_Cloth_Brand.Size = new System.Drawing.Size(86, 31);
            this.lbl_Cloth_Brand.TabIndex = 1;
            this.lbl_Cloth_Brand.Text = "Brand";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Quantity.Location = new System.Drawing.Point(57, 390);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(116, 31);
            this.lbl_Quantity.TabIndex = 1;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Price.Location = new System.Drawing.Point(437, 390);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(76, 31);
            this.lbl_Price.TabIndex = 1;
            this.lbl_Price.Text = "Price";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Add.Location = new System.Drawing.Point(318, 457);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(105, 47);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // cmb_Cloth_Type
            // 
            this.cmb_Cloth_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cloth_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cloth_Type.FormattingEnabled = true;
            this.cmb_Cloth_Type.Items.AddRange(new object[] {
            "a",
            "b"});
            this.cmb_Cloth_Type.Location = new System.Drawing.Point(367, 118);
            this.cmb_Cloth_Type.Name = "cmb_Cloth_Type";
            this.cmb_Cloth_Type.Size = new System.Drawing.Size(320, 37);
            this.cmb_Cloth_Type.TabIndex = 3;
            // 
            // cmb_Name
            // 
            this.cmb_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Name.FormattingEnabled = true;
            this.cmb_Name.Location = new System.Drawing.Point(367, 208);
            this.cmb_Name.Name = "cmb_Name";
            this.cmb_Name.Size = new System.Drawing.Size(320, 37);
            this.cmb_Name.TabIndex = 3;
            // 
            // cmb_Brand
            // 
            this.cmb_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Brand.FormattingEnabled = true;
            this.cmb_Brand.Location = new System.Drawing.Point(367, 300);
            this.cmb_Brand.Name = "cmb_Brand";
            this.cmb_Brand.Size = new System.Drawing.Size(320, 37);
            this.cmb_Brand.TabIndex = 3;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(179, 390);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(168, 35);
            this.tb_Quantity.TabIndex = 4;
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(519, 390);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(168, 35);
            this.tb_Price.TabIndex = 4;
            // 
            // lbl_Current_Stock
            // 
            this.lbl_Current_Stock.AutoSize = true;
            this.lbl_Current_Stock.BackColor = System.Drawing.Color.Khaki;
            this.lbl_Current_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Stock.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_Current_Stock.Location = new System.Drawing.Point(362, 396);
            this.lbl_Current_Stock.Name = "lbl_Current_Stock";
            this.lbl_Current_Stock.Size = new System.Drawing.Size(41, 25);
            this.lbl_Current_Stock.TabIndex = 1;
            this.lbl_Current_Stock.Text = "CS";
            // 
            // frm_Cloth_Stock_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 513);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_Quantity);
            this.Controls.Add(this.cmb_Brand);
            this.Controls.Add(this.cmb_Name);
            this.Controls.Add(this.cmb_Cloth_Type);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Cloth_Brand);
            this.Controls.Add(this.lbl_Cloth_Name);
            this.Controls.Add(this.lbl_Current_Stock);
            this.Controls.Add(this.lbl_Cloth_Type);
            this.Controls.Add(this.lbl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Cloth_Stock_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloth Stock";
            this.Load += new System.EventHandler(this.frm_Cloth_Stock__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Cloth_Type;
        private System.Windows.Forms.Label lbl_Cloth_Name;
        private System.Windows.Forms.Label lbl_Cloth_Brand;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmb_Cloth_Type;
        private System.Windows.Forms.ComboBox cmb_Name;
        private System.Windows.Forms.ComboBox cmb_Brand;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Current_Stock;
    }
}

