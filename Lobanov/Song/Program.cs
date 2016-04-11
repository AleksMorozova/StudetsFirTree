using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    class Program
    {

        
    //В лесу родилась ёлочка,
    //В лесу она росла.
    //Зимой и летом стройная,
    //Зелёная была.

    //Метель ей пела песенку:
    //«Спи, ёлочка, бай-бай!»
    //Мороз снежком укутывал:
    //«Смотри, не замерзай!»

    //Трусишка зайка серенький
    //Под ёлочкой скакал.
    //Порою волк, сердитый волк,
    //Рысцою пробегал.

        //Чу! Снег по лесу частому
        //Под полозом скрипит.
    //Лошадка мохноногая
    //Торопится, бежит.

    //Везёт лошадка дровеньки,
    //На дровнях мужичок.
    //Срубил он нашу ёлочку
    //Под самый корешок.

    //Теперь ты здесь, нарядная,
    //На праздник к нам пришла
    //И много, много радости
    //Детишкам принесла. 




        static void Main(string[] args)
        {
            Forest myforest = new Forest();
            Snowstorm sStorm = new Snowstorm();
            var localfrost = new Frost();
            var hare = new Hare();
            var wolf = new Wolf();
            var horse = new Horse();
            var sledge=new WoodSledge();
            var peasant = new Man();

            var newyear = new Holiday();
            var snow = new Snow();

            newyear.kids.Add(new Kid());
            newyear.kids.Add(new Kid());
            newyear.kids.Add(new Kid());


            sledge.peasant = peasant;
            horse.sledge = sledge;
            

            myforest.SeasonChanges();

            var myfir = myforest.firs[0];

            sStorm.Song(myfir);
            localfrost.Freeze(myfir);

            if ((hare is ICoward) && hare.GetColor(Seasons.Winter).Equals(Colors.Grey))
            {
                Console.WriteLine("Трусишка зайка серенький");
                hare.JumpUnderTheTree();
            }
            

            if (wolf is IAngry)
            {
                Console.WriteLine("Порою волк, сердитый волк");
                wolf.Move();
            }

            if (snow is IFrequend)
            {
                Console.WriteLine("Чу! Снег по лесу частому");
                snow.Creak(sledge.runners);
            }
            if (horse is IHairy)
            {
                Console.WriteLine("Лошадка мохноногая ");
                horse.Move();
            }
            if (sledge.IsControlled()) Console.WriteLine("На дровнях мужичок ");
            peasant.CutTheTree(myfir, CutType.Fully);

            if (myfir is IElegant)
            {
                Console.WriteLine("Теперь ты здесь нарядная ");
            }

            newyear.Tree = myfir;
            Console.WriteLine("На праздник к нам пришла ");
            newyear.Tree.SetHappyness(newyear.kids);

            Console.ReadKey();
        }
    }
}
