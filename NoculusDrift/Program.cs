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
                Console.WriteLine(input.SendKey(0x58));
            }
            Console.ReadKey();
        }
    }
}
