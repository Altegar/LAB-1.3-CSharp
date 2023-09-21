// Сушинський Ігор
// Лабораторна робота № 1.3
// Табулювання функції, заданої формулою: функція однієї змінної.
// Варіант 3

namespace LAB1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double xStart = Convert.ToDouble(Console.ReadLine());
            double xEnd = Convert.ToDouble(Console.ReadLine());
            double dx = Convert.ToDouble(Console.ReadLine());

            double x = xStart;
            double y;
            double A = 2 / x + Math.Abs(x);
            double B;

            Console.WriteLine("=======================");
            Console.WriteLine($"| {"x",8} | {"y",8} |");
            Console.WriteLine("=======================");

            // обчислення
            for (double i = x; x <= xEnd; x += dx)
            {
                if (x < 0)
                    B = 1 + 4 * Math.Pow(x, 2);
                else
                if (x > 2)
                    B = 5 * Math.Sin(Math.Pow(x, 2) + 1);
                else
                    B = Math.Pow(Math.Pow(Math.E, x) + Math.Abs(x), 2);
                y = A + B;

                Console.WriteLine($"| {x,8} | {y,8:F4} |");
                if (x < xEnd)
                    Console.WriteLine("|----------|----------|");
            }
            Console.WriteLine("=======================");
        }
    }
}