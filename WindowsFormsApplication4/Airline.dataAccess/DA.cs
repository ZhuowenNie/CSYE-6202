using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.dataAccess
{
    public class DA
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataSet ds;
        public DA()
        {
            string conStr = "server=localhost\\sqlexpress;Integrated Security=SSPI;uid=sa;pwd=sa;database=AirlineSystem";
            //string conStr = ConfigurationManager.ConnectionStrings["ExampleConnectionString"].ConnectionString;
            con = new SqlConnection(conStr);
            cmd = con.CreateCommand();
        }
        public int ExecuteSql(string sqlText, CommandType commandType, string[] paras, object[] values)//增删改
        {
            con.Open();
            cmd.CommandType = commandType;
            cmd.CommandText = sqlText;
            if (paras != null)
            {
                int d = paras.Length;
                for (int i = 0; i < d; i++)
                    cmd.Parameters.AddWithValue(paras[i], values[i]);
            }
            int count = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Close();
            return count;
        }
        public object ExecuteSql1(string sqlText, CommandType commandType, string[] paras, string[] values)//查询一个值
        {
            con.Open();
            cmd.CommandType = commandType;
            cmd.CommandText = sqlText;
            if (paras != null)
            {
                int d = paras.Length;
                for (int i = 0; i < d; i++)
                    cmd.Parameters.AddWithValue(paras[i], values[i]);
            }
            object count = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            con.Close();
            return count;
        }
        public DataSet ExecuteSql2(string sqlText, CommandType commandType, string tableName, string[] paras, string[] values)//查询多个值
        {
            sda = new SqlDataAdapter();
            ds = new DataSet();
            cmd.CommandType = commandType;
            cmd.CommandText = sqlText;
            if (paras != null)
            {
                int d = paras.Length;
                for (int i = 0; i < d; i++)
                    cmd.Parameters.AddWithValue(paras[i], values[i]);
            }
            sda.SelectCommand = cmd;
            sda.Fill(ds, tableName);
            cmd.Parameters.Clear();
            return ds;
        }
    }
}
