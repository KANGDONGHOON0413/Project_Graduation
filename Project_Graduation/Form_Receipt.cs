using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Graduation
{
    public partial class Form_Receipt : Form
    {
        int OrderNum;
        bool CkOrder = false;

        public Form_Receipt(int OrderNum, bool CkOrder)
        {
            this.OrderNum = OrderNum;
            this.CkOrder = CkOrder;
            InitializeComponent();
        }

        private void Form_Receipt_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(resourceses.privacy.connstring);
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("CkReceipt", conn);
            if(CkOrder)SDA.SelectCommand.CommandText = "CkOrder";

            SDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            SDA.SelectCommand.Parameters.AddWithValue("@OrderNum", OrderNum);

            SDA.Fill(dt);

            DataRow dr = dt.Rows[0];

            if (CkOrder)    // 주문확인시에는 필요없는 부분
            {
                this.Text = "Details";
                label_Seller_ID.Text = "";
                label_Seller_Phone.Text = "=======주문 상세=======";
                label_Commit_Time.Text = "";
            }
            else //영수증에 필요한 부분
            {
                label_Seller_ID.Text += "\t" + dr["Seller_ID"].ToString();
                label_Seller_Phone.Text += "\t" + dr["Seller_Phone"].ToString();
                label_Commit_Time.Text += "\t" + dr["Commit_Time"].ToString();
            }

            label_Order_Num.Text += "\t" + OrderNum;
            label_Orderer_ID.Text += "\t" + dr["Orderer_ID"].ToString();            
            label_Orderer_Name.Text += "\t" + dr["Orderer_Name"].ToString();
            label_Phone.Text += "\t" + dr["Orderer_Phone"].ToString();
            label_Address.Text += "\t" + dr["Orderer_Address"].ToString();
            label_Product_Name.Text += "\t" + dr["Product_Name"].ToString();
            label_Product_Num.Text += "\t" + dr["Product_Num"].ToString();
            label_TOT_Pay.Text += "\t" + dr["Total_Pay"].ToString();
            label_Order_Time.Text += "\t" + dr["Order_Time"].ToString();
        }
    }
}
