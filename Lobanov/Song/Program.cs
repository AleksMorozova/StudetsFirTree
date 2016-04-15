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
            Year worldyear = new Year(Seasons.Summer);

            Snowstorm sStorm = new Snowstorm();
            var localfrost = new Frost();

            var hare = new Hare();
            var wolf = new Wolf();
            var horse = new Horse();

            var sledge=new WoodSledge();
            var peasant = new Man(); 
            
            sledge.peasant = peasant;
            horse.sledge = sledge;

            var newyear = new Holiday();
            
            newyear.kids.Add(new Kid());
            newyear.kids.Add(new Kid());
            newyear.kids.Add(new Kid());

            var snow = new Snow();

            //--------------------------------------
            Forest myforest = new Forest(worldyear);
            Fir myfir = new Fir();

            myforest.AddTree(myfir);
            //В лесу родилась ёлочка,

            myforest.AddTree(new Fir());
            myforest.AddTree(new Oak());
            myforest.AddTree(new Oak());
            myforest.AddAnimal(wolf);
            myforest.AddAnimal(hare);


            worldyear.ChangeSeason();
            worldyear.ChangeSeason();
            //В лесу она росла.
            if (myfir.IsSlim(Seasons.Summer) == myfir.IsSlim(Seasons.Winter))
            {
                //Зимой и летом стройная
            }
            if (myfir.GetColor(Seasons.Summer) == myfir.GetColor(Seasons.Winter))
            {
                //Зелёная была
            }
            sStorm.Song(myfir, "Спи, ёлочка, бай-бай!");
            //Метель ей пела песенку:
            //«Спи, ёлочка, бай-бай!»
            
            localfrost.Freeze(myfir);
            //Мороз снежком укутывал:
            //«Смотри, не замерзай!»



            if ((hare.GetAnimalCharacter() == Character.Coward) && hare.GetColor(Seasons.Winter).Equals(Colors.Grey))
            {
                //Трусишка зайка серенький
                hare.JumpUnderTheTree();
                //Под ёлочкой скакал.
            }
            

            if (wolf.GetAnimalCharacter()==Character.Angry)
            {
                //Порою волк, сердитый волк,
                wolf.Move();
                //Рысцою пробегал.
            }
 

            if (snow.IsFreq())
            {
                //Чу! Снег по лесу частому
            
                snow.Creak(sledge.runners);
                //Под полозом скрипит.
            }
            if (horse.IsHairy())
            {
                //Лошадка мохноногая
                horse.Move();
                //Торопится, бежит.
            }
            //Везёт лошадка дровеньки,
            if (sledge.IsControlled()) Console.WriteLine("На дровнях мужичок ");
            //На дровнях мужичок.

            peasant.CutTheTree(myfir, CutType.Fully);
            //Срубил он нашу ёлочку
            //Под самый корешок.

            if (myfir.IsElegant())
            {
                //Теперь ты здесь нарядная
            }

            newyear.Tree = myfir;
            //На праздник к нам пришла
            
            newyear.Tree.SetHappyness(newyear.kids); 
            //И много, много радости
            //Детишкам принесла. 

            Console.ReadKey();
        }
    }
}
