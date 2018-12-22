using System;

namespace demo
{
    class Program
    {
        public Program()
        {
        }

        private void Run() 
        {
            Engine eng = new Engine();
            var v = eng.Multiply(23.0,56.0);

            Console.WriteLine("Hello World: {0:0.00}", v);
        }

        static void Main(string[] args)
        {
            new Program().Run();
        }
    }
}
