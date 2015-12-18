using System.Collections.Generic;

namespace Airline.Business
{
    public class Aircrew
    {
        public List<Aircrew> List { get; set; }
        public int CrewID { get; set; }

       public void ShowList()
        {
            List.ToString();
        }
    }
}