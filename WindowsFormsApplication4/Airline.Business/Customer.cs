using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Business
{
    class Customer:ICustomer
    {
        public string Cid { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Carrier { get; set; }
        public string Email { get; set; }
      
       
        public SeatType SeatType { get; set; }

        public FlightOrder FlightOrder { get; set; }
        public override string ToString()
        {
            return string.Format("Cid: {0}, LoginName: {1},Password:{2}, Carrier: {3},Email: {4},SeatType: {5}", Cid, LoginName, Password, Carrier, Email, SeatType);
        }
        //public virtual string UpdateCustomer(string loginName, string password, string email)
        //{
        //    LoginName = loginName;
        //    Password = password;
        //    Email = email;

        //    return "Person info updated";
        //}
        //public virtual string UpdateCustomer(int id, string carrier, string price)
        //{
        //    Carrier = carrier;
        //    Price = price;
        //    return "credit card info updated";
        //}
        
    }
}
