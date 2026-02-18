
using System.Xml;

namespace Homework1
{
    internal class tasks
    {
        /// <summary>
        /// функция которая обнуляет разряд десятков в числе
        /// </summary>
        /// <param name="n"></param>
        /// <exception cref="ArgumentException"></exception>
        static void NullDec(ref int n)
        {
            if ((Math.Abs(n) < 100) || (Math.Abs(n) > 999))
                throw new ArgumentException("Число не трехзначное");
            var (a, b, c) = ((n / 100), ((n / 10) % 10), n % 10);
            n = (a * 100) + c;
        }

        static string ChessColor(int x, int y)
        {
            if (((x < 1) || (y < 1)) || ((x > 8) || (y > 8)))
                throw new ArgumentException("координаты доски не в нужном диапазоне");
            if ((x + y) % 2 == 0)
                return "Поле черное";

            return "Поле белое";
        }



        static void Main()
        {
            Console.WriteLine("Введите трехзначное число: ");
            int n = int.Parse(Console.ReadLine());

            NullDec(ref n);
            Console.WriteLine($"Результат: {n}");

            Console.WriteLine("Введите координату x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y: ");
            int y = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine($"{ChessColor(x, y)}");
            }

            catch
            {
                Console.WriteLine("координаты доски не в нужном диапазоне");
            }
        }


    }
}
