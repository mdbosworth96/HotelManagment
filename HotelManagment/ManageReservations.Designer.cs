namespace HotelManagment
{
    partial class ManageReservations
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
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.buttonRemoveReservation = new System.Windows.Forms.Button();
            this.buttonEditReservation = new System.Windows.Forms.Button();
            this.buttonAddNewReservation = new System.Windows.Forms.Button();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.labelDateIN = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelClientId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReservationId = new System.Windows.Forms.TextBox();
            this.labelReservationId = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.labelDateOut = new System.Windows.Forms.Label();
            this.comboBoxRoomNum = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomNumber.Location = new System.Drawing.Point(167, 192);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(151, 30);
            this.textBoxRoomNumber.TabIndex = 21;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Tripple",
            "Quad",
            "Queen",
            "King",
            "Twin",
            "Double-Double",
            "Studio",
            "Family Suite",
            "Master Suite"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(166, 239);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(214, 33);
            this.comboBoxRoomType.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(153)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.comboBoxRoomNum);
            this.panel1.Controls.Add(this.dateTimePickerOut);
            this.panel1.Controls.Add(this.labelDateOut);
            this.panel1.Controls.Add(this.dateTimePickerIn);
            this.panel1.Controls.Add(this.textBoxReservationId);
            this.panel1.Controls.Add(this.labelReservationId);
            this.panel1.Controls.Add(this.textBoxRoomNumber);
            this.panel1.Controls.Add(this.comboBoxRoomType);
            this.panel1.Controls.Add(this.buttonClearFields);
            this.panel1.Controls.Add(this.buttonRemoveReservation);
            this.panel1.Controls.Add(this.buttonEditReservation);
            this.panel1.Controls.Add(this.buttonAddNewReservation);
            this.panel1.Controls.Add(this.dataGridViewReservations);
            this.panel1.Controls.Add(this.textBoxClientId);
            this.panel1.Controls.Add(this.labelDateIN);
            this.panel1.Controls.Add(this.labelRoomType);
            this.panel1.Controls.Add(this.labelRoomNumber);
            this.panel1.Controls.Add(this.labelClientId);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 624);
            this.panel1.TabIndex = 2;
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.Location = new System.Drawing.Point(27, 560);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(340, 30);
            this.buttonClearFields.TabIndex = 17;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.ButtonClearFields_Click);
            // 
            // buttonRemoveReservation
            // 
            this.buttonRemoveReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveReservation.Location = new System.Drawing.Point(117, 513);
            this.buttonRemoveReservation.Name = "buttonRemoveReservation";
            this.buttonRemoveReservation.Size = new System.Drawing.Size(155, 30);
            this.buttonRemoveReservation.TabIndex = 16;
            this.buttonRemoveReservation.Text = "Remove Reservation";
            this.buttonRemoveReservation.UseVisualStyleBackColor = true;
            this.buttonRemoveReservation.Click += new System.EventHandler(this.ButtonRemoveReservation_Click);
            // 
            // buttonEditReservation
            // 
            this.buttonEditReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditReservation.Location = new System.Drawing.Point(117, 465);
            this.buttonEditReservation.Name = "buttonEditReservation";
            this.buttonEditReservation.Size = new System.Drawing.Size(155, 30);
            this.buttonEditReservation.TabIndex = 15;
            this.buttonEditReservation.Text = "Edit Reservation";
            this.buttonEditReservation.UseVisualStyleBackColor = true;
            this.buttonEditReservation.Click += new System.EventHandler(this.ButtonEditReservation_Click);
            // 
            // buttonAddNewReservation
            // 
            this.buttonAddNewReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewReservation.Location = new System.Drawing.Point(117, 418);
            this.buttonAddNewReservation.Name = "buttonAddNewReservation";
            this.buttonAddNewReservation.Size = new System.Drawing.Size(155, 30);
            this.buttonAddNewReservation.TabIndex = 14;
            this.buttonAddNewReservation.Text = "Add Reservation";
            this.buttonAddNewReservation.UseVisualStyleBackColor = true;
            this.buttonAddNewReservation.Click += new System.EventHandler(this.ButtonAddNewReservation_Click);
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.AllowUserToAddRows = false;
            this.dataGridViewReservations.AllowUserToDeleteRows = false;
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(390, 87);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.ReadOnly = true;
            this.dataGridViewReservations.Size = new System.Drawing.Size(632, 503);
            this.dataGridViewReservations.TabIndex = 13;
            this.dataGridViewReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservations_CellClick);
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientId.Location = new System.Drawing.Point(165, 87);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(153, 31);
            this.textBoxClientId.TabIndex = 7;
            // 
            // labelDateIN
            // 
            this.labelDateIN.AutoSize = true;
            this.labelDateIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateIN.Location = new System.Drawing.Point(87, 302);
            this.labelDateIN.Name = "labelDateIN";
            this.labelDateIN.Size = new System.Drawing.Size(73, 24);
            this.labelDateIN.TabIndex = 4;
            this.labelDateIN.Text = "Date In:";
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomType.Location = new System.Drawing.Point(46, 243);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(114, 24);
            this.labelRoomType.TabIndex = 3;
            this.labelRoomType.Text = "Room Type:";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNumber.Location = new System.Drawing.Point(23, 192);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(140, 24);
            this.labelRoomNumber.TabIndex = 2;
            this.labelRoomNumber.Text = "Room Number:";
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientId.Location = new System.Drawing.Point(75, 91);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(84, 24);
            this.labelClientId.TabIndex = 1;
            this.labelClientId.Text = "Client ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 77);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(287, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Reservations";
            // 
            // textBoxReservationId
            // 
            this.textBoxReservationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReservationId.Location = new System.Drawing.Point(167, 140);
            this.textBoxReservationId.Name = "textBoxReservationId";
            this.textBoxReservationId.Size = new System.Drawing.Size(151, 30);
            this.textBoxReservationId.TabIndex = 23;
            // 
            // labelReservationId
            // 
            this.labelReservationId.AutoSize = true;
            this.labelReservationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservationId.Location = new System.Drawing.Point(27, 140);
            this.labelReservationId.Name = "labelReservationId";
            this.labelReservationId.Size = new System.Drawing.Size(136, 24);
            this.labelReservationId.TabIndex = 22;
            this.labelReservationId.Text = "Reservation ID:";
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIn.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIn.Location = new System.Drawing.Point(166, 295);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(214, 31);
            this.dateTimePickerIn.TabIndex = 24;
            this.dateTimePickerIn.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOut.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOut.Location = new System.Drawing.Point(165, 346);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(214, 31);
            this.dateTimePickerOut.TabIndex = 26;
            this.dateTimePickerOut.Value = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            // 
            // labelDateOut
            // 
            this.labelDateOut.AutoSize = true;
            this.labelDateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOut.Location = new System.Drawing.Point(71, 352);
            this.labelDateOut.Name = "labelDateOut";
            this.labelDateOut.Size = new System.Drawing.Size(88, 24);
            this.labelDateOut.TabIndex = 25;
            this.labelDateOut.Text = "Date Out:";
            // 
            // comboBoxRoomNum
            // 
            this.comboBoxRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomNum.FormattingEnabled = true;
            this.comboBoxRoomNum.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Tripple",
            "Quad",
            "Queen",
            "King",
            "Twin",
            "Double-Double",
            "Studio",
            "Family Suite",
            "Master Suite"});
            this.comboBoxRoomNum.Location = new System.Drawing.Point(337, 192);
            this.comboBoxRoomNum.Name = "comboBoxRoomNum";
            this.comboBoxRoomNum.Size = new System.Drawing.Size(214, 33);
            this.comboBoxRoomNum.TabIndex = 27;
            // 
            // ManageReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 624);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReservations";
            this.Text = "ManageReservations";
            this.Load += new System.EventHandler(this.ManageReservations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Button buttonRemoveReservation;
        private System.Windows.Forms.Button buttonEditReservation;
        private System.Windows.Forms.Button buttonAddNewReservation;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label labelDateIN;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReservationId;
        private System.Windows.Forms.Label labelReservationId;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.Label labelDateOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.ComboBox comboBoxRoomNum;
    }
}