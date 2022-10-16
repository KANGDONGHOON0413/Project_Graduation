
namespace Project_Graduation
{
    partial class Form_Sell
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.INPUT_Item_Name = new System.Windows.Forms.TextBox();
            this.INPUT_Item_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.INPUT_Item_Stock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Sell = new System.Windows.Forms.Button();
            this.INPUT_Description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            // 
            // INPUT_Item_Name
            // 
            this.INPUT_Item_Name.Location = new System.Drawing.Point(375, 11);
            this.INPUT_Item_Name.Name = "INPUT_Item_Name";
            this.INPUT_Item_Name.Size = new System.Drawing.Size(137, 27);
            this.INPUT_Item_Name.TabIndex = 2;
            // 
            // INPUT_Item_Price
            // 
            this.INPUT_Item_Price.Location = new System.Drawing.Point(375, 44);
            this.INPUT_Item_Price.Name = "INPUT_Item_Price";
            this.INPUT_Item_Price.Size = new System.Drawing.Size(137, 27);
            this.INPUT_Item_Price.TabIndex = 4;
            this.INPUT_Item_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.INPUT_Item_Price_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Price";
            // 
            // INPUT_Item_Stock
            // 
            this.INPUT_Item_Stock.Location = new System.Drawing.Point(375, 77);
            this.INPUT_Item_Stock.Name = "INPUT_Item_Stock";
            this.INPUT_Item_Stock.Size = new System.Drawing.Size(137, 27);
            this.INPUT_Item_Stock.TabIndex = 6;
            this.INPUT_Item_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.INPUT_Item_Stock_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item stock";
            // 
            // BTN_Sell
            // 
            this.BTN_Sell.Font = new System.Drawing.Font("Vladimir Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.BTN_Sell.Location = new System.Drawing.Point(285, 220);
            this.BTN_Sell.Name = "BTN_Sell";
            this.BTN_Sell.Size = new System.Drawing.Size(227, 53);
            this.BTN_Sell.TabIndex = 8;
            this.BTN_Sell.Text = "Sell";
            this.BTN_Sell.UseVisualStyleBackColor = true;
            this.BTN_Sell.Click += new System.EventHandler(this.BTN_Sell_Click);
            // 
            // INPUT_Description
            // 
            this.INPUT_Description.Location = new System.Drawing.Point(285, 138);
            this.INPUT_Description.Multiline = true;
            this.INPUT_Description.Name = "INPUT_Description";
            this.INPUT_Description.Size = new System.Drawing.Size(227, 76);
            this.INPUT_Description.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Description";
            // 
            // BTN_Update
            // 
            this.BTN_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTN_Update.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Update.Location = new System.Drawing.Point(398, 220);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(114, 53);
            this.BTN_Update.TabIndex = 11;
            this.BTN_Update.TabStop = false;
            this.BTN_Update.Text = "UPDATE";
            this.BTN_Update.UseVisualStyleBackColor = false;
            this.BTN_Update.Visible = false;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_Delete.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Delete.Location = new System.Drawing.Point(285, 221);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(107, 51);
            this.BTN_Delete.TabIndex = 12;
            this.BTN_Delete.TabStop = false;
            this.BTN_Delete.Text = "DELETE";
            this.BTN_Delete.UseVisualStyleBackColor = false;
            this.BTN_Delete.Visible = false;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // Form_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 285);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.INPUT_Description);
            this.Controls.Add(this.BTN_Sell);
            this.Controls.Add(this.INPUT_Item_Stock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.INPUT_Item_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.INPUT_Item_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Sell";
            this.Text = "Form_Sell";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox INPUT_Item_Name;
        private System.Windows.Forms.TextBox INPUT_Item_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox INPUT_Item_Stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Sell;
        private System.Windows.Forms.TextBox INPUT_Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Button BTN_Delete;
    }
}