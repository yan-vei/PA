using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BookingNamespace;

namespace PA
{

    public partial class Form1 : Form
    {
        private Flight[] allFlights = new Flight[100];
        private Passenger[] allPassengers = new Passenger[100];
        private int numOfPassengers = 0;
        private int numOfFlights = 0;
        private bool bookingSuccessful = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void loadFlights()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string fileName = @"\Flights.csv";
            path += fileName;
            var flightsInfo = new StreamReader(File.OpenRead(path));

            List<string> flightIds = new List<String>();
            List<string> airplanes = new List<String>();
            List<string> takeOffPorts = new List<String>();
            List<string> destPorts = new List<String>();
            List<string> dates = new List<String>();
            List<string> stopovers = new List<String>();
            List<string> numOfRows = new List<String>();
            List<string> mealProvided = new List<String>();

            while (!flightsInfo.EndOfStream)
            {
                string line = flightsInfo.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');
                    flightIds.Add(values[0]);
                    airplanes.Add(values[1]);
                    takeOffPorts.Add(values[2]);
                    destPorts.Add(values[3]);
                    dates.Add(values[4]);
                    stopovers.Add(values[5]);
                    numOfRows.Add(values[6]);
                    mealProvided.Add(values[7]);
                }
            }

            string[] flightID = flightIds.ToArray();
            string[] airplane = airplanes.ToArray();
            string[] takeOffPort = takeOffPorts.ToArray();
            string[] destPort = destPorts.ToArray();
            string[] date = dates.ToArray();
            string[] stopover = stopovers.ToArray();
            string[] numOfRow = numOfRows.ToArray();
            string[] meal = mealProvided.ToArray();

            for (int i = 0; i < flightID.Length; i++)
            {
                int rows = Convert.ToInt32(numOfRow[i]);
                allFlights[numOfFlights] = new Flight(flightID[i], airplane[i], takeOffPort[i], destPort[i], date[i], rows, meal[i]);
                numOfFlights++;
            }

