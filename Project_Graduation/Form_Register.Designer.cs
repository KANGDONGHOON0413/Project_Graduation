
namespace Project_Graduation
{
    partial class Form_Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.INPUT_Id = new System.Windows.Forms.TextBox();
            this.INPUT_Pw = new System.Windows.Forms.TextBox();
            this.INPUT_Name = new System.Windows.Forms.TextBox();
            this.INPUT_Phone = new System.Windows.Forms.TextBox();
            this.BTN_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(246, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "계정 생성";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "pw";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "name";
            // 
            // INPUT_Id
            // 
            this.INPUT_Id.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.INPUT_Id.Location = new System.Drawing.Point(72, 23);
            this.INPUT_Id.Name = "INPUT_Id";
            this.INPUT_Id.Size = new System.Drawing.Size(165, 27);
            this.INPUT_Id.TabIndex = 5;
            this.INPUT_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.INPUT_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.INPUT_Id_KeyDown);
            // 
            // INPUT_Pw
            // 
            this.INPUT_Pw.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.INPUT_Pw.Location = new System.Drawing.Point(72, 59);
            this.INPUT_Pw.Name = "INPUT_Pw";
            this.INPUT_Pw.PasswordChar = '*';
            this.INPUT_Pw.Size = new System.Drawing.Size(165, 27);
            this.INPUT_Pw.TabIndex = 6;
            this.INPUT_Pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.INPUT_Pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.INPUT_Pw_KeyDown);
            // 
            // INPUT_Name
            // 
            this.INPUT_Name.Location = new System.Drawing.Point(72, 95);
            this.INPUT_Name.Name = "INPUT_Name";
            this.INPUT_Name.Size = new System.Drawing.Size(165, 27);
            this.INPUT_Name.TabIndex = 7;
            this.INPUT_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // INPUT_Phone
            // 
            this.INPUT_Phone.Location = new System.Drawing.Point(72, 129);
            this.INPUT_Phone.Name = "INPUT_Phone";
            this.INPUT_Phone.Size = new System.Drawing.Size(165, 27);
            this.INPUT_Phone.TabIndex = 8;
            this.INPUT_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_Register
            // 
            this.BTN_Register.BackColor = System.Drawing.SystemColors.Info;
            this.BTN_Register.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Register.Location = new System.Drawing.Point(246, 101);
            this.BTN_Register.Name = "BTN_Register";
            this.BTN_Register.Size = new System.Drawing.Size(165, 55);
            this.BTN_Register.TabIndex = 9;
            this.BTN_Register.Text = "Register";
            this.BTN_Register.UseVisualStyleBackColor = false;
            this.BTN_Register.Click += new System.EventHandler(this.BTN_Register_Click);
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(429, 178);
            this.Controls.Add(this.BTN_Register);
            this.Controls.Add(this.INPUT_Phone);
            this.Controls.Add(this.INPUT_Name);
            this.Controls.Add(this.INPUT_Pw);
            this.Controls.Add(this.INPUT_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox INPUT_Id;
        private System.Windows.Forms.TextBox INPUT_Pw;
        private System.Windows.Forms.TextBox INPUT_Name;
        private System.Windows.Forms.TextBox INPUT_Phone;
        private System.Windows.Forms.Button BTN_Register;
    }
}