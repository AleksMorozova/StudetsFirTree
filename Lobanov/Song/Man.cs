using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    class Man
    {

        public void CutTheTree(Fir aim, CutType type)
        {
            aim.Cut(type);
            Console.WriteLine("Срубил он нашу ёлочку");
            switch (type)
            {
                case CutType.Fully:
                    Console.WriteLine("Под самый корешок.");
                    break;
                case CutType.Half:
                    Console.WriteLine("Как получилось.");
                    break;
                case CutType.Partially:
                    Console.WriteLine("Только обрезал.");
                    break;
                default:
                    Console.WriteLine("Ещё как-то");
                    break;

            }
        }
    }
}
