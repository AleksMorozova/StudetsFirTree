using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    public abstract class Tree 
    {
        private bool cutted = false;
        protected int size = 1;

       

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

        public abstract bool IsSlim(Seasons season);
        public  abstract Colors GetColor(Seasons season);
        
        public int GetSize()
        {
            return size;
        }

        public abstract void Grow();
        
        
        public virtual void SeasonHandler(SeasonEventArgs e)
        {
            Grow();
        }
    }
}
