using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline.dataAccess;
using System.Data;

namespace Airline.Business
{
    public class FlightOrderBusiness
    {
        Flight f = new Flight();
        DA da = new DA();
        

        public DataSet GetOrderInfo(string fno)
        {
            string s = "select * from flightOrder where fno=" + fno;
            DataSet ds = da.ExecuteSql2(s, CommandType.Text, "c", null, null);
            return ds;
        }

        public int Purchase(string fno, DateTime date, string price, string status, string carrier, string seat, string cid)
        {
            string s = "insert into FlightOrder values(@fno,@date,@price,@status,@carrier,@seat,@cid)";
            string[] paras = { "@fno", "@date", "@price", "@status", "@carrier", "@seat", "cid" };
            object[] values = { fno, date, price, status, carrier, seat, cid };
            int i = da.ExecuteSql(s, CommandType.Text, paras, values);
            return i;
        }
      
        //public double Purchase(int p)
        //{
        //    throw new NotImplementedException();
        //}

        //public double Purchase(double p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
