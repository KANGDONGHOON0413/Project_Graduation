using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Graduation.methods;
using Project_Graduation.resourceses;

namespace Project_Graduation
{
    public partial class Form_Main : Form
    {
        DataSet Dset;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Layout(object sender, LayoutEventArgs e)
        {
            this.Width = 1101;
            this.Height = 620;
        }


        #region =============BTN Events======================

        #region ========== 페이지 넘김 이벤트==========

        private void button1_Click(object sender, EventArgs e) //option
        {
            Form_Option OPForm = new Form_Option();
            if (OPForm.ShowDialog() == DialogResult.OK) this.Dispose();
            else this.Refresh();
        }

        private void BTN_Sell_Click(object sender, EventArgs e)
        {
            Form_Sell FSell = new Form_Sell();
            FSell.ShowDialog();
        }

        private void BTN_Order_Click(object sender, EventArgs e)
        {
            Form_Order_Main FOMORDER = new Form_Order_Main();
            FOMORDER.ShowDialog();
        }

        private void BTN_Favorite_Click(object sender, EventArgs e)
        {
            Form_Favorite FF = new Form_Favorite();
            FF.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // 영수증 버튼(Form_Receipt)
        {
            Form_Receipt_Main FRM = new Form_Receipt_Main();
            FRM.Show();
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            ViewSettings();
        }

        #endregion ===========End 페이지 넘김 이벤트 ================


        #region ============ 하단부 버튼 이벤트==============

        private void BTN_Receive_OK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("주문을 완료하시겠습니까?", "인수확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow rows in DGV_Order_Receive.SelectedRows)
                {
                    int OrderNum = (int)rows.Cells["Order_Num"].Value;
                    List<Param> Inputparams = new List<Param>();
                    Inputparams.Add(new Param() { ProcedureParam = "@In_OrderNum", InputParam = OrderNum });
                    Inputparams.Add(new Param() { ProcedureParam = "@In_PW", InputParam = privacy.PW });
                    UseProcedure.StoredProcedure1("dbo.MakeReceipt", Inputparams, "@out_msg");
                }
            }
        }

