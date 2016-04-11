using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_fir_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest MyForest = new Forest(new FirTree("Yolochka", Colors.Green, Waists.Shapely));
            MyForest.ForestTrees[0].Grow("В лесу она росла");

            MyForest.YearTime = YearTimes.Winter;
            Colors YolochkaColorInWinter = MyForest.ForestTrees[0].Color;
            Waists YolochkaWaistInWinter = MyForest.ForestTrees[0].Waist;

            MyForest.YearTime = YearTimes.Summer;
            Colors YolochkaColorInSummer = MyForest.ForestTrees[0].Color;
            Waists YolochkaWaistInSummer = MyForest.ForestTrees[0].Waist;

            if(YolochkaWaistInWinter == YolochkaWaistInSummer)
            {
                string quatrain = "Зимой и летом ";
                switch(MyForest.ForestTrees[0].Waist)
                {
                    case Waists.Fat: quatrain += "жирная";
                        break;
                    case Waists.Shapely: quatrain += "стройная";
                        break;
                    case Waists.Thin: quatrain += "худая";
                        break;
                }
                Console.WriteLine(quatrain);
            }

            if (YolochkaColorInSummer == YolochkaColorInWinter)
            {
                string quatrain = "";
                switch (MyForest.ForestTrees[0].Color)
                {
                    case Colors.Blue: quatrain += "Голубая";
                        break;
                    case Colors.Green: quatrain += "Зеленая";
                        break;
                    case Colors.Grey: quatrain += "Серая";
                        break;
                }
                quatrain += " была.";
                Console.WriteLine(quatrain);
            }
            Console.ReadKey();
        }
    }
}
