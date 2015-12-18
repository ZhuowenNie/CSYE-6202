using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline.dataAccess;
using System.Data;

namespace Airline.Business
{
    public class CustomerBusiness
    {
        List<Customer> list = new List<Customer>();
        static private CustomerBusiness _instance;
        DA da = new dataAccess.DA();
        public CustomerBusiness()
        {
            list = new List<Customer>();
        }

        public int IsUserExist(string loginName, string password)
        {
            string s = "select count(*) from customer where loginName='" + loginName + "' and password='" + password + "'";
            int i = (int)da.ExecuteSql1(s, CommandType.Text, null, null);
            return i;
        }
        //public int getloginName()
        //{
        //    Customer c = new Customer();
        //    string ln = "select loginName from customer";
        //    int i = (int)da.ExecuteSql1(ln, CommandType.Text, null, null);
        //    return i;
          
        //}
        public void AddCustomer(string cid,string loginName,string password,string email)
        {
            Customer c = new Customer();
            c.Cid = cid;
            c.LoginName = loginName;
            c.Password = password;
            c.Email = email;
            list.Add(c);    
        } 


    }
}