        private void BTN_Order_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 주문을 취소하시겠습니까?", "주문취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow rows in DGV_Order.SelectedRows)
                {
                    int OrderNum = (int)rows.Cells["Order_Num"].Value;
                    List<Param> Inputparams = new List<Param>();
                    Inputparams.Add(new Param() { ProcedureParam = "@In_OrderNum", InputParam = OrderNum });
                    UseProcedure.StoredProcedure1("dbo.CancleOrder", Inputparams, "@Out_Msg");
                }

            }
        }

        private void BTN_Refuse_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Order_Receive.SelectedRows.Count >= 2 || DGV_Order_Receive.SelectedRows.Count == 0)
                    throw new IndexOutOfRangeException("주문 거절은 한번에 하나씩만 수행해주세요.");

                int OrderNum = (int)DGV_Order_Receive.SelectedRows[0].Cells["Order_Num"].Value;

                Form_Msg MsgForm = new Form_Msg(OrderNum);
                MsgForm.ShowDialog();
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        #endregion ==============끝===========================

        #endregion ===================end of BTN events==================



        #region ===========DataGridView(DGV) Events===========

        private void DGV_Sell_ing_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Sell_ing.CurrentRow.Selected)
            {
                int SellNum = (int)DGV_Sell_ing.SelectedRows[0].Cells["Sell_Num"].Value;
                Form_Sell FS = new Form_Sell(SellNum);
                FS.ShowDialog();
            }
        }

        private void DGV_Order_Receive_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Order_Receive.CurrentRow.Selected)
            {
                int OrderNum = (int)DGV_Order_Receive.SelectedRows[0].Cells["Order_Num"].Value;
                Form_Receipt _Receipt = new Form_Receipt(OrderNum, true);
                _Receipt.ShowDialog();
            }
        }


        #endregion ===========DataGridView(DGV) Events===========



        #region =========Form Start And End Event===========
        private void Form_Main_Shown(object sender, EventArgs e)
        {
           // conn = new SqlConnection(privacy.connstring);
            Dset = new DataSet();

            ViewSettings();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.No) e.Cancel = true;
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("이용해주셔서 감사합니다.", "EXIT");
            Application.Exit();
        }
        #endregion =========Form Start And End Event===========



        #region ========methods==========


        private async void ViewSettings()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(privacy.connstring))
                {
                    Dset.Clear();
                    SqlDataAdapter SDA_Info = new SqlDataAdapter("UserInfo", conn);
                    SDA_Info.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SDA_Info.SelectCommand.Parameters.AddWithValue("@ID", privacy.ID);
                    SDA_Info.SelectCommand.Parameters.AddWithValue("@PW", privacy.PW);
                    SDA_Info.Fill(Dset, "Info");
                }

                foreach (DataRow dRow in Dset.Tables["Info"].Select())
                {
                    TXT_Name.Text = dRow["Name"].ToString();
                    TXT_Phone_Num.Text = "Phone Number:  " + dRow["Phone"].ToString();
                }

                var task1 = Task.Run(() => fillTableSell());
                var task2 = Task.Run(() => fillTableOrder());
                var task3 = Task.Run(() => fillTableOrderReceive());
                var task4 = Task.Run(() => ReceivingMsg());

                await task1;
                await task2;
                await task3;

                DGV_Sell_ing.DataSource = Dset.Tables["Table_Sell"];

                DGV_Order.DataSource = Dset.Tables["Table_Order"];

                DGV_Order_Receive.DataSource = Dset.Tables["Table_Order_Receive"];
                await task4;


                if (DGV_Order_Receive.Rows.Count > 0) MessageBox.Show("주문 들어온 물품이 있습니다", "물품 확인");
                if (Dset.Tables["Table_Msg"].Rows.Count > 0)
                {
                    foreach (DataRow msg in Dset.Tables["Table_Msg"].Rows)
                    {
                        string msg_out = "";
                        if (msg["MsgTitle"].Equals(true)) msg_out = "주문 완료";
                        else msg_out = "주문거절";
                        msg_out += "\n제품명: " + msg["Product_Name"] + "  수량: " + msg["Product_Num"] + "\n  " + msg["Msg"];
                        MessageBox.Show(msg_out, "메시지");
                    }
                }
                Dset.Tables["Table_Msg"].Clear();
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

        private void fillTableSell()
        {
            SqlConnection conn = new SqlConnection(privacy.connstring);
            SqlDataAdapter SDA_Sell = new SqlDataAdapter("select A.Sell_Num, A.Product_Name, A.Product_Price, A.Product_Num " +
                   "From Table_Sell A, Table_User B Where B.ID = '" + privacy.ID + "' And B.Password = '" + privacy.PW + "' And A.Seller_ID = B.ID", conn);
            SDA_Sell.Fill(Dset, "Table_Sell");
        }

        private void fillTableOrder()
        {
            SqlConnection conn = new SqlConnection(privacy.connstring);
            SqlDataAdapter SDA_Order = new SqlDataAdapter("Select A.Order_Num, A.Product_Name, A.Product_Num, A.Total_Pay, A.Order_Time " +
                    "From Table_Order A, Table_User B Where B.ID = '" + privacy.ID + "' And B.Password = '" + privacy.PW + "' And A.Orderer_ID = B.ID", conn);
            SDA_Order.Fill(Dset, "Table_Order");
        }

        private void fillTableOrderReceive()
        {
            SqlConnection conn = new SqlConnection(privacy.connstring);
            SqlDataAdapter SDA_Order_Receive = new SqlDataAdapter("Select A.Order_Num, A.Product_Name, A.Product_Num, A.Total_Pay, A.Order_Time " +
                    "From Table_Order A Where A.Seller_ID = '" + privacy.ID + "'", conn);
            SDA_Order_Receive.Fill(Dset, "Table_Order_Receive");
        }

        private void ReceivingMsg()
        {
            SqlConnection conn = new SqlConnection(privacy.connstring);
            SqlDataAdapter SDA_Msg = new SqlDataAdapter("dbo.ShowMsg", conn);
            SDA_Msg.SelectCommand.CommandType = CommandType.StoredProcedure;
            SDA_Msg.SelectCommand.Parameters.AddWithValue("@In_ID", privacy.ID);
            SDA_Msg.SelectCommand.Parameters.AddWithValue("@In_PW", privacy.PW);
            SDA_Msg.Fill(Dset, "Table_Msg");
        }


        #endregion     
    }
}
