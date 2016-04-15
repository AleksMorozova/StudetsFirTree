using System;

namespace OOP_Song
{
    public class Maple : ITree
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

        public void reactionTreeOn_SezonChanged(SeasonEventArgs e)
        {
            switch (e.CurrentSezon)
            {
                case Seasons.autumn:
                    this.color = Colors.orange;
                    this.Figure = Figures.slender;
                    break;
                case Seasons.winter:
                    this.color = Colors.no_color;
                    this.Figure = Figures.slender;
                    break;
                case Seasons.spring:
                    this.color = Colors.green;
                    this.Figure = Figures.standed;
                    break;
                case Seasons.summer:
                    this.color = Colors.green;
                    this.Figure = Figures.standed;
                    break;
            }

            Console.WriteLine("current sezon = {0}, {1} color = {2}, {1} figure = {3}",
                               e.CurrentSezon, this.Name, this.color, this.Figure);
        }
    }
}
