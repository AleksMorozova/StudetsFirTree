﻿using ISD.Fir_tree.Interfaces;
using System;
using System.Collections.Generic;

namespace ISD.Fir_tree.Classes
{
    class FelledFir : FelledTree, IChristmasTree
    {
        private List<ChristmasTreeToy> decorations;

        public List<ChristmasTreeToy> Decorations
        {
            get
            {
                return decorations;
            }
        }
        public bool Fancy
        {
            get
            {
                Console.Write("Ёлка \"{0}\" нарядная: ", this.name);
                return (this.decorations.Count >= 1);
            }
        }

        public FelledFir(Tree tree)
        {
            this.name = tree.Name + "(срублена)";
            this.decorations = new List<ChristmasTreeToy>();
        }

        public void Decorate(ChristmasTreeToy decoration)
        {
            this.decorations.Add(decoration);
            Console.WriteLine("Срубленную ёлку \"{0}\" украсили игрушкой.", this.name);
        }
        public static explicit operator FelledFir(Tree tree)
        {
            return new FelledFir(tree);
        }
    }
}
