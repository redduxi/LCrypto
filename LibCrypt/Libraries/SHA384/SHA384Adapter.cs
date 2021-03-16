using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1.Libraries.SHA384
{
    public class SHA384Adapter : IHashing
    {
        [DllImport("Resources\\SHA384.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void hash(byte[] buf);
        
        public string Hashing(string text)
        {
            byte[] buf = Encoding.ASCII.GetBytes(text);
            SHA384Adapter.hash(buf);
            var hash = Encoding.Default.GetString(buf);

            return hash;
        }
    }
}