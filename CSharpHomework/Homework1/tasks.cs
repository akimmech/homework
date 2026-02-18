
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

        static void Main()
        {
            Console.WriteLine("Введите трехзначное число: ");
            int n = int.Parse(Console.ReadLine());

            NullDec(ref n);
            Console.WriteLine($"Результат: {n}");
        }
    }
}
