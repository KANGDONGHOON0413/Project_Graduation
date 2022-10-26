using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Project_Graduation.methods;
using Project_Graduation.resourceses;
namespace Project_Graduation
{
    public partial class Form_Sell : Form
    {

        string connstring = privacy.connstring;
        SqlCommand cmd;
        string SellerID = privacy.ID;
        int Sell_Num = 0;
        SqlDataAdapter SDA;
        DataTable dt;
        DataRow dr;

        public Form_Sell()  //물건 판매 등록
        {
            InitializeComponent();
        }

        public Form_Sell(int Sell_Num)     //물건 수정
        {
            InitializeComponent();
            this.Sell_Num = Sell_Num;

            SqlConnection conn = new SqlConnection(connstring);
            dt = new DataTable();
            SDA = new SqlDataAdapter("dbo.SelectSell", conn);
            SDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            SDA.SelectCommand.Parameters.AddWithValue("@Sell_Num", Sell_Num);
            //SDA.SelectCommand.Parameters.AddWithValue("@PW", privacy.PW);

            SDA.Fill(dt);

            dr = dt.Rows[0];

            if (!(dr["Product_Image"] is DBNull)) pictureBox1.Image = allMethods.ConvertByteArrayToImage((byte[])dr["Product_Image"]);
            INPUT_Item_Name.Text = dr["Product_Name"].ToString();
            INPUT_Item_Price.Text = dr["Product_Price"].ToString();
            INPUT_Item_Stock.Text = dr["Product_Num"].ToString();
            INPUT_Description.Text = dr["Product_Description"].ToString();
            BTN_Sell.Visible = false;
            BTN_Update.Visible = true;
            BTN_Delete.Visible = true;
        }


        #region BTN_event + picturebox press

        private void pictureBox1_Click(object sender, EventArgs e)
        {// 이미지박스 클릭시 이미지를 받아온다.
            openFileDialog1.Filter = "이미지 | *.jpg; *.png; *.bmp; *.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                MessageBox.Show("물품사진이 등록되었습니다.", "물품 사진");
            }
        }

        private void BTN_Sell_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(INPUT_Item_Name.Text) || string.IsNullOrEmpty(INPUT_Item_Price.Text) || string.IsNullOrEmpty(INPUT_Item_Stock.Text))
                {   //이미지박스 제외 모든 입력값을 받는다.
                    throw new Exception("입력칸이 비어있습니다.");
                }

                if (MessageBox.Show("해당물품을 올리시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    throw new Exception("취소되었습니다");
                }

                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "dbo.InputSell";

                        cmd.Parameters.Add(new SqlParameter ("@Item_Name", INPUT_Item_Name.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter ("@Item_Stock", int.Parse(INPUT_Item_Stock.Text.Trim())));
                        cmd.Parameters.Add(new SqlParameter ("@Item_Price", int.Parse(INPUT_Item_Price.Text.Trim())));
                        cmd.Parameters.Add(new SqlParameter ("@ID", SellerID));
                        cmd.Parameters.Add(new SqlParameter ("@Item_Description", INPUT_Description.Text.Trim()));
                        if (pictureBox1.Image != null)
                        {
                            cmd.Parameters.AddWithValue("@Item_Image", allMethods.ConvertImageToByte(pictureBox1.Image));
                        }
                        else cmd.Parameters.AddWithValue("@Item_Image", null);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("물품이 성공적으로 판매리스트에 올랐습니다.","등록확인");

                        Reset();
                    }
                    catch (SqlException exc)
                    {
                        MessageBox.Show("오류발생: {0}", exc.Message);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Item stock와 Item Price는 숫자로 입력해주십시오.", "입력오류");
                    }
                }
            }
            catch(Exception exc) //INPUT 빈칸과 취소 핸들링
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("업데이트하시겠습니까?", "update", MessageBoxButtons.YesNo) == DialogResult.No) throw new Exception("업데이트가 취소되었습니다.");
                if (pictureBox1.Image != null) dr["Product_Image"] = allMethods.ConvertImageToByte(pictureBox1.Image);
                dr["Product_Name"] = INPUT_Item_Name.Text;
                dr["Product_Price"] = INPUT_Item_Price.Text;
                dr["Product_Num"] = INPUT_Item_Stock.Text;
                dr["Product_Description"] = INPUT_Description.Text;

                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.Update(dt);
                MessageBox.Show("물품정보가 변경되었습니다.", "업데이트 확인");
                Reset();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message,"취소");
            }
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("제품을 삭제하시겠습니까?", "update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dr.Delete();
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.Update(dt);
                MessageBox.Show("삭제가 완료되었습니다", "삭제완료");
                Reset();
            }
        }

        #endregion BTN_event + picturebox press 끝========

       
        #region 숫자로만 입력받기(가격, 재고) key press event
        private void INPUT_Item_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            allMethods.NumKeyOnly(e); //project_Graduation.methods.allMethods.NumKeyOnly        
        }

        private void INPUT_Item_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            allMethods.NumKeyOnly(e);
        }
        #endregion

        private void Reset()
        {
            INPUT_Item_Name.Text = "";
            INPUT_Item_Price.Text = "";
            INPUT_Item_Stock.Text = "";
            INPUT_Description.Text = "";
            pictureBox1.Image = null;
        }
    }
}
