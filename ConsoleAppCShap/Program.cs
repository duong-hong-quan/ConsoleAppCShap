namespace ConsoleAppCShap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Sum = {Add(a,b)}");
            Console.WriteLine($"Sum ={Sum(100)}");
            Console.ReadLine();
        }
        public static int Add(int x, int y)
        => x + y;

        /*
         -Sum
         */

        public static long Sum(int n)
        {
            long total = 0;
            int i = 1;
            while (i <= n)
            {
                if(i% 2 == 0)
                {
                    total += i;

                }
                i++;
            }
            return total;
        }
    }
}