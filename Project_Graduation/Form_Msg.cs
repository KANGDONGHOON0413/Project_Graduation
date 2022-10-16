using Project_Graduation.methods;
using Project_Graduation.resourceses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Graduation
{
    public partial class Form_Msg : Form
    {
        int _orderNum = 0;

        public Form_Msg(int orderNum)
        {
           _orderNum = orderNum;

            InitializeComponent();
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 주문을 거절하시겠습니까?", "주문 거절", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<Param> Inputparams = new List<Param>();
                Inputparams.Add(new Param() { ProcedureParam = "@In_OrderNum", InputParam = _orderNum });
                Inputparams.Add(new Param() { ProcedureParam = "@In_PW", InputParam = privacy.PW });
                Inputparams.Add(new Param() { ProcedureParam = "@In_Msg", InputParam = INPUT_Msg.Text });
                UseProcedure.StoredProcedure1("dbo.RefuseOrder", Inputparams, "@Out_Msg");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) //취소버튼
        {
            this.Close();
        }
    }
}
