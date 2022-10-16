
namespace Project_Graduation
{
    partial class Form_Msg
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
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.OUTPUT_Title = new System.Windows.Forms.Label();
            this.INPUT_Msg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Location = new System.Drawing.Point(30, 237);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(210, 38);
            this.BTN_Submit.TabIndex = 0;
            this.BTN_Submit.Text = "주문 거절";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // OUTPUT_Title
            // 
            this.OUTPUT_Title.AutoSize = true;
            this.OUTPUT_Title.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OUTPUT_Title.Location = new System.Drawing.Point(92, 18);
            this.OUTPUT_Title.Name = "OUTPUT_Title";
            this.OUTPUT_Title.Size = new System.Drawing.Size(226, 28);
            this.OUTPUT_Title.TabIndex = 1;
            this.OUTPUT_Title.Text = "거절 사유를 입력하세요";
            this.OUTPUT_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INPUT_Msg
            // 
            this.INPUT_Msg.Location = new System.Drawing.Point(30, 60);
            this.INPUT_Msg.Multiline = true;
            this.INPUT_Msg.Name = "INPUT_Msg";
            this.INPUT_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.INPUT_Msg.Size = new System.Drawing.Size(360, 171);
            this.INPUT_Msg.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.INPUT_Msg);
            this.Controls.Add(this.OUTPUT_Title);
            this.Controls.Add(this.BTN_Submit);
            this.Name = "Form_Msg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Msg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Label OUTPUT_Title;
        private System.Windows.Forms.TextBox INPUT_Msg;
        private System.Windows.Forms.Button button1;
    }
}