
namespace Project_Graduation
{
    partial class Form_Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Option));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OUTPUT_Name = new System.Windows.Forms.TextBox();
            this.INPUT_Phone = new System.Windows.Forms.TextBox();
            this.INPUT_Address = new System.Windows.Forms.TextBox();
            this.INPUT_Pw = new System.Windows.Forms.TextBox();
            this.INPUT_Pw_Check = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.INPUT_Email = new System.Windows.Forms.TextBox();
            this.BTN_LogOut = new System.Windows.Forms.Button();
            this.Btn_Leave = new System.Windows.Forms.Button();
            this.BTN_Confirm = new System.Windows.Forms.Button();
            this.BTN_Check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password check";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // OUTPUT_Name
            // 
            this.OUTPUT_Name.Location = new System.Drawing.Point(347, 13);
            this.OUTPUT_Name.Name = "OUTPUT_Name";
            this.OUTPUT_Name.ReadOnly = true;
            this.OUTPUT_Name.Size = new System.Drawing.Size(125, 27);
            this.OUTPUT_Name.TabIndex = 1;
            this.OUTPUT_Name.TabStop = false;
            // 
            // INPUT_Phone
            // 
            this.INPUT_Phone.Location = new System.Drawing.Point(349, 112);
            this.INPUT_Phone.Name = "INPUT_Phone";
            this.INPUT_Phone.Size = new System.Drawing.Size(189, 27);
            this.INPUT_Phone.TabIndex = 4;
            // 
            // INPUT_Address
            // 
            this.INPUT_Address.Location = new System.Drawing.Point(349, 145);
            this.INPUT_Address.Name = "INPUT_Address";
            this.INPUT_Address.Size = new System.Drawing.Size(189, 27);
            this.INPUT_Address.TabIndex = 5;
            // 
            // INPUT_Pw
            // 
            this.INPUT_Pw.Location = new System.Drawing.Point(347, 46);
            this.INPUT_Pw.Name = "INPUT_Pw";
            this.INPUT_Pw.PasswordChar = '*';
            this.INPUT_Pw.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Pw.TabIndex = 2;
            // 
            // INPUT_Pw_Check
            // 
            this.INPUT_Pw_Check.Location = new System.Drawing.Point(347, 79);
            this.INPUT_Pw_Check.Name = "INPUT_Pw_Check";
            this.INPUT_Pw_Check.PasswordChar = '*';
            this.INPUT_Pw_Check.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Pw_Check.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "E-Mail";
            // 
            // INPUT_Email
            // 
            this.INPUT_Email.Location = new System.Drawing.Point(347, 178);
            this.INPUT_Email.Name = "INPUT_Email";
            this.INPUT_Email.Size = new System.Drawing.Size(191, 27);
            this.INPUT_Email.TabIndex = 6;
            // 
            // BTN_LogOut
            // 
            this.BTN_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_LogOut.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_LogOut.Location = new System.Drawing.Point(13, 220);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(94, 55);
            this.BTN_LogOut.TabIndex = 14;
            this.BTN_LogOut.Text = "Log Out";
            this.BTN_LogOut.UseVisualStyleBackColor = false;
            this.BTN_LogOut.Click += new System.EventHandler(this.BTN_LogOut_Click);
            // 
            // Btn_Leave
            // 
            this.Btn_Leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Leave.Font = new System.Drawing.Font("맑은 고딕", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Btn_Leave.Location = new System.Drawing.Point(119, 218);
            this.Btn_Leave.Name = "Btn_Leave";
            this.Btn_Leave.Size = new System.Drawing.Size(94, 57);
            this.Btn_Leave.TabIndex = 15;
            this.Btn_Leave.Text = "Leave Account";
            this.Btn_Leave.UseVisualStyleBackColor = false;
            this.Btn_Leave.Click += new System.EventHandler(this.Btn_Leave_Click);
            // 
            // BTN_Confirm
            // 
            this.BTN_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_Confirm.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Confirm.Location = new System.Drawing.Point(347, 215);
            this.BTN_Confirm.Name = "BTN_Confirm";
            this.BTN_Confirm.Size = new System.Drawing.Size(191, 57);
            this.BTN_Confirm.TabIndex = 16;
            this.BTN_Confirm.Text = "Change confirm";
            this.BTN_Confirm.UseVisualStyleBackColor = false;
            this.BTN_Confirm.Click += new System.EventHandler(this.BTN_Confirm_Click);
            // 
            // BTN_Check
            // 
            this.BTN_Check.Location = new System.Drawing.Point(478, 44);
            this.BTN_Check.Name = "BTN_Check";
            this.BTN_Check.Size = new System.Drawing.Size(60, 62);
            this.BTN_Check.TabIndex = 17;
            this.BTN_Check.Text = "check";
            this.BTN_Check.UseVisualStyleBackColor = true;
            this.BTN_Check.Click += new System.EventHandler(this.BTN_Check_Click);
            // 
            // Form_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 283);
            this.Controls.Add(this.BTN_Check);
            this.Controls.Add(this.BTN_Confirm);
            this.Controls.Add(this.Btn_Leave);
            this.Controls.Add(this.BTN_LogOut);
            this.Controls.Add(this.INPUT_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.INPUT_Pw_Check);
            this.Controls.Add(this.INPUT_Pw);
            this.Controls.Add(this.INPUT_Address);
            this.Controls.Add(this.INPUT_Phone);
            this.Controls.Add(this.OUTPUT_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Option";
            this.Load += new System.EventHandler(this.Form_Option_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OUTPUT_Name;
        private System.Windows.Forms.TextBox INPUT_Phone;
        private System.Windows.Forms.TextBox INPUT_Address;
        private System.Windows.Forms.TextBox INPUT_Pw;
        private System.Windows.Forms.TextBox INPUT_Pw_Check;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox INPUT_Email;
        private System.Windows.Forms.Button BTN_LogOut;
        private System.Windows.Forms.Button Btn_Leave;
        private System.Windows.Forms.Button BTN_Confirm;
        private System.Windows.Forms.Button BTN_Check;
    }
}