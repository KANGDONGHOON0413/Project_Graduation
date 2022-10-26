using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_Graduation.methods;
using Project_Graduation.resourceses;
using Project_Graduation.Properties;
using System.Threading.Tasks;

namespace Project_Graduation
{
    public partial class Form_Order_Main : Form
    {
        #region 변수
        DataSet Dset;
        SqlDataAdapter SDA_Favorite;
        private string connstring = privacy.connstring;
        private string User_ID = privacy.ID;
        private string User_Address;
        private string User_Phone;
        private string User_Name;
        static private int TotalPay;
        int SellNum;
        string DefaultSet = "Select Sell_Num, Product_Name, Product_Num, Product_Price, Seller_ID From Table_Sell Where Product_Num > 0 ";
        #endregion

        #region 생성자

        public Form_Order_Main()
        {
            InitializeComponent();
        }

        public Form_Order_Main(int SellNum)
        {
            this.SellNum = SellNum;
            InitializeComponent();
        }

        #endregion

        #region Datagridview + button event

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                SellNum = (int)dataGridView1.SelectedRows[0].Cells["Sell_Num"].Value;

                arrayItemDescription();
            }
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(INPUT_Search.Text.Trim())) MessageBox.Show("입력란을 확인하세요");
            else
            {
                string Filter = DefaultSet + "And Product_Name Like '%" + INPUT_Search.Text.Trim() + "%'";
                if (INPUT_Search_Option.SelectedIndex == 1) Filter = DefaultSet + "And Seller_ID = '" + INPUT_Search.Text.Trim() + "' ";

                if (!string.IsNullOrEmpty(INPUT_Scope_Min.Text.Trim())) Filter += " And Product_Price > " + INPUT_Scope_Min.Text.Trim();
                if (!string.IsNullOrEmpty(INPUT_Scope_Max.Text.Trim())) Filter += " And Product_Price < " + INPUT_Scope_Max.Text.Trim();

                switch (INPUT_Filter1.SelectedIndex)
                {
                    case 0:
                        Filter += "ORDER BY Sell_Num Desc";
                        break;
                    case 1:
                        Filter += "ORDER BY Sell_Num";
                        break;
                    case 2:
                        Filter += "Order By Product_Price";
                        break;
                    case 3:
                        Filter += "Order By Product_Price Desc";
                        break;
                }
                Dset.Tables["Sell"].Clear();
                SETForm(Filter);
            }
        }

        private void BTN_Del_Click(object sender, EventArgs e)
        {
            INPUT_Scope_Min.Text = "";
            INPUT_Scope_Max.Text = "";
        }

        private void BTN_Buy_Click(object sender, EventArgs e)
        {

            try
            {

                #region 확인 절차
                if (MessageBox.Show("해당상품을 구매하시겠습니까?", "주문 확인", MessageBoxButtons.YesNo) == DialogResult.No)
                    throw new Exception("주문 요청 취소");
                #endregion


                #region 입력값 예외처리부분

                if (SellNum == 0) throw new Exception("구매하실 물건을 먼저 선택해주세요");

                if (string.IsNullOrEmpty(INPUT_Address.Text) || string.IsNullOrEmpty(INPUT_Phone.Text) || string.IsNullOrEmpty(INPUT_Quantity.Text))
                    throw new Exception("빈 항목이 존재합니다");

                if (int.Parse(INPUT_Quantity.Text) <= 0) throw new Exception("물품수량을 확인해주세요");

                if (int.Parse(OUTPUT_Stock.Text) < int.Parse(INPUT_Quantity.Text)) throw new Exception("물품 개수가 초과되었습니다.");

                #endregion  입력값 예외처리부분 끝

                #region 상품 구매 요청 부분(트랜잭션 사용, 프로시저 사용 안한 부분)
                //SqlTransaction transaction = null;

                //using (SqlConnection conn = new SqlConnection(connstring))
                //{                                    
                //    conn.Open();

                //    transaction = conn.BeginTransaction();

                //    try
                //    {
                //        string cmdString;

                //        //#region ===================재고 확인 부분================
                //        //cmdString = "Select Product_Num From Table_Sell Where Sell_Num = @Sell_Num";
                //        //cmd.CommandText = cmdString;
                //        //cmd.Parameters.AddWithValue("@Sell_Num", SellNum);
                //        //SqlDataReader Dr = cmd.ExecuteReader();
                //        //int stock = Dr.GetInt32(0);

                //        //if (stock < int.Parse(INPUT_Quantity.Text)) throw new Exception("물건이 전부 팔렸습니다.");
                //        //#endregion


                //        #region ===================재고 차감 부분==================

                //        SqlCommand cmd2 = new SqlCommand();
                //        cmd2.Connection = conn;
                //        cmd2.Transaction = transaction;

                //        cmdString = "UPDATE Table_Sell SET Product_Num -=@Product_Num Where Sell_Num = @Sell_Num";
                //        cmd2.CommandText = cmdString;
                //        cmd2.Parameters.AddWithValue("@Product_Num", int.Parse(INPUT_Quantity.Text));
                //        cmd2.Parameters.AddWithValue("@Sell_Num", SellNum);
                //        if (cmd2.ExecuteNonQuery() <= 0) throw new Exception("구매 오류 발생");

                //        #endregion ===================재고 차감 부분 end==================


                //        #region ===================구매 부분======================

                //        cmdString = "INSERT INTO Table_Order (Orderer_ID, Orderer_Name, Orderer_Phone, Orderer_Address," +
                //            "Seller_ID, Sell_Num, Product_Name, Product_Num, Total_Pay, Order_Time) " +
                //            "Values (@Orderer_ID, @Orderer_Name, @Orderer_Phone, @Orderer_Address," +
                //            "@Seller_ID, @Sell_Num, @Product_Name, @Product_Num, @Total_Pay, @Order_Time)";

                //        SqlCommand cmd3 = new SqlCommand();
                //        cmd3.Connection = conn;
                //        cmd3.CommandText = cmdString;
                //        cmd3.Transaction = transaction;

                //        cmd3.Parameters.AddWithValue("@Orderer_ID", User_ID);
                //        cmd3.Parameters.AddWithValue("@Orderer_Name", INPUT_User_Name.Text);
                //        cmd3.Parameters.AddWithValue("@Orderer_Phone", INPUT_Phone.Text);
                //        cmd3.Parameters.AddWithValue("@Orderer_Address", INPUT_Address.Text);
                //        cmd3.Parameters.AddWithValue("@Seller_ID", OUTPUT_Seller_ID.Text);
                //        cmd3.Parameters.AddWithValue("@Sell_Num", SellNum);
                //        cmd3.Parameters.AddWithValue("@Product_Name", OUTPUT_Item_Name.Text);
                //        cmd3.Parameters.AddWithValue("@Product_Num", int.Parse(INPUT_Quantity.Text));
                //        cmd3.Parameters.AddWithValue("@Total_Pay", int.Parse(OUTPUT_TOT_Cost.Text));

                //        string ordertime = DateTime.Now.ToString();
                //        cmd3.Parameters.AddWithValue("@Order_Time", ordertime);
                //        if (cmd3.ExecuteNonQuery() <= 0) throw new Exception("구매 오류 발생");

                //        #endregion ===================구매 부분 end======================

                //        transaction.Commit();

                //        MessageBox.Show("물품이 성공적으로 구매리스트에 올랐습니다.");
                //    }
                //    catch (Exception exc)
                //    {
                //        transaction.Rollback();
                //        MessageBox.Show(exc.Message);
                //    }
                //}

                #endregion 상품 구매 요청 부분 끝 ===============================================================

                #region 프로시저 사용, 공유매서드 사용x
                //Procedure 사용
                //using (SqlConnection conn = new SqlConnection(connstring))
                //{
                //    conn.Open();
                //    SqlCommand cmd = new SqlCommand("MakeOrders");
                //    cmd.CommandType = CommandType.StoredProcedure;
                //    cmd.Connection = conn;
                //    cmd.Parameters.AddWithValue("@In_Orderer_ID", User_ID);
                //    cmd.Parameters.AddWithValue("@In_Orderer_Name", INPUT_User_Name.Text);
                //    cmd.Parameters.AddWithValue("@In_Orderer_Phone", INPUT_Phone.Text);
                //    cmd.Parameters.AddWithValue("@In_Orderer_Address", INPUT_Address.Text);
                //    cmd.Parameters.AddWithValue("@In_Seller_ID", OUTPUT_Seller_ID.Text);
                //    cmd.Parameters.AddWithValue("@In_Sell_Num", SellNum);
                //    cmd.Parameters.AddWithValue("@In_Product_Name", OUTPUT_Item_Name.Text);
                //    cmd.Parameters.AddWithValue("@In_Product_Num", int.Parse(INPUT_Quantity.Text));
                //    cmd.Parameters.AddWithValue("@In_TotalPay", int.Parse(OUTPUT_TOT_Cost.Text));

                //    SqlParameter msg = new SqlParameter();
                //    msg.ParameterName = "@Out_message";
                //    msg.DbType = DbType.String;
                //    msg.Size = 20;
                //    msg.Direction = ParameterDirection.Output;

                //    cmd.Parameters.Add(msg);

                //    cmd.ExecuteNonQuery();

                //    MessageBox.Show(cmd.Parameters["@Out_message"].Value.ToString(),"주문 결과");
                //}

                #endregion

                List<Param> Plist = new List<Param>();
                Plist.Add(new Param() { ProcedureParam = "@In_Orderer_ID", InputParam = User_ID });
                Plist.Add(new Param() { ProcedureParam = "@In_Orderer_Name", InputParam = INPUT_User_Name.Text });
                Plist.Add(new Param() { ProcedureParam = "@In_Orderer_Phone", InputParam = INPUT_Phone.Text });
                Plist.Add(new Param() { ProcedureParam = "@In_Orderer_Address", InputParam = INPUT_Address.Text });
                Plist.Add(new Param() { ProcedureParam = "@In_Sell_Num", InputParam = SellNum });
                Plist.Add(new Param() { ProcedureParam = "@In_Product_Num", InputParam = int.Parse(INPUT_Quantity.Text) });
                UseProcedure.StoredProcedure1("MakeOrders", Plist, "@Out_message");


                //datagridview 초기화
                SETForm(DefaultSet + " ORDER BY Sell_Num Desc");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) //Setdefault button
        {
            INPUT_Address.Text = User_Address;
            INPUT_Phone.Text = User_Phone;
            INPUT_User_Name.Text = User_Name;
        }

        private void BTN_Favorite_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA_Favorite);
            if (Dset.Tables["Table_Favorite"].Rows.Count == 1)  //이미 관심 등록을 해 놓은 경우
            {
                Dset.Tables["Table_Favorite"].Rows[0].Delete();
                SDA_Favorite.Update(Dset.Tables["Table_Favorite"]);

                MessageBox.Show("관심을 해제하였습니다.", "알림");
                BTN_Favorite.Text = "Add To Favorite";
                BTN_Favorite.BackgroundImage = Resources.nonfavorite;
            }
            else
            {
                DataRow dr = Dset.Tables["Table_Favorite"].NewRow();
                dr["User_ID"] = privacy.ID;
                dr["Sell_Num"] = SellNum;
                dr["Product_Name"] = OUTPUT_Item_Name.Text;
                Dset.Tables["Table_Favorite"].Rows.Add(dr);

                SDA_Favorite.Update(Dset, "Table_Favorite");

                MessageBox.Show("해당 상품을 관심목록에 추가하였습니다.\nMain의 Favorite 에서 확인하실 수 있어요.", "알림");
                BTN_Favorite.Text = "Already Favorite";
                BTN_Favorite.BackgroundImage = Resources.favorite_icon;
            }

        }

        #region 물건 개수 입력 부분(Quantity Events)
        private void INPUT_Quantity_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                INPUT_Quantity.Items.Clear();
                int i = 0;
                int max = int.Parse(OUTPUT_Stock.Text);
                while (i < max)
                {
                    if (i < 10) i++;
                    else i += 10;

                    INPUT_Quantity.Items.Add(i);
                }
                INPUT_Quantity.Items.RemoveAt(INPUT_Quantity.Items.Count - 1); //마지막 item을 제거하는 부분이다.
                INPUT_Quantity.Items.Add(max);
            }
            catch (Exception)
            {

            }
        }

        private void INPUT_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(INPUT_Quantity.Text))
            {
                int tempPrice = int.Parse(OUTPUT_Price.Text) * int.Parse(INPUT_Quantity.Text);
                if (tempPrice < 25000) OUTPUT_fee.Text = "2500";
                else OUTPUT_fee.Text = "0";
                TotalPay = tempPrice + int.Parse(OUTPUT_fee.Text);
                OUTPUT_TOT_Cost.Text = TotalPay.ToString();
            }
        }

        #endregion 물건 개수 입력 끝======

        #endregion 버튼 이벤트 끝=========

        #region =======함수===========

        private async void arrayItemDescription()
        {
            var task1 = Task.Run(() => ShowItemDetails()); //sellnum의 아이템을 표기하는 부분이다.
            var task2 = Task.Run(() => Is_Favorite());      // 관심종목 유무 확인
            var task3 = Task.Run(() => setEmptyInput());    //Input값들 빈칸으로 만들기

            await task1;
            await task2;
            await task3;
        }

        private void setEmptyInput()
        {
            INPUT_User_Name.Text = "";
            INPUT_Quantity.Text = "0";
            INPUT_Phone.Text = "";
            INPUT_Address.Text = "";
            OUTPUT_fee.Text = "";
            OUTPUT_TOT_Cost.Text = "";
        }

        private void ShowItemDetails()
        {
            SqlConnection conn = new SqlConnection(connstring);
            SqlDataAdapter SDA = new SqlDataAdapter("SelectSell", conn);
            SDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            SDA.SelectCommand.Parameters.AddWithValue("@Sell_Num", SellNum);
            SDA.Fill(Dset, "Selected_row");

            DataRow[] Drow = Dset.Tables["Selected_row"].Select();

            if (!(Drow[0]["Product_Image"] is DBNull))
                pictureBox1.Image = allMethods.ConvertByteArrayToImage((byte[])Drow[0]["Product_Image"]);
            else pictureBox1.Image = null;

            OUTPUT_Item_Name.Text = Drow[0]["Product_Name"].ToString();
            OUTPUT_Stock.Text = Drow[0]["Product_Num"].ToString();
            OUTPUT_Price.Text = Drow[0]["Product_Price"].ToString();
            OUTPUT_Seller_ID.Text = Drow[0]["Seller_ID"].ToString();
            OUTPUT_Description.Text = Drow[0]["Product_Description"].ToString();
            Dset.Tables["Selected_row"].Clear();
        }

        private void Is_Favorite()
        {
            Dset.Tables["Table_Favorite"].Clear();
            SqlConnection conn = new SqlConnection(connstring);
            SDA_Favorite = new SqlDataAdapter("Select * From Table_Favorites Where Sell_Num =" + SellNum, conn);
            SDA_Favorite.Fill(Dset, "Table_Favorite");

            if (Dset.Tables["Table_Favorite"].Rows.Count == 1)
            {
                BTN_Favorite.Text = "Already Favorite";
                BTN_Favorite.BackgroundImage = Resources.favorite_icon;
            }
            else
            {
                BTN_Favorite.Text = "Add To Favorite";
                BTN_Favorite.BackgroundImage = Resources.nonfavorite;
            }
        }

        private void SETForm(string sqlcmd)
        {
            SqlConnection conn = new SqlConnection(connstring);
            SqlDataAdapter SDA = new SqlDataAdapter(sqlcmd, conn);

            SDA.Fill(Dset, "Sell");

            dataGridView1.DataSource = Dset.Tables["Sell"];

        }   //데이터set와 datagridview설정부분    

        #region 입력 제한
        private void INPUT_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            allMethods.NumKeyOnly(e);
        }

        private void INPUT_Scope_Min_KeyPress(object sender, KeyPressEventArgs e)
        {
            allMethods.NumKeyOnly(e);
        }

        private void INPUT_Scope_Max_KeyPress(object sender, KeyPressEventArgs e)
        {
            allMethods.NumKeyOnly(e);
        }
        #endregion

        #endregion =======함수===========

        #region 폼 시작, 종료 이벤트
        private void Form_Order_Main_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstring);
            Dset = new DataSet();
            SqlDataAdapter SDA = new SqlDataAdapter("Select * From Table_User Where ID = '" + User_ID + "' And Password ='" + privacy.PW + "'", conn);
            SDA.Fill(Dset, "myInfo");

            DataRow Drow = Dset.Tables["myInfo"].Rows[0];

            User_Address = Drow["Address"].ToString();
            User_Phone = Drow["Phone"].ToString();
            User_Name = Drow["Name"].ToString();

            INPUT_Search_Option.SelectedIndex = 0;
            INPUT_Filter1.SelectedIndex = 0;
            SETForm(DefaultSet + " ORDER BY Sell_Num Desc");

            Dset.Tables.Add("Table_Favorite");          // 어쩔수 없이 넣었다-> 

            if (SellNum != 0) arrayItemDescription();
        }

        private void Form_Order_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dset.Tables["Sell"].Clear();
        }

        #endregion

    }
}
