using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline.dataAccess;
using System.Data;

namespace Airline.Business
{
    public class FlightBusiness
    {
        
        List<Customer> list = new List<Customer>();
        static private CustomerBusiness _instance;
        DA da = new dataAccess.DA();
        public FlightBusiness()
        {
            list = new List<Customer>();
        }
        public DataSet GetFlightInfo(string destination,string departure,DateTime date)
        {
            string s = "select * from flight where departure='" +departure  + "' and destination='" + destination + "' and date='" + date.ToShortDateString() + "'";
            DataSet ds = da.ExecuteSql2(s, CommandType.Text, "e", null, null);
            return ds;
        }
        public DataSet GetFlightAllInfo()
        {
            string s = "select * from Flight";
            DataSet ds = da.ExecuteSql2(s, CommandType.Text, "e", null, null);
            return ds;
        }
        public int InsertFlight(string fname, DateTime date, string crew, string destination,string departure,string price)
        {
            string s = "insert into flight values(@fname, @date, @crew,@destination,@departure, @price)";
            string[] paras = { "@fname", "@date", "@crew", "@destination","@departure","@price" };
            object[] values = { fname, date, crew, destination,departure,price };
            int i = da.ExecuteSql(s, CommandType.Text, paras, values);
            return i;
        }

        public int UpdateFlight(string fname, DateTime date, string crew, string destination, string departure, string price)
        {
            string s = "update flight set fname=@fname,date=@date,crew=@crew,destination=@destination,departure=@departure, price=@price where fname=" + fname;
            string[] paras = { "@fname", "@date", "@crew", "@destination", "@departure,@price" };
            object[] values = { fname, date, crew, destination, departure,price };
            int i = da.ExecuteSql(s, CommandType.Text, paras, values);
            return i;
        }
        public int UpdateFlight1(string fname, string crew, string price)
        {
            string s = "update flight set fname=@fname,date=@date,crew=@crew,destination=@destination,departure=@departure, price=@price where fname=" + fname;
            string[] paras = { "@fname", "@crew","@price" };
            object[] values = { fname, crew, price };
            int i = da.ExecuteSql(s, CommandType.Text, paras, values);
            return i;
        }
        public int DeleteFlight(string fname)
        {
            string s = "delete from flight where fname=" + fname;
            int i = da.ExecuteSql(s, CommandType.Text, null, null);
            return i;
        }

    }
}
