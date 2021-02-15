using System.Net.Security;

namespace ConsoleApp1
{
    public interface ICryptor
    {
        string Encrypt(string text);
        string Decrypt(string text);
    }
}