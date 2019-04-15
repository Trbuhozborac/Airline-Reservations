namespace Airline_Reservations
{
    partial class frmPassengerLookup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatColumnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOnWaitingListDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passengerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.passengerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.AutoGenerateColumns = false;
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.seatRowDataGridViewTextBoxColumn,
            this.seatColumnDataGridViewTextBoxColumn,
            this.isOnWaitingListDataGridViewCheckBoxColumn});
            this.dgvPassengers.DataSource = this.passengerBindingSource;
            this.dgvPassengers.Location = new System.Drawing.Point(15, 29);
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.Size = new System.Drawing.Size(343, 150);
            this.dgvPassengers.TabIndex = 0;
            this.dgvPassengers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassengers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double Click to Select Passenger";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // seatRowDataGridViewTextBoxColumn
            // 
            this.seatRowDataGridViewTextBoxColumn.DataPropertyName = "SeatRow";
            this.seatRowDataGridViewTextBoxColumn.HeaderText = "SeatRow";
            this.seatRowDataGridViewTextBoxColumn.Name = "seatRowDataGridViewTextBoxColumn";
            // 
            // seatColumnDataGridViewTextBoxColumn
            // 
            this.seatColumnDataGridViewTextBoxColumn.DataPropertyName = "SeatColumn";
            this.seatColumnDataGridViewTextBoxColumn.HeaderText = "SeatColumn";
            this.seatColumnDataGridViewTextBoxColumn.Name = "seatColumnDataGridViewTextBoxColumn";
            // 
            // isOnWaitingListDataGridViewCheckBoxColumn
            // 
            this.isOnWaitingListDataGridViewCheckBoxColumn.DataPropertyName = "IsOnWaitingList";
            this.isOnWaitingListDataGridViewCheckBoxColumn.HeaderText = "IsOnWaitingList";
            this.isOnWaitingListDataGridViewCheckBoxColumn.Name = "isOnWaitingListDataGridViewCheckBoxColumn";
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataSource = typeof(Airline_Reservations.Passenger);
            // 
            // passengerBindingSource1
            // 
            this.passengerBindingSource1.DataSource = typeof(Airline_Reservations.Passenger);
            // 
            // passengerBindingSource2
            // 
            this.passengerBindingSource2.DataSource = typeof(Airline_Reservations.Passenger);
            // 
            // frmPassengerLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 229);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPassengers);
            this.Name = "frmPassengerLookup";
            this.Text = "PessengerLookup";
            this.Load += new System.EventHandler(this.frmPassengerLookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPassengers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatRowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatColumnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOnWaitingListDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource passengerBindingSource;
        private System.Windows.Forms.BindingSource passengerBindingSource1;
        private System.Windows.Forms.BindingSource passengerBindingSource2;
    }
}