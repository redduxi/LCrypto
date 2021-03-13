using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1.Libraries.SHA224
{
    public class SHA224Adapter : IHashing
    {
        [DllImport("Resources\\SHA224.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void hash(byte[] buf);
        
        public string Hashing(string text)
        {
            byte[] buf = Encoding.ASCII.GetBytes(text);
            SHA224Adapter.hash(buf);
            var hash = Encoding.Default.GetString(buf);

            return hash;
        }
    }
}