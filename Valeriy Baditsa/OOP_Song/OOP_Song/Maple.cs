using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Song
{
    class Maple : ITree
    {
        public string Name { get; set; }
        public Colors color { get; set; }
        public Figures Figure { get; set; }
        public double Hight { get; set; }

        public Maple(string name)
        {
            this.Name = name;
            this.Hight = 0;
            this.color = Colors.green;            
            this.Figure = Figures.standed;
            Console.WriteLine("{0} borned", this.Name);
        }
        
        public  void Grow()
        {
            Hight += 10;
            Console.WriteLine("{0} is GROWING", this.Name);
        }

        public void reactionsTreesOn_SezonChanged(object sender, SezonEventArgs e)
        {
            switch (e.CurrentSezon)
            {
                case Sezons.autumn:
                    this.color = Colors.orange;
                    this.Figure = Figures.slender;
                    break;
                case Sezons.winter:
                    this.color = Colors.no_color;
                    this.Figure = Figures.slender;
                    break;
                case Sezons.spring:
                    this.color = Colors.green;
                    this.Figure = Figures.standed;
                    break;
                case Sezons.summer:
                    this.color = Colors.green;
                    this.Figure = Figures.standed;
                    break;
            }

            Console.WriteLine("current sezon = {0}, {1} color = {2}, {1} figure = {3}",
                               e.CurrentSezon, this.Name, this.color, this.Figure);
        }
    }
}
