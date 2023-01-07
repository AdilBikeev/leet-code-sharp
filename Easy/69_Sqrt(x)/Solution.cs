namespace MyNamespace
{
    public class Program
    {
        public static int MySqrt(int x)
        {
            var left = 1;
            var right = x;
            var res = 0;

            while (left <= right)
            {
                var mid = (right + left) / 2;

                if (mid <= x / mid)
                {
                    res = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return res;
        }

        // sqrt(17) = 4
        // sqrt(15) = 3

        public static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(17)); // 4
            Console.WriteLine(MySqrt(15)); // 3
            Console.WriteLine(MySqrt(12)); // 3
            Console.WriteLine(MySqrt(4)); // 2
            Console.WriteLine(MySqrt(1)); // 1
            Console.WriteLine(MySqrt(int.MaxValue)); // 46339
        }
    }
}