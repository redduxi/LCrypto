using System;
using ConsoleApp1;
using System.Runtime.InteropServices;
using System.Text;


namespace ExampleTestCryptLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            IHashing c = HashBuilder.SHA256;
            c.Hashing("a");
        }
    }
}