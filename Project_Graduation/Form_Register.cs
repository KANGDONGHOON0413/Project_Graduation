using Project_Graduation.resourceses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Graduation
{
    public partial class Form_Register : Form
    {       
        #region 생성자

        public Form_Register()
        {
            InitializeComponent();
        }

        #endregion 생성자_end


        private void BTN_Register_Click(object sender, EventArgs e)
        {
            #region 입력오류 다루기
            if (string.IsNullOrEmpty(INPUT_Id.Text) && string.IsNullOrEmpty(INPUT_Pw.Text) &&
                string.IsNullOrEmpty(INPUT_Name.Text) && string.IsNullOrEmpty(INPUT_Phone.Text))
                MessageBox.Show("입력값중 한곳이 비어있습니다.", "오류");

            else if (INPUT_Id.Text.Length < 6 || INPUT_Pw.Text.Length > 20) MessageBox.Show("ID는 최소 6글자 이상, 20글자 이하여야만 합니다.");
            else if (INPUT_Pw.Text.Length < 6 || INPUT_Pw.Text.Length > 20) MessageBox.Show("pw는 최소 6글자 이상, 20글자 이하여야만 합니다.");

            # endregion 입력오류 다루기_end

            else  //값을 받아 insert하는 부분
            {
                try
                {
                    string registerQuery = "Register_Cmd";
                SqlConnection conn = new SqlConnection(privacy.connstring);
                SqlDataAdapter SDA = new SqlDataAdapter(registerQuery, conn);
                DataSet Dset = new DataSet();
                SDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                SDA.SelectCommand.Parameters.AddWithValue("@ID", INPUT_Id.Text.Trim());
                SDA.Fill(Dset, "Table_User");
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                
               
                if (Dset.Tables["Table_User"].Rows.Count != 0) throw new Exception("이미 존재하는 아이디입니다.");

                DataRow NewRow = Dset.Tables[0].NewRow();;
                NewRow["ID"] = INPUT_Id.Text.Trim();
                NewRow["Password"] = INPUT_Pw.Text;
                NewRow["Name"] = INPUT_Name.Text.Trim();
                NewRow["Phone"] = INPUT_Phone.Text;
                Dset.Tables[0].Rows.Add(NewRow);
               
                    SDA.Update(Dset, "Table_User");
                    Dset.Clear();
                    MessageBox.Show("Register complete!", "register FIN");
                    this.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("서버 연결 오류 발생");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        #region Form_Event
        private void Form_Register_Load(object sender, EventArgs e)
        {
           
        }
        #endregion Form_Event_end

        #region 영어로만 입력받기(ID, PW)
        private void INPUT_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if (INPUT_Id.ImeMode != ImeMode.Alpha)
            {
                INPUT_Id.ImeMode = ImeMode.Alpha;
            }
        }

        private void INPUT_Pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (INPUT_Id.ImeMode != ImeMode.Alpha)
            {
                INPUT_Id.ImeMode = ImeMode.Alpha;
            }
        }
        #endregion
    }
}
