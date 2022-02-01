using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Program
    {
        [DllImport("Test")]
        static extern int _NativeFunc();

        static void Main(string[] args)
        {
            Console.WriteLine("[Program.cs] Main");
            int value = _NativeFunc();
            Console.WriteLine("[Program.cs] _NativeFunc returns {0}", value);
        }
    }
}