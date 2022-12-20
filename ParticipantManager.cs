using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ParticipantManager
    {
        // fields
        private List<Participant> participants;


        //constructor
        public ParticipantManager()
        {
            participants = new List<Participant>();
        }

        /// <summary>
        /// method count participants the number of participants registered
        /// </summary>
        public int Count
        {
            get { return participants.Count; }
        }

        /// <summary>
        /// method to add participants on the list
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool AddParticipant(string firstName, string lastName, Address address)
        {
            Participant participant = new Participant(firstName, lastName, address);
            participants.Add(participant);
            return true;
        }

        /// <summary>
        /// method to add a participant
        /// </summary>
        /// <param name="ParticipantIn"></param>
        /// <returns></returns>
        public bool AddParticipant(Participant ParticipantIn)
        {
            if (participants == null)
            {
                return false;
            }

            participants.Add(ParticipantIn);
            return true;
        }

        /// <summary>
        /// method to get participant at a certain index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Participant GetParticipantAt(int index)
        {
            if (CheckIndex(index))
                return participants[index];

            return null;
        }

        /// <summary>
        /// method to change participant at
        /// </summary>
        /// <param name="ParticipantIn"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeParticipantAt(Participant ParticipantIn, int index)
        {

            if ((ParticipantIn == null) || !CheckIndex(index))
                return false;
                participants[index] = ParticipantIn;

            return true;
        }

        /// <summary>
        /// method to check index of the particpant
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
          return  (index >= 0) && (index < participants.Count);
        }

        /// <summary>
        /// method to delete participants
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteParticipantAt(int index)
        {
            if (!CheckIndex(index))
            {
                return false;
            }

            participants.RemoveAt(index);

            return true;
        }

        /// <summary>
        /// /method to get participant info
        /// each string call to participant object ToString method
        /// the ToString method in the address class is called
        /// </summary>
        /// <returns>an array of strings</returns>
        public string[] GetParticipantsInfo()
        {
            string [] info = new string[participants.Count];

            int i = 0;

            foreach (Participant ParticipantObj in participants)
            {
                info[i] = ParticipantObj.ToString();
                i++;
            }
            return info;
        }
    }
}
