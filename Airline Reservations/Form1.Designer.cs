namespace Airline_Reservations
{
    partial class frmReservations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtbSeatRow = new System.Windows.Forms.MaskedTextBox();
            this.mtbSeatCol = new System.Windows.Forms.MaskedTextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.btnDeletePessenger = new System.Windows.Forms.Button();
            this.btnShowPassengers = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seat:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 20);
            this.txtName.TabIndex = 2;
            // 
            // mtbSeatRow
            // 
            this.mtbSeatRow.Location = new System.Drawing.Point(73, 35);
            this.mtbSeatRow.Mask = "##";
            this.mtbSeatRow.Name = "mtbSeatRow";
            this.mtbSeatRow.Size = new System.Drawing.Size(27, 20);
            this.mtbSeatRow.TabIndex = 3;
            // 
            // mtbSeatCol
            // 
            this.mtbSeatCol.Location = new System.Drawing.Point(106, 35);
            this.mtbSeatCol.Mask = "L";
            this.mtbSeatCol.Name = "mtbSeatCol";
            this.mtbSeatCol.Size = new System.Drawing.Size(27, 20);
            this.mtbSeatCol.TabIndex = 3;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(231, 35);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(167, 264);
            this.lstOutput.TabIndex = 4;
            this.lstOutput.SelectedIndexChanged += new System.EventHandler(this.lstOutput_SelectedIndexChanged);
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Location = new System.Drawing.Point(73, 86);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(137, 27);
            this.btnAddPassenger.TabIndex = 5;
            this.btnAddPassenger.Text = "Add Passenger";
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            this.btnAddPassenger.Click += new System.EventHandler(this.btnAddPassenger_Click);
            // 
            // btnDeletePessenger
            // 
            this.btnDeletePessenger.Location = new System.Drawing.Point(73, 130);
            this.btnDeletePessenger.Name = "btnDeletePessenger";
            this.btnDeletePessenger.Size = new System.Drawing.Size(137, 27);
            this.btnDeletePessenger.TabIndex = 5;
            this.btnDeletePessenger.Text = "Delete Passenger";
            this.btnDeletePessenger.UseVisualStyleBackColor = true;
            this.btnDeletePessenger.Click += new System.EventHandler(this.btnDeletePessenger_Click);
            // 
            // btnShowPassengers
            // 
            this.btnShowPassengers.Location = new System.Drawing.Point(73, 175);
            this.btnShowPassengers.Name = "btnShowPassengers";
            this.btnShowPassengers.Size = new System.Drawing.Size(137, 27);
            this.btnShowPassengers.TabIndex = 5;
            this.btnShowPassengers.Text = "Show Passengers";
            this.btnShowPassengers.UseVisualStyleBackColor = true;
            this.btnShowPassengers.Click += new System.EventHandler(this.btnShowPassengers_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(73, 272);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(137, 27);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "(1A, 1B, 1C, 1D, ...100)";
            // 
            // frmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 326);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnShowPassengers);
            this.Controls.Add(this.btnDeletePessenger);
            this.Controls.Add(this.btnAddPassenger);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.mtbSeatCol);
            this.Controls.Add(this.mtbSeatRow);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReservations";
            this.Text = "Airline Reservations";
            this.Load += new System.EventHandler(this.frmReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtbSeatRow;
        private System.Windows.Forms.MaskedTextBox mtbSeatCol;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.Button btnDeletePessenger;
        private System.Windows.Forms.Button btnShowPassengers;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label3;
    }
}

