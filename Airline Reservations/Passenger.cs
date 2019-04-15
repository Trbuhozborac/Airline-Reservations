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

        public bool IsValidPassenger(string name, string row, string column)
        {
            if (name.Trim().Equals(""))
            {
                ErrorMessage = "Name is Required!";
                return false;
            }

            int validRow;
            if (!int.TryParse(row, out validRow) || validRow < 1 || validRow > 10)
            {
                ErrorMessage = "Valid Seat Row is Required!";
                return false;
            }

            if (column.ToUpper() != "A" && column.ToUpper() != "B" && column.ToUpper() != "C" && column.ToUpper() != "D")
            {
                ErrorMessage = "Valid Seat Column is Required!";
                return false;
            }

            return true;
        }

        public bool IsSeatTaken(string seatRow, string seatColumn)
        {
            var isTaken = frmReservations.passengers.Where(p => p.SeatRow == Convert.ToInt32(seatRow) &&
                                                                p.SeatColumn.ToUpper() == seatColumn.ToUpper()).Count();

            return isTaken == 0 ? false : true;
        }

        public List<Passenger> GetPassengersByName(string name)
        {
            return frmReservations.passengers.Where(p => p.Name == name).ToList();
        }

        public void AddPassenger(Passenger passenger)
        {
            frmReservations.passengers.Add(passenger);
        }

        public void RemovePassenger(Passenger passenger)
        {
            frmReservations.passengers.Remove(passenger);
        }

        public int NumberOfSeatedPassengers()
        {
            return frmReservations.passengers.Where(p => p.IsOnWaitingList == false).Count();
        }

        public int NumberOfWaitingPassengers()
        {
            return frmReservations.passengers.Where(p => p.IsOnWaitingList == true).Count();
        }
    }
}
