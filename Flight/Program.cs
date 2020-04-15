using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingNamespace
{
    public class Flight
    {
        private string flightID;
        private string airplane;
        private string takeOffPort;
        private string destPort;
        private string date;
        private int numOfPass;
        private int numOfRows;
        private char[] seats = { 'A', 'B', 'C', 'D', 'E', 'F' };
        private string stopover = null;
        private bool mealProvided = false;
        private int[,] seatingBooked;
        private Passenger[] passengers;

        public Flight() { }

        public Flight(string flightID, string airplane, string takeOffPort, string destPort, string date, int numOfRows, string mealProvided)
        {
            this.flightID = flightID;
            this.airplane = airplane;
            this.takeOffPort = takeOffPort;
            this.destPort = destPort;
            this.date = date;
            this.numOfRows = numOfRows;
            this.numOfPass = seats.Length * numOfRows;
            this.passengers = new Passenger[numOfPass];

            if (mealProvided.ToUpper() == "YES")
            {
                this.mealProvided = true;
            }

            seatingBooked = new int[numOfRows, seats.Length];
        }

        public Flight(string flightID, string airplane, string takeOffPort, string destPort, string date, int numOfRows, string stopover, string mealProvided)
        {
            this.flightID = flightID;
            this.airplane = airplane;
            this.takeOffPort = takeOffPort;
            this.destPort = destPort;
            this.date = date;
            this.numOfRows = numOfRows;
            this.stopover = stopover;
            this.numOfPass = seats.Length * numOfRows;
            this.passengers = new Passenger[numOfPass];

            if (mealProvided.ToUpper() == "YES")
            {
                this.mealProvided = true;
            }

            seatingBooked = new int[numOfRows, seats.Length];
        }

        public void setFlightID(string flightID)
        {
            this.flightID = flightID;
        }

        public void setAirplane(string airplane)
        {
            this.airplane = airplane;
        }

        public void setTakeOffPort(string takeOffPort)
        {
            this.takeOffPort = takeOffPort;
        }
        public void setDestPort(string destPort)
        {
            this.destPort = destPort;
        }
        public void setDate(string date)
        {
            this.date = date;
        }
        public void setStopover(string stopover)
        {
            this.stopover = stopover;
        }
        public void setNumOfRows(int numOfRows)
        {
            this.numOfRows = numOfRows;
        }
        public void setNumOfPass(int numOfPass)
        {
            this.numOfPass = numOfPass;
        }
        public void setSeats(char[] seats)
        {
            this.seats = seats;
        }
        public void setMeal(string mealProvided)
        {
            if (mealProvided.ToUpper() == "YES")
            {
                this.mealProvided = true;
            }
            else if (mealProvided.ToUpper() == "NO")
            {
                this.mealProvided = false;
            }
        }
        public string getFlightID()
        {
            return flightID;
        }
        public string getAirplane()
        {
            return airplane;
        }
        public string getTakeOffPort()
        {
            return takeOffPort;
        }
        public string getDestPort()
        {
            return destPort;
        }
        public string getDate()
        {
            return date;
        }
        public string getStopover()
        {
            return stopover;
        }
        public string getMealProvided()
        {
            if (this.isMealProvided())
                return "Yes";
            return "No";
        }
        public int getNumOfPass()
        {
            return numOfPass;
        }
        public int getNumOfRows()
        {
            return numOfRows;
        }
        public char[] getSeats()
        {
            return seats;
        }
        public int[,] getSeatsBooked()
        {
            return seatingBooked;
        }
        public bool isMealProvided()
        {
            if (mealProvided)
                return true;
            else
                return false;
        }
        public void setPassengers(int numOfPass)
        {
            passengers = new Passenger[numOfPass];
        }
        public Passenger[] getPassengers()
        {
            return passengers;
        }
        public bool isFreeSeat(int numOfRow, char seat)
        {
            int numSeat = Array.LastIndexOf(seats, seat);

            if (seatingBooked[numOfRow, numSeat] == 0)
            {
                return true;
            }

            return false;
        }
        public void bookSeat(int numOfRow, char seat, Passenger passenger)
        {
            int numSeat = Array.LastIndexOf(seats, seat);

            seatingBooked[numOfRow, numSeat] = 1;

            for (int i = 0; i < passengers.Length; i++)
            {
                if (passengers[i] == null)
                {
                    passengers[i] = passenger;
                    break;
                }
            }
        }
        public void removeSeat(int numOfRow, char seat, Passenger passenger)
        {
            int numSeat = Array.LastIndexOf(seats, seat);

            int index = Array.LastIndexOf(passengers, passenger);
            passengers[index] = null;

            seatingBooked[numOfRow, numSeat] = 0;
        }
        public static Flight searchFlightID(Flight[] flights, string flightID)
        {
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].getFlightID() == flightID)
                {
                    return flights[i];
                }
            }
            return null;
        }

        public static Flight searchFlightDate(Flight[] flights, string date)
        {
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].getDate() == date)
                {
                    return flights[i];
                }
            }
            return null;
        }

        public override string ToString()
        {
            return "\t" + this.flightID + " " + this.takeOffPort + "-" + this.destPort + " " + this.date + "\t\n";
        }
    }

    public class Passenger
    {
        private string firstName;
        private string lastName;
        private string typeOfTicket;
        private string date;
        private string seat;
        private char seatLetter;
        private int numOfRow;
        private int ticketNumber;
        private Flight flight;

        private static int allTickets = 0;

        public Passenger() { }

        public Passenger(string firstName, string lastName, string typeOfTicket)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.typeOfTicket = typeOfTicket;

            allTickets++;
            this.TicketNumber = allTickets;
        }

        public Passenger(string firstName, string lastName, string typeOfTicket, char seatLetter, int numOfRow, Flight flight, string date)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.typeOfTicket = typeOfTicket;
            this.flight = flight;
            this.Date = date;
            this.SeatLetter = seatLetter;
            this.NumOfRow = numOfRow;
            this.seat = numOfRow.ToString() + " " + seatLetter.ToString();

            flight.bookSeat(numOfRow, seatLetter, this);

            allTickets++;
            this.TicketNumber = allTickets;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string TypeOfTicket { get => typeOfTicket; set => typeOfTicket = value; }
        public char SeatLetter { get => seatLetter; set => seatLetter = value; }
        public int NumOfRow { get => numOfRow; set => numOfRow = value; }
        public string Date { get => date; set => date = value; }
        public int TicketNumber { get => ticketNumber; set => ticketNumber = value; }

        public void setSeat()
        {
            seat = numOfRow.ToString() + " " + seatLetter.ToString();
        }
        public string getSeat()
        {
            return numOfRow.ToString() + " " + seatLetter.ToString(); ;
        }
        public void setFlight(Flight flight)
        {
            this.flight = flight;
            flight.bookSeat(numOfRow, seatLetter, this);
        }
        public Flight getFlight()
        {
            return flight;
        }

        public override string ToString()
        {
            return "\t" + "Ticket number: " + ticketNumber + "\t\n"
                + "\t" + this.firstName + " " + this.lastName + "\t\n"
                + "\t" + typeOfTicket + "\t\n"
                + "\t" + this.flight.getTakeOffPort() + "-" + this.flight.getDestPort() + "\t\n"
                + "\t" + "Date: " + date + "\t\n"
                + "\t" + "Seat: " + seat + "\t";
        }
    }
}
