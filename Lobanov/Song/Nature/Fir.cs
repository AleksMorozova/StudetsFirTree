using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    public class Fir: Tree
    {

        

        public bool IsSleep { get; set; }

        public bool IsElegant()
        {
            return true;
        }
        public bool Wrapped { get; set; }


        public void Freeze()
        {
            if (Wrapped)
            {
                // Не замерзай
            }
            else
            {
                Console.WriteLine("замёрзла!");
            }
        }


        public Fir()
        {
            
        }

        public override bool IsSlim(Seasons season)
        {
            return true;
        }

        public override Colors GetColor(Seasons season)
        {
            return Colors.Green;
        }

        public override void Grow()
        {
            size+=2;
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
