namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool c)
        {
            /*if (c == true && a + b > 0)
            {
               return ($"{a + b} dollars");
            }
            else 
            {
                return $"{a + b} dollars";
            }*/
            if (c == true)
            {
                return ((a + b) > 1) ? $"${a + b}" + " dollars" : "$1 dollar";
            }
            return $"{a + b}";
        }
    }
}
