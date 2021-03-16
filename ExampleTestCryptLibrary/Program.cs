using ConsoleApp1;

namespace ExampleTestCryptLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            IHashing sha512 = HashBuilder.SHA512;
            sha512.Hashing("a");
        }
    }
}