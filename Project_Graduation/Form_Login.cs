using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Graduation
{  
    public partial class Form_Login : Form
    {
        string connstring = resourceses.privacy.connstring;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection conn = new SqlConnection(connstring);
                string Login_query = "UserInfo";
                SqlDataAdapter SDA = new SqlDataAdapter(Login_query, conn);
                SDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                SDA.SelectCommand.Parameters.AddWithValue("@ID", INPUT_ID.Text.Trim());
                SDA.SelectCommand.Parameters.AddWithValue("@PW", INPUT_Pw.Text.Trim());

                DataSet Dset = new DataSet();
                SDA.Fill(Dset, "Table_User");
          
                if (Dset.Tables["Table_User"].Rows.Count > 0)
                {
                    MessageBox.Show("Login Success!", "Welcome");
                    
                    this.Hide();
                    this.DialogResult = DialogResult.OK;
                    resourceses.privacy.ID = INPUT_ID.Text.Trim();
                    resourceses.privacy.PW = INPUT_Pw.Text.Trim();
                    Form_Main mainF = new Form_Main();
                    mainF.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("check Your ID, PW", "Login failed");
                }

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

        private void INPUT_Pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(INPUT_Pw.ImeMode != ImeMode.Alpha)
            {
                INPUT_Pw.ImeMode = ImeMode.Alpha;
            }
        }
    }
}
