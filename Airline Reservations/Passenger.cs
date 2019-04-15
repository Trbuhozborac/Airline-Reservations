using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservations
{
    public class Passenger
    {
        public string Name { get; set; }
        public int SeatRow { get; set; }
        public string SeatColumn  { get; set; }
        public bool IsOnWaitingList { get; set; }
        public static string ErrorMessage { get; set; }

        public Passenger(string name, string seatRow, string seatColumn)
        {
            this.Name = name;
            this.SeatRow = Convert.ToInt32(seatRow);
            this.SeatColumn = seatColumn;
        }

        public Passenger(string name)
        {
            this.Name = name;
        }

        public Passenger(string name, bool onWaitingList)
        {
            this.Name = name;
            this.IsOnWaitingList = onWaitingList;
            
        }

        public Passenger() { }
       

    }
}
