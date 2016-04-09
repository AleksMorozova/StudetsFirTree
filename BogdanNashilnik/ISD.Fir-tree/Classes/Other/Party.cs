using System.Collections.Generic;

namespace ISD.Fir_tree.Classes
{
    class Party
    {
        protected List<Person> participants = new List<Person>();
        public List<Person> Participants
        {
            get
            {
                return participants;
            }
        }

        public Party(List<Person> participants)
        {
            this.participants = participants;
        } 
    }
}
