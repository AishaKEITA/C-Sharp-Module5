namespace Assignment5
{
    partial class MainForm
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
            this.lbleEventTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCostPerParticipant = new System.Windows.Forms.TextBox();
            this.txtFeePerParticipant = new System.Windows.Forms.TextBox();
            this.lblCostPerParticipant = new System.Windows.Forms.Label();
            this.lblFeePerParticipant = new System.Windows.Forms.Label();
            this.grpNewEvent = new System.Windows.Forms.GroupBox();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.lstParticipants = new System.Windows.Forms.ListBox();
            this.lblParticipant = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.grpParticipants = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpEconomy = new System.Windows.Forms.GroupBox();
            this.lblSurpluOrDeficit = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblNumberOfParticipants = new System.Windows.Forms.Label();
            this.lblShowSuporDeficit = new System.Windows.Forms.Label();
            this.lblShowTotalFees = new System.Windows.Forms.Label();
            this.lblShowTotalCost = new System.Windows.Forms.Label();
            this.lblNumShowParticipants = new System.Windows.Forms.Label();
            this.grpNewEvent.SuspendLayout();
            this.grpParticipants.SuspendLayout();
            this.grpEconomy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbleEventTitle
            // 
            this.lbleEventTitle.AutoSize = true;
            this.lbleEventTitle.ForeColor = System.Drawing.Color.Black;
            this.lbleEventTitle.Location = new System.Drawing.Point(16, 43);
            this.lbleEventTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbleEventTitle.Name = "lbleEventTitle";
            this.lbleEventTitle.Size = new System.Drawing.Size(54, 13);
            this.lbleEventTitle.TabIndex = 0;
            this.lbleEventTitle.Text = "Event title";
            this.lbleEventTitle.Click += new System.EventHandler(this.lbleEventTitle_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(86, 40);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(146, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtCostPerParticipant
            // 
            this.txtCostPerParticipant.Location = new System.Drawing.Point(184, 69);
            this.txtCostPerParticipant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCostPerParticipant.Name = "txtCostPerParticipant";
            this.txtCostPerParticipant.Size = new System.Drawing.Size(48, 20);
            this.txtCostPerParticipant.TabIndex = 2;
            // 
            // txtFeePerParticipant
            // 
            this.txtFeePerParticipant.Location = new System.Drawing.Point(184, 97);
            this.txtFeePerParticipant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFeePerParticipant.Name = "txtFeePerParticipant";
            this.txtFeePerParticipant.Size = new System.Drawing.Size(48, 20);
            this.txtFeePerParticipant.TabIndex = 3;
            // 
            // lblCostPerParticipant
            // 
            this.lblCostPerParticipant.AutoSize = true;
            this.lblCostPerParticipant.ForeColor = System.Drawing.Color.Black;
            this.lblCostPerParticipant.Location = new System.Drawing.Point(16, 72);
            this.lblCostPerParticipant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostPerParticipant.Name = "lblCostPerParticipant";
            this.lblCostPerParticipant.Size = new System.Drawing.Size(98, 13);
            this.lblCostPerParticipant.TabIndex = 4;
            this.lblCostPerParticipant.Text = "Cost per participant";
            // 
            // lblFeePerParticipant
            // 
            this.lblFeePerParticipant.AutoSize = true;
            this.lblFeePerParticipant.ForeColor = System.Drawing.Color.Black;
            this.lblFeePerParticipant.Location = new System.Drawing.Point(16, 99);
            this.lblFeePerParticipant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeePerParticipant.Name = "lblFeePerParticipant";
            this.lblFeePerParticipant.Size = new System.Drawing.Size(95, 13);
            this.lblFeePerParticipant.TabIndex = 5;
            this.lblFeePerParticipant.Text = "Fee per participant";
            this.lblFeePerParticipant.Click += new System.EventHandler(this.lblFeePerParticipant_Click);
            // 
            // grpNewEvent
            // 
            this.grpNewEvent.Controls.Add(this.btnCreateEvent);
            this.grpNewEvent.Controls.Add(this.lblFeePerParticipant);
            this.grpNewEvent.Controls.Add(this.lblCostPerParticipant);
            this.grpNewEvent.Controls.Add(this.txtFeePerParticipant);
            this.grpNewEvent.Controls.Add(this.txtCostPerParticipant);
            this.grpNewEvent.Controls.Add(this.txtTitle);
            this.grpNewEvent.Controls.Add(this.lbleEventTitle);
            this.grpNewEvent.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpNewEvent.Location = new System.Drawing.Point(0, 6);
            this.grpNewEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNewEvent.Name = "grpNewEvent";
            this.grpNewEvent.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNewEvent.Size = new System.Drawing.Size(236, 172);
            this.grpNewEvent.TabIndex = 0;
            this.grpNewEvent.TabStop = false;
            this.grpNewEvent.Text = "New Event";
            this.grpNewEvent.Enter += new System.EventHandler(this.grpNewEvent_Enter);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(76, 131);
            this.btnCreateEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(84, 23);
            this.btnCreateEvent.TabIndex = 6;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // lstParticipants
            // 
            this.lstParticipants.FormattingEnabled = true;
            this.lstParticipants.Location = new System.Drawing.Point(270, 31);
            this.lstParticipants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstParticipants.Name = "lstParticipants";
            this.lstParticipants.Size = new System.Drawing.Size(314, 173);
            this.lstParticipants.TabIndex = 1;
            this.lstParticipants.SelectedIndexChanged += new System.EventHandler(this.lstParticipants_SelectedIndexChanged);
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblParticipant.Location = new System.Drawing.Point(286, 6);
            this.lblParticipant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParticipant.Name = "lblParticipant";
            this.lblParticipant.Size = new System.Drawing.Size(62, 13);
            this.lblParticipant.TabIndex = 2;
            this.lblParticipant.Text = "Participants";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblAdress.Location = new System.Drawing.Point(438, 6);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "Adress";
            // 
            // grpParticipants
            // 
            this.grpParticipants.Controls.Add(this.btnAdd);
            this.grpParticipants.Controls.Add(this.cmbCountry);
            this.grpParticipants.Controls.Add(this.txtZipCode);
            this.grpParticipants.Controls.Add(this.txtCity);
            this.grpParticipants.Controls.Add(this.txtStreet);
            this.grpParticipants.Controls.Add(this.txtLastName);
            this.grpParticipants.Controls.Add(this.txtFirstName);
            this.grpParticipants.Controls.Add(this.lblFullName);
            this.grpParticipants.Controls.Add(this.lblStreet);
            this.grpParticipants.Controls.Add(this.lblCountry);
            this.grpParticipants.Controls.Add(this.lblZipCode);
            this.grpParticipants.Controls.Add(this.lblCity);
            this.grpParticipants.Controls.Add(this.lblLastName);
            this.grpParticipants.Location = new System.Drawing.Point(6, 194);
            this.grpParticipants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpParticipants.Name = "grpParticipants";
            this.grpParticipants.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpParticipants.Size = new System.Drawing.Size(252, 229);
            this.grpParticipants.TabIndex = 6;
            this.grpParticipants.TabStop = false;
            this.grpParticipants.Text = "Add participant";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdd.Location = new System.Drawing.Point(50, 186);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 27);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(124, 130);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(126, 21);
            this.cmbCountry.TabIndex = 12;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(124, 106);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(126, 20);
            this.txtZipCode.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(124, 84);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(126, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(124, 64);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(126, 20);
            this.txtStreet.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 45);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(126, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(124, 26);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(126, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(16, 25);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Full Name";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(16, 62);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Street";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(16, 137);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(16, 108);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 2;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 83);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(16, 44);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // btnChange
            // 
            this.btnChange.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnChange.Location = new System.Drawing.Point(298, 209);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(84, 22);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnDelete.Location = new System.Drawing.Point(438, 206);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 24);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpEconomy
            // 
            this.grpEconomy.Controls.Add(this.lblSurpluOrDeficit);
            this.grpEconomy.Controls.Add(this.lblTotalFees);
            this.grpEconomy.Controls.Add(this.lblTotalCost);
            this.grpEconomy.Controls.Add(this.lblNumberOfParticipants);
            this.grpEconomy.Controls.Add(this.lblShowSuporDeficit);
            this.grpEconomy.Controls.Add(this.lblShowTotalFees);
            this.grpEconomy.Controls.Add(this.lblShowTotalCost);
            this.grpEconomy.Controls.Add(this.lblNumShowParticipants);
            this.grpEconomy.Location = new System.Drawing.Point(280, 244);
            this.grpEconomy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEconomy.Name = "grpEconomy";
            this.grpEconomy.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEconomy.Size = new System.Drawing.Size(289, 167);
            this.grpEconomy.TabIndex = 9;
            this.grpEconomy.TabStop = false;
            this.grpEconomy.Text = "Event Economy";
            this.grpEconomy.Enter += new System.EventHandler(this.grpEconomy_Enter);
            // 
            // lblSurpluOrDeficit
            // 
            this.lblSurpluOrDeficit.AutoSize = true;
            this.lblSurpluOrDeficit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSurpluOrDeficit.Location = new System.Drawing.Point(196, 135);
            this.lblSurpluOrDeficit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurpluOrDeficit.Name = "lblSurpluOrDeficit";
            this.lblSurpluOrDeficit.Size = new System.Drawing.Size(2, 15);
            this.lblSurpluOrDeficit.TabIndex = 7;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Location = new System.Drawing.Point(196, 101);
            this.lblTotalFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(2, 15);
            this.lblTotalFees.TabIndex = 6;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(196, 68);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(2, 15);
            this.lblTotalCost.TabIndex = 5;
            // 
            // lblNumberOfParticipants
            // 
            this.lblNumberOfParticipants.AutoSize = true;
            this.lblNumberOfParticipants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfParticipants.Location = new System.Drawing.Point(196, 39);
            this.lblNumberOfParticipants.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfParticipants.Name = "lblNumberOfParticipants";
            this.lblNumberOfParticipants.Size = new System.Drawing.Size(2, 15);
            this.lblNumberOfParticipants.TabIndex = 4;
            // 
            // lblShowSuporDeficit
            // 
            this.lblShowSuporDeficit.AutoSize = true;
            this.lblShowSuporDeficit.Location = new System.Drawing.Point(6, 125);
            this.lblShowSuporDeficit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowSuporDeficit.Name = "lblShowSuporDeficit";
            this.lblShowSuporDeficit.Size = new System.Drawing.Size(75, 13);
            this.lblShowSuporDeficit.TabIndex = 3;
            this.lblShowSuporDeficit.Text = "Surplus/deficit";
            // 
            // lblShowTotalFees
            // 
            this.lblShowTotalFees.AutoSize = true;
            this.lblShowTotalFees.Location = new System.Drawing.Point(6, 94);
            this.lblShowTotalFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowTotalFees.Name = "lblShowTotalFees";
            this.lblShowTotalFees.Size = new System.Drawing.Size(54, 13);
            this.lblShowTotalFees.TabIndex = 2;
            this.lblShowTotalFees.Text = "Total fees";
            // 
            // lblShowTotalCost
            // 
            this.lblShowTotalCost.AutoSize = true;
            this.lblShowTotalCost.Location = new System.Drawing.Point(6, 69);
            this.lblShowTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowTotalCost.Name = "lblShowTotalCost";
            this.lblShowTotalCost.Size = new System.Drawing.Size(54, 13);
            this.lblShowTotalCost.TabIndex = 1;
            this.lblShowTotalCost.Text = "Total cost";
            // 
            // lblNumShowParticipants
            // 
            this.lblNumShowParticipants.AutoSize = true;
            this.lblNumShowParticipants.Location = new System.Drawing.Point(6, 39);
            this.lblNumShowParticipants.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumShowParticipants.Name = "lblNumShowParticipants";
            this.lblNumShowParticipants.Size = new System.Drawing.Size(113, 13);
            this.lblNumShowParticipants.TabIndex = 0;
            this.lblNumShowParticipants.Text = "Number of participants";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 470);
            this.Controls.Add(this.grpEconomy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.grpParticipants);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblParticipant);
            this.Controls.Add(this.lstParticipants);
            this.Controls.Add(this.grpNewEvent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpNewEvent.ResumeLayout(false);
            this.grpNewEvent.PerformLayout();
            this.grpParticipants.ResumeLayout(false);
            this.grpParticipants.PerformLayout();
            this.grpEconomy.ResumeLayout(false);
            this.grpEconomy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbleEventTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCostPerParticipant;
        private System.Windows.Forms.TextBox txtFeePerParticipant;
        private System.Windows.Forms.Label lblCostPerParticipant;
        private System.Windows.Forms.Label lblFeePerParticipant;
        private System.Windows.Forms.GroupBox grpNewEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.ListBox lstParticipants;
        private System.Windows.Forms.Label lblParticipant;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.GroupBox grpParticipants;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpEconomy;
        private System.Windows.Forms.Label lblShowSuporDeficit;
        private System.Windows.Forms.Label lblShowTotalFees;
        private System.Windows.Forms.Label lblShowTotalCost;
        private System.Windows.Forms.Label lblNumShowParticipants;
        private System.Windows.Forms.Label lblSurpluOrDeficit;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblNumberOfParticipants;
    }
}

