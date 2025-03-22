
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
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Sub_Category = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmb_Sub_Category = new System.Windows.Forms.ComboBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
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
            this.lbl_Header.Size = new System.Drawing.Size(362, 63);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Product Stock";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Category.Location = new System.Drawing.Point(57, 118);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(125, 31);
            this.lbl_Category.TabIndex = 1;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Sub_Category
            // 
            this.lbl_Sub_Category.AutoSize = true;
            this.lbl_Sub_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sub_Category.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Sub_Category.Location = new System.Drawing.Point(57, 208);
            this.lbl_Sub_Category.Name = "lbl_Sub_Category";
            this.lbl_Sub_Category.Size = new System.Drawing.Size(182, 31);
            this.lbl_Sub_Category.TabIndex = 1;
            this.lbl_Sub_Category.Text = "Sub-Category";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Product_Name.Location = new System.Drawing.Point(57, 300);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(187, 31);
            this.lbl_Product_Name.TabIndex = 1;
            this.lbl_Product_Name.Text = "Product Name";
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
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Items.AddRange(new object[] {
            "a",
            "b"});
            this.cmb_Category.Location = new System.Drawing.Point(367, 118);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(320, 37);
            this.cmb_Category.TabIndex = 3;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // cmb_Sub_Category
            // 
            this.cmb_Sub_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sub_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sub_Category.FormattingEnabled = true;
            this.cmb_Sub_Category.Location = new System.Drawing.Point(367, 208);
            this.cmb_Sub_Category.Name = "cmb_Sub_Category";
            this.cmb_Sub_Category.Size = new System.Drawing.Size(320, 37);
            this.cmb_Sub_Category.TabIndex = 3;
            this.cmb_Sub_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Sub_Category_SelectedIndexChanged);
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(367, 300);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(320, 37);
            this.cmb_Product_Name.TabIndex = 3;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
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
            this.lbl_Current_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Stock.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_Current_Stock.Location = new System.Drawing.Point(198, 393);
            this.lbl_Current_Stock.Name = "lbl_Current_Stock";
            this.lbl_Current_Stock.Size = new System.Drawing.Size(46, 29);
            this.lbl_Current_Stock.TabIndex = 1;
            this.lbl_Current_Stock.Text = "CS";
            // 
            // frm_Cloth_Stock_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 480);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.cmb_Product_Name);
            this.Controls.Add(this.cmb_Sub_Category);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.lbl_Sub_Category);
            this.Controls.Add(this.lbl_Current_Stock);
            this.Controls.Add(this.lbl_Category);
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
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Sub_Category;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_Sub_Category;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Current_Stock;
    }
}

