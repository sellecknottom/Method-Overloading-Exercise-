namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
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
            if (c)
            {
                return ((a + b) > 1) ? a + b + "dollars" : "dollar";
            }
            return $"{a + b}";
        }
    }
}
