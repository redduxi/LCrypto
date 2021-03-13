using System;

namespace ConsoleApp1
{
    public class BlowfishAdapter : ICryptor
    {
        private BlowFish _blowFish;

        public BlowfishAdapter(string keyInHex)
        {
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