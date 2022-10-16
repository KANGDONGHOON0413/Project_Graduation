using Project_Graduation.resourceses;
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
    public partial class Form_Favorite : Form
    {
        SqlConnection conn;

        public Form_Favorite()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                int searchBySellNum = (int)dataGridView1.SelectedRows[0].Cells["Sell_Num"].Value;
                Form_Order_Main FOM = new Form_Order_Main(searchBySellNum);
                FOM.ShowDialog();
            }
        }

        private void Form_Favorite_Shown(object sender, EventArgs e)
        {
            conn = new SqlConnection(privacy.connstring);
            SetDatagridview();
        }

        private void Form_Favorite_Layout(object sender, LayoutEventArgs e)
        {
            this.Width = 318;
            this.Height = 551;
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                if (MessageBox.Show("관심종목을 삭제하시겠습니까?", "관심종목", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        foreach (DataGridViewRow rows in dataGridView1.SelectedRows)
                        {
                            string temp = rows.Cells["Sell_Num"].Value.ToString();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = "Delete From Table_Favorites Where Sell_Num = @SellNum And User_ID = @ID";
                            cmd.Parameters.AddWithValue("@SellNum", temp);
                            cmd.Parameters.AddWithValue("@ID", privacy.ID);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("삭제되었습니다.","삭제 알림");
                        SetDatagridview(); //새로고침
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);                       
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }
        }

        private void SetDatagridview()
        {
            var dt = new DataTable();
            var SDA = new SqlDataAdapter("Select Sell_Num, Product_Name From Table_Favorites Where User_ID = @ID", conn);
            SDA.SelectCommand.Parameters.AddWithValue("@ID", privacy.ID);
            SDA.Fill(dt);

            dataGridView1.DataSource = dt;
        }


    }
}
