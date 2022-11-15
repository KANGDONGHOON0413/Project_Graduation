
namespace Project_Graduation
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.button1 = new System.Windows.Forms.Button();
            this.TXT_Name = new System.Windows.Forms.Label();
            this.TXT_Phone_Num = new System.Windows.Forms.Label();
            this.BTN_Sell = new System.Windows.Forms.Button();
            this.DGV_Sell_ing = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Order = new System.Windows.Forms.DataGridView();
            this.DGV_Order_Receive = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Order = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_Favorite = new System.Windows.Forms.Button();
            this.BTN_Order_Cancel = new System.Windows.Forms.Button();
            this.BTN_Receive_OK = new System.Windows.Forms.Button();
            this.BTN_Refuse = new System.Windows.Forms.Button();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sell_ing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order_Receive)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Option";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_Name
            // 
            this.TXT_Name.AutoSize = true;
            this.TXT_Name.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_Name.Location = new System.Drawing.Point(111, 44);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(112, 46);
            this.TXT_Name.TabIndex = 2;
            this.TXT_Name.Text = "Name";
            // 
            // TXT_Phone_Num
            // 
            this.TXT_Phone_Num.AutoSize = true;
            this.TXT_Phone_Num.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_Phone_Num.Location = new System.Drawing.Point(13, 97);
            this.TXT_Phone_Num.Name = "TXT_Phone_Num";
            this.TXT_Phone_Num.Size = new System.Drawing.Size(127, 25);
            this.TXT_Phone_Num.TabIndex = 3;
            this.TXT_Phone_Num.Text = "Phone Num: ";
            // 
            // BTN_Sell
            // 
            this.BTN_Sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_Sell.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Sell.Location = new System.Drawing.Point(979, 23);
            this.BTN_Sell.Name = "BTN_Sell";
            this.BTN_Sell.Size = new System.Drawing.Size(94, 87);
            this.BTN_Sell.TabIndex = 4;
            this.BTN_Sell.Text = "Sell";
            this.BTN_Sell.UseVisualStyleBackColor = false;
            this.BTN_Sell.Click += new System.EventHandler(this.BTN_Sell_Click);
            // 
            // DGV_Sell_ing
            // 
            this.DGV_Sell_ing.AllowUserToAddRows = false;
            this.DGV_Sell_ing.AllowUserToDeleteRows = false;
            this.DGV_Sell_ing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sell_ing.Location = new System.Drawing.Point(367, 243);
            this.DGV_Sell_ing.MultiSelect = false;
            this.DGV_Sell_ing.Name = "DGV_Sell_ing";
            this.DGV_Sell_ing.ReadOnly = true;
            this.DGV_Sell_ing.RowHeadersVisible = false;
            this.DGV_Sell_ing.RowHeadersWidth = 51;
            this.DGV_Sell_ing.RowTemplate.Height = 29;
            this.DGV_Sell_ing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Sell_ing.Size = new System.Drawing.Size(350, 303);
            this.DGV_Sell_ing.TabIndex = 5;
            this.DGV_Sell_ing.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Sell_ing_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Orders: ";
            // 
            // DGV_Order
            // 
            this.DGV_Order.AllowUserToAddRows = false;
            this.DGV_Order.AllowUserToDeleteRows = false;
            this.DGV_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Order.Location = new System.Drawing.Point(11, 243);
            this.DGV_Order.Name = "DGV_Order";
            this.DGV_Order.ReadOnly = true;
            this.DGV_Order.RowHeadersVisible = false;
            this.DGV_Order.RowHeadersWidth = 51;
            this.DGV_Order.RowTemplate.Height = 29;
            this.DGV_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Order.Size = new System.Drawing.Size(350, 267);
            this.DGV_Order.TabIndex = 9;
            // 
            // DGV_Order_Receive
            // 
            this.DGV_Order_Receive.AllowUserToAddRows = false;
            this.DGV_Order_Receive.AllowUserToDeleteRows = false;
            this.DGV_Order_Receive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Order_Receive.Location = new System.Drawing.Point(723, 243);
            this.DGV_Order_Receive.Name = "DGV_Order_Receive";
            this.DGV_Order_Receive.ReadOnly = true;
            this.DGV_Order_Receive.RowHeadersVisible = false;
            this.DGV_Order_Receive.RowHeadersWidth = 51;
            this.DGV_Order_Receive.RowTemplate.Height = 29;
            this.DGV_Order_Receive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Order_Receive.Size = new System.Drawing.Size(350, 267);
            this.DGV_Order_Receive.TabIndex = 10;
            this.DGV_Order_Receive.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Order_Receive_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(367, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "On Sell: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(723, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Order Receive: ";
            // 
            // BTN_Order
            // 
            this.BTN_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_Order.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Order.Location = new System.Drawing.Point(815, 23);
            this.BTN_Order.Name = "BTN_Order";
            this.BTN_Order.Size = new System.Drawing.Size(158, 87);
            this.BTN_Order.TabIndex = 13;
            this.BTN_Order.Text = "ORDER";
            this.BTN_Order.UseVisualStyleBackColor = false;
            this.BTN_Order.Click += new System.EventHandler(this.BTN_Order_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(915, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 87);
            this.button2.TabIndex = 14;
            this.button2.Text = "Receipt";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_Favorite
            // 
            this.BTN_Favorite.BackColor = System.Drawing.Color.MistyRose;
            this.BTN_Favorite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Favorite.BackgroundImage")));
            this.BTN_Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Favorite.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BTN_Favorite.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_Favorite.Location = new System.Drawing.Point(815, 116);
            this.BTN_Favorite.Name = "BTN_Favorite";
            this.BTN_Favorite.Size = new System.Drawing.Size(94, 87);
            this.BTN_Favorite.TabIndex = 15;
            this.BTN_Favorite.Text = "favorite";
            this.BTN_Favorite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Favorite.UseVisualStyleBackColor = false;
            this.BTN_Favorite.Click += new System.EventHandler(this.BTN_Favorite_Click);
            // 
            // BTN_Order_Cancel
            // 
            this.BTN_Order_Cancel.Location = new System.Drawing.Point(11, 516);
            this.BTN_Order_Cancel.Name = "BTN_Order_Cancel";
            this.BTN_Order_Cancel.Size = new System.Drawing.Size(350, 30);
            this.BTN_Order_Cancel.TabIndex = 16;
            this.BTN_Order_Cancel.Text = "Cancel Orders";
            this.BTN_Order_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Order_Cancel.Click += new System.EventHandler(this.BTN_Order_Cancel_Click);
            // 
            // BTN_Receive_OK
            // 
            this.BTN_Receive_OK.Location = new System.Drawing.Point(723, 516);
            this.BTN_Receive_OK.Name = "BTN_Receive_OK";
            this.BTN_Receive_OK.Size = new System.Drawing.Size(210, 30);
            this.BTN_Receive_OK.TabIndex = 17;
            this.BTN_Receive_OK.Text = "Commit Order";
            this.BTN_Receive_OK.UseVisualStyleBackColor = true;
            this.BTN_Receive_OK.Click += new System.EventHandler(this.BTN_Receive_OK_Click);
            // 
            // BTN_Refuse
            // 
            this.BTN_Refuse.Location = new System.Drawing.Point(939, 516);
            this.BTN_Refuse.Name = "BTN_Refuse";
            this.BTN_Refuse.Size = new System.Drawing.Size(134, 30);
            this.BTN_Refuse.TabIndex = 18;
            this.BTN_Refuse.Text = "Refuse an Order";
            this.BTN_Refuse.UseVisualStyleBackColor = true;
            this.BTN_Refuse.Click += new System.EventHandler(this.BTN_Refuse_Click);
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.BackColor = System.Drawing.Color.Snow;
            this.BTN_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Refresh.BackgroundImage")));
            this.BTN_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTN_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Refresh.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Refresh.Location = new System.Drawing.Point(723, 24);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(86, 179);
            this.BTN_Refresh.TabIndex = 19;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Refresh.UseVisualStyleBackColor = false;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 556);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.BTN_Refuse);
            this.Controls.Add(this.BTN_Receive_OK);
            this.Controls.Add(this.BTN_Order_Cancel);
            this.Controls.Add(this.BTN_Favorite);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN_Order);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_Order_Receive);
            this.Controls.Add(this.DGV_Order);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Sell_ing);
            this.Controls.Add(this.BTN_Sell);
            this.Controls.Add(this.TXT_Phone_Num);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.button1);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Shown += new System.EventHandler(this.Form_Main_Shown);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form_Main_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sell_ing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Order_Receive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TXT_Name;
        private System.Windows.Forms.Label TXT_Phone_Num;
        private System.Windows.Forms.Button BTN_Sell;
        private System.Windows.Forms.DataGridView DGV_Sell_ing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Order;
        private System.Windows.Forms.DataGridView DGV_Order_Receive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Order;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_Favorite;
        private System.Windows.Forms.Button BTN_Order_Cancel;
        private System.Windows.Forms.Button BTN_Receive_OK;
        private System.Windows.Forms.Button BTN_Refuse;
        private System.Windows.Forms.Button BTN_Refresh;
    }
}