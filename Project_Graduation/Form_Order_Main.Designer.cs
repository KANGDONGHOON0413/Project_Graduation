
namespace Project_Graduation
{
    partial class Form_Order_Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Buy = new System.Windows.Forms.Button();
            this.BTN_Favorite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OUTPUT_Item_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OUTPUT_Seller_ID = new System.Windows.Forms.TextBox();
            this.OUTPUT_Stock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OUTPUT_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OUTPUT_Description = new System.Windows.Forms.TextBox();
            this.INPUT_Search = new System.Windows.Forms.TextBox();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.INPUT_User_Name = new System.Windows.Forms.TextBox();
            this.INPUT_Address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.INPUT_Phone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.INPUT_Quantity = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.OUTPUT_fee = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.OUTPUT_TOT_Cost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.INPUT_Filter1 = new System.Windows.Forms.ComboBox();
            this.INPUT_Scope_Min = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.INPUT_Scope_Max = new System.Windows.Forms.TextBox();
            this.INPUT_Search_Option = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BTN_Del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(623, 409);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(641, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Buy
            // 
            this.BTN_Buy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_Buy.Font = new System.Drawing.Font("맑은 고딕", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Buy.Location = new System.Drawing.Point(924, 386);
            this.BTN_Buy.Name = "BTN_Buy";
            this.BTN_Buy.Size = new System.Drawing.Size(224, 109);
            this.BTN_Buy.TabIndex = 31;
            this.BTN_Buy.Text = "BUY";
            this.BTN_Buy.UseVisualStyleBackColor = false;
            this.BTN_Buy.Click += new System.EventHandler(this.BTN_Buy_Click);
            // 
            // BTN_Favorite
            // 
            this.BTN_Favorite.BackColor = System.Drawing.SystemColors.Info;
            this.BTN_Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Favorite.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Favorite.Location = new System.Drawing.Point(924, 256);
            this.BTN_Favorite.Name = "BTN_Favorite";
            this.BTN_Favorite.Size = new System.Drawing.Size(224, 126);
            this.BTN_Favorite.TabIndex = 30;
            this.BTN_Favorite.Text = "ADD TO FAVORITE";
            this.BTN_Favorite.UseVisualStyleBackColor = false;
            this.BTN_Favorite.Click += new System.EventHandler(this.BTN_Favorite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Name";
            // 
            // OUTPUT_Item_Name
            // 
            this.OUTPUT_Item_Name.Location = new System.Drawing.Point(936, 49);
            this.OUTPUT_Item_Name.Name = "OUTPUT_Item_Name";
            this.OUTPUT_Item_Name.ReadOnly = true;
            this.OUTPUT_Item_Name.Size = new System.Drawing.Size(211, 27);
            this.OUTPUT_Item_Name.TabIndex = 5;
            this.OUTPUT_Item_Name.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seller ID";
            // 
            // OUTPUT_Seller_ID
            // 
            this.OUTPUT_Seller_ID.Location = new System.Drawing.Point(921, 115);
            this.OUTPUT_Seller_ID.Name = "OUTPUT_Seller_ID";
            this.OUTPUT_Seller_ID.ReadOnly = true;
            this.OUTPUT_Seller_ID.Size = new System.Drawing.Size(226, 27);
            this.OUTPUT_Seller_ID.TabIndex = 7;
            this.OUTPUT_Seller_ID.TabStop = false;
            // 
            // OUTPUT_Stock
            // 
            this.OUTPUT_Stock.Location = new System.Drawing.Point(1065, 83);
            this.OUTPUT_Stock.Name = "OUTPUT_Stock";
            this.OUTPUT_Stock.ReadOnly = true;
            this.OUTPUT_Stock.Size = new System.Drawing.Size(82, 27);
            this.OUTPUT_Stock.TabIndex = 11;
            this.OUTPUT_Stock.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1013, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stock";
            // 
            // OUTPUT_Price
            // 
            this.OUTPUT_Price.Location = new System.Drawing.Point(896, 82);
            this.OUTPUT_Price.Name = "OUTPUT_Price";
            this.OUTPUT_Price.ReadOnly = true;
            this.OUTPUT_Price.Size = new System.Drawing.Size(113, 27);
            this.OUTPUT_Price.TabIndex = 9;
            this.OUTPUT_Price.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(848, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(849, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description";
            // 
            // OUTPUT_Description
            // 
            this.OUTPUT_Description.Location = new System.Drawing.Point(849, 168);
            this.OUTPUT_Description.Multiline = true;
            this.OUTPUT_Description.Name = "OUTPUT_Description";
            this.OUTPUT_Description.ReadOnly = true;
            this.OUTPUT_Description.Size = new System.Drawing.Size(298, 81);
            this.OUTPUT_Description.TabIndex = 13;
            this.OUTPUT_Description.TabStop = false;
            // 
            // INPUT_Search
            // 
            this.INPUT_Search.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INPUT_Search.Location = new System.Drawing.Point(147, 11);
            this.INPUT_Search.Name = "INPUT_Search";
            this.INPUT_Search.Size = new System.Drawing.Size(404, 34);
            this.INPUT_Search.TabIndex = 15;
            this.INPUT_Search.TabStop = false;
            // 
            // BTN_Search
            // 
            this.BTN_Search.Location = new System.Drawing.Point(557, 11);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(78, 34);
            this.BTN_Search.TabIndex = 16;
            this.BTN_Search.Text = "Search";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Recipient";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(651, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Address";
            // 
            // INPUT_User_Name
            // 
            this.INPUT_User_Name.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INPUT_User_Name.Location = new System.Drawing.Point(746, 289);
            this.INPUT_User_Name.Name = "INPUT_User_Name";
            this.INPUT_User_Name.Size = new System.Drawing.Size(169, 27);
            this.INPUT_User_Name.TabIndex = 20;
            this.INPUT_User_Name.TabStop = false;
            this.INPUT_User_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // INPUT_Address
            // 
            this.INPUT_Address.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INPUT_Address.Location = new System.Drawing.Point(746, 322);
            this.INPUT_Address.Name = "INPUT_Address";
            this.INPUT_Address.Size = new System.Drawing.Size(169, 27);
            this.INPUT_Address.TabIndex = 21;
            this.INPUT_Address.TabStop = false;
            this.INPUT_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(651, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Phone";
            // 
            // INPUT_Phone
            // 
            this.INPUT_Phone.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INPUT_Phone.Location = new System.Drawing.Point(746, 355);
            this.INPUT_Phone.Name = "INPUT_Phone";
            this.INPUT_Phone.Size = new System.Drawing.Size(169, 27);
            this.INPUT_Phone.TabIndex = 23;
            this.INPUT_Phone.TabStop = false;
            this.INPUT_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(651, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Quantity";
            // 
            // INPUT_Quantity
            // 
            this.INPUT_Quantity.FormattingEnabled = true;
            this.INPUT_Quantity.Location = new System.Drawing.Point(746, 386);
            this.INPUT_Quantity.Name = "INPUT_Quantity";
            this.INPUT_Quantity.Size = new System.Drawing.Size(89, 28);
            this.INPUT_Quantity.TabIndex = 25;
            this.INPUT_Quantity.Text = "0";
            this.INPUT_Quantity.TextChanged += new System.EventHandler(this.INPUT_Quantity_TextChanged);
            this.INPUT_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.INPUT_Quantity_KeyPress);
            this.INPUT_Quantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.INPUT_Quantity_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(650, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Delivery fee";
            // 
            // OUTPUT_fee
            // 
            this.OUTPUT_fee.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OUTPUT_fee.Location = new System.Drawing.Point(745, 437);
            this.OUTPUT_fee.Name = "OUTPUT_fee";
            this.OUTPUT_fee.ReadOnly = true;
            this.OUTPUT_fee.Size = new System.Drawing.Size(89, 27);
            this.OUTPUT_fee.TabIndex = 27;
            this.OUTPUT_fee.TabStop = false;
            this.OUTPUT_fee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(651, 471);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Total Costs";
            // 
            // OUTPUT_TOT_Cost
            // 
            this.OUTPUT_TOT_Cost.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OUTPUT_TOT_Cost.Location = new System.Drawing.Point(746, 468);
            this.OUTPUT_TOT_Cost.Name = "OUTPUT_TOT_Cost";
            this.OUTPUT_TOT_Cost.ReadOnly = true;
            this.OUTPUT_TOT_Cost.Size = new System.Drawing.Size(169, 27);
            this.OUTPUT_TOT_Cost.TabIndex = 29;
            this.OUTPUT_TOT_Cost.TabStop = false;
            this.OUTPUT_TOT_Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(641, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 31);
            this.button1.TabIndex = 30;
            this.button1.Text = "Set Default Option";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(642, 417);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(281, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Free shipping for Total price over 25000";
            // 
            // INPUT_Filter1
            // 
            this.INPUT_Filter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.INPUT_Filter1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INPUT_Filter1.FormattingEnabled = true;
            this.INPUT_Filter1.Items.AddRange(new object[] {
            "최신 순",
            "오래된 순",
            "가격 낮은 순",
            "가격 높은 순"});
            this.INPUT_Filter1.Location = new System.Drawing.Point(84, 51);
            this.INPUT_Filter1.Name = "INPUT_Filter1";
            this.INPUT_Filter1.Size = new System.Drawing.Size(129, 28);
            this.INPUT_Filter1.TabIndex = 33;
            this.INPUT_Filter1.TabStop = false;
            // 
            // INPUT_Scope_Min
            // 
            this.INPUT_Scope_Min.Location = new System.Drawing.Point(320, 51);
            this.INPUT_Scope_Min.Name = "INPUT_Scope_Min";
            this.INPUT_Scope_Min.Size = new System.Drawing.Size(103, 27);
            this.INPUT_Scope_Min.TabIndex = 34;
            this.INPUT_Scope_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.INPUT_Scope_Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.INPUT_Scope_Min_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Price Range";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(429, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "~";
            // 
            // INPUT_Scope_Max
            // 
            this.INPUT_Scope_Max.Location = new System.Drawing.Point(455, 52);
            this.INPUT_Scope_Max.Name = "INPUT_Scope_Max";
            this.INPUT_Scope_Max.Size = new System.Drawing.Size(130, 27);
            this.INPUT_Scope_Max.TabIndex = 37;
            this.INPUT_Scope_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.INPUT_Scope_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.INPUT_Scope_Max_KeyPress);
            // 
            // INPUT_Search_Option
            // 
            this.INPUT_Search_Option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.INPUT_Search_Option.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INPUT_Search_Option.FormattingEnabled = true;
            this.INPUT_Search_Option.Items.AddRange(new object[] {
            "Item Name",
            "Seller ID"});
            this.INPUT_Search_Option.Location = new System.Drawing.Point(12, 13);
            this.INPUT_Search_Option.Name = "INPUT_Search_Option";
            this.INPUT_Search_Option.Size = new System.Drawing.Size(129, 33);
            this.INPUT_Search_Option.TabIndex = 38;
            this.INPUT_Search_Option.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 20);
            this.label16.TabIndex = 39;
            this.label16.Text = "Sort  By:";
            // 
            // BTN_Del
            // 
            this.BTN_Del.Location = new System.Drawing.Point(592, 51);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(43, 29);
            this.BTN_Del.TabIndex = 40;
            this.BTN_Del.Text = "Del";
            this.BTN_Del.UseVisualStyleBackColor = true;
            this.BTN_Del.Click += new System.EventHandler(this.BTN_Del_Click);
            // 
            // Form_Order_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 506);
            this.Controls.Add(this.BTN_Del);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.INPUT_Search_Option);
            this.Controls.Add(this.INPUT_Scope_Max);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.INPUT_Scope_Min);
            this.Controls.Add(this.INPUT_Filter1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OUTPUT_TOT_Cost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.OUTPUT_fee);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.INPUT_Quantity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.INPUT_Phone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.INPUT_Address);
            this.Controls.Add(this.INPUT_User_Name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.INPUT_Search);
            this.Controls.Add(this.OUTPUT_Description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OUTPUT_Stock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OUTPUT_Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OUTPUT_Seller_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OUTPUT_Item_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Favorite);
            this.Controls.Add(this.BTN_Buy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Order_Main";
            this.Text = "Form_Order_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Order_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Order_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Buy;
        private System.Windows.Forms.Button BTN_Favorite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OUTPUT_Item_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OUTPUT_Seller_ID;
        private System.Windows.Forms.TextBox OUTPUT_Stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OUTPUT_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OUTPUT_Description;
        private System.Windows.Forms.TextBox INPUT_Search;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox INPUT_User_Name;
        private System.Windows.Forms.TextBox INPUT_Address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox INPUT_Phone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox INPUT_Quantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox OUTPUT_fee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox OUTPUT_TOT_Cost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox INPUT_Filter1;
        private System.Windows.Forms.TextBox INPUT_Scope_Min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox INPUT_Scope_Max;
        private System.Windows.Forms.ComboBox INPUT_Search_Option;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BTN_Del;
    }
}