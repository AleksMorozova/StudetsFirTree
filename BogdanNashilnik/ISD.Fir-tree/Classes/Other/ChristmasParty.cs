using ISD.Fir_tree.Interfaces;
using System;
using System.Collections.Generic;

namespace ISD.Fir_tree.Classes
{
    class ChristmasParty : Party
    {
        private IChristmasTree christmasTree;
        public ChristmasParty(List<Person> participants) : base(participants) { }

        public IChristmasTree ChristmasTree
        {
            get
            {
                return christmasTree;
            }
            set
            {
                Console.WriteLine("На празднике появилось праздничное дерево \"{0}\".", value.Name);
                christmasTree = value;
                foreach (var person in this.Participants)
                {
                    if (person is Kid)
                    {
                        ((Kid)person).MakeHappy();
                    }
                }
            }
        }
    }
}
