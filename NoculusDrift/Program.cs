using System;
using System.Runtime.InteropServices;
using System.Threading;
using NoculusDriftInternals;

namespace NoculusDrift {


    class Program
    {
        static void Main(string[] args)
        {
            var input = new Input();
            for (int i = 0; i < 5; ++i)
            {
                Thread.Sleep(2000);
                Console.WriteLine(i);
                Console.WriteLine(input.MoveMouse(100, 100));
            }
            Console.ReadKey();
        }
    }
}
