using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline.dataAccess;

namespace Airline.Business
{
    class FlightOrder
    {
        public string Fno { get; set; }
        public DateTime Date { get; set; }
        public Flight Flight { get; set; }
        public decimal Price { get; set; }

        public string Status { get; set; }
        public string Carrier { get; set; }
        public Seat Seat { get; set; }
        public FlightOrder() { }
        public FlightOrder(string fno, DateTime date, Flight flight,decimal price,string status,string carrier,Seat seat)
        {
            Fno = fno;
            Date = date;
            Flight = flight;
            Price = price;
            Status = status;
            Carrier = carrier;
            Seat = seat;
        }
        public void AddCustomer(string cid, string loginName, string password, string email)
        {
            Customer c = new Customer();
            c.Cid = cid;
            c.LoginName = loginName;
            c.Password = password;
            c.Email = email;         
        } 
       
    }
}
