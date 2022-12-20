using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class MainForm : Form
    {
        //constructor event maanger
        EventManager eventManager;

        public MainForm()
        {
            InitializeComponent();
            cmbCountry.DataSource = Enum.GetNames(typeof(Countries));
            cmbCountry.SelectedItem = Countries.Gambia;
            grpParticipants.Enabled = false;
        }

        /// <summary>
        /// method to read cost per person
        /// </summary>
        /// <returns></returns>
        private bool ReadCostPerPerson()
        {
            double cost = 0.0;
            if (double.TryParse(txtCostPerParticipant.Text, out cost) && cost >= 0)
            {
                eventManager.CostPerPerson = cost;
                return true;
            }
            else
            {
                MessageBox.Show("Cost is invalid please try again");
            }
            return false;
        }

        /// <summary>
        /// method to read to read fees per person
        /// </summary>
        /// <returns></returns>
        private bool ReadFeesPerPerson()
        {
            double fee = 0.0;

            if (double.TryParse(txtFeePerParticipant.Text, out fee) && fee >= 0)
            {
                eventManager.FeePerPerson = fee;
                return true;
            }
            else
            {
                MessageBox.Show("Fees is invalid please try again");
            }

            return false;
        }

        /// <summary>
        /// method to read address and return address
        /// </summary>
        /// <returns></returns>
        private Address ReadAddress()
        {
            Address address = new Address();//create a new address obj
            address.Street = txtStreet.Text;
            address.City = txtCity.Text;
            address.ZipCode = txtZipCode.Text;

            address.Country = (Countries)cmbCountry.SelectedIndex;//select selected country

            return address;

        }

        /// <summary>
        /// method to read input of the participant
        /// </summary>
        /// <param name="participant"></param>
        /// <returns></returns>
        private bool ReadInput(ref Participant participant)
        {
            if (eventManager == null)
            {
                return false;
            }

            bool ok = ReadPartcipantData(ref participant);
            if (ok)
            {
                eventManager.ParticipantManager.AddParticipant(participant);
            }
            else
            {
                MessageBox.Show("First name, last name, and city are required!");
            }

            return ok;
        }

        /// <summary>
        /// method to read participant data
        /// </summary>
        /// <returns></returns>
        private bool ReadPartcipantData(ref Participant participant)
        {
            participant.FirstName = txtFirstName.Text;
            participant.LastName = txtLastName.Text;

            Address address = ReadAddress();

            //connect address to participant object
            participant.Address = address;

            bool ok = address.Validate();

            return ok;
        }

        /// <summary>
        /// clear an update listbox
        /// get paricipant info
        /// add the range
        /// and add array to the listbox
        /// </summary>
        private void updateGui()
        {
            string[] info = eventManager.ParticipantManager.GetParticipantsInfo();

            if (info != null)
            {

                lstParticipants.Items.Clear();
                lstParticipants.Items.AddRange(info);

                lblNumberOfParticipants.Text = lstParticipants.Items.Count.ToString();
            }

            double totalCost = eventManager.CalcTotalCost();
            lblTotalCost.Text = totalCost.ToString("0.00");
            lblNumberOfParticipants.Text = eventManager.ParticipantManager.Count.ToString();



            double totalFees = eventManager.CalcTotalFees();
            lblTotalFees.Text = totalFees.ToString("0.00");
            lblSurpluOrDeficit.Text = (totalFees - totalCost).ToString("$ 0.00");

        }

        /// <summary>
        /// method to create an event
        /// </summary>
        private void CreateEvent()
        {
            eventManager = new EventManager();

            eventManager.Title = txtTitle.Text;
            this.txtTitle.Text = eventManager.Title;

            if ((string.IsNullOrEmpty(txtTitle.Text)))
            {
                MessageBox.Show("Event title is required");
                return;
            }

            bool costPerPersonOk = ReadCostPerPerson();
            bool feePerPerPerson = ReadFeesPerPerson();

            if ((costPerPersonOk) && (feePerPerPerson))
            {
                MessageBox.Show($"Event is created");

                updateGui();
            }
        }

        private void lblFeePerParticipant_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// method to change participant information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = lstBoxItemSelected();
            if (index < 0)
                return;

            Participant participant = eventManager.ParticipantManager.GetParticipantAt(index);

            if (ReadPartcipantData(ref participant))
            {
                eventManager.ParticipantManager.ChangeParticipantAt(participant, index);
                updateGui();
            }
        }

        /// <summary>
        /// method to create an event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            lstParticipants.Items.Clear();

            string index = txtTitle.Text;
            if (eventManager == null)
                grpParticipants.Enabled = false;
            else
                grpParticipants.Enabled = true;
            CreateEvent();

        }

        /// <summary>
        /// method to add a participant and update the gui when a participant is added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant();
            if (ReadInput(ref participant))
            {
                updateGui();
            }
        }

        ///<summary>
        ///method to list participant in the list the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstParticipants.SelectedIndex;

            if (index >= 0)//make sure is not -1
            {

                Participant participant = eventManager.ParticipantManager.GetParticipantAt(index);

                txtFirstName.Text = participant.FirstName;
                txtLastName.Text = participant.LastName;
                txtStreet.Text = participant.Address.City;
                txtZipCode.Text = participant.Address.ZipCode;

                cmbCountry.SelectedIndex = (int)participant.Address.Country;//type cast enum into an integer
            }
            else
            {
                MessageBox.Show("Please select an item");
            }
        }

        /// <summary>
        /// method to delete paricipant in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstBoxItemSelected();
            if (index < 0)
            {
                return;
            }

            eventManager.ParticipantManager.DeleteParticipantAt(index);
            updateGui();
        }
        /// <summary>
        /// message for user to check if selected item
        /// is less than 0 if so return -1 else the index
        /// </summary>
        /// <returns></returns>
        private int lstBoxItemSelected()
        {
            int index = lstParticipants.SelectedIndex;
            if (lstParticipants.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an item from the list");
                return -1;
            }
            else
                return index;

        }

        private void grpEconomy_Enter(object sender, EventArgs e)
        {

        }

        private void lbleEventTitle_Click(object sender, EventArgs e)
        {

        }

        private void grpNewEvent_Enter(object sender, EventArgs e)
        {
        }
    }
}
