using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Business
{
    class Flight
    {
        static private int counter;
        public int Id { get; set; }
        public string FlightName { get; set; }
        public DateTime  Date { get; set; }
      
        //public string Crew { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public int SeatTotal { get; set; }
        public decimal BusinessPrice { get; set; }
        public int BusinessSeatTotal { get; set; }
        public int BuinsessSeatAvai { get; set; }
        public decimal EconomyPlusPrice { get; set; }
        public int EconomyPlusSeatTotal { get; set; }
        public int EconomyPlusSeatAvai { get; set; }
        public decimal EconomyPrice { get; set; }
        public int EconomySeatTotal { get; set; }
        public int EconomySeatAvai { get; set; }


        public List<Aircrew> CrewList { get; set; }
        public List<Seat> SeatList { get; set; }
        public Seat[] seats;


        public Flight() { }

        public Flight(int id,string flightName,DateTime date, string destination , string departure, int businessSeatTotal, decimal businessPrice, int economyPlusSeatTotal, decimal economyPlusPrice, int economySeatTotal, decimal economyPrice)
        {
            {
                counter++;
                Id = counter;
                Departure = departure;
                Destination = destination;
                Date = date;

                SeatTotal = businessSeatTotal + economyPlusSeatTotal + economySeatTotal;
                BusinessPrice = businessPrice;
                BusinessSeatTotal = businessSeatTotal;
                BuinsessSeatAvai = businessSeatTotal;
                EconomyPlusPrice = economyPlusPrice;
                EconomyPlusSeatTotal = economyPlusSeatTotal;
                EconomyPlusSeatAvai = economyPlusSeatTotal;
                EconomyPrice = economyPrice;
                EconomySeatTotal = economySeatTotal;
                EconomySeatAvai = economySeatTotal;

                //CrewList = ;
                //SeatList = ;
                seats = new Seat[SeatTotal];
            }
        }


     
    
    }

}
