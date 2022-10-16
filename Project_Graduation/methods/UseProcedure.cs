using Project_Graduation.resourceses;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Graduation.methods
{
    public class UseProcedure
    {
        public static void StoredProcedure1(string ProcedureName, List<Param> In_Param, string Out_Msg)
        {
                using (SqlConnection conn = new SqlConnection(privacy.connstring))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(ProcedureName);
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter msg = new SqlParameter();
                    msg.ParameterName = Out_Msg;
                    msg.DbType = DbType.String;
                    msg.Size = 30;
                    msg.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(msg);                

                    foreach (var i in In_Param)
                    {
                        cmd.Parameters.AddWithValue(i.ProcedureParam,i.InputParam);
                    }
                    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(cmd.Parameters[Out_Msg].Value.ToString(), "요청 처리 내역");
                }

        }
    }
}
