namespace OTUS.HW7
{
    public class ParallelSumCalculator : ISumCalculator
    {
        public int CalculateSum(int[] array)
        {
            int sum = 0;
            Parallel.ForEach(array, (item) =>
            {
                Interlocked.Add(ref sum, item);
            });
            return sum;
        }
    }
}
