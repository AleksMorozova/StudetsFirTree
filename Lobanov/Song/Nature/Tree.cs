﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    public class Tree : ICuttable, IColoured, ISlim
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

        public virtual bool IsSlim(Seasons season)
        {
            return false;
        }

        public virtual Colors GetColor(Seasons season)
        {
            return Colors.Brown;
        }
        public int GetSize()
        {
            return size;
        }

        public virtual void Grow()
        {
            size++;
        }
        
        public virtual void SeasonHandler(SeasonEventArgs e)
        {
            Grow();
        }
    }
}