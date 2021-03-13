using ConsoleApp1.Libraries;

namespace ConsoleApp1
{
    public class CryptorBuilder
    {
        public static ICryptor Blowfish
        {
            get
            {
                return new MyCryptFactory(new BlowFishConstantKeyProvider(
                        "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"), null)
                    .CreateCryptor(ECryptAlgorithm.BlowFish);
            }
        }

        public static ICryptFactory WithKey(string key)
        {
            return new MyCryptFactory(new BlowFishConstantKeyProvider(key), null);
        }
    }
}