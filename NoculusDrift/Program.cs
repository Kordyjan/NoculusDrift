using System;
using System.Runtime.InteropServices;
using System.Threading;
using NoculusDriftInternals;
using TUIO;

namespace NoculusDrift {


    static class Program
    {
        static void Main(string[] args)
        {
            var client = new TuioClient();
            client.addTuioListener(new Listener());
            client.connect();
        }
    }
}
