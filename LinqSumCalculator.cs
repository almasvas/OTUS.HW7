namespace OTUS.HW7
{
    public class LinqSumCalculator : ISumCalculator
    {
        public int CalculateSum(int[] array)
        {
            return array.Sum();
        }
    }
}
