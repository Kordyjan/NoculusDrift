using System;
using System.Runtime.InteropServices;
using System.Threading;
using NoculusDriftInternals;
using TUIO;

namespace NoculusDrift {


    class Program
    {
        static void Main(string[] args)
        {
            var input = new Input();
            for (int i = 0; i < 300; ++i)
            {
                Thread.Sleep(10);
                input.MoveMouse(1, 1);
            }
            Console.ReadKey();

            new TuioClient()
        }
    }
}