            flightsInfo.Close();
        }

        public void updateFlights()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string fileName = @"\Flights.csv";
            path += fileName;

            var csvFlights = new StringBuilder();
            string[] flightData = new string[8];

            for (int i = 0; i < allFlights.Length; i++)
            {
                if (allFlights[i] == null)
                {
                    break;
                }

                flightData[0] = allFlights[i].getFlightID();
                flightData[1] = allFlights[i].getAirplane();
                flightData[2] = allFlights[i].getTakeOffPort();
                flightData[3] = allFlights[i].getDestPort();
                flightData[4] = allFlights[i].getDate();
                flightData[5] = allFlights[i].getStopover();
                flightData[6] = allFlights[i].getNumOfRows().ToString();
                flightData[7] = allFlights[i].getMealProvided();

                var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", flightData[0], flightData[1],
                    flightData[2], flightData[3], flightData[4], flightData[5], flightData[6], Environment.NewLine);
                csvFlights.Append(newLine);
            }

            File.WriteAllText(path, csvFlights.ToString());
        }

        public void reportPassengers()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string fileName = @"\Passengers.csv";
            path += fileName;

            var csvPassengers = new StringBuilder();
            string[] passData = new string[7];

            for (int i = 0; i < allPassengers.Length; i++)
            {
                if (allPassengers[i] == null)
                {
                    break;
                }
                int numOfRow = allPassengers[i].NumOfRow + 1;

                passData[0] = allPassengers[i].FirstName;
                passData[1] = allPassengers[i].LastName;
                passData[2] = allPassengers[i].TypeOfTicket;
                passData[3] = allPassengers[i].Date;
                passData[4] = numOfRow.ToString() + " " + allPassengers[i].SeatLetter.ToString();
                passData[5] = allPassengers[i].getFlight().getFlightID();
                passData[6] = allPassengers[i].TicketNumber.ToString();

                var newLine = string.Format("{0} {1},{2},{3},{4},{5},#{6}", passData[0], passData[1],
                    passData[2], passData[3], passData[4], passData[5], passData[6], Environment.NewLine);
                csvPassengers.Append(newLine);
            }

            File.WriteAllText(path, csvPassengers.ToString());
        }

        private bool[] checkBookingAvailability(char seatForBooking, int chosenRow, string flightDate, string flightChosen)
        {
            bool[] availability = new bool[2]; // 0 - flight itself, 1 - seat

            string[] airports = flightChosen.Split('-');
            string takeOffPort = airports[0];
            string destPort = airports[1];

            for (int i = 0; i < allFlights.Length; i++)
            {
                if (allFlights[i] == null)
                {
                    MessageBox.Show("No such flight exists!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                if (allFlights[i].getDate() == flightDate && allFlights[i].getTakeOffPort() == takeOffPort
                    && allFlights[i].getDestPort() == destPort)
                {
                    availability[0] = true;
                    if (allFlights[i].isFreeSeat(chosenRow, seatForBooking))
                    {
                        availability[1] = true;
                        break;
                    }
                    else
                    {
                        availability[1] = false;
                        break;
                    }
                }
                else
                {
                    availability[0] = false;
                }
            }

            return availability;
        }

        private void checkSeatButton_Click(object sender, EventArgs e)
        {
            int chosenRow = rowBox.SelectedIndex;
            int seat = seatBox.SelectedIndex;
            int flight = flightsBox.SelectedIndex;

            if (chosenRow == -1 || flight == -1 || seat == -1)
            {
                MessageBox.Show("You chose an invalid seat!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                string chosenSeat = seatBox.Items[seatBox.SelectedIndex].ToString();
                string flightChosen = flightsBox.Items[flightsBox.SelectedIndex].ToString();
                string flightDate = dateBox.SelectionRange.Start.ToShortDateString(); // format: DD.MM.YYYY
                char seatForBooking = chosenSeat[0];

                bool[] availability = checkBookingAvailability(seatForBooking, chosenRow, flightDate, flightChosen);

                if (!availability[0])
                {
                    MessageBox.Show("There is no available flight", "Flight not available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (availability[1])
                {
                    MessageBox.Show("The seat is free!", "Available flight", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!availability[1] && availability[0])
                {
                    MessageBox.Show("The seat is taken!", "Flight not available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Invalid input!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void bookFlight(int chosenRow, char seatForBooking, string flightDate, string flightChosen, string fname, string lname, string typeOfBooking)
        {
            bool[] availability = checkBookingAvailability(seatForBooking, chosenRow, flightDate, flightChosen);
            string[] airports = flightChosen.Split('-');
            string takeOffPort = airports[0];
            string destPort = airports[1];

            if (availability[0] && availability[1])
            {
                for (int i = 0; i < allFlights.Length; i++)
                {
                    if (allFlights[i] == null)
                    {
                        break;
                    }
                    if (allFlights[i].getDate() == flightDate && allFlights[i].getTakeOffPort() == takeOffPort
                        && allFlights[i].getDestPort() == destPort)
                    {
                        allPassengers[numOfPassengers] = new Passenger(fname, lname, typeOfBooking, seatForBooking, chosenRow, allFlights[i], flightDate);
                        allFlights[i].bookSeat(chosenRow, seatForBooking, allPassengers[numOfPassengers]);
                        break;
                    }
                }
                numOfPassengers++;
                bookingSuccessful = true;
            }
            else
            {
                bookingSuccessful = false;
            }
        }

        private void booking_Click(object sender, EventArgs e)
        {
            int chosenRow = rowBox.SelectedIndex;
            int seat = seatBox.SelectedIndex;
            int flight = flightsBox.SelectedIndex;
            string flightDate = dateBox.SelectionRange.Start.ToShortDateString();
            string fname = fnameBox.Text;
            string lname = lnameBox.Text;
            string typeOfBooking = "One-way";

            try
            {
                if (chosenRow == -1 || flight == -1 || seat == -1 || fname.Length < 1 || lname.Length < 1)
                {
                    MessageBox.Show("You didn't fill all the fields", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw new ArgumentOutOfRangeException();
                }

                string chosenSeat = seatBox.Items[seatBox.SelectedIndex].ToString();
                string flightChosen = flightsBox.Items[flightsBox.SelectedIndex].ToString();
                char seatForBooking = chosenSeat[0];

                if (twoWayButton.Checked == true)
                {
                    typeOfBooking = "Two-way";
                    string[] flightBack = flightChosen.Split('-');
                    string takeOffPort = flightBack[1];
                    string destPort = flightBack[0];
                    string chosenFlight = takeOffPort + "-" + destPort;
                    string flightBackDate = dateBox2.SelectionRange.Start.ToShortDateString();
                    bookFlight(chosenRow, seatForBooking, flightBackDate, chosenFlight, fname, lname, typeOfBooking);
                }
                bookFlight(chosenRow, seatForBooking, flightDate, flightChosen, fname, lname, typeOfBooking);
                if (bookingSuccessful)
                {
                    MessageBox.Show("Booking successful", "Booking Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Booking cannot be completed", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Invalid input!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string[] getFlightInput()
        {
            string[] flightData = new string[8];

            flightData[0] = flightIDBox.Text;
            flightData[1] = takeOffPortBox.Text;
            flightData[2] = destPortBox.Text;
            flightData[3] = stopoverBox.Text;
            flightData[4] = airplaneBox.Text;
            flightData[5] = numOfRowsBox.Text;
            flightData[6] = mealProvidedBox.Text;
            flightData[7] = flightDateBox.SelectionRange.Start.ToShortDateString();

            if (flightData[0].Length < 5 || flightData[1].Length < 5 || flightData[2].Length < 5 
                || flightData[4].Length < 5 || flightData[5].Length < 2 || flightData[6].Length < 2)
            {
                MessageBox.Show("Fill all the fields (only stopover field is unnecessary)", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flightData;
        }

        private void createFlight()
        {
            string[] flightData = getFlightInput();

            for (int i = 0; i < flightData.Length; i++)
            {
                if (flightData[i] == "" && i != 3)
                {
                    MessageBox.Show("Invalid input!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                else if (i == flightData.Length-1)
                {
                    Flight newFlight = new Flight(flightData[0], flightData[4], flightData[1], flightData[2], flightData[7], Int32.Parse(flightData[5]), flightData[3], flightData[6]);
                    allFlights[numOfFlights] = newFlight;
                    numOfFlights++;
                    MessageBox.Show("Flight created successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void editFlight()
        {
            string[] flightData = getFlightInput();
            bool flightFound = false;

            for (int i = 0; i < allFlights.Length; i++)
            {
                if (allFlights[i].getFlightID() == flightData[0])
                {
                    allFlights[i].setAirplane(flightData[4]);
                    allFlights[i].setStopover(flightData[3]);
                    allFlights[i].setMeal(flightData[6]);
                    allFlights[i].setTakeOffPort(flightData[1]);
                    allFlights[i].setDestPort(flightData[2]);
                    allFlights[i].setDate(flightData[7]);
                    allFlights[i].setNumOfRows(Int32.Parse(flightData[5]));
                    MessageBox.Show("Flight updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flightFound = true;
                    break;
                }
            }

            if (!flightFound)
            {
                MessageBox.Show("No flight found to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteFlight()
        {
            string flightID = flightIDBox.Text;
            bool flightFound = false;

            for (int i = 0; i < allFlights.Length; i++)
            {
                try
                {
                    if (allFlights[i].getFlightID() == flightID)
                    {
                        allFlights[i] = allFlights[numOfFlights];
                        allFlights[numOfFlights] = null;
                        numOfFlights--;
                        MessageBox.Show("Flight deleted successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flightFound = true;
                        break;
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Enter the flight ID!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }

            if (!flightFound)
            {
                MessageBox.Show("No flight found to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void flightChange_Click(object sender, EventArgs e)
        {
            int selectedOpt = flightOptList.SelectedIndex;

            switch (selectedOpt)
            {
                case 0:
                    createFlight();
                    break;
                case 1:
                    editFlight();
                    break;
                case 2:
                    deleteFlight();
                    break;
            }
        }

        private void flightsInfo_Click(object sender, EventArgs e)
        {
            string flightsInfo = "";

            for (int i = 0; i < allFlights.Length; i++)
            {
                if (allFlights[i] == null)
                {
                    break;
                }
                string flightID = allFlights[i].getFlightID();
                string toPort = allFlights[i].getDestPort();
                string fromPort = allFlights[i].getTakeOffPort();
                string date = allFlights[i].getDate();

                flightsInfo += String.Format("{0, -10} {1, 50} {2, 55} {3, 45}", date, fromPort, toPort, flightID) + "\r\n";
            }

            allFlightsInfo.Text = flightsInfo;
        }
        
        private void Form1_Shown(object sender, EventArgs e)
        {
            loadFlights();
        }

        private void passBox_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allPassengers.Length; i++)
            {
                if (allPassengers[i] == null)
                {
                    break;
                }
                string passengerName = allPassengers[i].FirstName + " " + allPassengers[i].LastName;
                int index = passBox.FindString(passengerName);
                if (index == -1)
                { 
                passBox.Items.Add(passengerName);
                }
            }
        }

        private void passBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string passenger = passBox.Items[passBox.SelectedIndex].ToString();
            string[] name = passenger.Split(' ');
            string firstName = name[0];
            string lastName = name[1];

            for (int i = 0; i < allPassengers.Length; i++)
            {
                if (allPassengers[i] == null)
                {
                    break;
                }

                if (allPassengers[i].FirstName.ToUpper() == firstName && allPassengers[i].LastName.ToUpper() == lastName)
                {
                    int numOfRow = allPassengers[i].NumOfRow + 1;
                    string information = "Name: " + allPassengers[i].FirstName + " " + allPassengers[i].LastName + "\n"
                        + "Ticket number: " + allPassengers[i].TicketNumber + "\n"
                        + "Type of ticket: " + allPassengers[i].TypeOfTicket + "\n"
                        + "Flight: " + allPassengers[i].getFlight() + "\n"
                        + "Seat: " + numOfRow.ToString() + " " + allPassengers[i].SeatLetter.ToString();
                    MessageBox.Show(information, "Passenger Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void flights_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allFlights.Length; i++)
            {
                if (allFlights[i] == null)
                {
                    break;
                }
                string flightName = allFlights[i].getTakeOffPort() + "-" + allFlights[i].getDestPort();
                int index = flightsBox.FindString(flightName);
                if (index == -1)
                {
                    flightsBox.Items.Add(flightName);
                }
            }
        }

        private void flightOptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedOpt = flightOptList.SelectedIndex;

            switch (selectedOpt)
            {
                case 2:
                    takeOffPortBox.Enabled = false;
                    destPortBox.Enabled = false; 
                    stopoverBox.Enabled = false;
                    airplaneBox.Enabled = false;
                    numOfRowsBox.Enabled = false;
                    mealProvidedBox.Enabled = false;
                    break;

                default:
                    takeOffPortBox.Enabled = true;
                    destPortBox.Enabled = true;
                    stopoverBox.Enabled = true;
                    airplaneBox.Enabled = true;
                    numOfRowsBox.Enabled = true;
                    mealProvidedBox.Enabled = true;
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateFlights();
            reportPassengers();
            MessageBox.Show("All updates have been saved!", "Update message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void twoWayButton_CheckedChanged(object sender, EventArgs e)
        {
            dateBox2.Enabled = true;
        }

        private void rowBox_Click(object sender, EventArgs e)
        {
            int rows = 0;

            try
            {
                string flightChosen = flightsBox.Items[flightsBox.SelectedIndex].ToString();
                string[] airports = flightChosen.Split('-');
                string takeOffPort = airports[0];
                string destPort = airports[1];

                for (int i = 0; i < allFlights.Length; i++)
                {
                    if (allFlights[i] == null)
                    {
                        break;
                    }
                    if (allFlights[i].getDestPort() == destPort && allFlights[i].getTakeOffPort() == takeOffPort)
                    {
                        rows = allFlights[i].getNumOfRows();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Choose flight first!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            for (int j = 1; j <= rows; j++)
            {
                string rowItem = j.ToString();
                int index = passBox.FindString(rowItem);
                if (index == -1)
                {
                    rowBox.Items.Add(rowItem);
                }
            }

        }

        private void label22_Click(object sender, EventArgs e)
        {
            string aboutInfo = "Version 1.0 \t\n The program allows you to book flights, create, edit and delete them and to manipulate passengers' data";
            MessageBox.Show(aboutInfo, "About the program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fnameBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!fnameBox.Text.All(char.IsLetter))
            {
                MessageBox.Show("Invalid name!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnameBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!lnameBox.Text.All(char.IsLetter))
            {
                MessageBox.Show("Invalid name!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
