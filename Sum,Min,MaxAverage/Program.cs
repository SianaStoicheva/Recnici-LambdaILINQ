namespace Sum_Min_MaxAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = {0}", nums.Sum());
            Console.WriteLine("Min = {0}", nums.Min());
            Console.WriteLine("Max = {0}", nums.Max());
            Console.WriteLine("First Element = {0}", nums.First());
            Console.WriteLine("Last Element = {0}", nums.Last());
            Console.WriteLine("Average = {0:F2}", nums.Average());
        }
    }
}
