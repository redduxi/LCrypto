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

        public ICryptor CreateCryptor(ECryptAlgorithm crypt)
        {
            switch (crypt)
            {
                case ECryptAlgorithm.BlowFish:
                    return new BlowfishAdapter(_blowfishKeyProvider.GetBlowFishKey());
                case ECryptAlgorithm.AES:
                    return null; //_aesKeyProvider
                default:
                    throw new ArgumentOutOfRangeException(nameof(crypt), crypt, null);
            }
        }
    }
}