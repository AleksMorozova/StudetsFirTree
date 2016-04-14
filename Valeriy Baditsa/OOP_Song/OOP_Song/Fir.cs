using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Song
{


    class Fir : ITree
    {
       public string Name { get; set; }       
       public double Hight { get; set; }       

       public Colors color
       {
           get { return Colors.green; }           
       }

       public Figures Figure 
       {
            get { return Figures.slender; }            
       }

       public Fir(string name)
       {
            this.Name = name;
            this.Hight = 0;
            Console.WriteLine("Fir borned");
           
       }

       public void Grow()
       {
           this.Hight += 3;
           Console.WriteLine("{0} is growing", this.Name);
       }

       public void reactionsTreesOn_SezonChanged(object sender, SezonEventArgs e)
       {
           Console.WriteLine("current sezon = {0}, {1} color = {2}, {1} figure = {3}",
                              e.CurrentSezon, this.Name, this.color, this.Figure);           
       }
    }
}
