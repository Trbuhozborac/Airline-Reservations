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
    public partial class frmPassengerLookup : Form
    {
        // Create passenger object and list of all passenger that are found based on a search from the main form
        private List<Passenger> foundPassengers;
        public Passenger passenger;

        //create variable for mode (delete or view)
        private string viewMode;

        //create variable for cancellation, so no operation is performed
        public bool isOperationCancelled;

        public frmPassengerLookup(string viewMode)
        {
            InitializeComponent();
            foundPassengers = viewMode == "delete" ? frmReservations.foundPassengers : frmReservations.passengers;
            passenger = new Passenger();
            isOperationCancelled = false;
            this.viewMode = viewMode;
        }
        
        //when the form load, sort the passengers by seat row number and column letter
        private void frmPassengerLookup_Load(object sender, EventArgs e)
        {
            foundPassengers = foundPassengers.OrderBy(c => c.SeatColumn).OrderBy(r => r.SeatRow).ToList();
            dgvPassengers.DataSource = foundPassengers;
        }
        //canel the operation, do not do anything just close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            isOperationCancelled = true;
            this.Close();
        }

        // when user clicks the name in the grid view bound it with passenger object 
        private void dgvPassengers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(viewMode != "view")
            {
                passenger = (Passenger)dgvPassengers.CurrentRow.DataBoundItem;
                Hide();
            }
        }
    }
}
