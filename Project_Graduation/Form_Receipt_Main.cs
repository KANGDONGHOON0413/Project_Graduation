using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_Graduation.resourceses;

namespace Project_Graduation
{
    public partial class Form_Receipt_Main : Form
    {
        public Form_Receipt_Main()
        {
            InitializeComponent();
        }

        private void Form_Receipt_Main_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(privacy.connstring);
            DataSet Dset = new DataSet();
            
            SqlDataAdapter SDA_Rbuy = new SqlDataAdapter("Receipt_Buy",conn);
            SDA_Rbuy.SelectCommand.CommandType = CommandType.StoredProcedure;
            SDA_Rbuy.SelectCommand.Parameters.AddWithValue("@ID", privacy.ID);
            SDA_Rbuy.SelectCommand.Parameters.AddWithValue("@PW", privacy.PW);
            SDA_Rbuy.Fill(Dset, "Receipt_Buy");
            dataGridView1.DataSource = Dset.Tables["Receipt_Buy"];

            SqlDataAdapter SDA_Rsell = new SqlDataAdapter("Receipt_Sell", conn);
            SDA_Rsell.SelectCommand.CommandType = CommandType.StoredProcedure;
            SDA_Rsell.SelectCommand.Parameters.AddWithValue("@ID", privacy.ID);
            SDA_Rsell.SelectCommand.Parameters.AddWithValue("@PW", privacy.PW);
            SDA_Rsell.Fill(Dset, "Receipt_Sell");
            dataGridView2.DataSource = Dset.Tables["Receipt_Sell"];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                int sel = (int)dataGridView1.CurrentRow.Cells["Order_Num"].Value;
                Form_Receipt FR = new Form_Receipt(sel, false);
                FR.ShowDialog();
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow.Selected)
            {
                int sel = (int)dataGridView2.CurrentRow.Cells["Order_Num"].Value;
                Form_Receipt FR = new Form_Receipt(sel, false);
                FR.ShowDialog();
            }
        }  
    }
}
