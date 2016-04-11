using ISD.Fir_tree.Interfaces;
using System;
using System.Collections.Generic;

namespace ISD.Fir_tree.Classes
{
    class WoodSledge : ICart
    {
        const int MAX_CAPACITY = 10;
        private List<INamed> cargo;

        public List<INamed> Cargo
        {
            get
            {
                return cargo;
            }
        }
        public string Name
        {
            get
            {
                return "Дровеньки";
            }
        }
        public WheelsType WheelsType { get; set; }

        public WoodSledge()
        {
            this.cargo = new List<INamed>();
            this.WheelsType = WheelsType.Runners;
        }

        public bool Put(INamed obj)
        {
            if (this.cargo.Count >= MAX_CAPACITY)
            {
                return false;
            }
            else
            {
                cargo.Add(obj);
                Console.WriteLine("В \"{0}\" добавили \"{1}\".", this.Name, obj.Name);
                return true;
            }
        }
        public void Remove()
        {
            var removedObject = this.cargo[this.cargo.Count - 1];
            this.cargo.RemoveAt(this.cargo.Count - 1);
            Console.WriteLine("Из \"{0}\" убрали \"{1}\".", this.Name, removedObject.Name);
        }
    }
}
