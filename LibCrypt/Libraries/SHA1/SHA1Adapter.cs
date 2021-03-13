using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1.Libraries
{
   
    public class SHA1Adapter : IHashing
    {
        [DllImport("Resources\\SHA1.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void hash(byte[] buf);

        private SHA1Adapter _sha1;
        
        public string Hashing(string text)
        {
            byte[] buf = Encoding.ASCII.GetBytes(text);
            SHA1Adapter.hash(buf);
            var hash = Encoding.Default.GetString(buf);

            return hash;
        }
    }
}