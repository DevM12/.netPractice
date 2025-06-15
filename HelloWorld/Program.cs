using System;
Ō
namespace HelloWorld 
{
    class Program
    {
        static void Main()
        {
            //int x = 0;
            //for (int i = 0; i < 10; i++) {

            //    Console.WriteLine(x);
            //    x += i;
            //}
            int x = Square.DoCube(4);
            int y = Square.DoMultiply(4, 5);
            Console.WriteLine($"{x}\n{y}");
            Console.ReadKey();
        }
    }
}