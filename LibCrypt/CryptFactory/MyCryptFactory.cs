using System;

namespace ConsoleApp1
{
    public class MyCryptFactory : ICryptFactory
    {
        private IBlowfishKeyProvider _blowfishKeyProvider;
        private readonly IAesKeyProvider _aesKeyProvider;

        public MyCryptFactory(IBlowfishKeyProvider blowfishKeyProvider, IAesKeyProvider aesKeyProvider)
        {
            _blowfishKeyProvider = blowfishKeyProvider;
            _aesKeyProvider = aesKeyProvider;
        }

        public ICryptor CreateCryptor(ECryptAlgorythm crypt)
        {
            switch (crypt)
            {
                case ECryptAlgorythm.BlowFish:
                    return new BlowfishAdapter(_blowfishKeyProvider.GetBlowFishKey());
                case ECryptAlgorythm.AES:
                    return null;//_aesKeyProvider
                default:
                    throw new ArgumentOutOfRangeException(nameof(crypt), crypt, null);
            }
        }
    }
}