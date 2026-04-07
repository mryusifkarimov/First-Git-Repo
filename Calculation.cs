
namespace GenericTypeExample
{
    public class Calculation
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Sum(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Sum(string a, string b)
        {
            Console.WriteLine(a + b);
        }

        public static void Show<T>(T a)
        {
            Console.WriteLine(a);
        }

        public static void Show<T, Z>(T a, Z b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void ShowObj(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
