using ISD.Fir_tree.Interfaces;
using System;
using System.Collections.Generic;

namespace ISD.Fir_tree.Classes
{
    public class Forest : IHaveName
    {
        private string name;
        private List<Tree> trees;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int TreesCount
        {
            get
            {
                return this.trees.Count;
            }
        }

        public Forest(string name, Year year)
        {
            this.name = name;
            this.trees = new List<Tree>();
            year.OnSeasonChanged += new Year.SeasonChanged((sender, e) => this.ChangeSeason(((SeasonEventArgs)e).Season));
        }
        public Forest(Year year) : this("Безымянный лес", year) { }

        public void Plant(Tree tree)
        {
            this.trees.Add(tree);
            Console.WriteLine("В лес \"{0}\" посажено дерево \"{1}\".", this.name, tree.Name);
        }
        public void Grow(int age)
        {
            foreach (Tree tree in this.trees)
            {
                tree.Grow(age);
            }
        }
        public void ChangeSeason(Season season)
        {
            foreach (Tree tree in this.trees)
            {
                tree.ChangeSeason(season);
            }
        }
        public Tree GetTree(Tree tree)
        {
            return this.trees[this.trees.IndexOf(tree)];
        }
    }
}
