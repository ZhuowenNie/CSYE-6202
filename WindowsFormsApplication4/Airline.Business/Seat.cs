using System;

namespace Airline.Business
{
    public enum SeatType
    {
        Business,
        Economy,
        EconomyPlus,
        None

    }
    public class Seat
    {
        public int SeatId { get; set; }
        public SeatType seatType { get; set; }
        public Passenger passenger { get; set; }
        public decimal Price { get; set; }

        public string FlightName { get; set; }
        public Seat()
        {

        }

        public Seat(int seatId,SeatType seatType,Passenger passenger,string flightName,decimal price)
        {
            SeatId = seatId;
            this.seatType = seatType;
            this.passenger = passenger;
            FlightName = flightName;
            Price = price;
            //this .????
        }
        public void getPassenger(Passenger passenger)
        {
            this.passenger = passenger;
        }

        public void emptyPassenger()
        {
            this.passenger = null;
        }

        public static implicit operator SeatType(Seat v)
        {
            throw new NotImplementedException();
        }
    }

}