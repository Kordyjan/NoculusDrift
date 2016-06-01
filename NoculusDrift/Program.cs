using System;
using System.Runtime.InteropServices;
using NoculusDriftInternals;

namespace NoculusDrift {


    class Program
    {
        private const string InternalDll = @"NoculusDriftInternals.dll";

        static void Main(string[] args)
        {
            new Nicpon().TestuTestu(7);
            Console.ReadKey();
        }
    }
}
