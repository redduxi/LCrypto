using System;
using ConsoleApp1;


namespace ExampleTestCryptLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            
            ICryptor cryptor = MyLibraryBuilder.Blowfish;
            
            var encrypt = cryptor.Encrypt(text);
            Console.WriteLine(encrypt);
            
            var decrypt = cryptor.Decrypt(encrypt);
            Console.WriteLine(decrypt);
            
        }
    }
}