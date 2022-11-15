
namespace Project_Graduation
{
    partial class Form_Login
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
            this.INPUT_ID = new System.Windows.Forms.TextBox();
            this.INPUT_Pw = new System.Windows.Forms.TextBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "pw: ";
            // 
            // INPUT_ID
            // 
            this.INPUT_ID.Location = new System.Drawing.Point(68, 73);
            this.INPUT_ID.Name = "INPUT_ID";
            this.INPUT_ID.Size = new System.Drawing.Size(125, 27);
            this.INPUT_ID.TabIndex = 2;
            // 
            // INPUT_Pw
            // 
            this.INPUT_Pw.Location = new System.Drawing.Point(68, 106);
            this.INPUT_Pw.Name = "INPUT_Pw";
            this.INPUT_Pw.PasswordChar = '*';
            this.INPUT_Pw.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Pw.TabIndex = 3;
            this.INPUT_Pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.INPUT_Pw_KeyPress);
            // 
            // BTN_Login
            // 
            this.BTN_Login.BackColor = System.Drawing.Color.AliceBlue;
            this.BTN_Login.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Login.ForeColor = System.Drawing.Color.Blue;
            this.BTN_Login.Location = new System.Drawing.Point(199, 72);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(94, 61);
            this.BTN_Login.TabIndex = 4;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.UseVisualStyleBackColor = false;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vladimir Script", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(32, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(336, 174);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.INPUT_Pw);
            this.Controls.Add(this.INPUT_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox INPUT_ID;
        private System.Windows.Forms.TextBox INPUT_Pw;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Label label3;
    }
}