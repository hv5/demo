using System;

namespace demo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Engine eng = new Engine();
            var v = eng.Multiply(23.0,56.0);

            Console.WriteLine("Hello World: {0:0.00}", v);
        }
    }
}
