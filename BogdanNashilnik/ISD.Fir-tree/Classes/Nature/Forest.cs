using ISD.Fir_tree.Interfaces;
using System;
using System.Collections.Generic;

namespace ISD.Fir_tree.Classes
{
    class Forest : INamed
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
        public List<Tree> Trees
        {
            get
            {
                return trees;
            }
        }

        public Forest(string name)
        {
            this.name = name;
            this.trees = new List<Tree>();
        }
        public Forest() : this("Безымянный лес") { }

        public void Plant(Tree tree)
        {
            this.trees.Add(tree);
            Console.WriteLine("В лес \"{0}\" посажено дерево \"{1}\".", this.name, tree.Name);
        }

    }
}
