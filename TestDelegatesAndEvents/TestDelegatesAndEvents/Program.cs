using System;

namespace TestDelegatesAndEvents
{
    /// <summary>
    /// creating a delegate
    /// </summary>
    /// <param name="s"></param>
    delegate void MyDelegate(string s);
    public class Program
    {
        static void Main(string[] args)
        {
            MyDelegate a, b, c, d;

            a=new MyDelegate(Hello);
            a("Bikesh");
            var test=new MyDelegate(Goodbye);
            test("Bikesh");
            //testing calling static 
            Console.WriteLine((Test.Sum(4, 5)));
        }
        public static void Hello(String s)
        {
            Console.WriteLine($"Hello, {s}");
        }
        public static void Goodbye(String s)
        {
            Console.WriteLine($"Goodbye, {s}");
        }
    }

    public static class Test
    {
        public static int Sum(int x, int y) => (x + y);
    }
}
