using Fundamental.Cardlib;
using Fundamental.PrimesAlgorithem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 集合、枚举、对象的基本应用
            Deck deck = new Deck();
            //deck.Display();
            deck.Shuffle();
            //deck.Display();
            #endregion

            #region 迭代器求素数
            Primes primes = new Primes();
            foreach (long i in primes)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
            #endregion

        }
    }
}
