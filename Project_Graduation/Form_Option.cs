using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Project_Graduation.methods;
using Project_Graduation.resourceses;

namespace Project_Graduation
{
    public partial class Form_Option : Form
    {
        SqlConnection conn;
        string connstring = privacy.connstring;

        DataSet Dset;
        SqlDataAdapter SDA;
        Boolean pw_change = false;

        public Form_Option()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "이미지 | *.jpg; *.png; *.bmp; *.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                MessageBox.Show("이미지가 변경되었습니다.", "프로필 변경");
            }
        }

        private void BTN_Confirm_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            DataRow[] Drow = Dset.Tables["Table_User"].Select();
            if (pw_change) Drow[0]["Password"] = INPUT_Pw.Text.Trim();
            if (INPUT_Phone.Text.Length > 10) Drow[0]["Phone"] = INPUT_Phone.Text.Trim();
            Drow[0]["Email"] = INPUT_Email.Text.Trim();
            Drow[0]["Address"] = INPUT_Address.Text.Trim();
            Drow[0]["Image"] = allMethods.ConvertImageToByte(pictureBox1.Image);

            SDA.Update(Dset, "Table_User");
            Dset.Clear();
            if (pw_change) privacy.PW = INPUT_Pw.Text.Trim();
            SDA.Fill(Dset, "Table_User");
            MessageBox.Show("업데이트 성공");
        }

        private void Form_Option_Load(object sender, EventArgs e)
        {
            Dset = new DataSet();
            conn = new SqlConnection(connstring);
            string query = "UserInfo";
            SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            SDA.SelectCommand.Parameters.AddWithValue("@ID", privacy.ID);
            SDA.SelectCommand.Parameters.AddWithValue("@PW", privacy.PW);

            SDA.Fill(Dset, "Table_User");

            DataRow dRow = Dset.Tables["Table_User"].Rows[0];
            try
            {
                OUTPUT_Name.Text = dRow["Name"].ToString();
                INPUT_Phone.Text = dRow["Phone"].ToString();
                INPUT_Email.Text = dRow["Email"].ToString();
                INPUT_Address.Text = dRow["Address"].ToString();
                if (dRow["Image"] is DBNull) throw new Exception("기본이미지를 설정하세요");
                else pictureBox1.Image = allMethods.ConvertByteArrayToImage((byte[])dRow["Image"]);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void BTN_Check_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(INPUT_Pw.Text) && !string.IsNullOrEmpty(INPUT_Pw_Check.Text))
            {
                if (INPUT_Pw.Text.Length < 6) MessageBox.Show("pw는 최소 6글자 이상이여야만 합니다.");
                else if (string.Compare(INPUT_Pw.Text, INPUT_Pw_Check.Text) == 0)
                {
                    INPUT_Pw.ReadOnly = true;
                    INPUT_Pw_Check.ReadOnly = true;
                    MessageBox.Show("확인되었습니다");
                    BTN_Check.BackColor = Color.Aqua;
                    pw_change = true;
                }
                else MessageBox.Show("pw입력값이 다릅니다");
            }
        }

        private void Btn_Leave_Click(object sender, EventArgs e)
        {          
            if (MessageBox.Show("회원 탈퇴를 진행하시겠습니까?", "회원탈퇴", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);

                Dset.Tables[0].Rows[0].Delete();
                SDA.Update(Dset, "Table_User");
                privacy.ID = null;
                privacy.PW = null;
                MessageBox.Show("회원에서 탈퇴하였습니다.", "회원 탈퇴");
                reset();
            }
            else MessageBox.Show("회원 탈퇴를 취소하였습니다.");
        }

        private void BTN_LogOut_Click(object sender, EventArgs e)
        {
            privacy.ID = null;
            privacy.PW = null;
            reset();
        }

        private void reset()
        {
            StartForm SForm = new StartForm();
            Dset.Dispose();
            this.DialogResult = DialogResult.OK;
            this.Hide();
            SForm.Show();
        }    
    }
}
