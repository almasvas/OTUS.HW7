using System.Diagnostics;

namespace OTUS.HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = { 100_000, 1_000_000, 10_000_000 };
            var calculators = new ISumCalculator[]
            {
            new SimpleSumCalculator(),
            new ParallelSumCalculator(),
            new LinqSumCalculator()
            };

            foreach (var size in sizes)
            {
                int[] array = GenerateArray(size);
                Console.WriteLine($"Размер массива: {size}");

                foreach (var calculator in calculators)
                {
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    int sum = calculator.CalculateSum(array);
                    stopwatch.Stop();
                    Console.WriteLine($"{calculator.GetType().Name}: {stopwatch.ElapsedMilliseconds} ms");
                }
                Console.WriteLine();
            }
        }

        static int[] GenerateArray(int size)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1, 100); // Заполняем массив случайными числами
            }
            return array;
        }
    }
}
