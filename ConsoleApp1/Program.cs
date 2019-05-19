using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Parser parser = new Parser();
            var res = parser.TryParse("blabla");
         
            Storage st = new Storage();
            st.Add(res);
            st.DeleteLast();
        }
    }
}
