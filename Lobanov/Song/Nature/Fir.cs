using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    class Fir:ICuttable, IColoured, ISlim, IElegant
    {

        int size = 1;
        public bool IsSleep { get; set; }
        public bool Wrapped { get; set; }


        public void Freeze()
        {
            if (Wrapped)
            {
                Console.WriteLine("Не замерзай");
            }
            else
            {
                Console.WriteLine("замёрзла");
            }
        }


        private bool cutted=false;

        public Fir()
        {
            Console.WriteLine(" Родилась ёлочка");
        }

        
        public bool Cutted 
        {
            get
            {
                return cutted;
            }
            private set
            {
                cutted = value;
            }
            
        }

        public void Cut(CutType type)
        {
            Cutted = true;
        }
        

        public bool IsSlim(Seasons season)
        {
            return true;
        }

        public Colors GetColor(Seasons season)
        {
            return Colors.Green;
        }

        public void Grow()
        {
            size++;
            Console.WriteLine(" она росла");
        }
        public void SetHappyness(IEnumerable<Kid> kids)
        {
            foreach (Kid current in kids)
            {
                current.IsHappy = true;
            }
            Console.WriteLine("И много, много радости ");
            Console.WriteLine("детишкам принесла ");
        }
    }
}
