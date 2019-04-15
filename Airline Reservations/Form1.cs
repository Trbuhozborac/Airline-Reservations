using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservations
{
    public partial class frmReservations : Form
    {
        public static List<Passenger> passengers;
        private Passenger passenger;
        public static List<Passenger> foundPassengers;


        public frmReservations()
        {
            InitializeComponent();
            passenger = new Passenger();
            passengers = new List<Passenger>();
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmReservations_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            //validate input
            if (!passenger.IsValidPassenger(txtName.Text, mtbSeatRow.Text, mtbSeatCol.Text))
            {
                MessageBox.Show(Passenger.ErrorMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if input corect, create a passenger object
            passenger = new Passenger(txtName.Text, mtbSeatRow.Text, mtbSeatCol.Text); 

            //check if the plane is full
            if(passenger.NumberOfSeatedPassengers() == 40)
            {
                var msg = MessageBox.Show("The plane is full. Place passenger on the writing list?", "Plane full",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (msg == DialogResult.Yes)
                    passenger.AddPassenger(new Passenger(passenger.Name, true));

                return;
            }

            //check if the seat is taken
            if(passenger.IsSeatTaken(passenger.SeatRow.ToString(), passenger.SeatColumn))
            {
                MessageBox.Show("The seat is taken. Please select a different seat", "Seat Taken",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            //add the passenger
            passenger.AddPassenger(passenger);
            PopulateAirplane();
        }

        private void btnDeletePessenger_Click(object sender, EventArgs e)
        {
            //enter name and validate it
            var name = txtName.Text.Trim();
            
            if (name == "")
            {
                MessageBox.Show("Please enter passenger's name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if valid input, create passenger that matches the name of passenger to be deleted
            // search for passenger to delete
            var passenger = new Passenger(name);
            foundPassengers = passenger.GetPassengersByName(name);

            //check if no passenger is found
            if(foundPassengers.Count() == 0)
            {
                MessageBox.Show("Passenger " + name +" does not exist", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if passenger exists, open lookup form and display name there
            frmPassengerLookup form = new frmPassengerLookup("delete");
            form.ShowDialog();

            //if user canceleed operation we just return; otherwise we procced to delete passanger
            if (form.isOperationCancelled) return;

            //assign the passenger object to be deleted and populate the text boxes with the details
            passenger = form.passenger;
            txtName.Text = passenger.Name;
            mtbSeatRow.Text = passenger.SeatRow.ToString();
            mtbSeatCol.Text = passenger.SeatColumn;

            //ask user to confirm deletion
            var msg = MessageBox.Show("Delete Passenger?", "Delete",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            //if deletes is true 
            if(msg == DialogResult.Yes)
            {
                //delete passenger from list
                passenger.RemovePassenger(passenger);

                //check if anyone is on waitng list and move the first passenger from wait list
                if(passenger.NumberOfSeatedPassengers() == 39 && passenger.NumberOfWaitingPassengers() > 0)
                {
                    var index = passengers.FindIndex(p => p.IsOnWaitingList == true);

                    passengers[index].SeatRow = Convert.ToInt32(mtbSeatRow.Text);
                    passengers[index].SeatColumn = mtbSeatCol.Text;

                    //remove that passenger from the waiting list
                    passengers[index].IsOnWaitingList = false;

                    //display massege that we are removed passenger from the lsit
                    MessageBox.Show("Passenger " + txtName.Text + " was removed from the list" + Environment.NewLine +
                        passengers[index].Name + " was moved from the waiting list to seat " +
                        mtbSeatRow.Text + mtbSeatCol.Text, "Passengers Removed/Moved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                //clear form and upade the seating chart
                ClearForm();
                PopulateAirplane();

            }
        }

        private void btnShowPassengers_Click(object sender, EventArgs e)
        {
            //display all passenger in lookup form
            frmPassengerLookup form = new frmPassengerLookup("view");
            form.ShowDialog();

            //must open it in viewOnly mode
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            mtbSeatRow.Text = "";
            mtbSeatCol.Text = "";
        }

        private void PopulateAirplane()
        {
            //delete previes seating chart and create passenger object
            lstOutput.Items.Clear();
            passenger = new Passenger();

            //crate a 2d array of all passengers sorted by the seat (row and column)
            string[,] sortedPassengers = new string[10, 4];


            //loop through the seating charts rows and colums
            for(int i = 0; i < 10; i++)
            {
                var output = ""; //create a string for the whole seating chart
                var col = ""; //create a string for the column letters
                for(int c = 0; c < 4; c++)
                {
                    if (c == 0)
                        col = "A";
                    else if (c == 1)
                        col = "B";
                    else if (c == 2)
                        col = "C";
                    else
                        col = "D";

                    //if seat is taken constuct the ouput to contain the row number and column letter
                    if (passenger.IsSeatTaken((i + 1).ToString(), col))
                    {
                        if (i + 1 < 10)
                            output += "0" + (i + 1).ToString() + col + "   ";
                        else
                            output += (i + 1).ToString() + col + "   ";
                    }
                    else //seat is empty/ mark it as X
                    {
                        output += "XXX   ";

                        output += (c == 1 ? "    " : "");
                    }
                }

                //add seating information for the row
                lstOutput.Items.Add(output);
                lstOutput.Items.Add("");

            }
        }

    }
}
