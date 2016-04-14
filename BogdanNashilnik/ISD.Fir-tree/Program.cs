using ISD.Fir_tree.Classes;
using System;
using System.Collections.Generic;
using static ISD.Fir_tree.Classes.Year;

namespace ISD.Fir_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // В лесу
            var year = new Year();
            var forest = new Forest(year);
            // Родилась ёлочка
            var fir = new Fir("Ёлочка");
            forest.Plant(fir);
            forest.Plant(new Oak());
            // В лесу она росла
            var age = 5;
            forest.Grow(age);
            // Зимой
            Console.WriteLine("Текущее время года: {0}.", year.CurrentSeason);
            // Стройная, зелёная была
            Console.WriteLine(fir.Color);
            Console.WriteLine(fir.Constitution);
            // И летом
            year.NextSeason();
            year.NextSeason();
            Console.WriteLine("Текущее время года: {0}.", year.CurrentSeason);
            // Стройная, зелёная была
            Console.WriteLine(fir.Color);
            Console.WriteLine(fir.Constitution);
            // Метель
            var blizzard = new Blizzard();
            // Ей пела песенку
            var song = new Song("Спи, елочка, бай-бай!");
            blizzard.Sing(song, fir);
            // Мороз
            var frost = new Frost();
            // Снежком укутывал: "Смотри не замерзай!"
            frost.WrapWithSnow(fir);
            // Трусишка зайка серенький
            var bunny = new Bunny("Зайчик", Color.Grey, Bravery.YellowBelly);
            Console.WriteLine(bunny.Bravery);
            Console.WriteLine(bunny.Color);
            // Под ёлочкой
            fir.PutAnimal(bunny);
            // Скакал
            bunny.Move();
            // Порою волк
            var wolf = new Wolf();
            // Сердитый волк
            wolf.Mood = Mood.Angry;
            Console.WriteLine(wolf.Mood);
            // Рысцою пробегал
            fir.PutAnimal(wolf);
            wolf.Move();
            // Чу! Снег по лесу частому 
            // Под полозом скрипит, 
            // Лошадка мохноногая
            // Торопится, бежит. 
            // Везет лошадка дровенки, 
            // A в дровнях старичок,
            var horse = new Horse("Лошадка", Color.Grey, Wooliness.Shaggy);
            Console.WriteLine(horse.FootWooliness);
            horse.PutCart(new WoodSledge());
            var oldMan = new OldMan();
            horse.Cart.Put(oldMan);
            horse.Move();
            // Срубил он нашу ёлочку
            // Под самый корешок.
            horse.Cart.Remove();
            var felledFir = oldMan.CutFirAtTheRoots(fir);
            horse.Cart.Put(felledFir);
            horse.Cart.Put(oldMan);
            // Теперь она нарядная,
            felledFir.Decorate(new ChristmasTreeToy());
            Console.WriteLine(felledFir.Fancy);
            // На праздник
            List<Person> participants = new List<Person>();
            participants.Add(new Kid());
            participants.Add(new Kid());
            var party = new ChristmasParty(participants);
            // к нам пришла
            // И много, много радости
            // Детишкам принесла.
            party.ChristmasTree = felledFir;
            Console.ReadKey();
        }
    }
}
