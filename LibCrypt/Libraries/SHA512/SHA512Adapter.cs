using System.Runtime.InteropServices;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1.Libraries.SHA256
{
    public class SHA512Adapter : IHashing
    {
        [DllImport("Resources\\SHA512.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void hash(byte[] buf);

        public string Hashing(string text)
        {
            byte[] buf = Encoding.ASCII.GetBytes(text);
            SHA512Adapter.hash(buf);
            var hash = Encoding.Default.GetString(buf);

            return hash;
        }
    }
}
