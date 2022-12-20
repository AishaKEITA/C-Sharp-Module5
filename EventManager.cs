using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class EventManager
    {
        //instance variable
        private double costPerPerson;
        private double feePerPerson;
        private string title;
        private ParticipantManager participantManager;

        /// <summary>
        /// method accessing participant manager in the event manager class
        /// </summary>
        public EventManager()
        {
            participantManager = new ParticipantManager();
        }

        /// <summary>
        /// constructor participant manager
        /// </summary>
        public ParticipantManager ParticipantManager
        {
            get { return participantManager; }
        }
        /// <summary>
        /// method to get and set cost for per person
        /// </summary>
        public double CostPerPerson
        {
            get { return costPerPerson; }
            set
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
        }

        /// <summary>
        /// method to set and get fee per person
        /// </summary>
        public double FeePerPerson
        {
            get { return feePerPerson; }
            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
        }

        /// <summary>
        /// method to get and set title
        /// </summary>
        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    title = value;
            }
        }

        /// <summary>
        /// method to calculate total cost
        /// </summary>
        /// <returns></returns>
        public double CalcTotalCost()
        {
            return participantManager.Count * costPerPerson;
        }

        /// <summary>
        /// method to calculate total fees
        /// </summary>
        /// <returns></returns>
        public double CalcTotalFees()
        {
            return participantManager.Count * feePerPerson;
        }
    }
}
