using System;

namespace ConsoleApp1
{
    public class BlowfishAdapter : ICryptor
    {
        private BlowFish _blowFish;

        public BlowfishAdapter(string keyInHex)
        {
            
            // byte[] byteArrayFromHexString = new byte[keyInHex.Length / 2];
            // for (int i = 0; i < keyInHex.Length; i += 2)
            //     byteArrayFromHexString[i / 2] = Convert.ToByte(keyInHex.Substring(i, 2), 16);
            //
            // Console.WriteLine(byteArrayFromHexString);
            _blowFish = new BlowFish(keyInHex);
        }
        
        public string Encrypt(string text)
        {
            return _blowFish.Encrypt(text);
        }

        public string Decrypt(string text)
        {
            return _blowFish.Decrypt(text);
        }
    }
}