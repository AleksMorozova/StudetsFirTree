using ISD.Fir_tree.Interfaces;

namespace ISD.Fir_tree.Classes
{
    class Person : IHaveName
    {
        protected string name;
        protected int age;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            {
                age = value;
            }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person() : this("Безымянный человек", 25) { }
    }
}
