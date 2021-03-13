using System.Runtime.InteropServices;
using System.Text;
using ConsoleApp1.Libraries.SHA224;

namespace ConsoleApp1.Libraries.SHA256
{
    public class SHA256Adapter : IHashing
    {
        [DllImport("Resources\\SHA256.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void hash(byte[] buf);
        
        public string Hashing(string text)
        {
            byte[] buf = Encoding.ASCII.GetBytes(text);
            SHA256Adapter.hash(buf);
            var hash = Encoding.Default.GetString(buf);

            return hash;
        }
    }
}